using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace simplepaint
{
    public partial class Form2 : Form
    {
        //Thread th;
        public Form2()
        {
            InitializeComponent();
            
        }
        //private void tbWidth_TextChanged(object sender, EventArgs e)
        //{
        //    int w;
        //}
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    this.Close();
        //    th = new Thread(open);
        //    th.SetApartmentState(ApartmentState.STA);
        //    th.Start();
        //}
        //public void open(object obj)
        //{
        //    Application.Run(new Form1());
        //}
        public string name
        {
            get
            {
                string text = tbName.Text;
                return text;
            }
        }
        public int w
        {
            get
            {
                string text = tbWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        public int h
        {
            get
            {
                string text = tbHeigh.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }
        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void Cance1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok1_Click(object sender, EventArgs e)
        {
            _canceled = false;
            Close();
        }
    }
}
