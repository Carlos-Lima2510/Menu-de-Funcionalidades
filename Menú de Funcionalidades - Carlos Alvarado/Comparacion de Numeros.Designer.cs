namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    partial class compNumeros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compNumeros));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.listnum = new System.Windows.Forms.ListBox();
            this.bttLimpiarLista = new System.Windows.Forms.Button();
            this.bttAgregarnum = new System.Windows.Forms.Button();
            this.bttComparacion = new System.Windows.Forms.Button();
            this.selecciondeTema = new System.Windows.Forms.ComboBox();
            this.txtPredeterminado1 = new System.Windows.Forms.Label();
            this.minimizarAplicacion = new System.Windows.Forms.Button();
            this.cerrarAplicacion = new System.Windows.Forms.Button();
            this.retornarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRetorno = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelRetorno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.cerrarAplicacion);
            this.panelPrincipal.Controls.Add(this.minimizarAplicacion);
            this.panelPrincipal.Controls.Add(this.selecciondeTema);
            this.panelPrincipal.Controls.Add(this.txtNumero);
            this.panelPrincipal.Location = new System.Drawing.Point(-7, -3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(808, 149);
            this.panelPrincipal.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(53, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(226, 29);
            this.txtNumero.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.panelRetorno);
            this.panelBotones.Controls.Add(this.txtPredeterminado1);
            this.panelBotones.Controls.Add(this.listnum);
            this.panelBotones.Controls.Add(this.bttLimpiarLista);
            this.panelBotones.Controls.Add(this.bttAgregarnum);
            this.panelBotones.Controls.Add(this.bttComparacion);
            this.panelBotones.Location = new System.Drawing.Point(-4, 144);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(808, 320);
            this.panelBotones.TabIndex = 1;
            // 
            // listnum
            // 
            this.listnum.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listnum.FormattingEnabled = true;
            this.listnum.ItemHeight = 26;
            this.listnum.Location = new System.Drawing.Point(377, 62);
            this.listnum.Name = "listnum";
            this.listnum.Size = new System.Drawing.Size(295, 134);
            this.listnum.TabIndex = 3;
            // 
            // bttLimpiarLista
            // 
            this.bttLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLimpiarLista.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpiarLista.Location = new System.Drawing.Point(112, 156);
            this.bttLimpiarLista.Name = "bttLimpiarLista";
            this.bttLimpiarLista.Size = new System.Drawing.Size(164, 40);
            this.bttLimpiarLista.TabIndex = 2;
            this.bttLimpiarLista.Text = "Limpiar Lista";
            this.bttLimpiarLista.UseVisualStyleBackColor = true;
            this.bttLimpiarLista.Click += new System.EventHandler(this.bttLimpiarLista_Click);
            // 
            // bttAgregarnum
            // 
            this.bttAgregarnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregarnum.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregarnum.Location = new System.Drawing.Point(112, 64);
            this.bttAgregarnum.Name = "bttAgregarnum";
            this.bttAgregarnum.Size = new System.Drawing.Size(164, 40);
            this.bttAgregarnum.TabIndex = 1;
            this.bttAgregarnum.Text = "Agregar";
            this.bttAgregarnum.UseVisualStyleBackColor = true;
            this.bttAgregarnum.Click += new System.EventHandler(this.bttAgregarnum_Click);
            // 
            // bttComparacion
            // 
            this.bttComparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttComparacion.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttComparacion.Location = new System.Drawing.Point(112, 110);
            this.bttComparacion.Name = "bttComparacion";
            this.bttComparacion.Size = new System.Drawing.Size(164, 40);
            this.bttComparacion.TabIndex = 0;
            this.bttComparacion.Text = "Comparación";
            this.bttComparacion.UseVisualStyleBackColor = true;
            this.bttComparacion.Click += new System.EventHandler(this.bttComparacion_Click);
            // 
            // selecciondeTema
            // 
            this.selecciondeTema.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecciondeTema.FormattingEnabled = true;
            this.selecciondeTema.Items.AddRange(new object[] {
            "Oscuro",
            "Azul",
            "Rojo",
            "Morado"});
            this.selecciondeTema.Location = new System.Drawing.Point(504, 15);
            this.selecciondeTema.Name = "selecciondeTema";
            this.selecciondeTema.Size = new System.Drawing.Size(186, 28);
            this.selecciondeTema.TabIndex = 1;
            this.selecciondeTema.Text = "Seleccione un Tema";
            this.selecciondeTema.SelectedIndexChanged += new System.EventHandler(this.selecciondeTema_SelectedIndexChanged);
            // 
            // txtPredeterminado1
            // 
            this.txtPredeterminado1.AutoSize = true;
            this.txtPredeterminado1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredeterminado1.Location = new System.Drawing.Point(373, 30);
            this.txtPredeterminado1.Name = "txtPredeterminado1";
            this.txtPredeterminado1.Size = new System.Drawing.Size(111, 23);
            this.txtPredeterminado1.TabIndex = 4;
            this.txtPredeterminado1.Text = "Lista de Números";
            // 
            // minimizarAplicacion
            // 
            this.minimizarAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.minimizarAplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizarAplicacion.BackgroundImage")));
            this.minimizarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizarAplicacion.FlatAppearance.BorderSize = 0;
            this.minimizarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarAplicacion.ForeColor = System.Drawing.Color.White;
            this.minimizarAplicacion.Location = new System.Drawing.Point(725, 15);
            this.minimizarAplicacion.Name = "minimizarAplicacion";
            this.minimizarAplicacion.Size = new System.Drawing.Size(28, 23);
            this.minimizarAplicacion.TabIndex = 2;
            this.minimizarAplicacion.UseVisualStyleBackColor = false;
            this.minimizarAplicacion.Click += new System.EventHandler(this.minimizarAplicacion_Click);
            // 
            // cerrarAplicacion
            // 
            this.cerrarAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.cerrarAplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrarAplicacion.BackgroundImage")));
            this.cerrarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.cerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarAplicacion.Location = new System.Drawing.Point(769, 15);
            this.cerrarAplicacion.Name = "cerrarAplicacion";
            this.cerrarAplicacion.Size = new System.Drawing.Size(28, 23);
            this.cerrarAplicacion.TabIndex = 3;
            this.cerrarAplicacion.UseVisualStyleBackColor = false;
            this.cerrarAplicacion.Click += new System.EventHandler(this.cerrarAplicacion_Click);
            // 
            // retornarBTN
            // 
            this.retornarBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retornarBTN.BackgroundImage")));
            this.retornarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retornarBTN.FlatAppearance.BorderSize = 0;
            this.retornarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retornarBTN.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retornarBTN.Location = new System.Drawing.Point(177, 3);
            this.retornarBTN.Name = "retornarBTN";
            this.retornarBTN.Size = new System.Drawing.Size(38, 36);
            this.retornarBTN.TabIndex = 5;
            this.retornarBTN.UseVisualStyleBackColor = true;
            this.retornarBTN.Click += new System.EventHandler(this.retornarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Retornar al Menú";
            // 
            // panelRetorno
            // 
            this.panelRetorno.Controls.Add(this.retornarBTN);
            this.panelRetorno.Controls.Add(this.label1);
            this.panelRetorno.Location = new System.Drawing.Point(576, 249);
            this.panelRetorno.Name = "panelRetorno";
            this.panelRetorno.Size = new System.Drawing.Size(218, 48);
            this.panelRetorno.TabIndex = 7;
            // 
            // compNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "compNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparación de Números";
            this.Load += new System.EventHandler(this.compNumeros_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelRetorno.ResumeLayout(false);
            this.panelRetorno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.ListBox listnum;
        private System.Windows.Forms.Button bttLimpiarLista;
        private System.Windows.Forms.Button bttAgregarnum;
        private System.Windows.Forms.Button bttComparacion;
        private System.Windows.Forms.ComboBox selecciondeTema;
        private System.Windows.Forms.Label txtPredeterminado1;
        private System.Windows.Forms.Button cerrarAplicacion;
        private System.Windows.Forms.Button minimizarAplicacion;
        private System.Windows.Forms.Button retornarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRetorno;
    }
}

