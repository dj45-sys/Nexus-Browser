namespace Nexus_Browser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnatras = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnrecargar = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnalto = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(10, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(23, 23);
            this.btnatras.TabIndex = 1;
            this.btnatras.Text = "<";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(39, 12);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrecargar
            // 
            this.btnrecargar.Location = new System.Drawing.Point(10, 415);
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.Size = new System.Drawing.Size(23, 23);
            this.btnrecargar.TabIndex = 3;
            this.btnrecargar.Text = "R";
            this.btnrecargar.UseVisualStyleBackColor = true;
            this.btnrecargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(747, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 23);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "H";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnalto
            // 
            this.btnalto.Location = new System.Drawing.Point(39, 415);
            this.btnalto.Name = "btnalto";
            this.btnalto.Size = new System.Drawing.Size(23, 23);
            this.btnalto.TabIndex = 5;
            this.btnalto.Text = "S";
            this.btnalto.UseVisualStyleBackColor = true;
            this.btnalto.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(74, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(236, 20);
            this.txtUrl.TabIndex = 6;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(321, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(25, 20);
            this.btnIr.TabIndex = 7;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnalto);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnrecargar);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnrecargar;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnalto;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnIr;
    }
}

