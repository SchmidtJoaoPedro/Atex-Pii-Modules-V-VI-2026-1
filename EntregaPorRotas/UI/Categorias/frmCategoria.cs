using EntregaPorRotas.backend;
using EntregaPorRotas.repository;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.Categorias
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição da categoria.");
                return;
            }

            Categoria categoria = new Categoria
            {
                Descricao = txtDescricao.Text.Trim()
            };

            CategoriaRepository repository = new CategoriaRepository();

            repository.Inserir(categoria);

            MessageBox.Show("Categoria cadastrada com sucesso.");

            txtDescricao.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
