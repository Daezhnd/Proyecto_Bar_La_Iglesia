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
    public partial class Agregar_Personal : Form
    {
        int id;//--obtiene valor codigo personal
        public Agregar_Personal()
        {
            InitializeComponent();
        }
        //*******
        private void btn_Agregar_Click(object sender, EventArgs e) /* boton agregar personal */
        {
            using (var context = new ApplicationDbContext())
            {
                if (txt_Codigo.Text != " " && txt_Nombre.Text != " " && txt_Apellido.Text != " " && txt_Edad.Text != " " && txt_Telefono.Text != " " && txt_Direccion.Text != " " && txt_Usuario.Text != " " && txt_Contraseña.Text != " ")//--if para que no queden casillas sin llenar
                {
                    var agregar = new Personal();
                    agregar.Nombre = txt_Nombre.Text.ToUpper();
                    agregar.Apellido = txt_Apellido.Text.ToUpper();
                    agregar.Sexo = rb_Masculino.Checked ? "Masculino" : "Femenino";
                    agregar.Edad = Convert.ToInt32(txt_Edad.Text);
                    agregar.FechaNacimiento = Convert.ToString(dtp_FechaNacimiento.Value).ToUpper();
                    agregar.Telefono = Convert.ToInt32(txt_Telefono.Text);
                    agregar.Direccion = txt_Direccion.Text.ToUpper();
                    agregar.Nivel = Convert.ToString(cb_Nivel.SelectedItem).ToUpper();
                    agregar.Usuario = txt_Usuario.Text;
                    agregar.Contraseña = txt_Contraseña.Text;
                    context.Personal.Add(agregar);
                    MessageBox.Show("SE AGREGO EL NUEVO PERSONAL", "AVISO", MessageBoxButtons.OK);
                }
                else//--muestra mensaje si hay casillas sin llenar
                {
                    MessageBox.Show("TODAS LAS CASILLAS DEBEN ESTAR LLENAS", "AVISO", MessageBoxButtons.OK);
                }
            }
        }//fin metodo
         //*******
        private void btn_Actualizar_Click(object sender, EventArgs e) /* boton actualizar personal */
        {
            using (var context = new ApplicationDbContext())
            {
                if (txt_Codigo.Text != " " && txt_Nombre.Text != " " && txt_Apellido.Text != " " && txt_Edad.Text != " " && txt_Telefono.Text != " " && txt_Direccion.Text != " " && txt_Usuario.Text != " " && txt_Contraseña.Text != " ")//--if para que no queden casillas sin llenar
                {
                    var actualizar = context.Personal.First(x => x.Id == id);
                    if (actualizar != null)
                    {
                        actualizar.Nombre = txt_Nombre.Text.ToUpper();
                        actualizar.Apellido = txt_Apellido.Text.ToUpper();
                        actualizar.Sexo = rb_Masculino.Checked ? "Masculino" : "Femenino";
                        actualizar.Edad = Convert.ToInt32(txt_Edad.Text);
                        actualizar.FechaNacimiento = Convert.ToString(dtp_FechaNacimiento.Value).ToUpper();
                        actualizar.Telefono = Convert.ToInt32(txt_Telefono.Text);
                        actualizar.Direccion = txt_Direccion.Text.ToUpper();
                        actualizar.Nivel = Convert.ToString(cb_Nivel.SelectedItem).ToUpper();
                        actualizar.Usuario = txt_Usuario.Text;
                        actualizar.Contraseña = txt_Contraseña.Text;
                        context.SaveChanges();
                        MessageBox.Show("SE ACRUALIZO LA INFORMACION DE PERSONAL", "AVISO", MessageBoxButtons.OK);
                    }
                }
            }
        }//fin metodo
        //*******

    }//fin class
}//fin agregar personal
