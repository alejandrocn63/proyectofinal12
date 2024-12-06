namespace proyectofinal12
{
    partial class Confirmado1
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
            this.comfimacionpedido = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.comfimacionpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // comfimacionpedido
            // 
            this.comfimacionpedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comfimacionpedido.Image = global::proyectofinal12.Properties.Resources._checked;
            this.comfimacionpedido.ImageRotate = 0F;
            this.comfimacionpedido.Location = new System.Drawing.Point(145, 81);
            this.comfimacionpedido.Name = "comfimacionpedido";
            this.comfimacionpedido.Size = new System.Drawing.Size(920, 672);
            this.comfimacionpedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comfimacionpedido.TabIndex = 0;
            this.comfimacionpedido.TabStop = false;
            // 
            // Confirmado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 834);
            this.Controls.Add(this.comfimacionpedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmado1";
            this.Text = "Confirmado1";
            ((System.ComponentModel.ISupportInitialize)(this.comfimacionpedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox comfimacionpedido;
    }
}