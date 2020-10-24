namespace ZetaTelnet
{
    partial class ZetaTelnet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZetaTelnet));
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAnsiCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeForegroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminal.Font = new System.Drawing.Font("Courier New", 11F);
            this.txtTerminal.ForeColor = System.Drawing.Color.White;
            this.txtTerminal.Location = new System.Drawing.Point(0, 0);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(768, 302);
            this.txtTerminal.TabIndex = 0;
            this.txtTerminal.TabStop = false;
            this.txtTerminal.Text = "";
            this.txtTerminal.Click += new System.EventHandler(this.txtTerminal_Click);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Courier New", 11F);
            this.txtInput.Location = new System.Drawing.Point(3, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(619, 123);
            this.txtInput.TabIndex = 1;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(47, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(137, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtPort.Location = new System.Drawing.Point(222, 5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8000";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(12, 9);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(29, 12);
            this.IP.TabIndex = 4;
            this.IP.Text = "Host";
            this.IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.BackColor = System.Drawing.SystemColors.Control;
            this.Port.Location = new System.Drawing.Point(190, 9);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(29, 12);
            this.Port.TabIndex = 5;
            this.Port.Text = "Port";
            this.Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(300, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 24);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.IP);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.Port);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 33);
            this.panel1.TabIndex = 8;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(378, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(72, 24);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.saveAsMenuItem,
            this.exitToolStripMenuItem1});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.saveAsToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAnsiCodesToolStripMenuItem,
            this.changeForegroundColorToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // stripAnsiCodesToolStripMenuItem
            // 
            this.stripAnsiCodesToolStripMenuItem.Checked = true;
            this.stripAnsiCodesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stripAnsiCodesToolStripMenuItem.Name = "stripAnsiCodesToolStripMenuItem";
            this.stripAnsiCodesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.stripAnsiCodesToolStripMenuItem.Text = "Strip Ansi Codes";
            this.stripAnsiCodesToolStripMenuItem.Click += new System.EventHandler(this.stripAnsiCodesToolStripMenuItem_Click);
            // 
            // changeForegroundColorToolStripMenuItem
            // 
            this.changeForegroundColorToolStripMenuItem.Name = "changeForegroundColorToolStripMenuItem";
            this.changeForegroundColorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.changeForegroundColorToolStripMenuItem.Text = "Change Foreground Color";
            this.changeForegroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeForegroundColorToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTerminal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(768, 435);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48734F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51266F));
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 129);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Font = new System.Drawing.Font("ËÎÌå", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(628, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 123);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "·¢ËÍ";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.875F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 480);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // ZetaTelnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 505);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZetaTelnet";
            this.Text = "Zeta Telnet 3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTerminal;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripAnsiCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeForegroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

