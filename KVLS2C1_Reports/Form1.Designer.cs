
namespace KVLS2C1_Reports
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comBtn = new System.Windows.Forms.Button();
            this.LIST = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BITCombo = new System.Windows.Forms.ComboBox();
            this.comRichbox = new System.Windows.Forms.RichTextBox();
            this.BITRichBox = new System.Windows.Forms.RichTextBox();
            this.comSendTbox = new System.Windows.Forms.TextBox();
            this.comSendbtn = new System.Windows.Forms.Button();
            this.comClearBtn = new System.Windows.Forms.Button();
            this.comCrLfBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBaudBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.LIST.SuspendLayout();
            this.SuspendLayout();
            // 
            // comCombo
            // 
            this.comCombo.FormattingEnabled = true;
            this.comCombo.Location = new System.Drawing.Point(24, 24);
            this.comCombo.Name = "comCombo";
            this.comCombo.Size = new System.Drawing.Size(104, 20);
            this.comCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBaudBox);
            this.groupBox1.Controls.Add(this.comBtn);
            this.groupBox1.Controls.Add(this.comCombo);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // comBtn
            // 
            this.comBtn.Location = new System.Drawing.Point(24, 50);
            this.comBtn.Name = "comBtn";
            this.comBtn.Size = new System.Drawing.Size(213, 27);
            this.comBtn.TabIndex = 1;
            this.comBtn.Text = "Connection";
            this.comBtn.UseVisualStyleBackColor = true;
            this.comBtn.Click += new System.EventHandler(this.comBtn_Click);
            // 
            // LIST
            // 
            this.LIST.Controls.Add(this.button1);
            this.LIST.Controls.Add(this.BITCombo);
            this.LIST.Location = new System.Drawing.Point(487, 12);
            this.LIST.Name = "LIST";
            this.LIST.Size = new System.Drawing.Size(270, 98);
            this.LIST.TabIndex = 2;
            this.LIST.TabStop = false;
            this.LIST.Text = "COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BITCombo
            // 
            this.BITCombo.FormattingEnabled = true;
            this.BITCombo.Location = new System.Drawing.Point(24, 24);
            this.BITCombo.Name = "BITCombo";
            this.BITCombo.Size = new System.Drawing.Size(213, 20);
            this.BITCombo.TabIndex = 0;
            this.BITCombo.SelectedIndexChanged += new System.EventHandler(this.BITCombo_SelectedIndexChanged);
            // 
            // comRichbox
            // 
            this.comRichbox.Location = new System.Drawing.Point(10, 133);
            this.comRichbox.Name = "comRichbox";
            this.comRichbox.Size = new System.Drawing.Size(391, 180);
            this.comRichbox.TabIndex = 3;
            this.comRichbox.Text = "";
            // 
            // BITRichBox
            // 
            this.BITRichBox.Location = new System.Drawing.Point(487, 133);
            this.BITRichBox.Name = "BITRichBox";
            this.BITRichBox.Size = new System.Drawing.Size(350, 180);
            this.BITRichBox.TabIndex = 4;
            this.BITRichBox.Text = "";
            // 
            // comSendTbox
            // 
            this.comSendTbox.Location = new System.Drawing.Point(13, 332);
            this.comSendTbox.Name = "comSendTbox";
            this.comSendTbox.Size = new System.Drawing.Size(161, 21);
            this.comSendTbox.TabIndex = 5;
            // 
            // comSendbtn
            // 
            this.comSendbtn.Location = new System.Drawing.Point(245, 332);
            this.comSendbtn.Name = "comSendbtn";
            this.comSendbtn.Size = new System.Drawing.Size(75, 23);
            this.comSendbtn.TabIndex = 6;
            this.comSendbtn.Text = "Send";
            this.comSendbtn.UseVisualStyleBackColor = true;
            this.comSendbtn.Click += new System.EventHandler(this.comSendbtn_Click);
            // 
            // comClearBtn
            // 
            this.comClearBtn.Location = new System.Drawing.Point(326, 332);
            this.comClearBtn.Name = "comClearBtn";
            this.comClearBtn.Size = new System.Drawing.Size(75, 23);
            this.comClearBtn.TabIndex = 7;
            this.comClearBtn.Text = "Clear";
            this.comClearBtn.UseVisualStyleBackColor = true;
            this.comClearBtn.Click += new System.EventHandler(this.comClearBtn_Click);
            // 
            // comCrLfBox
            // 
            this.comCrLfBox.AutoSize = true;
            this.comCrLfBox.Location = new System.Drawing.Point(178, 336);
            this.comCrLfBox.Name = "comCrLfBox";
            this.comCrLfBox.Size = new System.Drawing.Size(61, 16);
            this.comCrLfBox.TabIndex = 8;
            this.comCrLfBox.Text = "CR/LF";
            this.comCrLfBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // comBaudBox
            // 
            this.comBaudBox.FormattingEnabled = true;
            this.comBaudBox.Location = new System.Drawing.Point(134, 24);
            this.comBaudBox.Name = "comBaudBox";
            this.comBaudBox.Size = new System.Drawing.Size(104, 20);
            this.comBaudBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comCrLfBox);
            this.Controls.Add(this.comClearBtn);
            this.Controls.Add(this.comSendbtn);
            this.Controls.Add(this.comSendTbox);
            this.Controls.Add(this.BITRichBox);
            this.Controls.Add(this.comRichbox);
            this.Controls.Add(this.LIST);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.LIST.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button comBtn;
        private System.Windows.Forms.GroupBox LIST;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox BITCombo;
        private System.Windows.Forms.RichTextBox comRichbox;
        private System.Windows.Forms.RichTextBox BITRichBox;
        private System.Windows.Forms.TextBox comSendTbox;
        private System.Windows.Forms.Button comSendbtn;
        private System.Windows.Forms.Button comClearBtn;
        private System.Windows.Forms.CheckBox comCrLfBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBaudBox;
    }
}

