using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    public partial class Vocales : Form
    {
        public Vocales()
        {
            InitializeComponent();
        }

        private void ingresarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = CuadrodeTexto.Text.ToLower();
            int contadorA = 0, contadorE = 0, contadorI = 0, contadorO = 0, contadorU = 0;
            // Primero, hacemos que la palabra que ingresamos se haga minuscula, luego le creamos un contador a cada vocal

            foreach (char letra in palabra)
            // por cada letra en la palabra que haga esto:
            {
                switch (letra)
                {
                    case 'a':
                        contadorA++;
                        break;
                    case 'e':
                        contadorE++;
                        break;
                    case 'i':
                        contadorI++;
                        break;
                    case 'o':
                        contadorO++;
                        break;
                    case 'u':
                        contadorU++;
                        break;
                        // si tiene cierta vocal, que sume al contador de esa vocal
                }
            }
            string resultado = $"La palabra \"{palabra}\" tiene:\n\n";
            if (contadorA > 0)
            {
                resultado += $"{contadorA} vocales \"a\"\n";
            }
            if (contadorE > 0)
            {
                resultado += $"{contadorE} vocales \"e\"\n";
            }
            if (contadorI > 0)
            {
                resultado += $"{contadorI} vocales \"i\"\n";
            }
            if (contadorO > 0)
            {
                resultado += $"{contadorO} vocales \"o\"\n";
            }
            if (contadorU > 0)
            {
                resultado += $"{contadorU} vocales \"u\"\n";
            }

            if (resultado == $"La palabra \"{palabra}\" tiene:\n\n")
            {
                resultado = $"La palabra \"{palabra}\" no tiene vocales.";
            }
            // si el contador de cada vocal es mayor a 0, qye imprima el numero de vocales que tiene la palabra
            // si no tiene vocales que imprima el resultado "sin vocales"

            mostrarVocales.Text = resultado;
        }

        private void Vocales_Load(object sender, EventArgs e)
        {
            TemasColor.ElegirTema("Oscuro");
            panelPrincipal.BackColor = TemasColor.PanelPrincipal;
            panelBotones.BackColor = TemasColor.PaneldeBotones;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            selecciondeTema.BackColor = TemasColor.PanelPrincipal;
            selecciondeTema.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
            panelCierreyMinimizado.BackColor = TemasColor.PaneldeBotones;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void retornarBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new Menú();
            menu.Show();
        }

        private void selecciondeTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemasColor.ElegirTema(selecciondeTema.Text);
            panelPrincipal.BackColor = TemasColor.PanelPrincipal;
            panelBotones.BackColor = TemasColor.PaneldeBotones;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            selecciondeTema.BackColor = TemasColor.PanelPrincipal;
            selecciondeTema.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
            panelCierreyMinimizado.BackColor = TemasColor.PaneldeBotones;
        }
    }
}
