using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmName_Click(object sender, EventArgs e)
        {
            string userName = tbName.Text.Trim();
            if (userName.Length < 3)
            {
                MessageBox.Show("Ведите имя пользоввателя!");
            }
            else
            {
                MessageBox.Show("Приввет" + userName);
            }
        }

        private void btmEx_Click(object sender, EventArgs e)
        {

        }
    }
}
