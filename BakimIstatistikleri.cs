using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarFormApplication
{
    public partial class BakimIstatistikleri : Form
    {
        public BakimIstatistikleri()
        {
            InitializeComponent();
        }

        private void BakimIstatistikleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
