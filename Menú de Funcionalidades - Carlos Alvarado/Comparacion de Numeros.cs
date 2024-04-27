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
    public partial class compNumeros : Form
    {
        public compNumeros()
        {
            InitializeComponent();
        }

        private void selecciondeTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemasColor.ElegirTema(selecciondeTema.Text);
            panelPrincipal.BackColor = TemasColor.PaneldeBotones;
            panelBotones.BackColor = TemasColor.PanelPrincipal;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            listnum.BackColor = TemasColor.PaneldeBotones;
            listnum.ForeColor = TemasColor.Textos;
            selecciondeTema.BackColor = TemasColor.PanelPrincipal;
            selecciondeTema.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
        }

        private void bttAgregarnum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                listnum.Items.Add(numero);
                txtNumero.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttComparacion_Click(object sender, EventArgs e)
        {
            if (listnum.Items.Count > 0)
            {
                int mayor = int.MinValue;
                int menor = int.MaxValue;
                foreach (int numero in listnum.Items)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
                MessageBox.Show("El numero mayor es " + mayor + "\n" + " El numero menor es " + menor, "Comparación", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese al menos un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttLimpiarLista_Click(object sender, EventArgs e)
        {
            listnum.Items.Clear();
        }

        private void compNumeros_Load(object sender, EventArgs e)
        {
            TemasColor.ElegirTema("Oscuro");
            panelPrincipal.BackColor = TemasColor.PaneldeBotones;
            panelBotones.BackColor = TemasColor.PanelPrincipal;
            panelPrincipal.ForeColor = TemasColor.Textos;
            panelBotones.ForeColor = TemasColor.Textos;
            listnum.BackColor = TemasColor.PaneldeBotones;
            listnum.ForeColor = TemasColor.Textos;
            selecciondeTema.BackColor = TemasColor.PanelPrincipal;
            selecciondeTema.ForeColor = TemasColor.Textos;
            panelRetorno.BackColor = TemasColor.PaneldeBotones;
        }

        private void retornarBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new Menú();
            menu.Show();
        }

        private void cerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarAplicacion_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
