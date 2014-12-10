namespace TwoTimesVallueApps
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
            this.ShowTwoTimesValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aNumber = new System.Windows.Forms.Label();
            this.TwoTimesValueTextBox = new System.Windows.Forms.TextBox();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowTwoTimesValue
            // 
            this.ShowTwoTimesValue.Location = new System.Drawing.Point(95, 157);
            this.ShowTwoTimesValue.Name = "ShowTwoTimesValue";
            this.ShowTwoTimesValue.Size = new System.Drawing.Size(130, 23);
            this.ShowTwoTimesValue.TabIndex = 0;
            this.ShowTwoTimesValue.Text = "ShowTwoTimesValue";
            this.ShowTwoTimesValue.UseVisualStyleBackColor = true;
            this.ShowTwoTimesValue.Click += new System.EventHandler(this.ShowTwoTimesValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TwoTimesValue";
            // 
            // aNumber
            // 
            this.aNumber.AutoSize = true;
            this.aNumber.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.aNumber.Location = new System.Drawing.Point(36, 51);
            this.aNumber.Name = "aNumber";
            this.aNumber.Size = new System.Drawing.Size(50, 13);
            this.aNumber.TabIndex = 2;
            this.aNumber.Text = "aNumber";
            // 
            // TwoTimesValueTextBox
            // 
            this.TwoTimesValueTextBox.Location = new System.Drawing.Point(125, 98);
            this.TwoTimesValueTextBox.Name = "TwoTimesValueTextBox";
            this.TwoTimesValueTextBox.ReadOnly = true;
            this.TwoTimesValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.TwoTimesValueTextBox.TabIndex = 3;
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(95, 44);
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.aNumberTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.TwoTimesValueTextBox);
            this.Controls.Add(this.aNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowTwoTimesValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowTwoTimesValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aNumber;
        private System.Windows.Forms.TextBox TwoTimesValueTextBox;
        private System.Windows.Forms.TextBox aNumberTextBox;
    }
}

