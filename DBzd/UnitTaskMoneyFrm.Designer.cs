namespace DBzd
{
    partial class UnitTaskMoneyFrm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSub = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscombYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewUnitPlantMoney = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewNotMoney = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labXianXM = new System.Windows.Forms.Label();
            this.labTownM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolStripLabel1,
            this.tscombYear,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.tsTxtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
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
            this.tsbtnAdd.Text = "增加";
            // 
            // tsbtnSub
            // 
            this.tsbtnSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSub.Image = global::DBzd.Properties.Resources.Action_remove_icon;
            this.tsbtnSub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSub.Name = "tsbtnSub";
            this.tsbtnSub.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSub.Text = "删除";
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEdit.Image = global::DBzd.Properties.Resources.edit_validated_icon;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnEdit.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "年度：";
            // 
            // tscombYear
            // 
            this.tscombYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscombYear.DropDownWidth = 80;
            this.tscombYear.Name = "tscombYear";
            this.tscombYear.Size = new System.Drawing.Size(121, 25);
            this.tscombYear.SelectedIndexChanged += new System.EventHandler(this.tscombYear_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "搜索：";
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(100, 25);
            this.tsTxtSearch.TextChanged += new System.EventHandler(this.tsTxtSearch_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listViewUnitPlantMoney, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 402);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listViewUnitPlantMoney
            // 
            this.listViewUnitPlantMoney.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewUnitPlantMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUnitPlantMoney.FullRowSelect = true;
            this.listViewUnitPlantMoney.GridLines = true;
            this.listViewUnitPlantMoney.Location = new System.Drawing.Point(3, 3);
            this.listViewUnitPlantMoney.MultiSelect = false;
            this.listViewUnitPlantMoney.Name = "listViewUnitPlantMoney";
            this.listViewUnitPlantMoney.Size = new System.Drawing.Size(324, 396);
            this.listViewUnitPlantMoney.TabIndex = 3;
            this.listViewUnitPlantMoney.UseCompatibleStateImageBehavior = false;
            this.listViewUnitPlantMoney.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "单位";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "计划金额";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "企业金额";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "总金额";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTemp);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(333, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 396);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewNotMoney);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "有任务未分配";
            // 
            // listViewNotMoney
            // 
            this.listViewNotMoney.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listViewNotMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNotMoney.FullRowSelect = true;
            this.listViewNotMoney.GridLines = true;
            this.listViewNotMoney.Location = new System.Drawing.Point(3, 17);
            this.listViewNotMoney.MultiSelect = false;
            this.listViewNotMoney.Name = "listViewNotMoney";
            this.listViewNotMoney.Size = new System.Drawing.Size(239, 182);
            this.listViewNotMoney.TabIndex = 0;
            this.listViewNotMoney.UseCompatibleStateImageBehavior = false;
            this.listViewNotMoney.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "单位";
            this.columnHeader6.Width = 158;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labXianXM);
            this.groupBox1.Controls.Add(this.labTownM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计";
            // 
            // labXianXM
            // 
            this.labXianXM.AutoSize = true;
            this.labXianXM.Location = new System.Drawing.Point(105, 66);
            this.labXianXM.Name = "labXianXM";
            this.labXianXM.Size = new System.Drawing.Size(41, 12);
            this.labXianXM.TabIndex = 2;
            this.labXianXM.Text = "label3";
            // 
            // labTownM
            // 
            this.labTownM.AutoSize = true;
            this.labTownM.Location = new System.Drawing.Point(103, 31);
            this.labTownM.Name = "labTownM";
            this.labTownM.Size = new System.Drawing.Size(41, 12);
            this.labTownM.TabIndex = 1;
            this.labTownM.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "县直任务总额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "乡镇任务总额：";
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(330, 79);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(75, 23);
            this.btnTemp.TabIndex = 2;
            this.btnTemp.Text = "临时计算";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // UnitTaskMoneyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UnitTaskMoneyFrm";
            this.Text = "金额分配";
            this.Load += new System.EventHandler(this.UnitTaskMoneyFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnSub;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewUnitPlantMoney;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labXianXM;
        private System.Windows.Forms.Label labTownM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewNotMoney;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscombYear;
        private System.Windows.Forms.ToolStripSeparator toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.Button btnTemp;

    }
}