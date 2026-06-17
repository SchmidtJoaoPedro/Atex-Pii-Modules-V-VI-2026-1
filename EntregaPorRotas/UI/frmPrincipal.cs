using EntregaPorRotas.UI.Beneficiarios;
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

        private string rua;
        private string URL = "https://www.google.com/maps/";
        private string search = "search/";
        private string PLACE = "Universidade+Prof.Edson+Antônio+Velano+-+Unifenas+-+Câmpus+Alfenas";

        private async void busca(string add)
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.CoreWebView2.Navigate(
                URL + add
            );
        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            busca($"{search}{PLACE}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rua = nomeRua.Text;
            busca($"{search}{rua}");
        }

        #region Forms

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IncluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncluirBeneficiario frm = new frmIncluirBeneficiario();
            frm.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoverBeneficiario frm = new frmRemoverBeneficiario(); 
            frm.ShowDialog();
        }

        #endregion
    }
}