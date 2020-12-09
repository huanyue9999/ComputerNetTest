namespace Sever
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.WaitingList = new System.Windows.Forms.Label();
            this.Local_IP = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.LableIP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.comboBoxListen = new System.Windows.Forms.ComboBox();
            this.Stop = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonFile_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(54, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始监听";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send.Location = new System.Drawing.Point(659, 308);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 40);
            this.Send.TabIndex = 1;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // WaitingList
            // 
            this.WaitingList.AutoSize = true;
            this.WaitingList.BackColor = System.Drawing.SystemColors.Control;
            this.WaitingList.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WaitingList.Location = new System.Drawing.Point(21, 159);
            this.WaitingList.Name = "WaitingList";
            this.WaitingList.Size = new System.Drawing.Size(132, 25);
            this.WaitingList.TabIndex = 2;
            this.WaitingList.Text = "Waiting List";
            // 
            // Local_IP
            // 
            this.Local_IP.AutoSize = true;
            this.Local_IP.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Local_IP.Location = new System.Drawing.Point(101, 30);
            this.Local_IP.Name = "Local_IP";
            this.Local_IP.Size = new System.Drawing.Size(97, 25);
            this.Local_IP.TabIndex = 3;
            this.Local_IP.Text = "Local_IP";
            this.Local_IP.Click += new System.EventHandler(this.Local_IP_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(106, 95);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(126, 28);
            this.textBoxPort.TabIndex = 4;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(389, 308);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(264, 28);
            this.textBoxSend.TabIndex = 5;
            // 
            // LableIP
            // 
            this.LableIP.AutoSize = true;
            this.LableIP.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LableIP.Location = new System.Drawing.Point(43, 30);
            this.LableIP.Name = "LableIP";
            this.LableIP.Size = new System.Drawing.Size(32, 25);
            this.LableIP.TabIndex = 6;
            this.LableIP.Text = "IP";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Port.Location = new System.Drawing.Point(31, 98);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(56, 25);
            this.Port.TabIndex = 7;
            this.Port.Text = "Port";
            // 
            // comboBoxListen
            // 
            this.comboBoxListen.FormattingEnabled = true;
            this.comboBoxListen.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBoxListen.Location = new System.Drawing.Point(159, 159);
            this.comboBoxListen.Name = "comboBoxListen";
            this.comboBoxListen.Size = new System.Drawing.Size(121, 26);
            this.comboBoxListen.TabIndex = 8;
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(97, 301);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 35);
            this.Stop.TabIndex = 9;
            this.Stop.Text = "抖动";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(389, 30);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(345, 272);
            this.textBoxDisplay.TabIndex = 10;
            this.textBoxDisplay.Text = "";
            // 
            // buttonFile_Click
            // 
            this.buttonFile_Click.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFile_Click.Location = new System.Drawing.Point(592, 366);
            this.buttonFile_Click.Name = "buttonFile_Click";
            this.buttonFile_Click.Size = new System.Drawing.Size(129, 36);
            this.buttonFile_Click.TabIndex = 11;
            this.buttonFile_Click.Text = "发送文件";
            this.buttonFile_Click.UseVisualStyleBackColor = true;
            this.buttonFile_Click.Click += new System.EventHandler(this.buttonFile_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "@2018级计科三班范少帅";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFile_Click);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.comboBoxListen);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.LableIP);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.Local_IP);
            this.Controls.Add(this.WaitingList);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "服务端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label WaitingList;
        private System.Windows.Forms.Label Local_IP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Label LableIP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.ComboBox comboBoxListen;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.RichTextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonFile_Click;
        private System.Windows.Forms.Label label1;
    }
}

