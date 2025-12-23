namespace PROYECTO_INTEGRADOR
{
    partial class info3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info3));
            this.info3titulo = new System.Windows.Forms.Label();
            this.Penicilina = new System.Windows.Forms.Button();
            this.panelpeni = new System.Windows.Forms.Panel();
            this.richpeni = new System.Windows.Forms.RichTextBox();
            this.panelpeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // info3titulo
            // 
            this.info3titulo.AutoSize = true;
            this.info3titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3titulo.Location = new System.Drawing.Point(142, 32);
            this.info3titulo.Name = "info3titulo";
            this.info3titulo.Size = new System.Drawing.Size(236, 16);
            this.info3titulo.TabIndex = 0;
            this.info3titulo.Text = "TRATAMIENTO PARA LA SIFILIS";
            // 
            // Penicilina
            // 
            this.Penicilina.Location = new System.Drawing.Point(66, 128);
            this.Penicilina.Name = "Penicilina";
            this.Penicilina.Size = new System.Drawing.Size(75, 30);
            this.Penicilina.TabIndex = 1;
            this.Penicilina.Text = "Penicilina";
            this.Penicilina.UseVisualStyleBackColor = true;
            this.Penicilina.Click += new System.EventHandler(this.Penicilina_Click);
            // 
            // panelpeni
            // 
            this.panelpeni.Controls.Add(this.richpeni);
            this.panelpeni.Location = new System.Drawing.Point(176, 101);
            this.panelpeni.Name = "panelpeni";
            this.panelpeni.Size = new System.Drawing.Size(310, 100);
            this.panelpeni.TabIndex = 2;
            this.panelpeni.Visible = false;
            // 
            // richpeni
            // 
            this.richpeni.Location = new System.Drawing.Point(3, 4);
            this.richpeni.Name = "richpeni";
            this.richpeni.Size = new System.Drawing.Size(304, 96);
            this.richpeni.TabIndex = 0;
            this.richpeni.Text = resources.GetString("richpeni.Text");
            // 
            // info3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.panelpeni);
            this.Controls.Add(this.Penicilina);
            this.Controls.Add(this.info3titulo);
            this.Name = "info3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIFILIS";
            this.panelpeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info3titulo;
        private System.Windows.Forms.Button Penicilina;
        private System.Windows.Forms.Panel panelpeni;
        private System.Windows.Forms.RichTextBox richpeni;
    }
}