namespace _11UploadFileFunction
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.targetPath = new System.Windows.Forms.TextBox();
            this.sourceFileName = new System.Windows.Forms.TextBox();
            this.targetFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "來源位置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目標位置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "來源檔名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "目標檔名：";
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(172, 49);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(100, 22);
            this.sourcePath.TabIndex = 4;
            
            // 
            // targetPath
            // 
            this.targetPath.Location = new System.Drawing.Point(172, 102);
            this.targetPath.Name = "targetPath";
            this.targetPath.Size = new System.Drawing.Size(100, 22);
            this.targetPath.TabIndex = 5;
            
            // 
            // sourceFileName
            // 
            this.sourceFileName.Location = new System.Drawing.Point(172, 153);
            this.sourceFileName.Name = "sourceFileName";
            this.sourceFileName.Size = new System.Drawing.Size(100, 22);
            this.sourceFileName.TabIndex = 6;
            // 
            // targetFileName
            // 
            this.targetFileName.Location = new System.Drawing.Point(172, 201);
            this.targetFileName.Name = "targetFileName";
            this.targetFileName.Size = new System.Drawing.Size(100, 22);
            this.targetFileName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "傳送檔案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.targetFileName);
            this.Controls.Add(this.sourceFileName);
            this.Controls.Add(this.targetPath);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox targetPath;
        private System.Windows.Forms.TextBox sourceFileName;
        private System.Windows.Forms.TextBox targetFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

