namespace FirstForm
{
    partial class Frame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그림DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modealessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.그림DToolStripMenuItem,
            this.도구TToolStripMenuItem,
            this.rulerToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.열기ToolStripMenuItem,
            this.저ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.프린트ToolStripMenuItem,
            this.종ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenuItem.Size = new System.Drawing.Size(236, 22);
            this.newFileMenuItem.Text = "새 파일(N)";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.열기ToolStripMenuItem.Text = "열기(O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1266, 612);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // 저ToolStripMenuItem
            // 
            this.저ToolStripMenuItem.Name = "저ToolStripMenuItem";
            this.저ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.저ToolStripMenuItem.Text = "저장(S)";
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장(A)";
            // 
            // 프린트ToolStripMenuItem
            // 
            this.프린트ToolStripMenuItem.Name = "프린트ToolStripMenuItem";
            this.프린트ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.프린트ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.프린트ToolStripMenuItem.Text = "프린트(P)";
            // 
            // 종ToolStripMenuItem
            // 
            this.종ToolStripMenuItem.Name = "종ToolStripMenuItem";
            this.종ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.종ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.종ToolStripMenuItem.Text = "종료(X)";
            // 
            // 그림DToolStripMenuItem
            // 
            this.그림DToolStripMenuItem.Name = "그림DToolStripMenuItem";
            this.그림DToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.그림DToolStripMenuItem.Text = "그림(D)";
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalMenuItem,
            this.modealessMenuItem});
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(T)";
            // 
            // rulerToolStripMenuItem
            // 
            this.rulerToolStripMenuItem.Name = "rulerToolStripMenuItem";
            this.rulerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rulerToolStripMenuItem.Text = "Ruler(R)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // modalMenuItem
            // 
            this.modalMenuItem.Name = "modalMenuItem";
            this.modalMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modalMenuItem.Text = "Modal(M)";
            this.modalMenuItem.Click += new System.EventHandler(this.modalMenuItem_Click);
            // 
            // modealessMenuItem
            // 
            this.modealessMenuItem.Name = "modealessMenuItem";
            this.modealessMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modealessMenuItem.Text = "Modealess(S)";
            this.modealessMenuItem.Click += new System.EventHandler(this.modealessMenuItem_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 636);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frame";
            this.Text = "CS Drawer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem 저ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그림DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modealessMenuItem;
    }
}

