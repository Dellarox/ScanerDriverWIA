
namespace ScanerDriverWIA
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxScannedImage = new System.Windows.Forms.PictureBox();
            this.labelChooseScaner = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonRefreshDevices = new System.Windows.Forms.Button();
            this.radioButton1BitMode = new System.Windows.Forms.RadioButton();
            this.radioButtonGreyScaleMode = new System.Windows.Forms.RadioButton();
            this.labelScanMode = new System.Windows.Forms.Label();
            this.radioButtonRGBMode = new System.Windows.Forms.RadioButton();
            this.groupBoxScan = new System.Windows.Forms.GroupBox();
            this.radioButtonDPI300 = new System.Windows.Forms.RadioButton();
            this.radioButtonDPI150 = new System.Windows.Forms.RadioButton();
            this.radioButtonDPI100 = new System.Windows.Forms.RadioButton();
            this.radioButtonDPI400 = new System.Windows.Forms.RadioButton();
            this.radioButtonDPI200 = new System.Windows.Forms.RadioButton();
            this.radioButtonDPI600 = new System.Windows.Forms.RadioButton();
            this.labelChooseDPI = new System.Windows.Forms.Label();
            this.radioButtonDPI1200 = new System.Windows.Forms.RadioButton();
            this.groupBoxDPI = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.labelSetSize = new System.Windows.Forms.Label();
            this.labelVertical = new System.Windows.Forms.Label();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.textBoxVertical = new System.Windows.Forms.TextBox();
            this.textBoxHorizontal = new System.Windows.Forms.TextBox();
            this.buttonScanSystemApp = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.radioButtonPNGFormat = new System.Windows.Forms.RadioButton();
            this.radioButtonJPGFormat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedImage)).BeginInit();
            this.groupBoxScan.SuspendLayout();
            this.groupBoxDPI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxScannedImage
            // 
            this.pictureBoxScannedImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxScannedImage.Name = "pictureBoxScannedImage";
            this.pictureBoxScannedImage.Size = new System.Drawing.Size(613, 906);
            this.pictureBoxScannedImage.TabIndex = 0;
            this.pictureBoxScannedImage.TabStop = false;
            // 
            // labelChooseScaner
            // 
            this.labelChooseScaner.AutoSize = true;
            this.labelChooseScaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseScaner.Location = new System.Drawing.Point(633, 15);
            this.labelChooseScaner.Name = "labelChooseScaner";
            this.labelChooseScaner.Size = new System.Drawing.Size(122, 18);
            this.labelChooseScaner.TabIndex = 1;
            this.labelChooseScaner.Text = "Choose scanner:";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(754, 12);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(289, 26);
            this.comboBoxDevices.TabIndex = 2;
            this.comboBoxDevices.Text = "No device selected";
            // 
            // buttonRefreshDevices
            // 
            this.buttonRefreshDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshDevices.Location = new System.Drawing.Point(1049, 12);
            this.buttonRefreshDevices.Name = "buttonRefreshDevices";
            this.buttonRefreshDevices.Size = new System.Drawing.Size(150, 26);
            this.buttonRefreshDevices.TabIndex = 3;
            this.buttonRefreshDevices.Text = "Refresh devices";
            this.buttonRefreshDevices.UseVisualStyleBackColor = true;
            this.buttonRefreshDevices.Click += new System.EventHandler(this.buttonRefreshDevices_Click);
            // 
            // radioButton1BitMode
            // 
            this.radioButton1BitMode.AutoSize = true;
            this.radioButton1BitMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1BitMode.Location = new System.Drawing.Point(149, 19);
            this.radioButton1BitMode.Name = "radioButton1BitMode";
            this.radioButton1BitMode.Size = new System.Drawing.Size(54, 22);
            this.radioButton1BitMode.TabIndex = 13;
            this.radioButton1BitMode.Text = "1-bit";
            this.radioButton1BitMode.UseVisualStyleBackColor = true;
            this.radioButton1BitMode.CheckedChanged += new System.EventHandler(this.radioButton1BitMode_CheckedChanged);
            // 
            // radioButtonGreyScaleMode
            // 
            this.radioButtonGreyScaleMode.AutoSize = true;
            this.radioButtonGreyScaleMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonGreyScaleMode.Location = new System.Drawing.Point(207, 19);
            this.radioButtonGreyScaleMode.Name = "radioButtonGreyScaleMode";
            this.radioButtonGreyScaleMode.Size = new System.Drawing.Size(97, 22);
            this.radioButtonGreyScaleMode.TabIndex = 14;
            this.radioButtonGreyScaleMode.Text = "Grey scale";
            this.radioButtonGreyScaleMode.UseVisualStyleBackColor = true;
            this.radioButtonGreyScaleMode.CheckedChanged += new System.EventHandler(this.radioButtonGreyScaleMode_CheckedChanged);
            // 
            // labelScanMode
            // 
            this.labelScanMode.AutoSize = true;
            this.labelScanMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanMode.Location = new System.Drawing.Point(0, 21);
            this.labelScanMode.Name = "labelScanMode";
            this.labelScanMode.Size = new System.Drawing.Size(143, 18);
            this.labelScanMode.TabIndex = 12;
            this.labelScanMode.Text = "Choose scan mode:";
            // 
            // radioButtonRGBMode
            // 
            this.radioButtonRGBMode.AutoSize = true;
            this.radioButtonRGBMode.Checked = true;
            this.radioButtonRGBMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonRGBMode.Location = new System.Drawing.Point(310, 19);
            this.radioButtonRGBMode.Name = "radioButtonRGBMode";
            this.radioButtonRGBMode.Size = new System.Drawing.Size(59, 22);
            this.radioButtonRGBMode.TabIndex = 15;
            this.radioButtonRGBMode.TabStop = true;
            this.radioButtonRGBMode.Text = "RGB";
            this.radioButtonRGBMode.UseVisualStyleBackColor = true;
            this.radioButtonRGBMode.CheckedChanged += new System.EventHandler(this.radioButtonRGBMode_CheckedChanged);
            // 
            // groupBoxScan
            // 
            this.groupBoxScan.Controls.Add(this.radioButtonRGBMode);
            this.groupBoxScan.Controls.Add(this.labelScanMode);
            this.groupBoxScan.Controls.Add(this.radioButtonGreyScaleMode);
            this.groupBoxScan.Controls.Add(this.radioButton1BitMode);
            this.groupBoxScan.Location = new System.Drawing.Point(631, 150);
            this.groupBoxScan.Name = "groupBoxScan";
            this.groupBoxScan.Size = new System.Drawing.Size(581, 56);
            this.groupBoxScan.TabIndex = 16;
            this.groupBoxScan.TabStop = false;
            this.groupBoxScan.Text = "Scan mode";
            // 
            // radioButtonDPI300
            // 
            this.radioButtonDPI300.AutoSize = true;
            this.radioButtonDPI300.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI300.Location = new System.Drawing.Point(263, 19);
            this.radioButtonDPI300.Name = "radioButtonDPI300";
            this.radioButtonDPI300.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI300.TabIndex = 8;
            this.radioButtonDPI300.Text = "300";
            this.radioButtonDPI300.UseVisualStyleBackColor = true;
            this.radioButtonDPI300.CheckedChanged += new System.EventHandler(this.radioButtonDPI300_CheckedChanged);
            // 
            // radioButtonDPI150
            // 
            this.radioButtonDPI150.AutoSize = true;
            this.radioButtonDPI150.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI150.Location = new System.Drawing.Point(151, 19);
            this.radioButtonDPI150.Name = "radioButtonDPI150";
            this.radioButtonDPI150.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI150.TabIndex = 7;
            this.radioButtonDPI150.Text = "150";
            this.radioButtonDPI150.UseVisualStyleBackColor = true;
            this.radioButtonDPI150.CheckedChanged += new System.EventHandler(this.radioButtonDPI150_CheckedChanged);
            // 
            // radioButtonDPI100
            // 
            this.radioButtonDPI100.AutoSize = true;
            this.radioButtonDPI100.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI100.Location = new System.Drawing.Point(95, 19);
            this.radioButtonDPI100.Name = "radioButtonDPI100";
            this.radioButtonDPI100.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI100.TabIndex = 6;
            this.radioButtonDPI100.Text = "100";
            this.radioButtonDPI100.UseVisualStyleBackColor = true;
            this.radioButtonDPI100.CheckedChanged += new System.EventHandler(this.radioButtonDPI100_CheckedChanged);
            // 
            // radioButtonDPI400
            // 
            this.radioButtonDPI400.AutoSize = true;
            this.radioButtonDPI400.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI400.Location = new System.Drawing.Point(319, 19);
            this.radioButtonDPI400.Name = "radioButtonDPI400";
            this.radioButtonDPI400.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI400.TabIndex = 10;
            this.radioButtonDPI400.Text = "400";
            this.radioButtonDPI400.UseVisualStyleBackColor = true;
            this.radioButtonDPI400.CheckedChanged += new System.EventHandler(this.radioButtonDPI400_CheckedChanged);
            // 
            // radioButtonDPI200
            // 
            this.radioButtonDPI200.AutoSize = true;
            this.radioButtonDPI200.Checked = true;
            this.radioButtonDPI200.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI200.Location = new System.Drawing.Point(207, 19);
            this.radioButtonDPI200.Name = "radioButtonDPI200";
            this.radioButtonDPI200.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI200.TabIndex = 5;
            this.radioButtonDPI200.TabStop = true;
            this.radioButtonDPI200.Text = "200";
            this.radioButtonDPI200.UseVisualStyleBackColor = true;
            this.radioButtonDPI200.CheckedChanged += new System.EventHandler(this.radioButtonDPI200_CheckedChanged);
            // 
            // radioButtonDPI600
            // 
            this.radioButtonDPI600.AutoSize = true;
            this.radioButtonDPI600.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI600.Location = new System.Drawing.Point(375, 19);
            this.radioButtonDPI600.Name = "radioButtonDPI600";
            this.radioButtonDPI600.Size = new System.Drawing.Size(50, 22);
            this.radioButtonDPI600.TabIndex = 11;
            this.radioButtonDPI600.Text = "600";
            this.radioButtonDPI600.UseVisualStyleBackColor = true;
            this.radioButtonDPI600.CheckedChanged += new System.EventHandler(this.radioButtonDPI600_CheckedChanged);
            // 
            // labelChooseDPI
            // 
            this.labelChooseDPI.AutoSize = true;
            this.labelChooseDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseDPI.Location = new System.Drawing.Point(0, 21);
            this.labelChooseDPI.Name = "labelChooseDPI";
            this.labelChooseDPI.Size = new System.Drawing.Size(93, 18);
            this.labelChooseDPI.TabIndex = 4;
            this.labelChooseDPI.Text = "Choose DPI:";
            // 
            // radioButtonDPI1200
            // 
            this.radioButtonDPI1200.AutoSize = true;
            this.radioButtonDPI1200.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDPI1200.Location = new System.Drawing.Point(431, 19);
            this.radioButtonDPI1200.Name = "radioButtonDPI1200";
            this.radioButtonDPI1200.Size = new System.Drawing.Size(58, 22);
            this.radioButtonDPI1200.TabIndex = 9;
            this.radioButtonDPI1200.Text = "1200";
            this.radioButtonDPI1200.UseVisualStyleBackColor = true;
            this.radioButtonDPI1200.CheckedChanged += new System.EventHandler(this.radioButtonDPI1200_CheckedChanged);
            // 
            // groupBoxDPI
            // 
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI1200);
            this.groupBoxDPI.Controls.Add(this.labelChooseDPI);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI600);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI200);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI400);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI100);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI150);
            this.groupBoxDPI.Controls.Add(this.radioButtonDPI300);
            this.groupBoxDPI.Location = new System.Drawing.Point(631, 76);
            this.groupBoxDPI.Name = "groupBoxDPI";
            this.groupBoxDPI.Size = new System.Drawing.Size(581, 56);
            this.groupBoxDPI.TabIndex = 17;
            this.groupBoxDPI.TabStop = false;
            this.groupBoxDPI.Text = "DPI";
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScan.Location = new System.Drawing.Point(636, 212);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(308, 71);
            this.buttonScan.TabIndex = 18;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // labelSetSize
            // 
            this.labelSetSize.AutoSize = true;
            this.labelSetSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSetSize.Location = new System.Drawing.Point(1016, 212);
            this.labelSetSize.Name = "labelSetSize";
            this.labelSetSize.Size = new System.Drawing.Size(183, 18);
            this.labelSetSize.TabIndex = 12;
            this.labelSetSize.Text = "Set size of scanner image:";
            // 
            // labelVertical
            // 
            this.labelVertical.AutoSize = true;
            this.labelVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVertical.Location = new System.Drawing.Point(950, 238);
            this.labelVertical.Name = "labelVertical";
            this.labelVertical.Size = new System.Drawing.Size(60, 18);
            this.labelVertical.TabIndex = 19;
            this.labelVertical.Text = "Vertical:";
            // 
            // labelHorizontal
            // 
            this.labelHorizontal.AutoSize = true;
            this.labelHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHorizontal.Location = new System.Drawing.Point(950, 265);
            this.labelHorizontal.Name = "labelHorizontal";
            this.labelHorizontal.Size = new System.Drawing.Size(80, 18);
            this.labelHorizontal.TabIndex = 20;
            this.labelHorizontal.Text = "Horizontal:";
            // 
            // textBoxVertical
            // 
            this.textBoxVertical.Location = new System.Drawing.Point(1049, 238);
            this.textBoxVertical.Name = "textBoxVertical";
            this.textBoxVertical.Size = new System.Drawing.Size(163, 20);
            this.textBoxVertical.TabIndex = 21;
            this.textBoxVertical.Text = "630";
            // 
            // textBoxHorizontal
            // 
            this.textBoxHorizontal.Location = new System.Drawing.Point(1049, 266);
            this.textBoxHorizontal.Name = "textBoxHorizontal";
            this.textBoxHorizontal.Size = new System.Drawing.Size(163, 20);
            this.textBoxHorizontal.TabIndex = 22;
            this.textBoxHorizontal.Text = "500";
            // 
            // buttonScanSystemApp
            // 
            this.buttonScanSystemApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScanSystemApp.Location = new System.Drawing.Point(636, 289);
            this.buttonScanSystemApp.Name = "buttonScanSystemApp";
            this.buttonScanSystemApp.Size = new System.Drawing.Size(308, 71);
            this.buttonScanSystemApp.TabIndex = 23;
            this.buttonScanSystemApp.Text = "Scan (by system app)";
            this.buttonScanSystemApp.UseVisualStyleBackColor = true;
            this.buttonScanSystemApp.Click += new System.EventHandler(this.buttonScanSystemApp_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveImage.Location = new System.Drawing.Point(636, 366);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(308, 71);
            this.buttonSaveImage.TabIndex = 24;
            this.buttonSaveImage.Text = "Save scanned image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // radioButtonPNGFormat
            // 
            this.radioButtonPNGFormat.AutoSize = true;
            this.radioButtonPNGFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPNGFormat.Location = new System.Drawing.Point(159, 43);
            this.radioButtonPNGFormat.Name = "radioButtonPNGFormat";
            this.radioButtonPNGFormat.Size = new System.Drawing.Size(54, 22);
            this.radioButtonPNGFormat.TabIndex = 7;
            this.radioButtonPNGFormat.Text = ".png";
            this.radioButtonPNGFormat.UseVisualStyleBackColor = true;
            // 
            // radioButtonJPGFormat
            // 
            this.radioButtonJPGFormat.AutoSize = true;
            this.radioButtonJPGFormat.Checked = true;
            this.radioButtonJPGFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonJPGFormat.Location = new System.Drawing.Point(159, 9);
            this.radioButtonJPGFormat.Name = "radioButtonJPGFormat";
            this.radioButtonJPGFormat.Size = new System.Drawing.Size(49, 22);
            this.radioButtonJPGFormat.TabIndex = 6;
            this.radioButtonJPGFormat.TabStop = true;
            this.radioButtonJPGFormat.Text = ".jpg";
            this.radioButtonJPGFormat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose save format:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonJPGFormat);
            this.groupBox1.Controls.Add(this.radioButtonPNGFormat);
            this.groupBox1.Location = new System.Drawing.Point(953, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 930);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonScanSystemApp);
            this.Controls.Add(this.textBoxHorizontal);
            this.Controls.Add(this.textBoxVertical);
            this.Controls.Add(this.labelHorizontal);
            this.Controls.Add(this.labelVertical);
            this.Controls.Add(this.labelSetSize);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.groupBoxDPI);
            this.Controls.Add(this.groupBoxScan);
            this.Controls.Add(this.buttonRefreshDevices);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.labelChooseScaner);
            this.Controls.Add(this.pictureBoxScannedImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedImage)).EndInit();
            this.groupBoxScan.ResumeLayout(false);
            this.groupBoxScan.PerformLayout();
            this.groupBoxDPI.ResumeLayout(false);
            this.groupBoxDPI.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScannedImage;
        private System.Windows.Forms.Label labelChooseScaner;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button buttonRefreshDevices;
        private System.Windows.Forms.RadioButton radioButton1BitMode;
        private System.Windows.Forms.RadioButton radioButtonGreyScaleMode;
        private System.Windows.Forms.Label labelScanMode;
        private System.Windows.Forms.RadioButton radioButtonRGBMode;
        private System.Windows.Forms.GroupBox groupBoxScan;
        private System.Windows.Forms.RadioButton radioButtonDPI300;
        private System.Windows.Forms.RadioButton radioButtonDPI150;
        private System.Windows.Forms.RadioButton radioButtonDPI100;
        private System.Windows.Forms.RadioButton radioButtonDPI400;
        private System.Windows.Forms.RadioButton radioButtonDPI200;
        private System.Windows.Forms.RadioButton radioButtonDPI600;
        private System.Windows.Forms.Label labelChooseDPI;
        private System.Windows.Forms.RadioButton radioButtonDPI1200;
        private System.Windows.Forms.GroupBox groupBoxDPI;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label labelSetSize;
        private System.Windows.Forms.Label labelVertical;
        private System.Windows.Forms.Label labelHorizontal;
        private System.Windows.Forms.TextBox textBoxVertical;
        private System.Windows.Forms.TextBox textBoxHorizontal;
        private System.Windows.Forms.Button buttonScanSystemApp;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.RadioButton radioButtonPNGFormat;
        private System.Windows.Forms.RadioButton radioButtonJPGFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

