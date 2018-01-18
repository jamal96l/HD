using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDesktop
{
    public partial class Form1 : Form
    {
        private Forms.ValoresGenerales formValores;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmValoresGenerales_Click(object sender, EventArgs e)
        {
            formValores = new Forms.ValoresGenerales();
            formValores.Show();
        }
    }
}
