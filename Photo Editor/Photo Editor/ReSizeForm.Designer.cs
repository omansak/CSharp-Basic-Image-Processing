namespace Photo_Editor
{
    partial class ReSizeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ratioBox = new System.Windows.Forms.GroupBox();
            this.valueBox = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.heightValue = new System.Windows.Forms.TextBox();
            this.widthValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightBar = new System.Windows.Forms.TrackBar();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.reSizeBtn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.ratioBox.SuspendLayout();
            this.valueBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueBox);
            this.groupBox1.Controls.Add(this.ratioBox);
            this.groupBox1.Controls.Add(this.reSizeBtn);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ölçekler";
            // 
            // ratioBox
            // 
            this.ratioBox.Controls.Add(this.checkBox1);
            this.ratioBox.Controls.Add(this.label4);
            this.ratioBox.Controls.Add(this.label3);
            this.ratioBox.Controls.Add(this.textBox2);
            this.ratioBox.Controls.Add(this.textBox1);
            this.ratioBox.Controls.Add(this.label2);
            this.ratioBox.Controls.Add(this.label1);
            this.ratioBox.Controls.Add(this.heightBar);
            this.ratioBox.Controls.Add(this.widthBar);
            this.ratioBox.Location = new System.Drawing.Point(6, 42);
            this.ratioBox.Name = "ratioBox";
            this.ratioBox.Size = new System.Drawing.Size(278, 178);
            this.ratioBox.TabIndex = 7;
            this.ratioBox.TabStop = false;
            this.ratioBox.Visible = false;
            // 
            // valueBox
            // 
            this.valueBox.Controls.Add(this.checkBox2);
            this.valueBox.Controls.Add(this.label5);
            this.valueBox.Controls.Add(this.label6);
            this.valueBox.Controls.Add(this.heightValue);
            this.valueBox.Controls.Add(this.widthValue);
            this.valueBox.Controls.Add(this.label7);
            this.valueBox.Controls.Add(this.label8);
            this.valueBox.Location = new System.Drawing.Point(6, 42);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(278, 178);
            this.valueBox.TabIndex = 20;
            this.valueBox.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(9, 148);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Benzer Orantı";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "px";
            // 
            // heightValue
            // 
            this.heightValue.Location = new System.Drawing.Point(9, 97);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(165, 20);
            this.heightValue.TabIndex = 16;
            this.heightValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heightValue.TextChanged += new System.EventHandler(this.heightValue_TextChanged);
            // 
            // widthValue
            // 
            this.widthValue.Location = new System.Drawing.Point(9, 35);
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(165, 20);
            this.widthValue.TabIndex = 15;
            this.widthValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthValue.TextChanged += new System.EventHandler(this.widthValue_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yükseklik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Genişlik";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Benzer Orantı";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "%";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Yükseklik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Genişlik";
            // 
            // heightBar
            // 
            this.heightBar.Location = new System.Drawing.Point(6, 97);
            this.heightBar.Name = "heightBar";
            this.heightBar.Size = new System.Drawing.Size(180, 45);
            this.heightBar.TabIndex = 12;
            this.heightBar.Scroll += new System.EventHandler(this.heightBar_Scroll);
            // 
            // widthBar
            // 
            this.widthBar.Location = new System.Drawing.Point(6, 32);
            this.widthBar.Name = "widthBar";
            this.widthBar.Size = new System.Drawing.Size(180, 45);
            this.widthBar.TabIndex = 11;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // reSizeBtn
            // 
            this.reSizeBtn.Location = new System.Drawing.Point(77, 232);
            this.reSizeBtn.Name = "reSizeBtn";
            this.reSizeBtn.Size = new System.Drawing.Size(115, 37);
            this.reSizeBtn.TabIndex = 6;
            this.reSizeBtn.Text = "Boyutlandır";
            this.reSizeBtn.UseVisualStyleBackColor = true;
            this.reSizeBtn.Click += new System.EventHandler(this.reSizeBtn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Değer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Oran";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ReSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReSizeForm";
            this.Text = "ReSizeForm";
            this.Load += new System.EventHandler(this.ReSizeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ratioBox.ResumeLayout(false);
            this.ratioBox.PerformLayout();
            this.valueBox.ResumeLayout(false);
            this.valueBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox valueBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox ratioBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar heightBar;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heightValue;
        private System.Windows.Forms.TextBox widthValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reSizeBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}