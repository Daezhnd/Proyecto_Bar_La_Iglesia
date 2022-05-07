
namespace Proyecto_Bar_La_Iglesia
{
    partial class Consulta_Mercancia
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Agregar_Mercancia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Mercancia = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Agregar_Existencia = new System.Windows.Forms.Button();
            this.btn_Estado = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercancia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Estado);
            this.panel3.Controls.Add(this.btn_Agregar_Existencia);
            this.panel3.Controls.Add(this.btn_Agregar_Mercancia);
            this.panel3.Location = new System.Drawing.Point(10, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 170);
            this.panel3.TabIndex = 5;
            // 
            // btn_Agregar_Mercancia
            // 
            this.btn_Agregar_Mercancia.Location = new System.Drawing.Point(3, 3);
            this.btn_Agregar_Mercancia.Name = "btn_Agregar_Mercancia";
            this.btn_Agregar_Mercancia.Size = new System.Drawing.Size(260, 50);
            this.btn_Agregar_Mercancia.TabIndex = 0;
            this.btn_Agregar_Mercancia.Text = "Agregar Mercancia";
            this.btn_Agregar_Mercancia.UseVisualStyleBackColor = true;
            this.btn_Agregar_Mercancia.Click += new System.EventHandler(this.btn_Agregar_Mercancia_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Mercancia);
            this.panel2.Location = new System.Drawing.Point(282, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 426);
            this.panel2.TabIndex = 4;
            // 
            // dgv_Mercancia
            // 
            this.dgv_Mercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mercancia.Location = new System.Drawing.Point(3, 3);
            this.dgv_Mercancia.Name = "dgv_Mercancia";
            this.dgv_Mercancia.RowTemplate.Height = 25;
            this.dgv_Mercancia.Size = new System.Drawing.Size(501, 420);
            this.dgv_Mercancia.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 60);
            this.panel1.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(76, 32);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingresar Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(187, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(76, 3);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.PlaceholderText = "Ingresar Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(187, 23);
            this.txt_Codigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s):";
            // 
            // btn_Agregar_Existencia
            // 
            this.btn_Agregar_Existencia.Location = new System.Drawing.Point(3, 59);
            this.btn_Agregar_Existencia.Name = "btn_Agregar_Existencia";
            this.btn_Agregar_Existencia.Size = new System.Drawing.Size(260, 50);
            this.btn_Agregar_Existencia.TabIndex = 1;
            this.btn_Agregar_Existencia.Text = "Agregar Existencia";
            this.btn_Agregar_Existencia.UseVisualStyleBackColor = true;
            this.btn_Agregar_Existencia.Click += new System.EventHandler(this.btn_Agregar_Existencia_Click);
            // 
            // btn_Estado
            // 
            this.btn_Estado.Location = new System.Drawing.Point(3, 115);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(260, 50);
            this.btn_Estado.TabIndex = 2;
            this.btn_Estado.Text = "Activo";
            this.btn_Estado.UseVisualStyleBackColor = true;
            // 
            // Consulta_Mercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Consulta_Mercancia";
            this.Text = "Consulta Mercancia";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercancia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Agregar_Mercancia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Mercancia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Estado;
        private System.Windows.Forms.Button btn_Agregar_Existencia;
    }
}