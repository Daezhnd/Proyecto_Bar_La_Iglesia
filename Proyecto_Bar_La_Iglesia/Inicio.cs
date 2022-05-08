using Proyecto_Bar_La_Iglesia.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Bar_La_Iglesia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //*******

        private void mn_Consulta_Personal_Click(object sender, EventArgs e) /* boton ingresar cosulta personal */
        {
            Consulta_Personal ConsultaPersonal = new Consulta_Personal();
            ConsultaPersonal.Show();
        }//fin metodo
        //*******

        private void aregarPersonalToolStripMenuItem_Click(object sender, EventArgs e) /* boton ingresar agregar personal */
        {
            Agregar_Personal AgregarPersonal = new Agregar_Personal();
            AgregarPersonal.Show();
        }//fin metodo
        //*******

        private void consultaMercanciaToolStripMenuItem_Click(object sender, EventArgs e) /* boton ingresar consulta mercancia */
        {
            Consulta_Mercancia ConsutaMercancia = new Consulta_Mercancia();
            ConsutaMercancia.Show();
        }//fin metodo
        //*******

        private void agregarMercanciaToolStripMenuItem_Click(object sender, EventArgs e) /* boton ingresar agregar mercancia */
        {
            Agregar_Mercancia AgregarMercancia = new Agregar_Mercancia();
            AgregarMercancia.Show();
        }//fin metodo
        //*******

        private void cajeroToolStripMenuItem1_Click(object sender, EventArgs e) /* boton ingresar cajero */
        {
            Cajero Cajero = new Cajero();
            Cajero.Show();
        }//fin metodo
        //*******
        private void bt_Inicio_Click(object sender, EventArgs e) /* boton para ingresar con cuenta de usuario */
        {
            using (var context = new ApplicationDbContext())
            {
                var usuario = context.Personal.First(x => x.Usuario == txt_Usuario.Text);
                if (usuario != null)
                {
                    if (usuario.Contraseña == txt_Contraseña.Text)//--si la contraseña es correcta
                    {
                        mn_Menu.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO Y/O CONTRASEÑA ES INCORRECTA", "AVISO", MessageBoxButtons.OK);
                    }
                }
            }
        }
        //*******

    }//fin class
}//fin proyecto
