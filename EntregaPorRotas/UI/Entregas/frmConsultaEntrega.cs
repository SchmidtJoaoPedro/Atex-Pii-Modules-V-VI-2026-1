using EntregaPorRotas.backend;
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

namespace EntregaPorRotas.UI.Entregas
{
    public partial class frmConsultaEntrega : Form
    {
        public frmConsultaEntrega()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrega_Load(object sender, EventArgs e)
        {
            EntregaRepository repository = new EntregaRepository();

            gridEntrega.AutoGenerateColumns = true;
            bdEntrega.DataSource = repository.ObterTodos();
        }
    }
}
