﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            boxCPF.Enabled = false;
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
                        string dadosSenha = Class_Dados.buscaSenha(id);
                        string[] ds = dadosSenha.Split(';');
                        string @usuario = ds[0];
                        string @senha = ds[1];
                        boxUsuario.Text = usuario;
                        boxSenha.Text = senha;
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
            limpaGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            string @id = Class_Dados.buscaIDUsuario(cpf);
            string @usuario = boxUsuario.Text;
            string @senha = boxSenha.Text;
            string dadosUsuario = id + ";" + usuario + ";" + senha;
            Class_Dados.alteraUsuario(dadosUsuario);
            limpaGrid();
        }

        private void limpaGrid()
        {
            boxCPF.Enabled = true;
            boxNome.Text = "";
            boxRG.Text = "";
            boxUsuario.Text = "";
            boxSenha.Text = "";
            boxCPF.Text = "";
            btIncluir.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);
            string @id = Class_Dados.buscaIDUsuario(cpf);
            Class_Dados.excluiUsuario(id);
            limpaGrid();
        }
    }
}
