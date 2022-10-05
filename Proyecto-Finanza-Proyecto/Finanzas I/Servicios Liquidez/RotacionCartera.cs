using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class RotacionCartera
    {
        public double RotacCartera(double VentasCredito, double PromCuentaxCobrar)
        {
            return VentasCredito / PromCuentaxCobrar;
        }
    }
}
