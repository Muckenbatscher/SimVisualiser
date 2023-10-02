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
            BT_CLEAR = new Button();
            BT_GREEN = new Button();
            BT_ORANGE = new Button();
            BT_WHITE = new Button();
            TrayIcon = new NotifyIcon(components);
            TLP_FLAGS.SuspendLayout();
            SuspendLayout();
            // 
            // BT_YELLOW
            // 
            BT_YELLOW.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_YELLOW.BackColor = Color.Yellow;
            BT_YELLOW.ForeColor = Color.Black;
            BT_YELLOW.Location = new Point(3, 92);
            BT_YELLOW.Name = "BT_YELLOW";
            BT_YELLOW.Size = new Size(149, 84);
            BT_YELLOW.TabIndex = 3;
            BT_YELLOW.Text = "1";
            BT_YELLOW.UseVisualStyleBackColor = false;
            BT_YELLOW.Click += BT_YELLOW_Click;
            // 
            // BT_BLUE
            // 
            BT_BLUE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_BLUE.BackColor = Color.Blue;
            BT_BLUE.ForeColor = Color.White;
            BT_BLUE.Location = new Point(158, 92);
            BT_BLUE.Name = "BT_BLUE";
            BT_BLUE.Size = new Size(149, 84);
            BT_BLUE.TabIndex = 2;
            BT_BLUE.Text = "2";
            BT_BLUE.UseVisualStyleBackColor = false;
            BT_BLUE.Click += BT_BLUE_Click;
            // 
            // TLP_FLAGS
            // 
            TLP_FLAGS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TLP_FLAGS.ColumnCount = 5;
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_FLAGS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLP_FLAGS.Controls.Add(BT_CLEAR, 0, 0);
            TLP_FLAGS.Controls.Add(BT_GREEN, 2, 1);
            TLP_FLAGS.Controls.Add(BT_YELLOW, 0, 1);
            TLP_FLAGS.Controls.Add(BT_ORANGE, 4, 1);
            TLP_FLAGS.Controls.Add(BT_BLUE, 1, 1);
            TLP_FLAGS.Controls.Add(BT_WHITE, 3, 1);
            TLP_FLAGS.Location = new Point(12, 12);
            TLP_FLAGS.Name = "TLP_FLAGS";
            TLP_FLAGS.RowCount = 2;
            TLP_FLAGS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FLAGS.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_FLAGS.Size = new Size(776, 179);
            TLP_FLAGS.TabIndex = 2;
            // 
            // BT_CLEAR
            // 
            BT_CLEAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CLEAR.BackColor = Color.Black;
            TLP_FLAGS.SetColumnSpan(BT_CLEAR, 5);
            BT_CLEAR.ForeColor = Color.White;
            BT_CLEAR.Location = new Point(3, 3);
            BT_CLEAR.Name = "BT_CLEAR";
            BT_CLEAR.Size = new Size(770, 83);
            BT_CLEAR.TabIndex = 1;
            BT_CLEAR.Text = "0";
            BT_CLEAR.UseVisualStyleBackColor = false;
            BT_CLEAR.Click += BT_CLEAR_Click;
            // 
            // BT_GREEN
            // 
            BT_GREEN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_GREEN.BackColor = Color.Green;
            BT_GREEN.ForeColor = Color.White;
            BT_GREEN.Location = new Point(313, 92);
            BT_GREEN.Name = "BT_GREEN";
            BT_GREEN.Size = new Size(149, 84);
            BT_GREEN.TabIndex = 5;
            BT_GREEN.Text = "3";
            BT_GREEN.UseVisualStyleBackColor = false;
            BT_GREEN.Click += BT_GREEN_Click;
            // 
            // BT_ORANGE
            // 
            BT_ORANGE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_ORANGE.BackColor = Color.Orange;
            BT_ORANGE.ForeColor = Color.Black;
            BT_ORANGE.Location = new Point(623, 92);
            BT_ORANGE.Name = "BT_ORANGE";
            BT_ORANGE.Size = new Size(150, 84);
            BT_ORANGE.TabIndex = 6;
            BT_ORANGE.Text = "7";
            BT_ORANGE.UseVisualStyleBackColor = false;
            BT_ORANGE.Click += BT_ORANGE_Click;
            // 
            // BT_WHITE
            // 
            BT_WHITE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_WHITE.BackColor = Color.White;
            BT_WHITE.ForeColor = Color.Black;
            BT_WHITE.Location = new Point(468, 92);
            BT_WHITE.Name = "BT_WHITE";
            BT_WHITE.Size = new Size(149, 84);
            BT_WHITE.TabIndex = 4;
            BT_WHITE.Text = "4";
            BT_WHITE.UseVisualStyleBackColor = false;
            BT_WHITE.Click += BT_WHITE_Click;
            // 
            // TrayIcon
            // 
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "SimVisualiser";
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}