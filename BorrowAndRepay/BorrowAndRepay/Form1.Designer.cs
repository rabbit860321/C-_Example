namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MynameInput = new System.Windows.Forms.TextBox();
            this.FriendnameInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MynameLabel = new System.Windows.Forms.Label();
            this.MymoneyLabel = new System.Windows.Forms.Label();
            this.FriendmoneyLabel = new System.Windows.Forms.Label();
            this.FriendnameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.RepayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(72, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入朋友的名字：";
            // 
            // MynameInput
            // 
            this.MynameInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.MynameInput.Location = new System.Drawing.Point(239, 63);
            this.MynameInput.Name = "MynameInput";
            this.MynameInput.Size = new System.Drawing.Size(148, 27);
            this.MynameInput.TabIndex = 2;
            // 
            // FriendnameInput
            // 
            this.FriendnameInput.Font = new System.Drawing.Font("新細明體", 12F);
            this.FriendnameInput.Location = new System.Drawing.Point(239, 97);
            this.FriendnameInput.Name = "FriendnameInput";
            this.FriendnameInput.Size = new System.Drawing.Size(148, 27);
            this.FriendnameInput.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.SubmitButton.Location = new System.Drawing.Point(410, 63);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(97, 61);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "確認";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(46, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(46, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "我的＄：";
            // 
            // MynameLabel
            // 
            this.MynameLabel.AutoSize = true;
            this.MynameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.MynameLabel.Location = new System.Drawing.Point(131, 172);
            this.MynameLabel.Name = "MynameLabel";
            this.MynameLabel.Size = new System.Drawing.Size(56, 16);
            this.MynameLabel.TabIndex = 7;
            this.MynameLabel.Text = "無名氏";
            // 
            // MymoneyLabel
            // 
            this.MymoneyLabel.AutoSize = true;
            this.MymoneyLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.MymoneyLabel.Location = new System.Drawing.Point(131, 203);
            this.MymoneyLabel.Name = "MymoneyLabel";
            this.MymoneyLabel.Size = new System.Drawing.Size(16, 16);
            this.MymoneyLabel.TabIndex = 8;
            this.MymoneyLabel.Text = "0";
            // 
            // FriendmoneyLabel
            // 
            this.FriendmoneyLabel.AutoSize = true;
            this.FriendmoneyLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.FriendmoneyLabel.Location = new System.Drawing.Point(361, 206);
            this.FriendmoneyLabel.Name = "FriendmoneyLabel";
            this.FriendmoneyLabel.Size = new System.Drawing.Size(56, 16);
            this.FriendmoneyLabel.TabIndex = 12;
            this.FriendmoneyLabel.Text = "200000";
            // 
            // FriendnameLabel
            // 
            this.FriendnameLabel.AutoSize = true;
            this.FriendnameLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.FriendnameLabel.Location = new System.Drawing.Point(361, 175);
            this.FriendnameLabel.Name = "FriendnameLabel";
            this.FriendnameLabel.Size = new System.Drawing.Size(56, 16);
            this.FriendnameLabel.TabIndex = 11;
            this.FriendnameLabel.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.Location = new System.Drawing.Point(251, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "朋友的＄：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F);
            this.label10.Location = new System.Drawing.Point(251, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名字：";
            // 
            // BorrowButton
            // 
            this.BorrowButton.Enabled = false;
            this.BorrowButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.BorrowButton.Location = new System.Drawing.Point(49, 257);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(458, 61);
            this.BorrowButton.TabIndex = 13;
            this.BorrowButton.Text = "跟XXX借$1000";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // RepayButton
            // 
            this.RepayButton.Enabled = false;
            this.RepayButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.RepayButton.Location = new System.Drawing.Point(49, 341);
            this.RepayButton.Name = "RepayButton";
            this.RepayButton.Size = new System.Drawing.Size(458, 61);
            this.RepayButton.TabIndex = 14;
            this.RepayButton.Text = "還給XXX$1000";
            this.RepayButton.UseVisualStyleBackColor = true;
            this.RepayButton.Click += new System.EventHandler(this.RepayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.RepayButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.FriendmoneyLabel);
            this.Controls.Add(this.FriendnameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MymoneyLabel);
            this.Controls.Add(this.MynameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FriendnameInput);
            this.Controls.Add(this.MynameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "借還前程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MynameInput;
        private System.Windows.Forms.TextBox FriendnameInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MynameLabel;
        private System.Windows.Forms.Label MymoneyLabel;
        private System.Windows.Forms.Label FriendmoneyLabel;
        private System.Windows.Forms.Label FriendnameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button RepayButton;
    }
}

