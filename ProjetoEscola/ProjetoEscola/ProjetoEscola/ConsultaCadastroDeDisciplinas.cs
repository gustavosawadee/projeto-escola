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
    public partial class frmConsultaCadastroDeDisciplinas : Form
    {
        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public frmConsultaCadastroDeDisciplinas()
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
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("descricao LIKE'%{0}%'", textBox1.Text);
            }
            else if (cbxCampoPesquisa.SelectedIndex == 2)
            {
                var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("sigla LIKE'%{0}%'", textBox1.Text);
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
            string query = "select * from tb_disciplinas";
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
