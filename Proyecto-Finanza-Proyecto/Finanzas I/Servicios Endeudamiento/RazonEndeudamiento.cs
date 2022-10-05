using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Endeudamiento
{
    public class RazonEndeudamiento
    {
        public double REndeudamiento(double PasivoTotal, double ActivoTotal)
        {
            return (PasivoTotal / ActivoTotal) * 100;
        }
    }
}
