namespace OdevAsal00
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asal Sayı Mı ?";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(337, 183);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(216, 22);
            this.numericUpDown.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(353, 342);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 51);
            this.label.TabIndex = 2;
            this.label.Text = "Şu Sayı";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(429, 432);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(0, 54);
            this.label_number.TabIndex = 3;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(330, 522);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 38);
            this.label_result.TabIndex = 4;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_check.Location = new System.Drawing.Point(362, 251);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(142, 46);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "Kontrol Et";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Asal Sayı Mıdır ?";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_check;
    }
}

