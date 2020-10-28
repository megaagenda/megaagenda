using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.CodeDom;

namespace MegaAgenda
{
    class Class_Dados
    {

        public static bool verificaCPF(String cpf)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            string strSQL;
            conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
            conexao.Open();
            strSQL = "SELECT * FROM pessoa WHERE cpf = '" + cpf + "';";
            comando = new MySqlCommand(strSQL, conexao);
            MySqlDataReader resposta = comando.ExecuteReader();
            return resposta.HasRows;
        }

        public static void incluiPessoa(string dadosPessoa)
        {
            try
            {
                string[] dp = dadosPessoa.Split(';');
                string @cpf = dp[0];
                string @nome = dp[1];
                string @rg = dp[2];
                string @sexo = dp[3];

                MySqlConnection conexao;
                MySqlCommand comando;
                string strSQL;
                conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
                strSQL = ("INSERT INTO pessoa (nome, cpf, rg, sexo) VALUES ('" + nome + "', '" + cpf + "', '" + rg + "', '" + sexo + "');");
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show(nome + " Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string buscaUsuario(string cpf)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            string strSQL;
            conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
            conexao.Open();
            strSQL = "SELECT id, nome, rg FROM pessoa WHERE cpf = '" + cpf + "';";
            comando = new MySqlCommand(strSQL, conexao);
            MySqlDataReader resposta = comando.ExecuteReader();
            string rs = "";
            while (resposta.Read())
            {
                rs = (  resposta["id"].ToString() + ";"
                      + resposta["nome"].ToString() + ";"
                      + resposta["rg"].ToString());
            }
            resposta.Close();
            conexao.Close();
            return rs;
        }

        public static bool verificaUsuario(String id)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            string strSQL;
            conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
            conexao.Open();
            strSQL = "SELECT * FROM usuarios WHERE id_pessoa = '" + id + "';";
            comando = new MySqlCommand(strSQL, conexao);
            MySqlDataReader resposta = comando.ExecuteReader();
            return resposta.HasRows;
        }


        public static void incluiUsuario(string dadosUsuario)
        {
            try
            {
                string[] du = dadosUsuario.Split(';');
                string @id_pessoa = du[0];
                string @nomeUsuario = du[1];
                string @senha = du[2];

                MySqlConnection conexao;
                MySqlCommand comando;
                string strSQL;
                conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
                strSQL = ("INSERT INTO usuarios (id_pessoa, usuario, senha) VALUES ('" + id_pessoa + "', '" + nomeUsuario + "', '" + senha + "');");
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("Usuário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
