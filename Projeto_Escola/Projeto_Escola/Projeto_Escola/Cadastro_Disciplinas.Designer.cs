﻿namespace Projeto_Escola
{
    partial class frmCadDisciplinas
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
            this.lblCadCodigo = new System.Windows.Forms.Label();
            this.lblCadDesc = new System.Windows.Forms.Label();
            this.lblCadSigla = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodDisciplina = new System.Windows.Forms.Label();
            this.txbCadDesc = new System.Windows.Forms.TextBox();
            this.txbCadSigla = new System.Windows.Forms.TextBox();
            this.gpbNav = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridViewDisciplinas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadCodigo
            // 
            this.lblCadCodigo.AutoSize = true;
            this.lblCadCodigo.Location = new System.Drawing.Point(37, 37);
            this.lblCadCodigo.Name = "lblCadCodigo";
            this.lblCadCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCadCodigo.TabIndex = 0;
            this.lblCadCodigo.Text = "Código:";
            // 
            // lblCadDesc
            // 
            this.lblCadDesc.AutoSize = true;
            this.lblCadDesc.Location = new System.Drawing.Point(37, 65);
            this.lblCadDesc.Name = "lblCadDesc";
            this.lblCadDesc.Size = new System.Drawing.Size(58, 13);
            this.lblCadDesc.TabIndex = 1;
            this.lblCadDesc.Text = "Descrição:";
            // 
            // lblCadSigla
            // 
            this.lblCadSigla.AutoSize = true;
            this.lblCadSigla.Location = new System.Drawing.Point(37, 97);
            this.lblCadSigla.Name = "lblCadSigla";
            this.lblCadSigla.Size = new System.Drawing.Size(33, 13);
            this.lblCadSigla.TabIndex = 2;
            this.lblCadSigla.Text = "Sigla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite a Sigla da disciplina a ser pesquisada:";
            // 
            // lblCodDisciplina
            // 
            this.lblCodDisciplina.AutoSize = true;
            this.lblCodDisciplina.Location = new System.Drawing.Point(87, 37);
            this.lblCodDisciplina.Name = "lblCodDisciplina";
            this.lblCodDisciplina.Size = new System.Drawing.Size(13, 13);
            this.lblCodDisciplina.TabIndex = 4;
            this.lblCodDisciplina.Text = "1";
            // 
            // txbCadDesc
            // 
            this.txbCadDesc.Location = new System.Drawing.Point(101, 62);
            this.txbCadDesc.Name = "txbCadDesc";
            this.txbCadDesc.Size = new System.Drawing.Size(100, 20);
            this.txbCadDesc.TabIndex = 5;
            // 
            // txbCadSigla
            // 
            this.txbCadSigla.Location = new System.Drawing.Point(101, 94);
            this.txbCadSigla.Name = "txbCadSigla";
            this.txbCadSigla.Size = new System.Drawing.Size(100, 20);
            this.txbCadSigla.TabIndex = 6;
            // 
            // gpbNav
            // 
            this.gpbNav.Controls.Add(this.button4);
            this.gpbNav.Controls.Add(this.button3);
            this.gpbNav.Controls.Add(this.button2);
            this.gpbNav.Controls.Add(this.button1);
            this.gpbNav.Location = new System.Drawing.Point(40, 146);
            this.gpbNav.Name = "gpbNav";
            this.gpbNav.Size = new System.Drawing.Size(337, 68);
            this.gpbNav.TabIndex = 7;
            this.gpbNav.TabStop = false;
            this.gpbNav.Text = "Navegação";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Último";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Anterior";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Próximo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Primeiro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Novo Registro";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(453, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(507, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(507, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Excluir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(507, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Incluir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridViewDisciplinas
            // 
            this.dataGridViewDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinas.Location = new System.Drawing.Point(40, 220);
            this.dataGridViewDisciplinas.Name = "dataGridViewDisciplinas";
            this.dataGridViewDisciplinas.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewDisciplinas.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 13;
            // 
            // frmCadDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 467);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewDisciplinas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.gpbNav);
            this.Controls.Add(this.txbCadSigla);
            this.Controls.Add(this.txbCadDesc);
            this.Controls.Add(this.lblCodDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCadSigla);
            this.Controls.Add(this.lblCadDesc);
            this.Controls.Add(this.lblCadCodigo);
            this.Name = "frmCadDisciplinas";
            this.Text = "Cadastro Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadDisciplinas_FormClosing);
            this.gpbNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadCodigo;
        private System.Windows.Forms.Label lblCadDesc;
        private System.Windows.Forms.Label lblCadSigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodDisciplina;
        private System.Windows.Forms.TextBox txbCadDesc;
        private System.Windows.Forms.TextBox txbCadSigla;
        private System.Windows.Forms.GroupBox gpbNav;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridViewDisciplinas;
        private System.Windows.Forms.TextBox textBox1;
    }
}