using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PXS6
{
    public partial class FormEncrypt : Form
    {
        private string? _key { get; set; }
        const int keyMaxLength = 32;
        private string? _message { get; set; }
        private string? _encryptedMessage { get; set; }
        private string? _checkSum { get; set; }

        public FormEncrypt()
        {
            InitializeComponent();

            tb_checkSum.Text = string.Empty;
        }

        static bool IsKeyFormatted(string s)
        {
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&()*+-/<=>?@[]^_{|}~";

            // Kiểm tra độ dài
            if (string.IsNullOrEmpty(s) || s.Length > keyMaxLength)
                return false;

            // Kiểm tra từng ký tự
            foreach (char c in s)
            {
                if (!allowedChars.Contains(c))
                    return false;
            }

            return true;
        }

        static bool IsMessageFormatted(string s)
        {
            return (s.Length >= 1) && (Regex.IsMatch(s, @"^[A-Z0-9 ]+$"));
        }

        private static (string encryptedString, string checkSum) Encrypting(string key, string message)
        {
            string keyhash = CryptoHelper.ToSHA256(key);

            string[] chunks = new string[8];
            for (int i = 0; i < 8; i++) { chunks[i] = keyhash.Substring(i * 8, 8); }

            // Create Checksum
            string checksum = CryptoHelper.ToSHA256(message + chunks[7]);

            // Xor Step 0->5
            for (int i = 0; i <= 5; i++)
            {
                message = CryptoHelper.XorStrings(message, chunks[i]);
            }

            // Shuffle Step
            message = CryptoHelper.ShuffleStrings(message, chunks[6]);

            // Encode Base32
            string encryptedstring = CryptoHelper.ToBase32(message);

            return (encryptedstring, checksum);
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            _key = tb_keyMessage.Text;
            _message = tb_inputMessage.Text;

            if (IsKeyFormatted(_key) && IsMessageFormatted(_message))
            {
                var result = Encrypting(_key, _message);

                _encryptedMessage = result.encryptedString;
                tb_outputMessage.Text = _encryptedMessage;

                _checkSum = result.checkSum;
                tb_checkSum.Text = $"Checksum : {_checkSum}";
            }
            else if (_key.Length == 0 && _message.Length == 0)
            {
                MessageBox.Show(
                    "Secret Key and Message needed!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (_key.Length == 0)
            {
                MessageBox.Show(
                    "Secret Key needed",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (_message.Length == 0)
            {
                MessageBox.Show(
                    "Message needed",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                MessageBox.Show(
                    "You should [Format] first",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void btn_format_Click(object sender, EventArgs e)
        {
            _key = tb_keyMessage.Text.Trim(); 
            _key = Regex.Replace(_key, @"[^a-zA-Z0-9!#$%&()*+\-/<=>?@[\]^_{|}~]", "");
            _key = _key[..Math.Min(_key.Length, keyMaxLength)];
            tb_keyMessage.Text = _key;

            _message = tb_inputMessage.Text.Trim();
            _message = _message.ToUpper();
            _message = Regex.Replace(_message, @"[^A-Z0-9 ]", "");
            tb_inputMessage.Text = _message;
        }

        private void btn_copyEncryptedMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_encryptedMessage))
            {
                Clipboard.SetText(_encryptedMessage);
            }
        }

        private void btn_copyChecksum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_checkSum))
            {
                Clipboard.SetText(_checkSum);
            }
        }

        private async void btn_toDecryptMode_Click(object sender, EventArgs e)
        {
            FormManager.ClearForm(this);
            this.Hide();
            await Task.Delay(100);
            FormManager.decryptForm!.Show();
        }

        private void tb_outputMessage_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tb_checkSum_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormEncrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
