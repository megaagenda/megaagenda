using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaAgenda
{
    class Class_Acesso_Sistema
    {
        public static bool confereAcesso(String usuario, String senha)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            string strSQL;
            conexao = new MySqlConnection("Server = " + Program.endBanco + "; Port = " + Program.portBanco + "; Database = " + Program.database + "; Uid = " + Program.userBanco + "; Pwd = " + Program.senhaBanco + "; pooling = false; convert zero datetime=True;");
            conexao.Open();
            strSQL = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "' and senha = '" + senha + "';";
            comando = new MySqlCommand(strSQL, conexao);
            MySqlDataReader resposta = comando.ExecuteReader();
            return resposta.HasRows;
        }
    }
}
