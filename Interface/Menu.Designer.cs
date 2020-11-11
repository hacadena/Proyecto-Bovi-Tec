namespace Interface
{
    partial class Menu
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
            this.botonBovinos = new System.Windows.Forms.Button();
            this.botonDueños = new System.Windows.Forms.Button();
            this.botonUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaUsuarioMenu = new System.Windows.Forms.TextBox();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.botonPeso = new System.Windows.Forms.Button();
            this.botonProductos = new System.Windows.Forms.Button();
            this.botonTratamientos = new System.Windows.Forms.Button();
            this.botonEnfermedades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonBovinos
            // 
            this.botonBovinos.Location = new System.Drawing.Point(38, 122);
            this.botonBovinos.Name = "botonBovinos";
            this.botonBovinos.Size = new System.Drawing.Size(180, 116);
            this.botonBovinos.TabIndex = 0;
            this.botonBovinos.Text = "Bovinos";
            this.botonBovinos.UseVisualStyleBackColor = true;
            this.botonBovinos.Click += new System.EventHandler(this.botonBovinos_Click);
            // 
            // botonDueños
            // 
            this.botonDueños.Location = new System.Drawing.Point(38, 269);
            this.botonDueños.Name = "botonDueños";
            this.botonDueños.Size = new System.Drawing.Size(180, 116);
            this.botonDueños.TabIndex = 1;
            this.botonDueños.Text = "Dueños";
            this.botonDueños.UseVisualStyleBackColor = true;
            this.botonDueños.Click += new System.EventHandler(this.botonDueños_Click);
            // 
            // botonUsuarios
            // 
            this.botonUsuarios.Location = new System.Drawing.Point(224, 269);
            this.botonUsuarios.Name = "botonUsuarios";
            this.botonUsuarios.Size = new System.Drawing.Size(180, 116);
            this.botonUsuarios.TabIndex = 2;
            this.botonUsuarios.Text = "Usuarios";
            this.botonUsuarios.UseVisualStyleBackColor = true;
            this.botonUsuarios.Click += new System.EventHandler(this.botonUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // cajaUsuarioMenu
            // 
            this.cajaUsuarioMenu.Location = new System.Drawing.Point(354, 61);
            this.cajaUsuarioMenu.Name = "cajaUsuarioMenu";
            this.cajaUsuarioMenu.Size = new System.Drawing.Size(100, 20);
            this.cajaUsuarioMenu.TabIndex = 4;
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Location = new System.Drawing.Point(596, 269);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(180, 116);
            this.botonCerrarSesion.TabIndex = 5;
            this.botonCerrarSesion.Text = "Cerrar Sesion";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // botonPeso
            // 
            this.botonPeso.Location = new System.Drawing.Point(410, 122);
            this.botonPeso.Name = "botonPeso";
            this.botonPeso.Size = new System.Drawing.Size(180, 116);
            this.botonPeso.TabIndex = 6;
            this.botonPeso.Text = "Peso";
            this.botonPeso.UseVisualStyleBackColor = true;
            this.botonPeso.Click += new System.EventHandler(this.botonPeso_Click);
            // 
            // botonProductos
            // 
            this.botonProductos.Location = new System.Drawing.Point(224, 122);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(180, 116);
            this.botonProductos.TabIndex = 7;
            this.botonProductos.Text = "Productos";
            this.botonProductos.UseVisualStyleBackColor = true;
            this.botonProductos.Click += new System.EventHandler(this.botonProductos_Click);
            // 
            // botonTratamientos
            // 
            this.botonTratamientos.Location = new System.Drawing.Point(410, 269);
            this.botonTratamientos.Name = "botonTratamientos";
            this.botonTratamientos.Size = new System.Drawing.Size(180, 116);
            this.botonTratamientos.TabIndex = 8;
            this.botonTratamientos.Text = "Tratamientos";
            this.botonTratamientos.UseVisualStyleBackColor = true;
            this.botonTratamientos.Click += new System.EventHandler(this.botonTratamientos_Click);
            // 
            // botonEnfermedades
            // 
            this.botonEnfermedades.Location = new System.Drawing.Point(596, 122);
            this.botonEnfermedades.Name = "botonEnfermedades";
            this.botonEnfermedades.Size = new System.Drawing.Size(180, 116);
            this.botonEnfermedades.TabIndex = 9;
            this.botonEnfermedades.Text = "Enfermedades";
            this.botonEnfermedades.UseVisualStyleBackColor = true;
            this.botonEnfermedades.Click += new System.EventHandler(this.botonEnfermedades_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEnfermedades);
            this.Controls.Add(this.botonTratamientos);
            this.Controls.Add(this.botonProductos);
            this.Controls.Add(this.botonPeso);
            this.Controls.Add(this.botonCerrarSesion);
            this.Controls.Add(this.cajaUsuarioMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonUsuarios);
            this.Controls.Add(this.botonDueños);
            this.Controls.Add(this.botonBovinos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBovinos;
        private System.Windows.Forms.Button botonDueños;
        private System.Windows.Forms.Button botonUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaUsuarioMenu;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonPeso;
        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Button botonTratamientos;
        private System.Windows.Forms.Button botonEnfermedades;
    }
}