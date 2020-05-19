using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dashBoardTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabTimeline = new System.Windows.Forms.TabPage();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.PieChartWithCropsTab = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.read = new MaterialSkin.Controls.MaterialButton();
            this.search = new MaterialSkin.Controls.MaterialButton();
            this.valueTB = new MaterialSkin.Controls.MaterialTextBox();
            this.datasetID = new MaterialSkin.Controls.MaterialTextBox();
            this.repositoryURL = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialSwitch8 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch6 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.MaterialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch5 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch4 = new MaterialSkin.Controls.MaterialSwitch();
            this.TabAlgorithm = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.viewClusters = new System.Windows.Forms.Button();
            this.cropsItems = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KmeansChart = new LiveCharts.WinForms.CartesianChart();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dashBoardTabs.SuspendLayout();
            this.tabTimeline.SuspendLayout();
            this.PieChartWithCropsTab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.TabAlgorithm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.item1ToolStripMenuItem, this.disabledItemToolStripMenuItem, this.item2ToolStripMenuItem, this.toolStripSeparator1, this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.subItem1ToolStripMenuItem, this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.splitContainer1);
            this.tabPage6.ImageKey = "round_assessment_white_24dp.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1015, 520);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Dashboard";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.materialTabSelector1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dashBoardTabs);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 520);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 25;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.dashBoardTabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1015, 43);
            this.materialTabSelector1.TabIndex = 24;
            this.materialTabSelector1.Text = "Pie chart with crops";
            // 
            // dashBoardTabs
            // 
            this.dashBoardTabs.Controls.Add(this.tabTimeline);
            this.dashBoardTabs.Controls.Add(this.PieChartWithCropsTab);
            this.dashBoardTabs.Controls.Add(this.tabPage4);
            this.dashBoardTabs.Depth = 0;
            this.dashBoardTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardTabs.Location = new System.Drawing.Point(0, 0);
            this.dashBoardTabs.Margin = new System.Windows.Forms.Padding(0);
            this.dashBoardTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.dashBoardTabs.Name = "dashBoardTabs";
            this.dashBoardTabs.SelectedIndex = 0;
            this.dashBoardTabs.Size = new System.Drawing.Size(1015, 473);
            this.dashBoardTabs.TabIndex = 23;
            // 
            // tabTimeline
            // 
            this.tabTimeline.BackColor = System.Drawing.Color.White;
            this.tabTimeline.Controls.Add(this.materialLabel45);
            this.tabTimeline.Location = new System.Drawing.Point(4, 24);
            this.tabTimeline.Name = "tabTimeline";
            this.tabTimeline.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeline.Size = new System.Drawing.Size(1007, 445);
            this.tabTimeline.TabIndex = 0;
            this.tabTimeline.Text = "TimeLine";
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel45.HighEmphasis = true;
            this.materialLabel45.Location = new System.Drawing.Point(15, 14);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(174, 24);
            this.materialLabel45.TabIndex = 4;
            this.materialLabel45.Text = "Tabs are supported";
            // 
            // PieChartWithCropsTab
            // 
            this.PieChartWithCropsTab.BackColor = System.Drawing.Color.White;
            this.PieChartWithCropsTab.Controls.Add(this.materialLabel3);
            this.PieChartWithCropsTab.Location = new System.Drawing.Point(4, 24);
            this.PieChartWithCropsTab.Name = "PieChartWithCropsTab";
            this.PieChartWithCropsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PieChartWithCropsTab.Size = new System.Drawing.Size(1007, 445);
            this.PieChartWithCropsTab.TabIndex = 2;
            this.PieChartWithCropsTab.Text = "Pie chart with crops";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(6, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(475, 58);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Everything is possible!";
            this.materialLabel3.UseAccent = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1007, 445);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Circular graph";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(6, 7);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(475, 58);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Everything is possible!";
            this.materialLabel4.UseAccent = true;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.checkedListBox1);
            this.tabPage7.Controls.Add(this.read);
            this.tabPage7.Controls.Add(this.search);
            this.tabPage7.Controls.Add(this.valueTB);
            this.tabPage7.Controls.Add(this.datasetID);
            this.tabPage7.Controls.Add(this.repositoryURL);
            this.tabPage7.Controls.Add(this.materialLabel25);
            this.tabPage7.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1015, 520);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(969, 211);
            this.dataGridView1.TabIndex = 68;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 78);
            this.textBox1.TabIndex = 67;
            this.textBox1.Text = "URL repo:   \r\nhttps://www.datos.gov.co\r\nID dataset:   \r\nysq6-ri4e";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(840, 67);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(158, 157);
            this.checkedListBox1.TabIndex = 66;
            // 
            // read
            // 
            this.read.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.read.Depth = 0;
            this.read.DrawShadows = true;
            this.read.HighEmphasis = true;
            this.read.Icon = null;
            this.read.Location = new System.Drawing.Point(645, 109);
            this.read.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.read.MouseState = MaterialSkin.MouseState.HOVER;
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(58, 36);
            this.read.TabIndex = 65;
            this.read.Text = "Read";
            this.read.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.read.UseAccentColor = false;
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // search
            // 
            this.search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search.Depth = 0;
            this.search.DrawShadows = true;
            this.search.HighEmphasis = true;
            this.search.Icon = null;
            this.search.Location = new System.Drawing.Point(376, 188);
            this.search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.search.MouseState = MaterialSkin.MouseState.HOVER;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(78, 36);
            this.search.TabIndex = 64;
            this.search.Text = "Search";
            this.search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.search.UseAccentColor = false;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // valueTB
            // 
            this.valueTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valueTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueTB.Depth = 0;
            this.valueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valueTB.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.valueTB.Hint = "Value to consult";
            this.valueTB.Location = new System.Drawing.Point(67, 174);
            this.valueTB.MaxLength = 50;
            this.valueTB.MouseState = MaterialSkin.MouseState.OUT;
            this.valueTB.Multiline = false;
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(197, 50);
            this.valueTB.TabIndex = 63;
            this.valueTB.Text = "";
            // 
            // datasetID
            // 
            this.datasetID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datasetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datasetID.Depth = 0;
            this.datasetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datasetID.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.datasetID.Hint = "ID dataset";
            this.datasetID.Location = new System.Drawing.Point(376, 95);
            this.datasetID.MaxLength = 50;
            this.datasetID.MouseState = MaterialSkin.MouseState.OUT;
            this.datasetID.Multiline = false;
            this.datasetID.Name = "datasetID";
            this.datasetID.Size = new System.Drawing.Size(197, 50);
            this.datasetID.TabIndex = 62;
            this.datasetID.Text = "";
            // 
            // repositoryURL
            // 
            this.repositoryURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repositoryURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repositoryURL.Depth = 0;
            this.repositoryURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repositoryURL.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.repositoryURL.Hint = "URL Repository";
            this.repositoryURL.Location = new System.Drawing.Point(67, 95);
            this.repositoryURL.MaxLength = 50;
            this.repositoryURL.MouseState = MaterialSkin.MouseState.OUT;
            this.repositoryURL.Multiline = false;
            this.repositoryURL.Name = "repositoryURL";
            this.repositoryURL.Size = new System.Drawing.Size(256, 50);
            this.repositoryURL.TabIndex = 59;
            this.repositoryURL.Text = "";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel25.Location = new System.Drawing.Point(22, 13);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(384, 58);
            this.materialLabel25.TabIndex = 58;
            this.materialLabel25.Text = "Query in database";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.materialSwitch8);
            this.tabPage1.Controls.Add(this.materialLabel24);
            this.tabPage1.Controls.Add(this.materialSwitch6);
            this.tabPage1.Controls.Add(this.materialButton7);
            this.tabPage1.Controls.Add(this.MaterialButton4);
            this.tabPage1.Controls.Add(this.materialSwitch5);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialSwitch4);
            this.tabPage1.ImageKey = "round_build_white_24dp.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1015, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // materialSwitch8
            // 
            this.materialSwitch8.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialSwitch8.AutoSize = true;
            this.materialSwitch8.Checked = true;
            this.materialSwitch8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch8.Depth = 0;
            this.materialSwitch8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch8.Location = new System.Drawing.Point(32, 457);
            this.materialSwitch8.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch8.Name = "materialSwitch8";
            this.materialSwitch8.Ripple = true;
            this.materialSwitch8.Size = new System.Drawing.Size(309, 37);
            this.materialSwitch8.TabIndex = 37;
            this.materialSwitch8.Text = "Drawer - Display Icons when hidden";
            this.materialSwitch8.UseVisualStyleBackColor = true;
            this.materialSwitch8.CheckedChanged += new System.EventHandler(this.materialSwitch8_CheckedChanged);
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel24.Location = new System.Drawing.Point(21, 17);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(129, 58);
            this.materialLabel24.TabIndex = 32;
            this.materialLabel24.Text = "Home";
            // 
            // materialSwitch6
            // 
            this.materialSwitch6.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialSwitch6.AutoSize = true;
            this.materialSwitch6.Depth = 0;
            this.materialSwitch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch6.Location = new System.Drawing.Point(32, 420);
            this.materialSwitch6.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch6.Name = "materialSwitch6";
            this.materialSwitch6.Ripple = true;
            this.materialSwitch6.Size = new System.Drawing.Size(291, 37);
            this.materialSwitch6.TabIndex = 31;
            this.materialSwitch6.Text = "Drawer - Background with Accent";
            this.materialSwitch6.UseVisualStyleBackColor = true;
            this.materialSwitch6.CheckedChanged += new System.EventHandler(this.MaterialSwitch6_CheckedChanged);
            // 
            // materialButton7
            // 
            this.materialButton7.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(190, 290);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(133, 36);
            this.materialButton7.TabIndex = 0;
            this.materialButton7.Text = "Change Theme";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MaterialButton4
            // 
            this.MaterialButton4.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButton4.Depth = 0;
            this.MaterialButton4.DrawShadows = true;
            this.MaterialButton4.HighEmphasis = true;
            this.MaterialButton4.Icon = null;
            this.MaterialButton4.Location = new System.Drawing.Point(32, 290);
            this.MaterialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButton4.Name = "MaterialButton4";
            this.MaterialButton4.Size = new System.Drawing.Size(140, 36);
            this.MaterialButton4.TabIndex = 22;
            this.MaterialButton4.Text = "Change Colors";
            this.MaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButton4.UseAccentColor = false;
            this.MaterialButton4.UseVisualStyleBackColor = true;
            this.MaterialButton4.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // materialSwitch5
            // 
            this.materialSwitch5.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialSwitch5.AutoSize = true;
            this.materialSwitch5.Checked = true;
            this.materialSwitch5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch5.Depth = 0;
            this.materialSwitch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch5.Location = new System.Drawing.Point(32, 384);
            this.materialSwitch5.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch5.Name = "materialSwitch5";
            this.materialSwitch5.Ripple = true;
            this.materialSwitch5.Size = new System.Drawing.Size(270, 37);
            this.materialSwitch5.TabIndex = 30;
            this.materialSwitch5.Text = "Drawer - Highlight with Accent";
            this.materialSwitch5.UseVisualStyleBackColor = true;
            this.materialSwitch5.CheckedChanged += new System.EventHandler(this.MaterialSwitch5_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (180)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialLabel9.Location = new System.Drawing.Point(21, 115);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(322, 143);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = resources.GetString("materialLabel9.Text");
            // 
            // materialSwitch4
            // 
            this.materialSwitch4.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.materialSwitch4.AutoSize = true;
            this.materialSwitch4.Depth = 0;
            this.materialSwitch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch4.Location = new System.Drawing.Point(32, 347);
            this.materialSwitch4.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch4.Name = "materialSwitch4";
            this.materialSwitch4.Ripple = true;
            this.materialSwitch4.Size = new System.Drawing.Size(193, 37);
            this.materialSwitch4.TabIndex = 29;
            this.materialSwitch4.Text = "Drawer - Use colors";
            this.materialSwitch4.UseVisualStyleBackColor = true;
            this.materialSwitch4.CheckedChanged += new System.EventHandler(this.materialSwitch4_CheckedChanged);
            // 
            // TabAlgorithm
            // 
            this.TabAlgorithm.Controls.Add(this.tabPage1);
            this.TabAlgorithm.Controls.Add(this.tabPage7);
            this.TabAlgorithm.Controls.Add(this.tabPage6);
            this.TabAlgorithm.Controls.Add(this.tabPage2);
            this.TabAlgorithm.Depth = 0;
            this.TabAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabAlgorithm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TabAlgorithm.ImageList = this.menuIconList;
            this.TabAlgorithm.Location = new System.Drawing.Point(3, 64);
            this.TabAlgorithm.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabAlgorithm.Name = "TabAlgorithm";
            this.TabAlgorithm.SelectedIndex = 0;
            this.TabAlgorithm.Size = new System.Drawing.Size(1023, 555);
            this.TabAlgorithm.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.viewClusters);
            this.tabPage2.Controls.Add(this.cropsItems);
            this.tabPage2.Controls.Add(this.labelInfo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.KmeansChart);
            this.tabPage2.Controls.Add(this.materialDivider4);
            this.tabPage2.ImageKey = "round_bookmark_white_24dp.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1015, 520);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Kmeans";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(474, 10);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 21);
            this.materialLabel6.TabIndex = 78;
            this.materialLabel6.Text = "Select crop";
            // 
            // viewClusters
            // 
            this.viewClusters.Location = new System.Drawing.Point(474, 63);
            this.viewClusters.Name = "viewClusters";
            this.viewClusters.Size = new System.Drawing.Size(107, 23);
            this.viewClusters.TabIndex = 76;
            this.viewClusters.Text = "view clusters";
            this.viewClusters.UseVisualStyleBackColor = true;
            this.viewClusters.Click += new System.EventHandler(this.viewClusters_Click);
            // 
            // cropsItems
            // 
            this.cropsItems.FormattingEnabled = true;
            this.cropsItems.Items.AddRange(new object[] {"AlgodonA", "AlgodonB", "ArrozA", "ArrozB", "FrijolA", "FrijolB", "MaizTecnificadoA", "MaizTecnificadoB", "SorgoA", "SorgoB", "SoyaA", "SoyaB", "TabacoA", "TabacoB", "MaizTradicionalA", "MaizTradicionalB"});
            this.cropsItems.Location = new System.Drawing.Point(460, 34);
            this.cropsItems.Name = "cropsItems";
            this.cropsItems.Size = new System.Drawing.Size(121, 23);
            this.cropsItems.TabIndex = 75;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(373, 352);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 15);
            this.labelInfo.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 72;
            // 
            // KmeansChart
            // 
            this.KmeansChart.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.KmeansChart.Location = new System.Drawing.Point(40, 139);
            this.KmeansChart.Name = "KmeansChart";
            this.KmeansChart.Size = new System.Drawing.Size(918, 350);
            this.KmeansChart.TabIndex = 71;
            this.KmeansChart.Text = "cartesianChart1";
            this.KmeansChart.DataClick += new LiveCharts.Events.DataClickHandler(this.ChartOnDataClick);
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(40, 417);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(490, 1);
            this.materialDivider4.TabIndex = 70;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.materialButton6);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 16);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(7);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(301, 187);
            this.materialCard2.TabIndex = 66;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 57);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(267, 73);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "These are simple containers, but with a very nice shadow under them";
            // 
            // materialButton6
            // 
            this.materialButton6.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Depth = 0;
            this.materialButton6.DrawShadows = true;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(226, 131);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.Size = new System.Drawing.Size(58, 36);
            this.materialButton6.TabIndex = 1;
            this.materialButton6.Text = "Nice!";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(229, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Cards are also supported!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.TabAlgorithm);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabAlgorithm;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "GIAC-Valle del Cauca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.dashBoardTabs.ResumeLayout(false);
            this.tabTimeline.ResumeLayout(false);
            this.tabTimeline.PerformLayout();
            this.PieChartWithCropsTab.ResumeLayout(false);
            this.PieChartWithCropsTab.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.TabAlgorithm.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cropsItems;
        private MaterialSkin.Controls.MaterialTabControl dashBoardTabs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox datasetID;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private LiveCharts.WinForms.CartesianChart KmeansChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private MaterialSkin.Controls.MaterialButton MaterialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch4;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch5;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch6;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch8;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ImageList menuIconList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage PieChartWithCropsTab;
        private MaterialSkin.Controls.MaterialButton read;
        private MaterialSkin.Controls.MaterialTextBox repositoryURL;
        private MaterialSkin.Controls.MaterialButton search;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabControl TabAlgorithm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabTimeline;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MaterialSkin.Controls.MaterialTextBox valueTB;
        private System.Windows.Forms.Button viewClusters;

        #endregion
    }
}