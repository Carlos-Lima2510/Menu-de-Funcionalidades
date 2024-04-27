namespace Menú_de_Funcionalidades___Carlos_Alvarado
{
    partial class Palindromas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Palindromas));
            this.cuadrodeTexto = new System.Windows.Forms.TextBox();
            this.guardadodeLineas = new System.Windows.Forms.ListBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelCierreyMinimizado = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRetorno = new System.Windows.Forms.Panel();
            this.retornarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selecciondeTema = new System.Windows.Forms.ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.ingresodeDatos = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelCierreyMinimizado.SuspendLayout();
            this.panelRetorno.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuadrodeTexto
            // 
            this.cuadrodeTexto.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadrodeTexto.Location = new System.Drawing.Point(45, 81);
            this.cuadrodeTexto.Name = "cuadrodeTexto";
            this.cuadrodeTexto.Size = new System.Drawing.Size(188, 26);
            this.cuadrodeTexto.TabIndex = 4;
            // 
            // guardadodeLineas
            // 
            this.guardadodeLineas.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardadodeLineas.FormattingEnabled = true;
            this.guardadodeLineas.ItemHeight = 20;
            this.guardadodeLineas.Location = new System.Drawing.Point(319, 32);
            this.guardadodeLineas.Name = "guardadodeLineas";
            this.guardadodeLineas.Size = new System.Drawing.Size(444, 224);
            this.guardadodeLineas.TabIndex = 3;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelCierreyMinimizado);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.panelRetorno);
            this.panelPrincipal.Controls.Add(this.selecciondeTema);
            this.panelPrincipal.Controls.Add(this.panelBotones);
            this.panelPrincipal.Location = new System.Drawing.Point(-1, 1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(808, 437);
            this.panelPrincipal.TabIndex = 8;
            // 
            // panelCierreyMinimizado
            // 
            this.panelCierreyMinimizado.Controls.Add(this.btnCerrar);
            this.panelCierreyMinimizado.Controls.Add(this.btnMinimizar);
            this.panelCierreyMinimizado.Location = new System.Drawing.Point(715, 11);
            this.panelCierreyMinimizado.Name = "panelCierreyMinimizado";
            this.panelCierreyMinimizado.Size = new System.Drawing.Size(74, 36);
            this.panelCierreyMinimizado.TabIndex = 21;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Palabras Palíndromas";
            // 
            // panelRetorno
            // 
            this.panelRetorno.Controls.Add(this.retornarBTN);
            this.panelRetorno.Controls.Add(this.label1);
            this.panelRetorno.Location = new System.Drawing.Point(576, 372);
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
            // selecciondeTema
            // 
            this.selecciondeTema.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecciondeTema.FormattingEnabled = true;
            this.selecciondeTema.Items.AddRange(new object[] {
            "Oscuro",
            "Azul",
            "Rojo",
            "Morado"});
            this.selecciondeTema.Location = new System.Drawing.Point(13, 19);
            this.selecciondeTema.Name = "selecciondeTema";
            this.selecciondeTema.Size = new System.Drawing.Size(186, 28);
            this.selecciondeTema.TabIndex = 7;
            this.selecciondeTema.Text = "Seleccione un Tema";
            this.selecciondeTema.SelectedIndexChanged += new System.EventHandler(this.selecciondeTema_SelectedIndexChanged);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.ingresodeDatos);
            this.panelBotones.Controls.Add(this.cuadrodeTexto);
            this.panelBotones.Controls.Add(this.guardadodeLineas);
            this.panelBotones.Location = new System.Drawing.Point(13, 70);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(776, 286);
            this.panelBotones.TabIndex = 6;
            // 
            // ingresodeDatos
            // 
            this.ingresodeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresodeDatos.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresodeDatos.Location = new System.Drawing.Point(63, 113);
            this.ingresodeDatos.Name = "ingresodeDatos";
            this.ingresodeDatos.Size = new System.Drawing.Size(150, 39);
            this.ingresodeDatos.TabIndex = 5;
            this.ingresodeDatos.Text = "Ingresar";
            this.ingresodeDatos.UseVisualStyleBackColor = true;
            this.ingresodeDatos.Click += new System.EventHandler(this.ingresodeDatos_Click);
            // 
            // Palindromas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 429);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Palindromas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palindromas";
            this.Load += new System.EventHandler(this.Palindromas_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelCierreyMinimizado.ResumeLayout(false);
            this.panelRetorno.ResumeLayout(false);
            this.panelRetorno.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox cuadrodeTexto;
        private System.Windows.Forms.ListBox guardadodeLineas;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCierreyMinimizado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRetorno;
        private System.Windows.Forms.Button retornarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selecciondeTema;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button ingresodeDatos;
    }
}