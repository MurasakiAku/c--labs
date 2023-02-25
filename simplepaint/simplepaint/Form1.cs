using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace simplepaint
{
    public partial class Form1 : Form
    {
        int _x;
        int _y;
        bool _mouseClicked = false;
        Color SelectedColor
        {
            get { return Color.Black; }
        }
        int SelectedSize
        {
            get { return TrackBar1.Value; }
        }
        Brush _selectedBrush;
        

        Color DefaultColor
        {
            get { return Color.White; }
        }
        
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
            Brush.Sizing(pictureBox1.Width, pictureBox1.Height);
            if( _selectedBrush == null)
            {
                    _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
            }
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
            
            //_selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
            //_selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
            //_selectedBrush = new RectangleBrush(SelectedColor, SelectedSize);
            ////_selectedBrush = new LastikBrush(SelectedColor, SelectedSize);
            //Bitmap map = new Bitmap(100, 100);
                   

        }

        //public static int W, H;
        //public static void Sizing(int w, int h)
        //{
        //    W = w;
        //    H = h;
        //}


        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw((Bitmap) pictureBox1.Image as Bitmap, _x, _y);
                
                pictureBox1.Refresh();
            }
        }

        private void squadBrush_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.w, form.h);
            }

            
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new RectangleBrush(SelectedColor, SelectedSize);
        }

        private void Lastik_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = ((Button)sender).BackColor; /*= new LastikBrush(SelectedColor, SelectedSize);*/
            

        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                if (pictureBox1.Image == null)
                {

                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = ((Button)sender).BackColor;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedBrush.BrushColor = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        //private void snowflake_Click(object sender, EventArgs e)
        //{
        //    _selectedBrush = new SnowFlakeBrush(SelectedColor, SelectedSize);
        //}
    }

}
