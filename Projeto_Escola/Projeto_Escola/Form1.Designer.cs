namespace Projeto_Escola
{
    partial class frmOpcoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstripOpcoes = new System.Windows.Forms.MenuStrip();
            this.mstripCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripCadDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripCadAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsPorDisciplicas = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsPorAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripConsPorMencao = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripLancarNota = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripRelatorioDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripRelatorioAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripRelatorioAnalitico = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mstripOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripOpcoes
            // 
            this.mstripOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripCadastros,
            this.mstripConsultas,
            this.mstripLancamentos,
            this.mstripRelatorios});
            this.mstripOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mstripOpcoes.Name = "mstripOpcoes";
            this.mstripOpcoes.Size = new System.Drawing.Size(870, 24);
            this.mstripOpcoes.TabIndex = 1;
            this.mstripOpcoes.Text = "menuStrip1";
            // 
            // mstripCadastros
            // 
            this.mstripCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripCadDisciplina,
            this.mstripCadAlunos});
            this.mstripCadastros.Name = "mstripCadastros";
            this.mstripCadastros.Size = new System.Drawing.Size(71, 20);
            this.mstripCadastros.Text = "Cadastros";
            // 
            // mstripCadDisciplina
            // 
            this.mstripCadDisciplina.Name = "mstripCadDisciplina";
            this.mstripCadDisciplina.Size = new System.Drawing.Size(152, 22);
            this.mstripCadDisciplina.Text = "Disciplinas";
            this.mstripCadDisciplina.Click += new System.EventHandler(this.mstripCadDisciplina_Click);
            // 
            // mstripCadAlunos
            // 
            this.mstripCadAlunos.Name = "mstripCadAlunos";
            this.mstripCadAlunos.Size = new System.Drawing.Size(152, 22);
            this.mstripCadAlunos.Text = "Alunos";
            this.mstripCadAlunos.Click += new System.EventHandler(this.mstripCadAlunos_Click);
            // 
            // mstripConsultas
            // 
            this.mstripConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripConsDisciplinas,
            this.mstripConsAlunos,
            this.mstripConsPorDisciplicas,
            this.mstripConsPorAlunos,
            this.mstripConsPorMencao});
            this.mstripConsultas.Name = "mstripConsultas";
            this.mstripConsultas.Size = new System.Drawing.Size(71, 20);
            this.mstripConsultas.Text = "Consultas";
            // 
            // mstripConsDisciplinas
            // 
            this.mstripConsDisciplinas.Name = "mstripConsDisciplinas";
            this.mstripConsDisciplinas.Size = new System.Drawing.Size(152, 22);
            this.mstripConsDisciplinas.Text = "Disciplinas";
            this.mstripConsDisciplinas.Click += new System.EventHandler(this.mstripConsDisciplinas_Click);
            // 
            // mstripConsAlunos
            // 
            this.mstripConsAlunos.Name = "mstripConsAlunos";
            this.mstripConsAlunos.Size = new System.Drawing.Size(152, 22);
            this.mstripConsAlunos.Text = "Alunos";
            this.mstripConsAlunos.Click += new System.EventHandler(this.mstripConsAlunos_Click);
            // 
            // mstripConsPorDisciplicas
            // 
            this.mstripConsPorDisciplicas.Name = "mstripConsPorDisciplicas";
            this.mstripConsPorDisciplicas.Size = new System.Drawing.Size(152, 22);
            this.mstripConsPorDisciplicas.Text = "Por Disciplinas";
            this.mstripConsPorDisciplicas.Click += new System.EventHandler(this.mstripConsPorDisciplicas_Click);
            // 
            // mstripConsPorAlunos
            // 
            this.mstripConsPorAlunos.Name = "mstripConsPorAlunos";
            this.mstripConsPorAlunos.Size = new System.Drawing.Size(152, 22);
            this.mstripConsPorAlunos.Text = "Por Alunos";
            this.mstripConsPorAlunos.Click += new System.EventHandler(this.mstripConsPorAlunos_Click);
            // 
            // mstripConsPorMencao
            // 
            this.mstripConsPorMencao.Name = "mstripConsPorMencao";
            this.mstripConsPorMencao.Size = new System.Drawing.Size(152, 22);
            this.mstripConsPorMencao.Text = "Por Menção";
            this.mstripConsPorMencao.Click += new System.EventHandler(this.mstripConsPorMencao_Click);
            // 
            // mstripLancamentos
            // 
            this.mstripLancamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripLancarNota});
            this.mstripLancamentos.Name = "mstripLancamentos";
            this.mstripLancamentos.Size = new System.Drawing.Size(88, 20);
            this.mstripLancamentos.Text = "Lançar Notas";
            // 
            // mstripLancarNota
            // 
            this.mstripLancarNota.Name = "mstripLancarNota";
            this.mstripLancarNota.Size = new System.Drawing.Size(152, 22);
            this.mstripLancarNota.Text = "Alunos";
            this.mstripLancarNota.Click += new System.EventHandler(this.mstripLancarNota_Click);
            // 
            // mstripRelatorios
            // 
            this.mstripRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripRelatorioDisciplinas,
            this.mstripRelatorioAlunos,
            this.mstripRelatorioAnalitico});
            this.mstripRelatorios.Name = "mstripRelatorios";
            this.mstripRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mstripRelatorios.Text = "Relatórios";
            // 
            // mstripRelatorioDisciplinas
            // 
            this.mstripRelatorioDisciplinas.Name = "mstripRelatorioDisciplinas";
            this.mstripRelatorioDisciplinas.Size = new System.Drawing.Size(196, 22);
            this.mstripRelatorioDisciplinas.Text = "Cadastro de Disciplinas";
            this.mstripRelatorioDisciplinas.Click += new System.EventHandler(this.mstripRelatorioDisciplinas_Click);
            // 
            // mstripRelatorioAlunos
            // 
            this.mstripRelatorioAlunos.Name = "mstripRelatorioAlunos";
            this.mstripRelatorioAlunos.Size = new System.Drawing.Size(196, 22);
            this.mstripRelatorioAlunos.Text = "Cadastro de Alunos";
            this.mstripRelatorioAlunos.Click += new System.EventHandler(this.mstripRelatorioAlunos_Click);
            // 
            // mstripRelatorioAnalitico
            // 
            this.mstripRelatorioAnalitico.Name = "mstripRelatorioAnalitico";
            this.mstripRelatorioAnalitico.Size = new System.Drawing.Size(196, 22);
            this.mstripRelatorioAnalitico.Text = "Relatório Analitico";
            this.mstripRelatorioAnalitico.Click += new System.EventHandler(this.mstripRelatorioAnalitico_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mstripOpcoes);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstripOpcoes;
            this.Name = "frmOpcoes";
            this.Text = "Menu de Opções";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpcoes_FormClosing);
            this.mstripOpcoes.ResumeLayout(false);
            this.mstripOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripOpcoes;
        private System.Windows.Forms.ToolStripMenuItem mstripCadastros;
        private System.Windows.Forms.ToolStripMenuItem mstripCadDisciplina;
        private System.Windows.Forms.ToolStripMenuItem mstripCadAlunos;
        private System.Windows.Forms.ToolStripMenuItem mstripConsultas;
        private System.Windows.Forms.ToolStripMenuItem mstripConsDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem mstripConsAlunos;
        private System.Windows.Forms.ToolStripMenuItem mstripConsPorDisciplicas;
        private System.Windows.Forms.ToolStripMenuItem mstripConsPorAlunos;
        private System.Windows.Forms.ToolStripMenuItem mstripConsPorMencao;
        private System.Windows.Forms.ToolStripMenuItem mstripLancamentos;
        private System.Windows.Forms.ToolStripMenuItem mstripLancarNota;
        private System.Windows.Forms.ToolStripMenuItem mstripRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mstripRelatorioDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem mstripRelatorioAlunos;
        private System.Windows.Forms.ToolStripMenuItem mstripRelatorioAnalitico;
        private System.Windows.Forms.StatusStrip statusStrip1;

        public System.EventHandler frmOpcoes_Load { get; set; }
    }
}

