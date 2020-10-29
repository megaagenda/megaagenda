using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaAgenda
{
    public partial class Form_Entrada : Form
    {
        public Form_Entrada()
        {
            InitializeComponent();
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
    }
}
