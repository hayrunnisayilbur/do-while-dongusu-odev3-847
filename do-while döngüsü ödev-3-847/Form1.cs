using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_döngüsü_ödev_3_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            do
            {
                richTextBox1.Text = richTextBox1.Text + sayi.ToString();
                sayi++;
            } while (sayi < 30);
        }
    }
}
