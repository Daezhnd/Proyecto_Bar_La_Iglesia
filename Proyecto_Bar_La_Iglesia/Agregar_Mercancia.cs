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
    public partial class Agregar_Mercancia : Form
    {
        int id;//--obtiene valor codigo mercancia
        public Agregar_Mercancia()
        {
            InitializeComponent();
        }
        //*******
        private void btn_Estado_Click(object sender, EventArgs e) /* boton cambiar estado producto */
        {
            if (btn_Estado.Text == "Activo")
            {
                btn_Estado.Text = "Inactivo";
            }
            else
            {
                btn_Estado.Text = "Activo";
            }
        }//fin metodo
        //*******
        private void btn_Agregar_Click(object sender, EventArgs e) /* boton agregar producto */
        {
            using (var context = new ApplicationDbContext())
            {
                if (txt_Codigo.Text != " " && txt_Nombre.Text != " " && txt_Proveedor.Text != " " && txt_Existencia.Text != " " && txt_Precio.Text != " ")//--if para que no queden casillas sin llenar
                {
                    var agregar = new Mercancia();
                    agregar.Nombre = txt_Nombre.Text.ToUpper();
                    agregar.TipoProducto = Convert.ToString(cb_TipoProducto.SelectedItem).ToUpper();
                    agregar.Proveedor = txt_Proveedor.Text.ToUpper();
                    agregar.Existencia = Convert.ToInt32(txt_Existencia.Text);
                    agregar.Precio = Convert.ToInt32(txt_Precio.Text);
                    agregar.Estado = btn_Estado.Text.ToUpper();
                    context.Mercancia.Add(agregar);
                    context.SaveChanges();
                    MessageBox.Show("SE AGREGO EL NUEVO PERSONAL", "AVISO", MessageBoxButtons.OK);
                }
                else//--muestra mensaje si hay casillas sin llenar
                {
                    MessageBox.Show("TODAS LAS CASILLAS DEBEN ESTAR LLENAS", "AVISO", MessageBoxButtons.OK);
                }
            }
        }//fin metodo
        //*******
        private void btn_Actualizar_Click(object sender, EventArgs e) /* boton actualizar producto */
        {
            using (var context = new ApplicationDbContext())
            {
                if (txt_Codigo.Text != " " && txt_Nombre.Text != " " && txt_Proveedor.Text != " " && txt_Existencia.Text != " " && txt_Precio.Text != " ")//--if para que no queden casillas sin llenar
                {
                    var actualizar = context.Mercancia.First(x => x.Id == id);
                    if (actualizar != null)
                    {
                        actualizar.Nombre = txt_Nombre.Text.ToUpper();
                        actualizar.TipoProducto = Convert.ToString(cb_TipoProducto.SelectedItem).ToUpper();
                        actualizar.Proveedor = txt_Proveedor.Text.ToUpper();
                        actualizar.Existencia = Convert.ToInt32(txt_Existencia.Text);
                        actualizar.Precio = Convert.ToInt32(txt_Precio.Text);
                        actualizar.Estado = btn_Estado.Text.ToUpper();
                        context.SaveChanges();
                        MessageBox.Show("SE ACRUALIZO LA INFORMACION DE PERSONAL", "AVISO", MessageBoxButtons.OK);
                    }
                }
            }
        }
        //*******

    }//fin class
}//fin agregar mercancia
