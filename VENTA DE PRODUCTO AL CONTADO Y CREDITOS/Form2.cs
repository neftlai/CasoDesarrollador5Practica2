using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    public partial class frmContado : Form
    {
        //Inicializacion del arreglo de productos
        static string[] Productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

        //creando el objeto de la clase Arrylist
        ArrayList aProductos = new ArrayList(Productos);

        double tSubtotal = 0;

        public frmContado()
        {
            InitializeComponent();
        }


        private void frmContado_load(object sender, EventArgs e)
        {
           
        }
        void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        void listado(Contado objC)
        {
            tSubtotal += objC.calculaSubtotal();
            lvResumen.Items.Clear();
            lvResumen.Items.Add("**RESUMEN DE VENTA** ");
            lvResumen.Items.Add("-------------------------------");
            lvResumen.Items.Add("CLIENTE: " + objC.clientes);
            lvResumen.Items.Add("RUC: " + objC.ruc);
            lvResumen.Items.Add("FECHA: " + objC.Fecha);
            lvResumen.Items.Add("HORA: " + objC.Hora);
            lvResumen.Items.Add("-------------------------------");

            lvResumen.Items.Add("SUBTOTAL: " + tSubtotal.ToString("c"));
            double descuento = objC.calculaDescuento(tSubtotal);
            double neto = objC.calculaNeto(tSubtotal, descuento);

            lvResumen.Items.Add("NETO: " + neto.ToString("c"));

            //Hablar el monto total sin descuento
            lblMonto.Text = neto.ToString("c");


        }

        private void frmContado_Load_1(object sender, EventArgs e)
        {
            cboProducto.DataSource = aProductos;
            mostrarFecha();
            mostrarHora();

        }

        private void bntAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Contado
            Contado objC = new Contado();

            //Datos el cliente 
            objC.clientes = txtCliente.Text;
            objC.ruc = txtRUC.Text;
            objC.Fecha = DateTime.Parse(lblFecha.Text);
            objC.Hora = DateTime.Parse(lblHora.Text);

            //datos del producto 
            objC.Producto = cboProducto.Text;
            objC.cantidad = int.Parse(txtCantidad.Text);

            //Imprimir en la lista 
            ListViewItem fila = new ListViewItem(objC.getN().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(objC.cantidad.ToString());
            fila.SubItems.Add(objC.asignaPrecio().ToString("c"));
            fila.SubItems.Add(objC.calculaSubtotal().ToString());
            LvDetalle.Items.Add(fila);

            listado(objC);
        }
    } 
}

