namespace WeatherApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.labWind = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Location = new System.Drawing.Point(96, 180);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(67, 13);
            this.labTemp.TabIndex = 1;
            this.labTemp.Text = "Temperature";
            // 
            // labWind
            // 
            this.labWind.AutoSize = true;
            this.labWind.Location = new System.Drawing.Point(93, 217);
            this.labWind.Name = "labWind";
            this.labWind.Size = new System.Drawing.Size(66, 13);
            this.labWind.TabIndex = 2;
            this.labWind.Text = "Wind Speed";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.Location = new System.Drawing.Point(99, 258);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(51, 13);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.labWind);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labWind;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.TextBox textBox1;
    }
}

