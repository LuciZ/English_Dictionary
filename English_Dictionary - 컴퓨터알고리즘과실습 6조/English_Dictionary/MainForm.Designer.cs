﻿namespace English_Dictionary
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resultPanel = new System.Windows.Forms.Panel();
            this.countPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.resultPanel.SuspendLayout();
            this.countPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.resultPanel.Controls.Add(this.resultLabel);
            this.resultPanel.Location = new System.Drawing.Point(12, 103);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(200, 210);
            this.resultPanel.TabIndex = 0;
            // 
            // countPanel
            // 
            this.countPanel.BackColor = System.Drawing.Color.Orchid;
            this.countPanel.Controls.Add(this.countLabel);
            this.countPanel.Location = new System.Drawing.Point(234, 103);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(200, 210);
            this.countPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(234, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 21);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.infoLabel.Location = new System.Drawing.Point(12, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(194, 16);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "검색할 단어를 입력하세요";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 56);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 21);
            this.searchTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(17, 21);
            this.resultLabel.MaximumSize = new System.Drawing.Size(160, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(133, 12);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "한국어 뜻이 출력됩니다";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(16, 21);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(161, 12);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "문자 비교 횟수가 출력됩니다";
            // 
            // MainForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 325);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.countPanel);
            this.Controls.Add(this.resultPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "영한사전 by 6조";
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel countPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label countLabel;
    }
}

