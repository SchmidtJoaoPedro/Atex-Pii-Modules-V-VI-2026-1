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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbBeneficiarios = new MetroFramework.Controls.MetroComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadasrtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cestaBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdBeneficiarios = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBeneficiarios)).BeginInit();
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
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.metroComboBox3);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.cbBeneficiarios);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 745);
            this.panel2.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(13, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Endereço";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(83, 135);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(205, 29);
            this.metroComboBox3.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(0, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Beneficiario";
            // 
            // cbBeneficiarios
            // 
            this.cbBeneficiarios.DataSource = this.bdBeneficiarios;
            this.cbBeneficiarios.FormattingEnabled = true;
            this.cbBeneficiarios.ItemHeight = 23;
            this.cbBeneficiarios.Location = new System.Drawing.Point(83, 61);
            this.cbBeneficiarios.Name = "cbBeneficiarios";
            this.cbBeneficiarios.Size = new System.Drawing.Size(205, 29);
            this.cbBeneficiarios.TabIndex = 9;
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
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Prencha os campos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
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
            this.deletarToolStripMenuItem});
            this.cadasrtroToolStripMenuItem.Name = "cadasrtroToolStripMenuItem";
            this.cadasrtroToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cadasrtroToolStripMenuItem.Text = "Beneficiarios";
            // 
            // IncluirToolStripMenuItem
            // 
            this.IncluirToolStripMenuItem.Name = "IncluirToolStripMenuItem";
            this.IncluirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.IncluirToolStripMenuItem.Text = "Incluir";
            this.IncluirToolStripMenuItem.Click += new System.EventHandler(this.IncluirToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deletarToolStripMenuItem.Text = "Remover";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // cestaBasicasToolStripMenuItem
            // 
            this.cestaBasicasToolStripMenuItem.Name = "cestaBasicasToolStripMenuItem";
            this.cestaBasicasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cestaBasicasToolStripMenuItem.Text = "Cesta basicas";
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.entregaToolStripMenuItem.Text = "Entrega";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBeneficiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadasrtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cestaBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbBeneficiarios;
        private System.Windows.Forms.BindingSource bdBeneficiarios;
    }
}