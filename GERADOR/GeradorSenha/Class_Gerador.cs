using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSenha
{
    class Class_Gerador
    {
        public static string dataAtual(string data)
        {
            data = data.Replace("00", string.Empty);
            data = data.Replace(":", string.Empty);
            data = data.Replace(" ", string.Empty);
            return data;
        }
    }
}
