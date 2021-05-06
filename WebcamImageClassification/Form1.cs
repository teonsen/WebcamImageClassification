using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ImageClassification;
using ImageClassificationGPU;
using ImageClassification.IO;
using WebCamPanel;

namespace WebcamImageClassification
{
    public partial class Form1 : Form
    {
        CameraPanel _wp1, _wp3;

        public Form1()
        {
            InitializeComponent();
            lblCapturedFilename.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCam1();
        }

        private void InitCam1()
        {
            pan1.Controls.Clear();
            _wp1 = new CameraPanel(pan1);
            _wp1.Dock = DockStyle.Fill;
            pan1.Controls.Add(_wp1);
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string datasetDir = folderBrowserDialog1.SelectedPath;
                txtRootDataDir.Text = datasetDir;
                txtDatasetDir.Text = datasetDir;
                if (File.Exists(datasetDir + "\\model.zip"))
                {
                    txtModelPath.Text = datasetDir + "\\model.zip";
                }
                if (File.Exists(datasetDir + "\\pipeline.zip"))
                {
                    txtPipelinePath.Text = datasetDir + "\\pipeline.zip";
                }
            }
        }

        private void btnInitCam1_Click(object sender, EventArgs e)
        {
            InitCam1();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsReadyToCapture())
            {
                _wp1.Captured += _wp_Captured;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                progressBar1.Maximum = (int)nudCaptures.Value;
                txtDatasetDir.Text = txtRootDataDir.Text;
                string labelDirPath = Path.Combine(txtRootDataDir.Text, txtLabelName.Text);
                Directory.CreateDirectory(labelDirPath);
                System.Threading.Thread.Sleep(2000);
                _wp1.StartCapturing(labelDirPath, (int)nudInterval.Value);
            }
        }

        private bool IsReadyToCapture()
        {
            if (Directory.Exists(txtRootDataDir.Text))
            {
                if (!string.IsNullOrEmpty(txtLabelName.Text))
                {
                    var dr = MessageBox.Show("Ready to start capture?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    return dr == DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(@"""Label name"" is can not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show($"Directory '{txtRootDataDir.Text}' does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        private void _wp_Captured(object sender, CapturedInfo e)
        {
            progressBar1.Value = e.Count;
            lblCapturedFilename.Text = $"{e.FileName} [{e.Count}/{nudCaptures.Value}]";
            if ((int)nudCaptures.Value == progressBar1.Value)
            {
                StopCapturing();
                MessageBox.Show($@"{nudCaptures.Value} images of ""{txtLabelName.Text}"" are saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitCam1();
            }
        }

        private void StopCapturing()
        {
            progressBar1.Visible = false;
            lblCapturedFilename.Text = "";
            _wp1.ClearThis();
            _wp1.Captured -= _wp_Captured;
        }

        private void btnGenerateModel_Click(object sender, EventArgs e)
        {
            txtTrainingProgress.Clear();
            if (Directory.Exists(txtDatasetDir.Text))
            {
                // Define hyper-paramters such as Epoch or BatchSize.
                var hp = new HyperParameter
                {
                    Epoch = 200,
                    BatchSize = 10,
                    LearningRate = 0.01f,
                    eTrainerArchitecture = eTrainerArchitectures.ResnetV250,
                    TestFraction = 0.3f,
                    ResultsToShow = 30
                };
                Cursor = Cursors.WaitCursor;
                // Train and generate the model.
                var results = Trainer.GenerateModel(txtDatasetDir.Text, hp);

                txtModelPath.Text = results.Resultfiles.ModelZip;
                txtPipelinePath.Text = results.Resultfiles.PipelineZip;
                // Show training result.
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(results.Resultfiles.ResultHTML)
                {
                    UseShellExecute = true
                };
                p.Start();
                Cursor = Cursors.Default;
            }
        }

        private void btnInitCam3_Click(object sender, EventArgs e)
        {
            InitCam3();
        }

        private void InitCam3()
        {
            pan3.Controls.Clear();
            _wp3 = new CameraPanel(pan3);
            _wp3.Dock = DockStyle.Fill;
            pan3.Controls.Add(_wp3);
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtModelPath.Text) && File.Exists(txtPipelinePath.Text))
            {
                if (pan3.Controls.Count == 0)
                {
                    InitCam3();
                }
                _wp3.StartClassifying(txtModelPath.Text, txtPipelinePath.Text);
            }
        }
    }
}
