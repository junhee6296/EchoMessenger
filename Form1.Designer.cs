namespace EchoMessenger
{
    partial class Echo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            listBoxMessages = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblCount = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("서울남산 장체 L", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblStatus.ForeColor = Color.DodgerBlue;
            lblStatus.Location = new Point(22, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(252, 42);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Echo Messenger";
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = SystemColors.InactiveCaption;
            listBoxMessages.Font = new Font("서울남산체 M", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.Location = new Point(31, 65);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(729, 280);
            listBoxMessages.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(31, 368);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(602, 29);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += Enterkey_Input;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Info;
            btnSend.Font = new Font("서울남산체 M", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(648, 368);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 59);
            btnSend.TabIndex = 3;
            btnSend.TabStop = false;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(31, 409);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(82, 16);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화 : 0개";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(550, 403);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 5;
            button1.TabStop = false;
            button1.Text = "전체삭제";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnClearALL_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Microsoft Sans Serif", 8.25F);
            button2.Location = new Point(461, 403);
            button2.Name = "button2";
            button2.Size = new Size(83, 29);
            button2.TabIndex = 6;
            button2.TabStop = false;
            button2.Text = "선택삭제";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClearSelect_Click;
            // 
            // Echo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 443);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblCount);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(listBoxMessages);
            Controls.Add(lblStatus);
            Name = "Echo";
            Text = " Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private ListBox listBoxMessages;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblCount;
        private Button button1;
        private Button button2;
    }
}
