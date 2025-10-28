using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXS6
{
    internal class FormManager
    {
        public static FormEncrypt? encryptForm;
        public static FormDecrypt? decryptForm;

        public static void Initialize()
        {
            encryptForm = new FormEncrypt();
            decryptForm = new FormDecrypt();
        }

        public static void ClearForm(Form form)
        {
            void ClearControls(Control parent)
            {
                foreach (Control c in  parent.Controls)
                {
                    if (c is TextBox tb)
                    {
                        tb.Clear();
                    }
                    if (c.HasChildren)
                    {
                        ClearControls(c);
                    }
                }
            }
            ClearControls(form);
        }
    }
}
