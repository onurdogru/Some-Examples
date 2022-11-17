namespace WFA_TopSektirme
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
            this.components = new System.ComponentModel.Container();
            this.pBTOPP = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBTOPP)).BeginInit();
            this.SuspendLayout();
            // 
            // pBTOPP
            // 
            this.pBTOPP.BackColor = System.Drawing.Color.Transparent;
            this.pBTOPP.Image = global::WFA_TopSektirme.Properties.Resources.TOPPP;
            this.pBTOPP.Location = new System.Drawing.Point(621, 363);
            this.pBTOPP.Name = "pBTOPP";
            this.pBTOPP.Size = new System.Drawing.Size(131, 106);
            this.pBTOPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBTOPP.TabIndex = 2;
            this.pBTOPP.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 832);
            this.Controls.Add(this.pBTOPP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBTOPP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBTOPP;
        private System.Windows.Forms.Timer timer1;
    }
}