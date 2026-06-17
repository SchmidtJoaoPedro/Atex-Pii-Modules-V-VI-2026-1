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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nomeRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 655);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webView21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(208, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 655);
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
            this.webView21.Size = new System.Drawing.Size(978, 655);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nomeRua);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 655);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeRua
            // 
            this.nomeRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeRua.Location = new System.Drawing.Point(7, 94);
            this.nomeRua.Name = "nomeRua";
            this.nomeRua.Size = new System.Drawing.Size(195, 20);
            this.nomeRua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Rua:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 655);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeRua;
        private System.Windows.Forms.Button button1;
    }
}