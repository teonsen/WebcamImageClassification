using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Internal;

namespace WebCamPanel
{
    public partial class CameraPanel : UserControl
    {
        public event EventHandler<CapturedInfo> Captured;
        private const int WIDTH = 640;
        private const int HEIGHT = 480;
        private Mat _frame;
        private VideoCapture _video;
        private Bitmap _bmp;
        private Graphics _graphic;
        private bool _classifyMode = false;
        Panel _parentPanel;

        public CameraPanel(Panel parentPanel)
        {
            InitializeComponent();
            _parentPanel = parentPanel;
            cboCameraIndex.SelectedIndex = 0;
        }

        private void InitWebcam()
        {
            //カメラ画像取得用のVideoCapture作成
            _video = new VideoCapture(cboCameraIndex.SelectedIndex);
            if (!_video.IsOpened())
            {
                MessageBox.Show("No camera is found!");
                return;
            }
            _video.FrameWidth = WIDTH;
            _video.FrameHeight = HEIGHT;

            //取得先のMat作成
            _frame = new Mat(HEIGHT, WIDTH, MatType.CV_8UC3);

            //表示用のBitmap作成
            _bmp = new Bitmap(_frame.Cols, _frame.Rows, (int)_frame.Step(), System.Drawing.Imaging.PixelFormat.Format24bppRgb, _frame.Data);

            //PictureBoxを出力サイズに合わせる
            pictureBox1.Width = _frame.Cols;
            pictureBox1.Height = _frame.Rows;

            // 描画用のGraphics作成
            _graphic = pictureBox1.CreateGraphics();

            //画像取得スレッド開始
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;

            while (!backgroundWorker1.CancellationPending)
            {
                _video.Grab();
                NativeMethods.videoio_VideoCapture_operatorRightShift_Mat(_video.CvPtr, _frame.CvPtr);

                bw.ReportProgress(0);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _graphic.DrawImage(_bmp, 0, 0, _frame.Cols, _frame.Rows);
        }

        private void timerCapture_Tick(object sender, EventArgs e)
        {
            string path = _classifyMode ? _savePath : $@"{_savePath}\{DateTime.Now:yyyyMMddHHmmss.fff}.jpg";
            //_bmp.Save(path);
            SaveResizedBitmap(path, 0.5f);

            if (_classifyMode)
            {
                Cursor = Cursors.WaitCursor;
                // predict the webcam image.
                var predictionResult = ImageClassification.Predictor.ClassifySingleImage(_pipelineZip, _modelZip, path);
                // overray
                //_frame.PutText($"{predictionResult.PredictedLabel} {predictionResult.Score:P}", new OpenCvSharp.Point(10, 10), HersheyFonts.HersheyPlain, 10, new Scalar(0), 2);
                lblClassify.Text = $"{predictionResult.PredictedLabel} {predictionResult.Score:P}";
                if (predictionResult.Score >= 0.9f)
                {
                    lblClassify.ForeColor = Color.Red;
                }
                else
                {
                    lblClassify.ForeColor = Color.Black;
                }
                Cursor = Cursors.Default;
            }
            _count++;
            Captured?.Invoke(this, new CapturedInfo(_count, path));
        }

        private void SaveResizedBitmap(string path, float scale)
        {
            // 変更サイズを取得する
            int widthToScale = (int)(_bmp.Width * scale);
            int heightToScale = (int)(_bmp.Height * scale);

            // サイズ変更した画像を作成する
            using (Bitmap bitmap = new Bitmap(widthToScale, heightToScale))
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // 背景色を塗る
                SolidBrush solidBrush = new SolidBrush(Color.Black);
                graphics.FillRectangle(solidBrush, new RectangleF(0, 0, widthToScale, heightToScale));

                // サイズ変更した画像に、左上を起点に変更する画像を描画する
                graphics.DrawImage(_bmp, 0, 0, widthToScale, heightToScale);

                // サイズ変更した画像を保存する
                bitmap.Save(path);
            }
        }

        private string _savePath;
        private int _count;
        public void StartCapturing(string savePath, int captureInterval)
        {
            _classifyMode = false;
            _savePath = savePath;
            _count = 0;
            timerCapture.Interval = captureInterval;
            timerCapture.Enabled = true;
        }

        public void ClearThis()
        {
            timerCapture.Enabled = false;
            lblClassify.Text = "---";
            //スレッドの終了を待機
            backgroundWorker1.CancelAsync();
            while (backgroundWorker1.IsBusy)
                Application.DoEvents();
            _parentPanel.Controls.Clear();

        }

        string _modelZip, _pipelineZip;
        public void StartClassifying(string modelPath, string pipelinePath)
        {
            _classifyMode = true;
            _modelZip = modelPath;
            _pipelineZip = pipelinePath;
            _savePath = Application.StartupPath + "webcam.jpg";
            timerCapture.Interval = 3000;
            timerCapture.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ClearThis();
            lblClassify.Text = "---";
        }

        private void cboCameraIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitWebcam();
        }

    }

    public class CapturedInfo
    {
        public int Count { get; private set; }
        public string FileName { get; private set; }

        public CapturedInfo(int count, string savePath)
        {
            Count = count;
            FileName = Path.GetFileName(savePath);
        }
    }
}
