using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorSenha
{
    public partial class Form_Gerador : Form
    {
        public Form_Gerador()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            string dataAtual = Class_Gerador.dataAtual(thisDay.ToString());
            boxDataAtual.Text = dataAtual;
            boxDataAtual.Enabled = false;
            boxPalavraChave.Text = "megaagenda";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = Class_Gerador.ajustaData(boxDataAtual.Text);
            string palavraChave = boxPalavraChave.Text;
            string dadosChave = data + palavraChave;
            string chave = Class_Gerador.geraChave(dadosChave);
            boxSenha.Text = chave;
        }
    }
}
