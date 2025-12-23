namespace PROYECTO_INTEGRADOR
{
    partial class info5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info5));
            this.info5titulo = new System.Windows.Forms.Label();
            this.richVPH = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // info5titulo
            // 
            this.info5titulo.AutoSize = true;
            this.info5titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info5titulo.Location = new System.Drawing.Point(127, 35);
            this.info5titulo.Name = "info5titulo";
            this.info5titulo.Size = new System.Drawing.Size(218, 16);
            this.info5titulo.TabIndex = 0;
            this.info5titulo.Text = "TRATAMIENTO PARA EL VPH";
            // 
            // richVPH
            // 
            this.richVPH.Location = new System.Drawing.Point(114, 78);
            this.richVPH.Name = "richVPH";
            this.richVPH.Size = new System.Drawing.Size(306, 96);
            this.richVPH.TabIndex = 1;
            this.richVPH.Text = resources.GetString("richVPH.Text");
            // 
            // info5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 250);
            this.Controls.Add(this.richVPH);
            this.Controls.Add(this.info5titulo);
            this.Name = "info5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info5titulo;
        private System.Windows.Forms.RichTextBox richVPH;
    }
}