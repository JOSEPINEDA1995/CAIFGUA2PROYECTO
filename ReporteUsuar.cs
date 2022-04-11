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
    public partial class ReporteUsuar : Form
    {
        public ReporteUsuar()
        {
            InitializeComponent();
        }

        private void ReporteUsuar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAIFGUADataSet1.V_usuarios' Puede moverla o quitarla según sea necesario.
            this.v_usuariosTableAdapter.Fill(this.cAIFGUADataSet1.V_usuarios);
            this.reportViewer1.RefreshReport();
        }
    }
}
