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
    public partial class PosiciondeLetras : Form
    {
        public PosiciondeLetras()
        {
            InitializeComponent();
            mostrarPrimeraLetra.Hide();
            mostrarPosición.Hide();
        }

        private void ingresarPalabra_Click(object sender, EventArgs e)
        {
            if (CuadrodeTextoPalabra.Text != "")
            // Si el cuadro de texto tiene algo:
            {
                string palabra = CuadrodeTextoPalabra.Text;
                // creamos una cadena con lo que ingresamos en el textbox
                char letra = palabra[0];
                // sacamos la letra en la primera posición (posición '0') de la palabra
                mostrarPrimeraLetra.Text = letra.ToString();
                mostrarPrimeraLetra.Show();
                // Imprimimos el carácter en un label
            }
        }

        private void PosiciondeLetras_Load(object sender, EventArgs e)
        {
            TemasColor.ElegirTema("Oscuro");
            panelFondo.BackColor = TemasColor.PaneldeBotones;
            PaneldeIngresos.BackColor = TemasColor.PanelPrincipal;
            panelFondo.ForeColor = TemasColor.Textos;
            PaneldeIngresos.ForeColor = TemasColor.Textos;
            SeleccióndeColor.BackColor = TemasColor.PanelPrincipal;
            SeleccióndeColor.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
            panelRetorno.ForeColor = TemasColor.Textos;
        }

        private void IngresarNumero_Click(object sender, EventArgs e)
        {
            if (CuadrodeTextoNúmero.Text != "")
            {
                string palabra = CuadrodeTextoPalabra.Text;
                // primero hacemos que lo ingresado en el textbox este en una cadena llamada palabra
                int índice = Convert.ToInt32(CuadrodeTextoNúmero.Text);
                //luego, hacemos que el numero que ingresamos en el otro textbox se declare en una variable entera llamada índice
                if (índice <= palabra.Length)
                // si el número es menor o igual a la cantidad de carácteres de la palabra:
                {
                    char letra = palabra[índice - 1];
                    // que cree una variable carácter, y que se saque la letra posiciónada en el resultante de índice-1 (ya que al ser vector empieza en 0)
                    mostrarPosición.Text = letra.ToString();
                    // que imprima la letra sacada
                    mostrarPosición.Show();
                }
                else
                {
                    MessageBox.Show("Ingresa un número menor a la cantidad de letras!!");
                    CuadrodeTextoNúmero.Clear();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CuadrodeTextoNúmero.Clear();
            CuadrodeTextoPalabra.Clear();
            mostrarPrimeraLetra.Text = "";
            mostrarPosición.Text = "";
        }

        private void SeleccióndeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemasColor.ElegirTema(SeleccióndeColor.Text);
            panelFondo.BackColor = TemasColor.PaneldeBotones;
            PaneldeIngresos.BackColor = TemasColor.PanelPrincipal;
            panelFondo.ForeColor = TemasColor.Textos;
            PaneldeIngresos.ForeColor = TemasColor.Textos;
            SeleccióndeColor.BackColor = TemasColor.PanelPrincipal;
            SeleccióndeColor.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
            panelRetorno.ForeColor = TemasColor.Textos;
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
