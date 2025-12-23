namespace PROYECTO_INTEGRADOR
{
    partial class info2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info2));
            this.info2titulo = new System.Windows.Forms.Label();
            this.info2desc = new System.Windows.Forms.Label();
            this.Ceftriaxona = new System.Windows.Forms.Button();
            this.panelceft = new System.Windows.Forms.Panel();
            this.richceft = new System.Windows.Forms.RichTextBox();
            this.panelceft.SuspendLayout();
            this.SuspendLayout();
            // 
            // info2titulo
            // 
            this.info2titulo.AutoSize = true;
            this.info2titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2titulo.Location = new System.Drawing.Point(165, 31);
            this.info2titulo.Name = "info2titulo";
            this.info2titulo.Size = new System.Drawing.Size(273, 16);
            this.info2titulo.TabIndex = 0;
            this.info2titulo.Text = "TRATAMIENTO PARA LA GONORREA";
            // 
            // info2desc
            // 
            this.info2desc.AutoSize = true;
            this.info2desc.Location = new System.Drawing.Point(61, 63);
            this.info2desc.Name = "info2desc";
            this.info2desc.Size = new System.Drawing.Size(480, 52);
            this.info2desc.TabIndex = 1;
            this.info2desc.Text = resources.GetString("info2desc.Text");
            // 
            // Ceftriaxona
            // 
            this.Ceftriaxona.Location = new System.Drawing.Point(72, 154);
            this.Ceftriaxona.Name = "Ceftriaxona";
            this.Ceftriaxona.Size = new System.Drawing.Size(83, 46);
            this.Ceftriaxona.TabIndex = 2;
            this.Ceftriaxona.Text = "Ceftriaxona";
            this.Ceftriaxona.UseVisualStyleBackColor = true;
            this.Ceftriaxona.Click += new System.EventHandler(this.Ceftriaxona_Click);
            // 
            // panelceft
            // 
            this.panelceft.Controls.Add(this.richceft);
            this.panelceft.Location = new System.Drawing.Point(205, 151);
            this.panelceft.Name = "panelceft";
            this.panelceft.Size = new System.Drawing.Size(336, 49);
            this.panelceft.TabIndex = 3;
            this.panelceft.Visible = false;
            // 
            // richceft
            // 
            this.richceft.Location = new System.Drawing.Point(6, 0);
            this.richceft.Name = "richceft";
            this.richceft.Size = new System.Drawing.Size(327, 50);
            this.richceft.TabIndex = 0;
            this.richceft.Text = "Este ejerce su efecto antibiótico al inhibir la pared celular de la bacteria gono" +
    "rrea, aunque su uso puede ocasionar reacciones alérgicas o dolor abdominal.";
            // 
            // info2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 250);
            this.Controls.Add(this.panelceft);
            this.Controls.Add(this.Ceftriaxona);
            this.Controls.Add(this.info2desc);
            this.Controls.Add(this.info2titulo);
            this.Name = "info2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GONORREA";
            this.panelceft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info2titulo;
        private System.Windows.Forms.Label info2desc;
        private System.Windows.Forms.Button Ceftriaxona;
        private System.Windows.Forms.Panel panelceft;
        private System.Windows.Forms.RichTextBox richceft;
    }
}