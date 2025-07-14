namespace GlyphTrainerApp
{
    public partial class LearnForm : Form
    {
        string styleCss;
        List<float> layRows = new List<float>();
        List<float> layCols = new List<float>();
        public LearnForm()
        {
            styleCss = "<style type=\"text/css\">@font-face {font-family: \"KaiTi\";}.glyph_disp {font-family: \"KaiTi\" !important;}</style>";
            InitializeComponent();
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                layRows.Add(rs.Height);
            }
            foreach (ColumnStyle rc in tableLayoutPanel1.ColumnStyles)
            {
                layCols.Add(rc.Width);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowser1.DocumentText = $"<html><head><title>button 一</title>{styleCss}</head><body><H1>button 一</H1><p>button <span class=\"glyph_disp\">一</span> text</p></body></html>";
            txtGlyph.Text = "对";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //webBrowser1.DocumentText = $"<html><head><title>button 二</title>{styleCss}</head><body><H1>button 二</H1><p>button <span class=\"glyph_disp\">二</span> text</p></body></html>";
            txtGlyph.Text = "的";
        }

        private void LearnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = Tag as MainForm;
            if (mainForm != null)
            {
                mainForm.LearningFormClosed();
            }
        }

        private void LearnForm_Resize(object sender, EventArgs e)
        {
            int minHeight = 400;
            int minWidth = 300;
            if (ClientSize.Width < minWidth)
            {
                Width = minWidth + 10;
            }
            if (ClientSize.Height < minHeight)
            {
                Height = minHeight + 50;
            }
            int idx = 0;
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                rs.SizeType = SizeType.Absolute;
                rs.Height = layRows[idx++] * ClientSize.Height / 100;
            }
            idx = 0;
            foreach (ColumnStyle rc in tableLayoutPanel1.ColumnStyles)
            {
                rc.SizeType = SizeType.Absolute;
                rc.Width = layCols[idx++] * ClientSize.Width / 100;
            }
            txtGlyph.Width = ClientSize.Width;
            txtGlyph.Height = (int)(tableLayoutPanel1.RowStyles[0].Height);
            txtPron.Width = txtMean.Width = (int)(tableLayoutPanel1.ColumnStyles[1].Width);
            linkLabel1.Width = linkLabel2.Width = (int)(tableLayoutPanel1.ColumnStyles[0].Width);
            if(linkLabel1.Width<100)
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 100;
                tableLayoutPanel1.ColumnStyles[1].Width = ClientSize.Width - linkLabel2.Width - 1;
            }
            linkLabel1.Height = txtPron.Height = (int)(tableLayoutPanel1.RowStyles[1].Height);
            linkLabel2.Height = txtMean.Height = (int)(tableLayoutPanel1.RowStyles[2].Height);
            flowLayoutPanel1.Height = (int)(tableLayoutPanel1.RowStyles[3].Height);
        }
    }
}
