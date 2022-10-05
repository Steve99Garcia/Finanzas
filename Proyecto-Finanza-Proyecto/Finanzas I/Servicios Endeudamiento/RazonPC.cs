using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Endeudamiento
{
    public class RazonPC
    {
        public double RPC(double PasivoLP, double Capital)
        {
            return PasivoLP / Capital;
        }
    }
}
