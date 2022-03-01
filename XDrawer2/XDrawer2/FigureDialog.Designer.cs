namespace XDrawer2
{
    partial class FigureDialog
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
            this.selectColorButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectColorButton
            // 
            this.selectColorButton.Location = new System.Drawing.Point(120, 199);
            this.selectColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(141, 28);
            this.selectColorButton.TabIndex = 31;
            this.selectColorButton.Text = "Select Color";
            this.selectColorButton.UseVisualStyleBackColor = true;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(275, 155);
            this.blueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(48, 16);
            this.blueButton.TabIndex = 30;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.blueButton_CheckedChanged);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(202, 155);
            this.greenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(57, 16);
            this.greenButton.TabIndex = 29;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.greenButton_CheckedChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(138, 155);
            this.redButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 16);
            this.redButton.TabIndex = 28;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(70, 155);
            this.blackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(54, 16);
            this.blackButton.TabIndex = 27;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // selectBox
            // 
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Location = new System.Drawing.Point(109, 113);
            this.selectBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(162, 20);
            this.selectBox.TabIndex = 26;
            this.selectBox.SelectedIndexChanged += new System.EventHandler(this.selectBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(202, 263);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 30);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(78, 263);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 30);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(247, 70);
            this.textY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(64, 21);
            this.textY2.TabIndex = 23;
            this.textY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "y2:";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(94, 70);
            this.textX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(64, 21);
            this.textX2.TabIndex = 21;
            this.textX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "x2:";
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(247, 34);
            this.textY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(64, 21);
            this.textY1.TabIndex = 19;
            this.textY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "y1:";
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(94, 34);
            this.textX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(64, 21);
            this.textX1.TabIndex = 17;
            this.textX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "x1:";
            // 
            // FigureDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.selectColorButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textX1);
            this.Controls.Add(this.label1);
            this.Name = "FigureDialog";
            this.Text = "FigureDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectColorButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.Label label1;
    }
}