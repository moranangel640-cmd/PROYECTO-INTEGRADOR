namespace PROYECTO_INTEGRADOR
{
    partial class Form4
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
            this.btnSube = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.verLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSube
            // 
            this.btnSube.Location = new System.Drawing.Point(557, 110);
            this.btnSube.Name = "btnSube";
            this.btnSube.Size = new System.Drawing.Size(122, 42);
            this.btnSube.TabIndex = 0;
            this.btnSube.Text = "button1";
            this.btnSube.UseVisualStyleBackColor = true;
            this.btnSube.Click += new System.EventHandler(this.btnSube_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(563, 196);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(115, 39);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "button2";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(155, 117);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(44, 16);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "label1";
            // 
            // verLog
            // 
            this.verLog.Location = new System.Drawing.Point(570, 302);
            this.verLog.Name = "verLog";
            this.verLog.Size = new System.Drawing.Size(107, 44);
            this.verLog.TabIndex = 3;
            this.verLog.Text = "button1";
            this.verLog.UseVisualStyleBackColor = true;
            this.verLog.Click += new System.EventHandler(this.verLog_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verLog);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnSube);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSube;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button verLog;
    }
}