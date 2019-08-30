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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            txtDate.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtBackup.Text = string.Empty;
            txtDate.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtDescription.Text))
            {

                
                MessageBox.Show("Preencha todos os Campos obrigatório!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if(string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Preencha todos os Campos obrigatório!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
            else
            {
                var result = MessageBox.Show("Cadastrados Realizado com Sucesso!","Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MdlCadastro mCad = new MdlCadastro();

                mCad.setData(txtDate.Text);
                mCad.setName(txtNome.Text);
                mCad.setDescription(txtDescription.Text);

                Cadastro ctlCad = new Cadastro();

                if(result == DialogResult.OK)
                {
                    ctlCad.Inserir(mCad.getData(), mCad.getName(), mCad.getDescription());
                }




                LimparTela();
            }
            


        }

        private void txtDate_Validating(object sender, CancelEventArgs e)
        {
            string var = txtDate.Text;
            int count = 0;
            for (int i = 0; i < var.Length; i++)
            {
                count++;
            }

            if (count <= 9)
            {
                e.Cancel = false;
                txtDate.Focus();
                errorProvider1.SetError(txtDate, "Campo de Data de Garantia  é Obrigatório!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDate, null);
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                e.Cancel = false;
                txtNome.Focus();
                errorProvider2.SetError(txtNome, "Campo de Nome do Cliente é Obrigatório!");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtNome, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                e.Cancel = false;
                txtDescription.Focus();
                errorProvider2.SetError(txtDescription, "Campo de Descrição é Obrigatório!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtDescription, null);
            }
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
