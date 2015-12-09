namespace DBzd
{
    partial class PaperInsert
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAllname = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSubsidy = new System.Windows.Forms.TextBox();
            this.combPaper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rabYes = new System.Windows.Forms.RadioButton();
            this.rabNo = new System.Windows.Forms.RadioButton();
            this.txtPaperCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "报刊级别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "报刊名称：";
            // 
            // txtAllname
            // 
            this.txtAllname.Location = new System.Drawing.Point(94, 98);
            this.txtAllname.Name = "txtAllname";
            this.txtAllname.Size = new System.Drawing.Size(121, 21);
            this.txtAllname.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(81, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "单  价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "补  贴：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 21);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "0";
            // 
            // txtSubsidy
            // 
            this.txtSubsidy.Location = new System.Drawing.Point(94, 212);
            this.txtSubsidy.Name = "txtSubsidy";
            this.txtSubsidy.Size = new System.Drawing.Size(121, 21);
            this.txtSubsidy.TabIndex = 4;
            this.txtSubsidy.Text = "0";
            // 
            // combPaper
            // 
            this.combPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPaper.FormattingEnabled = true;
            this.combPaper.Items.AddRange(new object[] {
            "中央",
            "省级",
            "市级"});
            this.combPaper.Location = new System.Drawing.Point(94, 23);
            this.combPaper.Name = "combPaper";
            this.combPaper.Size = new System.Drawing.Size(121, 20);
            this.combPaper.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "是否是党刊：";
            // 
            // rabYes
            // 
            this.rabYes.AutoSize = true;
            this.rabYes.Location = new System.Drawing.Point(94, 252);
            this.rabYes.Name = "rabYes";
            this.rabYes.Size = new System.Drawing.Size(35, 16);
            this.rabYes.TabIndex = 7;
            this.rabYes.TabStop = true;
            this.rabYes.Text = "是";
            this.rabYes.UseVisualStyleBackColor = true;
            // 
            // rabNo
            // 
            this.rabNo.AutoSize = true;
            this.rabNo.Location = new System.Drawing.Point(146, 252);
            this.rabNo.Name = "rabNo";
            this.rabNo.Size = new System.Drawing.Size(35, 16);
            this.rabNo.TabIndex = 7;
            this.rabNo.TabStop = true;
            this.rabNo.Text = "否";
            this.rabNo.UseVisualStyleBackColor = true;
            // 
            // txtPaperCode
            // 
            this.txtPaperCode.Location = new System.Drawing.Point(94, 60);
            this.txtPaperCode.Name = "txtPaperCode";
            this.txtPaperCode.Size = new System.Drawing.Size(121, 21);
            this.txtPaperCode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "邮发代号：";
            // 
            // txtNumb
            // 
            this.txtNumb.Location = new System.Drawing.Point(94, 136);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(121, 21);
            this.txtNumb.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "数  量：";
            // 
            // PaperInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 318);
            this.Controls.Add(this.txtNumb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPaperCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rabNo);
            this.Controls.Add(this.rabYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSubsidy);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAllname);
            this.Controls.Add(this.combPaper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaperInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "增加报刊";
            this.Load += new System.EventHandler(this.PaperInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAllname;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSubsidy;
        private System.Windows.Forms.ComboBox combPaper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rabYes;
        private System.Windows.Forms.RadioButton rabNo;
        private System.Windows.Forms.TextBox txtPaperCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.Label label8;
    }
}