using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    
    public class Venta
    {
        public string clientes { get; set; }
        public string ruc { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Producto { get; set; }
        public int cantidad { get; set; }

        public double asignaPrecio()
        {
            switch (Producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }

            return 0;
        }
        //Metodo que calcula el subtotal
        public double calculaSubtotal()
        {
            return asignaPrecio() * cantidad;
        }
    }
}
