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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
            panelBotones2.Hide();   
            
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            TemasColor.ElegirTema("Oscuro");
            panelPrincipal.BackColor = TemasColor.PanelPrincipal;
            panelBotones.BackColor = TemasColor.PaneldeBotones;
            panelBotones2.BackColor = TemasColor.PaneldeBotones;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            panelCierreyMinimizado.BackColor = TemasColor.PaneldeBotones;
        }

        private void bttEjercicioComparacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form comparacion = new compNumeros();
            comparacion.Show();

        }

        private void cerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarAplicacion_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttEjercicioPalabrasPosicion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form poscyletras = new PosiciondeLetras();
            poscyletras.Show();
        }

        private void bttEjercicioVocales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form vocales = new Vocales();
            vocales.Show();
        }

        private void cerrarAplicacion_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarAplicacion_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelBotones.Visible = false;
            this.panelBotones2.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reversos = new ReversiondePalabras();
            reversos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelBotones2.Visible = false;
            this.panelBotones.Visible = true;

        }

        private void palindromaBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form palindromas = new Palindromas();
            palindromas.Show();
        }

        private void longitudBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form longitud = new LongituddePalabras();
            longitud.Show();
        }
    }
}
