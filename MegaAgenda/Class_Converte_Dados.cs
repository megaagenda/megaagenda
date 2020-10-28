using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaAgenda
{
    class Class_Converte_Dados
    {
        public static string cpf(string cpf)
        {
            cpf = cpf.TrimStart('0');
            cpf = cpf.Replace(".", string.Empty);
            cpf = cpf.Replace(",", string.Empty);
            cpf = cpf.Replace("-", string.Empty);
            cpf = cpf.Replace(" ", string.Empty);
            return cpf;
        }
    }
}
