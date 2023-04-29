namespace Unit_Converter
{
    partial class Source
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.MainTab = new System.Windows.Forms.Panel();
            this.TabUnicodeButton = new System.Windows.Forms.Button();
            this.TabCostButton = new System.Windows.Forms.Button();
            this.TabDistanceButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DistanceTab = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxmm = new System.Windows.Forms.CheckBox();
            this.CheckBoxm = new System.Windows.Forms.CheckBox();
            this.CheckBoxkm = new System.Windows.Forms.CheckBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DistanceTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainTab.Controls.Add(this.pictureBox1);
            this.MainTab.Controls.Add(this.TabDistanceButton);
            this.MainTab.Controls.Add(this.TabCostButton);
            this.MainTab.Controls.Add(this.TabUnicodeButton);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.Size = new System.Drawing.Size(186, 367);
            this.MainTab.TabIndex = 0;
            // 
            // TabUnicodeButton
            // 
            this.TabUnicodeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabUnicodeButton.Location = new System.Drawing.Point(0, 305);
            this.TabUnicodeButton.Name = "TabUnicodeButton";
            this.TabUnicodeButton.Size = new System.Drawing.Size(186, 62);
            this.TabUnicodeButton.TabIndex = 0;
            this.TabUnicodeButton.Text = "文字 | unicode";
            this.TabUnicodeButton.UseVisualStyleBackColor = true;
            this.TabUnicodeButton.Click += new System.EventHandler(this.TabUnicodeButton_Click);
            // 
            // TabCostButton
            // 
            this.TabCostButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabCostButton.Location = new System.Drawing.Point(0, 243);
            this.TabCostButton.Name = "TabCostButton";
            this.TabCostButton.Size = new System.Drawing.Size(186, 62);
            this.TabCostButton.TabIndex = 1;
            this.TabCostButton.Text = "値段 | cost";
            this.TabCostButton.UseVisualStyleBackColor = true;
            this.TabCostButton.Click += new System.EventHandler(this.TabCostButton_Click);
            // 
            // TabDistanceButton
            // 
            this.TabDistanceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabDistanceButton.Location = new System.Drawing.Point(0, 181);
            this.TabDistanceButton.Name = "TabDistanceButton";
            this.TabDistanceButton.Size = new System.Drawing.Size(186, 62);
            this.TabDistanceButton.TabIndex = 2;
            this.TabDistanceButton.Text = "距離 | distance";
            this.TabDistanceButton.UseVisualStyleBackColor = true;
            this.TabDistanceButton.Click += new System.EventHandler(this.TabDistanceButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DistanceTab
            // 
            this.DistanceTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DistanceTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DistanceTab.Controls.Add(this.CopyButton);
            this.DistanceTab.Controls.Add(this.SaveButton);
            this.DistanceTab.Controls.Add(this.ResultTextBox);
            this.DistanceTab.Controls.Add(this.panel1);
            this.DistanceTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DistanceTab.Location = new System.Drawing.Point(186, 0);
            this.DistanceTab.Name = "DistanceTab";
            this.DistanceTab.Size = new System.Drawing.Size(566, 367);
            this.DistanceTab.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AutoCheckBox);
            this.panel1.Controls.Add(this.ResultButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SourceTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 330);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "距離 / Source";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(27, 60);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(155, 25);
            this.SourceTextBox.TabIndex = 1;
            this.SourceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(188, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "cm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBoxkm);
            this.groupBox1.Controls.Add(this.CheckBoxm);
            this.groupBox1.Controls.Add(this.CheckBoxmm);
            this.groupBox1.Location = new System.Drawing.Point(28, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CheckBoxmm
            // 
            this.CheckBoxmm.AutoSize = true;
            this.CheckBoxmm.Location = new System.Drawing.Point(126, 32);
            this.CheckBoxmm.Name = "CheckBoxmm";
            this.CheckBoxmm.Size = new System.Drawing.Size(60, 22);
            this.CheckBoxmm.TabIndex = 0;
            this.CheckBoxmm.Text = "mm";
            this.CheckBoxmm.UseVisualStyleBackColor = true;
            this.CheckBoxmm.CheckedChanged += new System.EventHandler(this.CheckBoxmm_CheckedChanged);
            // 
            // CheckBoxm
            // 
            this.CheckBoxm.AutoSize = true;
            this.CheckBoxm.Location = new System.Drawing.Point(126, 69);
            this.CheckBoxm.Name = "CheckBoxm";
            this.CheckBoxm.Size = new System.Drawing.Size(47, 22);
            this.CheckBoxm.TabIndex = 1;
            this.CheckBoxm.Text = "m";
            this.CheckBoxm.UseVisualStyleBackColor = true;
            this.CheckBoxm.CheckedChanged += new System.EventHandler(this.CheckBoxm_CheckedChanged);
            // 
            // CheckBoxkm
            // 
            this.CheckBoxkm.AutoSize = true;
            this.CheckBoxkm.Location = new System.Drawing.Point(126, 106);
            this.CheckBoxkm.Name = "CheckBoxkm";
            this.CheckBoxkm.Size = new System.Drawing.Size(55, 22);
            this.CheckBoxkm.TabIndex = 2;
            this.CheckBoxkm.Text = "km";
            this.CheckBoxkm.UseVisualStyleBackColor = true;
            this.CheckBoxkm.CheckedChanged += new System.EventHandler(this.CheckBoxkm_CheckedChanged);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(28, 263);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(173, 46);
            this.ResultButton.TabIndex = 4;
            this.ResultButton.Text = "変換 | Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AutoCheckBox.Location = new System.Drawing.Point(238, 287);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(113, 22);
            this.AutoCheckBox.TabIndex = 5;
            this.AutoCheckBox.Text = "自動チェック";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(401, 16);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(147, 226);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(401, 300);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 46);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存 | Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(401, 248);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(147, 46);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "コピー | Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 367);
            this.Controls.Add(this.DistanceTab);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Source";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Conversion   |   Pop-Apple";
            this.MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DistanceTab.ResumeLayout(false);
            this.DistanceTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainTab;
        private System.Windows.Forms.Button TabDistanceButton;
        private System.Windows.Forms.Button TabCostButton;
        private System.Windows.Forms.Button TabUnicodeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DistanceTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoCheckBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBoxkm;
        private System.Windows.Forms.CheckBox CheckBoxm;
        private System.Windows.Forms.CheckBox CheckBoxmm;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

