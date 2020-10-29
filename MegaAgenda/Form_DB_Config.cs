using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaAgenda
{
    public partial class Form_DB_Config : Form
    {
        public Form_DB_Config()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pastaConfig = @"C:\AGENDA\";
            string arqConfig = @"MEGAAGENDA.CFG";
            string pathString = System.IO.Path.Combine(pastaConfig, arqConfig);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString));
            }

            System.IO.StreamWriter arq;
            arq = File.CreateText(pathString);
            arq.WriteLine(boxEndereco.Text);
            arq.WriteLine(boxPorta.Text);
            arq.WriteLine(boxBanco.Text);
            arq.WriteLine(boxUsuario.Text);
            arq.WriteLine(boxSenha.Text);
            arq.Close();
            MessageBox.Show("Informações Gravadas!");
        }

        private void Form_DB_Config_Load(object sender, EventArgs e)
        {
            string pastaConfig = @"C:\AGENDA\";
            string arqConfig = @"MEGAAGENDA.CFG";
            string pathString = System.IO.Path.Combine(pastaConfig, arqConfig);

            string[] confValores = File.ReadAllLines(pathString);
            for (int i = 0; i < confValores.Length; i++)
            {
                boxEndereco.Text = confValores[0];
                boxPorta.Text = confValores[1];
                boxBanco.Text = confValores[2];
                boxUsuario.Text = confValores[3];
                boxSenha.Text = confValores[4];
            }
        }
    }
}
