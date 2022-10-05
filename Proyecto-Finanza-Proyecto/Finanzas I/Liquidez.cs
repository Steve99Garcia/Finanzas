using Finanzas_I.Poco;
using Finanzas_I.Servicios_Liquidez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas_I
{
    public partial class Liquidez : Form
    {
        public Datos datos { get; set; }
        CapitalTrabajo CT;
        IndiceSolvencia IS;
        PruebaAcida PA;
        RotacionInventario RI;
        RotacionCartera RC;
        RotacionCuentasxPagar RCP;

        public Liquidez()
        {
            InitializeComponent();
            CT = new CapitalTrabajo();
            IS = new IndiceSolvencia();
            PA = new PruebaAcida();
            RI = new RotacionInventario();
            RC = new RotacionCartera();
            RCP = new RotacionCuentasxPagar();
        }

        private void Liquidez_Load(object sender, EventArgs e)
        {
            TxtCT.Text = CT.CapitalT(datos.Activos, datos.Pasivos).ToString();
            TxtIS.Text = IS.IndiceS(datos.Activos, datos.Pasivos).ToString();
            TxtPA.Text = PA.PruebaA(datos.Activos, datos.Inventario, datos.Pasivos).ToString();
            double Promedio_Inventario = 0;
            Promedio_Inventario = (datos.Inventario_Inicial + datos.Inventario_Final) / 2;
            TxtRI.Text = RI.RotacInv(datos.Costo_Mercancia_Vendida, Promedio_Inventario).ToString();
            double Promedio_CuentasCobrar = 0;
            Promedio_CuentasCobrar = (datos.CuentasCobrar_Enero + datos.CuentasCobrar_Dic) / 2;
            TxtRC.Text = RC.RotacCartera(datos.Ventas_Credito, Promedio_CuentasCobrar).ToString();
            double Promedio_CuentasPagar = 0;
            Promedio_CuentasPagar = (datos.CuentasPagar_Enero + datos.CuentasPagar_Dic) / 2;
            TxtRCP.Text = RCP.RotacCuentasxPagar(datos.Compras_Creidto, Promedio_CuentasPagar).ToString();
        }
    }
}
