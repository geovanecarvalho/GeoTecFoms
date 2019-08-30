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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MdlCadastro cad = new MdlCadastro();

                cad.setData(txtData.Text);
                cad.setName(txtNome.Text);
                cad.setDescription(txtDescricao.Text);

                Cadastro ctlCadastro = new Cadastro();

                ctlCadastro.inserir(cad.getData(), cad.getName(), cad.getDescription());
            }
            catch
            {
                MessageBox.Show("Erro no cadastro");
            }
               
           
        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
