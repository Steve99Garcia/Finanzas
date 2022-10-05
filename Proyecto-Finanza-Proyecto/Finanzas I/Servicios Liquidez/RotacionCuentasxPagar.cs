using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class RotacionCuentasxPagar
    {
        public double RotacCuentasxPagar(double ComprasCredito, double PromCuentasxPagar)
        {
            return ComprasCredito / PromCuentasxPagar;
        }
    }
}
