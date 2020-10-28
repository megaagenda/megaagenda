using Google.Protobuf.WellKnownTypes;
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
    public partial class Form_Cad_Usuarios : Form
    {
        public Form_Cad_Usuarios()
        {
            InitializeComponent();
            boxNome.Enabled = false;
            boxRG.Enabled = false;
            btIncluir.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            string @usuarioPessoa = "";
            string @id = "";
            string @nomePessoa = "";
            string @rgPessoa = "";
            
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Favor informar um CPF!");                
            }
            else
            {
                bool resultado = Class_Dados.verificaCPF(cpf);
                if (resultado == true)
                {
                    MessageBox.Show("CPF Encontrado!");
                    usuarioPessoa = Class_Dados.buscaUsuario(cpf);
                    string[] resultadoPessoa = usuarioPessoa.Split(';');
                    id = resultadoPessoa[0];
                    nomePessoa = resultadoPessoa[1];
                    rgPessoa = resultadoPessoa[2];
                    boxNome.Text = nomePessoa;
                    boxRG.Text = rgPessoa;

                    bool usuarioExist = Class_Dados.verificaUsuario(id);
                    
                    if (usuarioExist == true)
                    {
                        btAlterar.Enabled = true;
                        btExcluir.Enabled = true;
                    }
                    else
                    {
                        btIncluir.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Pessoa não cadastrada!");
                }
            }
        }

        private void Form_Cad_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            string @id = "";
            string usuarioPessoa = Class_Dados.buscaUsuario(cpf);
            string[] resultadoPessoa = usuarioPessoa.Split(';');
            id = resultadoPessoa[0];

            string @nomeUsuario = boxUsuario.Text;
            string @senha = boxSenha.Text;

            string dadosUsuario = id + ";" + nomeUsuario + ";" + senha;

            Class_Dados.incluiUsuario(dadosUsuario);

        }
    }
}
