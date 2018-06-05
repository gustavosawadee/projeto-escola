using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class formMenuDeOpcoes : Form
    {
        public formMenuDeOpcoes()
        {
            InitializeComponent();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroDisciplinas cadDisc = new FrmCadastroDisciplinas();
            cadDisc.MdiParent = this;
            cadDisc.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAlunos cadAlunos = new frmCadastroAlunos();
            cadAlunos.MdiParent = this;
            cadAlunos.Show();
        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCadastroDeDisciplinas consultaDisciplinas = new frmConsultaCadastroDeDisciplinas();
            consultaDisciplinas.MdiParent = this;
            consultaDisciplinas.Show();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCadastralDeAlunos consultaAlunos = new frmConsultaCadastralDeAlunos();
            consultaAlunos.MdiParent = this;
            consultaAlunos.Show();
        }

        private void disciplinasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaPorDisciplinas consultaDisciplinas = new frmConsultaPorDisciplinas();
            consultaDisciplinas.MdiParent = this;
            consultaDisciplinas.Show();
        }

        private void alunosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaPorAluno consultaPorAlunos = new frmConsultaPorAluno();
            consultaPorAlunos.MdiParent = this;
            consultaPorAlunos.Show();
        }

        private void mençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPorMencao consultaMencao = new frmConsultaPorMencao();
            consultaMencao.MdiParent = this;
            consultaMencao.Show();
        }

        private void lançarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarMencoesAosAlunos registrarMencoesPorAlunos = new frmRegistrarMencoesAosAlunos();
            registrarMencoesPorAlunos.MdiParent = this;
            registrarMencoesPorAlunos.Show();
        }

        private void disciplinasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmRelatorioCadastralDeDisciplinas relatorioCadastralDeDisciplinas = new frmRelatorioCadastralDeDisciplinas();
            relatorioCadastralDeDisciplinas.MdiParent = this;
            relatorioCadastralDeDisciplinas.Show();
        }

        private void alunosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmRelatorioCadastralDeAlunos relatorioCadastralDeAlunos = new frmRelatorioCadastralDeAlunos();
            relatorioCadastralDeAlunos.MdiParent = this;
            relatorioCadastralDeAlunos.Show();
        }

        private void analíticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatoriosAnaliticos relatorioAnaliticos = new frmRelatoriosAnaliticos();
            relatorioAnaliticos.MdiParent = this;
            relatorioAnaliticos.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadastroDisciplinas cadastroDisciplinas = new FrmCadastroDisciplinas();
            cadastroDisciplinas.MdiParent = this;
            cadastroDisciplinas.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCadastroAlunos cadastroAlunos = new frmCadastroAlunos();
            cadastroAlunos.MdiParent = this;
            cadastroAlunos.Show();
        }

        private void formMenuDeOpcoes_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void formMenuDeOpcoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                FrmCadastroDisciplinas cadDisciplinas = new FrmCadastroDisciplinas();
                cadDisciplinas.MdiParent = this;
                cadDisciplinas.Show();
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                frmCadastroAlunos cadAlunos = new frmCadastroAlunos();
                cadAlunos.MdiParent = this;
                cadAlunos.Show();
            }
            else if (Control.ModifierKeys == Keys.Alt && e.KeyCode == Keys.D)
            {
                frmConsultaCadastroDeDisciplinas conDisciplinas = new frmConsultaCadastroDeDisciplinas();
                conDisciplinas.MdiParent = this;
                conDisciplinas.Show();
            }
            else if (Control.ModifierKeys == Keys.Alt && e.KeyCode == Keys.A)
            {
                frmConsultaCadastralDeAlunos consultaCadAlunos = new frmConsultaCadastralDeAlunos();
                consultaCadAlunos.MdiParent = this;
                consultaCadAlunos.Show();
            }
        }
    }
}
