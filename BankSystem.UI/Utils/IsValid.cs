using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.UI.Utils
{
    public class IsValid
    {
        public static bool Valid(TextBox textbox, Label label )
        {
           if(string.IsNullOrWhiteSpace(textbox.Text))
            {
                label.ForeColor = Color.DarkRed;
                return false;
            }
            else
            {
                label.ForeColor = Color.Navy;
                return true;
            }
        }
    }
}
