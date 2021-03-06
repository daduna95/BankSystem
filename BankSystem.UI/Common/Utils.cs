﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.UI.Common
{
    internal static class Utils
    {
        public static bool ValidateInput(TextBox textbox, Label label)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                label.ForeColor = Color.Maroon;
                return false;
            }
            else
            {
                label.ForeColor = Color.MidnightBlue;
                return true;
            }
        }
    }

}
