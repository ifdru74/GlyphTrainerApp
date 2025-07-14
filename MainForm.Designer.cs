namespace GlyphTrainerApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            toolExitButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripStart = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolNewButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolSaveButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            pauseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            showAppWindowToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolExitButton, toolStripSeparator3, toolStripStart, toolStripSeparator1, toolNewButton, toolStripButton1, toolSaveButton, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolExitButton
            // 
            toolExitButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolExitButton.Image = Properties.Resources.Log_Out;
            toolExitButton.ImageTransparentColor = Color.Magenta;
            toolExitButton.Name = "toolExitButton";
            toolExitButton.Size = new Size(23, 22);
            toolExitButton.Text = "Exit";
            toolExitButton.ToolTipText = "Exit the application now";
            toolExitButton.Click += toolExitButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripStart
            // 
            toolStripStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripStart.Image = Properties.Resources.ticket1;
            toolStripStart.ImageTransparentColor = Color.Magenta;
            toolStripStart.Name = "toolStripStart";
            toolStripStart.Size = new Size(23, 22);
            toolStripStart.Text = "Start learning";
            toolStripStart.Click += toolStripStart_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolNewButton
            // 
            toolNewButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolNewButton.Image = Properties.Resources.New;
            toolNewButton.ImageTransparentColor = Color.Magenta;
            toolNewButton.Name = "toolNewButton";
            toolNewButton.Size = new Size(23, 22);
            toolNewButton.Text = "New file...";
            toolNewButton.ToolTipText = "Create a new learning database file";
            toolNewButton.Click += toolNewButton_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Open;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Open...";
            toolStripButton1.ToolTipText = "Open an existing database file";
            // 
            // toolSaveButton
            // 
            toolSaveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolSaveButton.Image = Properties.Resources.Save;
            toolSaveButton.ImageTransparentColor = Color.Magenta;
            toolSaveButton.Name = "toolSaveButton";
            toolSaveButton.Size = new Size(23, 22);
            toolSaveButton.Text = "Save...";
            toolSaveButton.ToolTipText = "Commit changes now";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Language trainer";
            notifyIcon1.BalloonTipTitle = "Language trainer application";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Language trainer";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pauseToolStripMenuItem, toolStripMenuItem1, showAppWindowToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 54);
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Image = Properties.Resources.ticket;
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(171, 22);
            pauseToolStripMenuItem.Text = "&Pause";
            pauseToolStripMenuItem.ToolTipText = "Pause learning actions";
            pauseToolStripMenuItem.Click += toolStripStart_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(168, 6);
            // 
            // showAppWindowToolStripMenuItem
            // 
            showAppWindowToolStripMenuItem.Enabled = false;
            showAppWindowToolStripMenuItem.Image = Properties.Resources.library;
            showAppWindowToolStripMenuItem.Name = "showAppWindowToolStripMenuItem";
            showAppWindowToolStripMenuItem.Size = new Size(171, 22);
            showAppWindowToolStripMenuItem.Text = "&Show app window";
            showAppWindowToolStripMenuItem.ToolTipText = "Show application main window";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 379);
            dataGridView1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Resize += MainForm_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem showAppWindowToolStripMenuItem;
        private ToolStripButton toolStripStart;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolNewButton;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolExitButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolSaveButton;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridView dataGridView1;
    }
}