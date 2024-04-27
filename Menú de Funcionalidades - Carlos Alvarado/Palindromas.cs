using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    public partial class Palindromas : Form
    {
        public Palindromas()
        {
            InitializeComponent();
        }


        private void Palindromas_Load(object sender, EventArgs e)
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
            guardadodeLineas.BackColor = TemasColor.PaneldeBotones;
            guardadodeLineas.ForeColor = TemasColor.Textos;
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
            guardadodeLineas.BackColor = TemasColor.PaneldeBotones;
            guardadodeLineas.ForeColor = TemasColor.Textos;
        }

        private void ingresodeDatos_Click(object sender, EventArgs e)
        {
            string cadena = "";
            string cadena2 = "";
            string texto = cuadrodeTexto.Text.Trim();
            if (cuadrodeTexto.Text != "")
            {
                string frase = cuadrodeTexto.Text.Trim();
                cadena += texto[0];
                for (int i = 0; i <= texto.Length - 1; i++)
                {
                    cadena2 = texto[i].ToString();
                }

                if (cadena.Trim().ToLower() == cadena2.Trim().ToLower())
                {
                    guardadodeLineas.Items.Add(frase);
                    MessageBox.Show($"{frase} es palíndroma");
                }
                else
                {
                    MessageBox.Show($"{frase} NO es palíndroma");
                }
            }
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
