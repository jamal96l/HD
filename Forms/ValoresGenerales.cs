using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDesktop.Forms
{
    public partial class ValoresGenerales : Form
    {
        Class.ValoresGenerales losValores = new Class.ValoresGenerales();
        public ValoresGenerales()
        {
            InitializeComponent();
            
        }

        private void ValoresGenerales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
