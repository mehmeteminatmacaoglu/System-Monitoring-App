using System;
using System.Data;
using System.Drawing;
using System.Linq;
/**/
using System.Windows.Forms;
using System.Diagnostics;
using System.IO; // Disk bilgilerini okumak için kullanılan kütüphane
using System.Net.NetworkInformation; // Ağ bilgileri için kullanılan kütüphane
using OpenHardwareMonitor.Hardware; // Donanım bilgilerini okumak için kullanılan kütüphane
using System.Data.SqlClient; // Veritabanı bağlantısı için kullanılan kütüphane

namespace SystemMonitoringAppWF
{
    public partial class Main : Form
    {
        private Timer timers; // Zamanlayıcı için nesne
        private Computer GPUMonitor; // GPU için nesne (OpenHardwareMonitor)
        private PerformanceCounter CPUcounter; // CPU için nesne
        private PerformanceCounter RAMcounter; // RAM için nesne
        private PerformanceCounter Diskcounter; // Disk için nesne
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=SystemMonitoringAppDB;Trusted_Connection=True;"; // Veritabanı değişken

        public Main()
        {
            InitializeComponent();

            Timer(); // Zamanlayıcı metodunu çalıştırır
            Counters(); // Counters metodunu çalıştırır
            Info(); // Info metodunu çalıştırır
        }
        private void Timer() // Zamanlayıcı kullanarak metodları 5 saniyede bir çalıştırır
        {
            timers = new Timer(); // Timer nesnesinin ataması yapılır
            timers.Interval = 5000; // 5 saniye
            timers.Tick += (sender, e) =>
            {
                GPU(); // GPU metodunu çalıştırır
                CPU(); // CPU metodunu çalıştırır
                RAM(); // RAM metodunu çalıştırır
                Disk(); // Disk metodunu çalıştırır
                Network(); // Network metodunu çalıştırır
                BGProcess(); // Arkaplanda çalışan uygulama metodunu çalıştırır
            };
            timers.Start(); // Zamanlayıcıyı başlatır
        }
        private void Counters() // PerformansCounter nesnelerini oluşturur
        {
            GPUMonitor = new Computer() { GPUEnabled = true, CPUEnabled = true, RAMEnabled = true, HDDEnabled = true, MainboardEnabled = true }; // Donanımları etkin hale getirir
            GPUMonitor.Open(); // Donanımları açar

            CPUcounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); // CPU nesnesinin ataması yapılır
            RAMcounter = new PerformanceCounter("Memory", "Available MBytes"); // RAM nesnesinin ataması yapılır
            Diskcounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total"); // Disk nesnesinin ataması yapılır
        }
        private void Info() // Kullanıcı Adı, Makine Adı ve İşletim sistemi bilgilerini yazar
        {
            lblUserName.Text = Environment.UserName; // Kullanıcı Adı yazısı
            lblMachineName.Text = Environment.MachineName; // Makine Adı yazısı
            lblOS.Text = Environment.OSVersion.VersionString; // İşletim sistemi bilgileri  Adı yazısı
        }
        private void GPU() // GPU bilgilerini yazar
        {
            if (GPUMonitor == null) return; // GPU mevcut değil ise sonlandırır

            foreach (var hardwareGPU in GPUMonitor.Hardware )
            {
                if (hardwareGPU.HardwareType == HardwareType.GpuNvidia || hardwareGPU.HardwareType == HardwareType.GpuAti) // Kullanıcı ekran kartı kontrolü
                {
                    hardwareGPU.Update(); // Donanım bilgileri güncellenir

                    foreach (var sensor in hardwareGPU.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core")) // GPU kullanım miktarı bilgisi
                        {
                            int gpuValue = (int)(sensor.Value);
                            if (gpuValue > progressBarGPU.Maximum)
                            {
                                gpuValue = progressBarGPU.Maximum; // progressBar için maksimum değer ataması
                            }
                            progressBarGPU.Value = gpuValue; // GPU kullanım miktarını progressBar içinde gösterme
                            lblGPUusage.Text = $"{sensor.Value:F2}%"; // GPU kullanım miktarını yazar
                        }

                        if (sensor.SensorType == SensorType.Fan && sensor.Name.Contains("Fan")) // GPU fan bilgisi
                        {
                            lblFanSpeed.Text = $"{sensor.Name}: {(int)sensor.Value} RPM";
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU")) // GPU fan bilgisi
                        {
                            lblGPUTemp.Text = $"{sensor.Name}: {sensor.Value} °C";
                        }

                        if (sensor.Value > 80) // GPU kullanımı için uyarı
                        {
                            lblWarningGPU.Text = $"GPU usage is too high! {sensor.Value}%";
                        }
                        else
                        {
                            lblWarningGPU.Text = "";
                        }
                    }
                }
            }
        }
        private void CPU() // CPU bilgilerini yazar
        { 
            float CPUusage = CPUcounter.NextValue(); // CPU kullanım miktarı

            int cpuValue = (int)(CPUusage);
            if (cpuValue > progressBarCPU.Maximum)
            {
                cpuValue = progressBarCPU.Maximum; // progressBar için maksimum değer ataması
            }
            progressBarCPU.Value = cpuValue; // CPU kullanım miktarını progressBar içinde gösterme
            lblCPUusage.Text = $"{CPUusage:F2}%"; // CPU kullanım miktarını yazar

            foreach (var hardwareCPU in GPUMonitor.Hardware) // CPU sıcaklık verisin için kullanılan izleyici
            {
                hardwareCPU.Update(); // Donanım bilgilerini günceller

                foreach (var sensor in hardwareCPU.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU")) // Sıcaklık verisi kontrolü
                    {
                        lblCPUTemp.Text = $"{sensor.Name}: {sensor.Value} °C"; // CPU sıcaklığını yazar
                    }
                }
            }

            if (CPUusage > 80) // CPU kullanımı için uyarı
            {
                lblWarningCPU.Text = $"CPU usage is too high! {CPUusage}%";
            }
            else
            {
                lblWarningCPU.Text = "";
            }
        }
        private void RAM() // RAM bilgilerini yazar
        {
            float RAMusage = RAMcounter.NextValue(); // Boşta olan RAM miktarı

            lblRAMusage.Text = $"{(RAMusage / 1024):F2} GB"; // Kullanıcıya gösterme (GB cinsinden)
        }
        private void Disk() // Disk bilgilerini yazar
        {
            float Diskusage = Diskcounter.NextValue(); // Disk kullanım miktarı

            int diskValue = (int)(Diskusage);
            if (diskValue > progressBarDisk.Maximum)
            {
                diskValue = progressBarDisk.Maximum; // progressBar için maksimum değer ataması
            }
            progressBarDisk.Value = diskValue; // Disk kullanım miktarını progressBar içinde gösterme
            lblDiskUsage.Text = $"{Diskusage:F2}%"; // Disk kullanım miktarını yazar

            foreach (var disk in DriveInfo.GetDrives())
            {
                long usedSpace = (disk.TotalSize) - (disk.TotalFreeSpace);
                lblDriver.Text = $"{disk.Name} - {usedSpace / 1024 / 1024 / 1024} GB / {disk.TotalSize / 1024 /1024 / 1024} GB"; // Driver Bilgilerini yazar
            }
        }
        private void Network() // Network bilgilerini yazar
        {
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (network.OperationalStatus == OperationalStatus.Up) // Çalışan ağ bağlantısı kontrolü
                {
                    var stats = network.GetIPv4Statistics();
                    lblNetworkStatus.Text = $"Sent: {stats.BytesSent / 1024 / 1024} MB / Received  {stats.BytesReceived / 1024 / 1024} MB";
                    return; // Aktif bağlantıyı bulduktan sonra işlemi durdurur
                }
            }
            lblNetworkStatus.Text = "No network"; // Ağ bağlantısı yoksa mesaj döndürür
        }
        private void BGProcess() // Arkaplanda çalışan uygulamaların bilgilerini yazar
        {
            var processes = Process.GetProcesses() // Çalışan tüm süreçleri alır
                .OrderByDescending(p => p.WorkingSet64) // Bellek kullanımına göre sırala
                .Take(5); // İlk 5 i alır

            listBoxProcess.Items.Clear(); // listBoxProcess kutusunu temizler

            foreach (var process in processes)
            {
                listBoxProcess.Items.Add($"{process.ProcessName} - {process.WorkingSet64 / 1024 / 1024} MB"); // Aldığı süreçleri yazdırır
            }
        }
        private void SQL() // SQL bilgilerini alır
        {
            // Başlangıç değerleri
            float GPUusage = 0, GPUTemp = 0, CPUusage = 0, CPUTemp = 0, RAMusage = 0, Diskusage = 0; 
            long NetworkSent = 0, NetworkReceived = 0;

            // GPU bilgileri
            foreach (var hardware in GPUMonitor.Hardware) // GPU sıcaklık ve fan verisi için kullanılan izleyici
            {
                hardware.Update();

                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core"))
                    {
                        GPUusage = sensor.Value.HasValue ? sensor.Value.Value : 0;
                    }

                    if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU")) // GPU fan bilgisi
                    {
                        GPUTemp = sensor.Value.HasValue ? sensor.Value.Value : 0;
                    }
                }
            }

