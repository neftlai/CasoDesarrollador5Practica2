﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    public partial class frmCredito : Form
    {
        static int[] letras = { 3, 6, 9, 12 };
        static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

        ArrayList aProductos = new ArrayList(productos);
        ArrayList aletras = new ArrayList(letras);

        double tSubtotal = 0;
        public frmCredito()
        {

            InitializeComponent();
        }


        void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        void montoLetras(int le)
        {
            double montoMensual = double.Parse(lblMonto.Text) / le;

            lvResumen.Items.Clear();
            for (int i=1;i<=le; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(montoMensual.ToString("c"));
                lvResumen.Items.Add(fila);
            }
        }


        private void frmCredito_Load_1(object sender, EventArgs e)
        {
            cboLetras.DataSource = aletras;
            cboProducto.DataSource = aProductos;
            mostrarFecha();
            mostrarHora();

        }

        private void btnAdquirir_Click_1(object sender, EventArgs e)
        {
            //obeto de la clase credito
            Credito objC = new Credito();

            //datos del cliente
            objC.clientes = txtCliente.Text;
            objC.ruc = txtRUC.Text;
            objC.Fecha = DateTime.Parse(lblFecha.Text);
            objC.Hora = DateTime.Parse(lblHora.Text);


            //datos del producto
            objC.Producto = cboProducto.Text;
            objC.cantidad = int.Parse(txtCantidad.Text);

            //imprimir en la lista 
            ListViewItem fila = new ListViewItem(objC.getx().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(objC.asignaPrecio().ToString("c"));
            fila.SubItems.Add(objC.calculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            tSubtotal += objC.calculaSubtotal();
            lblMonto.Text = tSubtotal.ToString("0.00");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int letras = int.Parse(cboLetras.Text);
            switch (letras)
            {
                case 3: montoLetras(3); break;
                case 6: montoLetras(6); break;
                case 9: montoLetras(9); break;
                case 12: montoLetras(12); break;

            }
        }
    }
}
