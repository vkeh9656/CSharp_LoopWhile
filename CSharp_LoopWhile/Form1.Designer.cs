namespace CSharp_LoopWhile
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
            this.lblWhileResult = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lboxWhileResult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.lblDoWhile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhileResult
            // 
            this.lblWhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWhileResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWhileResult.Location = new System.Drawing.Point(12, 27);
            this.lblWhileResult.Name = "lblWhileResult";
            this.lblWhileResult.Size = new System.Drawing.Size(166, 25);
            this.lblWhileResult.TabIndex = 0;
            this.lblWhileResult.Text = "0, 0, 0, 0, 0, 0.";
            this.lblWhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(184, 27);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "로또 번호";
            this.btnWhile.UseVisualStyleBackColor = true;
            // 
            // lboxWhileResult
            // 
            this.lboxWhileResult.FormattingEnabled = true;
            this.lboxWhileResult.ItemHeight = 12;
            this.lboxWhileResult.Location = new System.Drawing.Point(14, 55);
            this.lboxWhileResult.Name = "lboxWhileResult";
            this.lboxWhileResult.Size = new System.Drawing.Size(164, 124);
            this.lboxWhileResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(14, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 3;
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(91, 237);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 4;
            this.btnDoWhile.Text = "선택 번호";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 ~ 100 안의 숫자를 선택하세요.";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 237);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(59, 21);
            this.tboxNumber.TabIndex = 6;
            // 
            // lblDoWhile
            // 
            this.lblDoWhile.AutoSize = true;
            this.lblDoWhile.Location = new System.Drawing.Point(12, 279);
            this.lblDoWhile.Name = "lblDoWhile";
            this.lblDoWhile.Size = new System.Drawing.Size(9, 10);
            this.lblDoWhile.TabIndex = 7;
            this.lblDoWhile.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 317);
            this.Controls.Add(this.lblDoWhile);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxWhileResult);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lblWhileResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhileResult;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox lboxWhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Label lblDoWhile;
    }
}

