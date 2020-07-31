namespace EjemploMenuEjerciciosCondiciones
{
    partial class Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnevaluar = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.pbsalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evalúa si un número es positivo o negativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa un número";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(393, 158);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 80);
            this.txtnumero.TabIndex = 3;
            // 
            // btnevaluar
            // 
            this.btnevaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnevaluar.Location = new System.Drawing.Point(540, 158);
            this.btnevaluar.Name = "btnevaluar";
            this.btnevaluar.Size = new System.Drawing.Size(192, 80);
            this.btnevaluar.TabIndex = 4;
            this.btnevaluar.Text = "Evaluar";
            this.btnevaluar.UseVisualStyleBackColor = true;
            this.btnevaluar.Click += new System.EventHandler(this.btnevaluar_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(261, 321);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(268, 56);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta";
            this.lblrespuesta.Visible = false;
            // 
            // pbsalir
            // 
            this.pbsalir.Image = global::EjemploMenuEjerciciosCondiciones.Properties.Resources.salir;
            this.pbsalir.Location = new System.Drawing.Point(688, 12);
            this.pbsalir.Name = "pbsalir";
            this.pbsalir.Size = new System.Drawing.Size(100, 99);
            this.pbsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalir.TabIndex = 6;
            this.pbsalir.TabStop = false;
            this.pbsalir.Click += new System.EventHandler(this.pbsalir_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbsalir);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btnevaluar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnevaluar;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.PictureBox pbsalir;
    }
}