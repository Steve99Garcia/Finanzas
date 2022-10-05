using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class IndiceSolvencia
    {
        public double IndiceS(double ActivoC, double PasivoC)
        {
            return ActivoC / PasivoC;
        }
    }
}
