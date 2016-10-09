namespace SPDB_Client
{
    partial class SPDB_C_LogIn
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever IP";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_IP.Location = new System.Drawing.Point(78, 17);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(129, 27);
            this.textBox_IP.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Connect.Location = new System.Drawing.Point(231, 16);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(86, 29);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "連接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(75, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "在線人數：";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(78, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(160, 196);
            this.listBox1.TabIndex = 4;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_Name.Location = new System.Drawing.Point(78, 324);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(129, 27);
            this.textBox_Name.TabIndex = 5;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Enabled = false;
            this.btn_Enter.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Enter.Location = new System.Drawing.Point(231, 323);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(86, 29);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "進入";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(32, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "暱稱";
            // 
            // SPDB_C_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Name = "SPDB_C_LogIn";
            this.Text = "同步繪畫暨討論版 － Clint連線";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label3;
    }
}

