namespace EntregaPorRotas.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDataEntrega = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoria = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbBeneficiarios = new MetroFramework.Controls.MetroComboBox();
            this.bdBeneficiarios = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadasrtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cestaBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCesta = new MetroFramework.Controls.MetroComboBox();
            this.bdCesta = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBeneficiarios)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCesta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1567, 745);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webView21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 745);
            this.panel3.TabIndex = 3;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1279, 745);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCesta);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.txtDataEntrega);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.txtCategoria);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.cbBeneficiarios);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 745);
            this.panel2.TabIndex = 2;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(12, 112);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Codigo da Cesta:";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(12, 296);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.ReadOnly = true;
            this.txtDataEntrega.Size = new System.Drawing.Size(270, 29);
            this.txtDataEntrega.TabIndex = 17;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(12, 274);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Data Entrega:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(12, 188);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(270, 29);
            this.txtCategoria.TabIndex = 15;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(12, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Categoria:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 242);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(270, 29);
            this.txtEndereco.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(12, 220);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Endereço:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(12, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Beneficiario:";
            // 
            // cbBeneficiarios
            // 
            this.cbBeneficiarios.DataSource = this.bdBeneficiarios;
            this.cbBeneficiarios.FormattingEnabled = true;
            this.cbBeneficiarios.ItemHeight = 23;
            this.cbBeneficiarios.Location = new System.Drawing.Point(12, 80);
            this.cbBeneficiarios.Name = "cbBeneficiarios";
            this.cbBeneficiarios.Size = new System.Drawing.Size(270, 29);
            this.cbBeneficiarios.TabIndex = 9;
            this.cbBeneficiarios.SelectedIndexChanged += new System.EventHandler(this.cbBeneficiarios_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroLabel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 55);
            this.panel5.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(12, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(195, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Selecione o beneficiario e cesta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(0, 707);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(288, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadasrtroToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.cestaBasicasToolStripMenuItem,
            this.entregaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1567, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadasrtroToolStripMenuItem
            // 
            this.cadasrtroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IncluirToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.cadasrtroToolStripMenuItem.Name = "cadasrtroToolStripMenuItem";
            this.cadasrtroToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.cadasrtroToolStripMenuItem.Text = "Beneficiario";
            // 
            // IncluirToolStripMenuItem
            // 
            this.IncluirToolStripMenuItem.Name = "IncluirToolStripMenuItem";
            this.IncluirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.IncluirToolStripMenuItem.Text = "Incluir";
            this.IncluirToolStripMenuItem.Click += new System.EventHandler(this.IncluirToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem1,
            this.consultaToolStripMenuItem1});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // incluirToolStripMenuItem1
            // 
            this.incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            this.incluirToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.incluirToolStripMenuItem1.Text = "Incluir";
            this.incluirToolStripMenuItem1.Click += new System.EventHandler(this.incluirToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // cestaBasicasToolStripMenuItem
            // 
            this.cestaBasicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.consultaToolStripMenuItem2});
            this.cestaBasicasToolStripMenuItem.Name = "cestaBasicasToolStripMenuItem";
            this.cestaBasicasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cestaBasicasToolStripMenuItem.Text = "Cesta basicas";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem2
            // 
            this.consultaToolStripMenuItem2.Name = "consultaToolStripMenuItem2";
            this.consultaToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem2.Text = "Consulta";
            this.consultaToolStripMenuItem2.Click += new System.EventHandler(this.consultaToolStripMenuItem2_Click);
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.consultaToolStripMenuItem3});
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.entregaToolStripMenuItem.Text = "Entrega";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem3
            // 
            this.consultaToolStripMenuItem3.Name = "consultaToolStripMenuItem3";
            this.consultaToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem3.Text = "Consulta";
            this.consultaToolStripMenuItem3.Click += new System.EventHandler(this.consultaToolStripMenuItem3_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cbCesta
            // 
            this.cbCesta.DataSource = this.bdCesta;
            this.cbCesta.FormattingEnabled = true;
            this.cbCesta.ItemHeight = 23;
            this.cbCesta.Location = new System.Drawing.Point(12, 134);
            this.cbCesta.Name = "cbCesta";
            this.cbCesta.Size = new System.Drawing.Size(270, 29);
            this.cbCesta.TabIndex = 20;
            this.cbCesta.SelectedIndexChanged += new System.EventHandler(this.cbCesta_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBeneficiarios)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdCesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadasrtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cestaBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbBeneficiarios;
        private System.Windows.Forms.BindingSource bdBeneficiarios;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtDataEntrega;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCategoria;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem3;
        private MetroFramework.Controls.MetroComboBox cbCesta;
        private System.Windows.Forms.BindingSource bdCesta;
    }
}