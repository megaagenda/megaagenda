using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace MegaAgenda
{
    static class Program
    {
        public static string endBanco = string.Empty;
        public static string portBanco = string.Empty;
        public static string database = string.Empty;
        public static string userBanco = string.Empty;
        public static string senhaBanco = string.Empty;

        //public static string endBanco = "www.qualitysys.com.br";
        //public static string portBanco = "3300";
        //public static string database = "agenda";
        //public static string userBanco = "root";
        //public static string senhaBanco = "Senha@123456";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Entrada());
        }
    }
}
