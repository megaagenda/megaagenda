using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaAgenda
{
    public partial class Form_Cad_Usuarios : Form
    {
        public Form_Cad_Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string @cpf = Class_Converte_Dados.cpf(boxCPF.Text);

            
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Favor informar um CPF!");
                
            }
            else
            {
                MessageBox.Show("CPF informado!");
            }
        }
    }
}
