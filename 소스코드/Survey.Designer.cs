
namespace TEST_Project
{
    partial class Survey
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
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
            this.LikeFood = new System.Windows.Forms.Label();
            this.HateFood = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.LikeClr = new System.Windows.Forms.Label();
            this.HateClr = new System.Windows.Forms.Label();
            this.GoodBad = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LikeC = new System.Windows.Forms.Label();
            this.HateC = new System.Windows.Forms.Label();
            this.LikeF = new System.Windows.Forms.TextBox();
            this.HateF = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Finish = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LikeFood
            // 
            this.LikeFood.AutoSize = true;
            this.LikeFood.Location = new System.Drawing.Point(33, 185);
            this.LikeFood.Name = "LikeFood";
            this.LikeFood.Size = new System.Drawing.Size(102, 15);
            this.LikeFood.TabIndex = 0;
            this.LikeFood.Text = "좋아하는 음식";
            // 
            // HateFood
            // 
            this.HateFood.AutoSize = true;
            this.HateFood.Location = new System.Drawing.Point(33, 240);
            this.HateFood.Name = "HateFood";
            this.HateFood.Size = new System.Drawing.Size(102, 15);
            this.HateFood.TabIndex = 0;
            this.HateFood.Text = "싫어하는 음식";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(33, 29);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(37, 15);
            this.gender.TabIndex = 0;
            this.gender.Text = "성별";
            // 
            // LikeClr
            // 
            this.LikeClr.AutoSize = true;
            this.LikeClr.Location = new System.Drawing.Point(33, 79);
            this.LikeClr.Name = "LikeClr";
            this.LikeClr.Size = new System.Drawing.Size(102, 15);
            this.LikeClr.TabIndex = 0;
            this.LikeClr.Text = "좋아하는 색깔";
            // 
            // HateClr
            // 
            this.HateClr.AutoSize = true;
            this.HateClr.Location = new System.Drawing.Point(33, 131);
            this.HateClr.Name = "HateClr";
            this.HateClr.Size = new System.Drawing.Size(102, 15);
            this.HateClr.TabIndex = 0;
            this.HateClr.Text = "싫어하는 색깔";
            // 
            // GoodBad
            // 
            this.GoodBad.AutoSize = true;
            this.GoodBad.Location = new System.Drawing.Point(32, 307);
            this.GoodBad.Name = "GoodBad";
            this.GoodBad.Size = new System.Drawing.Size(205, 15);
            this.GoodBad.TabIndex = 0;
            this.GoodBad.Text = "설문조사에 만족 하셨습니까?";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(31, 22);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 19);
            this.male.TabIndex = 1;
            this.male.Text = "남성";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(149, 22);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(58, 19);
            this.female.TabIndex = 1;
            this.female.Text = "여성";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "색 선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "색 선택";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LikeC
            // 
            this.LikeC.BackColor = System.Drawing.SystemColors.Info;
            this.LikeC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LikeC.Location = new System.Drawing.Point(282, 75);
            this.LikeC.Name = "LikeC";
            this.LikeC.Size = new System.Drawing.Size(62, 32);
            this.LikeC.TabIndex = 3;
            // 
            // HateC
            // 
            this.HateC.BackColor = System.Drawing.SystemColors.Info;
            this.HateC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HateC.Location = new System.Drawing.Point(282, 123);
            this.HateC.Name = "HateC";
            this.HateC.Size = new System.Drawing.Size(62, 36);
            this.HateC.TabIndex = 3;
            // 
            // LikeF
            // 
            this.LikeF.Location = new System.Drawing.Point(164, 182);
            this.LikeF.MaxLength = 10;
            this.LikeF.Name = "LikeF";
            this.LikeF.Size = new System.Drawing.Size(180, 25);
            this.LikeF.TabIndex = 4;
            // 
            // HateF
            // 
            this.HateF.Location = new System.Drawing.Point(164, 237);
            this.HateF.MaxLength = 10;
            this.HateF.Name = "HateF";
            this.HateF.Size = new System.Drawing.Size(180, 25);
            this.HateF.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "예";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "아니오";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.female);
            this.panel1.Location = new System.Drawing.Point(108, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 67);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(36, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 56);
            this.panel2.TabIndex = 2;
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(139, 426);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(98, 43);
            this.Finish.TabIndex = 6;
            this.Finish.Text = "완료";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Visible = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "내용이 부족하다.",
            "주제와 연관이 없다.",
            "질문이 이해가 안된다.",
            "오류가 있다.",
            "기타"});
            this.checkedListBox1.Location = new System.Drawing.Point(36, 426);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(299, 100);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.Visible = false;
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 408);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HateF);
            this.Controls.Add(this.LikeF);
            this.Controls.Add(this.HateC);
            this.Controls.Add(this.LikeC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoodBad);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.HateClr);
            this.Controls.Add(this.LikeClr);
            this.Controls.Add(this.HateFood);
            this.Controls.Add(this.LikeFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Survey";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설문조사";
            this.Load += new System.EventHandler(this.Survey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LikeFood;
        private System.Windows.Forms.Label HateFood;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label LikeClr;
        private System.Windows.Forms.Label HateClr;
        private System.Windows.Forms.Label GoodBad;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LikeC;
        private System.Windows.Forms.Label HateC;
        private System.Windows.Forms.TextBox LikeF;
        private System.Windows.Forms.TextBox HateF;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
