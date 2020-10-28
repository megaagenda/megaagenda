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
    public partial class Form_Agenda : Form
    {
        public Form_Agenda()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Pessoas cadPessoas = new Form_Cad_Pessoas();
            cadPessoas.ShowDialog();
        }

        private void Form_Agenda_Load(object sender, EventArgs e)
        {
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cad_Usuarios cadUsuarios = new Form_Cad_Usuarios();
            cadUsuarios.ShowDialog();
        }
    }
}
