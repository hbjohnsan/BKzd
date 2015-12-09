namespace DBzd
{
    partial class UnitPostInsert
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
            this.txtPostID = new System.Windows.Forms.TextBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtPostID
            // 
            this.txtPostID.Location = new System.Drawing.Point(69, 57);
            this.txtPostID.Name = "txtPostID";
            this.txtPostID.Size = new System.Drawing.Size(143, 21);
            this.txtPostID.TabIndex = 12;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(273, 22);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.ReadOnly = true;
            this.txtUnitName.Size = new System.Drawing.Size(143, 21);
            this.txtUnitName.TabIndex = 10;
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(69, 22);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(143, 21);
            this.txtUnitID.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "单  位：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "单位ID：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "职  务：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "职务ID：";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(69, 92);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(142, 21);
            this.txtPost.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "电  话：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(273, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(143, 21);
            this.txtTel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "年  度：";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(273, 58);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(143, 21);
            this.txtYear.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 367);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 188);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // UnitPostInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 401);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPostID);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitPostInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "增加单位职务";
            this.Load += new System.EventHandler(this.UnitPostInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPostID;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView listView1;
    }
}