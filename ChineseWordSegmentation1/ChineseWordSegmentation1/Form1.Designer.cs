namespace ChineseWordSegmentation1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.segmentButton = new System.Windows.Forms.Button();
            this.segmenTextBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入中文句子：";
            // 
            // enterTextBox
            // 
            this.enterTextBox.Location = new System.Drawing.Point(57, 37);
            this.enterTextBox.Multiline = true;
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(392, 77);
            this.enterTextBox.TabIndex = 1;
            // 
            // segmentButton
            // 
            this.segmentButton.Location = new System.Drawing.Point(163, 120);
            this.segmentButton.Name = "segmentButton";
            this.segmentButton.Size = new System.Drawing.Size(162, 79);
            this.segmentButton.TabIndex = 2;
            this.segmentButton.Text = "Segmentation";
            this.segmentButton.UseVisualStyleBackColor = true;
            this.segmentButton.Click += new System.EventHandler(this.segmentButton_Click);
            // 
            // segmenTextBox
            // 
            this.segmenTextBox.Location = new System.Drawing.Point(62, 211);
            this.segmenTextBox.Multiline = true;
            this.segmenTextBox.Name = "segmenTextBox";
            this.segmenTextBox.Size = new System.Drawing.Size(386, 106);
            this.segmenTextBox.TabIndex = 3;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(116, 340);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(272, 48);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "退出";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 440);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.segmenTextBox);
            this.Controls.Add(this.segmentButton);
            this.Controls.Add(this.enterTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterTextBox;
        private System.Windows.Forms.Button segmentButton;
        private System.Windows.Forms.TextBox segmenTextBox;
        private System.Windows.Forms.Button quitButton;
    }
}

