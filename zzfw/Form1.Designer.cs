namespace zzfw
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
            this.btn_star = new System.Windows.Forms.Button();
            this.tb_dk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_kc = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lb_OnlineClient = new System.Windows.Forms.ListBox();
            this.Tb_ClientNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_TestMsg = new System.Windows.Forms.TextBox();
            this.Cb_IsAsync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_star
            // 
            this.btn_star.Location = new System.Drawing.Point(673, 27);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(97, 52);
            this.btn_star.TabIndex = 0;
            this.btn_star.Text = "开始运行";
            this.btn_star.UseVisualStyleBackColor = true;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // tb_dk
            // 
            this.tb_dk.Location = new System.Drawing.Point(324, 26);
            this.tb_dk.Name = "tb_dk";
            this.tb_dk.Size = new System.Drawing.Size(67, 21);
            this.tb_dk.TabIndex = 2;
            this.tb_dk.Text = "14666";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "连接矿池：";
            // 
            // tb_kc
            // 
            this.tb_kc.Location = new System.Drawing.Point(324, 62);
            this.tb_kc.Name = "tb_kc";
            this.tb_kc.Size = new System.Drawing.Size(217, 21);
            this.tb_kc.TabIndex = 4;
            this.tb_kc.Text = "tcp://asia1.ethermine.org:4444";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(181, 154);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(647, 252);
            this.msgBox.TabIndex = 6;
            this.msgBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "统一钱包：";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(324, 98);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(265, 21);
            this.tb_money.TabIndex = 8;
            this.tb_money.Text = "0x0da75f7b2a4e117175bc4d0a82215b5bc9c6d27e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "客户端列表";
            // 
            // Lb_OnlineClient
            // 
            this.Lb_OnlineClient.FormattingEnabled = true;
            this.Lb_OnlineClient.ItemHeight = 12;
            this.Lb_OnlineClient.Items.AddRange(new object[] {
            "1212",
            "412121"});
            this.Lb_OnlineClient.Location = new System.Drawing.Point(9, 57);
            this.Lb_OnlineClient.Name = "Lb_OnlineClient";
            this.Lb_OnlineClient.Size = new System.Drawing.Size(154, 352);
            this.Lb_OnlineClient.TabIndex = 11;
            this.Lb_OnlineClient.SelectedIndexChanged += new System.EventHandler(this.Lb_OnlineClient_SelectedIndexChanged);
            // 
            // Tb_ClientNum
            // 
            this.Tb_ClientNum.AutoSize = true;
            this.Tb_ClientNum.Location = new System.Drawing.Point(139, 26);
            this.Tb_ClientNum.Name = "Tb_ClientNum";
            this.Tb_ClientNum.Size = new System.Drawing.Size(11, 12);
            this.Tb_ClientNum.TabIndex = 3;
            this.Tb_ClientNum.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb_TestMsg
            // 
            this.Tb_TestMsg.Location = new System.Drawing.Point(324, 128);
            this.Tb_TestMsg.Name = "Tb_TestMsg";
            this.Tb_TestMsg.Size = new System.Drawing.Size(264, 21);
            this.Tb_TestMsg.TabIndex = 13;
            // 
            // Cb_IsAsync
            // 
            this.Cb_IsAsync.AutoSize = true;
            this.Cb_IsAsync.Location = new System.Drawing.Point(611, 132);
            this.Cb_IsAsync.Name = "Cb_IsAsync";
            this.Cb_IsAsync.Size = new System.Drawing.Size(48, 16);
            this.Cb_IsAsync.TabIndex = 14;
            this.Cb_IsAsync.Text = "异步";
            this.Cb_IsAsync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 418);
            this.Controls.Add(this.Cb_IsAsync);
            this.Controls.Add(this.Tb_TestMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lb_OnlineClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_kc);
            this.Controls.Add(this.Tb_ClientNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dk);
            this.Controls.Add(this.btn_star);
            this.Name = "Form1";
            this.Text = "中转服务+反抽水";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.TextBox tb_dk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kc;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Lb_OnlineClient;
        private System.Windows.Forms.Label Tb_ClientNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_TestMsg;
        private System.Windows.Forms.CheckBox Cb_IsAsync;
    }
}

