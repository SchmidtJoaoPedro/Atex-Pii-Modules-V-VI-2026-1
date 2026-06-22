using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.CestasBasicas
{
    public partial class frmCestaBasica : Form
    {
        public frmCestaBasica()
        {
            InitializeComponent();
        }

        private void frmCestaBasica_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            CategoriaRepository repository = new CategoriaRepository();

            cbCategoria.DataSource = repository.ObterTodos();
            cbCategoria.DisplayMember = "Descricao";
            cbCategoria.ValueMember = "CodigoCategoria";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            CestaBasica cesta = new CestaBasica
            {
                CodigoCategoria = Convert.ToInt32(cbCategoria.SelectedValue),
                Quantidade = (int)nudQuantidade.Value
            };

            CestaBasicaRepository repository = new CestaBasicaRepository();

            repository.Inserir(cesta);

            MessageBox.Show("Cesta básica cadastrada com sucesso.");

            cbCategoria.SelectedIndex = 0;
            nudQuantidade.Value = nudQuantidade.Minimum;
        }

        private bool Validar()
        {
            if (cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria.");
                return false;
            }

            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
