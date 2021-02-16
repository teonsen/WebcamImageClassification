using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebcamImageClassification
{
    static class Program
    {
        static Form1 _form1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var consoleWriter = new ConsoleWriter())
            {
                consoleWriter.WriteEvent += consoleWriter_WriteEvent;
                consoleWriter.WriteLineEvent += consoleWriter_WriteLineEvent;

                Console.SetOut(consoleWriter);
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _form1 = new Form1();
                Application.Run(_form1);
            }
        }

        static void consoleWriter_WriteLineEvent(object sender, Program.ConsoleWriterEventArgs e)
        {
            UpdateTextBox(e.Value);
        }

        static void consoleWriter_WriteEvent(object sender, Program.ConsoleWriterEventArgs e)
        {
            UpdateTextBox(e.Value);
        }

        static void UpdateTextBox(string msg)
        {
            _form1.txtTrainingProgress.Text += msg;
            _form1.txtTrainingProgress.SelectionStart = _form1.txtTrainingProgress.Text.Length;
            _form1.txtTrainingProgress.Focus();
            _form1.txtTrainingProgress.ScrollToCaret();
        }

        //https://stackoverflow.com/questions/11911660/redirect-console-writeline-from-windows-application-to-a-string/11911734
        public class ConsoleWriterEventArgs : EventArgs
        {
            public string Value { get; private set; }
            public ConsoleWriterEventArgs(string value)
            {
                Value = value;
            }
        }

        public class ConsoleWriter : TextWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }

            public override void Write(string value)
            {
                if (WriteEvent != null) WriteEvent(this, new ConsoleWriterEventArgs(value));
                base.Write(value);
            }

            public override void WriteLine(string value)
            {
                if (WriteLineEvent != null) WriteLineEvent(this, new ConsoleWriterEventArgs(value));
                base.WriteLine(value);
            }

            public event EventHandler<ConsoleWriterEventArgs> WriteEvent;
            public event EventHandler<ConsoleWriterEventArgs> WriteLineEvent;
        }

    }
}
