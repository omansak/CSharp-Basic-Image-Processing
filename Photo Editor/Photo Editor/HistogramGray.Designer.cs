namespace Photo_Editor
{
    partial class HistogramGray
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
            this.grayBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grayBox
            // 
            this.grayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayBox.Location = new System.Drawing.Point(0, 0);
            this.grayBox.Name = "grayBox";
            this.grayBox.Size = new System.Drawing.Size(400, 342);
            this.grayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grayBox.TabIndex = 0;
            this.grayBox.TabStop = false;
            // 
            // HistogramGray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 342);
            this.Controls.Add(this.grayBox);
            this.Name = "HistogramGray";
            this.Text = "HistogramGray";
            this.Load += new System.EventHandler(this.HistogramGray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grayBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox grayBox;
    }
}