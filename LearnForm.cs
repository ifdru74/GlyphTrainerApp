namespace GlyphTrainerApp
{
    public partial class LearnForm : Form
    {
        string styleCss;
        public LearnForm()
        {
            styleCss = "<style type=\"text/css\">@font-face {font-family: \"KaiTi\";}.glyph_disp {font-family: \"KaiTi\" !important;}</style>";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = $"<html><head><title>button 一</title>{styleCss}</head><body><H1>button 一</H1><p>button <span class=\"glyph_disp\">一</span> text</p></body></html>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = $"<html><head><title>button 二</title>{styleCss}</head><body><H1>button 二</H1><p>button <span class=\"glyph_disp\">二</span> text</p></body></html>";
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
            float hb = button1.Height + button1.Margin.Vertical + flowLayoutPanel1.Margin.Vertical;
            if(tableLayoutPanel1.RowStyles[1].Height<hb)
            {
                tableLayoutPanel1.RowStyles[1].Height = hb;
            }
            int h = ClientSize.Height;
            tableLayoutPanel1.RowStyles[0].Height = h - tableLayoutPanel1.RowStyles[1].Height;
            webBrowser1.Height = (int)(tableLayoutPanel1.RowStyles[0].Height);
        }
    }
}
