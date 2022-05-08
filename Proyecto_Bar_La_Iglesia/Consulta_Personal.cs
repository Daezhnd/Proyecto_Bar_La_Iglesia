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
    public partial class Consulta_Personal : Form
    {

        int id;//--obtiene valor codigo persoonal
        Agregar_Personal AgregarPersonal = new Agregar_Personal();
        public Consulta_Personal()
        {
            InitializeComponent();
        }
        //*******
        private void Consulta_Personal_Load(object sender, EventArgs e) /* muestra registro de mercancia al iniciar */
        {
            using (var context = new ApplicationDbContext())
            {
                var Personal = context.Personal.ToList();
                dgv_Personal.DataSource = Personal;
            }
        }//fin metodo
        //*******
        private void btn_Agregar_Click(object sender, EventArgs e) /* boton ingresar agregar personal */
        {
            AgregarPersonal.Show();
        }//fin metodo
        //*******
        private void dgv_Personal_CellContentClick(object sender, DataGridViewCellEventArgs e) /* boton inresar actualizar personal */
        {
            id = Convert.ToInt32(dgv_Personal.CurrentRow.Cells[0].Value.ToString());
            /*hacer codigo para que envie codigo del personal al form agregar personal ancia*/
            AgregarPersonal.Show();
        }//fin metodo
        //*******

    }//fin class
}//fin consulta personal
