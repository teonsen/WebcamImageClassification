
namespace WebcamImageClassification
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pan1 = new System.Windows.Forms.Panel();
            this.grpCaptureSettings = new System.Windows.Forms.GroupBox();
            this.btnInitCam1 = new System.Windows.Forms.Button();
            this.lblCapturedFilename = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCaptures = new System.Windows.Forms.NumericUpDown();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.txtRootDataDir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrainingProgress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateModel = new System.Windows.Forms.Button();
            this.txtDatasetDir = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pan3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInitCam3 = new System.Windows.Forms.Button();
            this.txtPipelinePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCaptureSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaptures)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 726);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pan1);
            this.tabPage1.Controls.Add(this.grpCaptureSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Create data-set";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pan1
            // 
            this.pan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan1.Location = new System.Drawing.Point(3, 132);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(794, 563);
            this.pan1.TabIndex = 2;
            // 
            // grpCaptureSettings
            // 
            this.grpCaptureSettings.Controls.Add(this.btnInitCam1);
            this.grpCaptureSettings.Controls.Add(this.lblCapturedFilename);
            this.grpCaptureSettings.Controls.Add(this.progressBar1);
            this.grpCaptureSettings.Controls.Add(this.label5);
            this.grpCaptureSettings.Controls.Add(this.label4);
            this.grpCaptureSettings.Controls.Add(this.nudInterval);
            this.grpCaptureSettings.Controls.Add(this.label3);
            this.grpCaptureSettings.Controls.Add(this.nudCaptures);
            this.grpCaptureSettings.Controls.Add(this.btnSelectFolder);
            this.grpCaptureSettings.Controls.Add(this.label2);
            this.grpCaptureSettings.Controls.Add(this.label1);
            this.grpCaptureSettings.Controls.Add(this.btnStart);
            this.grpCaptureSettings.Controls.Add(this.txtLabelName);
            this.grpCaptureSettings.Controls.Add(this.txtRootDataDir);
            this.grpCaptureSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCaptureSettings.Location = new System.Drawing.Point(3, 3);
            this.grpCaptureSettings.Name = "grpCaptureSettings";
            this.grpCaptureSettings.Size = new System.Drawing.Size(794, 129);
            this.grpCaptureSettings.TabIndex = 1;
            this.grpCaptureSettings.TabStop = false;
            this.grpCaptureSettings.Text = "Capture settings";
            // 
            // btnInitCam1
            // 
            this.btnInitCam1.Location = new System.Drawing.Point(8, 89);
            this.btnInitCam1.Name = "btnInitCam1";
            this.btnInitCam1.Size = new System.Drawing.Size(60, 25);
            this.btnInitCam1.TabIndex = 28;
            this.btnInitCam1.Text = "InitCam";
            this.btnInitCam1.UseVisualStyleBackColor = true;
            this.btnInitCam1.Click += new System.EventHandler(this.btnInitCam1_Click);
            // 
            // lblCapturedFilename
            // 
            this.lblCapturedFilename.AutoSize = true;
            this.lblCapturedFilename.Location = new System.Drawing.Point(604, 102);
            this.lblCapturedFilename.Name = "lblCapturedFilename";
            this.lblCapturedFilename.Size = new System.Drawing.Size(52, 15);
            this.lblCapturedFilename.TabIndex = 27;
            this.lblCapturedFilename.Text = "filename";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(604, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 10);
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Create \"Label name\" folder and start capturing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Capture interval[ms]";
            // 
            // nudInterval
            // 
            this.nudInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.Location = new System.Drawing.Point(329, 91);
            this.nudInterval.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(87, 23);
            this.nudInterval.TabIndex = 22;
            this.nudInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Capture Images";
            // 
            // nudCaptures
            // 
            this.nudCaptures.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCaptures.Location = new System.Drawing.Point(236, 91);
            this.nudCaptures.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCaptures.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCaptures.Name = "nudCaptures";
            this.nudCaptures.Size = new System.Drawing.Size(87, 23);
            this.nudCaptures.TabIndex = 20;
            this.nudCaptures.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(749, 39);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(29, 23);
            this.btnSelectFolder.TabIndex = 19;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Label name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select a folder to save the images taken by webcam";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(441, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 25);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLabelName
            // 
            this.txtLabelName.Location = new System.Drawing.Point(74, 91);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size(156, 23);
            this.txtLabelName.TabIndex = 15;
            // 
            // txtRootDataDir
            // 
            this.txtRootDataDir.Location = new System.Drawing.Point(8, 40);
            this.txtRootDataDir.Name = "txtRootDataDir";
            this.txtRootDataDir.Size = new System.Drawing.Size(735, 23);
            this.txtRootDataDir.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Generate model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTrainingProgress);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 584);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Training progress";
            // 
            // txtTrainingProgress
            // 
            this.txtTrainingProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrainingProgress.Location = new System.Drawing.Point(3, 19);
            this.txtTrainingProgress.Multiline = true;
            this.txtTrainingProgress.Name = "txtTrainingProgress";
            this.txtTrainingProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrainingProgress.Size = new System.Drawing.Size(788, 562);
            this.txtTrainingProgress.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateModel);
            this.groupBox1.Controls.Add(this.txtDatasetDir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate model";
            // 
            // btnGenerateModel
            // 
            this.btnGenerateModel.Location = new System.Drawing.Point(15, 61);
            this.btnGenerateModel.Name = "btnGenerateModel";
            this.btnGenerateModel.Size = new System.Drawing.Size(107, 23);
            this.btnGenerateModel.TabIndex = 4;
            this.btnGenerateModel.Text = "Generate";
            this.btnGenerateModel.UseVisualStyleBackColor = true;
            this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
            // 
            // txtDatasetDir
            // 
            this.txtDatasetDir.Location = new System.Drawing.Point(15, 32);
            this.txtDatasetDir.Name = "txtDatasetDir";
            this.txtDatasetDir.Size = new System.Drawing.Size(734, 23);
            this.txtDatasetDir.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pan3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Consume model";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pan3
            // 
            this.pan3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan3.Location = new System.Drawing.Point(0, 121);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(800, 577);
            this.pan3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInitCam3);
            this.groupBox2.Controls.Add(this.txtPipelinePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnClassify);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtModelPath);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consume model";
            // 
            // btnInitCam3
            // 
            this.btnInitCam3.Location = new System.Drawing.Point(8, 84);
            this.btnInitCam3.Name = "btnInitCam3";
            this.btnInitCam3.Size = new System.Drawing.Size(60, 25);
            this.btnInitCam3.TabIndex = 29;
            this.btnInitCam3.Text = "InitCam";
            this.btnInitCam3.UseVisualStyleBackColor = true;
            this.btnInitCam3.Click += new System.EventHandler(this.btnInitCam3_Click);
            // 
            // txtPipelinePath
            // 
            this.txtPipelinePath.Location = new System.Drawing.Point(83, 26);
            this.txtPipelinePath.Name = "txtPipelinePath";
            this.txtPipelinePath.Size = new System.Drawing.Size(670, 23);
            this.txtPipelinePath.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "pipeline.zip";
            // 
            // btnClassify
            // 
            this.btnClassify.Location = new System.Drawing.Point(83, 84);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(122, 25);
            this.btnClassify.TabIndex = 12;
            this.btnClassify.Text = "Start classify";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "model.zip";
            // 
            // txtModelPath
            // 
            this.txtModelPath.Location = new System.Drawing.Point(83, 55);
            this.txtModelPath.Name = "txtModelPath";
            this.txtModelPath.Size = new System.Drawing.Size(670, 23);
            this.txtModelPath.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Webcam Image Classification";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpCaptureSettings.ResumeLayout(false);
            this.grpCaptureSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaptures)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.TextBox txtDatasetDir;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPipelinePath;
        private System.Windows.Forms.TextBox txtModelPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtTrainingProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox grpCaptureSettings;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCaptures;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.TextBox txtRootDataDir;
        private System.Windows.Forms.Label lblCapturedFilename;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel pan3;
        private System.Windows.Forms.Button btnInitCam1;
        private System.Windows.Forms.Button btnInitCam3;
    }
}

