namespace PROYECTO_INTEGRADOR
{
    partial class Form3
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
            this.Titulo1 = new System.Windows.Forms.Label();
            this.enfermedadespanel = new System.Windows.Forms.Panel();
            this.Titulo3 = new System.Windows.Forms.Label();
            this.Comboboxenfer = new System.Windows.Forms.ComboBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.Informacionrichtext = new System.Windows.Forms.RichTextBox();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.sabiasq = new System.Windows.Forms.Label();
            this.infosabias = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.enfermedadespanel.SuspendLayout();
            this.infopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.Location = new System.Drawing.Point(293, 36);
            this.Titulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(186, 28);
            this.Titulo1.TabIndex = 1;
            this.Titulo1.Text = "ENFERMEDADES ETS";
            this.Titulo1.Click += new System.EventHandler(this.Titulo1_Click);
            // 
            // enfermedadespanel
            // 
            this.enfermedadespanel.BackColor = System.Drawing.Color.Transparent;
            this.enfermedadespanel.Controls.Add(this.Titulo3);
            this.enfermedadespanel.Controls.Add(this.Comboboxenfer);
            this.enfermedadespanel.Location = new System.Drawing.Point(1, 180);
            this.enfermedadespanel.Margin = new System.Windows.Forms.Padding(2);
            this.enfermedadespanel.Name = "enfermedadespanel";
            this.enfermedadespanel.Size = new System.Drawing.Size(240, 310);
            this.enfermedadespanel.TabIndex = 2;
            // 
            // Titulo3
            // 
            this.Titulo3.AutoSize = true;
            this.Titulo3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo3.Location = new System.Drawing.Point(4, 20);
            this.Titulo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.Size = new System.Drawing.Size(257, 25);
            this.Titulo3.TabIndex = 1;
            this.Titulo3.Text = "Seleccione una enfermedad";
            // 
            // Comboboxenfer
            // 
            this.Comboboxenfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comboboxenfer.FormattingEnabled = true;
            this.Comboboxenfer.Items.AddRange(new object[] {
            "🦠 VIH/SIDA",
            "🦠 GONORREA",
            "🦠 SÍFILIS",
            "🦠 HERPES",
            "🦠 VPH"});
            this.Comboboxenfer.Location = new System.Drawing.Point(8, 48);
            this.Comboboxenfer.Margin = new System.Windows.Forms.Padding(2);
            this.Comboboxenfer.Name = "Comboboxenfer";
            this.Comboboxenfer.Size = new System.Drawing.Size(205, 21);
            this.Comboboxenfer.TabIndex = 0;
            this.Comboboxenfer.SelectedIndexChanged += new System.EventHandler(this.Comboboxenfer_SelectedIndexChanged);
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.SystemColors.Control;
            this.infopanel.Controls.Add(this.Informacionrichtext);
            this.infopanel.Controls.Add(this.Titulo2);
            this.infopanel.Location = new System.Drawing.Point(245, 180);
            this.infopanel.Margin = new System.Windows.Forms.Padding(2);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(336, 310);
            this.infopanel.TabIndex = 3;
            // 
            // Informacionrichtext
            // 
            this.Informacionrichtext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacionrichtext.Location = new System.Drawing.Point(2, 48);
            this.Informacionrichtext.Margin = new System.Windows.Forms.Padding(2);
            this.Informacionrichtext.Name = "Informacionrichtext";
            this.Informacionrichtext.ReadOnly = true;
            this.Informacionrichtext.Size = new System.Drawing.Size(325, 262);
            this.Informacionrichtext.TabIndex = 1;
            this.Informacionrichtext.Text = "";
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2.Location = new System.Drawing.Point(89, 10);
            this.Titulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(138, 30);
            this.Titulo2.TabIndex = 0;
            this.Titulo2.Text = "Informacion";
            this.Titulo2.Click += new System.EventHandler(this.Titulo2_Click);
            // 
            // sabiasq
            // 
            this.sabiasq.AutoSize = true;
            this.sabiasq.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabiasq.Location = new System.Drawing.Point(627, 196);
            this.sabiasq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sabiasq.Name = "sabiasq";
            this.sabiasq.Size = new System.Drawing.Size(123, 25);
            this.sabiasq.TabIndex = 4;
            this.sabiasq.Text = "¿Sabias que?";
            // 
            // infosabias
            // 
            this.infosabias.AutoSize = true;
            this.infosabias.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosabias.Location = new System.Drawing.Point(586, 231);
            this.infosabias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infosabias.Name = "infosabias";
            this.infosabias.Size = new System.Drawing.Size(199, 133);
            this.infosabias.TabIndex = 5;
            this.infosabias.Text = "El condon protege SOLO \r\nPARCIALMENTE contra el VPH\r\nAunque reduce el riesgo del\r" +
    "\npapiloma humano puede \r\ntransmitirse por contacto piel \r\ncon piel en areas NO c" +
    "ubiertas \r\npor el preservativo.\r\n";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = global::PROYECTO_INTEGRADOR.Properties.Resources.flechaBack2;
            this.back.Location = new System.Drawing.Point(21, 18);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 60);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 6;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_INTEGRADOR.Properties.Resources.Diseño_sin_título;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.back);
            this.Controls.Add(this.infosabias);
            this.Controls.Add(this.sabiasq);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.enfermedadespanel);
            this.Controls.Add(this.Titulo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.enfermedadespanel.ResumeLayout(false);
            this.enfermedadespanel.PerformLayout();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Panel enfermedadespanel;
        private System.Windows.Forms.ComboBox Comboboxenfer;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label Titulo2;
        private System.Windows.Forms.RichTextBox Informacionrichtext;
        private System.Windows.Forms.Label Titulo3;
        private System.Windows.Forms.Label sabiasq;
        private System.Windows.Forms.Label infosabias;
        private System.Windows.Forms.PictureBox back;
    }
}