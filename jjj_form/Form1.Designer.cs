namespace jjj_form
{
    partial class Form1
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
            this.plQuestion = new System.Windows.Forms.Panel();
            this.grDrink = new System.Windows.Forms.GroupBox();
            this.chb03 = new System.Windows.Forms.CheckBox();
            this.rbtn03 = new System.Windows.Forms.RadioButton();
            this.btnPoll = new System.Windows.Forms.Button();
            this.gbSports = new System.Windows.Forms.GroupBox();
            this.chb02 = new System.Windows.Forms.CheckBox();
            this.chb01 = new System.Windows.Forms.CheckBox();
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.rbtn02 = new System.Windows.Forms.RadioButton();
            this.rbtn01 = new System.Windows.Forms.RadioButton();
            this.plResult = new System.Windows.Forms.Panel();
            this.IblMe = new System.Windows.Forms.Label();
            this.IblDrink = new System.Windows.Forms.Label();
            this.IblSports = new System.Windows.Forms.Label();
            this.IblHobby = new System.Windows.Forms.Label();
            this.gbMe = new System.Windows.Forms.GroupBox();
            this.chb07 = new System.Windows.Forms.CheckBox();
            this.chb06 = new System.Windows.Forms.CheckBox();
            this.chb05 = new System.Windows.Forms.CheckBox();
            this.chb04 = new System.Windows.Forms.CheckBox();
            this.plQuestion.SuspendLayout();
            this.grDrink.SuspendLayout();
            this.gbSports.SuspendLayout();
            this.gbHobby.SuspendLayout();
            this.plResult.SuspendLayout();
            this.gbMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // plQuestion
            // 
            this.plQuestion.BackColor = System.Drawing.Color.White;
            this.plQuestion.Controls.Add(this.grDrink);
            this.plQuestion.Controls.Add(this.btnPoll);
            this.plQuestion.Controls.Add(this.gbSports);
            this.plQuestion.Controls.Add(this.gbHobby);
            this.plQuestion.Location = new System.Drawing.Point(-5, 0);
            this.plQuestion.Name = "plQuestion";
            this.plQuestion.Size = new System.Drawing.Size(562, 427);
            this.plQuestion.TabIndex = 0;
            // 
            // grDrink
            // 
            this.grDrink.Controls.Add(this.chb03);
            this.grDrink.Controls.Add(this.rbtn03);
            this.grDrink.Location = new System.Drawing.Point(17, 230);
            this.grDrink.Name = "grDrink";
            this.grDrink.Size = new System.Drawing.Size(263, 100);
            this.grDrink.TabIndex = 4;
            this.grDrink.TabStop = false;
            this.grDrink.Text = "좋아하는 음료수는?";
            // 
            // chb03
            // 
            this.chb03.AutoSize = true;
            this.chb03.Location = new System.Drawing.Point(146, 44);
            this.chb03.Name = "chb03";
            this.chb03.Size = new System.Drawing.Size(48, 16);
            this.chb03.TabIndex = 2;
            this.chb03.Text = "콜라";
            this.chb03.UseVisualStyleBackColor = true;
            // 
            // rbtn03
            // 
            this.rbtn03.AutoSize = true;
            this.rbtn03.Location = new System.Drawing.Point(25, 44);
            this.rbtn03.Name = "rbtn03";
            this.rbtn03.Size = new System.Drawing.Size(59, 16);
            this.rbtn03.TabIndex = 2;
            this.rbtn03.TabStop = true;
            this.rbtn03.Text = "사이다";
            this.rbtn03.UseVisualStyleBackColor = true;
            // 
            // btnPoll
            // 
            this.btnPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoll.Location = new System.Drawing.Point(458, 307);
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(75, 23);
            this.btnPoll.TabIndex = 2;
            this.btnPoll.Text = "제출하기";
            this.btnPoll.UseVisualStyleBackColor = true;
            this.btnPoll.Click += new System.EventHandler(this.BtnPoll_Click);
            // 
            // gbSports
            // 
            this.gbSports.Controls.Add(this.chb02);
            this.gbSports.Controls.Add(this.chb01);
            this.gbSports.Location = new System.Drawing.Point(17, 109);
            this.gbSports.Name = "gbSports";
            this.gbSports.Size = new System.Drawing.Size(263, 100);
            this.gbSports.TabIndex = 1;
            this.gbSports.TabStop = false;
            this.gbSports.Text = "좋아하는 스포츠?";
            // 
            // chb02
            // 
            this.chb02.AutoSize = true;
            this.chb02.Location = new System.Drawing.Point(150, 48);
            this.chb02.Name = "chb02";
            this.chb02.Size = new System.Drawing.Size(48, 16);
            this.chb02.TabIndex = 1;
            this.chb02.Text = "농구";
            this.chb02.UseVisualStyleBackColor = true;
            this.chb02.CheckedChanged += new System.EventHandler(this.chb02_CheckedChanged);
            // 
            // chb01
            // 
            this.chb01.AutoSize = true;
            this.chb01.Location = new System.Drawing.Point(25, 48);
            this.chb01.Name = "chb01";
            this.chb01.Size = new System.Drawing.Size(48, 16);
            this.chb01.TabIndex = 0;
            this.chb01.Text = "축구";
            this.chb01.UseVisualStyleBackColor = true;
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.rbtn02);
            this.gbHobby.Controls.Add(this.rbtn01);
            this.gbHobby.Location = new System.Drawing.Point(17, 3);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(263, 100);
            this.gbHobby.TabIndex = 0;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "취미는?";
            // 
            // rbtn02
            // 
            this.rbtn02.AutoSize = true;
            this.rbtn02.Location = new System.Drawing.Point(150, 44);
            this.rbtn02.Name = "rbtn02";
            this.rbtn02.Size = new System.Drawing.Size(71, 16);
            this.rbtn02.TabIndex = 3;
            this.rbtn02.TabStop = true;
            this.rbtn02.Text = "영화보기";
            this.rbtn02.UseVisualStyleBackColor = true;
            // 
            // rbtn01
            // 
            this.rbtn01.AutoSize = true;
            this.rbtn01.Location = new System.Drawing.Point(25, 44);
            this.rbtn01.Name = "rbtn01";
            this.rbtn01.Size = new System.Drawing.Size(71, 16);
            this.rbtn01.TabIndex = 2;
            this.rbtn01.TabStop = true;
            this.rbtn01.Text = "독서하기";
            this.rbtn01.UseVisualStyleBackColor = true;
            // 
            // plResult
            // 
            this.plResult.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.plResult.Controls.Add(this.IblMe);
            this.plResult.Controls.Add(this.IblDrink);
            this.plResult.Controls.Add(this.IblSports);
            this.plResult.Controls.Add(this.IblHobby);
            this.plResult.Location = new System.Drawing.Point(-5, 336);
            this.plResult.Name = "plResult";
            this.plResult.Size = new System.Drawing.Size(562, 181);
            this.plResult.TabIndex = 1;
            // 
            // IblMe
            // 
            this.IblMe.AutoSize = true;
            this.IblMe.Location = new System.Drawing.Point(310, 38);
            this.IblMe.Name = "IblMe";
            this.IblMe.Size = new System.Drawing.Size(87, 12);
            this.IblMe.TabIndex = 3;
            this.IblMe.Text = "선택한 메뉴는?";
            // 
            // IblDrink
            // 
            this.IblDrink.AutoSize = true;
            this.IblDrink.Location = new System.Drawing.Point(40, 123);
            this.IblDrink.Name = "IblDrink";
            this.IblDrink.Size = new System.Drawing.Size(57, 12);
            this.IblDrink.TabIndex = 2;
            this.IblDrink.Text = "음료수는:";
            // 
            // IblSports
            // 
            this.IblSports.AutoSize = true;
            this.IblSports.Location = new System.Drawing.Point(40, 81);
            this.IblSports.Name = "IblSports";
            this.IblSports.Size = new System.Drawing.Size(59, 12);
            this.IblSports.TabIndex = 1;
            this.IblSports.Text = "스포츠는?";
            // 
            // IblHobby
            // 
            this.IblHobby.AutoSize = true;
            this.IblHobby.Location = new System.Drawing.Point(40, 38);
            this.IblHobby.Name = "IblHobby";
            this.IblHobby.Size = new System.Drawing.Size(45, 12);
            this.IblHobby.TabIndex = 0;
            this.IblHobby.Text = "취미는:";
            // 
            // gbMe
            // 
            this.gbMe.Controls.Add(this.chb07);
            this.gbMe.Controls.Add(this.chb06);
            this.gbMe.Controls.Add(this.chb05);
            this.gbMe.Controls.Add(this.chb04);
            this.gbMe.Location = new System.Drawing.Point(294, 12);
            this.gbMe.Name = "gbMe";
            this.gbMe.Size = new System.Drawing.Size(263, 197);
            this.gbMe.TabIndex = 2;
            this.gbMe.TabStop = false;
            this.gbMe.Text = "좋아하는 버거는? (한개만선택가능)";
            // 
            // chb07
            // 
            this.chb07.AutoSize = true;
            this.chb07.Location = new System.Drawing.Point(150, 118);
            this.chb07.Name = "chb07";
            this.chb07.Size = new System.Drawing.Size(108, 16);
            this.chb07.TabIndex = 3;
            this.chb07.Text = "한우불고기버거";
            this.chb07.UseVisualStyleBackColor = true;
            // 
            // chb06
            // 
            this.chb06.AutoSize = true;
            this.chb06.Location = new System.Drawing.Point(25, 118);
            this.chb06.Name = "chb06";
            this.chb06.Size = new System.Drawing.Size(84, 16);
            this.chb06.TabIndex = 2;
            this.chb06.Text = "불고기버거";
            this.chb06.UseVisualStyleBackColor = true;
            // 
            // chb05
            // 
            this.chb05.AutoSize = true;
            this.chb05.Location = new System.Drawing.Point(150, 48);
            this.chb05.Name = "chb05";
            this.chb05.Size = new System.Drawing.Size(72, 16);
            this.chb05.TabIndex = 1;
            this.chb05.Text = "새우버거";
            this.chb05.UseVisualStyleBackColor = true;
            // 
            // chb04
            // 
            this.chb04.AutoSize = true;
            this.chb04.Location = new System.Drawing.Point(25, 48);
            this.chb04.Name = "chb04";
            this.chb04.Size = new System.Drawing.Size(48, 16);
            this.chb04.TabIndex = 0;
            this.chb04.Text = "빅맥";
            this.chb04.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 516);
            this.Controls.Add(this.gbMe);
            this.Controls.Add(this.plResult);
            this.Controls.Add(this.plQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "로그인";
            this.plQuestion.ResumeLayout(false);
            this.grDrink.ResumeLayout(false);
            this.grDrink.PerformLayout();
            this.gbSports.ResumeLayout(false);
            this.gbSports.PerformLayout();
            this.gbHobby.ResumeLayout(false);
            this.gbHobby.PerformLayout();
            this.plResult.ResumeLayout(false);
            this.plResult.PerformLayout();
            this.gbMe.ResumeLayout(false);
            this.gbMe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plQuestion;
        private System.Windows.Forms.GroupBox gbSports;
        private System.Windows.Forms.CheckBox chb02;
        private System.Windows.Forms.CheckBox chb01;
        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.RadioButton rbtn02;
        private System.Windows.Forms.RadioButton rbtn01;
        private System.Windows.Forms.Panel plResult;
        private System.Windows.Forms.Label IblSports;
        private System.Windows.Forms.Label IblHobby;
        private System.Windows.Forms.Button btnPoll;
        private System.Windows.Forms.Label IblDrink;
        private System.Windows.Forms.GroupBox grDrink;
        private System.Windows.Forms.CheckBox chb03;
        private System.Windows.Forms.RadioButton rbtn03;
        private System.Windows.Forms.Label IblMe;
        private System.Windows.Forms.GroupBox gbMe;
        private System.Windows.Forms.CheckBox chb07;
        private System.Windows.Forms.CheckBox chb06;
        private System.Windows.Forms.CheckBox chb05;
        private System.Windows.Forms.CheckBox chb04;
    }
}

