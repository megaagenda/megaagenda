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
    public partial class Form_Cad_Pessoas : Form
    {
        public Form_Cad_Pessoas()
        {
            InitializeComponent();
        }

        private void Form_Cad_Pessoas_Load(object sender, EventArgs e)
        {
            rbMasc.Checked = true;
            boxNome.Enabled = false;
            boxRG.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            string @nome = boxNome.Text;
            string @rg = boxRG.Text;
            string @sexo = "";
            if (rbMasc.Checked == true && rbFem.Checked == false)
            {
                sexo = "M";
            } 
            else
            {
                sexo = "F";
            }

            string dadosPessoa = cpf + ";" + nome + ";" + rg  + ";" + sexo;
            Class_Dados.incluiPessoa(dadosPessoa);

            boxCPF.Text = "";
            boxNome.Text = "";
            boxRG.Text = "";
            boxCPF.Enabled = true;
            rbMasc.Checked = true;
            boxNome.Enabled = false;
            boxRG.Enabled = false;
            rbMasc.Enabled = false;
            rbFem.Enabled = false;

        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            bool resultado = Class_Dados.verificaCPF(cpf);

            if (cpf != "")
            {
                if (resultado == false)
                {
                    rbMasc.Checked = true;
                    boxCPF.Enabled = false;
                    boxNome.Enabled = true;
                    boxRG.Enabled = true;
                    rbMasc.Enabled = true;
                    rbFem.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("CPF já Cadastrado!");
                    boxCPF.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o CPF!");
            }



        }
    }
}
