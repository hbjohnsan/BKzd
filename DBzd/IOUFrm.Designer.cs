namespace DBzd
{
    partial class IOUFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOUFrm));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrintSetup = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrintView = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRight = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.combJKDW = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTruePrice = new System.Windows.Forms.TextBox();
            this.rtbDoc = new ExtendedRichTextBox.RichTextBoxPrintCtrl();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "年度";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "单位";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox3_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "搜索";
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(100, 25);
            this.tsTxtSearch.TextChanged += new System.EventHandler(this.tsTxtSearch_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdit,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripComboBox3,
            this.toolStripLabel4,
            this.tsTxtSearch,
            this.toolStripSeparator2,
            this.tsbtnPrintSetup,
            this.tsbtnPrintView,
            this.tsbtnPrint,
            this.toolStripSeparator3,
            this.tsbtnFont,
            this.tsbtnBold,
            this.tsbtnUnderline,
            this.toolStripSeparator4,
            this.tsbtnLeft,
            this.tsbtnCenter,
            this.tsbtnRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::DBzd.Properties.Resources.edit_validated_icon;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "编辑";
            // 
            // tsbtnPrintSetup
            // 
            this.tsbtnPrintSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrintSetup.Image = global::DBzd.Properties.Resources.Actions_document_print_direct_icon;
            this.tsbtnPrintSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrintSetup.Name = "tsbtnPrintSetup";
            this.tsbtnPrintSetup.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrintSetup.Text = "打印设置";
            this.tsbtnPrintSetup.Click += new System.EventHandler(this.tsbtnPrintSetup_Click);
            // 
            // tsbtnPrintView
            // 
            this.tsbtnPrintView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrintView.Image = global::DBzd.Properties.Resources.Actions_document_print_preview_icon;
            this.tsbtnPrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrintView.Name = "tsbtnPrintView";
            this.tsbtnPrintView.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrintView.Text = "打印预览";
            this.tsbtnPrintView.Click += new System.EventHandler(this.tsbtnPrintView_Click);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrint.Image = global::DBzd.Properties.Resources.printer_icon;
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrint.Text = "打印";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // tsbtnFont
            // 
            this.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFont.Image = global::DBzd.Properties.Resources.Font_icon;
            this.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFont.Name = "tsbtnFont";
            this.tsbtnFont.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFont.Text = "字体";
            this.tsbtnFont.Click += new System.EventHandler(this.tsbtnFont_Click);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBold.Image = global::DBzd.Properties.Resources.text_bold_icon;
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBold.Text = "加粗";
            this.tsbtnBold.Click += new System.EventHandler(this.tsbtnBold_Click);
            // 
            // tsbtnUnderline
            // 
            this.tsbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUnderline.Image = global::DBzd.Properties.Resources.text_underline_icon;
            this.tsbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnderline.Name = "tsbtnUnderline";
            this.tsbtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUnderline.Text = "下划线";
            this.tsbtnUnderline.Click += new System.EventHandler(this.tsbtnUnderline_Click);
            // 
            // tsbtnLeft
            // 
            this.tsbtnLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLeft.Image = global::DBzd.Properties.Resources.text_align_left_icon;
            this.tsbtnLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLeft.Name = "tsbtnLeft";
            this.tsbtnLeft.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLeft.Text = "左对齐";
            this.tsbtnLeft.Click += new System.EventHandler(this.tsbtnLeft_Click);
            // 
            // tsbtnCenter
            // 
            this.tsbtnCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCenter.Image = global::DBzd.Properties.Resources.text_align_center_icon;
            this.tsbtnCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCenter.Name = "tsbtnCenter";
            this.tsbtnCenter.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCenter.Text = "居中";
            this.tsbtnCenter.Click += new System.EventHandler(this.tsbtnCenter_Click);
            // 
            // tsbtnRight
            // 
            this.tsbtnRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRight.Image = global::DBzd.Properties.Resources.text_align_right_icon;
            this.tsbtnRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRight.Name = "tsbtnRight";
            this.tsbtnRight.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRight.Text = "右对齐";
            this.tsbtnRight.Click += new System.EventHandler(this.tsbtnRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单位：";
            // 
            // combJKDW
            // 
            this.combJKDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combJKDW.FormattingEnabled = true;
            this.combJKDW.Location = new System.Drawing.Point(64, 20);
            this.combJKDW.Name = "combJKDW";
            this.combJKDW.Size = new System.Drawing.Size(121, 20);
            this.combJKDW.TabIndex = 1;
            this.combJKDW.SelectedIndexChanged += new System.EventHandler(this.combJKDW_SelectedIndexChanged);
            this.combJKDW.SelectedValueChanged += new System.EventHandler(this.combJKDW_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "金额：";
            // 
            // txtTruePrice
            // 
            this.txtTruePrice.Location = new System.Drawing.Point(274, 20);
            this.txtTruePrice.Name = "txtTruePrice";
            this.txtTruePrice.Size = new System.Drawing.Size(123, 21);
            this.txtTruePrice.TabIndex = 5;
            this.txtTruePrice.Text = "0";
            this.txtTruePrice.TextChanged += new System.EventHandler(this.txtTruePrice_TextChanged);
            // 
            // rtbDoc
            // 
            this.rtbDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDoc.Location = new System.Drawing.Point(0, 0);
            this.rtbDoc.Name = "rtbDoc";
            this.rtbDoc.Size = new System.Drawing.Size(778, 570);
            this.rtbDoc.TabIndex = 0;
            this.rtbDoc.Text = "";
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument1;
            this.printDialog2.UseEXDialog = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combJKDW);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTruePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 570);
            this.panel1.TabIndex = 7;
            // 
            // IOUFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "IOUFrm";
            this.Text = "欠条";
            this.Load += new System.EventHandler(this.IOUFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnPrintSetup;
        private System.Windows.Forms.ToolStripButton tsbtnPrintView;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnFont;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripButton tsbtnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnLeft;
        private System.Windows.Forms.ToolStripButton tsbtnCenter;
        private System.Windows.Forms.ToolStripButton tsbtnRight;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combJKDW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTruePrice;
        private System.Windows.Forms.PrintDialog printDialog2;
        private ExtendedRichTextBox.RichTextBoxPrintCtrl rtbDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}