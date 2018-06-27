using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Clock1;

namespace Lab7_TP
{
    public partial class ClockForm : Form
  {
        Timer t = new Timer();
        

        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 400;
        int iFormX, iFormY, iMouseX, iMouseY;//глобальные переменные

        //center 
        int cx, cy;

        Bitmap bmp;
        Graphics g;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = DefaultBackColor;
            //create bitmap
            bmp = new Bitmap (WIDTH + 1, HEIGHT + 1);
            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            //timer
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {

            //create grafics 
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //get time
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            //clear
            g.Clear(TransparencyKey = DefaultBackColor);
            //draw circle
            g.FillEllipse(new SolidBrush(Setting.ColorOfClock[0]), 0, 0, WIDTH, HEIGHT);
            g.DrawEllipse(new Pen(Color.White, 1f), 0, 0, WIDTH, HEIGHT);
            //draw figure
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));

            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(207, 4));
            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(270, 65));

            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));

            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(270, 180));
            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(210, 240));

            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));

            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(15, 180));
            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(70, 240));

            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(15, 65));
            g.DrawString(".", new Font("Arial", 20), Brushes.Black, new PointF(70, 4));

            //second hand
            handCoord = msCoord(sec, secHAND);
            g.DrawLine(new Pen(Color.Black, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            g.DrawLine(new Pen(Setting.ColorOfArrow[0]),new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            
            //minet hand
            handCoord = msCoord(min, minHAND);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            g.DrawLine(new Pen(Setting.ColorOfArrow[0]), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //hour hand
            handCoord = hrCoord(hour%12, 85, hrHAND);
            g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            g.DrawLine(new Pen(Setting.ColorOfArrow[0]), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));


            //load bmp in picturebox1
            pictureBox1.Image = bmp;

            //disp time 
            this.Text = "Clock - " + hour + ":" + min + ":" + sec;

            //dispose 
            g.Dispose();

        }

        //coord for minute and sec hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6; //each minute and second make 6 degree

                if( val>= 0 && val <= 180)
                {
                    coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                    coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
                }
            else
                {
                    coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                    coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
                }
                return coord;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                iFormX = this.Location.X;
                iFormY = this.Location.Y;
                iMouseX = MousePosition.X;
                iMouseY = MousePosition.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int iMouseX2 = MousePosition.X;
                int iMouseY2 = MousePosition.Y;
                if (e.Button == MouseButtons.Left)
                    this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm s = new SettingsForm();
            s.ShowDialog();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm a = new AuthorForm();
            a.ShowDialog();
        }

        private void writeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog a = new SaveFileDialog();
            a.InitialDirectory = "c:\\";
            a.Filter = "txt files (*.xml)|*.xml|All files (*.*)|*.*";
            if (a.ShowDialog() == DialogResult.OK)
            {
                Write(a.FileName);
            }
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int hlen, int mval)
        {
            int[] coord = new int[2];

            //each hours makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * -Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        /// <summary>
        /// запись в файл
        /// </summary>
        /// <param name="path"></param>
        public void Write(string path)
        {
            
            SaveFileDialog a = new SaveFileDialog();
            XmlSerializer xmlSerialaizer = new XmlSerializer(typeof(Config));
            FileStream fw = new FileStream(path, FileMode.OpenOrCreate);
            xmlSerialaizer.Serialize(fw, a);
            fw.Close();
        }    
    }
}