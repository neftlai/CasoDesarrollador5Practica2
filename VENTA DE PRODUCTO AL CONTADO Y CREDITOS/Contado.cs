using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    public class Contado:Venta 
    {
        public static int n;
        public Contado()
        {
            n++;
        }
        public int getN()
        {
            return n;
        }
        //Metodos de la clase contado
        public double calculaDescuento(double subtotal)
        {
            if (subtotal < 100)
                return 2.0 / 100 * subtotal;
            else if (subtotal >= 100 && subtotal <= 3000)
                return 5.0 / 100 * subtotal;
            else
                return 12.0 / 100 * subtotal;
        }
        public double calculaNeto(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }
    }
}
