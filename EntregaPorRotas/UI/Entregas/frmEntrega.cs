using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntregaPorRotas.backend;
using EntregaPorRotas.objetos;
using EntregaPorRotas.repository;

namespace EntregaPorRotas.UI.Entregas
{
    public partial class frmEntrega : Form
    {
        public frmEntrega()
        {
            InitializeComponent();
        }
        private BeneficiarioRepository rep1 = new BeneficiarioRepository();
        private List<Beneficiario> lb = new List<Beneficiario>();
        private List<CestaBasica> lc = new List<CestaBasica>();
        private CestaBasicaRepository rep2 = new CestaBasicaRepository();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cdCesta.Value <= 0 || cdBenefic.Value <= 0) 
            {
                MessageBox.Show("Código incorreto.");
                return;
            }

            lb = rep1.ObterTodos();
            lc = rep2.ObterTodos();

            int count1 = 0;
            int count2 = 0;

            foreach (Beneficiario b in lb)
            {
                if (b.CodigoBeneficiario == cdBenefic.Value)
                    break;
                else
                    ++count1;
            }

            foreach (CestaBasica c in lc)
            {
                if (c.CodigoCesta == cdCesta.Value)
                    break;
                else
                    ++count2;
            }

            if (count1 >= lb.Count || count2 >= lc.Count)
            {
                MessageBox.Show($"Beneficiário ou Cesta inexistente. Certifique-se de que esta digitando o código corretamente.");
                return;
            }

            Entrega ent = new Entrega();
            ent.CodigoCesta = Convert.ToInt32(cdCesta.Value);
            ent.CodigoBeneficiario = Convert.ToInt32(cdBenefic.Value);
            ent.DataEntrega = dateDescricao.Value.ToString("dd/MM/yyyy");

            EntregaRepository.Inserir(ent);
            MessageBox.Show("Entrega cadastrada com sucesso.");

            dateDescricao.Value = DateTime.Today;
            cdCesta.Value = 0;
            cdBenefic.Value = 0;

            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
