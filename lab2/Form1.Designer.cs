namespace lab2
{
    partial class Form1
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
            this.startAngleScrollBar = new System.Windows.Forms.HScrollBar();
            this.paramsGroupBox = new System.Windows.Forms.GroupBox();
            this.startYPosTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.startYPosScrollBar = new System.Windows.Forms.HScrollBar();
            this.tunnelAngleTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tunnelAngleScrollBar = new System.Windows.Forms.HScrollBar();
            this.secondSectionLengthTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.secondSectionLengthScrollBar = new System.Windows.Forms.HScrollBar();
            this.firstSectionLengthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.firstSectionLengthScrollBar = new System.Windows.Forms.HScrollBar();
            this.tunnelWidthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tunnelWidthScrollBar = new System.Windows.Forms.HScrollBar();
            this.startSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startSpeedScrollBar = new System.Windows.Forms.HScrollBar();
            this.startXPosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startXPosScrollBar = new System.Windows.Forms.HScrollBar();
            this.frictionCoefNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.washerRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.washerMassNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startAngleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.scaleScrollBar = new System.Windows.Forms.HScrollBar();
            this.mainFieldPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopModButton = new System.Windows.Forms.Button();
            this.startModButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cameraPosYTextBox = new System.Windows.Forms.TextBox();
            this.cameraPosXTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CameraPosLabel = new System.Windows.Forms.Label();
            this.drawPathCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.useStepRadioButton = new System.Windows.Forms.RadioButton();
            this.useElTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.drawChecksCheckBox = new System.Windows.Forms.CheckBox();
            this.paramsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frictionCoefNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.washerRadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.washerMassNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFieldPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startAngleScrollBar
            // 
            this.startAngleScrollBar.Location = new System.Drawing.Point(16, 304);
            this.startAngleScrollBar.Maximum = 189;
            this.startAngleScrollBar.Minimum = -180;
            this.startAngleScrollBar.Name = "startAngleScrollBar";
            this.startAngleScrollBar.Size = new System.Drawing.Size(142, 17);
            this.startAngleScrollBar.TabIndex = 0;
            this.startAngleScrollBar.Value = 90;
            this.startAngleScrollBar.ValueChanged += new System.EventHandler(this.startAngleScrollBar_ValueChanged);
            // 
            // paramsGroupBox
            // 
            this.paramsGroupBox.Controls.Add(this.startYPosTextBox);
            this.paramsGroupBox.Controls.Add(this.label12);
            this.paramsGroupBox.Controls.Add(this.startYPosScrollBar);
            this.paramsGroupBox.Controls.Add(this.tunnelAngleTextBox);
            this.paramsGroupBox.Controls.Add(this.label10);
            this.paramsGroupBox.Controls.Add(this.tunnelAngleScrollBar);
            this.paramsGroupBox.Controls.Add(this.secondSectionLengthTextBox);
            this.paramsGroupBox.Controls.Add(this.label9);
            this.paramsGroupBox.Controls.Add(this.secondSectionLengthScrollBar);
            this.paramsGroupBox.Controls.Add(this.firstSectionLengthTextBox);
            this.paramsGroupBox.Controls.Add(this.label8);
            this.paramsGroupBox.Controls.Add(this.firstSectionLengthScrollBar);
            this.paramsGroupBox.Controls.Add(this.tunnelWidthTextBox);
            this.paramsGroupBox.Controls.Add(this.label7);
            this.paramsGroupBox.Controls.Add(this.tunnelWidthScrollBar);
            this.paramsGroupBox.Controls.Add(this.startSpeedTextBox);
            this.paramsGroupBox.Controls.Add(this.label6);
            this.paramsGroupBox.Controls.Add(this.startSpeedScrollBar);
            this.paramsGroupBox.Controls.Add(this.startXPosTextBox);
            this.paramsGroupBox.Controls.Add(this.label5);
            this.paramsGroupBox.Controls.Add(this.startXPosScrollBar);
            this.paramsGroupBox.Controls.Add(this.frictionCoefNumericUpDown);
            this.paramsGroupBox.Controls.Add(this.label4);
            this.paramsGroupBox.Controls.Add(this.washerRadiusNumericUpDown);
            this.paramsGroupBox.Controls.Add(this.label3);
            this.paramsGroupBox.Controls.Add(this.washerMassNumericUpDown);
            this.paramsGroupBox.Controls.Add(this.label2);
            this.paramsGroupBox.Controls.Add(this.startAngleTextBox);
            this.paramsGroupBox.Controls.Add(this.label1);
            this.paramsGroupBox.Controls.Add(this.startAngleScrollBar);
            this.paramsGroupBox.Location = new System.Drawing.Point(570, 12);
            this.paramsGroupBox.Name = "paramsGroupBox";
            this.paramsGroupBox.Size = new System.Drawing.Size(218, 559);
            this.paramsGroupBox.TabIndex = 1;
            this.paramsGroupBox.TabStop = false;
            this.paramsGroupBox.Text = "Параметры";
            // 
            // startYPosTextBox
            // 
            this.startYPosTextBox.Enabled = false;
            this.startYPosTextBox.Location = new System.Drawing.Point(161, 196);
            this.startYPosTextBox.Name = "startYPosTextBox";
            this.startYPosTextBox.Size = new System.Drawing.Size(52, 20);
            this.startYPosTextBox.TabIndex = 32;
            this.startYPosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Начальное положение по Y, м:";
            // 
            // startYPosScrollBar
            // 
            this.startYPosScrollBar.Location = new System.Drawing.Point(11, 197);
            this.startYPosScrollBar.Maximum = 1009;
            this.startYPosScrollBar.Minimum = -1000;
            this.startYPosScrollBar.Name = "startYPosScrollBar";
            this.startYPosScrollBar.Size = new System.Drawing.Size(147, 17);
            this.startYPosScrollBar.TabIndex = 30;
            this.startYPosScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.startYPosScrollBar_Scroll);
            // 
            // tunnelAngleTextBox
            // 
            this.tunnelAngleTextBox.Enabled = false;
            this.tunnelAngleTextBox.Location = new System.Drawing.Point(161, 524);
            this.tunnelAngleTextBox.Name = "tunnelAngleTextBox";
            this.tunnelAngleTextBox.Size = new System.Drawing.Size(52, 20);
            this.tunnelAngleTextBox.TabIndex = 26;
            this.tunnelAngleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Угол туннеля:";
            // 
            // tunnelAngleScrollBar
            // 
            this.tunnelAngleScrollBar.Location = new System.Drawing.Point(16, 525);
            this.tunnelAngleScrollBar.Maximum = 159;
            this.tunnelAngleScrollBar.Minimum = 30;
            this.tunnelAngleScrollBar.Name = "tunnelAngleScrollBar";
            this.tunnelAngleScrollBar.Size = new System.Drawing.Size(142, 17);
            this.tunnelAngleScrollBar.TabIndex = 24;
            this.tunnelAngleScrollBar.Value = 80;
            this.tunnelAngleScrollBar.ValueChanged += new System.EventHandler(this.tunnelAngleScrollBar_ValueChanged);
            // 
            // secondSectionLengthTextBox
            // 
            this.secondSectionLengthTextBox.Enabled = false;
            this.secondSectionLengthTextBox.Location = new System.Drawing.Point(161, 470);
            this.secondSectionLengthTextBox.Name = "secondSectionLengthTextBox";
            this.secondSectionLengthTextBox.Size = new System.Drawing.Size(52, 20);
            this.secondSectionLengthTextBox.TabIndex = 23;
            this.secondSectionLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Длина второго участка, м:";
            // 
            // secondSectionLengthScrollBar
            // 
            this.secondSectionLengthScrollBar.Location = new System.Drawing.Point(16, 471);
            this.secondSectionLengthScrollBar.Maximum = 109;
            this.secondSectionLengthScrollBar.Minimum = 1;
            this.secondSectionLengthScrollBar.Name = "secondSectionLengthScrollBar";
            this.secondSectionLengthScrollBar.Size = new System.Drawing.Size(142, 17);
            this.secondSectionLengthScrollBar.TabIndex = 21;
            this.secondSectionLengthScrollBar.Value = 10;
            this.secondSectionLengthScrollBar.ValueChanged += new System.EventHandler(this.secondSectionLengthScrollBar_ValueChanged);
            // 
            // firstSectionLengthTextBox
            // 
            this.firstSectionLengthTextBox.Enabled = false;
            this.firstSectionLengthTextBox.Location = new System.Drawing.Point(161, 414);
            this.firstSectionLengthTextBox.Name = "firstSectionLengthTextBox";
            this.firstSectionLengthTextBox.Size = new System.Drawing.Size(52, 20);
            this.firstSectionLengthTextBox.TabIndex = 20;
            this.firstSectionLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Длина первого участка, м:";
            // 
            // firstSectionLengthScrollBar
            // 
            this.firstSectionLengthScrollBar.Location = new System.Drawing.Point(16, 415);
            this.firstSectionLengthScrollBar.Maximum = 109;
            this.firstSectionLengthScrollBar.Minimum = 1;
            this.firstSectionLengthScrollBar.Name = "firstSectionLengthScrollBar";
            this.firstSectionLengthScrollBar.Size = new System.Drawing.Size(142, 17);
            this.firstSectionLengthScrollBar.TabIndex = 18;
            this.firstSectionLengthScrollBar.Value = 10;
            this.firstSectionLengthScrollBar.ValueChanged += new System.EventHandler(this.firstSectionLengthScrollBar_ValueChanged);
            // 
            // tunnelWidthTextBox
            // 
            this.tunnelWidthTextBox.Enabled = false;
            this.tunnelWidthTextBox.Location = new System.Drawing.Point(161, 359);
            this.tunnelWidthTextBox.Name = "tunnelWidthTextBox";
            this.tunnelWidthTextBox.Size = new System.Drawing.Size(52, 20);
            this.tunnelWidthTextBox.TabIndex = 17;
            this.tunnelWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ширина туннеля, м:";
            // 
            // tunnelWidthScrollBar
            // 
            this.tunnelWidthScrollBar.Location = new System.Drawing.Point(16, 360);
            this.tunnelWidthScrollBar.Maximum = 109;
            this.tunnelWidthScrollBar.Minimum = 1;
            this.tunnelWidthScrollBar.Name = "tunnelWidthScrollBar";
            this.tunnelWidthScrollBar.Size = new System.Drawing.Size(142, 17);
            this.tunnelWidthScrollBar.TabIndex = 15;
            this.tunnelWidthScrollBar.Value = 20;
            this.tunnelWidthScrollBar.ValueChanged += new System.EventHandler(this.tunnelWidthScrollBar_ValueChanged);
            // 
            // startSpeedTextBox
            // 
            this.startSpeedTextBox.Enabled = false;
            this.startSpeedTextBox.Location = new System.Drawing.Point(161, 250);
            this.startSpeedTextBox.Name = "startSpeedTextBox";
            this.startSpeedTextBox.Size = new System.Drawing.Size(52, 20);
            this.startSpeedTextBox.TabIndex = 14;
            this.startSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Начальная скорость, м/c:";
            // 
            // startSpeedScrollBar
            // 
            this.startSpeedScrollBar.Location = new System.Drawing.Point(16, 251);
            this.startSpeedScrollBar.Maximum = 109;
            this.startSpeedScrollBar.Name = "startSpeedScrollBar";
            this.startSpeedScrollBar.Size = new System.Drawing.Size(142, 17);
            this.startSpeedScrollBar.TabIndex = 12;
            this.startSpeedScrollBar.Value = 10;
            this.startSpeedScrollBar.ValueChanged += new System.EventHandler(this.startSpeedScrollBar_ValueChanged);
            // 
            // startXPosTextBox
            // 
            this.startXPosTextBox.Enabled = false;
            this.startXPosTextBox.Location = new System.Drawing.Point(161, 139);
            this.startXPosTextBox.Name = "startXPosTextBox";
            this.startXPosTextBox.Size = new System.Drawing.Size(52, 20);
            this.startXPosTextBox.TabIndex = 11;
            this.startXPosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Начальное положение по X, м:";
            // 
            // startXPosScrollBar
            // 
            this.startXPosScrollBar.Location = new System.Drawing.Point(11, 140);
            this.startXPosScrollBar.Maximum = 1009;
            this.startXPosScrollBar.Minimum = -1000;
            this.startXPosScrollBar.Name = "startXPosScrollBar";
            this.startXPosScrollBar.Size = new System.Drawing.Size(147, 17);
            this.startXPosScrollBar.TabIndex = 9;
            this.startXPosScrollBar.ValueChanged += new System.EventHandler(this.startXPosScrollBar_ValueChanged);
            // 
            // frictionCoefNumericUpDown
            // 
            this.frictionCoefNumericUpDown.DecimalPlaces = 2;
            this.frictionCoefNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frictionCoefNumericUpDown.Location = new System.Drawing.Point(118, 83);
            this.frictionCoefNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.frictionCoefNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frictionCoefNumericUpDown.Name = "frictionCoefNumericUpDown";
            this.frictionCoefNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.frictionCoefNumericUpDown.TabIndex = 8;
            this.frictionCoefNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэф. трения о лёд:";
            // 
            // washerRadiusNumericUpDown
            // 
            this.washerRadiusNumericUpDown.Location = new System.Drawing.Point(118, 54);
            this.washerRadiusNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.washerRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.washerRadiusNumericUpDown.Name = "washerRadiusNumericUpDown";
            this.washerRadiusNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.washerRadiusNumericUpDown.TabIndex = 6;
            this.washerRadiusNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.washerRadiusNumericUpDown.ValueChanged += new System.EventHandler(this.washerRadiusNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Радиус шайбы, см.:";
            // 
            // washerMassNumericUpDown
            // 
            this.washerMassNumericUpDown.Location = new System.Drawing.Point(118, 24);
            this.washerMassNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.washerMassNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.washerMassNumericUpDown.Name = "washerMassNumericUpDown";
            this.washerMassNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.washerMassNumericUpDown.TabIndex = 4;
            this.washerMassNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.washerMassNumericUpDown.ValueChanged += new System.EventHandler(this.washerMassNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масса шайбы, г.:";
            // 
            // startAngleTextBox
            // 
            this.startAngleTextBox.Enabled = false;
            this.startAngleTextBox.Location = new System.Drawing.Point(161, 303);
            this.startAngleTextBox.Name = "startAngleTextBox";
            this.startAngleTextBox.Size = new System.Drawing.Size(52, 20);
            this.startAngleTextBox.TabIndex = 2;
            this.startAngleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальный угол:";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Enabled = false;
            this.scaleTextBox.Location = new System.Drawing.Point(133, 247);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(52, 20);
            this.scaleTextBox.TabIndex = 29;
            this.scaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Масштаб:";
            // 
            // scaleScrollBar
            // 
            this.scaleScrollBar.Location = new System.Drawing.Point(14, 249);
            this.scaleScrollBar.Maximum = 1009;
            this.scaleScrollBar.Minimum = 1;
            this.scaleScrollBar.Name = "scaleScrollBar";
            this.scaleScrollBar.Size = new System.Drawing.Size(113, 17);
            this.scaleScrollBar.TabIndex = 27;
            this.scaleScrollBar.Value = 10;
            this.scaleScrollBar.ValueChanged += new System.EventHandler(this.scaleScrollBar_ValueChanged);
            // 
            // mainFieldPictureBox
            // 
            this.mainFieldPictureBox.BackColor = System.Drawing.Color.White;
            this.mainFieldPictureBox.Location = new System.Drawing.Point(13, 12);
            this.mainFieldPictureBox.Name = "mainFieldPictureBox";
            this.mainFieldPictureBox.Size = new System.Drawing.Size(541, 559);
            this.mainFieldPictureBox.TabIndex = 2;
            this.mainFieldPictureBox.TabStop = false;
            this.mainFieldPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainFieldPictureBox_MouseDown);
            this.mainFieldPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainFieldPictureBox_MouseMove);
            this.mainFieldPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainFieldPictureBox_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stopModButton);
            this.groupBox2.Controls.Add(this.startModButton);
            this.groupBox2.Location = new System.Drawing.Point(794, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запуск моделирования";
            // 
            // stopModButton
            // 
            this.stopModButton.BackColor = System.Drawing.Color.Gold;
            this.stopModButton.Location = new System.Drawing.Point(7, 49);
            this.stopModButton.Name = "stopModButton";
            this.stopModButton.Size = new System.Drawing.Size(75, 23);
            this.stopModButton.TabIndex = 1;
            this.stopModButton.Text = "Остановить";
            this.stopModButton.UseVisualStyleBackColor = false;
            this.stopModButton.Click += new System.EventHandler(this.stopModButton_Click);
            // 
            // startModButton
            // 
            this.startModButton.BackColor = System.Drawing.Color.SpringGreen;
            this.startModButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startModButton.Location = new System.Drawing.Point(7, 19);
            this.startModButton.Name = "startModButton";
            this.startModButton.Size = new System.Drawing.Size(75, 23);
            this.startModButton.TabIndex = 0;
            this.startModButton.Text = "Запуск";
            this.startModButton.UseVisualStyleBackColor = false;
            this.startModButton.Click += new System.EventHandler(this.startModButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cameraPosYTextBox);
            this.groupBox3.Controls.Add(this.cameraPosXTextBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.CameraPosLabel);
            this.groupBox3.Controls.Add(this.drawPathCheckBox);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.drawChecksCheckBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.scaleTextBox);
            this.groupBox3.Controls.Add(this.scaleScrollBar);
            this.groupBox3.Location = new System.Drawing.Point(794, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 341);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительные опции";
            // 
            // cameraPosYTextBox
            // 
            this.cameraPosYTextBox.BackColor = System.Drawing.Color.Silver;
            this.cameraPosYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cameraPosYTextBox.Enabled = false;
            this.cameraPosYTextBox.Location = new System.Drawing.Point(102, 303);
            this.cameraPosYTextBox.Name = "cameraPosYTextBox";
            this.cameraPosYTextBox.Size = new System.Drawing.Size(40, 13);
            this.cameraPosYTextBox.TabIndex = 42;
            // 
            // cameraPosXTextBox
            // 
            this.cameraPosXTextBox.BackColor = System.Drawing.Color.Silver;
            this.cameraPosXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cameraPosXTextBox.Enabled = false;
            this.cameraPosXTextBox.Location = new System.Drawing.Point(30, 304);
            this.cameraPosXTextBox.Name = "cameraPosXTextBox";
            this.cameraPosXTextBox.Size = new System.Drawing.Size(40, 13);
            this.cameraPosXTextBox.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 304);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Y:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "X:";
            // 
            // CameraPosLabel
            // 
            this.CameraPosLabel.AutoSize = true;
            this.CameraPosLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CameraPosLabel.Location = new System.Drawing.Point(11, 283);
            this.CameraPosLabel.Name = "CameraPosLabel";
            this.CameraPosLabel.Size = new System.Drawing.Size(111, 13);
            this.CameraPosLabel.TabIndex = 38;
            this.CameraPosLabel.Text = "Положение камеры:";
            this.CameraPosLabel.Click += new System.EventHandler(this.CameraPosLabel_Click);
            // 
            // drawPathCheckBox
            // 
            this.drawPathCheckBox.AutoSize = true;
            this.drawPathCheckBox.Location = new System.Drawing.Point(14, 54);
            this.drawPathCheckBox.Name = "drawPathCheckBox";
            this.drawPathCheckBox.Size = new System.Drawing.Size(106, 17);
            this.drawPathCheckBox.TabIndex = 37;
            this.drawPathCheckBox.Text = "Отрисовка пути";
            this.drawPathCheckBox.UseVisualStyleBackColor = true;
            this.drawPathCheckBox.CheckedChanged += new System.EventHandler(this.drawPathCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.stepNumericUpDown);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.useStepRadioButton);
            this.panel1.Controls.Add(this.useElTimeRadioButton);
            this.panel1.Location = new System.Drawing.Point(7, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 122);
            this.panel1.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Размер шага:";
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Location = new System.Drawing.Point(87, 71);
            this.stepNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.stepNumericUpDown.TabIndex = 38;
            this.stepNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Использовать:";
            // 
            // useStepRadioButton
            // 
            this.useStepRadioButton.AutoSize = true;
            this.useStepRadioButton.Location = new System.Drawing.Point(14, 49);
            this.useStepRadioButton.Name = "useStepRadioButton";
            this.useStepRadioButton.Size = new System.Drawing.Size(44, 17);
            this.useStepRadioButton.TabIndex = 36;
            this.useStepRadioButton.Text = "шаг";
            this.useStepRadioButton.UseVisualStyleBackColor = true;
            this.useStepRadioButton.CheckedChanged += new System.EventHandler(this.useStepRadioButton_CheckedChanged);
            // 
            // useElTimeRadioButton
            // 
            this.useElTimeRadioButton.AutoSize = true;
            this.useElTimeRadioButton.Checked = true;
            this.useElTimeRadioButton.Location = new System.Drawing.Point(13, 26);
            this.useElTimeRadioButton.Name = "useElTimeRadioButton";
            this.useElTimeRadioButton.Size = new System.Drawing.Size(118, 17);
            this.useElTimeRadioButton.TabIndex = 35;
            this.useElTimeRadioButton.TabStop = true;
            this.useElTimeRadioButton.Text = "прошедшее время";
            this.useElTimeRadioButton.UseVisualStyleBackColor = true;
            this.useElTimeRadioButton.CheckedChanged += new System.EventHandler(this.useElTimeRadioButton_CheckedChanged);
            // 
            // drawChecksCheckBox
            // 
            this.drawChecksCheckBox.AutoSize = true;
            this.drawChecksCheckBox.Location = new System.Drawing.Point(14, 27);
            this.drawChecksCheckBox.Name = "drawChecksCheckBox";
            this.drawChecksCheckBox.Size = new System.Drawing.Size(132, 17);
            this.drawChecksCheckBox.TabIndex = 34;
            this.drawChecksCheckBox.Text = "Отрисовка проверок";
            this.drawChecksCheckBox.UseVisualStyleBackColor = true;
            this.drawChecksCheckBox.CheckedChanged += new System.EventHandler(this.drawChecksCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1005, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mainFieldPictureBox);
            this.Controls.Add(this.paramsGroupBox);
            this.Name = "Form1";
            this.Text = "Шайбометатель 3000";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paramsGroupBox.ResumeLayout(false);
            this.paramsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frictionCoefNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.washerRadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.washerMassNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFieldPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar startAngleScrollBar;
        private System.Windows.Forms.GroupBox paramsGroupBox;
        private System.Windows.Forms.TextBox startAngleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainFieldPictureBox;
        private System.Windows.Forms.NumericUpDown frictionCoefNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown washerRadiusNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown washerMassNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startXPosTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar startXPosScrollBar;
        private System.Windows.Forms.TextBox startSpeedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar startSpeedScrollBar;
        private System.Windows.Forms.TextBox tunnelWidthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar tunnelWidthScrollBar;
        private System.Windows.Forms.TextBox tunnelAngleTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HScrollBar tunnelAngleScrollBar;
        private System.Windows.Forms.TextBox secondSectionLengthTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar secondSectionLengthScrollBar;
        private System.Windows.Forms.TextBox firstSectionLengthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar firstSectionLengthScrollBar;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.HScrollBar scaleScrollBar;
        private System.Windows.Forms.TextBox startYPosTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.HScrollBar startYPosScrollBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startModButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox drawChecksCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton useElTimeRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton useStepRadioButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.Button stopModButton;
        private System.Windows.Forms.CheckBox drawPathCheckBox;
        private System.Windows.Forms.TextBox cameraPosYTextBox;
        private System.Windows.Forms.TextBox cameraPosXTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CameraPosLabel;
    }
}

