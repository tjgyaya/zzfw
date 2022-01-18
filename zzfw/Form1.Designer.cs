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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_star
            // 
            this.btn_star.Location = new System.Drawing.Point(471, 21);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(97, 52);
            this.btn_star.TabIndex = 0;
            this.btn_star.Text = "开始运行";
            this.btn_star.UseVisualStyleBackColor = true;
            // 
            // tb_dk
            // 
            this.tb_dk.Location = new System.Drawing.Point(165, 17);
            this.tb_dk.Name = "tb_dk";
            this.tb_dk.Size = new System.Drawing.Size(67, 21);
            this.tb_dk.TabIndex = 2;
            this.tb_dk.Text = "14666";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "连接矿池：";
            // 
            // tb_kc
            // 
            this.tb_kc.Location = new System.Drawing.Point(165, 53);
            this.tb_kc.Name = "tb_kc";
            this.tb_kc.Size = new System.Drawing.Size(217, 21);
            this.tb_kc.TabIndex = 4;
            this.tb_kc.Text = "tcp://asia1.ethermine.org:4444";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(647, 233);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "统一钱包：";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(165, 89);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(265, 21);
            this.tb_money.TabIndex = 8;
            this.tb_money.Text = "0x0da75f7b2a4e117175bc4d0a82215b5bc9c6d27e";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 418);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_kc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dk);
            this.Controls.Add(this.btn_star);
            this.Name = "Form1";
            this.Text = "中转服务+反抽水";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.TextBox tb_dk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_kc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_money;
    }
}

