﻿namespace DBzd
{
    partial class ToolsPaperNum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.combYear = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.nUD201 = new System.Windows.Forms.NumericUpDown();
            this.nUD202 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nUD203 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nUD301 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUD302 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nUD105 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nUD104 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nUD103 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nUD102 = new System.Windows.Forms.NumericUpDown();
            this.nUD101 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb302 = new System.Windows.Forms.CheckBox();
            this.chb105 = new System.Windows.Forms.CheckBox();
            this.chb104 = new System.Windows.Forms.CheckBox();
            this.chb103 = new System.Windows.Forms.CheckBox();
            this.chb301 = new System.Windows.Forms.CheckBox();
            this.chb203 = new System.Windows.Forms.CheckBox();
            this.chb202 = new System.Windows.Forms.CheckBox();
            this.chb201 = new System.Windows.Forms.CheckBox();
            this.chb102 = new System.Windows.Forms.CheckBox();
            this.chb101 = new System.Windows.Forms.CheckBox();
            this.butFenPei = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD201)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD202)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD203)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD301)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD302)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD101)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "年度：";
            // 
            // combYear
            // 
            this.combYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(59, 11);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(78, 20);
            this.combYear.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "按金额自动分配：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(250, 10);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(102, 21);
            this.txtMoney.TabIndex = 12;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(12, 220);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(53, 12);
            this.labTotal.TabIndex = 13;
            this.labTotal.Text = "当前金额";
            // 
            // nUD201
            // 
            this.nUD201.Location = new System.Drawing.Point(269, 23);
            this.nUD201.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD201.Name = "nUD201";
            this.nUD201.Size = new System.Drawing.Size(45, 21);
            this.nUD201.TabIndex = 3;
            this.nUD201.Tag = "201";
            this.nUD201.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // nUD202
            // 
            this.nUD202.Location = new System.Drawing.Point(269, 51);
            this.nUD202.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD202.Name = "nUD202";
            this.nUD202.Size = new System.Drawing.Size(45, 21);
            this.nUD202.TabIndex = 3;
            this.nUD202.Tag = "202";
            this.nUD202.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "经济日报：";
            // 
            // nUD203
            // 
            this.nUD203.Location = new System.Drawing.Point(269, 79);
            this.nUD203.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD203.Name = "nUD203";
            this.nUD203.Size = new System.Drawing.Size(45, 21);
            this.nUD203.TabIndex = 3;
            this.nUD203.Tag = "203";
            this.nUD203.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "新华每日电讯：";
            // 
            // nUD301
            // 
            this.nUD301.Location = new System.Drawing.Point(269, 107);
            this.nUD301.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD301.Name = "nUD301";
            this.nUD301.Size = new System.Drawing.Size(45, 21);
            this.nUD301.TabIndex = 3;
            this.nUD301.Tag = "301";
            this.nUD301.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "光明日报：";
            // 
            // nUD302
            // 
            this.nUD302.Location = new System.Drawing.Point(269, 135);
            this.nUD302.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD302.Name = "nUD302";
            this.nUD302.Size = new System.Drawing.Size(45, 21);
            this.nUD302.TabIndex = 3;
            this.nUD302.Tag = "302";
            this.nUD302.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "河北日报：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "求是：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "河北经济日报：";
            // 
            // nUD105
            // 
            this.nUD105.Location = new System.Drawing.Point(101, 135);
            this.nUD105.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD105.Name = "nUD105";
            this.nUD105.Size = new System.Drawing.Size(45, 21);
            this.nUD105.TabIndex = 3;
            this.nUD105.Tag = "105";
            this.nUD105.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "燕赵都市报：";
            // 
            // nUD104
            // 
            this.nUD104.Location = new System.Drawing.Point(101, 107);
            this.nUD104.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD104.Name = "nUD104";
            this.nUD104.Size = new System.Drawing.Size(45, 21);
            this.nUD104.TabIndex = 3;
            this.nUD104.Tag = "104";
            this.nUD104.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "唐山劳动日报：";
            // 
            // nUD103
            // 
            this.nUD103.Location = new System.Drawing.Point(101, 79);
            this.nUD103.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD103.Name = "nUD103";
            this.nUD103.Size = new System.Drawing.Size(45, 21);
            this.nUD103.TabIndex = 3;
            this.nUD103.Tag = "103";
            this.nUD103.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "唐山晚报：";
            // 
            // nUD102
            // 
            this.nUD102.Location = new System.Drawing.Point(101, 51);
            this.nUD102.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD102.Name = "nUD102";
            this.nUD102.Size = new System.Drawing.Size(45, 21);
            this.nUD102.TabIndex = 3;
            this.nUD102.Tag = "102";
            this.nUD102.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // nUD101
            // 
            this.nUD101.Location = new System.Drawing.Point(101, 23);
            this.nUD101.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD101.Name = "nUD101";
            this.nUD101.Size = new System.Drawing.Size(45, 21);
            this.nUD101.TabIndex = 3;
            this.nUD101.Tag = "101";
            this.nUD101.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "人民日报：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb302);
            this.groupBox1.Controls.Add(this.chb105);
            this.groupBox1.Controls.Add(this.chb104);
            this.groupBox1.Controls.Add(this.chb103);
            this.groupBox1.Controls.Add(this.chb301);
            this.groupBox1.Controls.Add(this.chb203);
            this.groupBox1.Controls.Add(this.chb202);
            this.groupBox1.Controls.Add(this.chb201);
            this.groupBox1.Controls.Add(this.chb102);
            this.groupBox1.Controls.Add(this.chb101);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUD101);
            this.groupBox1.Controls.Add(this.nUD102);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nUD103);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nUD104);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nUD105);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nUD302);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUD301);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nUD203);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nUD202);
            this.groupBox1.Controls.Add(this.nUD201);
            this.groupBox1.Location = new System.Drawing.Point(5, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 169);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "重点党刊";
            // 
            // chb302
            // 
            this.chb302.AutoSize = true;
            this.chb302.Checked = true;
            this.chb302.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb302.Location = new System.Drawing.Point(320, 137);
            this.chb302.Name = "chb302";
            this.chb302.Size = new System.Drawing.Size(15, 14);
            this.chb302.TabIndex = 5;
            this.chb302.UseVisualStyleBackColor = true;
            // 
            // chb105
            // 
            this.chb105.AutoSize = true;
            this.chb105.Checked = true;
            this.chb105.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb105.Location = new System.Drawing.Point(152, 137);
            this.chb105.Name = "chb105";
            this.chb105.Size = new System.Drawing.Size(15, 14);
            this.chb105.TabIndex = 5;
            this.chb105.UseVisualStyleBackColor = true;
            // 
            // chb104
            // 
            this.chb104.AutoSize = true;
            this.chb104.Checked = true;
            this.chb104.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb104.Location = new System.Drawing.Point(152, 109);
            this.chb104.Name = "chb104";
            this.chb104.Size = new System.Drawing.Size(15, 14);
            this.chb104.TabIndex = 5;
            this.chb104.UseVisualStyleBackColor = true;
            // 
            // chb103
            // 
            this.chb103.AutoSize = true;
            this.chb103.Checked = true;
            this.chb103.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb103.Location = new System.Drawing.Point(152, 81);
            this.chb103.Name = "chb103";
            this.chb103.Size = new System.Drawing.Size(15, 14);
            this.chb103.TabIndex = 5;
            this.chb103.UseVisualStyleBackColor = true;
            // 
            // chb301
            // 
            this.chb301.AutoSize = true;
            this.chb301.Checked = true;
            this.chb301.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb301.Location = new System.Drawing.Point(320, 109);
            this.chb301.Name = "chb301";
            this.chb301.Size = new System.Drawing.Size(15, 14);
            this.chb301.TabIndex = 5;
            this.chb301.UseVisualStyleBackColor = true;
            // 
            // chb203
            // 
            this.chb203.AutoSize = true;
            this.chb203.Checked = true;
            this.chb203.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb203.Location = new System.Drawing.Point(320, 81);
            this.chb203.Name = "chb203";
            this.chb203.Size = new System.Drawing.Size(15, 14);
            this.chb203.TabIndex = 5;
            this.chb203.UseVisualStyleBackColor = true;
            // 
            // chb202
            // 
            this.chb202.AutoSize = true;
            this.chb202.Checked = true;
            this.chb202.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb202.Location = new System.Drawing.Point(320, 53);
            this.chb202.Name = "chb202";
            this.chb202.Size = new System.Drawing.Size(15, 14);
            this.chb202.TabIndex = 5;
            this.chb202.UseVisualStyleBackColor = true;
            // 
            // chb201
            // 
            this.chb201.AutoSize = true;
            this.chb201.Checked = true;
            this.chb201.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb201.Location = new System.Drawing.Point(320, 25);
            this.chb201.Name = "chb201";
            this.chb201.Size = new System.Drawing.Size(15, 14);
            this.chb201.TabIndex = 5;
            this.chb201.UseVisualStyleBackColor = true;
            // 
            // chb102
            // 
            this.chb102.AutoSize = true;
            this.chb102.Checked = true;
            this.chb102.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb102.Location = new System.Drawing.Point(152, 53);
            this.chb102.Name = "chb102";
            this.chb102.Size = new System.Drawing.Size(15, 14);
            this.chb102.TabIndex = 5;
            this.chb102.UseVisualStyleBackColor = true;
            // 
            // chb101
            // 
            this.chb101.AutoSize = true;
            this.chb101.Checked = true;
            this.chb101.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb101.Location = new System.Drawing.Point(152, 25);
            this.chb101.Name = "chb101";
            this.chb101.Size = new System.Drawing.Size(15, 14);
            this.chb101.TabIndex = 5;
            this.chb101.UseVisualStyleBackColor = true;
            // 
            // butFenPei
            // 
            this.butFenPei.Location = new System.Drawing.Point(301, 215);
            this.butFenPei.Name = "butFenPei";
            this.butFenPei.Size = new System.Drawing.Size(51, 23);
            this.butFenPei.TabIndex = 14;
            this.butFenPei.Text = "计算";
            this.butFenPei.UseVisualStyleBackColor = true;
            this.butFenPei.Click += new System.EventHandler(this.butFenPei_Click);
            // 
            // ToolsPaperNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(356, 246);
            this.Controls.Add(this.butFenPei);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.combYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolsPaperNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报刊自动分配";
            this.Load += new System.EventHandler(this.ToolsPaperNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD201)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD202)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD203)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD301)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD302)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD101)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.NumericUpDown nUD201;
        private System.Windows.Forms.NumericUpDown nUD202;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD203;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUD301;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUD302;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUD105;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUD104;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nUD103;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nUD102;
        private System.Windows.Forms.NumericUpDown nUD101;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb302;
        private System.Windows.Forms.CheckBox chb105;
        private System.Windows.Forms.CheckBox chb104;
        private System.Windows.Forms.CheckBox chb103;
        private System.Windows.Forms.CheckBox chb301;
        private System.Windows.Forms.CheckBox chb203;
        private System.Windows.Forms.CheckBox chb202;
        private System.Windows.Forms.CheckBox chb201;
        private System.Windows.Forms.CheckBox chb102;
        private System.Windows.Forms.CheckBox chb101;
        private System.Windows.Forms.Button butFenPei;
    }
}