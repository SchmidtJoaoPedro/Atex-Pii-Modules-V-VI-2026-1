using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.CestasBasicas
{
    public partial class frmCestaBasica : Form
    {
        public frmCestaBasica()
        {
            InitializeComponent();
        }

        private void cbBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarCategorias()
        {
            CategoriaRepository repository = new CategoriaRepository();

            cbCategoria.DataSource = repository.ObterTodos();
            cbCategoria.DisplayMember = "Descricao";
            cbCategoria.ValueMember = "CodigoCategoria";
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCestaBasica_Load_1(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
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
    }
}
