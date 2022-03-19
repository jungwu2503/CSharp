namespace DoriSoundPlayer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoBeep1 = new System.Windows.Forms.RadioButton();
            this.rdoBeep2 = new System.Windows.Forms.RadioButton();
            this.rdoBeep3 = new System.Windows.Forms.RadioButton();
            this.rdoBeep4 = new System.Windows.Forms.RadioButton();
            this.rdoBeep5 = new System.Windows.Forms.RadioButton();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnWAV = new System.Windows.Forms.Button();
            this.tboxFileName = new System.Windows.Forms.TextBox();
            this.tboxStatus = new System.Windows.Forms.TextBox();
            this.btnMP3 = new System.Windows.Forms.Button();
            this.tbarMain = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBeep);
            this.groupBox1.Controls.Add(this.rdoBeep5);
            this.groupBox1.Controls.Add(this.rdoBeep4);
            this.groupBox1.Controls.Add(this.rdoBeep3);
            this.groupBox1.Controls.Add(this.rdoBeep2);
            this.groupBox1.Controls.Add(this.rdoBeep1);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SystemSound";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWAV);
            this.groupBox2.Location = new System.Drawing.Point(523, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WAV Player";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVolume);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.tbarVolume);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Controls.Add(this.tbarMain);
            this.groupBox3.Controls.Add(this.btnMP3);
            this.groupBox3.Controls.Add(this.tboxStatus);
            this.groupBox3.Controls.Add(this.tboxFileName);
            this.groupBox3.Location = new System.Drawing.Point(22, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MP3 Player";
            // 
            // rdoBeep1
            // 
            this.rdoBeep1.AutoSize = true;
            this.rdoBeep1.Location = new System.Drawing.Point(19, 44);
            this.rdoBeep1.Name = "rdoBeep1";
            this.rdoBeep1.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep1.TabIndex = 0;
            this.rdoBeep1.TabStop = true;
            this.rdoBeep1.Text = "Beep1";
            this.rdoBeep1.UseVisualStyleBackColor = true;
            // 
            // rdoBeep2
            // 
            this.rdoBeep2.AutoSize = true;
            this.rdoBeep2.Location = new System.Drawing.Point(83, 44);
            this.rdoBeep2.Name = "rdoBeep2";
            this.rdoBeep2.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep2.TabIndex = 1;
            this.rdoBeep2.TabStop = true;
            this.rdoBeep2.Text = "Beep2";
            this.rdoBeep2.UseVisualStyleBackColor = true;
            // 
            // rdoBeep3
            // 
            this.rdoBeep3.AutoSize = true;
            this.rdoBeep3.Location = new System.Drawing.Point(148, 44);
            this.rdoBeep3.Name = "rdoBeep3";
            this.rdoBeep3.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep3.TabIndex = 2;
            this.rdoBeep3.TabStop = true;
            this.rdoBeep3.Text = "Beep3";
            this.rdoBeep3.UseVisualStyleBackColor = true;
            // 
            // rdoBeep4
            // 
            this.rdoBeep4.AutoSize = true;
            this.rdoBeep4.Location = new System.Drawing.Point(213, 44);
            this.rdoBeep4.Name = "rdoBeep4";
            this.rdoBeep4.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep4.TabIndex = 3;
            this.rdoBeep4.TabStop = true;
            this.rdoBeep4.Text = "Beep4";
            this.rdoBeep4.UseVisualStyleBackColor = true;
            // 
            // rdoBeep5
            // 
            this.rdoBeep5.AutoSize = true;
            this.rdoBeep5.Location = new System.Drawing.Point(278, 44);
            this.rdoBeep5.Name = "rdoBeep5";
            this.rdoBeep5.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep5.TabIndex = 4;
            this.rdoBeep5.TabStop = true;
            this.rdoBeep5.Text = "Beep5";
            this.rdoBeep5.UseVisualStyleBackColor = true;
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(353, 36);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(118, 32);
            this.btnBeep.TabIndex = 5;
            this.btnBeep.Text = "SystemSound";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnWAV
            // 
            this.btnWAV.Location = new System.Drawing.Point(36, 36);
            this.btnWAV.Name = "btnWAV";
            this.btnWAV.Size = new System.Drawing.Size(118, 32);
            this.btnWAV.TabIndex = 6;
            this.btnWAV.Text = "WAV Open";
            this.btnWAV.UseVisualStyleBackColor = true;
            this.btnWAV.Click += new System.EventHandler(this.btnWAV_Click);
            // 
            // tboxFileName
            // 
            this.tboxFileName.Location = new System.Drawing.Point(13, 35);
            this.tboxFileName.Name = "tboxFileName";
            this.tboxFileName.Size = new System.Drawing.Size(387, 21);
            this.tboxFileName.TabIndex = 0;
            // 
            // tboxStatus
            // 
            this.tboxStatus.Location = new System.Drawing.Point(406, 35);
            this.tboxStatus.Name = "tboxStatus";
            this.tboxStatus.Size = new System.Drawing.Size(152, 21);
            this.tboxStatus.TabIndex = 1;
            this.tboxStatus.Text = "-";
            // 
            // btnMP3
            // 
            this.btnMP3.Location = new System.Drawing.Point(564, 28);
            this.btnMP3.Name = "btnMP3";
            this.btnMP3.Size = new System.Drawing.Size(118, 32);
            this.btnMP3.TabIndex = 7;
            this.btnMP3.Text = "MP3 Open";
            this.btnMP3.UseVisualStyleBackColor = true;
            this.btnMP3.Click += new System.EventHandler(this.btnMP3_Click);
            // 
            // tbarMain
            // 
            this.tbarMain.Location = new System.Drawing.Point(14, 76);
            this.tbarMain.Name = "tbarMain";
            this.tbarMain.Size = new System.Drawing.Size(386, 45);
            this.tbarMain.TabIndex = 8;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(422, 77);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 28);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(466, 77);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 28);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(510, 77);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 28);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tbarVolume
            // 
            this.tbarVolume.Location = new System.Drawing.Point(554, 76);
            this.tbarVolume.Maximum = 100;
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(133, 45);
            this.tbarVolume.TabIndex = 12;
            this.tbarVolume.Scroll += new System.EventHandler(this.tbarVolume_Scroll);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(324, 109);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 12);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "0 / 0";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(661, 109);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(11, 12);
            this.lblVolume.TabIndex = 14;
            this.lblVolume.Text = "0";
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 310);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.RadioButton rdoBeep5;
        private System.Windows.Forms.RadioButton rdoBeep4;
        private System.Windows.Forms.RadioButton rdoBeep3;
        private System.Windows.Forms.RadioButton rdoBeep2;
        private System.Windows.Forms.RadioButton rdoBeep1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWAV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar tbarMain;
        private System.Windows.Forms.Button btnMP3;
        private System.Windows.Forms.TextBox tboxStatus;
        private System.Windows.Forms.TextBox tboxFileName;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}

