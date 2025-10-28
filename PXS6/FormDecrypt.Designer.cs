namespace PXS6
{
    partial class FormDecrypt
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
            btn_copyMessage = new Button();
            btn_toEncryptMode = new Button();
            tb_checkSumTarget = new TextBox();
            btn_format = new Button();
            btn_decrypt = new Button();
            tb_keyMessage = new TextBox();
            tb_outputMessage = new TextBox();
            tb_inputMessage = new TextBox();
            tb_checkSum = new TextBox();
            tb_checkSumAnswer = new TextBox();
            btn_copyChecksum = new Button();
            SuspendLayout();
            // 
            // btn_copyMessage
            // 
            btn_copyMessage.Cursor = Cursors.Hand;
            btn_copyMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_copyMessage.Location = new Point(670, 52);
            btn_copyMessage.Name = "btn_copyMessage";
            btn_copyMessage.Size = new Size(94, 29);
            btn_copyMessage.TabIndex = 17;
            btn_copyMessage.Text = "Copy";
            btn_copyMessage.UseVisualStyleBackColor = true;
            btn_copyMessage.Click += btn_copyMessage_Click;
            // 
            // btn_toEncryptMode
            // 
            btn_toEncryptMode.BackColor = Color.Coral;
            btn_toEncryptMode.BackgroundImageLayout = ImageLayout.Center;
            btn_toEncryptMode.Cursor = Cursors.Hand;
            btn_toEncryptMode.FlatStyle = FlatStyle.Popup;
            btn_toEncryptMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_toEncryptMode.Location = new Point(642, 14);
            btn_toEncryptMode.Name = "btn_toEncryptMode";
            btn_toEncryptMode.Size = new Size(122, 29);
            btn_toEncryptMode.TabIndex = 15;
            btn_toEncryptMode.Text = "Decrypt Mode";
            btn_toEncryptMode.UseVisualStyleBackColor = false;
            btn_toEncryptMode.Click += btn_toEncryptMode_Click;
            // 
            // tb_checkSumTarget
            // 
            tb_checkSumTarget.BackColor = SystemColors.ButtonHighlight;
            tb_checkSumTarget.Cursor = Cursors.IBeam;
            tb_checkSumTarget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            tb_checkSumTarget.ForeColor = Color.Red;
            tb_checkSumTarget.Location = new Point(37, 408);
            tb_checkSumTarget.Name = "tb_checkSumTarget";
            tb_checkSumTarget.PlaceholderText = "Target...";
            tb_checkSumTarget.Size = new Size(627, 28);
            tb_checkSumTarget.TabIndex = 14;
            tb_checkSumTarget.Text = "#__Target__ : 4a789d0eafbe1c20722cc69b2eab74409eeb0db1f92a3efc87b9c843c08e4b1d";
            tb_checkSumTarget.Enter += tb_checkSumTarget_Enter;
            tb_checkSumTarget.Leave += tb_checkSumTarget_Leave;
            // 
            // btn_format
            // 
            btn_format.BackColor = Color.LightSteelBlue;
            btn_format.Cursor = Cursors.Hand;
            btn_format.Location = new Point(345, 312);
            btn_format.Name = "btn_format";
            btn_format.Size = new Size(110, 43);
            btn_format.TabIndex = 13;
            btn_format.Text = "Format";
            btn_format.UseVisualStyleBackColor = false;
            btn_format.Click += btn_format_Click;
            // 
            // btn_decrypt
            // 
            btn_decrypt.BackColor = Color.Coral;
            btn_decrypt.Cursor = Cursors.Hand;
            btn_decrypt.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_decrypt.Location = new Point(345, 134);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(110, 110);
            btn_decrypt.TabIndex = 12;
            btn_decrypt.Text = ">>\r\nDECRYPT\r\n>>";
            btn_decrypt.UseVisualStyleBackColor = false;
            btn_decrypt.Click += btn_decrypt_Click;
            // 
            // tb_keyMessage
            // 
            tb_keyMessage.Cursor = Cursors.IBeam;
            tb_keyMessage.Location = new Point(37, 36);
            tb_keyMessage.Name = "tb_keyMessage";
            tb_keyMessage.PlaceholderText = "Secret Key...";
            tb_keyMessage.Size = new Size(280, 27);
            tb_keyMessage.TabIndex = 11;
            tb_keyMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_outputMessage
            // 
            tb_outputMessage.BackColor = SystemColors.Info;
            tb_outputMessage.Cursor = Cursors.No;
            tb_outputMessage.Location = new Point(484, 87);
            tb_outputMessage.Multiline = true;
            tb_outputMessage.Name = "tb_outputMessage";
            tb_outputMessage.PlaceholderText = "Message...";
            tb_outputMessage.ReadOnly = true;
            tb_outputMessage.Size = new Size(280, 300);
            tb_outputMessage.TabIndex = 10;
            tb_outputMessage.Enter += tb_outputMessage_Enter;
            // 
            // tb_inputMessage
            // 
            tb_inputMessage.BackColor = SystemColors.Info;
            tb_inputMessage.Cursor = Cursors.IBeam;
            tb_inputMessage.Location = new Point(37, 87);
            tb_inputMessage.Multiline = true;
            tb_inputMessage.Name = "tb_inputMessage";
            tb_inputMessage.PlaceholderText = "Encrypted Message...";
            tb_inputMessage.Size = new Size(280, 300);
            tb_inputMessage.TabIndex = 9;
            // 
            // tb_checkSum
            // 
            tb_checkSum.BackColor = SystemColors.ButtonHighlight;
            tb_checkSum.Cursor = Cursors.No;
            tb_checkSum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            tb_checkSum.ForeColor = Color.Red;
            tb_checkSum.Location = new Point(37, 443);
            tb_checkSum.Name = "tb_checkSum";
            tb_checkSum.PlaceholderText = "Checksum...";
            tb_checkSum.ReadOnly = true;
            tb_checkSum.Size = new Size(627, 28);
            tb_checkSum.TabIndex = 18;
            tb_checkSum.Text = "#Checksum : 4a789d0eafbe1c20722cc69b2eab74409eeb0db1f92a3efc87b9c843c08e4b1d";
            tb_checkSum.Enter += tb_checkSum_Enter;
            // 
            // tb_checkSumAnswer
            // 
            tb_checkSumAnswer.BackColor = Color.Blue;
            tb_checkSumAnswer.Cursor = Cursors.No;
            tb_checkSumAnswer.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tb_checkSumAnswer.ForeColor = Color.LimeGreen;
            tb_checkSumAnswer.Location = new Point(670, 408);
            tb_checkSumAnswer.Name = "tb_checkSumAnswer";
            tb_checkSumAnswer.ReadOnly = true;
            tb_checkSumAnswer.Size = new Size(94, 30);
            tb_checkSumAnswer.TabIndex = 19;
            tb_checkSumAnswer.Text = "VERIFY";
            tb_checkSumAnswer.TextAlign = HorizontalAlignment.Center;
            tb_checkSumAnswer.Enter += tb__Enter;
            // 
            // btn_copyChecksum
            // 
            btn_copyChecksum.Cursor = Cursors.Hand;
            btn_copyChecksum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_copyChecksum.Location = new Point(670, 442);
            btn_copyChecksum.Name = "btn_copyChecksum";
            btn_copyChecksum.Size = new Size(94, 29);
            btn_copyChecksum.TabIndex = 20;
            btn_copyChecksum.Text = "Copy";
            btn_copyChecksum.UseVisualStyleBackColor = true;
            btn_copyChecksum.Click += btn_copyChecksum_Click;
            // 
            // FormDecrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 483);
            Controls.Add(btn_copyChecksum);
            Controls.Add(tb_checkSumAnswer);
            Controls.Add(tb_checkSum);
            Controls.Add(btn_copyMessage);
            Controls.Add(btn_toEncryptMode);
            Controls.Add(tb_checkSumTarget);
            Controls.Add(btn_format);
            Controls.Add(btn_decrypt);
            Controls.Add(tb_keyMessage);
            Controls.Add(tb_outputMessage);
            Controls.Add(tb_inputMessage);
            MaximizeBox = false;
            Name = "FormDecrypt";
            Text = "PXS6 - decrypt";
            FormClosed += FormDecrypt_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_copyMessage;
        private Button btn_toEncryptMode;
        private TextBox tb_checkSumTarget;
        private Button btn_format;
        private Button btn_decrypt;
        private TextBox tb_keyMessage;
        private TextBox tb_outputMessage;
        private TextBox tb_inputMessage;
        private TextBox tb_checkSum;
        private TextBox tb_checkSumAnswer;
        private Button btn_copyChecksum;
    }
}