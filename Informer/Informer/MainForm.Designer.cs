namespace Informer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SecretTextBox = new System.Windows.Forms.TextBox();
            this.RigTextBox = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSecret = new System.Windows.Forms.Label();
            this.labelRigName = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.labelTimeWork = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GetTempretureTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AutoStartTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckNewVersionTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeWorkTimer = new System.Windows.Forms.Timer(this.components);
            this.btSettings = new System.Windows.Forms.Button();
            this.GPUTempMaxTimer = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.GPUTempMinTimer = new System.Windows.Forms.Timer(this.components);
            this.ReloadMinerTimer = new System.Windows.Forms.Timer(this.components);
            this.InformationLabel = new System.Windows.Forms.Label();
            this.labelStatusTempMax = new System.Windows.Forms.Label();
            this.labelTimeWork2 = new System.Windows.Forms.Label();
            this.GPUFanMaxTimer = new System.Windows.Forms.Timer(this.components);
            this.GPUFanMinTImer = new System.Windows.Forms.Timer(this.components);
            this.labelCounterTempMax = new System.Windows.Forms.Label();
            this.labelTempMax = new System.Windows.Forms.Label();
            this.SendDataTimer = new System.Windows.Forms.Timer(this.components);
            this.labelFanMax = new System.Windows.Forms.Label();
            this.labelStatusTempMin = new System.Windows.Forms.Label();
            this.labelCounterTempMin = new System.Windows.Forms.Label();
            this.labelTempMin = new System.Windows.Forms.Label();
            this.labelReloadFile = new System.Windows.Forms.Label();
            this.labelStatusReloadFile = new System.Windows.Forms.Label();
            this.labelCounterReloadFile = new System.Windows.Forms.Label();
            this.labelFanMin = new System.Windows.Forms.Label();
            this.labelStatusFanMax = new System.Windows.Forms.Label();
            this.labelCounterFanMax = new System.Windows.Forms.Label();
            this.labelStatusFanMin = new System.Windows.Forms.Label();
            this.labelCounterFanMin = new System.Windows.Forms.Label();
            this.GPUCoreMinTimer = new System.Windows.Forms.Timer(this.components);
            this.GPUMemMinTimer = new System.Windows.Forms.Timer(this.components);
            this.labelClock = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelStatusClock = new System.Windows.Forms.Label();
            this.labelCounterClock = new System.Windows.Forms.Label();
            this.labelStatusMemory = new System.Windows.Forms.Label();
            this.labelCounterMemory = new System.Windows.Forms.Label();
            this.PingInternetTimer = new System.Windows.Forms.Timer(this.components);
            this.labelInternetPing = new System.Windows.Forms.Label();
            this.labelStatusInternetPing = new System.Windows.Forms.Label();
            this.DontHaveInternetTimer = new System.Windows.Forms.Timer(this.components);
            this.FellOffGPUTimer = new System.Windows.Forms.Timer(this.components);
            this.labelFellOffGPU = new System.Windows.Forms.Label();
            this.labelStatusFellOffGPU = new System.Windows.Forms.Label();
            this.labelCounerFellOff = new System.Windows.Forms.Label();
            this.labelInternet = new System.Windows.Forms.Label();
            this.labelStatusInternet = new System.Windows.Forms.Label();
            this.label3CounterInternet = new System.Windows.Forms.Label();
            this.labelCounterLoadGPU = new System.Windows.Forms.Label();
            this.labelStatusLoadGPU = new System.Windows.Forms.Label();
            this.labelLoadGPU = new System.Windows.Forms.Label();
            this.GPULoadMin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(111, 6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(218, 20);
            this.EmailTextBox.TabIndex = 0;
            // 
            // SecretTextBox
            // 
            this.SecretTextBox.Location = new System.Drawing.Point(111, 32);
            this.SecretTextBox.Name = "SecretTextBox";
            this.SecretTextBox.Size = new System.Drawing.Size(218, 20);
            this.SecretTextBox.TabIndex = 1;
            // 
            // RigTextBox
            // 
            this.RigTextBox.Location = new System.Drawing.Point(111, 58);
            this.RigTextBox.Name = "RigTextBox";
            this.RigTextBox.Size = new System.Drawing.Size(218, 20);
            this.RigTextBox.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(32, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelSecret
            // 
            this.labelSecret.AutoSize = true;
            this.labelSecret.Location = new System.Drawing.Point(32, 35);
            this.labelSecret.Name = "labelSecret";
            this.labelSecret.Size = new System.Drawing.Size(41, 13);
            this.labelSecret.TabIndex = 4;
            this.labelSecret.Text = "Secret:";
            // 
            // labelRigName
            // 
            this.labelRigName.AutoSize = true;
            this.labelRigName.Location = new System.Drawing.Point(31, 65);
            this.labelRigName.Name = "labelRigName";
            this.labelRigName.Size = new System.Drawing.Size(55, 13);
            this.labelRigName.TabIndex = 5;
            this.labelRigName.Text = "Rig name:";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(111, 383);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(190, 30);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Запустить";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStartClick);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(111, 419);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(190, 25);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Остановить";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.BtStopClick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(31, 93);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(76, 13);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Информация:";
            // 
            // labelTimeWork
            // 
            this.labelTimeWork.AutoSize = true;
            this.labelTimeWork.Location = new System.Drawing.Point(31, 115);
            this.labelTimeWork.Name = "labelTimeWork";
            this.labelTimeWork.Size = new System.Drawing.Size(83, 13);
            this.labelTimeWork.TabIndex = 9;
            this.labelTimeWork.Text = "Время работы:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(108, 476);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Обновления:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GetTempretureTimer
            // 
            this.GetTempretureTimer.Interval = 1000;
            this.GetTempretureTimer.Tag = "get temp";
            this.GetTempretureTimer.Tick += new System.EventHandler(this.GetTempretureTimerTick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300000;
            this.timer2.Tag = "active 1 timer";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AutoStartTimer
            // 
            this.AutoStartTimer.Interval = 1000;
            this.AutoStartTimer.Tag = "reverse time";
            this.AutoStartTimer.Tick += new System.EventHandler(this.AutoStart_Tick);
            // 
            // CheckNewVersionTimer
            // 
            this.CheckNewVersionTimer.Enabled = true;
            this.CheckNewVersionTimer.Interval = 600000;
            this.CheckNewVersionTimer.Tag = "update";
            this.CheckNewVersionTimer.Tick += new System.EventHandler(this.CheckNewVersionTimerTick);
            // 
            // TimeWorkTimer
            // 
            this.TimeWorkTimer.Interval = 60000;
            this.TimeWorkTimer.Tag = "time active";
            this.TimeWorkTimer.Tick += new System.EventHandler(this.UptimeTimerTick);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(111, 450);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(190, 23);
            this.btSettings.TabIndex = 12;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.BtnOpenSettingsFormClick);
            // 
            // GPUTempMaxTimer
            // 
            this.GPUTempMaxTimer.Interval = 1000;
            this.GPUTempMaxTimer.Tag = "t_max";
            this.GPUTempMaxTimer.Tick += new System.EventHandler(this.TempretureTimerTick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // GPUTempMinTimer
            // 
            this.GPUTempMinTimer.Interval = 1000;
            this.GPUTempMinTimer.Tag = "t_min";
            this.GPUTempMinTimer.Tick += new System.EventHandler(this.LowTempretureTimerTick);
            // 
            // ReloadMinerTimer
            // 
            this.ReloadMinerTimer.Interval = 1000;
            this.ReloadMinerTimer.Tag = "r_min";
            this.ReloadMinerTimer.Tick += new System.EventHandler(this.RerunTimerTick);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(114, 93);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(106, 13);
            this.InformationLabel.TabIndex = 14;
            this.InformationLabel.Text = "                                 ";
            // 
            // labelStatusTempMax
            // 
            this.labelStatusTempMax.AutoSize = true;
            this.labelStatusTempMax.Location = new System.Drawing.Point(158, 160);
            this.labelStatusTempMax.Name = "labelStatusTempMax";
            this.labelStatusTempMax.Size = new System.Drawing.Size(49, 13);
            this.labelStatusTempMax.TabIndex = 15;
            this.labelStatusTempMax.Text = "              ";
            // 
            // labelTimeWork2
            // 
            this.labelTimeWork2.AutoSize = true;
            this.labelTimeWork2.Location = new System.Drawing.Point(134, 115);
            this.labelTimeWork2.Name = "labelTimeWork2";
            this.labelTimeWork2.Size = new System.Drawing.Size(137, 13);
            this.labelTimeWork2.TabIndex = 16;
            this.labelTimeWork2.Text = "Дни: 0 Часы: 0 Минуты: 0";
            // 
            // GPUFanMaxTimer
            // 
            this.GPUFanMaxTimer.Interval = 1000;
            this.GPUFanMaxTimer.Tag = "fan_max";
            this.GPUFanMaxTimer.Tick += new System.EventHandler(this.FanMaxTimerTick);
            // 
            // GPUFanMinTImer
            // 
            this.GPUFanMinTImer.Interval = 1000;
            this.GPUFanMinTImer.Tag = "fan_min";
            this.GPUFanMinTImer.Tick += new System.EventHandler(this.FanMinTimerTick);
            // 
            // labelCounterTempMax
            // 
            this.labelCounterTempMax.AutoSize = true;
            this.labelCounterTempMax.Location = new System.Drawing.Point(312, 160);
            this.labelCounterTempMax.Name = "labelCounterTempMax";
            this.labelCounterTempMax.Size = new System.Drawing.Size(70, 13);
            this.labelCounterTempMax.TabIndex = 17;
            this.labelCounterTempMax.Text = "                     ";
            // 
            // labelTempMax
            // 
            this.labelTempMax.AutoSize = true;
            this.labelTempMax.Location = new System.Drawing.Point(32, 160);
            this.labelTempMax.Name = "labelTempMax";
            this.labelTempMax.Size = new System.Drawing.Size(113, 13);
            this.labelTempMax.TabIndex = 18;
            this.labelTempMax.Text = "Событие TEMP MAX:";
            // 
            // SendDataTimer
            // 
            this.SendDataTimer.Interval = 60000;
            this.SendDataTimer.Tag = "send sait";
            this.SendDataTimer.Tick += new System.EventHandler(this.SendDataTimerTick);
            // 
            // labelFanMax
            // 
            this.labelFanMax.AutoSize = true;
            this.labelFanMax.Location = new System.Drawing.Point(32, 201);
            this.labelFanMax.Name = "labelFanMax";
            this.labelFanMax.Size = new System.Drawing.Size(104, 13);
            this.labelFanMax.TabIndex = 19;
            this.labelFanMax.Text = "Событие FAN MAX:";
            // 
            // labelStatusTempMin
            // 
            this.labelStatusTempMin.AutoSize = true;
            this.labelStatusTempMin.Location = new System.Drawing.Point(158, 179);
            this.labelStatusTempMin.Name = "labelStatusTempMin";
            this.labelStatusTempMin.Size = new System.Drawing.Size(40, 13);
            this.labelStatusTempMin.TabIndex = 20;
            this.labelStatusTempMin.Text = "           ";
            // 
            // labelCounterTempMin
            // 
            this.labelCounterTempMin.AutoSize = true;
            this.labelCounterTempMin.Location = new System.Drawing.Point(312, 179);
            this.labelCounterTempMin.Name = "labelCounterTempMin";
            this.labelCounterTempMin.Size = new System.Drawing.Size(46, 13);
            this.labelCounterTempMin.TabIndex = 21;
            this.labelCounterTempMin.Text = "             ";
            // 
            // labelTempMin
            // 
            this.labelTempMin.AutoSize = true;
            this.labelTempMin.Location = new System.Drawing.Point(32, 179);
            this.labelTempMin.Name = "labelTempMin";
            this.labelTempMin.Size = new System.Drawing.Size(110, 13);
            this.labelTempMin.TabIndex = 22;
            this.labelTempMin.Text = "Событие TEMP MIN:";
            // 
            // labelReloadFile
            // 
            this.labelReloadFile.AutoSize = true;
            this.labelReloadFile.Location = new System.Drawing.Point(32, 246);
            this.labelReloadFile.Name = "labelReloadFile";
            this.labelReloadFile.Size = new System.Drawing.Size(126, 13);
            this.labelReloadFile.TabIndex = 23;
            this.labelReloadFile.Text = "Событие RELOAD FILE:";
            // 
            // labelStatusReloadFile
            // 
            this.labelStatusReloadFile.AutoSize = true;
            this.labelStatusReloadFile.Location = new System.Drawing.Point(158, 246);
            this.labelStatusReloadFile.Name = "labelStatusReloadFile";
            this.labelStatusReloadFile.Size = new System.Drawing.Size(61, 13);
            this.labelStatusReloadFile.TabIndex = 24;
            this.labelStatusReloadFile.Text = "                  ";
            // 
            // labelCounterReloadFile
            // 
            this.labelCounterReloadFile.AutoSize = true;
            this.labelCounterReloadFile.Location = new System.Drawing.Point(312, 246);
            this.labelCounterReloadFile.Name = "labelCounterReloadFile";
            this.labelCounterReloadFile.Size = new System.Drawing.Size(73, 13);
            this.labelCounterReloadFile.TabIndex = 25;
            this.labelCounterReloadFile.Text = "                      ";
            // 
            // labelFanMin
            // 
            this.labelFanMin.AutoSize = true;
            this.labelFanMin.Location = new System.Drawing.Point(32, 223);
            this.labelFanMin.Name = "labelFanMin";
            this.labelFanMin.Size = new System.Drawing.Size(101, 13);
            this.labelFanMin.TabIndex = 26;
            this.labelFanMin.Text = "Событие FAN MIN:";
            // 
            // labelStatusFanMax
            // 
            this.labelStatusFanMax.AutoSize = true;
            this.labelStatusFanMax.Location = new System.Drawing.Point(158, 201);
            this.labelStatusFanMax.Name = "labelStatusFanMax";
            this.labelStatusFanMax.Size = new System.Drawing.Size(43, 13);
            this.labelStatusFanMax.TabIndex = 27;
            this.labelStatusFanMax.Text = "            ";
            // 
            // labelCounterFanMax
            // 
            this.labelCounterFanMax.AutoSize = true;
            this.labelCounterFanMax.Location = new System.Drawing.Point(312, 201);
            this.labelCounterFanMax.Name = "labelCounterFanMax";
            this.labelCounterFanMax.Size = new System.Drawing.Size(52, 13);
            this.labelCounterFanMax.TabIndex = 28;
            this.labelCounterFanMax.Text = "               ";
            // 
            // labelStatusFanMin
            // 
            this.labelStatusFanMin.AutoSize = true;
            this.labelStatusFanMin.Location = new System.Drawing.Point(158, 223);
            this.labelStatusFanMin.Name = "labelStatusFanMin";
            this.labelStatusFanMin.Size = new System.Drawing.Size(49, 13);
            this.labelStatusFanMin.TabIndex = 29;
            this.labelStatusFanMin.Text = "              ";
            // 
            // labelCounterFanMin
            // 
            this.labelCounterFanMin.AutoSize = true;
            this.labelCounterFanMin.Location = new System.Drawing.Point(312, 223);
            this.labelCounterFanMin.Name = "labelCounterFanMin";
            this.labelCounterFanMin.Size = new System.Drawing.Size(64, 13);
            this.labelCounterFanMin.TabIndex = 30;
            this.labelCounterFanMin.Text = "                   ";
            // 
            // GPUCoreMinTimer
            // 
            this.GPUCoreMinTimer.Interval = 1000;
            this.GPUCoreMinTimer.Tag = "clock";
            this.GPUCoreMinTimer.Tick += new System.EventHandler(this.GpuCoreMinHzTimerTick);
            // 
            // GPUMemMinTimer
            // 
            this.GPUMemMinTimer.Interval = 1000;
            this.GPUMemMinTimer.Tag = "memory";
            this.GPUMemMinTimer.Tick += new System.EventHandler(this.GpuMemoryMinHzTimerTick);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(32, 269);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(92, 13);
            this.labelClock.TabIndex = 31;
            this.labelClock.Text = "Событие CLOCK:";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(32, 290);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(105, 13);
            this.labelMemory.TabIndex = 32;
            this.labelMemory.Text = "Событие MEMORY:";
            // 
            // labelStatusClock
            // 
            this.labelStatusClock.AutoSize = true;
            this.labelStatusClock.Location = new System.Drawing.Point(158, 269);
            this.labelStatusClock.Name = "labelStatusClock";
            this.labelStatusClock.Size = new System.Drawing.Size(49, 13);
            this.labelStatusClock.TabIndex = 33;
            this.labelStatusClock.Text = "              ";
            // 
            // labelCounterClock
            // 
            this.labelCounterClock.AutoSize = true;
            this.labelCounterClock.Location = new System.Drawing.Point(312, 269);
            this.labelCounterClock.Name = "labelCounterClock";
            this.labelCounterClock.Size = new System.Drawing.Size(67, 13);
            this.labelCounterClock.TabIndex = 34;
            this.labelCounterClock.Text = "                    ";
            // 
            // labelStatusMemory
            // 
            this.labelStatusMemory.AutoSize = true;
            this.labelStatusMemory.Location = new System.Drawing.Point(158, 290);
            this.labelStatusMemory.Name = "labelStatusMemory";
            this.labelStatusMemory.Size = new System.Drawing.Size(79, 13);
            this.labelStatusMemory.TabIndex = 35;
            this.labelStatusMemory.Text = "                        ";
            // 
            // labelCounterMemory
            // 
            this.labelCounterMemory.AutoSize = true;
            this.labelCounterMemory.Location = new System.Drawing.Point(312, 290);
            this.labelCounterMemory.Name = "labelCounterMemory";
            this.labelCounterMemory.Size = new System.Drawing.Size(64, 13);
            this.labelCounterMemory.TabIndex = 36;
            this.labelCounterMemory.Text = "                   ";
            // 
            // PingInternetTimer
            // 
            this.PingInternetTimer.Enabled = true;
            this.PingInternetTimer.Interval = 5000;
            this.PingInternetTimer.Tag = "internet";
            this.PingInternetTimer.Tick += new System.EventHandler(this.PingTimerTick);
            // 
            // labelInternetPing
            // 
            this.labelInternetPing.AutoSize = true;
            this.labelInternetPing.Location = new System.Drawing.Point(31, 137);
            this.labelInternetPing.Name = "labelInternetPing";
            this.labelInternetPing.Size = new System.Drawing.Size(105, 13);
            this.labelInternetPing.TabIndex = 37;
            this.labelInternetPing.Text = "Доступ в интернет:";
            // 
            // labelStatusInternetPing
            // 
            this.labelStatusInternetPing.AutoSize = true;
            this.labelStatusInternetPing.Location = new System.Drawing.Point(159, 137);
            this.labelStatusInternetPing.Name = "labelStatusInternetPing";
            this.labelStatusInternetPing.Size = new System.Drawing.Size(73, 13);
            this.labelStatusInternetPing.TabIndex = 38;
            this.labelStatusInternetPing.Text = "                      ";
            // 
            // DontHaveInternetTimer
            // 
            this.DontHaveInternetTimer.Interval = 1000;
            this.DontHaveInternetTimer.Tag = "internet_r";
            this.DontHaveInternetTimer.Tick += new System.EventHandler(this.InternetInactiveTimerTick);
            // 
            // FellOffGPUTimer
            // 
            this.FellOffGPUTimer.Tag = "card leave";
            this.FellOffGPUTimer.Tick += new System.EventHandler(this.FellOffTimerTick);
            // 
            // labelFellOffGPU
            // 
            this.labelFellOffGPU.AutoSize = true;
            this.labelFellOffGPU.Location = new System.Drawing.Point(32, 332);
            this.labelFellOffGPU.Name = "labelFellOffGPU";
            this.labelFellOffGPU.Size = new System.Drawing.Size(120, 13);
            this.labelFellOffGPU.TabIndex = 39;
            this.labelFellOffGPU.Text = "Событие отвал карты:";
            // 
            // labelStatusFellOffGPU
            // 
            this.labelStatusFellOffGPU.AutoSize = true;
            this.labelStatusFellOffGPU.Location = new System.Drawing.Point(158, 332);
            this.labelStatusFellOffGPU.Name = "labelStatusFellOffGPU";
            this.labelStatusFellOffGPU.Size = new System.Drawing.Size(64, 13);
            this.labelStatusFellOffGPU.TabIndex = 40;
            this.labelStatusFellOffGPU.Text = "                   ";
            // 
            // labelCounerFellOff
            // 
            this.labelCounerFellOff.AutoSize = true;
            this.labelCounerFellOff.Location = new System.Drawing.Point(312, 332);
            this.labelCounerFellOff.Name = "labelCounerFellOff";
            this.labelCounerFellOff.Size = new System.Drawing.Size(70, 13);
            this.labelCounerFellOff.TabIndex = 41;
            this.labelCounerFellOff.Text = "                     ";
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Location = new System.Drawing.Point(32, 353);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(103, 13);
            this.labelInternet.TabIndex = 42;
            this.labelInternet.Text = "Событие интернет:";
            // 
            // labelStatusInternet
            // 
            this.labelStatusInternet.AutoSize = true;
            this.labelStatusInternet.Location = new System.Drawing.Point(158, 353);
            this.labelStatusInternet.Name = "labelStatusInternet";
            this.labelStatusInternet.Size = new System.Drawing.Size(43, 13);
            this.labelStatusInternet.TabIndex = 43;
            this.labelStatusInternet.Text = "            ";
            // 
            // label3CounterInternet
            // 
            this.label3CounterInternet.AutoSize = true;
            this.label3CounterInternet.Location = new System.Drawing.Point(311, 353);
            this.label3CounterInternet.Name = "label3CounterInternet";
            this.label3CounterInternet.Size = new System.Drawing.Size(73, 13);
            this.label3CounterInternet.TabIndex = 44;
            this.label3CounterInternet.Text = "                      ";
            // 
            // labelCounterLoadGPU
            // 
            this.labelCounterLoadGPU.AutoSize = true;
            this.labelCounterLoadGPU.Location = new System.Drawing.Point(312, 311);
            this.labelCounterLoadGPU.Name = "labelCounterLoadGPU";
            this.labelCounterLoadGPU.Size = new System.Drawing.Size(64, 13);
            this.labelCounterLoadGPU.TabIndex = 47;
            this.labelCounterLoadGPU.Text = "                   ";
            // 
            // labelStatusLoadGPU
            // 
            this.labelStatusLoadGPU.AutoSize = true;
            this.labelStatusLoadGPU.Location = new System.Drawing.Point(158, 311);
            this.labelStatusLoadGPU.Name = "labelStatusLoadGPU";
            this.labelStatusLoadGPU.Size = new System.Drawing.Size(79, 13);
            this.labelStatusLoadGPU.TabIndex = 46;
            this.labelStatusLoadGPU.Text = "                        ";
            // 
            // labelLoadGPU
            // 
            this.labelLoadGPU.AutoSize = true;
            this.labelLoadGPU.Location = new System.Drawing.Point(32, 311);
            this.labelLoadGPU.Name = "labelLoadGPU";
            this.labelLoadGPU.Size = new System.Drawing.Size(112, 13);
            this.labelLoadGPU.TabIndex = 45;
            this.labelLoadGPU.Text = "Событие LOAD GPU:";
            // 
            // GPULoadMin
            // 
            this.GPULoadMin.Interval = 1000;
            this.GPULoadMin.Tag = "load";
            this.GPULoadMin.Tick += new System.EventHandler(this.GPULoadMin_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 505);
            this.Controls.Add(this.labelCounterLoadGPU);
            this.Controls.Add(this.labelStatusLoadGPU);
            this.Controls.Add(this.labelLoadGPU);
            this.Controls.Add(this.label3CounterInternet);
            this.Controls.Add(this.labelStatusInternet);
            this.Controls.Add(this.labelInternet);
            this.Controls.Add(this.labelCounerFellOff);
            this.Controls.Add(this.labelStatusFellOffGPU);
            this.Controls.Add(this.labelFellOffGPU);
            this.Controls.Add(this.labelStatusInternetPing);
            this.Controls.Add(this.labelInternetPing);
            this.Controls.Add(this.labelCounterMemory);
            this.Controls.Add(this.labelStatusMemory);
            this.Controls.Add(this.labelCounterClock);
            this.Controls.Add(this.labelStatusClock);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelCounterFanMin);
            this.Controls.Add(this.labelStatusFanMin);
            this.Controls.Add(this.labelCounterFanMax);
            this.Controls.Add(this.labelStatusFanMax);
            this.Controls.Add(this.labelFanMin);
            this.Controls.Add(this.labelCounterReloadFile);
            this.Controls.Add(this.labelStatusReloadFile);
            this.Controls.Add(this.labelReloadFile);
            this.Controls.Add(this.labelTempMin);
            this.Controls.Add(this.labelCounterTempMin);
            this.Controls.Add(this.labelStatusTempMin);
            this.Controls.Add(this.labelFanMax);
            this.Controls.Add(this.labelTempMax);
            this.Controls.Add(this.labelCounterTempMax);
            this.Controls.Add(this.labelTimeWork2);
            this.Controls.Add(this.labelStatusTempMax);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelTimeWork);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.labelRigName);
            this.Controls.Add(this.labelSecret);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.RigTextBox);
            this.Controls.Add(this.SecretTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informer | Allminer.ru v1.3.4";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SecretTextBox;
        private System.Windows.Forms.TextBox RigTextBox;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSecret;
        private System.Windows.Forms.Label labelRigName;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label labelTimeWork;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer GetTempretureTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer AutoStartTimer;
        private System.Windows.Forms.Timer CheckNewVersionTimer;
        private System.Windows.Forms.Timer TimeWorkTimer;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Timer GPUTempMaxTimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer GPUTempMinTimer;
        private System.Windows.Forms.Timer ReloadMinerTimer;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label labelStatusTempMax;
        private System.Windows.Forms.Label labelTimeWork2;
        private System.Windows.Forms.Timer GPUFanMaxTimer;
        private System.Windows.Forms.Timer GPUFanMinTImer;
        private System.Windows.Forms.Label labelCounterTempMax;
        private System.Windows.Forms.Label labelTempMax;
        private System.Windows.Forms.Timer SendDataTimer;
        private System.Windows.Forms.Label labelFanMax;
        private System.Windows.Forms.Label labelStatusTempMin;
        private System.Windows.Forms.Label labelCounterTempMin;
        private System.Windows.Forms.Label labelTempMin;
        private System.Windows.Forms.Label labelReloadFile;
        private System.Windows.Forms.Label labelStatusReloadFile;
        private System.Windows.Forms.Label labelCounterReloadFile;
        private System.Windows.Forms.Label labelFanMin;
        private System.Windows.Forms.Label labelStatusFanMax;
        private System.Windows.Forms.Label labelCounterFanMax;
        private System.Windows.Forms.Label labelStatusFanMin;
        private System.Windows.Forms.Label labelCounterFanMin;
        private System.Windows.Forms.Timer GPUCoreMinTimer;
        private System.Windows.Forms.Timer GPUMemMinTimer;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelStatusClock;
        private System.Windows.Forms.Label labelCounterClock;
        private System.Windows.Forms.Label labelStatusMemory;
        private System.Windows.Forms.Label labelCounterMemory;
        private System.Windows.Forms.Timer PingInternetTimer;
        private System.Windows.Forms.Label labelInternetPing;
        private System.Windows.Forms.Label labelStatusInternetPing;
        private System.Windows.Forms.Timer DontHaveInternetTimer;
        private System.Windows.Forms.Timer FellOffGPUTimer;
        private System.Windows.Forms.Label labelFellOffGPU;
        private System.Windows.Forms.Label labelStatusFellOffGPU;
        private System.Windows.Forms.Label labelCounerFellOff;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.Label labelStatusInternet;
        private System.Windows.Forms.Label label3CounterInternet;
        private System.Windows.Forms.Label labelCounterLoadGPU;
        private System.Windows.Forms.Label labelStatusLoadGPU;
        private System.Windows.Forms.Label labelLoadGPU;
        private System.Windows.Forms.Timer GPULoadMin;
    }
}

