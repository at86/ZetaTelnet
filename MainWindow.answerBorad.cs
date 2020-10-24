using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZetaTelnet
{
    public partial class ZetaTelnet
    {
        /// <summary>
        /// Appends text to the terminal output window.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">client, server</param>
        private void AddTerminalText(string text, string type)
        {
            //InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtTerminal.InvokeRequired)
            {
                TerminalTextCallback d = new TerminalTextCallback((text1, type1) => AddTerminalText(text1, type1));
                this.Invoke(d, new object[] {text, type});
            }
            else
            {
                int begin = this.txtTerminal.Text.Length;
                string sign = "";
                Color color = Color.Transparent;
                if (type == "client")
                {
                    sign = "client❓:=============\n";
                    color = Color.RoyalBlue;
                }
                else if (type == "server")
                {
                    sign = "server🍓:=============\n";
                    color = Color.DarkOrange;
                }

                this.txtTerminal.AppendText(sign);
                this.txtTerminal.Select(begin, sign.Length);
                this.txtTerminal.SelectionColor = color;


                if (_stripANSI)
                {
                    this.txtTerminal.AppendText(RemoveANSICodes(text));
                }
                else
                {
                    this.txtTerminal.AppendText(text);
                }

                this.txtTerminal.AppendText("\n");
                this.txtTerminal.ScrollToCaret();
            }
        }

        private void txtTerminal_Click(object sender, EventArgs e)
        {
            //txtInput.Focus();
        }
    }
}