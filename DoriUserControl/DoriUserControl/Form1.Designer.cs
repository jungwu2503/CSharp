﻿namespace DoriUserControl
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.ucInfo3 = new DoriUserControl.UCInfo();
            this.ucInfo2 = new DoriUserControl.UCInfo();
            this.ucInfo1 = new DoriUserControl.UCInfo();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Peru;
            this.pMain.Controls.Add(this.ucInfo3);
            this.pMain.Controls.Add(this.ucInfo2);
            this.pMain.Controls.Add(this.ucInfo1);
            this.pMain.Location = new System.Drawing.Point(13, 10);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(753, 257);
            this.pMain.TabIndex = 0;
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 12;
            this.lboxList.Location = new System.Drawing.Point(12, 276);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(753, 136);
            this.lboxList.TabIndex = 1;
            // 
            // ucInfo3
            // 
            this.ucInfo3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo3.Location = new System.Drawing.Point(501, 14);
            this.ucInfo3.Name = "ucInfo3";
            this.ucInfo3.Size = new System.Drawing.Size(232, 225);
            this.ucInfo3.TabIndex = 2;
            this.ucInfo3.UserFace = global::DoriUserControl.Properties.Resources.cat;
            this.ucInfo3.UserGold = "2천5백만원";
            this.ucInfo3.UserName = "김형주";
            this.ucInfo3.UserNo = "3";
            // 
            // ucInfo2
            // 
            this.ucInfo2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo2.Location = new System.Drawing.Point(256, 14);
            this.ucInfo2.Name = "ucInfo2";
            this.ucInfo2.Size = new System.Drawing.Size(232, 225);
            this.ucInfo2.TabIndex = 1;
            this.ucInfo2.UserFace = global::DoriUserControl.Properties.Resources.dog;
            this.ucInfo2.UserGold = "3백만원";
            this.ucInfo2.UserName = "황진하";
            this.ucInfo2.UserNo = "2";
            // 
            // ucInfo1
            // 
            this.ucInfo1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo1.Location = new System.Drawing.Point(12, 14);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(232, 225);
            this.ucInfo1.TabIndex = 0;
            this.ucInfo1.UserFace = global::DoriUserControl.Properties.Resources.hydra;
            this.ucInfo1.UserGold = "2천만원";
            this.ucInfo1.UserName = "유상현";
            this.ucInfo1.UserNo = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 422);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private UCInfo ucInfo3;
        private UCInfo ucInfo2;
        private UCInfo ucInfo1;
        private System.Windows.Forms.ListBox lboxList;

    }
}

