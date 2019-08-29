using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controler;

namespace GeoTec
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            txtLogin.Focus();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MdlLogin login = new MdlLogin();
          
            login.setLogin(txtLogin.Text);
            login.setSenha(txtSenha.Text);

            Login log = new Login();

            log.Verificar(login.getLogin(), login.getSenha());
              
           if (log.Acesso() == true)
            {
                MessageBox.Show("Acesso Permitido!","Parabéns",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                Close();
                frmSettings conf = new frmSettings();
                conf.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Acesso Negado!","Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                txtLogin.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtLogin.Focus();
        }

        private void ntnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
