using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class RotacionInventario
    {
        public double RotacInv(double CostoMercanciaVendida, double PromedioInv)
        {
            return CostoMercanciaVendida / PromedioInv;
        }
    }
}
