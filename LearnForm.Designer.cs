namespace GlyphTrainerApp
{
    partial class LearnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            skipButton = new Button();
            learnedButton = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            txtPron = new TextBox();
            txtMean = new TextBox();
            txtGlyph = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 1);
            tableLayoutPanel1.Controls.Add(linkLabel2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPron, 1, 1);
            tableLayoutPanel1.Controls.Add(txtMean, 1, 2);
            tableLayoutPanel1.Controls.Add(txtGlyph, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.MinimumSize = new Size(400, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.1120033F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3253336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3253336F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2373228F));
            tableLayoutPanel1.Size = new Size(800, 438);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(skipButton);
            flowLayoutPanel1.Controls.Add(learnedButton);
            flowLayoutPanel1.Location = new Point(4, 395);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.MinimumSize = new Size(200, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(792, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // skipButton
            // 
            skipButton.DialogResult = DialogResult.Cancel;
            skipButton.Location = new Point(4, 3);
            skipButton.Margin = new Padding(4, 3, 4, 3);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(88, 27);
            skipButton.TabIndex = 6;
            skipButton.Text = "&Skip";
            skipButton.UseVisualStyleBackColor = true;
            skipButton.Click += button1_Click;
            // 
            // learnedButton
            // 
            learnedButton.DialogResult = DialogResult.OK;
            learnedButton.Location = new Point(100, 3);
            learnedButton.Margin = new Padding(4, 3, 4, 3);
            learnedButton.Name = "learnedButton";
            learnedButton.Size = new Size(88, 27);
            learnedButton.TabIndex = 7;
            learnedButton.Text = "&Learned";
            learnedButton.UseVisualStyleBackColor = true;
            learnedButton.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(5, 263);
            linkLabel1.Margin = new Padding(5);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(110, 57);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pronunciation:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Dock = DockStyle.Fill;
            linkLabel2.Location = new Point(3, 325);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Padding = new Padding(5);
            linkLabel2.Size = new Size(114, 67);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Meaning:";
            // 
            // txtPron
            // 
            txtPron.BorderStyle = BorderStyle.None;
            txtPron.Dock = DockStyle.Fill;
            txtPron.Location = new Point(123, 261);
            txtPron.Multiline = true;
            txtPron.Name = "txtPron";
            txtPron.Size = new Size(674, 61);
            txtPron.TabIndex = 3;
            // 
            // txtMean
            // 
            txtMean.BorderStyle = BorderStyle.None;
            txtMean.Dock = DockStyle.Fill;
            txtMean.Location = new Point(123, 328);
            txtMean.Multiline = true;
            txtMean.Name = "txtMean";
            txtMean.Size = new Size(674, 61);
            txtMean.TabIndex = 5;
            // 
            // txtGlyph
            // 
            txtGlyph.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(txtGlyph, 2);
            txtGlyph.Dock = DockStyle.Fill;
            txtGlyph.Font = new Font("KaiTi", 99.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGlyph.Location = new Point(3, 3);
            txtGlyph.Multiline = true;
            txtGlyph.Name = "txtGlyph";
            txtGlyph.Size = new Size(794, 252);
            txtGlyph.TabIndex = 1;
            txtGlyph.Text = "对";
            txtGlyph.TextAlign = HorizontalAlignment.Center;
            // 
            // LearnForm
            // 
            AcceptButton = learnedButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = skipButton;
            ClientSize = new Size(800, 438);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(400, 300);
            Name = "LearnForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Learn";
            TopMost = true;
            FormClosing += LearnForm_FormClosing;
            Resize += LearnForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button skipButton;
        private Button learnedButton;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox txtPron;
        private TextBox txtMean;
        private TextBox txtGlyph;
    }
}
