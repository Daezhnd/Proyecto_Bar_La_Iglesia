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
    public partial class Cajero : Form
    {
        public int posicion = 0;//--recibe el valor de la posicion del la fila del DataGridView
        public Cajero()
        {
            InitializeComponent();
        }
        //*******
        private void Cajero_Load(object sender, EventArgs e) /* muestra tabla de productos al iniciar */
        {
            using (var context = new ApplicationDbContext())
            {
                var producto = context.Mercancia.ToList();
                dgv_Producto.DataSource = producto;
            }
        }//fin metodo
        //*******
        private void txt_Producto_TextChanged(object sender, EventArgs e) /* muestra en tabla producto los productos buscados */
        {
            using (var context = new ApplicationDbContext())
            {
                var produco = context.Mercancia.Where(XmlReadMode => XmlReadMode.Nombre.Contains(txt_Producto.Text.ToUpper())).ToList();
            }
        }//fin metodo
        //*******
        private void btn_Agregar_Click(object sender, EventArgs e) /* boton agregar producto */
        {
            if (txt_Producto.Text != " " && txt_Cantidad.Text != " ")
            {
                using (var context = new ApplicationDbContext())
                {
                    var producto = context.Mercancia.First(x => x.Nombre == dgv_Producto.CurrentRow.Cells[1].Value.ToString().ToUpper());
                    if (producto != null)
                    {
                        if (producto.Estado == "INACTIVO")//--no agregar producto si esta inactivo
                        {
                            MessageBox.Show("EL PRODUCTO NO ESTA ACTIVO", "AVISO", MessageBoxButtons.OK);
                        }
                        else if (producto.Existencia < Convert.ToInt32(txt_Cantidad.Text))//--no agregar producto si cantidad es superior a existencia
                        {
                            MessageBox.Show("LA EXISTENCIA DEL PRODUCTO ES DE [" + Convert.ToString(producto.Existencia) + "]", "AVISO", MessageBoxButtons.OK);
                        }
                        else//--agrega los datos al ticket
                        {
                            int n = dgv_Ticket.Rows.Add();
                            dgv_Ticket.Rows[n].Cells[0].Value = txt_Cantidad.Text;
                            dgv_Ticket.Rows[n].Cells[1].Value = producto.Nombre;
                            dgv_Ticket.Rows[n].Cells[2].Value = producto.Precio;
                            dgv_Ticket.Rows[n].Cells[3].Value = (Convert.ToInt32(txt_Cantidad.Text) * producto.Precio);
                            TotalProducto();
                            Limpiar();
                        }
                    }
                }
            }
        }//fin metodo
        //*******
        private void btn_Eliminar_Click(object sender, EventArgs e) /* boton eliminar producto */
        {
            if (txt_Producto.Text != " " && txt_Cantidad.Text != " ")
            {
                dgv_Ticket.Rows.RemoveAt(posicion);
                TotalProducto();
                Limpiar();
            }
        }//fin metodo
        //*******
        private void TotalProducto() /* metodo para sumar el total del ticket */
        {
            txt_Total.Text = "0";
            for (int i = 0; i < dgv_Ticket.RowCount; i++)
            {
                txt_Total.Text = "" + (Convert.ToDouble(txt_Total)) + (Convert.ToInt32(dgv_Ticket.Rows[i].Cells[0].Value)) * (Convert.ToDouble(dgv_Ticket.Rows[i].Cells[2].Value));
            }
        }//fin metodo
        //*******
        private void btn_Limpiar_Click(object sender, EventArgs e) /* boton limpiar */
        {
            Limpiar();
        }//fin metodo
        //*******
        private void btn_Facturar_Click(object sender, EventArgs e) /* boton facturar */
        {
            using (var context = new ApplicationDbContext())
            {
                if (txt_Total.Text != "0")
                {
                    var agregar = new HistorialVenta();
                    int n = dgv_Ticket.Rows.Add();
                    for (int i = 0; i < n; i++)//--ingresa datos del ticket a una solo casilla
                    {
                        var mercancia = context.Mercancia.First(x => x.Nombre == dgv_Ticket.Rows[i].Cells[0].Value.ToString());
                        mercancia.Existencia = mercancia.Existencia - Convert.ToInt32(dgv_Ticket.Rows[i].Cells[1].Value);
                        
                        if (mercancia.Existencia == 0)//--si existencia del producto es igual a 0 cambiar estado a inacrivo
                        {
                            mercancia.Estado = "INACTIVO";
                        }
                        agregar.ProductoCantidadPrecio = "" + agregar.ProductoCantidadPrecio + ("[" + dgv_Ticket.Rows[i].Cells[0].Value + "][" + dgv_Ticket.Rows[i].Cells[1].Value + "][$" + dgv_Ticket.Rows[i].Cells[2].Value + "];");
                    }
                    agregar.Fecha = DateTime.Now;
                    agregar.Total = Convert.ToInt32(txt_Total.Text);
                    context.HistorialVenta.Add(agregar);
                    context.SaveChanges();
                }
            }
            Limpiar();
            txt_Total.Text = "0";
            dgv_Ticket.Rows.Clear();
        }//fin metodo
        //*******
        public void Limpiar() /* metodo para limpiar el form */
        {
            txt_Producto.Text = "";
            txt_Cantidad.Text = "0";
        }//fin metodo
        //*******
        private void dgv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e) /* tabla producto */
        {
            txt_Producto.Text = dgv_Producto.CurrentRow.Cells[1].Value.ToString().ToUpper();
        }//fin metodo
        //*******
        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e) /* tabla ticket */
        {
            posicion = dgv_Ticket.CurrentRow.Index;
            txt_Cantidad.Text = dgv_Ticket.CurrentRow.Cells[0].Value.ToString();
            txt_Producto.Text = dgv_Ticket.CurrentRow.Cells[1].Value.ToString().ToUpper();
        }//fin 
        //*******

    }//fin class
}//fin cajero
