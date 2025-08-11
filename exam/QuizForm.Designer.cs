namespace exam
{
    partial class QuizForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.answer0Radio = new System.Windows.Forms.RadioButton();
            this.answer1Radio = new System.Windows.Forms.RadioButton();
            this.answer2Radio = new System.Windows.Forms.RadioButton();
            this.answer3Radio = new System.Windows.Forms.RadioButton();
            this.answer0Check = new System.Windows.Forms.CheckBox();
            this.answer1Check = new System.Windows.Forms.CheckBox();
            this.answer2Check = new System.Windows.Forms.CheckBox();
            this.answer3Check = new System.Windows.Forms.CheckBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(25, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(750, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Название викторины";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(25, 70);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(750, 30);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос 1 из 10";
            this.questionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(25, 100);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(750, 80);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "Текст вопроса";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.instructionLabel.Location = new System.Drawing.Point(25, 180);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(750, 20);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Выберите правильный вариант ответа:";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // answer0Radio
            // 
            this.answer0Radio.AutoSize = false;
            this.answer0Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer0Radio.Location = new System.Drawing.Point(50, 210);
            this.answer0Radio.Name = "answer0Radio";
            this.answer0Radio.Size = new System.Drawing.Size(700, 60);
            this.answer0Radio.TabIndex = 4;
            this.answer0Radio.TabStop = true;
            this.answer0Radio.Text = "Вариант ответа 1";
            this.answer0Radio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer0Radio.UseVisualStyleBackColor = true;
            // 
            // answer1Radio
            // 
            this.answer1Radio.AutoSize = false;
            this.answer1Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1Radio.Location = new System.Drawing.Point(50, 280);
            this.answer1Radio.Name = "answer1Radio";
            this.answer1Radio.Size = new System.Drawing.Size(700, 60);
            this.answer1Radio.TabIndex = 5;
            this.answer1Radio.TabStop = true;
            this.answer1Radio.Text = "Вариант ответа 2";
            this.answer1Radio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer1Radio.UseVisualStyleBackColor = true;
            // 
            // answer2Radio
            // 
            this.answer2Radio.AutoSize = false;
            this.answer2Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2Radio.Location = new System.Drawing.Point(50, 350);
            this.answer2Radio.Name = "answer2Radio";
            this.answer2Radio.Size = new System.Drawing.Size(700, 60);
            this.answer2Radio.TabIndex = 6;
            this.answer2Radio.TabStop = true;
            this.answer2Radio.Text = "Вариант ответа 3";
            this.answer2Radio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer2Radio.UseVisualStyleBackColor = true;
            // 
            // answer3Radio
            // 
            this.answer3Radio.AutoSize = false;
            this.answer3Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3Radio.Location = new System.Drawing.Point(50, 420);
            this.answer3Radio.Name = "answer3Radio";
            this.answer3Radio.Size = new System.Drawing.Size(700, 60);
            this.answer3Radio.TabIndex = 7;
            this.answer3Radio.TabStop = true;
            this.answer3Radio.Text = "Вариант ответа 4";
            this.answer3Radio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer3Radio.UseVisualStyleBackColor = true;
            // 
            // answer0Check
            // 
            this.answer0Check.AutoSize = false;
            this.answer0Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer0Check.Location = new System.Drawing.Point(50, 210);
            this.answer0Check.Name = "answer0Check";
            this.answer0Check.Size = new System.Drawing.Size(700, 60);
            this.answer0Check.TabIndex = 8;
            this.answer0Check.Text = "Вариант ответа 1";
            this.answer0Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer0Check.UseVisualStyleBackColor = true;
            this.answer0Check.Visible = false;
            // 
            // answer1Check
            // 
            this.answer1Check.AutoSize = false;
            this.answer1Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1Check.Location = new System.Drawing.Point(50, 280);
            this.answer1Check.Name = "answer1Check";
            this.answer1Check.Size = new System.Drawing.Size(700, 60);
            this.answer1Check.TabIndex = 9;
            this.answer1Check.Text = "Вариант ответа 2";
            this.answer1Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer1Check.UseVisualStyleBackColor = true;
            this.answer1Check.Visible = false;
            // 
            // answer2Check
            // 
            this.answer2Check.AutoSize = false;
            this.answer2Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2Check.Location = new System.Drawing.Point(50, 350);
            this.answer2Check.Name = "answer2Check";
            this.answer2Check.Size = new System.Drawing.Size(700, 60);
            this.answer2Check.TabIndex = 10;
            this.answer2Check.Text = "Вариант ответа 3";
            this.answer2Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer2Check.UseVisualStyleBackColor = true;
            this.answer2Check.Visible = false;
            // 
            // answer3Check
            // 
            this.answer3Check.AutoSize = false;
            this.answer3Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3Check.Location = new System.Drawing.Point(50, 420);
            this.answer3Check.Name = "answer3Check";
            this.answer3Check.Size = new System.Drawing.Size(700, 60);
            this.answer3Check.TabIndex = 11;
            this.answer3Check.Text = "Вариант ответа 4";
            this.answer3Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer3Check.UseVisualStyleBackColor = true;
            this.answer3Check.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(500, 500);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(180, 40);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Следующий вопрос";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishButton.Location = new System.Drawing.Point(300, 500);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(120, 40);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Завершить";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answer3Check);
            this.Controls.Add(this.answer2Check);
            this.Controls.Add(this.answer1Check);
            this.Controls.Add(this.answer0Check);
            this.Controls.Add(this.answer3Radio);
            this.Controls.Add(this.answer2Radio);
            this.Controls.Add(this.answer1Radio);
            this.Controls.Add(this.answer0Radio);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викторина";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.RadioButton answer0Radio;
        private System.Windows.Forms.RadioButton answer1Radio;
        private System.Windows.Forms.RadioButton answer2Radio;
        private System.Windows.Forms.RadioButton answer3Radio;
        private System.Windows.Forms.CheckBox answer0Check;
        private System.Windows.Forms.CheckBox answer1Check;
        private System.Windows.Forms.CheckBox answer2Check;
        private System.Windows.Forms.CheckBox answer3Check;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button finishButton;
    }
}