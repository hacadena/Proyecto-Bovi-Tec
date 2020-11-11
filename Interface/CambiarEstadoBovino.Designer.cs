namespace Interface
{
    partial class CambiarEstadoBovino
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
            this.botonCancelarRegistarBovino = new System.Windows.Forms.Button();
            this.botonConfirmarRegistroBovino = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonCancelarRegistarBovino
            // 
            this.botonCancelarRegistarBovino.Location = new System.Drawing.Point(87, 282);
            this.botonCancelarRegistarBovino.Name = "botonCancelarRegistarBovino";
            this.botonCancelarRegistarBovino.Size = new System.Drawing.Size(75, 23);
            this.botonCancelarRegistarBovino.TabIndex = 39;
            this.botonCancelarRegistarBovino.Text = "Cancelar";
            this.botonCancelarRegistarBovino.UseVisualStyleBackColor = true;
            this.botonCancelarRegistarBovino.Click += new System.EventHandler(this.botonCancelarRegistarBovino_Click);
            // 
            // botonConfirmarRegistroBovino
            // 
            this.botonConfirmarRegistroBovino.Location = new System.Drawing.Point(209, 282);
            this.botonConfirmarRegistroBovino.Name = "botonConfirmarRegistroBovino";
            this.botonConfirmarRegistroBovino.Size = new System.Drawing.Size(160, 23);
            this.botonConfirmarRegistroBovino.TabIndex = 38;
            this.botonConfirmarRegistroBovino.Text = "Confirmar Cambio De Estado";
            this.botonConfirmarRegistroBovino.UseVisualStyleBackColor = true;
            this.botonConfirmarRegistroBovino.Click += new System.EventHandler(this.botonConfirmarRegistroBovino_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Identificacion Del Dueño";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo De Bovino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id_Bovino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hurtado",
            "Muerto",
            "Vendido"});
            this.comboBox1.Location = new System.Drawing.Point(210, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // CambiarEstadoBovino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 330);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonCancelarRegistarBovino);
            this.Controls.Add(this.botonConfirmarRegistroBovino);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "CambiarEstadoBovino";
            this.Text = "CambiarEstadoBovino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelarRegistarBovino;
        private System.Windows.Forms.Button botonConfirmarRegistroBovino;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}