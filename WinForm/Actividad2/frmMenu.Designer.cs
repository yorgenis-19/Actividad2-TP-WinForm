﻿namespace Actividad2
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
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnVerDetalleArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Location = new System.Drawing.Point(369, 49);
            this.btnListaArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(256, 46);
            this.btnListaArticulos.TabIndex = 0;
            this.btnListaArticulos.Text = "Listado de artículos";
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Location = new System.Drawing.Point(369, 128);
            this.btnBuscarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(257, 47);
            this.btnBuscarArticulos.TabIndex = 1;
            this.btnBuscarArticulos.Text = "Búscar artículos";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Location = new System.Drawing.Point(369, 213);
            this.btnAgregarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(257, 47);
            this.btnAgregarArticulos.TabIndex = 2;
            this.btnAgregarArticulos.Text = "Agregar artículos";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(369, 464);
            this.btnVerDetalleArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(257, 47);
            this.btnVerDetalleArticulo.TabIndex = 5;
            this.btnVerDetalleArticulo.Text = "Ver detalle de un artículo";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnVerDetalleArticulo.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Location = new System.Drawing.Point(369, 382);
            this.btnModificarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(257, 47);
            this.btnModificarArticulos.TabIndex = 4;
            this.btnModificarArticulos.Text = "Modificar artículos";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Location = new System.Drawing.Point(369, 298);
            this.btnEliminarArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(256, 46);
            this.btnEliminarArticulos.TabIndex = 3;
            this.btnEliminarArticulos.Text = "Eliminar artículos";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            this.btnEliminarArticulos.Click += new System.EventHandler(this.button9_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 636);
            this.Controls.Add(this.btnVerDetalleArticulo);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnBuscarArticulos);
            this.Controls.Add(this.btnListaArticulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnVerDetalleArticulo;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnEliminarArticulos;
    }
}