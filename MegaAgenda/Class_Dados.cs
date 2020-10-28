using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MegaAgenda
{
    class Class_Dados
    {
        public static void incluiPessoa(string dadosPessoa)
        {
            try
            {
                string[] db = dadosBloco.Split(';');
                string @numBloco = db[0];
                string @descricao = db[1];
                MySqlConnection conexao;
                MySqlCommand comando;
                string strSQL;
                conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
                strSQL = ("INSERT INTO cadbloco(num_bloco, descricao) VALUES('" + numBloco + "', '" + descricao + "');");
                comando = new MySqlCommand(strSQL, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                conexao = null;
                comando = null;
                MessageBox.Show("Bloco: " + descricao + " Incluido com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Não é possível cadastrar dois blocos com o mesmo número");
            }
        }
    }
}
