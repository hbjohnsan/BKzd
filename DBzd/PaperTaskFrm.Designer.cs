namespace DBzd
{
    partial class PaperTaskFrm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSub = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSjTmoney = new System.Windows.Forms.Label();
            this.labSubTmoney = new System.Windows.Forms.Label();
            this.labPlanTmoney = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.labcz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPaperTask = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnSub,
            this.tsbtnEdit,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = global::DBzd.Properties.Resources.add_2_icon;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdd.Text = "增加任务";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnSub
            // 
            this.tsbtnSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSub.Image = global::DBzd.Properties.Resources.Action_remove_icon;
            this.tsbtnSub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSub.Name = "tsbtnSub";
            this.tsbtnSub.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSub.Text = "删除任务";
            this.tsbtnSub.Click += new System.EventHandler(this.tsbtnSub_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEdit.Image = global::DBzd.Properties.Resources.edit_validated_icon;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnEdit.Text = "编辑任务";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "年度：";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
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
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSjTmoney);
            this.groupBox1.Controls.Add(this.labSubTmoney);
            this.groupBox1.Controls.Add(this.labPlanTmoney);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.labcz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计";
            // 
            // labSjTmoney
            // 
            this.labSjTmoney.AutoSize = true;
            this.labSjTmoney.Location = new System.Drawing.Point(569, 17);
            this.labSjTmoney.Name = "labSjTmoney";
            this.labSjTmoney.Size = new System.Drawing.Size(11, 12);
            this.labSjTmoney.TabIndex = 4;
            this.labSjTmoney.Text = "0";
            // 
            // labSubTmoney
            // 
            this.labSubTmoney.AutoSize = true;
            this.labSubTmoney.Location = new System.Drawing.Point(347, 17);
            this.labSubTmoney.Name = "labSubTmoney";
            this.labSubTmoney.Size = new System.Drawing.Size(11, 12);
            this.labSubTmoney.TabIndex = 3;
            this.labSubTmoney.Text = "0";
            // 
            // labPlanTmoney
            // 
            this.labPlanTmoney.AutoSize = true;
            this.labPlanTmoney.Location = new System.Drawing.Point(117, 17);
            this.labPlanTmoney.Name = "labPlanTmoney";
            this.labPlanTmoney.Size = new System.Drawing.Size(11, 12);
            this.labPlanTmoney.TabIndex = 2;
            this.labPlanTmoney.Text = "0";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(474, 17);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(89, 12);
            this.lab.TabIndex = 1;
            this.lab.Text = "应收征收总额：";
            // 
            // labcz
            // 
            this.labcz.AutoSize = true;
            this.labcz.Location = new System.Drawing.Point(252, 17);
            this.labcz.Name = "labcz";
            this.labcz.Size = new System.Drawing.Size(89, 12);
            this.labcz.TabIndex = 0;
            this.labcz.Text = "财政补贴总额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上级任务总额：";
            // 
            // listViewPaperTask
            // 
            this.listViewPaperTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewPaperTask.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewPaperTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPaperTask.FullRowSelect = true;
            this.listViewPaperTask.GridLines = true;
            this.listViewPaperTask.Location = new System.Drawing.Point(0, 65);
            this.listViewPaperTask.MultiSelect = false;
            this.listViewPaperTask.Name = "listViewPaperTask";
            this.listViewPaperTask.Size = new System.Drawing.Size(714, 388);
            this.listViewPaperTask.TabIndex = 2;
            this.listViewPaperTask.UseCompatibleStateImageBehavior = false;
            this.listViewPaperTask.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "报纸";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "份数";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单价";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "任务金额";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "补贴";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "补贴金额";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "年度";
            // 
            // PaperTaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 453);
            this.Controls.Add(this.listViewPaperTask);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "PaperTaskFrm";
            this.Text = "上级任务";
            this.Load += new System.EventHandler(this.HigherTaskFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPaperTask;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labSjTmoney;
        private System.Windows.Forms.Label labSubTmoney;
        private System.Windows.Forms.Label labPlanTmoney;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label labcz;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnSub;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}