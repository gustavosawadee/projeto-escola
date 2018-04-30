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
    public partial class frmRelatorioDisciplinas : Form
    {
        public frmRelatorioDisciplinas()
        {
            InitializeComponent();
        }

        private void frmRelatorioDisciplinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Relatório Disciplinas?", "Saindo Relatório Disciplinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }
    }
}
