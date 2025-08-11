namespace exam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.authTabControl = new System.Windows.Forms.TabControl();
            this.signInTab = new System.Windows.Forms.TabPage();
            this.signIn = new System.Windows.Forms.GroupBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordSignInTextBox = new System.Windows.Forms.TextBox();
            this.loginSIgnInTextBox = new System.Windows.Forms.TextBox();
            this.loginSignIn = new System.Windows.Forms.Label();
            this.passwordSignIn = new System.Windows.Forms.Label();
            this.signUpTab = new System.Windows.Forms.TabPage();
            this.signUp = new System.Windows.Forms.GroupBox();
            this.signUpCalendar = new System.Windows.Forms.MonthCalendar();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordSignUpTextBox = new System.Windows.Forms.TextBox();
            this.loginSignUpTextBox = new System.Windows.Forms.TextBox();
            this.loginSignUp = new System.Windows.Forms.Label();
            this.loginSignPassword = new System.Windows.Forms.Label();
            this.authTabControl.SuspendLayout();
            this.signInTab.SuspendLayout();
            this.signIn.SuspendLayout();
            this.signUpTab.SuspendLayout();
            this.signUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // authTabControl
            // 
            this.authTabControl.Controls.Add(this.signInTab);
            this.authTabControl.Controls.Add(this.signUpTab);
            this.authTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authTabControl.Location = new System.Drawing.Point(12, 12);
            this.authTabControl.Name = "authTabControl";
            this.authTabControl.SelectedIndex = 0;
            this.authTabControl.Size = new System.Drawing.Size(776, 426);
            this.authTabControl.TabIndex = 0;
            // 
            // signInTab
            // 
            this.signInTab.BackgroundImage = global::exam.Properties.Resources.background;
            this.signInTab.Controls.Add(this.signIn);
            this.signInTab.Location = new System.Drawing.Point(4, 47);
            this.signInTab.Name = "signInTab";
            this.signInTab.Padding = new System.Windows.Forms.Padding(3);
            this.signInTab.Size = new System.Drawing.Size(768, 375);
            this.signInTab.TabIndex = 0;
            this.signInTab.Text = "Вход";
            this.signInTab.UseVisualStyleBackColor = true;
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.LightCyan;
            this.signIn.Controls.Add(this.signInButton);
            this.signIn.Controls.Add(this.passwordSignInTextBox);
            this.signIn.Controls.Add(this.loginSIgnInTextBox);
            this.signIn.Controls.Add(this.loginSignIn);
            this.signIn.Controls.Add(this.passwordSignIn);
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn.Location = new System.Drawing.Point(161, 59);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(439, 249);
            this.signIn.TabIndex = 3;
            this.signIn.TabStop = false;
            this.signIn.Text = "Вход:";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(41, 182);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(355, 44);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            // 
            // passwordSignInTextBox
            // 
            this.passwordSignInTextBox.Location = new System.Drawing.Point(138, 123);
            this.passwordSignInTextBox.Name = "passwordSignInTextBox";
            this.passwordSignInTextBox.Size = new System.Drawing.Size(258, 38);
            this.passwordSignInTextBox.TabIndex = 3;
            // 
            // loginSIgnInTextBox
            // 
            this.loginSIgnInTextBox.Location = new System.Drawing.Point(138, 55);
            this.loginSIgnInTextBox.Name = "loginSIgnInTextBox";
            this.loginSIgnInTextBox.Size = new System.Drawing.Size(258, 38);
            this.loginSIgnInTextBox.TabIndex = 2;
            // 
            // loginSignIn
            // 
            this.loginSignIn.AutoSize = true;
            this.loginSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSignIn.Location = new System.Drawing.Point(36, 61);
            this.loginSignIn.Name = "loginSignIn";
            this.loginSignIn.Size = new System.Drawing.Size(82, 29);
            this.loginSignIn.TabIndex = 0;
            this.loginSignIn.Text = "Логин";
            // 
            // passwordSignIn
            // 
            this.passwordSignIn.AutoSize = true;
            this.passwordSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordSignIn.Location = new System.Drawing.Point(36, 129);
            this.passwordSignIn.Name = "passwordSignIn";
            this.passwordSignIn.Size = new System.Drawing.Size(96, 29);
            this.passwordSignIn.TabIndex = 1;
            this.passwordSignIn.Text = "Пароль";
            // 
            // signUpTab
            // 
            this.signUpTab.BackgroundImage = global::exam.Properties.Resources.background;
            this.signUpTab.Controls.Add(this.signUp);
            this.signUpTab.Location = new System.Drawing.Point(4, 47);
            this.signUpTab.Name = "signUpTab";
            this.signUpTab.Padding = new System.Windows.Forms.Padding(3);
            this.signUpTab.Size = new System.Drawing.Size(768, 375);
            this.signUpTab.TabIndex = 1;
            this.signUpTab.Text = "Регистрация";
            this.signUpTab.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.LightCyan;
            this.signUp.Controls.Add(this.signUpCalendar);
            this.signUp.Controls.Add(this.signUpButton);
            this.signUp.Controls.Add(this.passwordSignUpTextBox);
            this.signUp.Controls.Add(this.loginSignUpTextBox);
            this.signUp.Controls.Add(this.loginSignUp);
            this.signUp.Controls.Add(this.loginSignPassword);
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUp.Location = new System.Drawing.Point(76, 58);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(620, 249);
            this.signUp.TabIndex = 4;
            this.signUp.TabStop = false;
            this.signUp.Text = "Регистрация:";
            // 
            // signUpCalendar
            // 
            this.signUpCalendar.Location = new System.Drawing.Point(393, 19);
            this.signUpCalendar.Name = "signUpCalendar";
            this.signUpCalendar.TabIndex = 5;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(41, 182);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(310, 44);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // passwordSignUpTextBox
            // 
            this.passwordSignUpTextBox.Location = new System.Drawing.Point(138, 123);
            this.passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            this.passwordSignUpTextBox.Size = new System.Drawing.Size(213, 38);
            this.passwordSignUpTextBox.TabIndex = 3;
            // 
            // loginSignUpTextBox
            // 
            this.loginSignUpTextBox.Location = new System.Drawing.Point(138, 55);
            this.loginSignUpTextBox.Name = "loginSignUpTextBox";
            this.loginSignUpTextBox.Size = new System.Drawing.Size(213, 38);
            this.loginSignUpTextBox.TabIndex = 2;
            // 
            // loginSignUp
            // 
            this.loginSignUp.AutoSize = true;
            this.loginSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSignUp.Location = new System.Drawing.Point(36, 61);
            this.loginSignUp.Name = "loginSignUp";
            this.loginSignUp.Size = new System.Drawing.Size(82, 29);
            this.loginSignUp.TabIndex = 0;
            this.loginSignUp.Text = "Логин";
            // 
            // loginSignPassword
            // 
            this.loginSignPassword.AutoSize = true;
            this.loginSignPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSignPassword.Location = new System.Drawing.Point(36, 129);
            this.loginSignPassword.Name = "loginSignPassword";
            this.loginSignPassword.Size = new System.Drawing.Size(96, 29);
            this.loginSignPassword.TabIndex = 1;
            this.loginSignPassword.Text = "Пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authTabControl);
            this.Name = "Form1";
            this.Text = "Викторина";
            this.authTabControl.ResumeLayout(false);
            this.signInTab.ResumeLayout(false);
            this.signIn.ResumeLayout(false);
            this.signIn.PerformLayout();
            this.signUpTab.ResumeLayout(false);
            this.signUp.ResumeLayout(false);
            this.signUp.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl authTabControl;
        private System.Windows.Forms.TabPage signInTab;
        private System.Windows.Forms.TabPage signUpTab;
        private System.Windows.Forms.Label passwordSignIn;
        private System.Windows.Forms.Label loginSignIn;
        private System.Windows.Forms.GroupBox signIn;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordSignInTextBox;
        private System.Windows.Forms.TextBox loginSIgnInTextBox;
        private System.Windows.Forms.GroupBox signUp;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox passwordSignUpTextBox;
        private System.Windows.Forms.TextBox loginSignUpTextBox;
        private System.Windows.Forms.Label loginSignUp;
        private System.Windows.Forms.Label loginSignPassword;
        private System.Windows.Forms.MonthCalendar signUpCalendar;
    }
}

