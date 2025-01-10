namespace SystemMonitoringAppWF
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblWarningGPU = new System.Windows.Forms.Label();
            this.lblWarningCPU = new System.Windows.Forms.Label();
            this.lblSystemMonitoring = new System.Windows.Forms.Label();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnLightMode = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.CPUpanel = new System.Windows.Forms.Panel();
            this.lblCPUTemp = new System.Windows.Forms.Label();
            this.lblCPUusage = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.RAMpanel = new System.Windows.Forms.Panel();
            this.lblRAMusage = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.Diskpanel = new System.Windows.Forms.Panel();
            this.progressBarDisk = new System.Windows.Forms.ProgressBar();
            this.lblDiskUsage = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblDisk = new System.Windows.Forms.Label();
            this.Networkspanel = new System.Windows.Forms.Panel();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.GPUpanel = new System.Windows.Forms.Panel();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.lblGPUusage = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.progressBarGPU = new System.Windows.Forms.ProgressBar();
            this.lblGPU = new System.Windows.Forms.Label();
            this.Infopanel = new System.Windows.Forms.Panel();
            this.btnDataBase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGithub = new System.Windows.Forms.Button();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.BGpanel = new System.Windows.Forms.Panel();
            this.listBoxProcess = new System.Windows.Forms.ListBox();
            this.lblBG = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.CPUpanel.SuspendLayout();
            this.RAMpanel.SuspendLayout();
            this.Diskpanel.SuspendLayout();
            this.Networkspanel.SuspendLayout();
            this.GPUpanel.SuspendLayout();
            this.Infopanel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.BGpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.TopPanel.Controls.Add(this.lblWarningGPU);
            this.TopPanel.Controls.Add(this.lblWarningCPU);
            this.TopPanel.Controls.Add(this.lblSystemMonitoring);
            this.TopPanel.Controls.Add(this.btnDarkMode);
            this.TopPanel.Controls.Add(this.btnLightMode);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(789, 60);
            this.TopPanel.TabIndex = 0;
            // 
            // lblWarningGPU
            // 
            this.lblWarningGPU.AutoSize = true;
            this.lblWarningGPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarningGPU.ForeColor = System.Drawing.Color.White;
            this.lblWarningGPU.Location = new System.Drawing.Point(407, 19);
            this.lblWarningGPU.Name = "lblWarningGPU";
            this.lblWarningGPU.Size = new System.Drawing.Size(18, 23);
            this.lblWarningGPU.TabIndex = 13;
            this.lblWarningGPU.Text = "x";
            // 
            // lblWarningCPU
            // 
            this.lblWarningCPU.AutoSize = true;
            this.lblWarningCPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarningCPU.ForeColor = System.Drawing.Color.White;
            this.lblWarningCPU.Location = new System.Drawing.Point(424, 19);
            this.lblWarningCPU.Name = "lblWarningCPU";
            this.lblWarningCPU.Size = new System.Drawing.Size(18, 23);
            this.lblWarningCPU.TabIndex = 3;
            this.lblWarningCPU.Text = "x";
            // 
            // lblSystemMonitoring
            // 
            this.lblSystemMonitoring.AutoSize = true;
            this.lblSystemMonitoring.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSystemMonitoring.ForeColor = System.Drawing.Color.White;
            this.lblSystemMonitoring.Location = new System.Drawing.Point(3, 15);
            this.lblSystemMonitoring.Name = "lblSystemMonitoring";
            this.lblSystemMonitoring.Size = new System.Drawing.Size(176, 26);
            this.lblSystemMonitoring.TabIndex = 12;
            this.lblSystemMonitoring.Text = "System Monitoring";
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Location = new System.Drawing.Point(712, 19);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(60, 23);
            this.btnDarkMode.TabIndex = 11;
            this.btnDarkMode.Text = "Dark";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnLightMode
            // 
            this.btnLightMode.Location = new System.Drawing.Point(646, 19);
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Size = new System.Drawing.Size(60, 23);
            this.btnLightMode.TabIndex = 9;
            this.btnLightMode.Text = "Light";
            this.btnLightMode.UseVisualStyleBackColor = true;
            this.btnLightMode.Click += new System.EventHandler(this.btnLightMode_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.LeftPanel.Controls.Add(this.btnHome);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 60);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(75, 501);
            this.LeftPanel.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(8, 239);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 23);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // CPUpanel
            // 
            this.CPUpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.CPUpanel.Controls.Add(this.lblCPUTemp);
            this.CPUpanel.Controls.Add(this.lblCPUusage);
            this.CPUpanel.Controls.Add(this.progressBarCPU);
            this.CPUpanel.Controls.Add(this.lblCPU);
            this.CPUpanel.Location = new System.Drawing.Point(438, 68);
            this.CPUpanel.Name = "CPUpanel";
            this.CPUpanel.Size = new System.Drawing.Size(341, 100);
            this.CPUpanel.TabIndex = 2;
            // 
            // lblCPUTemp
            // 
            this.lblCPUTemp.AutoSize = true;
            this.lblCPUTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblCPUTemp.Location = new System.Drawing.Point(4, 68);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(34, 23);
            this.lblCPUTemp.TabIndex = 3;
            this.lblCPUTemp.Text = "0 C";
            // 
            // lblCPUusage
            // 
            this.lblCPUusage.AutoSize = true;
            this.lblCPUusage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPUusage.ForeColor = System.Drawing.Color.White;
            this.lblCPUusage.Location = new System.Drawing.Point(261, 36);
            this.lblCPUusage.Name = "lblCPUusage";
            this.lblCPUusage.Size = new System.Drawing.Size(73, 23);
            this.lblCPUusage.TabIndex = 2;
            this.lblCPUusage.Text = "00,00 %";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(8, 36);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(247, 23);
            this.progressBarCPU.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(3, 3);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(42, 23);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "CPU";
            // 
            // RAMpanel
            // 
            this.RAMpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.RAMpanel.Controls.Add(this.lblRAMusage);
            this.RAMpanel.Controls.Add(this.lblRAM);
            this.RAMpanel.Location = new System.Drawing.Point(84, 181);
            this.RAMpanel.Name = "RAMpanel";
            this.RAMpanel.Size = new System.Drawing.Size(341, 100);
            this.RAMpanel.TabIndex = 3;
            // 
            // lblRAMusage
            // 
            this.lblRAMusage.AutoSize = true;
            this.lblRAMusage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRAMusage.ForeColor = System.Drawing.Color.White;
            this.lblRAMusage.Location = new System.Drawing.Point(4, 48);
            this.lblRAMusage.Name = "lblRAMusage";
            this.lblRAMusage.Size = new System.Drawing.Size(46, 23);
            this.lblRAMusage.TabIndex = 2;
            this.lblRAMusage.Text = "0 GB";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRAM.ForeColor = System.Drawing.Color.White;
            this.lblRAM.Location = new System.Drawing.Point(3, 3);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(50, 23);
            this.lblRAM.TabIndex = 0;
            this.lblRAM.Text = "RAM";
            // 
            // Diskpanel
            // 
            this.Diskpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.Diskpanel.Controls.Add(this.progressBarDisk);
            this.Diskpanel.Controls.Add(this.lblDiskUsage);
            this.Diskpanel.Controls.Add(this.lblDriver);
            this.Diskpanel.Controls.Add(this.lblDisk);
            this.Diskpanel.Location = new System.Drawing.Point(438, 181);
            this.Diskpanel.Name = "Diskpanel";
            this.Diskpanel.Size = new System.Drawing.Size(341, 100);
            this.Diskpanel.TabIndex = 4;
            // 
            // progressBarDisk
            // 
            this.progressBarDisk.Location = new System.Drawing.Point(8, 36);
            this.progressBarDisk.Name = "progressBarDisk";
            this.progressBarDisk.Size = new System.Drawing.Size(247, 23);
            this.progressBarDisk.TabIndex = 4;
            // 
            // lblDiskUsage
            // 
            this.lblDiskUsage.AutoSize = true;
            this.lblDiskUsage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiskUsage.ForeColor = System.Drawing.Color.White;
            this.lblDiskUsage.Location = new System.Drawing.Point(261, 36);
            this.lblDiskUsage.Name = "lblDiskUsage";
            this.lblDiskUsage.Size = new System.Drawing.Size(20, 23);
            this.lblDiskUsage.TabIndex = 3;
            this.lblDiskUsage.Text = "0";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDriver.ForeColor = System.Drawing.Color.White;
            this.lblDriver.Location = new System.Drawing.Point(4, 68);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(32, 23);
            this.lblDriver.TabIndex = 2;
            this.lblDriver.Text = "C:\\";
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisk.ForeColor = System.Drawing.Color.White;
            this.lblDisk.Location = new System.Drawing.Point(3, 3);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(46, 23);
            this.lblDisk.TabIndex = 0;
            this.lblDisk.Text = "DISK";
            // 
            // Networkspanel
            // 
            this.Networkspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.Networkspanel.Controls.Add(this.lblNetworkStatus);
            this.Networkspanel.Controls.Add(this.lblNetwork);
            this.Networkspanel.Location = new System.Drawing.Point(84, 296);
            this.Networkspanel.Name = "Networkspanel";
            this.Networkspanel.Size = new System.Drawing.Size(341, 100);
            this.Networkspanel.TabIndex = 5;
            // 
            // lblNetworkStatus
            // 
            this.lblNetworkStatus.AutoSize = true;
            this.lblNetworkStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetworkStatus.ForeColor = System.Drawing.Color.White;
            this.lblNetworkStatus.Location = new System.Drawing.Point(4, 48);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.Size = new System.Drawing.Size(137, 23);
            this.lblNetworkStatus.TabIndex = 2;
            this.lblNetworkStatus.Text = "Sent: / Received:";
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetwork.ForeColor = System.Drawing.Color.White;
            this.lblNetwork.Location = new System.Drawing.Point(3, 3);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(88, 23);
            this.lblNetwork.TabIndex = 0;
            this.lblNetwork.Text = "Networks";
            // 
            // GPUpanel
            // 
            this.GPUpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.GPUpanel.Controls.Add(this.lblFanSpeed);
            this.GPUpanel.Controls.Add(this.lblGPUusage);
            this.GPUpanel.Controls.Add(this.lblGPUTemp);
            this.GPUpanel.Controls.Add(this.progressBarGPU);
            this.GPUpanel.Controls.Add(this.lblGPU);
            this.GPUpanel.Location = new System.Drawing.Point(84, 68);
            this.GPUpanel.Name = "GPUpanel";
            this.GPUpanel.Size = new System.Drawing.Size(341, 100);
            this.GPUpanel.TabIndex = 3;
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.AutoSize = true;
            this.lblFanSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFanSpeed.ForeColor = System.Drawing.Color.White;
            this.lblFanSpeed.Location = new System.Drawing.Point(168, 68);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(71, 23);
            this.lblFanSpeed.TabIndex = 5;
            this.lblFanSpeed.Text = "/ 0 RPM";
            // 
            // lblGPUusage
            // 
            this.lblGPUusage.AutoSize = true;
            this.lblGPUusage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGPUusage.ForeColor = System.Drawing.Color.White;
            this.lblGPUusage.Location = new System.Drawing.Point(261, 36);
            this.lblGPUusage.Name = "lblGPUusage";
            this.lblGPUusage.Size = new System.Drawing.Size(73, 23);
            this.lblGPUusage.TabIndex = 4;
            this.lblGPUusage.Text = "00,00 %";
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblGPUTemp.Location = new System.Drawing.Point(4, 68);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(34, 23);
            this.lblGPUTemp.TabIndex = 2;
            this.lblGPUTemp.Text = "0 C";
            // 
            // progressBarGPU
            // 
            this.progressBarGPU.Location = new System.Drawing.Point(8, 36);
            this.progressBarGPU.Name = "progressBarGPU";
            this.progressBarGPU.Size = new System.Drawing.Size(247, 23);
            this.progressBarGPU.TabIndex = 1;
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGPU.ForeColor = System.Drawing.Color.White;
            this.lblGPU.Location = new System.Drawing.Point(3, 3);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(44, 23);
            this.lblGPU.TabIndex = 0;
            this.lblGPU.Text = "GPU";
            // 
            // Infopanel
            // 
            this.Infopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.Infopanel.Controls.Add(this.btnDataBase);
            this.Infopanel.Controls.Add(this.label2);
            this.Infopanel.Controls.Add(this.btnGithub);
            this.Infopanel.Controls.Add(this.lblOS);
            this.Infopanel.Controls.Add(this.lblMachineName);
            this.Infopanel.Controls.Add(this.lblUserName);
            this.Infopanel.Location = new System.Drawing.Point(84, 449);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(695, 100);
            this.Infopanel.TabIndex = 6;
            // 
            // btnDataBase
            // 
            this.btnDataBase.Location = new System.Drawing.Point(619, 7);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(69, 23);
            this.btnDataBase.TabIndex = 10;
            this.btnDataBase.Text = "DataBase";
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(551, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(628, 73);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(60, 23);
            this.btnGithub.TabIndex = 9;
            this.btnGithub.Text = "GitHub";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOS.ForeColor = System.Drawing.Color.White;
            this.lblOS.Location = new System.Drawing.Point(4, 73);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(96, 23);
            this.lblOS.TabIndex = 4;
            this.lblOS.Text = "OS Version";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMachineName.ForeColor = System.Drawing.Color.White;
            this.lblMachineName.Location = new System.Drawing.Point(4, 38);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(130, 23);
            this.lblMachineName.TabIndex = 3;
            this.lblMachineName.Text = "Machine Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(4, 4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 23);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.BGpanel);
            this.panelMain.Location = new System.Drawing.Point(74, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(715, 501);
            this.panelMain.TabIndex = 7;
            // 
            // BGpanel
            // 
            this.BGpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.BGpanel.Controls.Add(this.listBoxProcess);
            this.BGpanel.Controls.Add(this.lblBG);
            this.BGpanel.Location = new System.Drawing.Point(364, 236);
            this.BGpanel.Name = "BGpanel";
            this.BGpanel.Size = new System.Drawing.Size(341, 100);
            this.BGpanel.TabIndex = 6;
            // 
            // listBoxProcess
            // 
            this.listBoxProcess.FormattingEnabled = true;
            this.listBoxProcess.ItemHeight = 14;
            this.listBoxProcess.Location = new System.Drawing.Point(8, 36);
            this.listBoxProcess.Name = "listBoxProcess";
            this.listBoxProcess.Size = new System.Drawing.Size(326, 60);
            this.listBoxProcess.TabIndex = 3;
            // 
            // lblBG
            // 
            this.lblBG.AutoSize = true;
            this.lblBG.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBG.ForeColor = System.Drawing.Color.White;
            this.lblBG.Location = new System.Drawing.Point(3, 3);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(168, 23);
            this.lblBG.TabIndex = 0;
            this.lblBG.Text = "Background Process";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(789, 561);
            this.Controls.Add(this.Infopanel);
            this.Controls.Add(this.GPUpanel);
            this.Controls.Add(this.Networkspanel);
            this.Controls.Add(this.Diskpanel);
            this.Controls.Add(this.RAMpanel);
            this.Controls.Add(this.CPUpanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.CPUpanel.ResumeLayout(false);
            this.CPUpanel.PerformLayout();
            this.RAMpanel.ResumeLayout(false);
            this.RAMpanel.PerformLayout();
            this.Diskpanel.ResumeLayout(false);
            this.Diskpanel.PerformLayout();
            this.Networkspanel.ResumeLayout(false);
            this.Networkspanel.PerformLayout();
            this.GPUpanel.ResumeLayout(false);
            this.GPUpanel.PerformLayout();
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.BGpanel.ResumeLayout(false);
            this.BGpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelGPU;
        private System.Windows.Forms.Panel panelRAM;
        private System.Windows.Forms.Panel panelDisk;
        private System.Windows.Forms.Label labelSystemM;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressGPU;
        private System.Diagnostics.PerformanceCounter performanceGPU;
        private System.Diagnostics.PerformanceCounter performanceRAM;
        private System.Diagnostics.PerformanceCounter performanceDisk;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel CPUpanel;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblCPUusage;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.Panel RAMpanel;
        private System.Windows.Forms.Label lblRAMusage;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Panel Diskpanel;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Panel Networkspanel;
        private System.Windows.Forms.Label lblNetworkStatus;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel GPUpanel;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.ProgressBar progressBarGPU;
        private System.Windows.Forms.Label lblDiskUsage;
        private System.Windows.Forms.ProgressBar progressBarDisk;
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLightMode;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Label lblCPUTemp;
        private System.Windows.Forms.Label lblSystemMonitoring;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblWarningCPU;
        private System.Windows.Forms.Label lblGPUusage;
        private System.Windows.Forms.Panel BGpanel;
        private System.Windows.Forms.ListBox listBoxProcess;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnDataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarningGPU;
        internal System.Windows.Forms.Label lblFanSpeed;
    }
}

