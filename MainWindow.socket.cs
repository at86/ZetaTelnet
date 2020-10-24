using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ZetaTelnet
{
    public partial class ZetaTelnet
    {

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _ipHost = Dns.GetHostEntry(txtIP.Text);
            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to resolve IP Address");
                return;
            }

            try
            {
                foreach (IPAddress address in _ipHost.AddressList)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        _ipAddress = address;
                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("IP Address does not resolve to any known hosts.");
                return;
            }
            if (_ipAddress == null)
            {
                MessageBox.Show("Cannot find host for address " + txtIP.Text + ".");
                return;
            }

            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (SystemException)
            {
                MessageBox.Show("Unable to create socket.");
                return;
            }

            try
            {
                _socket.Blocking = false;
                AsyncCallback onconnect = new AsyncCallback(OnConnect);
                int port;
                try
                {
                    port = Int32.Parse(txtPort.Text);
                }
                catch (SystemException)
                {
                    MessageBox.Show("Unable to connect: Bad port number (must be an integer)");
                    return;
                }
                _socket.BeginConnect(_ipAddress, port, onconnect, _socket);
            }
            catch (SocketException ex)
            {
                int errorCode = ex.ErrorCode;
                MessageBox.Show("Socket error " + errorCode.ToString() + " on BeginConnect");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initiate connection: " + ex.ToString());
                return;
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            _socket.Close();
            EnableConnect(true);
        }

        protected void EnableConnect(bool enabled)
        {
            if (this.btnConnect.InvokeRequired)
            {
                EnableConnectCallback d = new EnableConnectCallback(EnableConnect);
                this.Invoke(d, new object[] { enabled });
            }
            else
            {
                this.btnConnect.Enabled = enabled;
                this.btnDisconnect.Enabled = !enabled;
            }
        }


        public void OnSend(IAsyncResult ar)
        {
            _socket = (Socket)ar.AsyncState;

            try
            {
                int bytesSent = _socket.EndSend(ar);
                if (bytesSent > 0)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error processing receive buffer!");
            }
        }

        public void OnConnect(IAsyncResult ar)
        {
            _socket = (Socket)ar.AsyncState;

            try
            {
                _socket.EndConnect(ar);
                if (_socket.Connected)
                {
                    SetupReceiveCallback(_socket);
                    EnableConnect(false);
                }
                else
                {
                    MessageBox.Show("Unable to connect to remote host.");
                    EnableConnect(true);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error");
                EnableConnect(true);
                return;
            }
        }

        public void SetupReceiveCallback(Socket sock)
        {
            try
            {
                AsyncCallback receiveData = new AsyncCallback(OnReceiveData);
                _inBuffer = new byte[bytesLen];
                sock.BeginReceive(_inBuffer, 0, bytesLen, SocketFlags.None, receiveData, sock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setup receive callback failed: " + ex.ToString());
                disconnect();
                return;
            }
        }

        /// <summary>
        /// Process data received from the socket.
        /// </summary>
        /// <param name="ar"></param>
        public void OnReceiveData(IAsyncResult ar)
        {
            _socket = (Socket)ar.AsyncState;

            if (_socket == null || !_socket.Connected)
                return;

            try
            {
                int bytesReceived = _socket.EndReceive(ar);
                if (bytesReceived > 0)
                {
                    //string buffer = Encoding.ASCII.GetString(_inBuffer, 0, bytesLen);
                    string buffer = Encoding.UTF8.GetString(_inBuffer, 0, bytesLen);
                    AddTerminalText(buffer, "server");
                    _inBuffer = null;
                }
                SetupReceiveCallback(_socket);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error Receiving Data: " + ex.ToString());
                if (_socket != null)
                    _socket.Close();
                EnableConnect(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error processing receive buffer!");
                return;
            }
        }

    }
}
