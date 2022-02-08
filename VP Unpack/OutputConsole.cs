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
            output = Globals.mainForm.outputConsole; //Sets the Globals variable for the Output Log.
        }

        /// <summary>
        /// Sends a message to the Output Log. Only takes a string for the moment.
        /// </summary>
        /// <param name="message">String to be sent.</param>
        public static void SendMessage(string message)
        {
            string[] s = new string[output.Lines.Length + 1];
            output.Lines.CopyTo(s, 0);
            s[output.Lines.Length] = message;
            output.Lines = s;
            output.SelectionStart = output.Text.Length;
            output.ScrollToCaret(); //Keep focus on the newest message.
        }

        /// <summary>
        /// Clear all messages from the Output Log.
        /// </summary>
        public static void ClearMessages()
        {
            output.Lines = null;
        }
    }
}
