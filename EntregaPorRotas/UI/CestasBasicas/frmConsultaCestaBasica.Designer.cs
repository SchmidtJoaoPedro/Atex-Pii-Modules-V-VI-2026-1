namespace EntregaPorRotas.UI.CestasBasicas
{
    partial class frmConsultaCestaBasica
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
            this.gridCestaBasica = new System.Windows.Forms.DataGridView();
            this.bdCestaBasica = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCestaBasica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCestaBasica)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCestaBasica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 761);
            this.panel1.TabIndex = 0;
            // 
            // gridCestaBasica
            // 
            this.gridCestaBasica.AutoGenerateColumns = false;
            this.gridCestaBasica.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCestaBasica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCestaBasica.DataSource = this.bdCestaBasica;
            this.gridCestaBasica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCestaBasica.Location = new System.Drawing.Point(0, 0);
            this.gridCestaBasica.Name = "gridCestaBasica";
            this.gridCestaBasica.Size = new System.Drawing.Size(1484, 761);
            this.gridCestaBasica.TabIndex = 3;
            // 
            // frmConsultaCestaBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaCestaBasica";
            this.Text = "Consulta Cesta Basica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultaCestaBasica_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCestaBasica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCestaBasica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridCestaBasica;
        private System.Windows.Forms.BindingSource bdCestaBasica;
    }
}