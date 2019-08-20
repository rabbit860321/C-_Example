using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11UploadFileFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(sourcePath.Text) && !(String.IsNullOrEmpty(targetPath.Text)) && 
                !String.IsNullOrEmpty(sourceFileName.Text) && !(String.IsNullOrEmpty(targetFileName.Text)))
            {
                //組合檔案來源位置字串
                string sourceFile = Path.Combine(sourcePath.Text, sourceFileName.Text);
                //組合檔案目的位置字串
                string destFile = Path.Combine(targetPath.Text, targetFileName.Text);

                //檢查目的地資料夾是否存在
                if (!Directory.Exists(targetPath.Text))
                {
                    //若無 則建立資料夾
                    Directory.CreateDirectory(targetPath.Text);
                }

                try
                {
                    File.Copy(sourceFile, destFile, true);
                    label5.Text = "傳送成功";
                }
                catch (Exception)
                {
                    label5.Text = "傳送成功";
                }
            }
            else
            {
                MessageBox.Show("不可為空");
            }
        }
    }
}
