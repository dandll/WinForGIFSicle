﻿namespace WinForGIFSicle
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
            this.btnClearTxt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLossy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLossy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtSelectPath = new System.Windows.Forms.TextBox();
            this.cbFileNameChange = new System.Windows.Forms.CheckBox();
            this.cbFileNameNoChange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilePath.Size = new System.Drawing.Size(576, 180);
            this.txtFilePath.TabIndex = 4;
            this.txtFilePath.WordWrap = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 198);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnAnBiLiSuoXiao
            // 
            this.btnAnBiLiSuoXiao.Location = new System.Drawing.Point(98, 308);
            this.btnAnBiLiSuoXiao.Name = "btnAnBiLiSuoXiao";
            this.btnAnBiLiSuoXiao.Size = new System.Drawing.Size(90, 23);
            this.btnAnBiLiSuoXiao.TabIndex = 5;
            this.btnAnBiLiSuoXiao.Text = "按比例压缩";
            this.btnAnBiLiSuoXiao.UseVisualStyleBackColor = true;
            this.btnAnBiLiSuoXiao.Click += new System.EventHandler(this.btnAnBiLiSuoXiao_Click);
            // 
            // btnYaSuo
            // 
            this.btnYaSuo.Location = new System.Drawing.Point(96, 353);
            this.btnYaSuo.Name = "btnYaSuo";
            this.btnYaSuo.Size = new System.Drawing.Size(90, 23);
            this.btnYaSuo.TabIndex = 6;
            this.btnYaSuo.Text = "程序自动压缩";
            this.btnYaSuo.UseVisualStyleBackColor = true;
            this.btnYaSuo.Click += new System.EventHandler(this.btnYaSuo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "比例";
            // 
            // txtBiLi
            // 
            this.txtBiLi.Location = new System.Drawing.Point(48, 310);
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
            this.label2.Location = new System.Drawing.Point(81, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(59, 239);
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
            this.radioButton2.Location = new System.Drawing.Point(124, 239);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "桌面";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "保存至";
            // 
            // btnClearTxt
            // 
            this.btnClearTxt.Location = new System.Drawing.Point(367, 198);
            this.btnClearTxt.Name = "btnClearTxt";
            this.btnClearTxt.Size = new System.Drawing.Size(75, 23);
            this.btnClearTxt.TabIndex = 13;
            this.btnClearTxt.Text = "清空选择";
            this.btnClearTxt.UseVisualStyleBackColor = true;
            this.btnClearTxt.Click += new System.EventHandler(this.btnClearTxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(94, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "*多个GIF可直接选择文件后，拖拽至程序即可";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(383, 308);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Value = 35;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "lossy压缩";
            // 
            // txtLossy
            // 
            this.txtLossy.Location = new System.Drawing.Point(322, 310);
            this.txtLossy.Name = "txtLossy";
            this.txtLossy.Size = new System.Drawing.Size(53, 21);
            this.txtLossy.TabIndex = 17;
            this.txtLossy.Text = "35";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 2);
            this.label6.TabIndex = 18;
            // 
            // btnLossy
            // 
            this.btnLossy.Location = new System.Drawing.Point(383, 353);
            this.btnLossy.Name = "btnLossy";
            this.btnLossy.Size = new System.Drawing.Size(75, 23);
            this.btnLossy.TabIndex = 19;
            this.btnLossy.Text = "lossy压缩";
            this.btnLossy.UseVisualStyleBackColor = true;
            this.btnLossy.Click += new System.EventHandler(this.btnLossy_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(236, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 82);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(14, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(520, 2);
            this.label8.TabIndex = 21;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(177, 239);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "自选目录";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(466, 237);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(37, 23);
            this.btnSelectPath.TabIndex = 23;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtSelectPath
            // 
            this.txtSelectPath.Location = new System.Drawing.Point(254, 238);
            this.txtSelectPath.Name = "txtSelectPath";
            this.txtSelectPath.Size = new System.Drawing.Size(213, 21);
            this.txtSelectPath.TabIndex = 24;
            // 
            // cbFileNameChange
            // 
            this.cbFileNameChange.AutoSize = true;
            this.cbFileNameChange.Checked = true;
            this.cbFileNameChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFileNameChange.Location = new System.Drawing.Point(59, 268);
            this.cbFileNameChange.Name = "cbFileNameChange";
            this.cbFileNameChange.Size = new System.Drawing.Size(168, 16);
            this.cbFileNameChange.TabIndex = 25;
            this.cbFileNameChange.Text = "保存的文件名添加时间信息";
            this.cbFileNameChange.UseVisualStyleBackColor = true;
            this.cbFileNameChange.CheckedChanged += new System.EventHandler(this.cbFileNameChange_CheckedChanged);
            // 
            // cbFileNameNoChange
            // 
            this.cbFileNameNoChange.AutoSize = true;
            this.cbFileNameNoChange.Location = new System.Drawing.Point(233, 268);
            this.cbFileNameNoChange.Name = "cbFileNameNoChange";
            this.cbFileNameNoChange.Size = new System.Drawing.Size(168, 16);
            this.cbFileNameNoChange.TabIndex = 26;
            this.cbFileNameNoChange.Text = "保存文件名不添加时间信息";
            this.cbFileNameNoChange.UseVisualStyleBackColor = true;
            this.cbFileNameNoChange.CheckedChanged += new System.EventHandler(this.cbFileNameNoChange_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 448);
            this.Controls.Add(this.cbFileNameNoChange);
            this.Controls.Add(this.cbFileNameChange);
            this.Controls.Add(this.txtSelectPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLossy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLossy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearTxt);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button btnClearTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLossy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLossy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtSelectPath;
        private System.Windows.Forms.CheckBox cbFileNameChange;
        private System.Windows.Forms.CheckBox cbFileNameNoChange;
    }
}

