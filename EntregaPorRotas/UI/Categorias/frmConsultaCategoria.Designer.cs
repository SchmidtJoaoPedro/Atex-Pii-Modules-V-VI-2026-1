namespace EntregaPorRotas.UI.Categorias
{
    partial class frmConsultaCategoria
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
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.bdCategorias = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 761);
            this.panel1.TabIndex = 0;
            // 
            // gridCategorias
            // 
            this.gridCategorias.AutoGenerateColumns = false;
            this.gridCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.DataSource = this.bdCategorias;
            this.gridCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategorias.Location = new System.Drawing.Point(0, 0);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(1484, 761);
            this.gridCategorias.TabIndex = 2;
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaCategoria";
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.frmConsultaCategoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.BindingSource bdCategorias;
    }
}