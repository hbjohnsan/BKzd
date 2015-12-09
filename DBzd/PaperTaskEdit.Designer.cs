namespace DBzd
{
    partial class PaperTaskEdit
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
            this.btnEditTask = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(77, 145);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 20;
            this.btnEditTask.Text = "修改任务";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 53);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(100, 21);
            this.txtYear.TabIndex = 18;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(105, 96);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 17;
            this.txtNum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "年度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "份数：";
            // 
            // PaperTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 184);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaperTaskEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改上级报刊任务";
            this.Load += new System.EventHandler(this.PaperTaskEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}