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
            this.back = new System.Windows.Forms.Button();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.enfermedadespanel = new System.Windows.Forms.Panel();
            this.Titulo3 = new System.Windows.Forms.Label();
            this.Comboboxenfer = new System.Windows.Forms.ComboBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.Informacionrichtext = new System.Windows.Forms.RichTextBox();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.sabiasq = new System.Windows.Forms.Label();
            this.infosabias = new System.Windows.Forms.Label();
            this.enfermedadespanel.SuspendLayout();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 67);
            this.back.TabIndex = 0;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.Location = new System.Drawing.Point(388, 48);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(236, 31);
            this.Titulo1.TabIndex = 1;
            this.Titulo1.Text = "ENFERMEDADES ETS";
            // 
            // enfermedadespanel
            // 
            this.enfermedadespanel.Controls.Add(this.Titulo3);
            this.enfermedadespanel.Controls.Add(this.Comboboxenfer);
            this.enfermedadespanel.Location = new System.Drawing.Point(1, 222);
            this.enfermedadespanel.Name = "enfermedadespanel";
            this.enfermedadespanel.Size = new System.Drawing.Size(320, 382);
            this.enfermedadespanel.TabIndex = 2;
            // 
            // Titulo3
            // 
            this.Titulo3.AutoSize = true;
            this.Titulo3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo3.Location = new System.Drawing.Point(5, 25);
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.Size = new System.Drawing.Size(308, 31);
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
            this.Comboboxenfer.Location = new System.Drawing.Point(11, 59);
            this.Comboboxenfer.Name = "Comboboxenfer";
            this.Comboboxenfer.Size = new System.Drawing.Size(272, 24);
            this.Comboboxenfer.TabIndex = 0;
            this.Comboboxenfer.SelectedIndexChanged += new System.EventHandler(this.Comboboxenfer_SelectedIndexChanged);
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.Informacionrichtext);
            this.infopanel.Controls.Add(this.Titulo2);
            this.infopanel.Location = new System.Drawing.Point(327, 222);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(448, 382);
            this.infopanel.TabIndex = 3;
            // 
            // Informacionrichtext
            // 
            this.Informacionrichtext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacionrichtext.Location = new System.Drawing.Point(3, 59);
            this.Informacionrichtext.Name = "Informacionrichtext";
            this.Informacionrichtext.ReadOnly = true;
            this.Informacionrichtext.Size = new System.Drawing.Size(432, 322);
            this.Informacionrichtext.TabIndex = 1;
            this.Informacionrichtext.Text = "";
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2.Location = new System.Drawing.Point(119, 12);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(178, 38);
            this.Titulo2.TabIndex = 0;
            this.Titulo2.Text = "Informacion";
            this.Titulo2.Click += new System.EventHandler(this.Titulo2_Click);
            // 
            // sabiasq
            // 
            this.sabiasq.AutoSize = true;
            this.sabiasq.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabiasq.Location = new System.Drawing.Point(836, 241);
            this.sabiasq.Name = "sabiasq";
            this.sabiasq.Size = new System.Drawing.Size(148, 31);
            this.sabiasq.TabIndex = 4;
            this.sabiasq.Text = "¿Sabias que?";
            // 
            // infosabias
            // 
            this.infosabias.AutoSize = true;
            this.infosabias.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosabias.Location = new System.Drawing.Point(781, 284);
            this.infosabias.Name = "infosabias";
            this.infosabias.Size = new System.Drawing.Size(249, 161);
            this.infosabias.TabIndex = 5;
            this.infosabias.Text = "El condon protege SOLO \r\nPARCIALMENTE contra el VPH\r\nAunque reduce el riesgo del\r" +
    "\npapiloma humano puede \r\ntransmitirse por contacto piel \r\ncon piel en areas NO c" +
    "ubiertas \r\npor el preservativo.\r\n";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.infosabias);
            this.Controls.Add(this.sabiasq);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.enfermedadespanel);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.back);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.enfermedadespanel.ResumeLayout(false);
            this.enfermedadespanel.PerformLayout();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Panel enfermedadespanel;
        private System.Windows.Forms.ComboBox Comboboxenfer;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label Titulo2;
        private System.Windows.Forms.RichTextBox Informacionrichtext;
        private System.Windows.Forms.Label Titulo3;
        private System.Windows.Forms.Label sabiasq;
        private System.Windows.Forms.Label infosabias;
    }
}