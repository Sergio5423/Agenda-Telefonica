namespace PresentacionForm
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFamiliar = new System.Windows.Forms.Button();
            this.btnEmpresarial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C O N T A C T O S";
            // 
            // btnFamiliar
            // 
            this.btnFamiliar.Location = new System.Drawing.Point(64, 85);
            this.btnFamiliar.Name = "btnFamiliar";
            this.btnFamiliar.Size = new System.Drawing.Size(138, 23);
            this.btnFamiliar.TabIndex = 1;
            this.btnFamiliar.Text = "CONTACTO FAMILIAR";
            this.btnFamiliar.UseVisualStyleBackColor = true;
            this.btnFamiliar.Click += new System.EventHandler(this.btnFamiliar_Click);
            // 
            // btnEmpresarial
            // 
            this.btnEmpresarial.Location = new System.Drawing.Point(55, 146);
            this.btnEmpresarial.Name = "btnEmpresarial";
            this.btnEmpresarial.Size = new System.Drawing.Size(156, 23);
            this.btnEmpresarial.TabIndex = 2;
            this.btnEmpresarial.Text = "CONTACTO EMPRESARIAL";
            this.btnEmpresarial.UseVisualStyleBackColor = true;
            this.btnEmpresarial.Click += new System.EventHandler(this.btnEmpresarial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(93, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 294);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpresarial);
            this.Controls.Add(this.btnFamiliar);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFamiliar;
        private System.Windows.Forms.Button btnEmpresarial;
        private System.Windows.Forms.Button btnSalir;
    }
}