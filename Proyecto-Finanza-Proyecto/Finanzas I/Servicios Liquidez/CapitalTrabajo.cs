using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class CapitalTrabajo
    {
        public double CapitalT(double ActivoC, double PasivoC)
        {
            return ActivoC - PasivoC;
        }
    }
}
