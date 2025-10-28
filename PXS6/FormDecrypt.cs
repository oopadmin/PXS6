using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PXS6
{
    public partial class FormDecrypt : Form
    {
        private string? _key { get; set; }
        const int keyMaxLength = 32;
        private string? _message { get; set; }
        private string? _encryptedMessage { get; set; }
        private string? _checkSum { get; set; }

        public FormDecrypt()
        {
            InitializeComponent();

            tb_checkSum.Text = string.Empty;
            tb_checkSumTarget.Text = string.Empty;

            tb_checkSumAnswer.Visible = false;
        }

        static bool IsKeyFormatted(string s)
        {
            return (s.Length >= 1 && s.Length <= keyMaxLength) && (Regex.IsMatch(s, @"^[A-Za-z0-9!#$%&()*+\-/<=>?@[\]^_{|}~]+$"));
        }

        static bool IsEncryptedMessageFormatted(string s)
        {
            return (s.Length >= 1) && (Regex.IsMatch(s, @"^[A-Z2-7=]+$"));
        }

        private static (string message, string checkSum) Decrypting(string key, string encryptedString)
        {
            string keyhash = CryptoHelper.ToSHA256(key);

            string[] chunks = new string[8];
            for (int i = 0; i < 8; i++) { chunks[i] = keyhash.Substring(i * 8, 8); }

            // Decode Base32
            string message = CryptoHelper.FromBase32(encryptedString);

            // UnShuffle
            message = CryptoHelper.UnShuffleStrings(message, chunks[6]);

            // Xor 5->0
            for (int i = 5; i >= 0; i--)
            {
                message = CryptoHelper.XorStrings(message, chunks[i]);
            }

            // Checksum
            string checksum = CryptoHelper.ToSHA256(message + chunks[7]);

            return (message, checksum);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            _key = tb_keyMessage.Text;
            _encryptedMessage = tb_inputMessage.Text;

            if (IsKeyFormatted(_key) && IsEncryptedMessageFormatted(_encryptedMessage))
            {
                var result = Decrypting(_key, _encryptedMessage);

                _message = result.message;
                tb_outputMessage.Text = _message;

                _checkSum = result.checkSum;
                tb_checkSum.Text = $"#Checksum : {_checkSum}";
            }
            else if (_key.Length == 0 && _encryptedMessage.Length == 0)
            {
                MessageBox.Show(
                    "Secret Key and Encrypted Message needed!",
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
            else if (_encryptedMessage.Length == 0)
            {
                MessageBox.Show(
                    "Encrypted Message needed",
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

            if (!string.IsNullOrEmpty(tb_checkSumTarget.Text) && !string.IsNullOrEmpty(tb_checkSum.Text))
            {
                tb_checkSumAnswer.Visible = true;

                if (tb_checkSumTarget.Text.Substring(15) == tb_checkSum.Text.Substring(13))
                {
                    tb_checkSumAnswer.Text = "VERIFY";
                    tb_checkSumAnswer.ForeColor = Color.LimeGreen;
                    tb_checkSumAnswer.BackColor = Color.Blue;
                }
                else
                {
                    tb_checkSumAnswer.Text = "FALSIFY";
                    tb_checkSumAnswer.ForeColor= Color.Red;
                    tb_checkSumAnswer.BackColor = SystemColors.InfoText;
                }
            }
            else
            {
                tb_checkSumAnswer.Visible = false;
            }    
        }

        private void btn_format_Click(object sender, EventArgs e)
        {
            _key = tb_keyMessage.Text.Trim();
            _key = Regex.Replace(_key, @"[^a-zA-Z0-9!#$%&()*+\-/<=>?@[\]^_{|}~]", "");
            _key = _key[..Math.Min(_key.Length, keyMaxLength)];
            tb_keyMessage.Text = _key;

            _encryptedMessage = tb_inputMessage.Text.Trim();
            _encryptedMessage = _encryptedMessage.ToUpper();
            _encryptedMessage = Regex.Replace(_encryptedMessage, @"[^A-Z2-9=]", "");
            tb_inputMessage.Text = _encryptedMessage;
        }

        private void btn_copyMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_message))
            {
                Clipboard.SetText(_message);
            }
        }

        private void btn_copyChecksum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_checkSum))
            {
                Clipboard.SetText(_checkSum);
            }
        }

        private async void btn_toEncryptMode_Click(object sender, EventArgs e)
        {
            FormManager.ClearForm(this);
            this.Hide();
            await Task.Delay(100);
            FormManager.encryptForm!.Show();
        }

        private void tb_checkSumTarget_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_checkSumTarget.Text) && tb_checkSumTarget.Text.StartsWith("#__Target__ : "))
            {
                tb_checkSumTarget.Text = tb_checkSumTarget.Text.Substring(15);
            }
        }

        private void tb_checkSumTarget_Leave(object sender, EventArgs e)
        {
            if (tb_checkSumTarget.Text.Length > 0)
            {
                tb_checkSumTarget.Text = Regex.Replace(tb_checkSumTarget.Text, @"[^a-f0-9]", "");

                if (tb_checkSumTarget.Text.Length == 64)
                {
                    tb_checkSumTarget.Text = $"#__Target__ : {tb_checkSumTarget.Text}";
                }
                else if (tb_checkSumTarget.Text.Length < 64)
                {
                    tb_checkSumTarget.Text = $"#__Target__ : {tb_checkSumTarget.Text.PadRight(64, '0')}";
                }
                else
                {
                    tb_checkSumTarget.Text = $"#__Target__ : {tb_checkSumTarget.Text.Substring(0, 64)}";
                }
            }
            else
            {
                tb_checkSumAnswer.Text = string.Empty;
            }
        }

        private void tb_outputMessage_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tb_checkSum_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tb__Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormDecrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
