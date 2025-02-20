using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
{
    public class Credito: Venta
    {
        public static int x;
        public Credito()
        {
            x++;
        }
        public int getx()
        {
            return x;
        }

        //Metodos de la clase Credito
           public int letras { get; set; }

        //metodosde la clase credito
        public double calculaMontoInteres()
        {
            switch (letras)
            {
                case 3: return 5.0 / 100 * calculaSubtotal();
                case 6: return 10.0 / 100 * calculaSubtotal();
                case 9: return 15.0 / 100 * calculaSubtotal();
                case 12: return 25.0 / 100 * calculaSubtotal();
            }
            return 0;
        }
        public double calcularMontoMensual()
        {
            return (calculaSubtotal() + calculaMontoInteres())/ letras;
        }
    }
}
