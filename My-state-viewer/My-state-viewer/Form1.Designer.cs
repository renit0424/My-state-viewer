namespace My_state_viewer
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.状態ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在席ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離席ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.就寝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StatusLabel.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 100);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "在席";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(68, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 44);
            this.label2.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状態ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 状態ToolStripMenuItem
            // 
            this.状態ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.在席ToolStripMenuItem,
            this.離席ToolStripMenuItem,
            this.作業ToolStripMenuItem,
            this.外出ToolStripMenuItem,
            this.就寝ToolStripMenuItem,
            this.不明ToolStripMenuItem,
            this.toolStripTextBox1});
            this.状態ToolStripMenuItem.Name = "状態ToolStripMenuItem";
            this.状態ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.状態ToolStripMenuItem.Text = "状態";
            // 
            // 在席ToolStripMenuItem
            // 
            this.在席ToolStripMenuItem.Name = "在席ToolStripMenuItem";
            this.在席ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.在席ToolStripMenuItem.Text = "在席";
            this.在席ToolStripMenuItem.Click += new System.EventHandler(this.在席ToolStripMenuItem_Click);
            // 
            // 離席ToolStripMenuItem
            // 
            this.離席ToolStripMenuItem.Name = "離席ToolStripMenuItem";
            this.離席ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.離席ToolStripMenuItem.Text = "離席";
            this.離席ToolStripMenuItem.Click += new System.EventHandler(this.離席ToolStripMenuItem_Click);
            // 
            // 作業ToolStripMenuItem
            // 
            this.作業ToolStripMenuItem.Name = "作業ToolStripMenuItem";
            this.作業ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.作業ToolStripMenuItem.Text = "作業";
            this.作業ToolStripMenuItem.Click += new System.EventHandler(this.作業ToolStripMenuItem_Click);
            // 
            // 外出ToolStripMenuItem
            // 
            this.外出ToolStripMenuItem.Name = "外出ToolStripMenuItem";
            this.外出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.外出ToolStripMenuItem.Text = "外出";
            this.外出ToolStripMenuItem.Click += new System.EventHandler(this.外出ToolStripMenuItem_Click);
            // 
            // 就寝ToolStripMenuItem
            // 
            this.就寝ToolStripMenuItem.Name = "就寝ToolStripMenuItem";
            this.就寝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.就寝ToolStripMenuItem.Text = "就寝";
            this.就寝ToolStripMenuItem.Click += new System.EventHandler(this.就寝ToolStripMenuItem_Click);
            // 
            // 不明ToolStripMenuItem
            // 
            this.不明ToolStripMenuItem.Name = "不明ToolStripMenuItem";
            this.不明ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.不明ToolStripMenuItem.Text = "不明";
            this.不明ToolStripMenuItem.Click += new System.EventHandler(this.不明ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "その他";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 99);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "在席表示";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 状態ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在席ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離席ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 就寝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 不明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
    }
}

