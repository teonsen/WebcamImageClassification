namespace WebCamPanel
{
    partial class CameraPanel
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClassify = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.cboCameraIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClassify);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.cboCameraIndex);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblClassify
            // 
            resources.ApplyResources(this.lblClassify, "lblClassify");
            this.lblClassify.Name = "lblClassify";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cboCameraIndex
            // 
            this.cboCameraIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameraIndex.FormattingEnabled = true;
            this.cboCameraIndex.Items.AddRange(new object[] {
            resources.GetString("cboCameraIndex.Items"),
            resources.GetString("cboCameraIndex.Items1"),
            resources.GetString("cboCameraIndex.Items2"),
            resources.GetString("cboCameraIndex.Items3"),
            resources.GetString("cboCameraIndex.Items4"),
            resources.GetString("cboCameraIndex.Items5")});
            resources.ApplyResources(this.cboCameraIndex, "cboCameraIndex");
            this.cboCameraIndex.Name = "cboCameraIndex";
            this.cboCameraIndex.SelectedIndexChanged += new System.EventHandler(this.cboCameraIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // timerCapture
            // 
            this.timerCapture.Tick += new System.EventHandler(this.timerCapture_Tick);
            // 
            // CameraPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CameraPanel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCameraIndex;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblClassify;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerCapture;
    }
}
