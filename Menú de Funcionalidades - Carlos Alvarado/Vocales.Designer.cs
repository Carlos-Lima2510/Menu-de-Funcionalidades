namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    partial class Vocales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vocales));
            this.mostrarVocales = new System.Windows.Forms.Label();
            this.ingresarPalabra = new System.Windows.Forms.Button();
            this.CuadrodeTexto = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.selecciondeTema = new System.Windows.Forms.ComboBox();
            this.panelRetorno = new System.Windows.Forms.Panel();
            this.retornarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelCierreyMinimizado = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelRetorno.SuspendLayout();
            this.panelCierreyMinimizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostrarVocales
            // 
            this.mostrarVocales.AutoSize = true;
            this.mostrarVocales.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarVocales.Location = new System.Drawing.Point(279, 18);
            this.mostrarVocales.Name = "mostrarVocales";
            this.mostrarVocales.Size = new System.Drawing.Size(171, 23);
            this.mostrarVocales.TabIndex = 5;
            this.mostrarVocales.Text = "Cantidad de Vocales";
            // 
            // ingresarPalabra
            // 
            this.ingresarPalabra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarPalabra.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarPalabra.Location = new System.Drawing.Point(26, 65);
            this.ingresarPalabra.Name = "ingresarPalabra";
            this.ingresarPalabra.Size = new System.Drawing.Size(176, 40);
            this.ingresarPalabra.TabIndex = 4;
            this.ingresarPalabra.Text = "Ingresar";
            this.ingresarPalabra.UseVisualStyleBackColor = true;
            this.ingresarPalabra.Click += new System.EventHandler(this.ingresarPalabra_Click);
            // 
            // CuadrodeTexto
            // 
            this.CuadrodeTexto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuadrodeTexto.Location = new System.Drawing.Point(26, 18);
            this.CuadrodeTexto.Name = "CuadrodeTexto";
            this.CuadrodeTexto.Size = new System.Drawing.Size(176, 29);
            this.CuadrodeTexto.TabIndex = 3;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.CuadrodeTexto);
            this.panelBotones.Controls.Add(this.mostrarVocales);
            this.panelBotones.Controls.Add(this.ingresarPalabra);
            this.panelBotones.Location = new System.Drawing.Point(13, 70);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(657, 186);
            this.panelBotones.TabIndex = 6;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelCierreyMinimizado);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.panelRetorno);
            this.panelPrincipal.Controls.Add(this.selecciondeTema);
            this.panelPrincipal.Controls.Add(this.panelBotones);
            this.panelPrincipal.Location = new System.Drawing.Point(-1, -1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(680, 329);
            this.panelPrincipal.TabIndex = 7;
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
            this.selecciondeTema.Location = new System.Drawing.Point(13, 13);
            this.selecciondeTema.Name = "selecciondeTema";
            this.selecciondeTema.Size = new System.Drawing.Size(186, 28);
            this.selecciondeTema.TabIndex = 7;
            this.selecciondeTema.Text = "Seleccione un Tema";
            this.selecciondeTema.SelectedIndexChanged += new System.EventHandler(this.selecciondeTema_SelectedIndexChanged);
            // 
            // panelRetorno
            // 
            this.panelRetorno.Controls.Add(this.retornarBTN);
            this.panelRetorno.Controls.Add(this.label1);
            this.panelRetorno.Location = new System.Drawing.Point(457, 262);
            this.panelRetorno.Name = "panelRetorno";
            this.panelRetorno.Size = new System.Drawing.Size(213, 48);
            this.panelRetorno.TabIndex = 17;
            // 
            // retornarBTN
            // 
            this.retornarBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retornarBTN.BackgroundImage")));
            this.retornarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retornarBTN.FlatAppearance.BorderSize = 0;
            this.retornarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retornarBTN.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retornarBTN.Location = new System.Drawing.Point(170, 7);
            this.retornarBTN.Name = "retornarBTN";
            this.retornarBTN.Size = new System.Drawing.Size(30, 28);
            this.retornarBTN.TabIndex = 5;
            this.retornarBTN.UseVisualStyleBackColor = true;
            this.retornarBTN.Click += new System.EventHandler(this.retornarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Retornar al Menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contador de Vocales";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(42, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 26);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Location = new System.Drawing.Point(4, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 26);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panelCierreyMinimizado
            // 
            this.panelCierreyMinimizado.Controls.Add(this.btnCerrar);
            this.panelCierreyMinimizado.Controls.Add(this.btnMinimizar);
            this.panelCierreyMinimizado.Location = new System.Drawing.Point(596, 13);
            this.panelCierreyMinimizado.Name = "panelCierreyMinimizado";
            this.panelCierreyMinimizado.Size = new System.Drawing.Size(74, 36);
            this.panelCierreyMinimizado.TabIndex = 21;
            // 
            // Vocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 322);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vocales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocales";
            this.Load += new System.EventHandler(this.Vocales_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelRetorno.ResumeLayout(false);
            this.panelRetorno.PerformLayout();
            this.panelCierreyMinimizado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mostrarVocales;
        private System.Windows.Forms.Button ingresarPalabra;
        private System.Windows.Forms.TextBox CuadrodeTexto;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ComboBox selecciondeTema;
        private System.Windows.Forms.Panel panelRetorno;
        private System.Windows.Forms.Button retornarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelCierreyMinimizado;
    }
}