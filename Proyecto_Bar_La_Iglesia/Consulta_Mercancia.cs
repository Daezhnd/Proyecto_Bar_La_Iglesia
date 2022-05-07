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
    public partial class Consulta_Mercancia : Form
    {
        Agregar_Mercancia AgregarMercancia = new Agregar_Mercancia();
        Agregar_Existencia_Mercancia AgregarExistencia = new Agregar_Existencia_Mercancia();
        public Consulta_Mercancia()
        {
            InitializeComponent();
        }
        //*******
        private void Consulta_Mercancia_Load(object sender, EventArgs e) /* muestra registro de clientes al iniciar */
        {
            using (var context = new ApplicationDbContext())
            {
                var Personal = context.Personal.ToList();
                dgv_Mercancia.DataSource = Personal;
            }
        }//fin metodo
        //*******
        private void btn_Agregar_Mercancia_Click(object sender, EventArgs e) /* boton ingresar agregar mercancia */
        {        
            AgregarMercancia.Show();
        }//fin metodo
        //*******
        private void btn_Agregar_Existencia_Click(object sender, EventArgs e) /* boton ingresar agregar existencia mercancia */
        {         
            AgregarExistencia.Show();
        }//fin metodo
        //*******
        private void btn_Limpiar_Click(object sender, EventArgs e) /*  */
        {
            txt_Codigo.Clear();
            txt_Nombre.Clear();
        }//fin metodo
        //*******
        private void dgv_Mercancia_CellContentClick(object sender, DataGridViewCellEventArgs e) /* boton inresar actualizar mercancia */
        {
            /*hacer codigo para que envie codigo del producto al form agregar mercancia*/
            AgregarMercancia.Show();
        }//fin metodo
        //*******

    }//fin class
}//fin consulta mercancia
