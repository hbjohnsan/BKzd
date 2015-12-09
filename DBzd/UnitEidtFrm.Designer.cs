namespace DBzd
{
    partial class UnitEidtFrm
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
            this.combcode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rabYes = new System.Windows.Forms.RadioButton();
            this.rabNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rabtnPayYes = new System.Windows.Forms.RadioButton();
            this.rabtnPayNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.combArea = new System.Windows.Forms.ComboBox();
            this.combTwon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combkind
            // 
            this.combkind.FormattingEnabled = true;
            this.combkind.Location = new System.Drawing.Point(85, 118);
            this.combkind.Name = "combkind";
            this.combkind.Size = new System.Drawing.Size(159, 20);
            this.combkind.TabIndex = 19;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(85, 181);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(159, 21);
            this.txtFax.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(85, 149);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(159, 21);
            this.txtTel.TabIndex = 14;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtshorname
            // 
            this.txtshorname.Location = new System.Drawing.Point(85, 86);
            this.txtshorname.Name = "txtshorname";
            this.txtshorname.Size = new System.Drawing.Size(159, 21);
            this.txtshorname.TabIndex = 16;
            // 
            // txtallname
            // 
            this.txtallname.Location = new System.Drawing.Point(85, 54);
            this.txtallname.Name = "txtallname";
            this.txtallname.Size = new System.Drawing.Size(159, 21);
            this.txtallname.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "传真：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "类别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "简称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "全称：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(190, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // combcode
            // 
            this.combcode.FormattingEnabled = true;
            this.combcode.Location = new System.Drawing.Point(85, 23);
            this.combcode.Name = "combcode";
            this.combcode.Size = new System.Drawing.Size(159, 20);
            this.combcode.TabIndex = 20;
            this.combcode.SelectedIndexChanged += new System.EventHandler(this.combcode_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rabYes
            // 
            this.rabYes.AutoSize = true;
            this.rabYes.Location = new System.Drawing.Point(51, 20);
            this.rabYes.Name = "rabYes";
            this.rabYes.Size = new System.Drawing.Size(35, 16);
            this.rabYes.TabIndex = 23;
            this.rabYes.TabStop = true;
            this.rabYes.Text = "是";
            this.rabYes.UseVisualStyleBackColor = true;
            // 
            // rabNo
            // 
            this.rabNo.AutoSize = true;
            this.rabNo.Location = new System.Drawing.Point(156, 20);
            this.rabNo.Name = "rabNo";
            this.rabNo.Size = new System.Drawing.Size(35, 16);
            this.rabNo.TabIndex = 23;
            this.rabNo.TabStop = true;
            this.rabNo.Text = "否";
            this.rabNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabYes);
            this.groupBox1.Controls.Add(this.rabNo);
            this.groupBox1.Location = new System.Drawing.Point(34, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 45);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "是否有报刊订阅任务";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rabtnPayNo);
            this.groupBox2.Controls.Add(this.rabtnPayYes);
            this.groupBox2.Location = new System.Drawing.Point(34, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 45);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "是否是交款单位";
            // 
            // rabtnPayYes
            // 
            this.rabtnPayYes.AutoSize = true;
            this.rabtnPayYes.Location = new System.Drawing.Point(51, 20);
            this.rabtnPayYes.Name = "rabtnPayYes";
            this.rabtnPayYes.Size = new System.Drawing.Size(35, 16);
            this.rabtnPayYes.TabIndex = 0;
            this.rabtnPayYes.TabStop = true;
            this.rabtnPayYes.Text = "是";
            this.rabtnPayYes.UseVisualStyleBackColor = true;
            // 
            // rabtnPayNo
            // 
            this.rabtnPayNo.AutoSize = true;
            this.rabtnPayNo.Location = new System.Drawing.Point(156, 19);
            this.rabtnPayNo.Name = "rabtnPayNo";
            this.rabtnPayNo.Size = new System.Drawing.Size(35, 16);
            this.rabtnPayNo.TabIndex = 1;
            this.rabtnPayNo.TabStop = true;
            this.rabtnPayNo.Text = "否";
            this.rabtnPayNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "地址区域：";
            // 
            // combArea
            // 
            this.combArea.FormattingEnabled = true;
            this.combArea.Location = new System.Drawing.Point(72, 364);
            this.combArea.Name = "combArea";
            this.combArea.Size = new System.Drawing.Size(172, 20);
            this.combArea.TabIndex = 28;
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
            this.combTwon.Location = new System.Drawing.Point(103, 338);
            this.combTwon.Name = "combTwon";
            this.combTwon.Size = new System.Drawing.Size(141, 20);
            this.combTwon.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "详细";
            // 
            // UnitEidtFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combArea);
            this.Controls.Add(this.combTwon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.combcode);
            this.Controls.Add(this.combkind);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtshorname);
            this.Controls.Add(this.txtallname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitEidtFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改单位信息";
            this.Load += new System.EventHandler(this.UnitEidtFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ComboBox combcode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rabYes;
        private System.Windows.Forms.RadioButton rabNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rabtnPayNo;
        private System.Windows.Forms.RadioButton rabtnPayYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combArea;
        private System.Windows.Forms.ComboBox combTwon;
        private System.Windows.Forms.Label label8;
    }
}