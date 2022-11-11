namespace Rock_Scissors_Papaer_Game
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerLifeProgressbar = new System.Windows.Forms.ProgressBar();
            this.enemyLifeProgressbar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ゲームGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.情報JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WinLoss5PictureBox = new System.Windows.Forms.PictureBox();
            this.WinLoss4PictureBox = new System.Windows.Forms.PictureBox();
            this.WinLoss3PictureBox = new System.Windows.Forms.PictureBox();
            this.WinLoss2PictureBox = new System.Windows.Forms.PictureBox();
            this.WinLoss1PictureBox = new System.Windows.Forms.PictureBox();
            this.ScissorsButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.PaperButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.RockButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HPIndicator = new System.Windows.Forms.PictureBox();
            this.EnemyHandPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerHandPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(587, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 133);
            this.panel3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("けいふぉんと", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(145, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "VS Cracking BOT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("けいふぉんと", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rock Paper Scissors";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(587, 214);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(556, 79);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "ゲームスタート (&S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ScissorsButtonPictureBox);
            this.panel2.Controls.Add(this.PaperButtonPictureBox);
            this.panel2.Controls.Add(this.RockButtonPictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 691);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 159);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.HPIndicator);
            this.panel1.Controls.Add(this.playerLifeProgressbar);
            this.panel1.Controls.Add(this.EnemyHandPictureBox);
            this.panel1.Controls.Add(this.PlayerHandPictureBox);
            this.panel1.Controls.Add(this.enemyLifeProgressbar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 638);
            this.panel1.TabIndex = 20;
            // 
            // playerLifeProgressbar
            // 
            this.playerLifeProgressbar.Location = new System.Drawing.Point(21, 591);
            this.playerLifeProgressbar.Name = "playerLifeProgressbar";
            this.playerLifeProgressbar.Size = new System.Drawing.Size(520, 23);
            this.playerLifeProgressbar.TabIndex = 5;
            // 
            // enemyLifeProgressbar
            // 
            this.enemyLifeProgressbar.Location = new System.Drawing.Point(21, 20);
            this.enemyLifeProgressbar.Name = "enemyLifeProgressbar";
            this.enemyLifeProgressbar.Size = new System.Drawing.Size(520, 23);
            this.enemyLifeProgressbar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ゲームGToolStripMenuItem,
            this.情報JToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1159, 35);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ゲームGToolStripMenuItem
            // 
            this.ゲームGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スタートSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了EToolStripMenuItem});
            this.ゲームGToolStripMenuItem.Name = "ゲームGToolStripMenuItem";
            this.ゲームGToolStripMenuItem.Size = new System.Drawing.Size(76, 31);
            this.ゲームGToolStripMenuItem.Text = "ゲーム(&G)";
            // 
            // スタートSToolStripMenuItem
            // 
            this.スタートSToolStripMenuItem.Name = "スタートSToolStripMenuItem";
            this.スタートSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.スタートSToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.スタートSToolStripMenuItem.Text = "スタート(S)";
            this.スタートSToolStripMenuItem.Click += new System.EventHandler(this.スタートSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // 終了EToolStripMenuItem
            // 
            this.終了EToolStripMenuItem.Name = "終了EToolStripMenuItem";
            this.終了EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.終了EToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.終了EToolStripMenuItem.Text = "終了(&E)";
            this.終了EToolStripMenuItem.Click += new System.EventHandler(this.終了EToolStripMenuItem_Click);
            // 
            // 情報JToolStripMenuItem
            // 
            this.情報JToolStripMenuItem.Name = "情報JToolStripMenuItem";
            this.情報JToolStripMenuItem.Size = new System.Drawing.Size(61, 31);
            this.情報JToolStripMenuItem.Text = "情報(&I)";
            this.情報JToolStripMenuItem.Click += new System.EventHandler(this.情報JToolStripMenuItem_Click);
            // 
            // WinLoss5PictureBox
            // 
            this.WinLoss5PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WinLoss5PictureBox.Location = new System.Drawing.Point(824, 718);
            this.WinLoss5PictureBox.Name = "WinLoss5PictureBox";
            this.WinLoss5PictureBox.Size = new System.Drawing.Size(91, 86);
            this.WinLoss5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinLoss5PictureBox.TabIndex = 29;
            this.WinLoss5PictureBox.TabStop = false;
            // 
            // WinLoss4PictureBox
            // 
            this.WinLoss4PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WinLoss4PictureBox.Location = new System.Drawing.Point(824, 626);
            this.WinLoss4PictureBox.Name = "WinLoss4PictureBox";
            this.WinLoss4PictureBox.Size = new System.Drawing.Size(91, 86);
            this.WinLoss4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinLoss4PictureBox.TabIndex = 28;
            this.WinLoss4PictureBox.TabStop = false;
            // 
            // WinLoss3PictureBox
            // 
            this.WinLoss3PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WinLoss3PictureBox.Location = new System.Drawing.Point(824, 534);
            this.WinLoss3PictureBox.Name = "WinLoss3PictureBox";
            this.WinLoss3PictureBox.Size = new System.Drawing.Size(91, 86);
            this.WinLoss3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinLoss3PictureBox.TabIndex = 27;
            this.WinLoss3PictureBox.TabStop = false;
            // 
            // WinLoss2PictureBox
            // 
            this.WinLoss2PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WinLoss2PictureBox.Location = new System.Drawing.Point(824, 442);
            this.WinLoss2PictureBox.Name = "WinLoss2PictureBox";
            this.WinLoss2PictureBox.Size = new System.Drawing.Size(91, 86);
            this.WinLoss2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinLoss2PictureBox.TabIndex = 26;
            this.WinLoss2PictureBox.TabStop = false;
            // 
            // WinLoss1PictureBox
            // 
            this.WinLoss1PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WinLoss1PictureBox.Location = new System.Drawing.Point(824, 350);
            this.WinLoss1PictureBox.Name = "WinLoss1PictureBox";
            this.WinLoss1PictureBox.Size = new System.Drawing.Size(91, 86);
            this.WinLoss1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinLoss1PictureBox.TabIndex = 25;
            this.WinLoss1PictureBox.TabStop = false;
            // 
            // ScissorsButtonPictureBox
            // 
            this.ScissorsButtonPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ScissorsButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScissorsButtonPictureBox.Image = global::Rock_Scissors_Papaer_Game.Properties.Resources.Scissors;
            this.ScissorsButtonPictureBox.Location = new System.Drawing.Point(206, 18);
            this.ScissorsButtonPictureBox.Name = "ScissorsButtonPictureBox";
            this.ScissorsButtonPictureBox.Size = new System.Drawing.Size(158, 122);
            this.ScissorsButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScissorsButtonPictureBox.TabIndex = 2;
            this.ScissorsButtonPictureBox.TabStop = false;
            this.ScissorsButtonPictureBox.Click += new System.EventHandler(this.ScissorsButtonPictureBox_Click);
            // 
            // PaperButtonPictureBox
            // 
            this.PaperButtonPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PaperButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaperButtonPictureBox.Image = global::Rock_Scissors_Papaer_Game.Properties.Resources.Paper;
            this.PaperButtonPictureBox.Location = new System.Drawing.Point(386, 18);
            this.PaperButtonPictureBox.Name = "PaperButtonPictureBox";
            this.PaperButtonPictureBox.Size = new System.Drawing.Size(155, 122);
            this.PaperButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaperButtonPictureBox.TabIndex = 1;
            this.PaperButtonPictureBox.TabStop = false;
            this.PaperButtonPictureBox.Click += new System.EventHandler(this.PaperButtonPictureBox_Click);
            // 
            // RockButtonPictureBox
            // 
            this.RockButtonPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RockButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RockButtonPictureBox.Image = global::Rock_Scissors_Papaer_Game.Properties.Resources.Rock;
            this.RockButtonPictureBox.Location = new System.Drawing.Point(21, 18);
            this.RockButtonPictureBox.Name = "RockButtonPictureBox";
            this.RockButtonPictureBox.Size = new System.Drawing.Size(158, 122);
            this.RockButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RockButtonPictureBox.TabIndex = 0;
            this.RockButtonPictureBox.TabStop = false;
            this.RockButtonPictureBox.Click += new System.EventHandler(this.RockButtonPictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(517, 562);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // HPIndicator
            // 
            this.HPIndicator.Image = ((System.Drawing.Image)(resources.GetObject("HPIndicator.Image")));
            this.HPIndicator.Location = new System.Drawing.Point(21, 49);
            this.HPIndicator.Name = "HPIndicator";
            this.HPIndicator.Size = new System.Drawing.Size(24, 31);
            this.HPIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HPIndicator.TabIndex = 6;
            this.HPIndicator.TabStop = false;
            // 
            // EnemyHandPictureBox
            // 
            this.EnemyHandPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EnemyHandPictureBox.Location = new System.Drawing.Point(206, 299);
            this.EnemyHandPictureBox.Name = "EnemyHandPictureBox";
            this.EnemyHandPictureBox.Size = new System.Drawing.Size(158, 122);
            this.EnemyHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyHandPictureBox.TabIndex = 4;
            this.EnemyHandPictureBox.TabStop = false;
            // 
            // PlayerHandPictureBox
            // 
            this.PlayerHandPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlayerHandPictureBox.Location = new System.Drawing.Point(206, 446);
            this.PlayerHandPictureBox.Name = "PlayerHandPictureBox";
            this.PlayerHandPictureBox.Size = new System.Drawing.Size(158, 122);
            this.PlayerHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerHandPictureBox.TabIndex = 3;
            this.PlayerHandPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 864);
            this.Controls.Add(this.WinLoss5PictureBox);
            this.Controls.Add(this.WinLoss4PictureBox);
            this.Controls.Add(this.WinLoss3PictureBox);
            this.Controls.Add(this.WinLoss2PictureBox);
            this.Controls.Add(this.WinLoss1PictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Scissors Papaer Game | Pop-Apple";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoss1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WinLoss5PictureBox;
        private System.Windows.Forms.PictureBox WinLoss4PictureBox;
        private System.Windows.Forms.PictureBox WinLoss3PictureBox;
        private System.Windows.Forms.PictureBox WinLoss2PictureBox;
        private System.Windows.Forms.PictureBox WinLoss1PictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ScissorsButtonPictureBox;
        private System.Windows.Forms.PictureBox PaperButtonPictureBox;
        private System.Windows.Forms.PictureBox RockButtonPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar playerLifeProgressbar;
        private System.Windows.Forms.PictureBox EnemyHandPictureBox;
        private System.Windows.Forms.PictureBox PlayerHandPictureBox;
        private System.Windows.Forms.ProgressBar enemyLifeProgressbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ゲームGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 情報JToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox HPIndicator;
    }
}

