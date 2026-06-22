using EntregaPorRotas.repository;
using System;
using System.Windows.Forms;

namespace EntregaPorRotas.UI.Categorias
{
    public partial class frmConsultaCategoria : Form
    {
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaRepository repository = new CategoriaRepository();

            gridCategorias.AutoGenerateColumns = true;
            bdCategorias.DataSource = repository.ObterTodos();
        }
    }
}
