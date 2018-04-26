using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Escola{
    public partial class frmRelatorioAnalitico : Form{
        public frmRelatorioAnalitico(){
            InitializeComponent();
        }

        private void frmRelatorioAnalitico_FormClosing(object sender, FormClosingEventArgs e){
            if (MessageBox.Show("Deseja sair do Relatório Analitico?", "Saindo Relatório Analitico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }
    }
}
