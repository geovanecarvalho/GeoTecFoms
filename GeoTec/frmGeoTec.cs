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
    public partial class frmGeoTec : Form
    {
        public frmGeoTec()
        {
            InitializeComponent();
        }
        public void AbriJanelaLogin()
        {
            frmLogin AbriLogin = new frmLogin();
            AbriLogin.Visible = true;
           
        }

        private void likConfiguração_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbriJanelaLogin();
        }

        private void frmGeoTec_Load(object sender, EventArgs e)
        {
            Init Inicial = new Init();

            Inicial.CriarPasta();
            Inicial.CriarArquivo("Name");
            Inicial.CriarArquivo("Date");
            Inicial.CriarArquivo("Description");


           
        }
    }
}
