using EntregaPorRotas.backend;
using EntregaPorRotas.repository;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI
{
    public partial class frmBeneficiario : Form
    {
        public frmBeneficiario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeBeneficiario.Text))
            {
                MessageBox.Show("Informe o nome do beneficiário.");
                txtNomeBeneficiario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Informe o endereço.");
                txtEndereco.Focus();
                return;
            }

            var beneficiario = new Beneficiario
            {
                NomeBeneficiario = txtNomeBeneficiario.Text.Trim(),
                Endereco = txtEndereco.Text.Trim()
            };

            var repository = new BeneficiarioRepository();

            repository.Inserir(beneficiario);

            MessageBox.Show("Beneficiário cadastrado com sucesso.");

            txtNomeBeneficiario.Clear();
            txtEndereco.Clear();

            txtNomeBeneficiario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
