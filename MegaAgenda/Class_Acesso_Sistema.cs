﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaAgenda
{
    class Class_Acesso_Sistema
    {
        public static bool confereAcesso(String usuario, String senha)
        {
            bool resultado = false;
            try
            {
                MySqlConnection conexao;
                MySqlCommand comando;
                string strSQL;
                conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
                conexao.Open();
                strSQL = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "' and senha = '" + senha + "';";
                comando = new MySqlCommand(strSQL, conexao);
                MySqlDataReader resposta = comando.ExecuteReader();
                resultado =  resposta.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar com o Banco!");
            }
            return resultado;
        }

        public static string dataAtual(string data)
        {
            data = data.Replace("00", string.Empty);
            data = data.Replace(":", string.Empty);
            data = data.Replace("/", string.Empty);
            data = data.Replace(" ", string.Empty);
            return data;
        }

        public static string geraChave(string dadosChave)
        {
            string @chave = string.Empty;
            string @chave1 = string.Empty;
            string @chave2 = string.Empty;
            char[] ch = dadosChave.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (i <= 7)
                {
                    if (ch[i].ToString() == "0")
                    {
                        chave = chave + "9";
                    }
                    if (ch[i].ToString() == "1")
                    {
                        chave = chave + "8";
                    }
                    if (ch[i].ToString() == "2")
                    {
                        chave = chave + "7";
                    }
                    if (ch[i].ToString() == "3")
                    {
                        chave = chave + "6";
                    }
                    if (ch[i].ToString() == "4")
                    {
                        chave = chave + "5";
                    }
                    if (ch[i].ToString() == "5")
                    {
                        chave = chave + "4";
                    }
                    if (ch[i].ToString() == "6")
                    {
                        chave = chave + "3";
                    }
                    if (ch[i].ToString() == "7")
                    {
                        chave = chave + "2";
                    }
                    if (ch[i].ToString() == "8")
                    {
                        chave = chave + "1";
                    }
                    if (ch[i].ToString() == "9")
                    {
                        chave = chave + "0";
                    }
                }
                if (i > 7 && i <= 15)
                {
                    if (ch[i].ToString() == "a")
                    {
                        chave = chave + "0";
                    }
                    if (ch[i].ToString() == "e")
                    {
                        chave = chave + "2";
                    }
                    if (ch[i].ToString() == "i")
                    {
                        chave = chave + "3";
                    }
                    if (ch[i].ToString() == "o")
                    {
                        chave = chave + "4";
                    }
                    if (ch[i].ToString() == "u")
                    {
                        chave = chave + "5";
                    }
                }
            }

            char[] ch1 = chave.ToCharArray();

            for (int i = 0; i < ch1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    chave1 = chave1 + ch1[i];
                }
            }

            char[] ch2 = chave1.ToCharArray();

            if (ch2.Length == 4)
            {
                chave2 = ch2[3].ToString() + ch2[0].ToString() + ch2[1].ToString() + ch2[2].ToString();
            }

            if (ch2.Length == 5)
            {
                chave2 = ch2[4].ToString() + ch2[3].ToString() + ch2[0].ToString() + ch2[1].ToString() + ch2[2].ToString();
            }

            if (ch2.Length >= 6)
            {
                chave2 = ch2[4].ToString() + ch2[3].ToString() + ch2[0].ToString() + ch2[1].ToString() + ch2[2].ToString() + ch2[5].ToString();
            }
            return chave2;
        }
        public static void carregaDB()
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
