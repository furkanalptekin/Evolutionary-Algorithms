namespace AI.UI
{
    partial class FormMinimizeProblems
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelRate2 = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownGeneration = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownRate2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChartDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBeginningX = new System.Windows.Forms.Label();
            this.labelCurrentFunc = new System.Windows.Forms.Label();
            this.labelFinalFunc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelBeginningY = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCurrentY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCurrentX = new System.Windows.Forms.Label();
            this.labelBeginningFunc = new System.Windows.Forms.Label();
            this.labelFinalX = new System.Windows.Forms.Label();
            this.labelFinalY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new AI.UI.CustomProgressBar();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numericUpDownPopulation);
            this.panel3.Controls.Add(this.labelRate2);
            this.panel3.Controls.Add(this.labelRate);
            this.panel3.Controls.Add(this.buttonCalculate);
            this.panel3.Controls.Add(this.comboBoxAlgorithm);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.numericUpDownGeneration);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numericUpDownRate2);
            this.panel3.Controls.Add(this.numericUpDownChartDelay);
            this.panel3.Controls.Add(this.numericUpDownRate);
            this.panel3.Location = new System.Drawing.Point(18, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 304);
            this.panel3.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(15, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Chart Delay : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Population : ";
            // 
            // numericUpDownPopulation
            // 
            this.numericUpDownPopulation.Location = new System.Drawing.Point(109, 43);
            this.numericUpDownPopulation.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPopulation.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPopulation.Name = "numericUpDownPopulation";
            this.numericUpDownPopulation.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownPopulation.TabIndex = 1;
            this.numericUpDownPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPopulation.ThousandsSeparator = true;
            this.numericUpDownPopulation.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelRate2
            // 
            this.labelRate2.AutoSize = true;
            this.labelRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRate2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRate2.Location = new System.Drawing.Point(64, 152);
            this.labelRate2.Name = "labelRate2";
            this.labelRate2.Size = new System.Drawing.Size(31, 15);
            this.labelRate2.TabIndex = 2;
            this.labelRate2.Text = "C2 : ";
            this.labelRate2.Visible = false;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRate.Location = new System.Drawing.Point(64, 117);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(31, 15);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "C1 : ";
            this.labelRate.Visible = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.White;
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCalculate.Image = global::AI.UI.Properties.Resources.iconfinder_bag_4213589;
            this.buttonCalculate.Location = new System.Drawing.Point(60, 220);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(193, 72);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(109, 7);
            this.comboBoxAlgorithm.MaxDropDownItems = 20;
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(193, 21);
            this.comboBoxAlgorithm.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(18, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Generation : ";
            // 
            // numericUpDownGeneration
            // 
            this.numericUpDownGeneration.Location = new System.Drawing.Point(109, 79);
            this.numericUpDownGeneration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGeneration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGeneration.Name = "numericUpDownGeneration";
            this.numericUpDownGeneration.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownGeneration.TabIndex = 1;
            this.numericUpDownGeneration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownGeneration.ThousandsSeparator = true;
            this.numericUpDownGeneration.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(32, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Function : ";
            // 
            // numericUpDownRate2
            // 
            this.numericUpDownRate2.DecimalPlaces = 5;
            this.numericUpDownRate2.Location = new System.Drawing.Point(109, 149);
            this.numericUpDownRate2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRate2.Name = "numericUpDownRate2";
            this.numericUpDownRate2.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownRate2.TabIndex = 1;
            this.numericUpDownRate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRate2.ThousandsSeparator = true;
            this.numericUpDownRate2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRate2.Visible = false;
            // 
            // numericUpDownChartDelay
            // 
            this.numericUpDownChartDelay.Location = new System.Drawing.Point(109, 184);
            this.numericUpDownChartDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownChartDelay.Name = "numericUpDownChartDelay";
            this.numericUpDownChartDelay.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownChartDelay.TabIndex = 1;
            this.numericUpDownChartDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownChartDelay.ThousandsSeparator = true;
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.DecimalPlaces = 5;
            this.numericUpDownRate.Location = new System.Drawing.Point(109, 114);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownRate.TabIndex = 1;
            this.numericUpDownRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRate.ThousandsSeparator = true;
            this.numericUpDownRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownRate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(40, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beginning X : ";
            // 
            // labelBeginningX
            // 
            this.labelBeginningX.AutoSize = true;
            this.labelBeginningX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBeginningX.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBeginningX.Location = new System.Drawing.Point(125, 13);
            this.labelBeginningX.Name = "labelBeginningX";
            this.labelBeginningX.Size = new System.Drawing.Size(11, 15);
            this.labelBeginningX.TabIndex = 4;
            this.labelBeginningX.Text = "-";
            // 
            // labelCurrentFunc
            // 
            this.labelCurrentFunc.AutoSize = true;
            this.labelCurrentFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentFunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentFunc.Location = new System.Drawing.Point(395, 69);
            this.labelCurrentFunc.Name = "labelCurrentFunc";
            this.labelCurrentFunc.Size = new System.Drawing.Size(11, 15);
            this.labelCurrentFunc.TabIndex = 5;
            this.labelCurrentFunc.Text = "-";
            // 
            // labelFinalFunc
            // 
            this.labelFinalFunc.AutoSize = true;
            this.labelFinalFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinalFunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFinalFunc.Location = new System.Drawing.Point(648, 69);
            this.labelFinalFunc.Name = "labelFinalFunc";
            this.labelFinalFunc.Size = new System.Drawing.Size(11, 15);
            this.labelFinalFunc.TabIndex = 5;
            this.labelFinalFunc.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(40, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beginning Y : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(568, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Final Func : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(303, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Current Func : ";
            // 
            // labelBeginningY
            // 
            this.labelBeginningY.AutoSize = true;
            this.labelBeginningY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBeginningY.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBeginningY.Location = new System.Drawing.Point(125, 41);
            this.labelBeginningY.Name = "labelBeginningY";
            this.labelBeginningY.Size = new System.Drawing.Size(11, 15);
            this.labelBeginningY.TabIndex = 4;
            this.labelBeginningY.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(323, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Current Y : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beginning Func : ";
            // 
            // labelCurrentY
            // 
            this.labelCurrentY.AutoSize = true;
            this.labelCurrentY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentY.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentY.Location = new System.Drawing.Point(395, 41);
            this.labelCurrentY.Name = "labelCurrentY";
            this.labelCurrentY.Size = new System.Drawing.Size(11, 15);
            this.labelCurrentY.TabIndex = 4;
            this.labelCurrentY.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(588, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Final X : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(323, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Current X : ";
            // 
            // labelCurrentX
            // 
            this.labelCurrentX.AutoSize = true;
            this.labelCurrentX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentX.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentX.Location = new System.Drawing.Point(395, 13);
            this.labelCurrentX.Name = "labelCurrentX";
            this.labelCurrentX.Size = new System.Drawing.Size(11, 15);
            this.labelCurrentX.TabIndex = 4;
            this.labelCurrentX.Text = "-";
            // 
            // labelBeginningFunc
            // 
            this.labelBeginningFunc.AutoSize = true;
            this.labelBeginningFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBeginningFunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBeginningFunc.Location = new System.Drawing.Point(125, 69);
            this.labelBeginningFunc.Name = "labelBeginningFunc";
            this.labelBeginningFunc.Size = new System.Drawing.Size(11, 15);
            this.labelBeginningFunc.TabIndex = 5;
            this.labelBeginningFunc.Text = "-";
            // 
            // labelFinalX
            // 
            this.labelFinalX.AutoSize = true;
            this.labelFinalX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinalX.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFinalX.Location = new System.Drawing.Point(648, 13);
            this.labelFinalX.Name = "labelFinalX";
            this.labelFinalX.Size = new System.Drawing.Size(11, 15);
            this.labelFinalX.TabIndex = 4;
            this.labelFinalX.Text = "-";
            // 
            // labelFinalY
            // 
            this.labelFinalY.AutoSize = true;
            this.labelFinalY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinalY.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFinalY.Location = new System.Drawing.Point(648, 41);
            this.labelFinalY.Name = "labelFinalY";
            this.labelFinalY.Size = new System.Drawing.Size(11, 15);
            this.labelFinalY.TabIndex = 4;
            this.labelFinalY.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelBeginningX);
            this.panel1.Controls.Add(this.labelCurrentFunc);
            this.panel1.Controls.Add(this.labelFinalFunc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.labelBeginningY);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelCurrentY);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.labelCurrentX);
            this.panel1.Controls.Add(this.labelBeginningFunc);
            this.panel1.Controls.Add(this.labelFinalX);
            this.panel1.Controls.Add(this.labelFinalY);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 99);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(588, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final Y : ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(331, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 304);
            this.panel2.TabIndex = 15;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderWidth = 10;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.Name = "Func";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(497, 303);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(18, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(141, 25);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Algoritma Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(314, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Current Gen : ";
            // 
            // progressBar1
            // 
            this.progressBar1.CustomText = null;
            this.progressBar1.Location = new System.Drawing.Point(419, 477);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // FormMinimizeProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(847, 505);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMinimizeProblems";
            this.Text = "FormGA";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericUpDownPopulation;
        private System.Windows.Forms.Label labelRate2;
        private System.Windows.Forms.Label labelRate;
        public System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numericUpDownGeneration;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown numericUpDownRate2;
        public System.Windows.Forms.NumericUpDown numericUpDownChartDelay;
        public System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBeginningX;
        private System.Windows.Forms.Label labelCurrentFunc;
        private System.Windows.Forms.Label labelFinalFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelBeginningY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCurrentY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelCurrentX;
        private System.Windows.Forms.Label labelBeginningFunc;
        private System.Windows.Forms.Label labelFinalX;
        private System.Windows.Forms.Label labelFinalY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label13;
        private CustomProgressBar progressBar1;
    }
}