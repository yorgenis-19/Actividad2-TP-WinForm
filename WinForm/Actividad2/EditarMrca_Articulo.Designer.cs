﻿namespace Actividad2
{
    partial class EditarMrca_Articulo
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
            this.txtMarcEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoNombreMarc = new System.Windows.Forms.TextBox();
            this.btnModMarc = new System.Windows.Forms.Button();
            this.btnModCat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevoNombreCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCatEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarcEdit
            // 
            this.txtMarcEdit.Location = new System.Drawing.Point(200, 31);
            this.txtMarcEdit.Name = "txtMarcEdit";
            this.txtMarcEdit.Size = new System.Drawing.Size(100, 20);
            this.txtMarcEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el ID de la marca a modificar:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ingrese el nuevo nombre: ";
            // 
            // txtNuevoNombreMarc
            // 
            this.txtNuevoNombreMarc.Location = new System.Drawing.Point(147, 67);
            this.txtNuevoNombreMarc.Name = "txtNuevoNombreMarc";
            this.txtNuevoNombreMarc.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombreMarc.TabIndex = 2;
            // 
            // btnModMarc
            // 
            this.btnModMarc.Location = new System.Drawing.Point(15, 109);
            this.btnModMarc.Name = "btnModMarc";
            this.btnModMarc.Size = new System.Drawing.Size(75, 23);
            this.btnModMarc.TabIndex = 4;
            this.btnModMarc.Text = "Modificar";
            this.btnModMarc.UseVisualStyleBackColor = true;
            this.btnModMarc.Click += new System.EventHandler(this.btnModMarc_Click);
            // 
            // btnModCat
            // 
            this.btnModCat.Location = new System.Drawing.Point(373, 109);
            this.btnModCat.Name = "btnModCat";
            this.btnModCat.Size = new System.Drawing.Size(75, 23);
            this.btnModCat.TabIndex = 9;
            this.btnModCat.Text = "Modificar";
            this.btnModCat.UseVisualStyleBackColor = true;
            this.btnModCat.Click += new System.EventHandler(this.btnModCat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ingrese el nuevo nombre: ";
            // 
            // txtNuevoNombreCat
            // 
            this.txtNuevoNombreCat.Location = new System.Drawing.Point(505, 67);
            this.txtNuevoNombreCat.Name = "txtNuevoNombreCat";
            this.txtNuevoNombreCat.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombreCat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese el ID de LA categoria a modificar:\r\n\r\n\r\n\r\n";
            // 
            // txtCatEdit
            // 
            this.txtCatEdit.Location = new System.Drawing.Point(578, 31);
            this.txtCatEdit.Name = "txtCatEdit";
            this.txtCatEdit.Size = new System.Drawing.Size(100, 20);
            this.txtCatEdit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "MARCAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(369, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "CATEGORIAS";
            // 
            // EditarMrca_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevoNombreCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCatEdit);
            this.Controls.Add(this.btnModMarc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuevoNombreMarc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarcEdit);
            this.Name = "EditarMrca_Articulo";
            this.Text = "EditarMrca_Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarcEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoNombreMarc;
        private System.Windows.Forms.Button btnModMarc;
        private System.Windows.Forms.Button btnModCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevoNombreCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCatEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}