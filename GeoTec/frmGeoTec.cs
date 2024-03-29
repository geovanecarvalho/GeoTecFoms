﻿using System;
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
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

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

        public void Janela(bool valor)
        {
            StreamWriter write = new StreamWriter(@"c:\FileSystem\CheckBox.txt");
            write.WriteLine(chcBox.Checked);
            write.Close();
            

            if(valor == true)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipText = "Sistema GeoTec Informática em background";
                notifyIcon.ShowBalloonTip(10);
                
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                

                
            }
        }

        private void frmGeoTec_Load(object sender, EventArgs e)
        {
            Init Inicial = new Init();
            Leitura Ler = new Leitura();

            RegistryKey Reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            Reg.SetValue("GeoTec Informatica", Application.ExecutablePath.ToString());

            try
            {
                StreamReader lerCheck = new StreamReader(@"c:\FileSystem\CheckBox.txt");
                bool Ch = Convert.ToBoolean(lerCheck.ReadLine());
                lerCheck.Close();
                if(Ch == true)
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    this.ShowInTaskbar = false;
                    notifyIcon.Visible = true;
                    notifyIcon.BalloonTipText = "Sistema GeoTec Informática em background";
                    notifyIcon.ShowBalloonTip(10);
                }
                else
                {
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;

                }
                
                
               
               
            }
            catch
            {

            }
            
            try
            {
                Ler.lerArquivo();
                lblName.Text = "Olá Tudo Bem " + Ler.LerName()+ " Obrigado Por Ser Nosso Cliente";
                txtDescripition.Text =  Ler.LerDescription();
            }
            catch
            {
              
    
               

            }
            Inicial.CriarPasta();


            
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MINIMIZAR A JANELA
            Janela(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Backup ctlBack = new Backup();

            try
            {
                ctlBack.Verificar();

                if (string.IsNullOrEmpty(ctlBack.Verificar()))
                {
                    MessageBox.Show("Não foi realizado nenhum backup!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    Process.Start(ctlBack.Verificar());
                }
            }
            catch
            {
                var resut = MessageBox.Show("Os Aquivos de backup não foram configurados, deseja configura-los agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resut == DialogResult.Yes)
                {
                    frmLogin l = new frmLogin();
                    l.Visible = true;
                }
            }



            


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Site web = new Site();
            Process.Start(web.webGeotec());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Site web = new Site();
            Process.Start(web.webWhatsApp());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leitura Ler = new Leitura();
            try
            {
                Ler.lerArquivo();
                MessageBox.Show(Ler.LerDate(), "Garantia Válida até:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                var resut = MessageBox.Show("Os Aquivos de Garantia não foram configurados, deseja configura-los agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resut == DialogResult.Yes)
                {
                    frmLogin l = new frmLogin();
                    l.Visible = true;
                }

            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Janela(false);
        }

        private void chcBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Janela(false);
        }
    }
}
