using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica1;

namespace CAIFGUA2
{
    public partial class FrmFichaUsuario : Form
    {
        public FrmFichaUsuario()
        {
            InitializeComponent();
        }

        private void FrmFichaUsuario_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            TblEstadoCivil tb = new TblEstadoCivil();
            DataSet ds = new DataSet();
            ds = tb.listarEstado();
            int b = ds.Tables[0].Rows.Count;
            for (int i = 0; i < b ; i++)
            {

                comboBox8.Items.Add(ds.Tables[0].Rows[i]["nombre"].ToString());     
                    
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
