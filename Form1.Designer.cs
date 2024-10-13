using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeLivros
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnMostrarLivro;
        private ListBox listBoxLivros;
        private System.Windows.Forms.DataGridView dataGridLivros;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnMostrarLivro = new System.Windows.Forms.Button();
            this.dataGridLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarLivro
            // 
            this.btnMostrarLivro.Location = new System.Drawing.Point(177, 70);
            this.btnMostrarLivro.Name = "btnMostrarLivro";
            this.btnMostrarLivro.Size = new System.Drawing.Size(150, 30);
            this.btnMostrarLivro.TabIndex = 1;
            this.btnMostrarLivro.Text = "Mostrar Livros";
            this.btnMostrarLivro.UseVisualStyleBackColor = true;
            this.btnMostrarLivro.Click += new System.EventHandler(this.btnMostrarLivro_Click);
            // 
            // dataGridLivros
            // 
            this.dataGridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivros.Location = new System.Drawing.Point(25, 117);
            this.dataGridLivros.Name = "dataGridLivros";
            this.dataGridLivros.Size = new System.Drawing.Size(450, 150);
            this.dataGridLivros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renan Santos de Oliveira - 2222200490";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridLivros);
            this.Controls.Add(this.btnMostrarLivro);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}