using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_tez2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArabaOyunu ac2 = new ArabaOyunu();
            ac2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            HafızaOyunu ac2 = new HafızaOyunu();
            ac2.ShowDialog();
        }
    }
}
