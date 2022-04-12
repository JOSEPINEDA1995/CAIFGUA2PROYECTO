using CapaLogica;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   try
            {
                ClUsuarios usu = new ClUsuarios();
                DataSet ds = new DataSet();
                ds = usu.verifica(textBox1.Text, textBox2.Text);


                String Codigo = ds.Tables[0].Rows[0]["tp_id"].ToString().Trim();
                string usuario = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["calve"].ToString().Trim();

                if (usuario == textBox1.Text.Trim() && password == textBox2.Text.Trim())
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["tp_id"]) == 1)
                    {
                        Menu frm = new Menu();
                        this.Hide();
                        frm.usuario = ds;
                        frm.Show();
                        
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("error no existe el usuario "+ error.Message);
                textBox1.Text = "";
                textBox2.Text = "";
            }


            }
    }
}
