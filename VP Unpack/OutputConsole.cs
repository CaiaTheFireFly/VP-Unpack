using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Unpack
{
    public static class OutputConsole
    {
        public static TextBox output;

        static OutputConsole()
        {
            output = Globals.mainForm.outputConsole;
        }

        public static void SendMessage(string message)
        {
            string[] s = new string[output.Lines.Length + 1];
            output.Lines.CopyTo(s, 0);
            s[output.Lines.Length] = message;
            output.Lines = s;
            output.SelectionStart = output.Text.Length;
            output.ScrollToCaret();
        }

        public static void ClearMessages()
        {
            output.Lines = null;
        }
    }
}
