namespace QuanLyQuanAn
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            RightMenu = new FlowLayoutPanel();
            BtnAll = new Button();
            panel1 = new Panel();
            LayoutMenu = new FlowLayoutPanel();
            btnVIP = new Button();
            Floor1 = new Button();
            TableLayout = new FlowLayoutPanel();
            Table1 = new TableLayoutPanel();
            Table1Lable = new Label();
            panel2 = new Panel();
            TableInfo = new Panel();
            TableIfName = new Label();
            Table = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel.SuspendLayout();
            RightMenu.SuspendLayout();
            LayoutMenu.SuspendLayout();
            TableLayout.SuspendLayout();
            Table1.SuspendLayout();
            TableInfo.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Menu.AutoSize = true;
            Menu.BackColor = Color.FromArgb(246, 240, 235);
            Menu.Controls.Add(pictureBox1);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1266, 71);
            Menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel.Controls.Add(RightMenu, 1, 0);
            tableLayoutPanel.Controls.Add(panel1, 0, 1);
            tableLayoutPanel.Controls.Add(LayoutMenu, 0, 0);
            tableLayoutPanel.Controls.Add(TableLayout, 0, 2);
            tableLayoutPanel.Controls.Add(panel2, 1, 1);
            tableLayoutPanel.Controls.Add(TableInfo, 1, 2);
            tableLayoutPanel.Location = new Point(0, 77);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1266, 603);
            tableLayoutPanel.TabIndex = 2;
            // 
            // RightMenu
            // 
            RightMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RightMenu.AutoSize = true;
            RightMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightMenu.Controls.Add(BtnAll);
            RightMenu.Location = new Point(1079, 3);
            RightMenu.Name = "RightMenu";
            RightMenu.Padding = new Padding(0, 0, 50, 0);
            RightMenu.Size = new Size(184, 69);
            RightMenu.TabIndex = 5;
            // 
            // BtnAll
            // 
            BtnAll.FlatAppearance.BorderColor = Color.Silver;
            BtnAll.FlatStyle = FlatStyle.Flat;
            BtnAll.Location = new Point(45, 20);
            BtnAll.Margin = new Padding(45, 20, 0, 0);
            BtnAll.Name = "BtnAll";
            BtnAll.Size = new Size(100, 30);
            BtnAll.TabIndex = 1;
            BtnAll.Text = "ALL";
            BtnAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(0, 75);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 15);
            panel1.TabIndex = 1;
            // 
            // LayoutMenu
            // 
            LayoutMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LayoutMenu.AutoSize = true;
            LayoutMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutMenu.Controls.Add(btnVIP);
            LayoutMenu.Controls.Add(Floor1);
            LayoutMenu.Location = new Point(3, 3);
            LayoutMenu.Name = "LayoutMenu";
            LayoutMenu.Size = new Size(1070, 69);
            LayoutMenu.TabIndex = 1;
            // 
            // btnVIP
            // 
            btnVIP.FlatAppearance.BorderColor = Color.Silver;
            btnVIP.FlatStyle = FlatStyle.Flat;
            btnVIP.Location = new Point(30, 20);
            btnVIP.Margin = new Padding(30, 20, 0, 0);
            btnVIP.Name = "btnVIP";
            btnVIP.Size = new Size(100, 30);
            btnVIP.TabIndex = 0;
            btnVIP.Text = "VIP";
            btnVIP.UseVisualStyleBackColor = true;
            // 
            // Floor1
            // 
            Floor1.FlatAppearance.BorderColor = Color.Silver;
            Floor1.FlatStyle = FlatStyle.Flat;
            Floor1.Location = new Point(160, 20);
            Floor1.Margin = new Padding(30, 20, 0, 0);
            Floor1.Name = "Floor1";
            Floor1.Size = new Size(100, 30);
            Floor1.TabIndex = 1;
            Floor1.Text = "Tầng 1";
            Floor1.UseVisualStyleBackColor = true;
            // 
            // TableLayout
            // 
            TableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayout.Controls.Add(Table1);
            TableLayout.Location = new Point(3, 93);
            TableLayout.Name = "TableLayout";
            TableLayout.Size = new Size(1070, 507);
            TableLayout.TabIndex = 2;
            // 
            // Table1
            // 
            Table1.BackColor = Color.LightBlue;
            Table1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            Table1.ColumnCount = 1;
            Table1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table1.Controls.Add(Table1Lable, 0, 0);
            Table1.Location = new Point(30, 20);
            Table1.Margin = new Padding(30, 20, 0, 0);
            Table1.Name = "Table1";
            Table1.RowCount = 2;
            Table1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Table1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            Table1.Size = new Size(230, 124);
            Table1.TabIndex = 3;
            // 
            // Table1Lable
            // 
            Table1Lable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Table1Lable.AutoSize = true;
            Table1Lable.BackColor = Color.LightCyan;
            Table1Lable.Location = new Point(2, 2);
            Table1Lable.Margin = new Padding(0);
            Table1Lable.Name = "Table1Lable";
            Table1Lable.Size = new Size(226, 23);
            Table1Lable.TabIndex = 0;
            Table1Lable.Text = "Bàn 1";
            Table1Lable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(1076, 75);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 15);
            panel2.TabIndex = 3;
            // 
            // TableInfo
            // 
            TableInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableInfo.BorderStyle = BorderStyle.FixedSingle;
            TableInfo.Controls.Add(TableIfName);
            TableInfo.Location = new Point(1076, 90);
            TableInfo.Margin = new Padding(0);
            TableInfo.Name = "TableInfo";
            TableInfo.Size = new Size(190, 513);
            TableInfo.TabIndex = 4;
            // 
            // TableIfName
            // 
            TableIfName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableIfName.BackColor = Color.LightCyan;
            TableIfName.BorderStyle = BorderStyle.FixedSingle;
            TableIfName.Location = new Point(5, 23);
            TableIfName.Margin = new Padding(5, 3, 5, 3);
            TableIfName.Name = "TableIfName";
            TableIfName.Size = new Size(178, 23);
            TableIfName.TabIndex = 1;
            TableIfName.Text = "Bàn 1";
            TableIfName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Table
            // 
            Table.Location = new Point(0, 0);
            Table.Name = "Table";
            Table.Size = new Size(200, 100);
            Table.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(30, 20, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 0;
            label1.Text = "Bàn 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.LightBlue;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(30, 20, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Location = new Point(2, 2);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 0;
            label3.Text = "Bàn 1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel);
            Controls.Add(Menu);
            Name = "View";
            Text = "Quản Lý Quán Ăn";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            RightMenu.ResumeLayout(false);
            LayoutMenu.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            Table1.ResumeLayout(false);
            Table1.PerformLayout();
            TableInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Menu;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel;
        private FlowLayoutPanel LayoutMenu;
        private Button btnVIP;
        private Panel panel1;
        private Button Floor1;
        private FlowLayoutPanel TableLayout;
        private TableLayoutPanel Table1;
        private Label Table1Lable;
        private TableLayoutPanel Table;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Panel panel2;
        private Panel TableInfo;
        private Label TableIfName;
        private FlowLayoutPanel RightMenu;
        private Button BtnAll;
    }
}