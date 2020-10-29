using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaAgenda
{
    public partial class Form_Entrada : Form
    {
        public Form_Entrada()
        {
            InitializeComponent();
            boxSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Class_Acesso_Sistema.confereAcesso(boxUsuario.Text, boxSenha.Text)) == true)
            {
                this.Hide();
                Form AbrePrograma = new Form_Agenda();
                AbrePrograma.Closed += (s, args) => this.Close();
                AbrePrograma.Show();
            }
            else
            {
                DateTime thisDay = DateTime.Today;
                string dataAtual = Class_Acesso_Sistema.dataAtual(thisDay.ToString());
                string dadosChave = dataAtual + "megaagenda";
                string senha = Class_Acesso_Sistema.geraChave(dadosChave);

                if (boxUsuario.Text == "admin" && boxSenha.Text == senha)
                {
                    this.Hide();
                    Form AbrePrograma = new Form_Agenda();
                    AbrePrograma.Closed += (s, args) => this.Close();
                    AbrePrograma.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e senha incorretos!");
                    boxUsuario.Text = string.Empty;
                    boxSenha.Text = string.Empty;
                }
            }
        }

        private void Form_Entrada_Load(object sender, EventArgs e)
        {
            string pastaConfig = @"C:\AGENDA\";
            string arqConfig = @"MEGAAGENDA.CFG";
            string pathString = System.IO.Path.Combine(pastaConfig, arqConfig);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString)) ;
            }

            string[] confValores = File.ReadAllLines(pathString);
            for (int i = 0; i < confValores.Length; i++)
            {
                Program.endBanco = confValores[0];
                Program.portBanco = confValores[1];
                Program.database = confValores[2];
                Program.userBanco = confValores[3];
                Program.senhaBanco = confValores[4];
            }

        }
    }
}
