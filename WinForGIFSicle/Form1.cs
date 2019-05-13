﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForGIFSicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 拖放文件
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            DragFile(e);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            DragFile(e);
        }

        void DragFile(DragEventArgs e)
        {
            //如果拖进来的是文件类型
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] paths = e.Data.GetData(DataFormats.FileDrop) as string[];
                //得到拖进来的路径,取第一个文件
                string path = paths[0];
                //Clipboard.SetText(path);
                txtFilePath.Text = path;
                //string fileName = txtFilePath.Text.Substring(txtFilePath.Text.LastIndexOf('\\') + 1);
                //路径字符串长度不为空
                if (path.Length > 1)
                {
                    //判断是文件夹吗
                    FileInfo fil = new FileInfo(path);
                    if (fil.Attributes == FileAttributes.Directory)//文件夹
                    {
                        //鼠标图标链接
                        e.Effect = DragDropEffects.Link;
                    }
                    else//文件
                    {
                        //鼠标图标链接
                        e.Effect = DragDropEffects.Link;
                    }
                }
                else
                {
                    //鼠标图标禁止
                    e.Effect = DragDropEffects.None;
                }
            }
        }
        #endregion
        
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GIF文件|*.gif|所有文件|*.*";
            ofd.RestoreDirectory = true;
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fName = ofd.FileName;
                txtFilePath.Text = fName;
                //btnLoadImgInfo_Click(null, null);
            }
        }

        private void btnAnBiLiSuoXiao_Click(object sender, EventArgs e)
        {
            if (!(!string.IsNullOrEmpty(txtFilePath.Text) && File.Exists(txtFilePath.Text)))
            { MessageBox.Show("请选择文件！"); }
            //gifsicle.exe 0.gif --scale 0.8 -o small.gif
            string filePath = txtFilePath.Text;
            int biLi = int.Parse(txtBiLi.Text);
            string str = "gifsicle.exe " + txtFilePath.Text + " --scale " + ((double)biLi / (double)100).ToString("0.00") + " -o "+ txtFilePath.Text.Insert(txtFilePath.Text.Length - 5, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            if (radioButton2.Checked)
            {
                str = "gifsicle.exe " + txtFilePath.Text + " --scale " + ((double)biLi / (double)100).ToString("0.00") + " -o " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/" + Path.GetFileName(txtFilePath.Text).Replace(".", DateTime.Now.ToString("yyMMddHHmmssfff") + ".");
            }
            CMD(str);
        }

        private void btnYaSuo_Click(object sender, EventArgs e)
        {
            if (!(!string.IsNullOrEmpty(txtFilePath.Text) && File.Exists(txtFilePath.Text)))
            { MessageBox.Show("请选择文件！"); }
            //Directory.GetFiles(
            //gifsicle -O3 0.gif -o new.gif
            //string fileName = txtFilePath.Text.Substring(txtFilePath.Text.LastIndexOf('\\') + 1);
            string str = "gifsicle.exe -O3 " + txtFilePath.Text + " -o " + txtFilePath.Text.Insert(txtFilePath.Text.Length - 5, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            if (radioButton2.Checked)
            {
                str = "gifsicle.exe -O3 " + txtFilePath.Text + " -o " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/" + Path.GetFileName(txtFilePath.Text).Replace(".", DateTime.Now.ToString("yyMMddHHmmssfff") + ".");
            }
            CMD(str);
        }

        string CMD(string mingLing)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(mingLing + "&exit");

            p.StandardInput.AutoFlush = true;
            //p.StandardInput.WriteLine("exit");
            //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
            //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令

            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();

            //StreamReader reader = p.StandardOutput;
            //string line=reader.ReadLine();
            //while (!reader.EndOfStream)
            //{
            //    str += line + "  ";
            //    line = reader.ReadLine();
            //}

            p.WaitForExit();//等待程序执行完退出进程
            p.Close();

            //Console.WriteLine(output);
            return output;
        }

        private void txtBiLi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)48 && e.KeyChar <= (char)57) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}