
namespace WebCamImageClassificationNet472
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapturedFilename = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.nudCaptures = new System.Windows.Forms.NumericUpDown();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.btnInitCam1 = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtRootDataDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTrainingProgress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateModel = new System.Windows.Forms.Button();
            this.txtDatasetDir = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInitCam3 = new System.Windows.Forms.Button();
            this.btnClassify = new System.Windows.Forms.Button();
            this.txtModelPath = new System.Windows.Forms.TextBox();
            this.txtPipelinePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaptures)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCapturedFilename);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.nudInterval);
            this.groupBox1.Controls.Add(this.nudCaptures);
            this.groupBox1.Controls.Add(this.txtLabelName);
            this.groupBox1.Controls.Add(this.btnInitCam1);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.txtRootDataDir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblCapturedFilename
            // 
            resources.ApplyResources(this.lblCapturedFilename, "lblCapturedFilename");
            this.lblCapturedFilename.Name = "lblCapturedFilename";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudInterval
            // 
            resources.ApplyResources(this.nudInterval, "nudInterval");
            this.nudInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudCaptures
            // 
            resources.ApplyResources(this.nudCaptures, "nudCaptures");
            this.nudCaptures.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
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
            this.nudCaptures.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtLabelName
            // 
            resources.ApplyResources(this.txtLabelName, "txtLabelName");
            this.txtLabelName.Name = "txtLabelName";
            // 
            // btnInitCam1
            // 
            resources.ApplyResources(this.btnInitCam1, "btnInitCam1");
            this.btnInitCam1.Name = "btnInitCam1";
            this.btnInitCam1.UseVisualStyleBackColor = true;
            this.btnInitCam1.Click += new System.EventHandler(this.btnInitCam1_Click);
            // 
            // btnSelectFolder
            // 
            resources.ApplyResources(this.btnSelectFolder, "btnSelectFolder");
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtRootDataDir
            // 
            resources.ApplyResources(this.txtRootDataDir, "txtRootDataDir");
            this.txtRootDataDir.Name = "txtRootDataDir";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.txtTrainingProgress);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtTrainingProgress
            // 
            resources.ApplyResources(this.txtTrainingProgress, "txtTrainingProgress");
            this.txtTrainingProgress.Name = "txtTrainingProgress";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnGenerateModel);
            this.groupBox2.Controls.Add(this.txtDatasetDir);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnGenerateModel
            // 
            resources.ApplyResources(this.btnGenerateModel, "btnGenerateModel");
            this.btnGenerateModel.Name = "btnGenerateModel";
            this.btnGenerateModel.UseVisualStyleBackColor = true;
            this.btnGenerateModel.Click += new System.EventHandler(this.btnGenerateModel_Click);
            // 
            // txtDatasetDir
            // 
            resources.ApplyResources(this.txtDatasetDir, "txtDatasetDir");
            this.txtDatasetDir.Name = "txtDatasetDir";
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnInitCam3);
            this.groupBox3.Controls.Add(this.btnClassify);
            this.groupBox3.Controls.Add(this.txtModelPath);
            this.groupBox3.Controls.Add(this.txtPipelinePath);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnInitCam3
            // 
            resources.ApplyResources(this.btnInitCam3, "btnInitCam3");
            this.btnInitCam3.Name = "btnInitCam3";
            this.btnInitCam3.UseVisualStyleBackColor = true;
            this.btnInitCam3.Click += new System.EventHandler(this.btnInitCam3_Click);
            // 
            // btnClassify
            // 
            resources.ApplyResources(this.btnClassify, "btnClassify");
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // txtModelPath
            // 
            resources.ApplyResources(this.txtModelPath, "txtModelPath");
            this.txtModelPath.Name = "txtModelPath";
            // 
            // txtPipelinePath
            // 
            resources.ApplyResources(this.txtPipelinePath, "txtPipelinePath");
            this.txtPipelinePath.Name = "txtPipelinePath";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaptures)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootDataDir;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnInitCam1;
        private System.Windows.Forms.TextBox txtLabelName;
        private System.Windows.Forms.NumericUpDown nudCaptures;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCapturedFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDatasetDir;
        private System.Windows.Forms.Button btnGenerateModel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelPath;
        private System.Windows.Forms.TextBox txtPipelinePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Button btnInitCam3;
        internal System.Windows.Forms.TextBox txtTrainingProgress;
    }
}

