using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projeto_Escola{
    public partial class frmOpcoes : Form{
        public frmOpcoes(){
            InitializeComponent();
        }

        private void mstripCadDisciplina_Click(object sender, EventArgs e){
            frmCadDisciplinas cad_disciplina = new frmCadDisciplinas(); 
            cad_disciplina.MdiParent = this; 
            cad_disciplina.Show(); 
        }

        private void mstripCadAlunos_Click(object sender, EventArgs e){
            frmCadAlunos cad_aluno = new frmCadAlunos();
            cad_aluno.MdiParent = this;
            cad_aluno.Show(); 
        }

        private void mstripConsDisciplinas_Click(object sender, EventArgs e){
            frmConsultaDisciplinas consulta_disciplina = new frmConsultaDisciplinas();
            consulta_disciplina.MdiParent = this;
            consulta_disciplina.Show(); 
        }

        private void mstripConsAlunos_Click(object sender, EventArgs e){
            frmConsultaAlunos consulta_aluno = new frmConsultaAlunos();
            consulta_aluno.MdiParent = this;
            consulta_aluno.Show(); 
        }

        private void mstripConsPorDisciplicas_Click(object sender, EventArgs e){
            frmConsultaPorDisciplinas consulta_por_disciplina = new frmConsultaPorDisciplinas();
            consulta_por_disciplina.MdiParent = this;
            consulta_por_disciplina.Show(); 
        }

        private void mstripConsPorAlunos_Click(object sender, EventArgs e){
            frmConsultaPorAluno consulta_por_aluno = new frmConsultaPorAluno();
            consulta_por_aluno.MdiParent = this;
            consulta_por_aluno.Show(); 
        }

        private void mstripConsPorMencao_Click(object sender, EventArgs e){
            frmConsultaPorMencao consulta_por_mencao = new frmConsultaPorMencao();
            consulta_por_mencao.MdiParent = this;
            consulta_por_mencao.Show(); 
        }

        private void mstripLancarNota_Click(object sender, EventArgs e){
            frmLancarNotaAluno lancar_nota_aluno = new frmLancarNotaAluno();
            lancar_nota_aluno.MdiParent = this;
            lancar_nota_aluno.Show(); 
        }

        private void mstripRelatorioDisciplinas_Click(object sender, EventArgs e){
            frmRelatorioDisciplinas relatorio_disciplinas = new frmRelatorioDisciplinas();
            relatorio_disciplinas.MdiParent = this;
            relatorio_disciplinas.Show(); 
        }

        private void mstripRelatorioAlunos_Click(object sender, EventArgs e){
            frmRelatorioAlunos relatorio_alunos = new frmRelatorioAlunos();
            relatorio_alunos.MdiParent = this;
            relatorio_alunos.Show(); 
        }

        private void mstripRelatorioAnalitico_Click(object sender, EventArgs e){
            frmRelatorioAnalitico relatorio_analitico = new frmRelatorioAnalitico();
            relatorio_analitico.MdiParent = this;
            relatorio_analitico.Show(); 
        }

        private void frmOpcoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Sistemas Escolar?", "Saindo Sistemas Escolar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        public string connectionString { get; set; }
    }
}
