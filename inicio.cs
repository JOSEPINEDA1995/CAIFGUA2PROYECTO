using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIFGUA2
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

      
        private void inicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1500;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.00001;
            }

            this.Hide();
            Login frm = new Login();
            frm.Show();
            timer1.Stop();
        }
    }
}
