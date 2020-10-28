namespace AI.UI
{
    partial class FormMain
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPSO = new System.Windows.Forms.Button();
            this.buttonABC = new System.Windows.Forms.Button();
            this.buttonGA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1061, 32);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evolutionary Algorithms";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.Location = new System.Drawing.Point(1031, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(24, 24);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.buttonPSO);
            this.panelMenu.Controls.Add(this.buttonABC);
            this.panelMenu.Controls.Add(this.buttonGA);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 503);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonPSO
            // 
            this.buttonPSO.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPSO.FlatAppearance.BorderSize = 0;
            this.buttonPSO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonPSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPSO.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPSO.Image = global::AI.UI.Properties.Resources.iconfinder_atom1_216197_1;
            this.buttonPSO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPSO.Location = new System.Drawing.Point(0, 197);
            this.buttonPSO.Name = "buttonPSO";
            this.buttonPSO.Size = new System.Drawing.Size(210, 46);
            this.buttonPSO.TabIndex = 15;
            this.buttonPSO.Text = "PSO";
            this.buttonPSO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPSO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPSO.UseVisualStyleBackColor = true;
            this.buttonPSO.Click += new System.EventHandler(this.ButtonAlgorithm_Click);
            // 
            // buttonABC
            // 
            this.buttonABC.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonABC.FlatAppearance.BorderSize = 0;
            this.buttonABC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonABC.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonABC.Image = global::AI.UI.Properties.Resources.iconfinder_Honny_Bee_2976464_1;
            this.buttonABC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonABC.Location = new System.Drawing.Point(0, 151);
            this.buttonABC.Name = "buttonABC";
            this.buttonABC.Size = new System.Drawing.Size(210, 46);
            this.buttonABC.TabIndex = 14;
            this.buttonABC.Text = "ABC";
            this.buttonABC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonABC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonABC.UseVisualStyleBackColor = true;
            this.buttonABC.Click += new System.EventHandler(this.ButtonAlgorithm_Click);
            // 
            // buttonGA
            // 
            this.buttonGA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGA.FlatAppearance.BorderSize = 0;
            this.buttonGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGA.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGA.Image = global::AI.UI.Properties.Resources.dna1;
            this.buttonGA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGA.Location = new System.Drawing.Point(0, 105);
            this.buttonGA.Name = "buttonGA";
            this.buttonGA.Size = new System.Drawing.Size(210, 46);
            this.buttonGA.TabIndex = 13;
            this.buttonGA.Text = "Genetik Algoritma";
            this.buttonGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGA.UseVisualStyleBackColor = true;
            this.buttonGA.Click += new System.EventHandler(this.ButtonAlgorithm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 5);
            this.panel1.TabIndex = 8;
            // 
            // panelName
            // 
            this.panelName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelName.Controls.Add(this.pictureBoxName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 5);
            this.panelName.Name = "panelName";
            this.panelName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelName.Size = new System.Drawing.Size(210, 95);
            this.panelName.TabIndex = 9;
            this.panelName.Click += new System.EventHandler(this.PanelName_Click);
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxName.Image = global::AI.UI.Properties.Resources.name;
            this.pictureBoxName.Location = new System.Drawing.Point(10, 0);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(190, 95);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxName.TabIndex = 0;
            this.pictureBoxName.TabStop = false;
            this.pictureBoxName.Click += new System.EventHandler(this.PanelName_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 5);
            this.panel3.TabIndex = 7;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(210, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(851, 503);
            this.panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 535);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPSO;
        private System.Windows.Forms.Button buttonABC;
        private System.Windows.Forms.Button buttonGA;
    }
}

