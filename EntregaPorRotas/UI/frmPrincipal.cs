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

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.CoreWebView2.Navigate(
                "https://www.google.com/maps/search/Rua+da+Consolacao+Sao+Paulo"
            );
        }
    }
}