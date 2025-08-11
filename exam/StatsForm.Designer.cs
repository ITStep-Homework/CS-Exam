namespace exam
{
    partial class StatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.generalStatsLabel = new System.Windows.Forms.Label();
            this.categoryStatsLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Controls.Add(this.userInfoLabel);
            this.mainPanel.Controls.Add(this.generalStatsLabel);
            this.mainPanel.Controls.Add(this.categoryStatsLabel);
            this.mainPanel.Controls.Add(this.historyLabel);
            this.mainPanel.Controls.Add(this.historyListBox);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Location = new System.Drawing.Point(10, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 615);
            this.mainPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(10, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(700, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Детальная статистика";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfoLabel.Location = new System.Drawing.Point(10, 66);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(700, 143);
            this.userInfoLabel.TabIndex = 1;
            this.userInfoLabel.Text = "Информация о пользователе";
            // 
            // generalStatsLabel
            // 
            this.generalStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalStatsLabel.Location = new System.Drawing.Point(10, 219);
            this.generalStatsLabel.Name = "generalStatsLabel";
            this.generalStatsLabel.Size = new System.Drawing.Size(700, 223);
            this.generalStatsLabel.TabIndex = 2;
            this.generalStatsLabel.Text = "Общая статистика";
            // 
            // categoryStatsLabel
            // 
            this.categoryStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryStatsLabel.Location = new System.Drawing.Point(10, 442);
            this.categoryStatsLabel.Name = "categoryStatsLabel";
            this.categoryStatsLabel.Size = new System.Drawing.Size(700, 300);
            this.categoryStatsLabel.TabIndex = 3;
            this.categoryStatsLabel.Text = "Статистика по категориям";
            this.categoryStatsLabel.Click += new System.EventHandler(this.categoryStatsLabel_Click);
            // 
            // historyLabel
            // 
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyLabel.Location = new System.Drawing.Point(10, 790);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(700, 40);
            this.historyLabel.TabIndex = 4;
            this.historyLabel.Text = "История последних 10 игр:";
            this.historyLabel.Click += new System.EventHandler(this.historyLabel_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 29;
            this.historyListBox.Location = new System.Drawing.Point(10, 832);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(700, 149);
            this.historyListBox.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(258, 987);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(233, 72);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 637);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика игрока";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label generalStatsLabel;
        private System.Windows.Forms.Label categoryStatsLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button closeButton;
    }
}