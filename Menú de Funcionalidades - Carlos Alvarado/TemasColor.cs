using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    internal class TemasColor
    {
        public static Color PanelPrincipal;
        public static Color PaneldeBotones;
        public static Color Textos;

        private static readonly Color PanelPrincipalO = Color.FromArgb(10, 10, 10);
        private static readonly Color PaneldeBotonesD = Color.FromArgb(51, 51, 51);
        private static readonly Color TextosD = Color.White;

        private static readonly Color PanelPrincipalA = Color.FromArgb(23, 44, 92);
        private static readonly Color PaneldeBotonesA = Color.FromArgb(42, 56, 92);
        private static readonly Color TextosA = Color.White;

        private static readonly Color PanelPrincipalR = Color.FromArgb(59, 17, 27);
        private static readonly Color PaneldeBotonesR = Color.FromArgb(122, 35, 56);
        private static readonly Color TextosR = Color.White;

        private static readonly Color PanelPrincipalM = Color.FromArgb(92, 36, 97);
        private static readonly Color PaneldeBotonesM = Color.FromArgb(94, 65, 97);
        private static readonly Color TextosM = Color.LightGoldenrodYellow;

        public static void ElegirTema(string Tema)
        {
            if (Tema == "Oscuro")
            {
                PanelPrincipal = PanelPrincipalO;
                PaneldeBotones = PaneldeBotonesD;
                Textos = TextosD;
            }
            if (Tema == "Azul")
            {
                PanelPrincipal = PanelPrincipalA;
                PaneldeBotones = PaneldeBotonesA;
                Textos = TextosA;
            }
            if (Tema == "Rojo")
            {
                PanelPrincipal = PanelPrincipalR;
                PaneldeBotones = PaneldeBotonesR;
                Textos = TextosR;
            }
            if (Tema == "Morado")
            {
                PanelPrincipal = PanelPrincipalM;
                PaneldeBotones = PaneldeBotonesM;
                Textos = TextosM;
            }
        }
    }
}
