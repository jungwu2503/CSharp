namespace DoriAsync
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
            this.pDoor1 = new System.Windows.Forms.Panel();
            this.pRobot = new System.Windows.Forms.Panel();
            this.pDoor2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSimulationAsync = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.tboxDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRobotRetract = new System.Windows.Forms.Button();
            this.btnRobotExtend = new System.Windows.Forms.Button();
            this.btnRobotRotate = new System.Windows.Forms.Button();
            this.btnD2Close = new System.Windows.Forms.Button();
            this.btnD1Close = new System.Windows.Forms.Button();
            this.btnD2Open = new System.Windows.Forms.Button();
            this.btnD1Open = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDoor1
            // 
            this.pDoor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor1.Location = new System.Drawing.Point(6, 20);
            this.pDoor1.Name = "pDoor1";
            this.pDoor1.Size = new System.Drawing.Size(59, 178);
            this.pDoor1.TabIndex = 0;
            // 
            // pRobot
            // 
            this.pRobot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pRobot.Location = new System.Drawing.Point(71, 20);
            this.pRobot.Name = "pRobot";
            this.pRobot.Size = new System.Drawing.Size(195, 178);
            this.pRobot.TabIndex = 1;
            // 
            // pDoor2
            // 
            this.pDoor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor2.Location = new System.Drawing.Point(272, 20);
            this.pDoor2.Name = "pDoor2";
            this.pDoor2.Size = new System.Drawing.Size(59, 178);
            this.pDoor2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pDoor2);
            this.groupBox1.Controls.Add(this.pDoor1);
            this.groupBox1.Controls.Add(this.pRobot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSimulationAsync);
            this.groupBox2.Controls.Add(this.btnSimulation);
            this.groupBox2.Controls.Add(this.tboxDelay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnInit);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전체 동작";
            // 
            // btnSimulationAsync
            // 
            this.btnSimulationAsync.Location = new System.Drawing.Point(9, 151);
            this.btnSimulationAsync.Name = "btnSimulationAsync";
            this.btnSimulationAsync.Size = new System.Drawing.Size(150, 50);
            this.btnSimulationAsync.TabIndex = 4;
            this.btnSimulationAsync.Text = "비동기 동작 진행";
            this.btnSimulationAsync.UseVisualStyleBackColor = true;
            this.btnSimulationAsync.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.Location = new System.Drawing.Point(10, 95);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(150, 50);
            this.btnSimulation.TabIndex = 3;
            this.btnSimulation.Text = "동기 동작 진행";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btn_Click);
            // 
            // tboxDelay
            // 
            this.tboxDelay.Location = new System.Drawing.Point(82, 68);
            this.tboxDelay.Name = "tboxDelay";
            this.tboxDelay.Size = new System.Drawing.Size(41, 21);
            this.tboxDelay.TabIndex = 2;
            this.tboxDelay.Text = "100";
            this.tboxDelay.TextChanged += new System.EventHandler(this.tboxDelay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "동작 Delay : ";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(7, 22);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(150, 38);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "초기 화면 표시";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "m/s";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRobotRetract);
            this.groupBox3.Controls.Add(this.btnRobotExtend);
            this.groupBox3.Controls.Add(this.btnRobotRotate);
            this.groupBox3.Controls.Add(this.btnD2Close);
            this.groupBox3.Controls.Add(this.btnD1Close);
            this.groupBox3.Controls.Add(this.btnD2Open);
            this.groupBox3.Controls.Add(this.btnD1Open);
            this.groupBox3.Location = new System.Drawing.Point(548, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 212);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "단위 동작";
            // 
            // btnRobotRetract
            // 
            this.btnRobotRetract.Location = new System.Drawing.Point(10, 138);
            this.btnRobotRetract.Name = "btnRobotRetract";
            this.btnRobotRetract.Size = new System.Drawing.Size(234, 31);
            this.btnRobotRetract.TabIndex = 8;
            this.btnRobotRetract.Text = "Robot Arm Retract";
            this.btnRobotRetract.UseVisualStyleBackColor = true;
            this.btnRobotRetract.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotExtend
            // 
            this.btnRobotExtend.Location = new System.Drawing.Point(10, 104);
            this.btnRobotExtend.Name = "btnRobotExtend";
            this.btnRobotExtend.Size = new System.Drawing.Size(234, 31);
            this.btnRobotExtend.TabIndex = 7;
            this.btnRobotExtend.Text = "Robot Arm Extend";
            this.btnRobotExtend.UseVisualStyleBackColor = true;
            this.btnRobotExtend.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotRotate
            // 
            this.btnRobotRotate.Location = new System.Drawing.Point(10, 172);
            this.btnRobotRotate.Name = "btnRobotRotate";
            this.btnRobotRotate.Size = new System.Drawing.Size(234, 31);
            this.btnRobotRotate.TabIndex = 6;
            this.btnRobotRotate.Text = "Robot Rotate";
            this.btnRobotRotate.UseVisualStyleBackColor = true;
            this.btnRobotRotate.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Close
            // 
            this.btnD2Close.Location = new System.Drawing.Point(130, 61);
            this.btnD2Close.Name = "btnD2Close";
            this.btnD2Close.Size = new System.Drawing.Size(114, 38);
            this.btnD2Close.TabIndex = 3;
            this.btnD2Close.Text = "Door2 Close";
            this.btnD2Close.UseVisualStyleBackColor = true;
            this.btnD2Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD1Close
            // 
            this.btnD1Close.Location = new System.Drawing.Point(10, 61);
            this.btnD1Close.Name = "btnD1Close";
            this.btnD1Close.Size = new System.Drawing.Size(114, 38);
            this.btnD1Close.TabIndex = 2;
            this.btnD1Close.Text = "Door1 Close";
            this.btnD1Close.UseVisualStyleBackColor = true;
            this.btnD1Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Open
            // 
            this.btnD2Open.Location = new System.Drawing.Point(130, 18);
            this.btnD2Open.Name = "btnD2Open";
            this.btnD2Open.Size = new System.Drawing.Size(114, 38);
            this.btnD2Open.TabIndex = 1;
            this.btnD2Open.Text = "Door2 Open";
            this.btnD2Open.UseVisualStyleBackColor = true;
            this.btnD2Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD1Open
            // 
            this.btnD1Open.Location = new System.Drawing.Point(10, 19);
            this.btnD1Open.Name = "btnD1Open";
            this.btnD1Open.Size = new System.Drawing.Size(114, 38);
            this.btnD1Open.TabIndex = 0;
            this.btnD1Open.Text = "Door1 Open";
            this.btnD1Open.UseVisualStyleBackColor = true;
            this.btnD1Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lboxLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 257);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "log View";
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(6, 17);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(773, 232);
            this.lboxLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 492);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDoor1;
        private System.Windows.Forms.Panel pRobot;
        private System.Windows.Forms.Panel pDoor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSimulationAsync;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.TextBox tboxDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRobotRetract;
        private System.Windows.Forms.Button btnRobotExtend;
        private System.Windows.Forms.Button btnRobotRotate;
        private System.Windows.Forms.Button btnD2Close;
        private System.Windows.Forms.Button btnD1Close;
        private System.Windows.Forms.Button btnD2Open;
        private System.Windows.Forms.Button btnD1Open;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lboxLog;
    }
}

