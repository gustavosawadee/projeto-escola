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
    public partial class frmConsultaDisciplinas : Form
    {
        public frmConsultaDisciplinas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaDisciplinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Consulta de Disciplinas?", "Saindo Consulta de Disciplinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            string script = "SELECT * FROM disciplinas";
            if (cbxFiltro.Text == "Sigla") 
            {
                script = "Select * from disciplinas where sigla like '" + txbFiltro.Text + "%'";
            }
            else if (cbxFiltro.Text == "disciplinas")
            {
                script = "Select * from disciplinas where disciplina like '" + txbFiltro.Text + "%'";
            }
            else if (cbxFiltro.Text == "Codigo da disciplina")
            {
                script = "Select * from disciplinas where id like '" + txbFiltro.Text + "%'";
            }
            else
            { 
                MessageBox.Show("escolha um campo para pesquisar! " +cbxFiltro.Focus());       
            }
        }
    }
}