            CPUusage = CPUcounter.NextValue(); // CPU bilgileri
            foreach (var hardwareCPU in GPUMonitor.Hardware) // CPU sıcaklık verisin için kullanılan izleyici
            {
                hardwareCPU.Update(); // Donanım bilgilerini günceller

                foreach (var sensor in hardwareCPU.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU")) // Sıcaklık verisi kontrolü
                    {
                        CPUTemp = sensor.Value.HasValue ? sensor.Value.Value : 0;
                    }
                }
            }

            RAMusage = (RAMcounter.NextValue() / 1024); // RAM bilgileri
            Diskusage = Diskcounter.NextValue(); // Disk bilgileri

            // Network bilgileri
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (network.OperationalStatus == OperationalStatus.Up)
                {
                    var stats = network.GetIPv4Statistics();
                    NetworkSent += stats.BytesSent;
                    NetworkReceived += stats.BytesReceived;
                }
            }

            // Network bilgilerini MB cinsine çevirme
            NetworkSent /= (1024 * 1024);
            NetworkReceived /= (1024 * 1024);

            // Verileri Veritabanına gönderme
            InsertSQLData(GPUusage, GPUTemp, CPUusage, CPUTemp, RAMusage, Diskusage, NetworkSent, NetworkReceived);
        }
        private void InsertSQLData(float GPU, float GPUTemp, float CPU, float CPUTemp, float RAM, float Disk, long NetworkSent, long NetworkReceived) // SQL bilgilerini yazar
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO SystemStats (GPU_Usage, GPU_Temp, CPU_Usage, CPU_Temp, RAM_Usage, Disk_Usage, Network_Sent, Network_Received) " + "VALUES (@GPU, @GPUT, @CPU, @CPUT, @RAM, @Disk, @Sent, @Received);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GPU", GPU);
                        cmd.Parameters.AddWithValue("@GPUT", GPUTemp);
                        cmd.Parameters.AddWithValue("@CPU", CPU);
                        cmd.Parameters.AddWithValue("@CPUT", CPUTemp);
                        cmd.Parameters.AddWithValue("@RAM", RAM);
                        cmd.Parameters.AddWithValue("@Disk", Disk);
                        cmd.Parameters.AddWithValue("@Sent", NetworkSent);
                        cmd.Parameters.AddWithValue("@Received", NetworkReceived);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                SQL();
                MessageBox.Show("System data added to database", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mehmeteminatmacaoglu");
        }
        private void btnLightMode_Click(object sender, EventArgs e)
        {
            panelMain.BackColor = Color.FromArgb(57, 86, 137);
            TopPanel.BackColor = Color.FromArgb(36, 63, 110);
            LeftPanel.BackColor = Color.FromArgb(36, 63, 110);

            GPUpanel.BackColor = Color.FromArgb(239, 239, 239);
            CPUpanel.BackColor = Color.FromArgb(239, 239, 239);
            RAMpanel.BackColor = Color.FromArgb(239, 239, 239);
            Diskpanel.BackColor = Color.FromArgb(239, 239, 239);
            Networkspanel.BackColor = Color.FromArgb(239, 239, 239);
            BGpanel.BackColor = Color.FromArgb(239, 239, 239);
            Infopanel.BackColor = Color.FromArgb(239, 239, 239);

            lblGPU.ForeColor = Color.FromArgb(30, 30, 30);
            lblGPUTemp.ForeColor = Color.FromArgb(30, 30, 30);
            lblGPUusage.ForeColor = Color.FromArgb(30, 30, 30);
            lblFanSpeed.ForeColor = Color.FromArgb(30, 30, 30);

            lblCPU.ForeColor = Color.FromArgb(30, 30, 30);
            lblCPUTemp.ForeColor = Color.FromArgb(30, 30, 30);
            lblCPUusage.ForeColor = Color.FromArgb(30, 30, 30);

            lblRAM.ForeColor = Color.FromArgb(30, 30, 30);
            lblRAMusage.ForeColor = Color.FromArgb(30, 30, 30);

            lblDisk.ForeColor = Color.FromArgb(30, 30, 30);
            lblDiskUsage.ForeColor = Color.FromArgb(30, 30, 30);
            lblDriver.ForeColor = Color.FromArgb(30, 30, 30);

            lblNetwork.ForeColor = Color.FromArgb(30, 30, 30);
            lblNetworkStatus.ForeColor = Color.FromArgb(30, 30, 30);

            lblBG.ForeColor = Color.FromArgb(30, 30, 30);

            lblUserName.ForeColor = Color.FromArgb(30, 30, 30);
            lblMachineName.ForeColor = Color.FromArgb(30, 30, 30);
            lblOS.ForeColor = Color.FromArgb(30, 30, 30);
        }
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            panelMain.BackColor = Color.FromArgb(35, 38, 43);
            TopPanel.BackColor = Color.FromArgb(30, 35, 39);
            LeftPanel.BackColor = Color.FromArgb(30, 35, 39);

            GPUpanel.BackColor = Color.FromArgb(43, 47, 52);
            CPUpanel.BackColor = Color.FromArgb(43, 47, 52);
            RAMpanel.BackColor = Color.FromArgb(43, 47, 52);
            Diskpanel.BackColor = Color.FromArgb(43, 47, 52);
            Networkspanel.BackColor = Color.FromArgb(43, 47, 52);
            BGpanel.BackColor = Color.FromArgb(43, 47, 52);
            Infopanel.BackColor = Color.FromArgb(43, 47, 52);

            lblGPU.ForeColor = Color.FromArgb(255, 255, 255);
            lblGPUTemp.ForeColor = Color.FromArgb(255, 255, 255);
            lblGPUusage.ForeColor = Color.FromArgb(255, 255, 255);
            lblFanSpeed.ForeColor = Color.FromArgb(255, 255, 255);

            lblCPU.ForeColor = Color.FromArgb(255, 255, 255);
            lblCPUTemp.ForeColor = Color.FromArgb(255, 255, 255);
            lblCPUusage.ForeColor = Color.FromArgb(255, 255, 255);

            lblRAM.ForeColor = Color.FromArgb(255, 255, 255);
            lblRAMusage.ForeColor = Color.FromArgb(255, 255, 255);

            lblDisk.ForeColor = Color.FromArgb(255, 255, 255);
            lblDiskUsage.ForeColor = Color.FromArgb(255, 255, 255);
            lblDriver.ForeColor = Color.FromArgb(255, 255, 255);

            lblNetwork.ForeColor = Color.FromArgb(255, 255, 255);
            lblNetworkStatus.ForeColor = Color.FromArgb(255, 255, 255);

            lblBG.ForeColor = Color.FromArgb(255, 255, 255);

            lblUserName.ForeColor = Color.FromArgb(255, 255, 255);
            lblMachineName.ForeColor = Color.FromArgb(255, 255, 255);
            lblOS.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}