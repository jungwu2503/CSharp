namespace DoriTreeView
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
            this.Setting = new System.Windows.Forms.GroupBox();
            this.tboxDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTreeLoad = new System.Windows.Forms.Button();
            this.tboxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxCommand = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tviewLocation = new System.Windows.Forms.TreeView();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.tboxDestination);
            this.Setting.Controls.Add(this.label2);
            this.Setting.Controls.Add(this.btnTreeLoad);
            this.Setting.Controls.Add(this.tboxSource);
            this.Setting.Controls.Add(this.label1);
            this.Setting.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Setting.Location = new System.Drawing.Point(17, 14);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(527, 61);
            this.Setting.TabIndex = 0;
            this.Setting.TabStop = false;
            this.Setting.Text = "Setting";
            // 
            // tboxDestination
            // 
            this.tboxDestination.Location = new System.Drawing.Point(350, 24);
            this.tboxDestination.Name = "tboxDestination";
            this.tboxDestination.Size = new System.Drawing.Size(159, 21);
            this.tboxDestination.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // btnTreeLoad
            // 
            this.btnTreeLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTreeLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreeLoad.Location = new System.Drawing.Point(229, 22);
            this.btnTreeLoad.Name = "btnTreeLoad";
            this.btnTreeLoad.Size = new System.Drawing.Size(31, 24);
            this.btnTreeLoad.TabIndex = 2;
            this.btnTreeLoad.Text = "T";
            this.btnTreeLoad.UseVisualStyleBackColor = false;
            this.btnTreeLoad.Click += new System.EventHandler(this.btnTreeLoad_Click);
            // 
            // tboxSource
            // 
            this.tboxSource.Location = new System.Drawing.Point(65, 24);
            this.tboxSource.Name = "tboxSource";
            this.tboxSource.Size = new System.Drawing.Size(159, 21);
            this.tboxSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tboxFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lboxCommand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tviewLocation);
            this.groupBox1.Controls.Add(this.btnCollapse);
            this.groupBox1.Controls.Add(this.btnExtend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "▼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "▶";
            // 
            // tboxFile
            // 
            this.tboxFile.Location = new System.Drawing.Point(276, 132);
            this.tboxFile.Multiline = true;
            this.tboxFile.Name = "tboxFile";
            this.tboxFile.Size = new System.Drawing.Size(240, 85);
            this.tboxFile.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "File";
            // 
            // lboxCommand
            // 
            this.lboxCommand.FormattingEnabled = true;
            this.lboxCommand.ItemHeight = 12;
            this.lboxCommand.Location = new System.Drawing.Point(276, 42);
            this.lboxCommand.Name = "lboxCommand";
            this.lboxCommand.Size = new System.Drawing.Size(241, 64);
            this.lboxCommand.TabIndex = 5;
            this.lboxCommand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxCommand_MouseClick);
            this.lboxCommand.DoubleClick += new System.EventHandler(this.lboxCommand_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Command";
            // 
            // tviewLocation
            // 
            this.tviewLocation.Location = new System.Drawing.Point(12, 54);
            this.tviewLocation.Name = "tviewLocation";
            this.tviewLocation.Size = new System.Drawing.Size(247, 164);
            this.tviewLocation.TabIndex = 3;
            this.tviewLocation.DoubleClick += new System.EventHandler(this.tviewLocation_DoubleClick);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(174, 18);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(86, 28);
            this.btnCollapse.TabIndex = 2;
            this.btnCollapse.Text = "Collapse";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtend.Location = new System.Drawing.Point(82, 18);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(86, 28);
            this.btnExtend.TabIndex = 1;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = false;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "TreeNode";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopy.Location = new System.Drawing.Point(469, 330);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(73, 26);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxLog);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(16, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(9, 17);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(505, 76);
            this.lboxLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(561, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Setting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox tboxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTreeLoad;
        private System.Windows.Forms.TextBox tboxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tviewLocation;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

