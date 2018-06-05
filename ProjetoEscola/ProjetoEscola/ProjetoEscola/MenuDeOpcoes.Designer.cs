namespace ProjetoEscola
{
    partial class formMenuDeOpcoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuDeOpcoes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.analíticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.lançarNotasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem,
            this.alunosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas - Ctrl + D ";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alunosToolStripMenuItem.Text = "Alunos - Ctrl + A";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraisToolStripMenuItem,
            this.analíticasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cadastraisToolStripMenuItem
            // 
            this.cadastraisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem1,
            this.alunosToolStripMenuItem1});
            this.cadastraisToolStripMenuItem.Name = "cadastraisToolStripMenuItem";
            this.cadastraisToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cadastraisToolStripMenuItem.Text = "Cadastrais";
            // 
            // disciplinasToolStripMenuItem1
            // 
            this.disciplinasToolStripMenuItem1.Name = "disciplinasToolStripMenuItem1";
            this.disciplinasToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.disciplinasToolStripMenuItem1.Text = "Disciplinas - Alt + D";
            this.disciplinasToolStripMenuItem1.Click += new System.EventHandler(this.disciplinasToolStripMenuItem1_Click);
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.alunosToolStripMenuItem1.Text = "Alunos - Alt + A";
            this.alunosToolStripMenuItem1.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // analíticasToolStripMenuItem
            // 
            this.analíticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem2,
            this.alunosToolStripMenuItem2,
            this.mençãoToolStripMenuItem});
            this.analíticasToolStripMenuItem.Name = "analíticasToolStripMenuItem";
            this.analíticasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.analíticasToolStripMenuItem.Text = "Analíticas";
            // 
            // disciplinasToolStripMenuItem2
            // 
            this.disciplinasToolStripMenuItem2.Name = "disciplinasToolStripMenuItem2";
            this.disciplinasToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem2.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem2.Click += new System.EventHandler(this.disciplinasToolStripMenuItem2_Click);
            // 
            // alunosToolStripMenuItem2
            // 
            this.alunosToolStripMenuItem2.Name = "alunosToolStripMenuItem2";
            this.alunosToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.alunosToolStripMenuItem2.Text = "Alunos";
            this.alunosToolStripMenuItem2.Click += new System.EventHandler(this.alunosToolStripMenuItem2_Click);
            // 
            // mençãoToolStripMenuItem
            // 
            this.mençãoToolStripMenuItem.Name = "mençãoToolStripMenuItem";
            this.mençãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mençãoToolStripMenuItem.Text = "Menção";
            this.mençãoToolStripMenuItem.Click += new System.EventHandler(this.mençãoToolStripMenuItem_Click);
            // 
            // lançarNotasToolStripMenuItem
            // 
            this.lançarNotasToolStripMenuItem.Name = "lançarNotasToolStripMenuItem";
            this.lançarNotasToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.lançarNotasToolStripMenuItem.Text = "Lançar Notas";
            this.lançarNotasToolStripMenuItem.Click += new System.EventHandler(this.lançarNotasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraisToolStripMenuItem1,
            this.analíticosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // cadastraisToolStripMenuItem1
            // 
            this.cadastraisToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem3,
            this.alunosToolStripMenuItem3});
            this.cadastraisToolStripMenuItem1.Name = "cadastraisToolStripMenuItem1";
            this.cadastraisToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.cadastraisToolStripMenuItem1.Text = "Cadastrais";
            // 
            // disciplinasToolStripMenuItem3
            // 
            this.disciplinasToolStripMenuItem3.Name = "disciplinasToolStripMenuItem3";
            this.disciplinasToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem3.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem3.Click += new System.EventHandler(this.disciplinasToolStripMenuItem3_Click);
            // 
            // alunosToolStripMenuItem3
            // 
            this.alunosToolStripMenuItem3.Name = "alunosToolStripMenuItem3";
            this.alunosToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.alunosToolStripMenuItem3.Text = "Alunos";
            this.alunosToolStripMenuItem3.Click += new System.EventHandler(this.alunosToolStripMenuItem3_Click);
            // 
            // analíticosToolStripMenuItem
            // 
            this.analíticosToolStripMenuItem.Name = "analíticosToolStripMenuItem";
            this.analíticosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.analíticosToolStripMenuItem.Text = "Analíticos";
            this.analíticosToolStripMenuItem.Click += new System.EventHandler(this.analíticosToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 17);
            this.lblData.Text = "Data: ";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMenuDeOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenuDeOpcoes";
            this.Text = "Menu de Opções";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMenuDeOpcoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formMenuDeOpcoes_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analíticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem analíticosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;

    }
}

