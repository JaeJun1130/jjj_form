namespace WindowsFormsApp1
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.lbResult1 = new System.Windows.Forms.ListBox();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(21, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(29, 12);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "선택";
            // 
            // cbbSelect
            // 
            this.cbbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.Items.AddRange(new object[] {
            "2 단",
            "3 단",
            "4 단",
            "5 단",
            "6 단",
            "7 단",
            "8 단",
            "9 단"});
            this.cbbSelect.Location = new System.Drawing.Point(56, 6);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.Size = new System.Drawing.Size(157, 20);
            this.cbbSelect.TabIndex = 1;
            this.cbbSelect.SelectedIndexChanged += new System.EventHandler(this.cbbSelect_SelectedIndexChanged);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(23, 51);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(190, 362);
            this.lbResult.TabIndex = 2;
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            // 
            // lbResult1
            // 
            this.lbResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult1.FormattingEnabled = true;
            this.lbResult1.ItemHeight = 12;
            this.lbResult1.Location = new System.Drawing.Point(290, 51);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(190, 362);
            this.lbResult1.TabIndex = 3;

            // 
            // cbbTime
            // 
            this.cbbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Items.AddRange(new object[] {
            "0 1 시",
            "0 2 시",
            "0 3 시",
            "0 4 시",
            "0 5 시",
            "0 6 시",
            "0 7 시",
            "0 8 시",
            "0 9 시",
            "1 0 시",
            "1 1 시",
            "1 2 시",
            "1 3 시",
            "1 4 시"});
            this.cbbTime.Location = new System.Drawing.Point(323, 9);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(157, 20);
            this.cbbTime.TabIndex = 5;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "시";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 459);
            this.Controls.Add(this.cbbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbbSelect);
            this.Controls.Add(this.lblSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "구구단 시";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbbSelect;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.ListBox lbResult1;
        private System.Windows.Forms.ComboBox cbbTime;
        private System.Windows.Forms.Label label1;
    }
}

