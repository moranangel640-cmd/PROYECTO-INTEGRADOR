namespace PROYECTO_INTEGRADOR
{
    partial class Form7
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
            this.amaz = new System.Windows.Forms.PictureBox();
            this.sierra = new System.Windows.Forms.PictureBox();
            this.costa = new System.Windows.Forms.PictureBox();
            this.panelAmaz = new System.Windows.Forms.Panel();
            this.panelSierra = new System.Windows.Forms.Panel();
            this.panelCosta = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.amaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sierra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // amaz
            // 
            this.amaz.BackColor = System.Drawing.Color.White;
            this.amaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amaz.Image = global::PROYECTO_INTEGRADOR.Properties.Resources.amazoniaB;
            this.amaz.Location = new System.Drawing.Point(733, 28);
            this.amaz.Name = "amaz";
            this.amaz.Size = new System.Drawing.Size(251, 361);
            this.amaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amaz.TabIndex = 0;
            this.amaz.TabStop = false;
            this.amaz.Click += new System.EventHandler(this.amaz_Click);
            this.amaz.MouseEnter += new System.EventHandler(this.pBmouseEnter);
            this.amaz.MouseLeave += new System.EventHandler(this.pBmouseLeave);
            // 
            // sierra
            // 
            this.sierra.BackColor = System.Drawing.Color.White;
            this.sierra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sierra.Image = global::PROYECTO_INTEGRADOR.Properties.Resources.sierraB;
            this.sierra.Location = new System.Drawing.Point(559, 96);
            this.sierra.Name = "sierra";
            this.sierra.Size = new System.Drawing.Size(168, 395);
            this.sierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sierra.TabIndex = 1;
            this.sierra.TabStop = false;
            this.sierra.Click += new System.EventHandler(this.sierra_Click);
            this.sierra.MouseEnter += new System.EventHandler(this.pBmouseEnter);
            this.sierra.MouseLeave += new System.EventHandler(this.pBmouseLeave);
            // 
            // costa
            // 
            this.costa.BackColor = System.Drawing.Color.White;
            this.costa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costa.Image = global::PROYECTO_INTEGRADOR.Properties.Resources.costaB;
            this.costa.Location = new System.Drawing.Point(400, 212);
            this.costa.Name = "costa";
            this.costa.Size = new System.Drawing.Size(153, 379);
            this.costa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.costa.TabIndex = 2;
            this.costa.TabStop = false;
            this.costa.Click += new System.EventHandler(this.costa_Click);
            this.costa.MouseEnter += new System.EventHandler(this.pBmouseEnter);
            this.costa.MouseLeave += new System.EventHandler(this.pBmouseLeave);
            // 
            // panelAmaz
            // 
            this.panelAmaz.Location = new System.Drawing.Point(35, 46);
            this.panelAmaz.Name = "panelAmaz";
            this.panelAmaz.Size = new System.Drawing.Size(302, 148);
            this.panelAmaz.TabIndex = 3;
            this.panelAmaz.Visible = false;
            // 
            // panelSierra
            // 
            this.panelSierra.Location = new System.Drawing.Point(39, 219);
            this.panelSierra.Name = "panelSierra";
            this.panelSierra.Size = new System.Drawing.Size(298, 146);
            this.panelSierra.TabIndex = 4;
            this.panelSierra.Visible = false;
            // 
            // panelCosta
            // 
            this.panelCosta.Location = new System.Drawing.Point(39, 389);
            this.panelCosta.Name = "panelCosta";
            this.panelCosta.Size = new System.Drawing.Size(298, 137);
            this.panelCosta.TabIndex = 5;
            this.panelCosta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PROYECTO_INTEGRADOR.Properties.Resources.flechaBack2;
            this.pictureBox1.Location = new System.Drawing.Point(909, 530);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_INTEGRADOR.Properties.Resources.Diseño_sin_título;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelCosta);
            this.Controls.Add(this.panelSierra);
            this.Controls.Add(this.panelAmaz);
            this.Controls.Add(this.costa);
            this.Controls.Add(this.sierra);
            this.Controls.Add(this.amaz);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.amaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sierra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox amaz;
        private System.Windows.Forms.PictureBox sierra;
        private System.Windows.Forms.PictureBox costa;
        private System.Windows.Forms.Panel panelAmaz;
        private System.Windows.Forms.Panel panelSierra;
        private System.Windows.Forms.Panel panelCosta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}