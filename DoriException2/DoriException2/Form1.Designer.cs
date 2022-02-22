namespace DoriException2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.lboxColor = new System.Windows.Forms.ListBox();
            this.btnColorSave = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.pBack = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cDialogColor = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColorInfo);
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alpha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text :";
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(72, 22);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(20, 20);
            this.pColor.TabIndex = 3;
            this.pColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pColor_MouseClick);
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(72, 67);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(143, 45);
            this.tbarAlpha.TabIndex = 4;
            this.tbarAlpha.Value = 255;
            this.tbarAlpha.Scroll += new System.EventHandler(this.tbarAlpha_Scroll);
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(70, 114);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(11, 12);
            this.lblColorInfo.TabIndex = 5;
            this.lblColorInfo.Text = "-";
            // 
            // lboxColor
            // 
            this.lboxColor.FormattingEnabled = true;
            this.lboxColor.ItemHeight = 12;
            this.lboxColor.Location = new System.Drawing.Point(8, 234);
            this.lboxColor.Name = "lboxColor";
            this.lboxColor.Size = new System.Drawing.Size(285, 148);
            this.lboxColor.TabIndex = 1;
            this.lboxColor.SelectedIndexChanged += new System.EventHandler(this.lboxColor_SelectedIndexChanged);
            // 
            // btnColorSave
            // 
            this.btnColorSave.Location = new System.Drawing.Point(145, 197);
            this.btnColorSave.Name = "btnColorSave";
            this.btnColorSave.Size = new System.Drawing.Size(67, 26);
            this.btnColorSave.TabIndex = 2;
            this.btnColorSave.Text = "저장";
            this.btnColorSave.UseVisualStyleBackColor = true;
            this.btnColorSave.Click += new System.EventHandler(this.btnColorSave_Click);
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Location = new System.Drawing.Point(218, 197);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(67, 26);
            this.btnColorDelete.TabIndex = 3;
            this.btnColorDelete.Text = "삭제";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBack.Controls.Add(this.panel4);
            this.pBack.Controls.Add(this.panel5);
            this.pBack.Controls.Add(this.panel3);
            this.pBack.Controls.Add(this.panel2);
            this.pBack.Controls.Add(this.panel1);
            this.pBack.Location = new System.Drawing.Point(324, 20);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(318, 362);
            this.pBack.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(104, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 305);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(163, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 110);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(27, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 64);
            this.panel5.TabIndex = 2;
            this.panel5.Click += new System.EventHandler(this.Panel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 394);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.btnColorDelete);
            this.Controls.Add(this.btnColorSave);
            this.Controls.Add(this.lboxColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.pBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxColor;
        private System.Windows.Forms.Button btnColorSave;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog cDialogColor;
    }
}

