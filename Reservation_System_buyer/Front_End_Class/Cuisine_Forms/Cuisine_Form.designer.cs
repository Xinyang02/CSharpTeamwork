namespace Front_End_Class
{
    partial class Cuisine_Form
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
            this.pnlShowCuisine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlShowCuisine
            // 
            this.pnlShowCuisine.AutoScroll = true;
            this.pnlShowCuisine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlShowCuisine.Location = new System.Drawing.Point(0, 0);
            this.pnlShowCuisine.Margin = new System.Windows.Forms.Padding(0);
            this.pnlShowCuisine.Name = "pnlShowCuisine";
            this.pnlShowCuisine.Size = new System.Drawing.Size(1000, 670);
            this.pnlShowCuisine.TabIndex = 0;
            this.pnlShowCuisine.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShowCuisine_Paint);
            // 
            // Cuisine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnlShowCuisine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuisine_Form";
            this.Text = "Cuisine";
            this.Load += new System.EventHandler(this.CuisineForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowCuisine;
    }
}