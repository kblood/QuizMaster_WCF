using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAdmin.UserControls
{
    public static class Utilities
    {
        // Clear all text boxes in control, UserControl, Panel, whatever
        public static void ClearAllText(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }

                else
                {   // Child control recursive call
                    ClearAllText(item);
                }
            }
        }
    }
}
