﻿namespace CopyAndPaste
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
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtlbtextadd = new System.Windows.Forms.TextBox();
            this.cboxActivation = new System.Windows.Forms.CheckBox();
            this.lblActivation = new System.Windows.Forms.Label();
            this.btnlbtextadd = new System.Windows.Forms.Button();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 12;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(433, 278);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActivation);
            this.panel1.Controls.Add(this.cboxActivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBar);
            this.panel2.Controls.Add(this.btnlbtextadd);
            this.panel2.Controls.Add(this.txtlbtextadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 34);
            this.panel2.TabIndex = 2;
            // 
            // txtlbtextadd
            // 
            this.txtlbtextadd.Location = new System.Drawing.Point(12, 6);
            this.txtlbtextadd.Name = "txtlbtextadd";
            this.txtlbtextadd.Size = new System.Drawing.Size(131, 21);
            this.txtlbtextadd.TabIndex = 0;
            this.txtlbtextadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_KeyDown);
            // 
            // cboxActivation
            // 
            this.cboxActivation.AutoSize = true;
            this.cboxActivation.Checked = true;
            this.cboxActivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxActivation.Location = new System.Drawing.Point(22, 9);
            this.cboxActivation.Name = "cboxActivation";
            this.cboxActivation.Size = new System.Drawing.Size(78, 16);
            this.cboxActivation.TabIndex = 0;
            this.cboxActivation.Text = "Activation";
            this.cboxActivation.UseVisualStyleBackColor = true;
            this.cboxActivation.CheckedChanged += new System.EventHandler(this.cbox_Change);
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Location = new System.Drawing.Point(227, 13);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(149, 12);
            this.lblActivation.TabIndex = 1;
            this.lblActivation.Text = "활성화 상태(Ctrl + C 가능)";
            // 
            // btnlbtextadd
            // 
            this.btnlbtextadd.Location = new System.Drawing.Point(164, 3);
            this.btnlbtextadd.Name = "btnlbtextadd";
            this.btnlbtextadd.Size = new System.Drawing.Size(83, 26);
            this.btnlbtextadd.TabIndex = 1;
            this.btnlbtextadd.Text = "등록";
            this.btnlbtextadd.UseVisualStyleBackColor = true;
            this.btnlbtextadd.Click += new System.EventHandler(this.btnAdd);
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(266, 6);
            this.tBar.Minimum = 2;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(154, 45);
            this.tBar.TabIndex = 2;
            this.tBar.Value = 10;
            this.tBar.Scroll += new System.EventHandler(this.tBar_Scroll_Change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            this.ResumeLayout(false);

        }                 

        #endregion

        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActivation;
        private System.Windows.Forms.CheckBox cboxActivation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.Button btnlbtextadd;
        private System.Windows.Forms.TextBox txtlbtextadd;
    }
}

