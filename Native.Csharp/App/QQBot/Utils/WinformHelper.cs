using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackRunner.QQBot.Utils
{
    public static class WinformHelper
    {
        public static Control FindControl(Control control, string controlName)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else
                {
                    if (c.Controls.Count > 0)
                    {
                        Control child = FindControl(c, controlName);
                        if (child != null)
                        {
                            return child;
                        }
                    }
                }
            }
            return null;
        }
    }
}
