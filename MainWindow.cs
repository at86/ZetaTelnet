using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZetaTelnet
{
    public partial class ZetaTelnet : Form
    {
        private Socket _socket = null;
        byte[] _inBuffer = null;
        private IPHostEntry _ipHost;
        private IPAddress _ipAddress;

        private delegate void TerminalTextCallback(string text, string type);

        private delegate void EnableConnectCallback(bool enabled);

        List<String> _scrollback = new List<String>();
        int _scrollbackPosition = -1;
        bool _stripANSI = true;
        Int32 bytesLen = 64 * 1024;

        public ZetaTelnet()
        {
            InitializeComponent();
            //txtInput.KeyPress += new KeyPressEventHandler(KeyHandler);

            // atdo comment it 1..
            //txtInput.KeyDown += new KeyEventHandler(KeyHandler);
        }

        ~ZetaTelnet()
        {
            if (_socket != null)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
        }

        /// <summary>
        /// Reacts to window size changes and moves/resizes controls accordingly.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            //int previousHeight = txtTerminal.Height;
            //txtTerminal.Height = this.Height - 92;
            //txtTerminal.Height = this.Height - 115;
            //int newInputY = txtTerminal.Location.Y + txtTerminal.Height;
            //txtInput.Location = new Point(txtInput.Location.X, newInputY);

            txtInput.Width = this.Width - 14;
            txtTerminal.Width = this.Width - 14;
            base.OnSizeChanged(e);
        }

        public static String RemoveANSICodes(string text)
        {
            text = Regex.Replace(text, @"\e\[\d*(;?\d)+m", "");
            text = text.Replace("\n\r", "\r\n");
            return text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Zeta Telnet 3.01\nCopyright (c) 2007-2013 Zeta Centauri, Inc.\nhttp://www.zetacentauri.com\nWritten by Jason Champion.\n\nThis program is freeware and may be distributed freely.",
                "About Zeta Telnet");
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            String text = txtTerminal.Text;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "text files (*.txt)|*.txt";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(dlg.FileName);
                file.Write(text);
                file.Close();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stripAnsiCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _stripANSI = !_stripANSI;
            stripAnsiCodesToolStripMenuItem.Checked = _stripANSI;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnConnect_Click(sender, e);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDisconnect_Click(sender, e);
        }

        private void changeForegroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtTerminal.ForeColor = dlg.Color;
            }
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtTerminal.BackColor = dlg.Color;
            }
        }
    }
}