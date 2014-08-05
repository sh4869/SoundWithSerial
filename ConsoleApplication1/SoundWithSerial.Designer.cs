namespace ConsoleApplication1
{
    partial class SoundWithSerial
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
            this.SerialPortCom = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoudRateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SerialPortCom
            // 
            this.SerialPortCom.Location = new System.Drawing.Point(80, 32);
            this.SerialPortCom.Name = "SerialPortCom";
            this.SerialPortCom.Size = new System.Drawing.Size(100, 19);
            this.SerialPortCom.TabIndex = 0;
            this.SerialPortCom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(29, 226);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "BoudRate";
            // 
            // BoudRateBox
            // 
            this.BoudRateBox.Location = new System.Drawing.Point(80, 65);
            this.BoudRateBox.Name = "BoudRateBox";
            this.BoudRateBox.Size = new System.Drawing.Size(100, 19);
            this.BoudRateBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ReadTime";
            // 
            // ReadTimeBox
            // 
            this.ReadTimeBox.Location = new System.Drawing.Point(80, 104);
            this.ReadTimeBox.Name = "ReadTimeBox";
            this.ReadTimeBox.Size = new System.Drawing.Size(100, 19);
            this.ReadTimeBox.TabIndex = 7;
            // 
            // SoundWithSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 191);
            this.Controls.Add(this.ReadTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoudRateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SerialPortCom);
            this.Name = "SoundWithSerial";
            this.Text = "SoundWithSerial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SerialPortCom;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoudRateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReadTimeBox;

    }
}