﻿namespace PresentacionForm
{
    partial class FormContactoFamiliar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cbCamaras = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.tbListado = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.grilla3 = new System.Windows.Forms.DataGridView();
            this.gridViewCF2 = new System.Windows.Forms.DataGridView();
            this.gridViewCF = new System.Windows.Forms.DataGridView();
            this.IdGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            this.tbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(22, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(497, 37);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(142, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRuta);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cbCamaras);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(352, 304);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(229, 23);
            this.btnRuta.TabIndex = 13;
            this.btnRuta.Text = "Seleccione una ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(506, 40);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cbCamaras
            // 
            this.cbCamaras.FormattingEnabled = true;
            this.cbCamaras.Location = new System.Drawing.Point(352, 42);
            this.cbCamaras.Name = "cbCamaras";
            this.cbCamaras.Size = new System.Drawing.Size(148, 21);
            this.cbCamaras.TabIndex = 11;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(352, 87);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(229, 199);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "C O N T A C T O S";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(117, 223);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(117, 163);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(117, 102);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(117, 42);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "C O N T A C T O S   F A M I L I A R E S";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tbGeneral);
            this.tabPage.Controls.Add(this.tbListado);
            this.tabPage.Location = new System.Drawing.Point(12, 12);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(655, 554);
            this.tabPage.TabIndex = 12;
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.groupBox1);
            this.tbGeneral.Controls.Add(this.label6);
            this.tbGeneral.Controls.Add(this.groupBox2);
            this.tbGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeneral.Size = new System.Drawing.Size(647, 528);
            this.tbGeneral.TabIndex = 0;
            this.tbGeneral.Text = "Contacto Familiar";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // tbListado
            // 
            this.tbListado.Controls.Add(this.label7);
            this.tbListado.Controls.Add(this.btnActualizar);
            this.tbListado.Controls.Add(this.btnEliminar);
            this.tbListado.Controls.Add(this.txtFiltro);
            this.tbListado.Controls.Add(this.grilla3);
            this.tbListado.Controls.Add(this.gridViewCF2);
            this.tbListado.Controls.Add(this.gridViewCF);
            this.tbListado.Location = new System.Drawing.Point(4, 22);
            this.tbListado.Name = "tbListado";
            this.tbListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbListado.Size = new System.Drawing.Size(647, 528);
            this.tbListado.TabIndex = 1;
            this.tbListado.Text = "Vista General";
            this.tbListado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Filtro";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(436, 479);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(542, 479);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(102, 447);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // grilla3
            // 
            this.grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla3.Location = new System.Drawing.Point(27, 327);
            this.grilla3.Name = "grilla3";
            this.grilla3.Size = new System.Drawing.Size(590, 98);
            this.grilla3.TabIndex = 2;
            this.grilla3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla3_CellContentClick);
            // 
            // gridViewCF2
            // 
            this.gridViewCF2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCF2.Location = new System.Drawing.Point(27, 190);
            this.gridViewCF2.Name = "gridViewCF2";
            this.gridViewCF2.Size = new System.Drawing.Size(590, 102);
            this.gridViewCF2.TabIndex = 1;
            // 
            // gridViewCF
            // 
            this.gridViewCF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrid,
            this.nombresGrid,
            this.telefonoGrid,
            this.fechaGrid});
            this.gridViewCF.Location = new System.Drawing.Point(27, 54);
            this.gridViewCF.Name = "gridViewCF";
            this.gridViewCF.Size = new System.Drawing.Size(590, 108);
            this.gridViewCF.TabIndex = 0;
            // 
            // IdGrid
            // 
            this.IdGrid.HeaderText = "ID";
            this.IdGrid.Name = "IdGrid";
            // 
            // nombresGrid
            // 
            this.nombresGrid.HeaderText = "NOMBRES";
            this.nombresGrid.Name = "nombresGrid";
            // 
            // telefonoGrid
            // 
            this.telefonoGrid.HeaderText = "TELEFONOS";
            this.telefonoGrid.Name = "telefonoGrid";
            // 
            // fechaGrid
            // 
            this.fechaGrid.HeaderText = "FECHA";
            this.fechaGrid.Name = "fechaGrid";
            // 
            // FormContactoFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 578);
            this.Controls.Add(this.tabPage);
            this.Name = "FormContactoFamiliar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormContactoFamiliar_FormClosed);
            this.Load += new System.EventHandler(this.FormContactoFamiliar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            this.tbListado.ResumeLayout(false);
            this.tbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tbGeneral;
        private System.Windows.Forms.TabPage tbListado;
        private System.Windows.Forms.DataGridView gridViewCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGrid;
        private System.Windows.Forms.DataGridView gridViewCF2;
        private System.Windows.Forms.DataGridView grilla3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cbCamaras;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizar;
    }
}

