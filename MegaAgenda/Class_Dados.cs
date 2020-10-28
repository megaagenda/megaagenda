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
            catch
            {
                MessageBox.Show("Não é possível cadastrar dois blocos com o mesmo número");
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
    }
}
