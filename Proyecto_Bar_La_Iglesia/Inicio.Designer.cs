
namespace Proyecto_Bar_La_Iglesia
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Inicio = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mn_Menu = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Consulta_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.aregarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMercanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mn_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(87, 3);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Nombre de Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(249, 23);
            this.txt_Usuario.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Inicio);
            this.panel1.Controls.Add(this.txt_Contraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Location = new System.Drawing.Point(233, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 94);
            this.panel1.TabIndex = 3;
            // 
            // bt_Inicio
            // 
            this.bt_Inicio.Location = new System.Drawing.Point(276, 61);
            this.bt_Inicio.Name = "bt_Inicio";
            this.bt_Inicio.Size = new System.Drawing.Size(60, 25);
            this.bt_Inicio.TabIndex = 4;
            this.bt_Inicio.Text = "Inicio";
            this.bt_Inicio.UseVisualStyleBackColor = true;
            this.bt_Inicio.Click += new System.EventHandler(this.bt_Inicio_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(87, 32);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PlaceholderText = "Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(252, 23);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mn_Menu);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 28);
            this.panel2.TabIndex = 4;
            // 
            // mn_Menu
            // 
            this.mn_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.mercanciaToolStripMenuItem,
            this.cajeroToolStripMenuItem});
            this.mn_Menu.Location = new System.Drawing.Point(0, 0);
            this.mn_Menu.Name = "mn_Menu";
            this.mn_Menu.Size = new System.Drawing.Size(776, 24);
            this.mn_Menu.TabIndex = 0;
            this.mn_Menu.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Consulta_Personal,
            this.aregarPersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // mn_Consulta_Personal
            // 
            this.mn_Consulta_Personal.Name = "mn_Consulta_Personal";
            this.mn_Consulta_Personal.Size = new System.Drawing.Size(169, 22);
            this.mn_Consulta_Personal.Text = "Consulta Personal";
            this.mn_Consulta_Personal.Click += new System.EventHandler(this.mn_Consulta_Personal_Click);
            // 
            // aregarPersonalToolStripMenuItem
            // 
            this.aregarPersonalToolStripMenuItem.Name = "aregarPersonalToolStripMenuItem";
            this.aregarPersonalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aregarPersonalToolStripMenuItem.Text = "Aregar Personal";
            this.aregarPersonalToolStripMenuItem.Click += new System.EventHandler(this.aregarPersonalToolStripMenuItem_Click);
            // 
            // mercanciaToolStripMenuItem
            // 
            this.mercanciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMercanciaToolStripMenuItem,
            this.agregarMercanciaToolStripMenuItem});
            this.mercanciaToolStripMenuItem.Name = "mercanciaToolStripMenuItem";
            this.mercanciaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.mercanciaToolStripMenuItem.Text = "Mercancia";
            // 
            // consultaMercanciaToolStripMenuItem
            // 
            this.consultaMercanciaToolStripMenuItem.Name = "consultaMercanciaToolStripMenuItem";
            this.consultaMercanciaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.consultaMercanciaToolStripMenuItem.Text = "Consulta Mercancia";
            this.consultaMercanciaToolStripMenuItem.Click += new System.EventHandler(this.consultaMercanciaToolStripMenuItem_Click);
            // 
            // agregarMercanciaToolStripMenuItem
            // 
            this.agregarMercanciaToolStripMenuItem.Name = "agregarMercanciaToolStripMenuItem";
            this.agregarMercanciaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarMercanciaToolStripMenuItem.Text = "Agregar Mercancia";
            this.agregarMercanciaToolStripMenuItem.Click += new System.EventHandler(this.agregarMercanciaToolStripMenuItem_Click);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajeroToolStripMenuItem1});
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cajeroToolStripMenuItem.Text = "Cajero";
            // 
            // cajeroToolStripMenuItem1
            // 
            this.cajeroToolStripMenuItem1.Name = "cajeroToolStripMenuItem1";
            this.cajeroToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.cajeroToolStripMenuItem1.Text = "Cajero";
            this.cajeroToolStripMenuItem1.Click += new System.EventHandler(this.cajeroToolStripMenuItem1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mn_Menu;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mn_Menu.ResumeLayout(false);
            this.mn_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button bt_Inicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mn_Menu;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_Consulta_Personal;
        private System.Windows.Forms.ToolStripMenuItem aregarPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMercanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMercanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem1;
    }
}

