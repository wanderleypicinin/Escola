using System.Data.Common;
using Escola.Dados;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dados.DBConnections.GetConnection().ToString());
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            DBConnections dados = new DBConnections();

            dados.Cadastrar(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtTelefone.Text);
            MessageBox.Show("Cadastro com sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //excluir
            DBConnections dados = new DBConnections();
            dados.Excluir(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Excluido com sucesso");
            txtId.Clear();
            txtId.Focus();
        }
    }
}
