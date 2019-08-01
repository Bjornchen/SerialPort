namespace PortControlDemo
{
    partial class FrmPortControl
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
            this.peBody = new System.Windows.Forms.Panel();
            this.pe_show = new System.Windows.Forms.Panel();
            this.pe_receive = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pe_send = new System.Windows.Forms.Panel();
            this.Btn_send = new System.Windows.Forms.Button();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pe_set = new System.Windows.Forms.Panel();
            this.cb_timeout = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_open = new System.Windows.Forms.Button();
            this.cb_checkBit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_dataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_portNameSend = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.peBody.SuspendLayout();
            this.pe_show.SuspendLayout();
            this.pe_receive.SuspendLayout();
            this.pe_send.SuspendLayout();
            this.pe_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // peBody
            // 
            this.peBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.peBody.Controls.Add(this.pe_show);
            this.peBody.Controls.Add(this.pe_set);
            this.peBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peBody.Location = new System.Drawing.Point(0, 0);
            this.peBody.Name = "peBody";
            this.peBody.Size = new System.Drawing.Size(544, 353);
            this.peBody.TabIndex = 0;
            // 
            // pe_show
            // 
            this.pe_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pe_show.Controls.Add(this.pe_receive);
            this.pe_show.Controls.Add(this.pe_send);
            this.pe_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_show.Location = new System.Drawing.Point(200, 0);
            this.pe_show.Name = "pe_show";
            this.pe_show.Size = new System.Drawing.Size(344, 353);
            this.pe_show.TabIndex = 0;
            // 
            // pe_receive
            // 
            this.pe_receive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pe_receive.Controls.Add(this.label8);
            this.pe_receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_receive.Location = new System.Drawing.Point(0, 349);
            this.pe_receive.Name = "pe_receive";
            this.pe_receive.Size = new System.Drawing.Size(342, 2);
            this.pe_receive.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 2;
            // 
            // pe_send
            // 
            this.pe_send.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pe_send.Controls.Add(this.button1);
            this.pe_send.Controls.Add(this.Btn_send);
            this.pe_send.Controls.Add(this.tb_send);
            this.pe_send.Controls.Add(this.label7);
            this.pe_send.Dock = System.Windows.Forms.DockStyle.Top;
            this.pe_send.Location = new System.Drawing.Point(0, 0);
            this.pe_send.Name = "pe_send";
            this.pe_send.Size = new System.Drawing.Size(342, 349);
            this.pe_send.TabIndex = 0;
            // 
            // Btn_send
            // 
            this.Btn_send.Location = new System.Drawing.Point(243, 316);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(75, 23);
            this.Btn_send.TabIndex = 12;
            this.Btn_send.Text = "发送数据";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(18, 51);
            this.tb_send.Multiline = true;
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(300, 241);
            this.tb_send.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "发送管理";
            // 
            // pe_set
            // 
            this.pe_set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pe_set.Controls.Add(this.cb_timeout);
            this.pe_set.Controls.Add(this.label9);
            this.pe_set.Controls.Add(this.Btn_open);
            this.pe_set.Controls.Add(this.cb_checkBit);
            this.pe_set.Controls.Add(this.label6);
            this.pe_set.Controls.Add(this.cb_stopBit);
            this.pe_set.Controls.Add(this.label5);
            this.pe_set.Controls.Add(this.cb_dataBit);
            this.pe_set.Controls.Add(this.label4);
            this.pe_set.Controls.Add(this.cb_baudRate);
            this.pe_set.Controls.Add(this.label3);
            this.pe_set.Controls.Add(this.cb_portNameSend);
            this.pe_set.Controls.Add(this.label2);
            this.pe_set.Controls.Add(this.label1);
            this.pe_set.Dock = System.Windows.Forms.DockStyle.Left;
            this.pe_set.Location = new System.Drawing.Point(0, 0);
            this.pe_set.Name = "pe_set";
            this.pe_set.Size = new System.Drawing.Size(200, 353);
            this.pe_set.TabIndex = 0;
            // 
            // cb_timeout
            // 
            this.cb_timeout.FormattingEnabled = true;
            this.cb_timeout.Location = new System.Drawing.Point(63, 209);
            this.cb_timeout.Name = "cb_timeout";
            this.cb_timeout.Size = new System.Drawing.Size(111, 20);
            this.cb_timeout.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(10, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "超时ms：";
            // 
            // Btn_open
            // 
            this.Btn_open.Location = new System.Drawing.Point(37, 263);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(122, 23);
            this.Btn_open.TabIndex = 11;
            this.Btn_open.Text = "打开发送接收串口";
            this.Btn_open.UseVisualStyleBackColor = true;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // cb_checkBit
            // 
            this.cb_checkBit.FormattingEnabled = true;
            this.cb_checkBit.Location = new System.Drawing.Point(63, 175);
            this.cb_checkBit.Name = "cb_checkBit";
            this.cb_checkBit.Size = new System.Drawing.Size(111, 20);
            this.cb_checkBit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(11, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "校验位：";
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Location = new System.Drawing.Point(63, 144);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(111, 20);
            this.cb_stopBit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "停止位：";
            // 
            // cb_dataBit
            // 
            this.cb_dataBit.FormattingEnabled = true;
            this.cb_dataBit.Location = new System.Drawing.Point(63, 114);
            this.cb_dataBit.Name = "cb_dataBit";
            this.cb_dataBit.Size = new System.Drawing.Size(111, 20);
            this.cb_dataBit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "数据位：";
            // 
            // cb_baudRate
            // 
            this.cb_baudRate.FormattingEnabled = true;
            this.cb_baudRate.Location = new System.Drawing.Point(63, 83);
            this.cb_baudRate.Name = "cb_baudRate";
            this.cb_baudRate.Size = new System.Drawing.Size(111, 20);
            this.cb_baudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "波特率：";
            // 
            // cb_portNameSend
            // 
            this.cb_portNameSend.FormattingEnabled = true;
            this.cb_portNameSend.Location = new System.Drawing.Point(63, 51);
            this.cb_portNameSend.Name = "cb_portNameSend";
            this.cb_portNameSend.Size = new System.Drawing.Size(111, 20);
            this.cb_portNameSend.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "发送端：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口通信参数设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "清空数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_click);
            // 
            // FrmPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.peBody);
            this.Name = "FrmPortControl";
            this.Text = "串口通信";
            this.peBody.ResumeLayout(false);
            this.pe_show.ResumeLayout(false);
            this.pe_receive.ResumeLayout(false);
            this.pe_send.ResumeLayout(false);
            this.pe_send.PerformLayout();
            this.pe_set.ResumeLayout(false);
            this.pe_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel peBody;
        private System.Windows.Forms.Panel pe_show;
        private System.Windows.Forms.Panel pe_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_checkBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_dataBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_portNameSend;
        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.Panel pe_receive;
        private System.Windows.Forms.Panel pe_send;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button Btn_send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_timeout;
        private System.Windows.Forms.Button button1;
    }
}

