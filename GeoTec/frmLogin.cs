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
            
            
        }
        

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                e.Cancel = false;
                txtLogin.Focus();
                errorProvider1.SetError(txtLogin, "Campo Obrigatório!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLogin, null);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtLogin.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MdlLogin log = new MdlLogin();
            log.setLogin(txtLogin.Text);
            log.setSenha(txtSenha.Text);

            Login ctlLogin = new Login();
            ctlLogin.Verificar(log.getLogin(), log.getSenha());

            if (ctlLogin.Acesso() == true)
            {
                MessageBox.Show("Acesso Permitido", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSettings confg = new frmSettings();
                Close();
                confg.Visible = true;
            }
            else
            {
                MessageBox.Show("Acesso Negado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtLogin.Focus();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
