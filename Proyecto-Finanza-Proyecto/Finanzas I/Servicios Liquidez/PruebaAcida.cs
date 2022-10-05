using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas_I.Servicios_Liquidez
{
    public class PruebaAcida
    {
        public double PruebaA(double ActivosC, double Inventario, double PasivosC)
        {
            return (ActivosC - Inventario) / PasivosC;
        }
    }
}
