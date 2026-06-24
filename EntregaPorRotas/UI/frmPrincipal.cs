using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;
using EntregaPorRotas.UI.Beneficiarios;
using EntregaPorRotas.UI.Categorias;
using EntregaPorRotas.UI.CestasBasicas;
using EntregaPorRotas.UI.Entregas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntregaPorRotas.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private EntregaRepository entregaRepository = new EntregaRepository();
        private CestaBasicaRepository cestaRepository = new CestaBasicaRepository();
        private CategoriaRepository categoriaRepository = new CategoriaRepository();
        private BeneficiarioRepository beneficiarioRepository = new BeneficiarioRepository();

        // helpers
        private readonly string rua;
        private readonly string URL = "https://www.google.com/maps/";
        private string rotaFinal;

        // URL keywords
        private readonly string search = "search/";
        private readonly string dir = "dir/";
       
        // endereços comuns
        private readonly string PLACE = "Computação+Unifenas";
        private readonly string partida = "Av. São José, 2080, Alfenas";

        // lista de endereços para traçar rotas
        private List<string> enderecos = new List<string>();

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            BuscarEndereco($"{search}{PLACE}");
            CarregarCampos();
        }

        private void CarregarCampos()
        {
            bdBeneficiarios.DataSource = null;
            bdBeneficiarios.DataSource = beneficiarioRepository.ObterTodos();

            cbBeneficiarios.DisplayMember = "NomeBeneficiario";
            cbBeneficiarios.ValueMember = "CodigoBeneficiario";

            CarregarCestas();
            CarregarDadosCesta();
        }

        private void CarregarDadosBeneficiario()
        {
            if (!(cbBeneficiarios.SelectedItem is Beneficiario beneficiario))
            {
                return;
            }

            txtEndereco.Text = beneficiario.Endereco;
        }

        private void CarregarCestas()
        {
            if (!(cbBeneficiarios.SelectedItem is Beneficiario beneficiario))
            {
                return;
            }

            bdCesta.DataSource = entregaRepository.ObterTodosPorBeneficiario(beneficiario.CodigoBeneficiario);

            cbCesta.DisplayMember = "CodigoCesta";
            cbCesta.ValueMember = "CodigoCesta";
        }

        private void CarregarDadosCesta()
        {
            if (!(cbCesta.SelectedItem is Entrega entrega))
            {
                return;
            }

            CestaBasica cesta = cestaRepository.ObterPorId(entrega.CodigoCesta);

            if (cesta == null)
            {
                txtDataEntrega.Clear();
                txtCategoria.Clear();
                return;
            }

            Categoria categoria = categoriaRepository.ObterPorId(cesta.CodigoCategoria);

            txtDataEntrega.Text = Convert.ToDateTime(entrega.DataEntrega).ToString("dd/MM/yyyy");
            txtCategoria.Text = categoria?.Descricao ?? "";
        }

        private void cbCesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosCesta();
        }

        private void cbBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosBeneficiario();
            CarregarCestas();

            if (cbCesta.Items.Count > 0)
            {
                cbCesta.SelectedIndex = 0;
                CarregarDadosCesta();
            }
            else
            {
                txtDataEntrega.Clear();
                txtCategoria.Clear();
            }
        }

        // Monta a URL de busca e navega para o endereço
        private async void BuscarEndereco(string endereco)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate(URL + endereco);
        }

        private async void TracarRota(string endereco)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate(URL + dir + partida + "/" + endereco);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                BuscarEndereco($"{search}{rua}");
            }
            else
            {
                BuscarEndereco($"{search}{txtEndereco.Text}");
            }
        }

        private void rotasBtn_Click(object sender, EventArgs e)
        {
            entregaRepository.ObterEnderecoDeHoje(enderecos);

            int Counter = 0;

            foreach (var itens in enderecos)
            {
                if (rotaFinal != null && rotaFinal.Contains(itens))
                {
                    continue;
                }

                if (Counter != enderecos.Count)
                {
                    rotaFinal += itens + "/";
                    Counter++;
                }
                else
                {
                    rotaFinal += itens;
                }
            }

            if (!string.IsNullOrEmpty(rotaFinal))
            {
                TracarRota(rotaFinal);
            }
            else
            {
                MessageBox.Show("Não há endereços cadastrados na data de hoje para traçar a rota.","Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnPontoOrigem_Click(object sender, EventArgs e)
        {
            enderecos.Clear();
            rotaFinal = null;
            BuscarEndereco($"{search}{partida}");
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

        // Cestas Básicas
        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCestaBasica frm = new frmCestaBasica();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaCestaBasica frm = new frmConsultaCestaBasica();
            frm.ShowDialog();
        }

        // Entrega
        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEntrega frm = new frmEntrega();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultaEntrega frm= new frmConsultaEntrega();
            frm.ShowDialog();
        }

        #endregion
    }
}