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
            // Echo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 443);
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
    }
}
