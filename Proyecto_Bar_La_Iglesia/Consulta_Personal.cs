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
    public partial class Consulta_Personal : Form
    {
        public Consulta_Personal()
        {
            InitializeComponent();
        }
        //*******

        private void btn_Agregar_Click(object sender, EventArgs e) /* boton ingresar agregar personal */
        {
            Agregar_Personal AgregarPersonal = new Agregar_Personal();
            AgregarPersonal.Show();
        }//fin metodo
        //*******

    }//fin class
}//fin proyecto
