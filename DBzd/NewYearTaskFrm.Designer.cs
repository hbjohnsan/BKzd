namespace DBzd
{
    partial class NewYearTaskFrm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSharePaper = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxNewYear = new System.Windows.Forms.ComboBox();
            this.cboxOldYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.增加ToolStripMenuItem.Text = "增加";
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // btnSharePaper
            // 
            this.btnSharePaper.Location = new System.Drawing.Point(35, 192);
            this.btnSharePaper.Name = "btnSharePaper";
            this.btnSharePaper.Size = new System.Drawing.Size(148, 23);
            this.btnSharePaper.TabIndex = 7;
            this.btnSharePaper.Text = "2、报刊分配任务(县直)";
            this.btnSharePaper.UseVisualStyleBackColor = true;
           
            this.btnSharePaper.MouseEnter += new System.EventHandler(this.btnSharePaper_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cboxNewYear);
            this.groupBox1.Controls.Add(this.btnSharePaper);
            this.groupBox1.Controls.Add(this.cboxOldYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddPaper);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上级年度任务";
            // 
            // cboxNewYear
            // 
            this.cboxNewYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNewYear.FormattingEnabled = true;
            this.cboxNewYear.Location = new System.Drawing.Point(89, 60);
            this.cboxNewYear.Name = "cboxNewYear";
            this.cboxNewYear.Size = new System.Drawing.Size(93, 20);
            this.cboxNewYear.TabIndex = 8;
            // 
            // cboxOldYear
            // 
            this.cboxOldYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOldYear.FormattingEnabled = true;
            this.cboxOldYear.Location = new System.Drawing.Point(89, 30);
            this.cboxOldYear.Name = "cboxOldYear";
            this.cboxOldYear.Size = new System.Drawing.Size(93, 20);
            this.cboxOldYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "复制年度：";
            // 
            // btnAddPaper
            // 
            this.btnAddPaper.Location = new System.Drawing.Point(35, 98);
            this.btnAddPaper.Name = "btnAddPaper";
            this.btnAddPaper.Size = new System.Drawing.Size(148, 23);
            this.btnAddPaper.TabIndex = 4;
            this.btnAddPaper.Text = "1、增加年度报刊及任务";
            this.btnAddPaper.UseVisualStyleBackColor = true;
           
            this.btnAddPaper.MouseEnter += new System.EventHandler(this.btnAddPaper_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增年度：";
            // 
            // NewYearTaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 299);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "NewYearTaskFrm";
            this.Text = "新增年度任务";
            this.Load += new System.EventHandler(this.NewYearTaskFrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxNewYear;
        private System.Windows.Forms.ComboBox cboxOldYear;
        private System.Windows.Forms.Button btnSharePaper;
    }
}