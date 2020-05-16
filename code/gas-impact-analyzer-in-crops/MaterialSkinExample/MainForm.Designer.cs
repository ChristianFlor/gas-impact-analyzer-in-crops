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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MaterialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch8 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch6 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.MaterialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch5 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch4 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.algo = new System.Windows.Forms.Label();
            this.materialContextMenuStrip1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
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
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
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
            this.tabPage6.Controls.Add(this.materialTabSelector1);
            this.tabPage6.Controls.Add(this.materialTabControl2);
            this.tabPage6.ImageKey = "round_bookmark_white_24dp.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1015, 520);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Cards";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1015, 38);
            this.materialTabSelector1.TabIndex = 24;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage8);
            this.materialTabControl2.Controls.Add(this.tabPage9);
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 38);
            this.materialTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1019, 320);
            this.materialTabControl2.TabIndex = 23;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.materialLabel45);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1011, 294);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Heat map";
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
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.materialLabel10);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1011, 294);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Linear";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.HighEmphasis = true;
            this.materialLabel10.Location = new System.Drawing.Point(6, 7);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(475, 58);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Everything is possible!";
            this.materialLabel10.UseAccent = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1011, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bar";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1011, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Circular graph";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.tabPage7.Controls.Add(this.materialButton5);
            this.tabPage7.Controls.Add(this.materialButton2);
            this.tabPage7.Controls.Add(this.materialTextBox2);
            this.tabPage7.Controls.Add(this.materialTextBox1);
            this.tabPage7.Controls.Add(this.materialCheckedListBox1);
            this.tabPage7.Controls.Add(this.materialListView1);
            this.tabPage7.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage7.Controls.Add(this.materialLabel25);
            this.tabPage7.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1015, 520);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Data";
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Depth = 0;
            this.materialButton5.DrawShadows = true;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(506, 88);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(58, 36);
            this.materialButton5.TabIndex = 65;
            this.materialButton5.Text = "Read";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(338, 174);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(78, 36);
            this.materialButton2.TabIndex = 64;
            this.materialButton2.Text = "Search";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox2.Hint = "Value to consult";
            this.materialTextBox2.Location = new System.Drawing.Point(25, 160);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(197, 50);
            this.materialTextBox2.TabIndex = 63;
            this.materialTextBox2.Text = "";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox1.Hint = "ID dataset";
            this.materialTextBox1.Location = new System.Drawing.Point(252, 76);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(197, 50);
            this.materialTextBox1.TabIndex = 62;
            this.materialTextBox1.Text = "";
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialCheckedListBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(664, 37);
            this.materialCheckedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(242, 249);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 61;
            // 
            // materialListView1
            // 
            this.materialListView1.AllowColumnReorder = true;
            this.materialListView1.AutoSizeTable = true;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(25, 275);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Scrollable = false;
            this.materialListView1.Size = new System.Drawing.Size(547, 100);
            this.materialListView1.TabIndex = 60;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialSingleLineTextField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialSingleLineTextField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField2.Hint = "URL Repository";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(25, 76);
            this.materialSingleLineTextField2.MaxLength = 50;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialSingleLineTextField2.Multiline = false;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(197, 50);
            this.materialSingleLineTextField2.TabIndex = 59;
            this.materialSingleLineTextField2.Text = "";
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
            this.tabPage1.Controls.Add(this.MaterialButton3);
            this.tabPage1.Controls.Add(this.materialSwitch8);
            this.tabPage1.Controls.Add(this.materialLabel24);
            this.tabPage1.Controls.Add(this.materialSwitch6);
            this.tabPage1.Controls.Add(this.materialLabel6);
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
            // MaterialButton3
            // 
            this.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButton3.Depth = 0;
            this.MaterialButton3.DrawShadows = true;
            this.MaterialButton3.HighEmphasis = true;
            this.MaterialButton3.Icon = null;
            this.MaterialButton3.Location = new System.Drawing.Point(22, 425);
            this.MaterialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButton3.Name = "MaterialButton3";
            this.MaterialButton3.Size = new System.Drawing.Size(163, 36);
            this.MaterialButton3.TabIndex = 36;
            this.MaterialButton3.Text = "Open Message box";
            this.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButton3.UseAccentColor = false;
            this.MaterialButton3.UseVisualStyleBackColor = true;
            this.MaterialButton3.Click += new System.EventHandler(this.MaterialButton3_Click);
            // 
            // materialSwitch8
            // 
            this.materialSwitch8.AutoSize = true;
            this.materialSwitch8.Checked = true;
            this.materialSwitch8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch8.Depth = 0;
            this.materialSwitch8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch8.Location = new System.Drawing.Point(22, 323);
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
            this.materialSwitch6.AutoSize = true;
            this.materialSwitch6.Depth = 0;
            this.materialSwitch6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch6.Location = new System.Drawing.Point(22, 286);
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
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 389);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(154, 19);
            this.materialLabel6.TabIndex = 35;
            this.materialLabel6.Text = "Flexible Message Box";
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(180, 156);
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
            this.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButton4.Depth = 0;
            this.MaterialButton4.DrawShadows = true;
            this.MaterialButton4.HighEmphasis = true;
            this.MaterialButton4.Icon = null;
            this.MaterialButton4.Location = new System.Drawing.Point(22, 156);
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
            this.materialSwitch5.AutoSize = true;
            this.materialSwitch5.Checked = true;
            this.materialSwitch5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch5.Depth = 0;
            this.materialSwitch5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch5.Location = new System.Drawing.Point(22, 250);
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
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(19, 79);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(937, 60);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = resources.GetString("materialLabel9.Text");
            // 
            // materialSwitch4
            // 
            this.materialSwitch4.AutoSize = true;
            this.materialSwitch4.Depth = 0;
            this.materialSwitch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch4.Location = new System.Drawing.Point(22, 213);
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
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1023, 555);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.algo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.materialDivider4);
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.ImageKey = "round_assessment_white_24dp.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1015, 520);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 71;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.materialButton6);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 52);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(267, 73);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "These are simple containers, but with a very nice shadow under them";
            // 
            // materialButton6
            // 
            this.materialButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            // algo
            // 
            this.algo.AutoSize = true;
            this.algo.Location = new System.Drawing.Point(473, 40);
            this.algo.Name = "algo";
            this.algo.Size = new System.Drawing.Size(35, 13);
            this.algo.TabIndex = 72;
            this.algo.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Text = "GIAC-Valle del Cauca";
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton MaterialButton3;
        private MaterialSkin.Controls.MaterialButton MaterialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialTextBox materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch4;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch5;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch6;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch8;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.ImageList menuIconList;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        #endregion

        private MaterialCard materialCard2;
        private MaterialLabel materialLabel1;
        private MaterialButton materialButton6;
        private MaterialLabel materialLabel2;
        private Label label1;
        private Label algo;
    }
}