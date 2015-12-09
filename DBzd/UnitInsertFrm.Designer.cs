namespace DBzd
{
    partial class UnitInsertFrm
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
            this.rabNo = new System.Windows.Forms.RadioButton();
            this.rabYes = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.combcode = new System.Windows.Forms.ComboBox();
            this.combkind = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtshorname = new System.Windows.Forms.TextBox();
            this.txtallname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combFatherCode = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rabPayNo = new System.Windows.Forms.RadioButton();
            this.rabPayYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.combArea = new System.Windows.Forms.ComboBox();
            this.combTwon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rabNo
            // 
            this.rabNo.AutoSize = true;
            this.rabNo.Checked = true;
            this.rabNo.Location = new System.Drawing.Point(150, 24);
            this.rabNo.Name = "rabNo";
            this.rabNo.Size = new System.Drawing.Size(35, 16);
            this.rabNo.TabIndex = 39;
            this.rabNo.TabStop = true;
            this.rabNo.Text = "否";
            this.rabNo.UseVisualStyleBackColor = true;
            // 
            // rabYes
            // 
            this.rabYes.AutoSize = true;
            this.rabYes.Location = new System.Drawing.Point(41, 24);
            this.rabYes.Name = "rabYes";
            this.rabYes.Size = new System.Drawing.Size(35, 16);
            this.rabYes.TabIndex = 40;
            this.rabYes.Text = "是";
            this.rabYes.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "新增";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // combcode
            // 
            this.combcode.FormattingEnabled = true;
            this.combcode.Location = new System.Drawing.Point(80, 20);
            this.combcode.Name = "combcode";
            this.combcode.Size = new System.Drawing.Size(159, 20);
            this.combcode.TabIndex = 36;
            // 
            // combkind
            // 
            this.combkind.FormattingEnabled = true;
            this.combkind.Items.AddRange(new object[] {
            "局",
            "县直",
            "乡镇",
            "街道",
            "企业",
            "学校",
            "协会",
            "银行",
            "医院"});
            this.combkind.Location = new System.Drawing.Point(101, 20);
            this.combkind.Name = "combkind";
            this.combkind.Size = new System.Drawing.Size(138, 20);
            this.combkind.TabIndex = 35;
            this.combkind.SelectedIndexChanged += new System.EventHandler(this.combkind_SelectedIndexChanged);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(80, 150);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(159, 21);
            this.txtFax.TabIndex = 32;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(80, 118);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(159, 21);
            this.txtTel.TabIndex = 31;
            // 
            // txtshorname
            // 
            this.txtshorname.Location = new System.Drawing.Point(80, 83);
            this.txtshorname.Name = "txtshorname";
            this.txtshorname.Size = new System.Drawing.Size(159, 21);
            this.txtshorname.TabIndex = 33;
            // 
            // txtallname
            // 
            this.txtallname.Location = new System.Drawing.Point(80, 51);
            this.txtallname.Name = "txtallname";
            this.txtallname.Size = new System.Drawing.Size(159, 21);
            this.txtallname.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "传真：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "单位类别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "简称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "全称：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(210, 480);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabNo);
            this.groupBox1.Controls.Add(this.rabYes);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 58);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "是否有报刊订阅任务";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combcode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtallname);
            this.groupBox2.Controls.Add(this.txtshorname);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 182);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单位信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.combFatherCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.combkind);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 84);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单位级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "父级代码：";
            // 
            // combFatherCode
            // 
            this.combFatherCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFatherCode.FormattingEnabled = true;
            this.combFatherCode.Location = new System.Drawing.Point(101, 54);
            this.combFatherCode.Name = "combFatherCode";
            this.combFatherCode.Size = new System.Drawing.Size(138, 20);
            this.combFatherCode.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rabPayNo);
            this.groupBox4.Controls.Add(this.rabPayYes);
            this.groupBox4.Location = new System.Drawing.Point(12, 354);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 58);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "是否交款单位";
            // 
            // rabPayNo
            // 
            this.rabPayNo.AutoSize = true;
            this.rabPayNo.Checked = true;
            this.rabPayNo.Location = new System.Drawing.Point(150, 24);
            this.rabPayNo.Name = "rabPayNo";
            this.rabPayNo.Size = new System.Drawing.Size(35, 16);
            this.rabPayNo.TabIndex = 39;
            this.rabPayNo.TabStop = true;
            this.rabPayNo.Text = "否";
            this.rabPayNo.UseVisualStyleBackColor = true;
            // 
            // rabPayYes
            // 
            this.rabPayYes.AutoSize = true;
            this.rabPayYes.Location = new System.Drawing.Point(41, 24);
            this.rabPayYes.Name = "rabPayYes";
            this.rabPayYes.Size = new System.Drawing.Size(35, 16);
            this.rabPayYes.TabIndex = 40;
            this.rabPayYes.Text = "是";
            this.rabPayYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "详细";
            // 
            // combArea
            // 
            this.combArea.FormattingEnabled = true;
            this.combArea.Location = new System.Drawing.Point(79, 444);
            this.combArea.Name = "combArea";
            this.combArea.Size = new System.Drawing.Size(172, 20);
            this.combArea.TabIndex = 46;
            // 
            // combTwon
            // 
            this.combTwon.FormattingEnabled = true;
            this.combTwon.Items.AddRange(new object[] {
            "新城",
            "古城",
            "滦州镇",
            "棒子镇",
            "雷庄镇",
            "响堂镇",
            "东安个庄镇",
            "茨榆坨镇",
            "杨柳庄镇",
            "油棕镇",
            "九百户镇",
            "小马庄镇",
            "古马镇",
            "王店子镇"});
            this.combTwon.Location = new System.Drawing.Point(110, 418);
            this.combTwon.Name = "combTwon";
            this.combTwon.Size = new System.Drawing.Size(141, 20);
            this.combTwon.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "地址区域：";
            // 
            // UnitInsertFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combArea);
            this.Controls.Add(this.combTwon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitInsertFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增单位";
            this.Load += new System.EventHandler(this.UnitInsertFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rabNo;
        private System.Windows.Forms.RadioButton rabYes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox combcode;
        private System.Windows.Forms.ComboBox combkind;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtshorname;
        private System.Windows.Forms.TextBox txtallname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combFatherCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rabPayNo;
        private System.Windows.Forms.RadioButton rabPayYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combArea;
        private System.Windows.Forms.ComboBox combTwon;
        private System.Windows.Forms.Label label9;
    }
}