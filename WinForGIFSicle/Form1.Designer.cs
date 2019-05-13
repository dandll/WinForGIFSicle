namespace WinForGIFSicle
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnAnBiLiSuoXiao = new System.Windows.Forms.Button();
            this.btnYaSuo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBiLi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(495, 21);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(513, 10);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnAnBiLiSuoXiao
            // 
            this.btnAnBiLiSuoXiao.Location = new System.Drawing.Point(100, 82);
            this.btnAnBiLiSuoXiao.Name = "btnAnBiLiSuoXiao";
            this.btnAnBiLiSuoXiao.Size = new System.Drawing.Size(75, 23);
            this.btnAnBiLiSuoXiao.TabIndex = 5;
            this.btnAnBiLiSuoXiao.Text = "按比例缩小";
            this.btnAnBiLiSuoXiao.UseVisualStyleBackColor = true;
            this.btnAnBiLiSuoXiao.Click += new System.EventHandler(this.btnAnBiLiSuoXiao_Click);
            // 
            // btnYaSuo
            // 
            this.btnYaSuo.Location = new System.Drawing.Point(100, 126);
            this.btnYaSuo.Name = "btnYaSuo";
            this.btnYaSuo.Size = new System.Drawing.Size(75, 23);
            this.btnYaSuo.TabIndex = 6;
            this.btnYaSuo.Text = "直接压缩";
            this.btnYaSuo.UseVisualStyleBackColor = true;
            this.btnYaSuo.Click += new System.EventHandler(this.btnYaSuo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "比例";
            // 
            // txtBiLi
            // 
            this.txtBiLi.Location = new System.Drawing.Point(50, 84);
            this.txtBiLi.Name = "txtBiLi";
            this.txtBiLi.Size = new System.Drawing.Size(27, 21);
            this.txtBiLi.TabIndex = 8;
            this.txtBiLi.Text = "80";
            this.txtBiLi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBiLi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBiLi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(63, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "原目录";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "桌面";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "保存至";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBiLi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYaSuo);
            this.Controls.Add(this.btnAnBiLiSuoXiao);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "WinForGIFSicle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnAnBiLiSuoXiao;
        private System.Windows.Forms.Button btnYaSuo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBiLi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
    }
}

