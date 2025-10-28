namespace PXS6
{
    partial class FormEncrypt
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
            tb_inputMessage = new TextBox();
            tb_outputMessage = new TextBox();
            tb_keyMessage = new TextBox();
            btn_encrypt = new Button();
            btn_format = new Button();
            tb_checkSum = new TextBox();
            btn_toDecryptMode = new Button();
            btn_copyChecksum = new Button();
            btn_copyEncryptedMessage = new Button();
            SuspendLayout();
            // 
            // tb_inputMessage
            // 
            tb_inputMessage.BackColor = SystemColors.Info;
            tb_inputMessage.Cursor = Cursors.IBeam;
            tb_inputMessage.Location = new Point(22, 85);
            tb_inputMessage.Multiline = true;
            tb_inputMessage.Name = "tb_inputMessage";
            tb_inputMessage.PlaceholderText = "Message...";
            tb_inputMessage.Size = new Size(280, 300);
            tb_inputMessage.TabIndex = 0;
            // 
            // tb_outputMessage
            // 
            tb_outputMessage.BackColor = SystemColors.Info;
            tb_outputMessage.Cursor = Cursors.No;
            tb_outputMessage.Location = new Point(469, 85);
            tb_outputMessage.Multiline = true;
            tb_outputMessage.Name = "tb_outputMessage";
            tb_outputMessage.PlaceholderText = "Encrypted Message...";
            tb_outputMessage.ReadOnly = true;
            tb_outputMessage.Size = new Size(280, 300);
            tb_outputMessage.TabIndex = 1;
            tb_outputMessage.Enter += tb_outputMessage_Enter;
            // 
            // tb_keyMessage
            // 
            tb_keyMessage.Cursor = Cursors.IBeam;
            tb_keyMessage.Location = new Point(22, 34);
            tb_keyMessage.Name = "tb_keyMessage";
            tb_keyMessage.PlaceholderText = "Secret Key...";
            tb_keyMessage.Size = new Size(280, 27);
            tb_keyMessage.TabIndex = 2;
            tb_keyMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_encrypt
            // 
            btn_encrypt.BackColor = SystemColors.HotTrack;
            btn_encrypt.Cursor = Cursors.Hand;
            btn_encrypt.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_encrypt.Location = new Point(330, 132);
            btn_encrypt.Name = "btn_encrypt";
            btn_encrypt.Size = new Size(110, 110);
            btn_encrypt.TabIndex = 3;
            btn_encrypt.Text = ">>\r\nENCRYPT\r\n>>";
            btn_encrypt.UseVisualStyleBackColor = false;
            btn_encrypt.Click += btn_encrypt_Click;
            // 
            // btn_format
            // 
            btn_format.BackColor = Color.LightSteelBlue;
            btn_format.Cursor = Cursors.Hand;
            btn_format.Location = new Point(330, 310);
            btn_format.Name = "btn_format";
            btn_format.Size = new Size(110, 43);
            btn_format.TabIndex = 4;
            btn_format.Text = "Format";
            btn_format.UseVisualStyleBackColor = false;
            btn_format.Click += btn_format_Click;
            // 
            // tb_checkSum
            // 
            tb_checkSum.BackColor = SystemColors.ButtonHighlight;
            tb_checkSum.Cursor = Cursors.No;
            tb_checkSum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            tb_checkSum.ForeColor = Color.Red;
            tb_checkSum.Location = new Point(22, 406);
            tb_checkSum.Name = "tb_checkSum";
            tb_checkSum.PlaceholderText = "Checksum...";
            tb_checkSum.ReadOnly = true;
            tb_checkSum.Size = new Size(627, 28);
            tb_checkSum.TabIndex = 5;
            tb_checkSum.Text = "#Checksum : 4a789d0eafbe1c20722cc69b2eab74409eeb0db1f92a3efc87b9c843c08e4b1d";
            tb_checkSum.Enter += tb_checkSum_Enter;
            // 
            // btn_toDecryptMode
            // 
            btn_toDecryptMode.BackColor = SystemColors.HotTrack;
            btn_toDecryptMode.BackgroundImageLayout = ImageLayout.Center;
            btn_toDecryptMode.Cursor = Cursors.Hand;
            btn_toDecryptMode.FlatStyle = FlatStyle.Popup;
            btn_toDecryptMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_toDecryptMode.Location = new Point(627, 12);
            btn_toDecryptMode.Name = "btn_toDecryptMode";
            btn_toDecryptMode.Size = new Size(122, 29);
            btn_toDecryptMode.TabIndex = 6;
            btn_toDecryptMode.Text = "Encrypt Mode";
            btn_toDecryptMode.UseVisualStyleBackColor = false;
            btn_toDecryptMode.Click += btn_toDecryptMode_Click;
            // 
            // btn_copyChecksum
            // 
            btn_copyChecksum.Cursor = Cursors.Hand;
            btn_copyChecksum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_copyChecksum.Location = new Point(655, 405);
            btn_copyChecksum.Name = "btn_copyChecksum";
            btn_copyChecksum.Size = new Size(94, 29);
            btn_copyChecksum.TabIndex = 7;
            btn_copyChecksum.Text = "Copy";
            btn_copyChecksum.UseVisualStyleBackColor = true;
            btn_copyChecksum.Click += btn_copyChecksum_Click;
            // 
            // btn_copyEncryptedMessage
            // 
            btn_copyEncryptedMessage.Cursor = Cursors.Hand;
            btn_copyEncryptedMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_copyEncryptedMessage.Location = new Point(655, 50);
            btn_copyEncryptedMessage.Name = "btn_copyEncryptedMessage";
            btn_copyEncryptedMessage.Size = new Size(94, 29);
            btn_copyEncryptedMessage.TabIndex = 8;
            btn_copyEncryptedMessage.Text = "Copy";
            btn_copyEncryptedMessage.UseVisualStyleBackColor = true;
            btn_copyEncryptedMessage.Click += btn_copyEncryptedMessage_Click;
            // 
            // FormEncrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(770, 450);
            Controls.Add(btn_copyEncryptedMessage);
            Controls.Add(btn_copyChecksum);
            Controls.Add(btn_toDecryptMode);
            Controls.Add(tb_checkSum);
            Controls.Add(btn_format);
            Controls.Add(btn_encrypt);
            Controls.Add(tb_keyMessage);
            Controls.Add(tb_outputMessage);
            Controls.Add(tb_inputMessage);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MaximizeBox = false;
            Name = "FormEncrypt";
            Text = "PXS6 - encrypt";
            FormClosed += FormEncrypt_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_inputMessage;
        private TextBox tb_outputMessage;
        private TextBox tb_keyMessage;
        private Button btn_encrypt;
        private Button btn_format;
        private TextBox tb_checkSum;
        private Button btn_toDecryptMode;
        private Button btn_copyChecksum;
        private Button btn_copyEncryptedMessage;
    }
}
