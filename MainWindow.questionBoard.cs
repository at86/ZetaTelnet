using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ZetaTelnet
{
    public partial class ZetaTelnet
    {
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_socket != null && _socket.Connected == true)
            {
                //byte[] sendBytes = Encoding.ASCII.GetBytes(txtInput.Text + "\n");
                byte[] sendBytes = Encoding.UTF8.GetBytes(txtInput.Text);
                AsyncCallback onsend = new AsyncCallback(OnSend);
                _socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, onsend, _socket);
                AddTerminalText(txtInput.Text, "client");
                txtInput.Text = "";
            }
        }

        // atdo comment it 1..
        private void KeyHandler(Object o, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                if (_socket != null && _socket.Connected == true)
                {
                    _scrollback.Add(txtInput.Text);
                    _scrollbackPosition = _scrollback.Count;
                    byte[] sendBytes = Encoding.ASCII.GetBytes(txtInput.Text + "\n");
                    AsyncCallback onsend = new AsyncCallback(OnSend);
                    _socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, onsend, _socket);
                    AddTerminalText(txtInput.Text, "client");
                    txtInput.Text = "";
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (_scrollbackPosition > 0 && _scrollback.Count > 0)
                {
                    _scrollbackPosition--;
                    txtInput.Text = _scrollback[_scrollbackPosition];
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (_scrollbackPosition < (_scrollback.Count - 1) && _scrollback.Count > 0)
                {
                    _scrollbackPosition++;
                    txtInput.Text = _scrollback[_scrollbackPosition];
                }
                else
                {
                    txtInput.Text = String.Empty;
                    _scrollbackPosition = _scrollback.Count;
                }
            }
        }
    }
}