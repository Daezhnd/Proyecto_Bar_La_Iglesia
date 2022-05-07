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
    public partial class Consulta_Mercancia : Form
    {
        public Consulta_Mercancia()
        {
            InitializeComponent();
        }
        //*******

        private void btn_Agregar_Mercancia_Click(object sender, EventArgs e) /* boton ingresar agregar mercancia */
        {
            Agregar_Mercancia AgregarMercancia = new Agregar_Mercancia();
            AgregarMercancia.Show();
        }//fin metodo
        //*******
        private void btn_Agregar_Existencia_Click(object sender, EventArgs e) /* boton ingresar agregar existencia mercancia */
        {
            Agregar_Existencia_Mercancia AgregarExistencia = new Agregar_Existencia_Mercancia();
            AgregarExistencia.Show();
        }//fin metodo
        //*******

    }//fin class
}//fin proyecto
