namespace exam
{
    partial class Form2
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.quizTab = new System.Windows.Forms.TabPage();
            this.startQuiz = new System.Windows.Forms.Label();
            this.startGeneralQuiz = new System.Windows.Forms.Button();
            this.startRandomQuiz = new System.Windows.Forms.Button();
            this.startComboQuiz = new System.Windows.Forms.Button();
            this.quizCombo = new System.Windows.Forms.ComboBox();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.birthChangeCalendar = new System.Windows.Forms.MonthCalendar();
            this.showStats = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.changeProfileButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.ratingTab = new System.Windows.Forms.TabPage();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quizRankingsListBox = new System.Windows.Forms.ListBox();
            this.editorTab = new System.Windows.Forms.TabPage();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.editDeleteQuizButton = new System.Windows.Forms.Button();
            this.editNewQuizButton = new System.Windows.Forms.Button();
            this.editQuestionsPanel = new System.Windows.Forms.Panel();
            this.editQuizTitleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editQuizCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exitTab = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.quizTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.ratingTab.SuspendLayout();
            this.editorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.quizTab);
            this.mainTabControl.Controls.Add(this.profileTab);
            this.mainTabControl.Controls.Add(this.ratingTab);
            this.mainTabControl.Controls.Add(this.editorTab);
            this.mainTabControl.Controls.Add(this.exitTab);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(776, 426);
            this.mainTabControl.TabIndex = 0;
            // 
            // quizTab
            // 
            this.quizTab.BackgroundImage = global::exam.Properties.Resources.background2;
            this.quizTab.Controls.Add(this.startQuiz);
            this.quizTab.Controls.Add(this.startGeneralQuiz);
            this.quizTab.Controls.Add(this.startRandomQuiz);
            this.quizTab.Controls.Add(this.startComboQuiz);
            this.quizTab.Controls.Add(this.quizCombo);
            this.quizTab.Location = new System.Drawing.Point(4, 40);
            this.quizTab.Name = "quizTab";
            this.quizTab.Padding = new System.Windows.Forms.Padding(3);
            this.quizTab.Size = new System.Drawing.Size(768, 382);
            this.quizTab.TabIndex = 0;
            this.quizTab.Text = "Викторины";
            this.quizTab.UseVisualStyleBackColor = true;
            // 
            // startQuiz
            // 
            this.startQuiz.AutoSize = true;
            this.startQuiz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startQuiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startQuiz.Location = new System.Drawing.Point(187, 64);
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.Size = new System.Drawing.Size(320, 34);
            this.startQuiz.TabIndex = 4;
            this.startQuiz.Text = "Стартовать викторину!";
            // 
            // startGeneralQuiz
            // 
            this.startGeneralQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGeneralQuiz.Location = new System.Drawing.Point(527, 131);
            this.startGeneralQuiz.Name = "startGeneralQuiz";
            this.startGeneralQuiz.Size = new System.Drawing.Size(216, 145);
            this.startGeneralQuiz.TabIndex = 3;
            this.startGeneralQuiz.Text = "Общая игра (вперемешку)";
            this.startGeneralQuiz.UseVisualStyleBackColor = true;
            // 
            // startRandomQuiz
            // 
            this.startRandomQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startRandomQuiz.Location = new System.Drawing.Point(315, 131);
            this.startRandomQuiz.Name = "startRandomQuiz";
            this.startRandomQuiz.Size = new System.Drawing.Size(193, 145);
            this.startRandomQuiz.TabIndex = 2;
            this.startRandomQuiz.Text = "Начать рандомную викторину";
            this.startRandomQuiz.UseVisualStyleBackColor = true;
            // 
            // startComboQuiz
            // 
            this.startComboQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startComboQuiz.Location = new System.Drawing.Point(31, 183);
            this.startComboQuiz.Name = "startComboQuiz";
            this.startComboQuiz.Size = new System.Drawing.Size(267, 93);
            this.startComboQuiz.TabIndex = 1;
            this.startComboQuiz.Text = "Начать игру\r\n(ручной выбор)";
            this.startComboQuiz.UseVisualStyleBackColor = true;
            // 
            // quizCombo
            // 
            this.quizCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizCombo.FormattingEnabled = true;
            this.quizCombo.Items.AddRange(new object[] {
            "История",
            "География",
            "Биология"});
            this.quizCombo.Location = new System.Drawing.Point(31, 131);
            this.quizCombo.Name = "quizCombo";
            this.quizCombo.Size = new System.Drawing.Size(267, 39);
            this.quizCombo.TabIndex = 0;
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.Color.AliceBlue;
            this.profileTab.Controls.Add(this.birthChangeCalendar);
            this.profileTab.Controls.Add(this.showStats);
            this.profileTab.Controls.Add(this.label8);
            this.profileTab.Controls.Add(this.label7);
            this.profileTab.Controls.Add(this.changeProfileButton);
            this.profileTab.Controls.Add(this.newPasswordTextBox);
            this.profileTab.Controls.Add(this.oldPasswordTextBox);
            this.profileTab.Controls.Add(this.birthDateLabel);
            this.profileTab.Controls.Add(this.loginLabel);
            this.profileTab.Controls.Add(this.label3);
            this.profileTab.Controls.Add(this.label2);
            this.profileTab.Controls.Add(this.profilePicture);
            this.profileTab.Location = new System.Drawing.Point(4, 47);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(768, 375);
            this.profileTab.TabIndex = 1;
            this.profileTab.Text = "Личный кабинет";
            // 
            // birthChangeCalendar
            // 
            this.birthChangeCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthChangeCalendar.Location = new System.Drawing.Point(305, 159);
            this.birthChangeCalendar.Name = "birthChangeCalendar";
            this.birthChangeCalendar.TabIndex = 12;
            // 
            // showStats
            // 
            this.showStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showStats.Location = new System.Drawing.Point(213, 108);
            this.showStats.Name = "showStats";
            this.showStats.Size = new System.Drawing.Size(536, 40);
            this.showStats.TabIndex = 11;
            this.showStats.Text = "Посмотреть свои результаты";
            this.showStats.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(37, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Новый пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(37, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Старый пароль:";
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProfileButton.Location = new System.Drawing.Point(540, 173);
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.Size = new System.Drawing.Size(209, 185);
            this.changeProfileButton.TabIndex = 8;
            this.changeProfileButton.Text = "Обновить информацию";
            this.changeProfileButton.UseVisualStyleBackColor = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(42, 320);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(251, 38);
            this.newPasswordTextBox.TabIndex = 7;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(42, 225);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(251, 38);
            this.oldPasswordTextBox.TabIndex = 6;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(513, 73);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(158, 32);
            this.birthDateLabel.TabIndex = 5;
            this.birthDateLabel.Text = "01.01.1970";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(207, 73);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(76, 32);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(513, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::exam.Properties.Resources.profile_img;
            this.profilePicture.InitialImage = global::exam.Properties.Resources.profile_img;
            this.profilePicture.Location = new System.Drawing.Point(42, 27);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(138, 140);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // ratingTab
            // 
            this.ratingTab.Controls.Add(this.categoryCombo);
            this.ratingTab.Controls.Add(this.label9);
            this.ratingTab.Controls.Add(this.quizRankingsListBox);
            this.ratingTab.Location = new System.Drawing.Point(4, 47);
            this.ratingTab.Name = "ratingTab";
            this.ratingTab.Size = new System.Drawing.Size(768, 375);
            this.ratingTab.TabIndex = 2;
            this.ratingTab.Text = "Рейтинг";
            this.ratingTab.UseVisualStyleBackColor = true;
            // 
            // categoryCombo
            // 
            this.categoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(326, 40);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(299, 39);
            this.categoryCombo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(160, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Категория:";
            // 
            // quizRankingsListBox
            // 
            this.quizRankingsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quizRankingsListBox.FormattingEnabled = true;
            this.quizRankingsListBox.ItemHeight = 31;
            this.quizRankingsListBox.Location = new System.Drawing.Point(62, 99);
            this.quizRankingsListBox.Name = "quizRankingsListBox";
            this.quizRankingsListBox.Size = new System.Drawing.Size(655, 221);
            this.quizRankingsListBox.TabIndex = 0;
            // 
            // editorTab
            // 
            this.editorTab.Controls.Add(this.editSaveButton);
            this.editorTab.Controls.Add(this.editDeleteQuizButton);
            this.editorTab.Controls.Add(this.editNewQuizButton);
            this.editorTab.Controls.Add(this.editQuestionsPanel);
            this.editorTab.Controls.Add(this.editQuizTitleTextBox);
            this.editorTab.Controls.Add(this.label11);
            this.editorTab.Controls.Add(this.editQuizCombo);
            this.editorTab.Controls.Add(this.label10);
            this.editorTab.Location = new System.Drawing.Point(4, 40);
            this.editorTab.Name = "editorTab";
            this.editorTab.Size = new System.Drawing.Size(768, 382);
            this.editorTab.TabIndex = 3;
            this.editorTab.Text = "Редактор";
            this.editorTab.UseVisualStyleBackColor = true;
            // 
            // editSaveButton
            // 
            this.editSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSaveButton.Location = new System.Drawing.Point(499, 60);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(132, 35);
            this.editSaveButton.TabIndex = 7;
            this.editSaveButton.Text = "Сохранить";
            this.editSaveButton.UseVisualStyleBackColor = true;
            // 
            // editDeleteQuizButton
            // 
            this.editDeleteQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDeleteQuizButton.Location = new System.Drawing.Point(637, 60);
            this.editDeleteQuizButton.Name = "editDeleteQuizButton";
            this.editDeleteQuizButton.Size = new System.Drawing.Size(114, 35);
            this.editDeleteQuizButton.TabIndex = 6;
            this.editDeleteQuizButton.Text = "Удалить";
            this.editDeleteQuizButton.UseVisualStyleBackColor = true;
            // 
            // editNewQuizButton
            // 
            this.editNewQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNewQuizButton.Location = new System.Drawing.Point(637, 19);
            this.editNewQuizButton.Name = "editNewQuizButton";
            this.editNewQuizButton.Size = new System.Drawing.Size(114, 35);
            this.editNewQuizButton.TabIndex = 5;
            this.editNewQuizButton.Text = "Новая";
            this.editNewQuizButton.UseVisualStyleBackColor = true;
            // 
            // editQuestionsPanel
            // 
            this.editQuestionsPanel.AutoScroll = true;
            this.editQuestionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editQuestionsPanel.Location = new System.Drawing.Point(15, 105);
            this.editQuestionsPanel.Name = "editQuestionsPanel";
            this.editQuestionsPanel.Size = new System.Drawing.Size(736, 255);
            this.editQuestionsPanel.TabIndex = 4;
            // 
            // editQuizTitleTextBox
            // 
            this.editQuizTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editQuizTitleTextBox.Location = new System.Drawing.Point(111, 60);
            this.editQuizTitleTextBox.Name = "editQuizTitleTextBox";
            this.editQuizTitleTextBox.Size = new System.Drawing.Size(382, 30);
            this.editQuizTitleTextBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(5, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Название:";
            // 
            // editQuizCombo
            // 
            this.editQuizCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editQuizCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editQuizCombo.FormattingEnabled = true;
            this.editQuizCombo.Location = new System.Drawing.Point(115, 20);
            this.editQuizCombo.Name = "editQuizCombo";
            this.editQuizCombo.Size = new System.Drawing.Size(382, 33);
            this.editQuizCombo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(2, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Викторина:";
            // 
            // exitTab
            // 
            this.exitTab.Location = new System.Drawing.Point(4, 47);
            this.exitTab.Name = "exitTab";
            this.exitTab.Size = new System.Drawing.Size(768, 375);
            this.exitTab.TabIndex = 4;
            this.exitTab.Text = "Выход";
            this.exitTab.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form2";
            this.Text = "Викторина";
            this.mainTabControl.ResumeLayout(false);
            this.quizTab.ResumeLayout(false);
            this.quizTab.PerformLayout();
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ratingTab.ResumeLayout(false);
            this.ratingTab.PerformLayout();
            this.editorTab.ResumeLayout(false);
            this.editorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage quizTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.Label startQuiz;
        private System.Windows.Forms.Button startGeneralQuiz;
        private System.Windows.Forms.Button startRandomQuiz;
        private System.Windows.Forms.Button startComboQuiz;
        private System.Windows.Forms.ComboBox quizCombo;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeProfileButton;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button showStats;
        private System.Windows.Forms.TabPage ratingTab;
        private System.Windows.Forms.TabPage editorTab;
        private System.Windows.Forms.TabPage exitTab;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox quizRankingsListBox;
        private System.Windows.Forms.MonthCalendar birthChangeCalendar;
        private System.Windows.Forms.Button editSaveButton;
        private System.Windows.Forms.Button editDeleteQuizButton;
        private System.Windows.Forms.Button editNewQuizButton;
        private System.Windows.Forms.Panel editQuestionsPanel;
        private System.Windows.Forms.TextBox editQuizTitleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox editQuizCombo;
        private System.Windows.Forms.Label label10;
    }
}