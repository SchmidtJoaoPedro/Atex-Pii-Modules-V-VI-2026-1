using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.Entregas
{
    public partial class frmEntrega : Form
    {
        public frmEntrega()
        {
            InitializeComponent();
            CarregarCampos();
        }

        EntregaRepository repository = new EntregaRepository();
        BeneficiarioRepository beneficiarioRepository = new BeneficiarioRepository();
        CestaBasicaRepository cestaRepository = new CestaBasicaRepository();

        private void CarregarCampos()
        {

            bdBeneficiarios.DataSource = null;
            bdBeneficiarios.DataSource = beneficiarioRepository.ObterTodos();

            cbBeneficiarios.DisplayMember = "NomeBeneficiario";
            cbBeneficiarios.ValueMember = "CodigoBeneficiario";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCesta.Text, out int codigoCesta))
            {
                MessageBox.Show("Informe um código de cesta válido.");
                txtCesta.Focus();
                return;
            }

            if (cbBeneficiarios.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um beneficiário.");
                return;
            }

            if (cestaRepository.ObterPorId(codigoCesta) == null)
            {
                MessageBox.Show("Cesta não encontrada.");
                txtCesta.Focus();
                return;
            }

            Entrega entrega = new Entrega
            {
                CodigoCesta = codigoCesta,
                CodigoBeneficiario = Convert.ToInt32(cbBeneficiarios.SelectedValue),
                DataEntrega = dateDescricao.Value.ToString("dd/MM/yyyy")
            };

            try
            {
                repository.Inserir(entrega);

                MessageBox.Show("Entrega cadastrada com sucesso.");

                dateDescricao.Value = DateTime.Today;
                txtCesta.Clear();
                cbBeneficiarios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar entrega.\n{ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
