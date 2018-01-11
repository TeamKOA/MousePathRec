using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace MousePathRec
{

    public partial class Form1 : Form
    {
        private static IKeyboardMouseEvents m_GlobalHook;
        public static Bitmap bmp;
        public static Graphics g;
        public static string filePath = @"F:\Coding\gmod";
        public static Point old = new Point(0,0);
        static Pen pen;
        static Brush brush;
        static int h;
        static int w;
        static int lmb = 0;
        static int scrollActions = 0;
        static int rmb = 0;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, (float)lineSize.Value);
            brush = Brushes.White;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            h = resolution.Height;
            w = resolution.Width;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (recordingStatus.Text == "Recording")
                return;
            if (File.Exists(@dirText.Text))
            {
                return;
            }

            recordingStatus.Text = "Recording";
            recordingStatus.ForeColor = Color.Green;
            CreateImg();
            Subscribe();
        }
      
        private void stop_Click(object sender, EventArgs e)
        {
            if (recordingStatus.Text == "Not Recording")
                return;
            recordingStatus.Text = "Not Recording";
            recordingStatus.ForeColor = Color.Red;

            if(checkBoxPath.CheckState == CheckState.Checked)
            SaveImg();

            Unsubscribe();
        }

        private void setDir_Click(object sender, EventArgs e)
        {
            dirSelector.ShowDialog();
        }
         void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseMove += OnMouseMove;
            m_GlobalHook.MouseClick += OnMouseClick;
        }
        static void Unsubscribe()
                {
                    m_GlobalHook.MouseMove -= OnMouseMove;

                    m_GlobalHook.Dispose();
                }
        static void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point loc = e.Location;
            loc.X = (loc.X < 0) ? 0 : e.X;
            loc.X = (loc.X > w) ? w : e.X;
            loc.Y = (loc.Y < 0) ? 0 : e.Y;
            loc.Y = (loc.Y > h) ? h : e.Y;
            g.DrawLine(pen, e.Location, old);
           
            old = e.Location;
        }

        void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lmb++;
                textBoxlmb.Text = lmb + "";
            }
            if (e.Button == MouseButtons.Right)
            {
                rmb++;
                textBoxrmb.Text = rmb + "";
            }
            
        }

         void CreateImg()
        {           
            bmp = new Bitmap(w, h);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(brush, 0, 0, 1920, 1080);

        }
         void SaveImg()
        {
            string fp;
     
            fp = @dirText.Text;
            g.Dispose();
            bmp.Save(fp, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonColorLine_Click(object sender, EventArgs e)
        {
            if (colorDialogLine.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(colorDialogLine.Color, (float) lineSize.Value);
            }
            else
            {
                pen = new Pen(Color.Black, (float) lineSize.Value);
            }
        }

        private void buttonColorBack_Click(object sender, EventArgs e)
        {
            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(colorDialogBackground.Color);
            }
            else
            {
                brush = Brushes.Black;
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if(File.Exists(@dirText.Text))
            System.Diagnostics.Process.Start(@dirText.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetCounter_Click(object sender, EventArgs e)
        {
            rmb = 0;
            lmb = 0;
            textBoxrmb.Text = rmb + "";
            textBoxlmb.Text = lmb + "";
        }
    }
}
