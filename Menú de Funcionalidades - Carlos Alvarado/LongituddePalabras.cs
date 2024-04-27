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
    public partial class LongituddePalabras : Form
    {
        string[] palabra1 = new string[1];
        string[] palabra2 = new string[1];
        public LongituddePalabras()
        {
            InitializeComponent();
        }

        private void LongituddePalabras_Load(object sender, EventArgs e)
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

        private void AgregarPalabra1_Click(object sender, EventArgs e)
        {
            if (CuadroPrimeraPalabra.Text != "" && CuadroSegundaPalabra.Text != "")
            {
                palabra1[0] = CuadroPrimeraPalabra.Text;
                int longitud = palabra1[0].Length;

                palabra2[0] = CuadroSegundaPalabra.Text;
                int longitud2 = palabra2[0].Length;
                if (longitud > longitud2)
                {
                    mostrarMayoromenor.Text = "La palabra " + palabra1[0] + " (" + longitud + ")" + "\n"+ " tiene mayor longitud" + " que la palabra " + palabra2[0] + " (" + longitud2 + ")";
                }
                else
                {
                    mostrarMayoromenor.Text = "La palabra " + palabra1[0] + " (" + longitud + ")" + "\n" + " no tiene mayor longitud" + " que la palabra " + palabra2[0] + " (" + longitud2 + ")";
                }
                if (longitud == longitud2)
                {
                    mostrarMayoromenor.Text = "La palabra " + palabra1[0] + " (" + longitud + ")" + "\n" + " tiene igual longitud" + " que la palabra " + palabra2[0] + " (" + longitud2 + ")";
                }
            }
            else
            {
                MessageBox.Show("Ingresa datos en TODOS los campos");
            }
        }

        private void limpiarDatos_Click(object sender, EventArgs e)
        {
            CuadroPrimeraPalabra.Clear();
            CuadroSegundaPalabra.Clear();
            mostrarMayoromenor.Text = "";
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
    }
}
