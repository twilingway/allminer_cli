namespace Informer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btSave = new System.Windows.Forms.Button();
            this.tbTempMin = new System.Windows.Forms.TextBox();
            this.tbTempMax = new System.Windows.Forms.TextBox();
            this.cbTempMaxGPU = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btView1 = new System.Windows.Forms.Button();
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.cbReloadFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReloadTempFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTempMinGPU = new System.Windows.Forms.CheckBox();
            this.combTimeStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPath2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btView2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReloadFileSec = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTempMinSec = new System.Windows.Forms.TextBox();
            this.tbTempMaxSec = new System.Windows.Forms.TextBox();
            this.chFanMaxGPU = new System.Windows.Forms.CheckBox();
            this.tbFanMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFanMinGPU = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFanMin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFanMinSec = new System.Windows.Forms.TextBox();
            this.tbFanMaxSec = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbClockMinGPU = new System.Windows.Forms.CheckBox();
            this.tbClockMin = new System.Windows.Forms.TextBox();
            this.tbClockMinSec = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMemoryMinGPU = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMemoryMinSec = new System.Windows.Forms.TextBox();
            this.tbMemoryMin = new System.Windows.Forms.TextBox();
            this.cbInternetOff = new System.Windows.Forms.CheckBox();
            this.tbInternetOffSec = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFellOffGPU = new System.Windows.Forms.CheckBox();
            this.tbCountGPU = new System.Windows.Forms.TextBox();
            this.tbCountGPUSec = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbSecGPU = new System.Windows.Forms.Label();
            this.tbLoadGPUSec = new System.Windows.Forms.TextBox();
            this.tbLoadGPU = new System.Windows.Forms.TextBox();
            this.cbLoadGPU = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(247, 508);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(297, 45);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSaveClick);
            // 
            // tbTempMin
            // 
            this.tbTempMin.Location = new System.Drawing.Point(25, 82);
            this.tbTempMin.Name = "tbTempMin";
            this.tbTempMin.Size = new System.Drawing.Size(42, 20);
            this.tbTempMin.TabIndex = 5;
            this.tbTempMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempMin_KeyPress);
            // 
            // tbTempMax
            // 
            this.tbTempMax.Location = new System.Drawing.Point(25, 33);
            this.tbTempMax.Name = "tbTempMax";
            this.tbTempMax.Size = new System.Drawing.Size(42, 20);
            this.tbTempMax.TabIndex = 14;
            this.tbTempMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempMax_KeyPress);
            // 
            // cbTempMaxGPU
            // 
            this.cbTempMaxGPU.AutoSize = true;
            this.cbTempMaxGPU.Location = new System.Drawing.Point(25, 6);
            this.cbTempMaxGPU.Name = "cbTempMaxGPU";
            this.cbTempMaxGPU.Size = new System.Drawing.Size(357, 17);
            this.cbTempMaxGPU.TabIndex = 15;
            this.cbTempMaxGPU.Text = "Перезагрузка если максимальная температура выше или равно";
            this.cbTempMaxGPU.UseVisualStyleBackColor = true;
            this.cbTempMaxGPU.CheckedChanged += new System.EventHandler(this.CheckBoxTempMax_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "сек";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "сек";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btView1
            // 
            this.btView1.Location = new System.Drawing.Point(22, 102);
            this.btView1.Name = "btView1";
            this.btView1.Size = new System.Drawing.Size(75, 23);
            this.btView1.TabIndex = 27;
            this.btView1.Text = "Обзор";
            this.btView1.UseVisualStyleBackColor = true;
            this.btView1.Click += new System.EventHandler(this.buttonView1_Click);
            // 
            // tbPath1
            // 
            this.tbPath1.Location = new System.Drawing.Point(104, 104);
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.ReadOnly = true;
            this.tbPath1.Size = new System.Drawing.Size(240, 20);
            this.tbPath1.TabIndex = 28;
            // 
            // cbReloadFile
            // 
            this.cbReloadFile.AutoSize = true;
            this.cbReloadFile.Location = new System.Drawing.Point(25, 3);
            this.cbReloadFile.Name = "cbReloadFile";
            this.cbReloadFile.Size = new System.Drawing.Size(133, 17);
            this.cbReloadFile.TabIndex = 29;
            this.cbReloadFile.Text = "Перезапускать фаил";
            this.cbReloadFile.UseVisualStyleBackColor = true;
            this.cbReloadFile.CheckedChanged += new System.EventHandler(this.CheckBoxReloadFile_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(58, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "ВНИМАНИЕ! ЗАКРОЕТ ВСЕ КОМАНДНЫЕ СТРОКИ!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Если минимальная температура ниже или равно";
            // 
            // tbReloadTempFile
            // 
            this.tbReloadTempFile.Location = new System.Drawing.Point(26, 56);
            this.tbReloadTempFile.Name = "tbReloadTempFile";
            this.tbReloadTempFile.Size = new System.Drawing.Size(42, 20);
            this.tbReloadTempFile.TabIndex = 33;
            this.tbReloadTempFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReloadTempFile_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "сек";
            // 
            // cbTempMinGPU
            // 
            this.cbTempMinGPU.AutoSize = true;
            this.cbTempMinGPU.Location = new System.Drawing.Point(25, 59);
            this.cbTempMinGPU.Name = "cbTempMinGPU";
            this.cbTempMinGPU.Size = new System.Drawing.Size(349, 17);
            this.cbTempMinGPU.TabIndex = 35;
            this.cbTempMinGPU.Text = "Перезагрузка если минимальная температура ниже или равно";
            this.cbTempMinGPU.UseVisualStyleBackColor = true;
            this.cbTempMinGPU.CheckedChanged += new System.EventHandler(this.CheckBoxTempMin_CheckedChanged);
            // 
            // combTimeStart
            // 
            this.combTimeStart.DisplayMember = "1";
            this.combTimeStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTimeStart.FormattingEnabled = true;
            this.combTimeStart.Items.AddRange(new object[] {
            "10",
            "30",
            "60",
            "120",
            "180",
            "240",
            "300"});
            this.combTimeStart.Location = new System.Drawing.Point(162, 4);
            this.combTimeStart.Name = "combTimeStart";
            this.combTimeStart.Size = new System.Drawing.Size(68, 21);
            this.combTimeStart.TabIndex = 36;
            this.combTimeStart.SelectedIndexChanged += new System.EventHandler(this.combTimeStart_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "секунд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Запуск программы через";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbPath2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btView2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbReloadFileSec);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbReloadTempFile);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbReloadFile);
            this.panel1.Controls.Add(this.tbPath1);
            this.panel1.Controls.Add(this.btView1);
            this.panel1.Location = new System.Drawing.Point(12, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 183);
            this.panel1.TabIndex = 39;
            // 
            // tbPath2
            // 
            this.tbPath2.Location = new System.Drawing.Point(104, 146);
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.ReadOnly = true;
            this.tbPath2.Size = new System.Drawing.Size(240, 20);
            this.tbPath2.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Путь для перезапуска бат файла";
            // 
            // btView2
            // 
            this.btView2.Location = new System.Drawing.Point(22, 144);
            this.btView2.Name = "btView2";
            this.btView2.Size = new System.Drawing.Size(75, 23);
            this.btView2.TabIndex = 37;
            this.btView2.Text = "Обзор";
            this.btView2.UseVisualStyleBackColor = true;
            this.btView2.Click += new System.EventHandler(this.buttonView2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Путь для закрытия майнера";
            // 
            // tbReloadFileSec
            // 
            this.tbReloadFileSec.Location = new System.Drawing.Point(79, 56);
            this.tbReloadFileSec.Name = "tbReloadFileSec";
            this.tbReloadFileSec.Size = new System.Drawing.Size(51, 20);
            this.tbReloadFileSec.TabIndex = 35;
            this.tbReloadFileSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReloadFileSec_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.tbTempMinSec);
            this.panel2.Controls.Add(this.tbTempMaxSec);
            this.panel2.Controls.Add(this.cbTempMinGPU);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbTempMaxGPU);
            this.panel2.Controls.Add(this.tbTempMax);
            this.panel2.Controls.Add(this.tbTempMin);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 116);
            this.panel2.TabIndex = 40;
            // 
            // tbTempMinSec
            // 
            this.tbTempMinSec.Location = new System.Drawing.Point(79, 82);
            this.tbTempMinSec.Name = "tbTempMinSec";
            this.tbTempMinSec.Size = new System.Drawing.Size(47, 20);
            this.tbTempMinSec.TabIndex = 37;
            this.tbTempMinSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempMinSec_KeyPress);
            // 
            // tbTempMaxSec
            // 
            this.tbTempMaxSec.Location = new System.Drawing.Point(79, 33);
            this.tbTempMaxSec.Name = "tbTempMaxSec";
            this.tbTempMaxSec.Size = new System.Drawing.Size(47, 20);
            this.tbTempMaxSec.TabIndex = 36;
            this.tbTempMaxSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempMaxSec_KeyPress);
            // 
            // chFanMaxGPU
            // 
            this.chFanMaxGPU.AutoSize = true;
            this.chFanMaxGPU.Location = new System.Drawing.Point(22, 8);
            this.chFanMaxGPU.Name = "chFanMaxGPU";
            this.chFanMaxGPU.Size = new System.Drawing.Size(358, 17);
            this.chFanMaxGPU.TabIndex = 41;
            this.chFanMaxGPU.Text = "Перезагрузка если максимальные обороты Fan выше или равно";
            this.chFanMaxGPU.UseVisualStyleBackColor = true;
            this.chFanMaxGPU.CheckedChanged += new System.EventHandler(this.CheckBoxFanMax_CheckedChanged);
            // 
            // tbFanMax
            // 
            this.tbFanMax.Location = new System.Drawing.Point(21, 31);
            this.tbFanMax.Name = "tbFanMax";
            this.tbFanMax.Size = new System.Drawing.Size(46, 20);
            this.tbFanMax.TabIndex = 42;
            this.tbFanMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFanMax_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "сек";
            // 
            // cbFanMinGPU
            // 
            this.cbFanMinGPU.AutoSize = true;
            this.cbFanMinGPU.Location = new System.Drawing.Point(21, 57);
            this.cbFanMinGPU.Name = "cbFanMinGPU";
            this.cbFanMinGPU.Size = new System.Drawing.Size(350, 17);
            this.cbFanMinGPU.TabIndex = 45;
            this.cbFanMinGPU.Text = "Перезагрузка если минимальные обороты Fan ниже или равно";
            this.cbFanMinGPU.UseVisualStyleBackColor = true;
            this.cbFanMinGPU.CheckedChanged += new System.EventHandler(this.CheckBoxFanMin_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "сек";
            // 
            // tbFanMin
            // 
            this.tbFanMin.Location = new System.Drawing.Point(22, 80);
            this.tbFanMin.Name = "tbFanMin";
            this.tbFanMin.Size = new System.Drawing.Size(46, 20);
            this.tbFanMin.TabIndex = 48;
            this.tbFanMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFanMin_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tbFanMinSec);
            this.panel3.Controls.Add(this.tbFanMaxSec);
            this.panel3.Controls.Add(this.tbFanMin);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbFanMinGPU);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbFanMax);
            this.panel3.Controls.Add(this.chFanMaxGPU);
            this.panel3.Location = new System.Drawing.Point(12, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 135);
            this.panel3.TabIndex = 49;
            // 
            // tbFanMinSec
            // 
            this.tbFanMinSec.Location = new System.Drawing.Point(79, 80);
            this.tbFanMinSec.Name = "tbFanMinSec";
            this.tbFanMinSec.Size = new System.Drawing.Size(47, 20);
            this.tbFanMinSec.TabIndex = 50;
            this.tbFanMinSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFanMinSec_KeyPress);
            // 
            // tbFanMaxSec
            // 
            this.tbFanMaxSec.Location = new System.Drawing.Point(79, 31);
            this.tbFanMaxSec.Name = "tbFanMaxSec";
            this.tbFanMaxSec.Size = new System.Drawing.Size(47, 20);
            this.tbFanMaxSec.TabIndex = 49;
            this.tbFanMaxSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFanMaxSec_KeyPress);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.combTimeStart);
            this.panel4.Location = new System.Drawing.Point(205, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 44);
            this.panel4.TabIndex = 50;
            // 
            // cbClockMinGPU
            // 
            this.cbClockMinGPU.AutoSize = true;
            this.cbClockMinGPU.Location = new System.Drawing.Point(25, 6);
            this.cbClockMinGPU.Name = "cbClockMinGPU";
            this.cbClockMinGPU.Size = new System.Drawing.Size(273, 17);
            this.cbClockMinGPU.TabIndex = 51;
            this.cbClockMinGPU.Text = "Перезагрузка если частота ядра (Clock) меньше";
            this.cbClockMinGPU.UseVisualStyleBackColor = true;
            this.cbClockMinGPU.CheckedChanged += new System.EventHandler(this.CheckBoxClockMin_CheckedChanged);
            // 
            // tbClockMin
            // 
            this.tbClockMin.Location = new System.Drawing.Point(24, 33);
            this.tbClockMin.Name = "tbClockMin";
            this.tbClockMin.Size = new System.Drawing.Size(45, 20);
            this.tbClockMin.TabIndex = 52;
            this.tbClockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClockMin_KeyPress);
            // 
            // tbClockMinSec
            // 
            this.tbClockMinSec.Location = new System.Drawing.Point(79, 33);
            this.tbClockMinSec.Name = "tbClockMinSec";
            this.tbClockMinSec.Size = new System.Drawing.Size(46, 20);
            this.tbClockMinSec.TabIndex = 53;
            this.tbClockMinSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClockMinSec_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "сек";
            // 
            // cbMemoryMinGPU
            // 
            this.cbMemoryMinGPU.AutoSize = true;
            this.cbMemoryMinGPU.Location = new System.Drawing.Point(24, 59);
            this.cbMemoryMinGPU.Name = "cbMemoryMinGPU";
            this.cbMemoryMinGPU.Size = new System.Drawing.Size(296, 17);
            this.cbMemoryMinGPU.TabIndex = 55;
            this.cbMemoryMinGPU.Text = "Перезагрузка если частота памяти (Memory) меньше";
            this.cbMemoryMinGPU.UseVisualStyleBackColor = true;
            this.cbMemoryMinGPU.CheckedChanged += new System.EventHandler(this.CheckBoxMemory_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tbMemoryMinSec);
            this.panel5.Controls.Add(this.tbMemoryMin);
            this.panel5.Controls.Add(this.cbMemoryMinGPU);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.tbClockMinSec);
            this.panel5.Controls.Add(this.tbClockMin);
            this.panel5.Controls.Add(this.cbClockMinGPU);
            this.panel5.Location = new System.Drawing.Point(412, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 116);
            this.panel5.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "сек";
            // 
            // tbMemoryMinSec
            // 
            this.tbMemoryMinSec.Location = new System.Drawing.Point(79, 82);
            this.tbMemoryMinSec.Name = "tbMemoryMinSec";
            this.tbMemoryMinSec.Size = new System.Drawing.Size(46, 20);
            this.tbMemoryMinSec.TabIndex = 57;
            this.tbMemoryMinSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMemoryMinSec_KeyPress);
            // 
            // tbMemoryMin
            // 
            this.tbMemoryMin.Location = new System.Drawing.Point(24, 82);
            this.tbMemoryMin.Name = "tbMemoryMin";
            this.tbMemoryMin.Size = new System.Drawing.Size(45, 20);
            this.tbMemoryMin.TabIndex = 56;
            this.tbMemoryMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMemoryMin_KeyPress);
            // 
            // cbInternetOff
            // 
            this.cbInternetOff.AutoSize = true;
            this.cbInternetOff.Location = new System.Drawing.Point(23, 4);
            this.cbInternetOff.Name = "cbInternetOff";
            this.cbInternetOff.Size = new System.Drawing.Size(202, 17);
            this.cbInternetOff.TabIndex = 57;
            this.cbInternetOff.Text = "Перезагрузка если нет Интернета";
            this.cbInternetOff.UseVisualStyleBackColor = true;
            this.cbInternetOff.CheckedChanged += new System.EventHandler(this.CheckBoxInternetOff_CheckedChanged);
            // 
            // tbInternetOffSec
            // 
            this.tbInternetOffSec.Location = new System.Drawing.Point(23, 30);
            this.tbInternetOffSec.Name = "tbInternetOffSec";
            this.tbInternetOffSec.Size = new System.Drawing.Size(45, 20);
            this.tbInternetOffSec.TabIndex = 58;
            this.tbInternetOffSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInternetOffSec_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "сек";
            // 
            // cbFellOffGPU
            // 
            this.cbFellOffGPU.AutoSize = true;
            this.cbFellOffGPU.Location = new System.Drawing.Point(23, 4);
            this.cbFellOffGPU.Name = "cbFellOffGPU";
            this.cbFellOffGPU.Size = new System.Drawing.Size(163, 17);
            this.cbFellOffGPU.TabIndex = 60;
            this.cbFellOffGPU.Text = "Следить за отвалом карты";
            this.cbFellOffGPU.UseVisualStyleBackColor = true;
            this.cbFellOffGPU.CheckedChanged += new System.EventHandler(this.CheckBoxFellOff_CheckedChanged);
            // 
            // tbCountGPU
            // 
            this.tbCountGPU.Location = new System.Drawing.Point(23, 51);
            this.tbCountGPU.Name = "tbCountGPU";
            this.tbCountGPU.Size = new System.Drawing.Size(45, 20);
            this.tbCountGPU.TabIndex = 61;
            this.tbCountGPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountGPU_KeyPress);
            // 
            // tbCountGPUSec
            // 
            this.tbCountGPUSec.Location = new System.Drawing.Point(79, 51);
            this.tbCountGPUSec.Name = "tbCountGPUSec";
            this.tbCountGPUSec.Size = new System.Drawing.Size(46, 20);
            this.tbCountGPUSec.TabIndex = 62;
            this.tbCountGPUSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountGPUSec_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "сек";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Укажите количество карт в риге:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.lbSecGPU);
            this.panel6.Controls.Add(this.tbLoadGPUSec);
            this.panel6.Controls.Add(this.tbLoadGPU);
            this.panel6.Controls.Add(this.cbLoadGPU);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.tbCountGPUSec);
            this.panel6.Controls.Add(this.tbCountGPU);
            this.panel6.Controls.Add(this.cbFellOffGPU);
            this.panel6.Location = new System.Drawing.Point(412, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(347, 135);
            this.panel6.TabIndex = 65;
            // 
            // lbSecGPU
            // 
            this.lbSecGPU.AutoSize = true;
            this.lbSecGPU.Location = new System.Drawing.Point(131, 109);
            this.lbSecGPU.Name = "lbSecGPU";
            this.lbSecGPU.Size = new System.Drawing.Size(25, 13);
            this.lbSecGPU.TabIndex = 68;
            this.lbSecGPU.Text = "сек";
            // 
            // tbLoadGPUSec
            // 
            this.tbLoadGPUSec.Location = new System.Drawing.Point(79, 102);
            this.tbLoadGPUSec.Name = "tbLoadGPUSec";
            this.tbLoadGPUSec.Size = new System.Drawing.Size(47, 20);
            this.tbLoadGPUSec.TabIndex = 67;
            this.tbLoadGPUSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoadGPUSec_KeyPress);
            // 
            // tbLoadGPU
            // 
            this.tbLoadGPU.Location = new System.Drawing.Point(23, 102);
            this.tbLoadGPU.Name = "tbLoadGPU";
            this.tbLoadGPU.Size = new System.Drawing.Size(46, 20);
            this.tbLoadGPU.TabIndex = 66;
            this.tbLoadGPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoadGPU_KeyPress);
            // 
            // cbLoadGPU
            // 
            this.cbLoadGPU.AutoSize = true;
            this.cbLoadGPU.Location = new System.Drawing.Point(23, 78);
            this.cbLoadGPU.Name = "cbLoadGPU";
            this.cbLoadGPU.Size = new System.Drawing.Size(304, 17);
            this.cbLoadGPU.TabIndex = 65;
            this.cbLoadGPU.Text = "Перезагружать если загрузка GPU меньше или равно";
            this.cbLoadGPU.UseVisualStyleBackColor = true;
            this.cbLoadGPU.CheckedChanged += new System.EventHandler(this.cbLoadGPU_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.cbInternetOff);
            this.panel7.Controls.Add(this.tbInternetOffSec);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(412, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 73);
            this.panel7.TabIndex = 66;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 565);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbTempMin;
        private System.Windows.Forms.TextBox tbTempMax;
        private System.Windows.Forms.CheckBox cbTempMaxGPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btView1;
        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.CheckBox cbReloadFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReloadTempFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbTempMinGPU;
        private System.Windows.Forms.ComboBox combTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chFanMaxGPU;
        private System.Windows.Forms.TextBox tbFanMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbFanMinGPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFanMin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbTempMaxSec;
        private System.Windows.Forms.TextBox tbTempMinSec;
        private System.Windows.Forms.TextBox tbFanMaxSec;
        private System.Windows.Forms.TextBox tbFanMinSec;
        private System.Windows.Forms.TextBox tbReloadFileSec;
        private System.Windows.Forms.TextBox tbPath2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbClockMinGPU;
        private System.Windows.Forms.TextBox tbClockMin;
        private System.Windows.Forms.TextBox tbClockMinSec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbMemoryMinGPU;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMemoryMinSec;
        private System.Windows.Forms.TextBox tbMemoryMin;
        private System.Windows.Forms.CheckBox cbInternetOff;
        private System.Windows.Forms.TextBox tbInternetOffSec;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbFellOffGPU;
        private System.Windows.Forms.TextBox tbCountGPU;
        private System.Windows.Forms.TextBox tbCountGPUSec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbSecGPU;
        private System.Windows.Forms.TextBox tbLoadGPUSec;
        private System.Windows.Forms.TextBox tbLoadGPU;
        private System.Windows.Forms.CheckBox cbLoadGPU;
        private System.Windows.Forms.Panel panel7;
    }
}