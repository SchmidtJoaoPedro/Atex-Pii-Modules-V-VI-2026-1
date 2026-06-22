using EntregaPorRotas.backend;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.CestasBasicas
{
    public partial class frmConsultaCestaBasica : Form
    {
        public frmConsultaCestaBasica()
        {
            InitializeComponent();
        }

        private void frmConsultaCestaBasica_Load(object sender, EventArgs e)
        {
            CestaBasicaRepository repository = new CestaBasicaRepository();

            gridCestaBasica.AutoGenerateColumns = true;
            bdCestaBasica.DataSource = repository.ObterTodos();
        }
    }
}
