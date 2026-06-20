using EntregaPorRotas.repository;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.Beneficiarios
{
    public partial class frmRemoverBeneficiario : Form
    {
        public frmRemoverBeneficiario()
        {
            InitializeComponent();
        }

        private void frmRemoverBeneficiario_Load(object sender, System.EventArgs e)
        {
            BeneficiarioRepository repository = new BeneficiarioRepository();

            gridBeneficiarios.AutoGenerateColumns = true;
            bdBeneficiarios.DataSource = repository.ObterTodos();
        }
    }
}
