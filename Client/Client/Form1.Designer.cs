namespace Client
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
            this.buttonConnect_Click = new System.Windows.Forms.Button();
            this.buttonSend_Click = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect_Click
            // 
            this.buttonConnect_Click.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConnect_Click.Location = new System.Drawing.Point(152, 183);
            this.buttonConnect_Click.Name = "buttonConnect_Click";
            this.buttonConnect_Click.Size = new System.Drawing.Size(92, 32);
            this.buttonConnect_Click.TabIndex = 0;
            this.buttonConnect_Click.Text = "连接";
            this.buttonConnect_Click.UseVisualStyleBackColor = true;
            this.buttonConnect_Click.Click += new System.EventHandler(this.buttonConnect_Click_Click);
            // 
            // buttonSend_Click
            // 
            this.buttonSend_Click.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend_Click.Location = new System.Drawing.Point(673, 321);
            this.buttonSend_Click.Name = "buttonSend_Click";
            this.buttonSend_Click.Size = new System.Drawing.Size(101, 47);
            this.buttonSend_Click.TabIndex = 1;
            this.buttonSend_Click.Text = "发送";
            this.buttonSend_Click.UseVisualStyleBackColor = true;
            this.buttonSend_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(152, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "断开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SeverIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(152, 42);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(159, 28);
            this.textBoxIP.TabIndex = 5;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(152, 100);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(159, 28);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(390, 321);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(277, 28);
            this.textBoxSend.TabIndex = 7;
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(390, 31);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(359, 284);
            this.textBoxDisplay.TabIndex = 8;
            this.textBoxDisplay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "@2018级计科三班范少帅";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSend_Click);
            this.Controls.Add(this.buttonConnect_Click);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect_Click;
        private System.Windows.Forms.Button buttonSend_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.RichTextBox textBoxDisplay;
        private System.Windows.Forms.Label label3;
    }
}

