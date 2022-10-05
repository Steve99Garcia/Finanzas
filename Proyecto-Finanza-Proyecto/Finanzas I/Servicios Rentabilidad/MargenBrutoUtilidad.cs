using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Rentabilidad
{
    public class MargenBrutoUtilidad
    {
        public double MBU(double Ventas, double CostoVentas)
        {
            return (Ventas - CostoVentas) / Ventas;
        }
    }
}
