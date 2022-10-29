
namespace TEST_Project
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pwPanel = new System.Windows.Forms.Panel();
            this.Unfinish = new System.Windows.Forms.Label();
            this.AdminPw = new System.Windows.Forms.TextBox();
            this.Finish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pwPanel
            // 
            this.pwPanel.Controls.Add(this.AdminPw);
            this.pwPanel.Controls.Add(this.label2);
            this.pwPanel.Location = new System.Drawing.Point(151, 142);
            this.pwPanel.Name = "pwPanel";
            this.pwPanel.Size = new System.Drawing.Size(501, 115);
            this.pwPanel.TabIndex = 0;
            // 
            // Unfinish
            // 
            this.Unfinish.AutoSize = true;
            this.Unfinish.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Unfinish.Location = new System.Drawing.Point(305, 237);
            this.Unfinish.Name = "Unfinish";
            this.Unfinish.Size = new System.Drawing.Size(193, 20);
            this.Unfinish.TabIndex = 3;
            this.Unfinish.Text = "참여하지 않은 인원";
            this.Unfinish.Visible = false;
            this.Unfinish.Click += new System.EventHandler(this.Unfinish_Click);
            // 
            // AdminPw
            // 
            this.AdminPw.BackColor = System.Drawing.SystemColors.Desktop;
            this.AdminPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPw.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AdminPw.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AdminPw.Location = new System.Drawing.Point(204, 46);
            this.AdminPw.Name = "AdminPw";
            this.AdminPw.Size = new System.Drawing.Size(284, 23);
            this.AdminPw.TabIndex = 1;
            this.AdminPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminPw_KeyDown);
            // 
            // Finish
            // 
            this.Finish.AutoSize = true;
            this.Finish.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Finish.Location = new System.Drawing.Point(335, 155);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(122, 20);
            this.Finish.TabIndex = 2;
            this.Finish.Text = "참여한 인원";
            this.Finish.Visible = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "암호를 입력하시오 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "종료 : ESC 입력완료 : ENTER";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwPanel);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Unfinish);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Admin";
            this.Text = "관리자 모드";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pwPanel.ResumeLayout(false);
            this.pwPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pwPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminPw;
        private System.Windows.Forms.Label Finish;
        private System.Windows.Forms.Label Unfinish;
    }
}