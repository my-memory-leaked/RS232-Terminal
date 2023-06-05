namespace RS232
{
    partial class UserGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C = new GroupBox();
            ownTerminatorTextBox = new TextBox();
            terminatorCBox = new ComboBox();
            terminatorLabel = new Label();
            parityCBox = new ComboBox();
            parityLabel = new Label();
            refreshComsButton = new Button();
            OpenCloseComButton = new Button();
            flowControlCBox = new ComboBox();
            flowControlLabel = new Label();
            dataBitsCBox = new ComboBox();
            dataBitsLabel = new Label();
            stopBitsCBox = new ComboBox();
            baudRateCBox = new ComboBox();
            comPortCBox = new ComboBox();
            stopBitsLabel = new Label();
            baudRateLabel = new Label();
            comPortLabel = new Label();
            terminalRichTextBox = new RichTextBox();
            terminalLabel = new Label();
            terminalSendButton = new Button();
            sendCommandTextBox = new TextBox();
            sendCommandLabel = new Label();
            clearTerminalButton = new Button();
            C.SuspendLayout();
            SuspendLayout();
            // 
            // C
            // 
            C.Controls.Add(ownTerminatorTextBox);
            C.Controls.Add(terminatorCBox);
            C.Controls.Add(terminatorLabel);
            C.Controls.Add(parityCBox);
            C.Controls.Add(parityLabel);
            C.Controls.Add(refreshComsButton);
            C.Controls.Add(OpenCloseComButton);
            C.Controls.Add(flowControlCBox);
            C.Controls.Add(flowControlLabel);
            C.Controls.Add(dataBitsCBox);
            C.Controls.Add(dataBitsLabel);
            C.Controls.Add(stopBitsCBox);
            C.Controls.Add(baudRateCBox);
            C.Controls.Add(comPortCBox);
            C.Controls.Add(stopBitsLabel);
            C.Controls.Add(baudRateLabel);
            C.Controls.Add(comPortLabel);
            C.Location = new Point(12, 12);
            C.Name = "C";
            C.Size = new Size(473, 384);
            C.TabIndex = 0;
            C.TabStop = false;
            C.Text = "COM Port Parameters";
            // 
            // ownTerminatorTextBox
            // 
            ownTerminatorTextBox.Location = new Point(335, 277);
            ownTerminatorTextBox.Name = "ownTerminatorTextBox";
            ownTerminatorTextBox.Size = new Size(112, 31);
            ownTerminatorTextBox.TabIndex = 16;
            ownTerminatorTextBox.Visible = false;
            ownTerminatorTextBox.TextChanged += ownTerminatorTextBox_TextChanged;
            // 
            // terminatorCBox
            // 
            terminatorCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            terminatorCBox.FormattingEnabled = true;
            terminatorCBox.Items.AddRange(new object[] { "None", "CR", "LF", "CRLF", "Own" });
            terminatorCBox.Location = new Point(147, 275);
            terminatorCBox.Name = "terminatorCBox";
            terminatorCBox.Size = new Size(182, 33);
            terminatorCBox.TabIndex = 15;
            terminatorCBox.SelectedIndexChanged += terminatorCBox_SelectedIndexChanged;
            // 
            // terminatorLabel
            // 
            terminatorLabel.AutoSize = true;
            terminatorLabel.Location = new Point(16, 283);
            terminatorLabel.Name = "terminatorLabel";
            terminatorLabel.Size = new Size(96, 25);
            terminatorLabel.TabIndex = 14;
            terminatorLabel.Text = "Terminator";
            // 
            // parityCBox
            // 
            parityCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            parityCBox.FormattingEnabled = true;
            parityCBox.Items.AddRange(new object[] { "None", "Odd", "Even" });
            parityCBox.Location = new Point(147, 236);
            parityCBox.Name = "parityCBox";
            parityCBox.Size = new Size(182, 33);
            parityCBox.TabIndex = 13;
            parityCBox.SelectedIndexChanged += parityCBox_SelectedIndexChanged;
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new Point(16, 244);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(55, 25);
            parityLabel.TabIndex = 12;
            parityLabel.Text = "Parity";
            // 
            // refreshComsButton
            // 
            refreshComsButton.Location = new Point(335, 37);
            refreshComsButton.Name = "refreshComsButton";
            refreshComsButton.Size = new Size(112, 34);
            refreshComsButton.TabIndex = 11;
            refreshComsButton.Text = "Refresh";
            refreshComsButton.UseVisualStyleBackColor = true;
            refreshComsButton.Click += refreshComsButton_Click;
            // 
            // OpenCloseComButton
            // 
            OpenCloseComButton.BackColor = Color.Green;
            OpenCloseComButton.Location = new Point(157, 332);
            OpenCloseComButton.Name = "OpenCloseComButton";
            OpenCloseComButton.Size = new Size(112, 34);
            OpenCloseComButton.TabIndex = 10;
            OpenCloseComButton.Text = "Open";
            OpenCloseComButton.UseVisualStyleBackColor = false;
            OpenCloseComButton.Click += OpenCloseComButton_Click;
            // 
            // flowControlCBox
            // 
            flowControlCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flowControlCBox.FormattingEnabled = true;
            flowControlCBox.Items.AddRange(new object[] { "None", "XON/XOFF", "RTS/CTS", "DTR/DSR" });
            flowControlCBox.Location = new Point(147, 197);
            flowControlCBox.Name = "flowControlCBox";
            flowControlCBox.Size = new Size(182, 33);
            flowControlCBox.TabIndex = 9;
            flowControlCBox.SelectedIndexChanged += flowControlCBox_SelectedIndexChanged;
            // 
            // flowControlLabel
            // 
            flowControlLabel.AutoSize = true;
            flowControlLabel.Location = new Point(16, 205);
            flowControlLabel.Name = "flowControlLabel";
            flowControlLabel.Size = new Size(113, 25);
            flowControlLabel.TabIndex = 8;
            flowControlLabel.Text = "Flow Control";
            // 
            // dataBitsCBox
            // 
            dataBitsCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataBitsCBox.FormattingEnabled = true;
            dataBitsCBox.Items.AddRange(new object[] { "8 bits", "7 bits" });
            dataBitsCBox.Location = new Point(147, 118);
            dataBitsCBox.Name = "dataBitsCBox";
            dataBitsCBox.Size = new Size(182, 33);
            dataBitsCBox.TabIndex = 7;
            dataBitsCBox.SelectedIndexChanged += dataBitsCBox_SelectedIndexChanged;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new Point(16, 126);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(82, 25);
            dataBitsLabel.TabIndex = 6;
            dataBitsLabel.Text = "Data Bits";
            // 
            // stopBitsCBox
            // 
            stopBitsCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitsCBox.FormattingEnabled = true;
            stopBitsCBox.Items.AddRange(new object[] { "1 bit", "2 bits" });
            stopBitsCBox.Location = new Point(147, 159);
            stopBitsCBox.Name = "stopBitsCBox";
            stopBitsCBox.Size = new Size(182, 33);
            stopBitsCBox.TabIndex = 5;
            stopBitsCBox.SelectedIndexChanged += stopBitsCBox_SelectedIndexChanged;
            // 
            // baudRateCBox
            // 
            baudRateCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            baudRateCBox.FormattingEnabled = true;
            baudRateCBox.Items.AddRange(new object[] { "110 bits/s", "300 bits/s", "600 bits/s", "1200 bits/s", "2400 bits/s", "4800 bits/s", "9600 bits/s", "14400 bits/s", "19200 bits/s", "38400 bits/s", "57600 bits/s", "115200 bits/s" });
            baudRateCBox.Location = new Point(147, 79);
            baudRateCBox.Name = "baudRateCBox";
            baudRateCBox.Size = new Size(182, 33);
            baudRateCBox.TabIndex = 4;
            baudRateCBox.SelectedIndexChanged += baudRateCBox_SelectedIndexChanged;
            // 
            // comPortCBox
            // 
            comPortCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comPortCBox.FormattingEnabled = true;
            comPortCBox.Location = new Point(147, 37);
            comPortCBox.Name = "comPortCBox";
            comPortCBox.Size = new Size(182, 33);
            comPortCBox.TabIndex = 3;
            comPortCBox.SelectedIndexChanged += comPortCBox_SelectedIndexChanged;
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new Point(16, 167);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new Size(82, 25);
            stopBitsLabel.TabIndex = 2;
            stopBitsLabel.Text = "Stop Bits";
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new Point(16, 82);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(92, 25);
            baudRateLabel.TabIndex = 1;
            baudRateLabel.Text = "Baud Rate";
            // 
            // comPortLabel
            // 
            comPortLabel.AutoSize = true;
            comPortLabel.Location = new Point(16, 37);
            comPortLabel.Name = "comPortLabel";
            comPortLabel.Size = new Size(90, 25);
            comPortLabel.TabIndex = 0;
            comPortLabel.Text = "COM Port";
            // 
            // terminalRichTextBox
            // 
            terminalRichTextBox.Location = new Point(523, 40);
            terminalRichTextBox.Name = "terminalRichTextBox";
            terminalRichTextBox.Size = new Size(915, 770);
            terminalRichTextBox.TabIndex = 2;
            terminalRichTextBox.Text = "";
            // 
            // terminalLabel
            // 
            terminalLabel.AutoSize = true;
            terminalLabel.Location = new Point(523, 12);
            terminalLabel.Name = "terminalLabel";
            terminalLabel.Size = new Size(77, 25);
            terminalLabel.TabIndex = 3;
            terminalLabel.Text = "Terminal";
            // 
            // terminalSendButton
            // 
            terminalSendButton.Location = new Point(523, 878);
            terminalSendButton.Name = "terminalSendButton";
            terminalSendButton.Size = new Size(112, 34);
            terminalSendButton.TabIndex = 4;
            terminalSendButton.Text = "Send";
            terminalSendButton.UseVisualStyleBackColor = true;
            terminalSendButton.Click += terminalSendButton_Click;
            // 
            // sendCommandTextBox
            // 
            sendCommandTextBox.Location = new Point(523, 841);
            sendCommandTextBox.Name = "sendCommandTextBox";
            sendCommandTextBox.Size = new Size(578, 31);
            sendCommandTextBox.TabIndex = 5;
            // 
            // sendCommandLabel
            // 
            sendCommandLabel.AutoSize = true;
            sendCommandLabel.Location = new Point(523, 813);
            sendCommandLabel.Name = "sendCommandLabel";
            sendCommandLabel.Size = new Size(138, 25);
            sendCommandLabel.TabIndex = 6;
            sendCommandLabel.Text = "Send command";
            // 
            // clearTerminalButton
            // 
            clearTerminalButton.Location = new Point(1326, 816);
            clearTerminalButton.Name = "clearTerminalButton";
            clearTerminalButton.Size = new Size(112, 34);
            clearTerminalButton.TabIndex = 7;
            clearTerminalButton.Text = "Clear";
            clearTerminalButton.UseVisualStyleBackColor = true;
            clearTerminalButton.Click += clearTerminalButton_Click;
            // 
            // UserGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 932);
            Controls.Add(clearTerminalButton);
            Controls.Add(sendCommandLabel);
            Controls.Add(sendCommandTextBox);
            Controls.Add(terminalSendButton);
            Controls.Add(terminalLabel);
            Controls.Add(terminalRichTextBox);
            Controls.Add(C);
            Name = "UserGUI";
            Text = "RS232 Terminal";
            C.ResumeLayout(false);
            C.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox C;
        private Label stopBitsLabel;
        private Label baudRateLabel;
        private Label comPortLabel;
        private ComboBox stopBitsCBox;
        private ComboBox baudRateCBox;
        private ComboBox comPortCBox;
        private ComboBox flowControlCBox;
        private Label flowControlLabel;
        private ComboBox dataBitsCBox;
        private Label dataBitsLabel;
        private Button OpenCloseComButton;
        private Button refreshComsButton;
        private ComboBox parityCBox;
        private Label parityLabel;
        private RichTextBox terminalRichTextBox;
        private Label terminalLabel;
        private Button terminalSendButton;
        private TextBox sendCommandTextBox;
        private Label sendCommandLabel;
        private ComboBox terminatorCBox;
        private Label terminatorLabel;
        private TextBox ownTerminatorTextBox;
        private Button clearTerminalButton;
    }
}