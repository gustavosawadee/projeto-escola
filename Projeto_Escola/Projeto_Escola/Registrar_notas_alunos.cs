using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class frmLancarNotaAluno : Form
    {
        public frmLancarNotaAluno()
        {
            InitializeComponent();
        }

        private void frmLancarNotaAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Registro de notas?", "Saindo Registro de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }
    }
}
