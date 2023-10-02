namespace SimVisualiser
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BT_YELLOW = new Button();
            BT_BLUE = new Button();
            TLP_FLAGS = new TableLayoutPanel();
            BT_ORANGE = new Button();
            BT_WHITE = new Button();
            BT_GREEN = new Button();
            BT_CLEAR = new Button();
            TrayIcon = new NotifyIcon(components);
            BT_CHECKERED_FLAG = new Button();
            BT_BLACK_FLAG = new Button();
            TLP_FLAGS.SuspendLayout();
            SuspendLayout();
            // 
            // BT_YELLOW
            // 
            BT_YELLOW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_YELLOW.BackColor = Color.Yellow;
            BT_YELLOW.ForeColor = Color.Black;
            BT_YELLOW.Location = new Point(100, 148);
            BT_YELLOW.Name = "BT_YELLOW";
            BT_YELLOW.Size = new Size(91, 139);
            BT_YELLOW.TabIndex = 3;
            BT_YELLOW.Text = "1";
            BT_YELLOW.UseVisualStyleBackColor = false;
            // 
            // BT_BLUE
            // 
            BT_BLUE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_BLUE.BackColor = Color.Blue;
            BT_BLUE.ForeColor = Color.White;
            BT_BLUE.Location = new Point(197, 148);
            BT_BLUE.Name = "BT_BLUE";
            BT_BLUE.Size = new Size(91, 139);
            BT_BLUE.TabIndex = 2;
            BT_BLUE.Text = "2";
            BT_BLUE.UseVisualStyleBackColor = false;
            // 
            // TLP_FLAGS
            // 
            TLP_FLAGS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_FLAGS.ColumnCount = 8;
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TLP_FLAGS.Controls.Add(BT_ORANGE, 7, 1);
            TLP_FLAGS.Controls.Add(BT_WHITE, 4, 1);
            TLP_FLAGS.Controls.Add(BT_GREEN, 3, 1);
            TLP_FLAGS.Controls.Add(BT_BLUE, 2, 1);
            TLP_FLAGS.Controls.Add(BT_YELLOW, 1, 1);
            TLP_FLAGS.Controls.Add(BT_CLEAR, 0, 1);
            TLP_FLAGS.Controls.Add(BT_CHECKERED_FLAG, 5, 1);
            TLP_FLAGS.Controls.Add(BT_BLACK_FLAG, 6, 1);
            TLP_FLAGS.Location = new Point(12, 12);
            TLP_FLAGS.Name = "TLP_FLAGS";
            TLP_FLAGS.RowCount = 2;
            TLP_FLAGS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FLAGS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FLAGS.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_FLAGS.Size = new Size(776, 290);
            TLP_FLAGS.TabIndex = 2;
            // 
            // BT_ORANGE
            // 
            BT_ORANGE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_ORANGE.BackColor = Color.Orange;
            BT_ORANGE.ForeColor = Color.Black;
            BT_ORANGE.Location = new Point(682, 148);
            BT_ORANGE.Name = "BT_ORANGE";
            BT_ORANGE.Size = new Size(91, 139);
            BT_ORANGE.TabIndex = 6;
            BT_ORANGE.Text = "7";
            BT_ORANGE.UseVisualStyleBackColor = false;
            // 
            // BT_WHITE
            // 
            BT_WHITE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_WHITE.BackColor = Color.White;
            BT_WHITE.ForeColor = Color.Black;
            BT_WHITE.Location = new Point(391, 148);
            BT_WHITE.Name = "BT_WHITE";
            BT_WHITE.Size = new Size(91, 139);
            BT_WHITE.TabIndex = 4;
            BT_WHITE.Text = "4";
            BT_WHITE.UseVisualStyleBackColor = false;
            // 
            // BT_GREEN
            // 
            BT_GREEN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_GREEN.BackColor = Color.Green;
            BT_GREEN.ForeColor = Color.White;
            BT_GREEN.Location = new Point(294, 148);
            BT_GREEN.Name = "BT_GREEN";
            BT_GREEN.Size = new Size(91, 139);
            BT_GREEN.TabIndex = 5;
            BT_GREEN.Text = "3";
            BT_GREEN.UseVisualStyleBackColor = false;
            // 
            // BT_CLEAR
            // 
            BT_CLEAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CLEAR.BackColor = Color.Black;
            BT_CLEAR.ForeColor = Color.White;
            BT_CLEAR.Location = new Point(3, 148);
            BT_CLEAR.Name = "BT_CLEAR";
            BT_CLEAR.Size = new Size(91, 139);
            BT_CLEAR.TabIndex = 1;
            BT_CLEAR.Text = "0";
            BT_CLEAR.UseVisualStyleBackColor = false;
            // 
            // TrayIcon
            // 
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "SimVisualiser";
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            // 
            // BT_CHECKERED_FLAG
            // 
            BT_CHECKERED_FLAG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CHECKERED_FLAG.BackColor = Color.DarkGray;
            BT_CHECKERED_FLAG.ForeColor = Color.Black;
            BT_CHECKERED_FLAG.Location = new Point(488, 148);
            BT_CHECKERED_FLAG.Name = "BT_CHECKERED_FLAG";
            BT_CHECKERED_FLAG.Size = new Size(91, 139);
            BT_CHECKERED_FLAG.TabIndex = 7;
            BT_CHECKERED_FLAG.Text = "5";
            BT_CHECKERED_FLAG.UseVisualStyleBackColor = false;
            // 
            // BT_BLACK_FLAG
            // 
            BT_BLACK_FLAG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_BLACK_FLAG.BackColor = Color.Black;
            BT_BLACK_FLAG.ForeColor = Color.White;
            BT_BLACK_FLAG.Location = new Point(585, 148);
            BT_BLACK_FLAG.Name = "BT_BLACK_FLAG";
            BT_BLACK_FLAG.Size = new Size(91, 139);
            BT_BLACK_FLAG.TabIndex = 8;
            BT_BLACK_FLAG.Text = "6";
            BT_BLACK_FLAG.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(TLP_FLAGS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "SimVisualiser";
            FormClosed += MainWindow_FormClosed;
            Resize += MainWindow_Resize;
            TLP_FLAGS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BT_YELLOW;
        private Button BT_BLUE;
        private TableLayoutPanel TLP_FLAGS;
        private Button BT_GREEN;
        private Button BT_WHITE;
        private Button BT_CLEAR;
        private Button BT_ORANGE;
        private NotifyIcon TrayIcon;
        private Button BT_CHECKERED_FLAG;
        private Button BT_BLACK_FLAG;
    }
}