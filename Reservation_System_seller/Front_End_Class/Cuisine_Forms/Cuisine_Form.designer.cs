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
            this.pnlShowCuisine.Location = new System.Drawing.Point(5, 5);
            this.pnlShowCuisine.Name = "pnlShowCuisine";
            this.pnlShowCuisine.Size = new System.Drawing.Size(543, 364);
            this.pnlShowCuisine.TabIndex = 0;
            // 
            // Cuisine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 381);
            this.Controls.Add(this.pnlShowCuisine);
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