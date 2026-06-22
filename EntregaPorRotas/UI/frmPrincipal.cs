using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;
using EntregaPorRotas.UI.Beneficiarios;
using EntregaPorRotas.UI.Categorias;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private readonly string rua;
        private readonly string URL = "https://www.google.com/maps/";
        private readonly string search = "search/";
        private readonly string PLACE = "Computação+Unifenas";

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            busca($"{search}{PLACE}");

            CarregarCampos();
        }

        private void CarregarCampos()
        {
            BeneficiarioRepository beneficiarioRepository = new BeneficiarioRepository();

            bdBeneficiarios.DataSource = null;
            bdBeneficiarios.DataSource = beneficiarioRepository.ObterTodos();

            cbBeneficiarios.DisplayMember = "NomeBeneficiario";
            cbBeneficiarios.ValueMember = "CodigoBeneficiario";

            CarregarDadosBeneficiario();
        }

        private void CarregarDadosBeneficiario()
        {
            if (!(cbBeneficiarios.SelectedItem is Beneficiario beneficiario))
                return;

            txtEndereco.Text = beneficiario.Endereco;

            EntregaRepository entregaRepository = new EntregaRepository();
            Entrega entrega = entregaRepository.ObterPorBeneficiario(beneficiario.CodigoBeneficiario);

            if (entrega == null)
            {
                txtDataEntrega.Clear();
                txtCodCesta.Clear();
                txtCategoria.Clear();
                return;
            }

            CestasBasicasRepository cestaRepository = new CestasBasicasRepository();
            CestasBasicas cesta = cestaRepository.ObterPorId(entrega.CodigoCesta);

            if (cesta == null)
            {
                txtDataEntrega.Clear();
                txtCodCesta.Clear();
                txtCategoria.Clear();
                return;
            }

            CategoriaRepository categoriaRepository = new CategoriaRepository();
            Categoria categoria = categoriaRepository.ObterPorId(cesta.CodigoCategoria);

            txtDataEntrega.Text = entrega.DataEntrega;
            txtCodCesta.Text = cesta.CodigoCesta.ToString();
            txtCategoria.Text = categoria?.Descricao ?? "";
        }

        private void cbBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosBeneficiario();
        }

        // Monta a URL de busca e navega para o endereço
        private async void busca(string add)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate(URL + add);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                busca($"{search}{rua}");
            }
            else
            {
                busca($"{search}{txtEndereco.Text}");
            }
        }

        #region Formularios

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Beneficiario
        private void IncluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBeneficiario frm = new frmBeneficiario();
            frm.ShowDialog();
            CarregarCampos();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBeneficiario frm = new frmConsultaBeneficiario();
            frm.ShowDialog();
        }

        // Categoria
        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frm = new frmConsultaCategoria();
            frm.ShowDialog();
        }

        #endregion
    }
}