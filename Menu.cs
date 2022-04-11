using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CAIFGUA2
{
    public partial class Menu : Form
    {
        public DataSet usuario;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
                
            label1.Text = usuario.Tables[0].Rows[0]["nombre"].ToString().Trim() +" "+ usuario.Tables[0].Rows[0]["apellido"].ToString().Trim(); ;
            label2.Text = "No: "+usuario.Tables[0].Rows[0]["tp_id"].ToString().Trim();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = true;
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void btnRepor3_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void btnRepor6_Click(object sender, EventArgs e)
        {
            PanelSubmenuReportes.Visible = false;
        }

        private void abrirFromulario(object form) {

            if (this.PanelContenedor.Controls.Count >0) 
                    this.PanelContenedor.Controls.RemoveAt(0);//quita controles del conetendor
                Form frm = form as Form; // crea un formulario
                frm.TopLevel = false;   // fromulario secundario
                frm.Dock = DockStyle.Fill; // el formulario se acopla al panel
                this.PanelContenedor.Controls.Add(frm); // agregamos al panel la forma creada
                this.PanelContenedor.Tag = frm;//instacia como contenedor de datos
                frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFromulario(new FrmFichaUsuario());
        }
    }
}
