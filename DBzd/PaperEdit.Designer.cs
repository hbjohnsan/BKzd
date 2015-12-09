namespace DBzd
{
    partial class PaperEdit
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
            this.btnEditOK = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtSubsidy = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAllname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPaperCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rabNo = new System.Windows.Forms.RadioButton();
            this.rabYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditOK
            // 
            this.btnEditOK.Location = new System.Drawing.Point(83, 322);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(75, 23);
            this.btnEditOK.TabIndex = 16;
            this.btnEditOK.Text = "确定";
            this.btnEditOK.UseVisualStyleBackColor = true;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(96, 245);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(121, 21);
            this.txtYear.TabIndex = 13;
            // 
            // txtSubsidy
            // 
            this.txtSubsidy.Location = new System.Drawing.Point(96, 210);
            this.txtSubsidy.Name = "txtSubsidy";
            this.txtSubsidy.Size = new System.Drawing.Size(121, 21);
            this.txtSubsidy.TabIndex = 12;
            this.txtSubsidy.Text = "0";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(96, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 21);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.Text = "0";
            // 
            // txtAllname
            // 
            this.txtAllname.Location = new System.Drawing.Point(96, 105);
            this.txtAllname.Name = "txtAllname";
            this.txtAllname.Size = new System.Drawing.Size(121, 21);
            this.txtAllname.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "年  度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "补  贴：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "单  价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "名  称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "报刊级别：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(96, 35);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 21);
            this.txtCode.TabIndex = 17;
            // 
            // txtPaperCode
            // 
            this.txtPaperCode.Location = new System.Drawing.Point(96, 70);
            this.txtPaperCode.Name = "txtPaperCode";
            this.txtPaperCode.Size = new System.Drawing.Size(121, 21);
            this.txtPaperCode.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "邮发代号：";
            // 
            // rabNo
            // 
            this.rabNo.AutoSize = true;
            this.rabNo.Location = new System.Drawing.Point(161, 287);
            this.rabNo.Name = "rabNo";
            this.rabNo.Size = new System.Drawing.Size(35, 16);
            this.rabNo.TabIndex = 21;
            this.rabNo.TabStop = true;
            this.rabNo.Text = "否";
            this.rabNo.UseVisualStyleBackColor = true;
            // 
            // rabYes
            // 
            this.rabYes.AutoSize = true;
            this.rabYes.Location = new System.Drawing.Point(109, 287);
            this.rabYes.Name = "rabYes";
            this.rabYes.Size = new System.Drawing.Size(35, 16);
            this.rabYes.TabIndex = 22;
            this.rabYes.TabStop = true;
            this.rabYes.Text = "是";
            this.rabYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "是否是党刊：";
            // 
            // txtNumb
            // 
            this.txtNumb.Location = new System.Drawing.Point(96, 140);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(121, 21);
            this.txtNumb.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "数  量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(96, 13);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(47, 12);
            this.labID.TabIndex = 26;
            this.labID.Text = "label10";
            // 
            // PaperEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 354);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rabNo);
            this.Controls.Add(this.rabYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaperCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnEditOK);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSubsidy);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAllname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaperEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改报刊";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditOK;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtSubsidy;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAllname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPaperCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rabNo;
        private System.Windows.Forms.RadioButton rabYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labID;
    }
}