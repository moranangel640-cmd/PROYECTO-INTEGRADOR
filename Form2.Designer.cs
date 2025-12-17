namespace PROYECTO_INTEGRADOR
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Regreso = new System.Windows.Forms.Button();
            this.Bienve = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regreso
            // 
            this.Regreso.BackColor = System.Drawing.Color.Transparent;
            this.Regreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Regreso.BackgroundImage")));
            this.Regreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regreso.FlatAppearance.BorderSize = 0;
            this.Regreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Regreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regreso.Location = new System.Drawing.Point(12, 520);
            this.Regreso.Name = "Regreso";
            this.Regreso.Size = new System.Drawing.Size(96, 71);
            this.Regreso.TabIndex = 0;
            this.Regreso.UseVisualStyleBackColor = false;
            this.Regreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bienve
            // 
            this.Bienve.AutoSize = true;
            this.Bienve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienve.Location = new System.Drawing.Point(12, 9);
            this.Bienve.Name = "Bienve";
            this.Bienve.Size = new System.Drawing.Size(151, 29);
            this.Bienve.TabIndex = 1;
            this.Bienve.Text = "Bienvenido:\r\n";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(157, 9);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(20, 29);
            this.usuario.TabIndex = 2;
            this.usuario.Text = ".";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.Bienve);
            this.Controls.Add(this.Regreso);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regreso;
        private System.Windows.Forms.Label Bienve;
        private System.Windows.Forms.Label usuario;
    }
}