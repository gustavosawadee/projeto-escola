using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoEscola
{
    public partial class frmConsultaCadastralDeAlunos : Form
    {

        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public frmConsultaCadastralDeAlunos()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxCampoPesquisa.SelectedIndex == 0)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "Convert(id, System.String) LIKE '" + textBox1.Text + "%'";
            }
            else if (cbxCampoPesquisa.SelectedIndex == 1)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nome LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 2)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nascimento LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 3)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Endereço LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 4)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Bairro LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 5)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cidade LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 6)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "Convert(cep, System.String) LIKE '" + textBox1.Text + "%'";
            }
            else if (cbxCampoPesquisa.SelectedIndex == 7)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "Convert(rg, System.String) LIKE '" + textBox1.Text + "%'";
            }
            else if (cbxCampoPesquisa.SelectedIndex == 8)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "Convert(telefone, System.String) LIKE '" + textBox1.Text + "%'";
            }
            else
            {
                MessageBox.Show("Escolha um campo!");
                textBox1.Clear();
            }
        }

        public void atualizaDataGrid()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select * from tb_alunos";
            SqlCommand cmd = new SqlCommand(query, SQLSERVER);
            SqlDataAdapter adapter = new SqlDataAdapter(query, SQLSERVER);

            SQLSERVER.Open();
            int resultado = cmd.ExecuteNonQuery();
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

        }
    }
}
