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
    public partial class ReversiondePalabras : Form
    {
        private string[] palabras = new string[10];
        private int contador = 0;
        public ReversiondePalabras()
        {
            InitializeComponent();
        }
        private void ReversiondePalabras_Load(object sender, EventArgs e)
        {
            TemasColor.ElegirTema("Oscuro");
            panelPrincipal.BackColor = TemasColor.PanelPrincipal;
            panelBotones.BackColor = TemasColor.PaneldeBotones;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            listBox1.BackColor = TemasColor.PaneldeBotones;
            groupBox1.BackColor = TemasColor.PaneldeBotones;
            listBox1.ForeColor = TemasColor.Textos;
            groupBox1.ForeColor = TemasColor.Textos;
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
            listBox1.BackColor = TemasColor.PaneldeBotones;
            groupBox1.BackColor = TemasColor.PaneldeBotones;
            listBox1.ForeColor = TemasColor.Textos;
            groupBox1.ForeColor = TemasColor.Textos;
            selecciondeTema.BackColor = TemasColor.PanelPrincipal;
            selecciondeTema.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
            panelCierreyMinimizado.BackColor = TemasColor.PaneldeBotones;
        }

        private void ingresarpalabra_Click(object sender, EventArgs e)
        {
            if (contador < palabras.Length)
            //si contador es menor a la cantidad de palabras (contador = 0 al inicio)
            {
                palabras[contador] = palabrasbox.Text;
                // que ponga la palabra ingresadas en la posición que muestra el contador (inicialmente esta en 0)
                contador++;
                // se suma 1, al contador, y esto forma un ciclo que va avanzando posiciones (contador = 1, posición = 1)
                palabrasbox.Clear();
                palabrasbox.Focus();
                listBox1.Items.Add(palabras[contador - 1]);
                // añade las palabras a una listbox, usando el vector para empezar en la posición 0 de las palabras
            }
            else
            {
                MessageBox.Show("Se llenó la lista." + "\n" + "Intenta limpiar algunos datos!!");
            }

        }

        private void revertirpalabra_Click(object sender, EventArgs e)
        {
            string resultado = "";
            // crea una cadena vacia
            for (int i = contador - 1; i >= 0; i--)
            // se crea un bucle donde recorra todas las palabras usando el contador - 1 para darle la posición final al vector y asi ir restando para ver cada palabra en el vector
            {
                string palabra = palabras[i];
                // se crea otra cadena para las palabras de la lista, siempre usando la variable i que las recorre
                for (int j = palabra.Length - 1; j >= 0; j--)
                // se crea otro bucle, que recorre cada palabra especificamente, solo que en reversa para generar el efecto de inversión de la palabra
                {
                    resultado += palabra[j];
                    // la cadena vacia se acumula con las palabras de la lista ya invertidas usando la variable j
                }
                resultado += "\n";
                // se le acumula una nueva linea para que la siguiente palabra se separe de la ya convertida
            }
            revertidas.Text = resultado;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            contador = 0;
            listBox1.Items.Clear();
            revertidas.Text = "";
            palabrasbox.Clear();
            // estas 4 lineas, limpian el contador del vector, la lista, el label, y el textbox
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
