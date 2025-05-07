using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data;

namespace GlyphTrainerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            showAppWindowToolStripMenuItem.Enabled = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    Hide();
                    showAppWindowToolStripMenuItem.Enabled = true;
                    break;
                case FormWindowState.Normal:
                    showAppWindowToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        private void toolStripStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                LearnForm lf = new LearnForm();
                lf.Tag = this;
                lf.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                foreach (Screen scr in Screen.AllScreens)
                {
                    lf.Width = scr.Bounds.Width / 8;
                    if (lf.Width < 100)
                    {
                        lf.Width = 100;
                    }
                    lf.Height = scr.Bounds.Height / 8;
                    if (lf.Height < 100)
                    {
                        lf.Height = 100;
                    }
                    lf.Top = scr.Bounds.Top + (scr.Bounds.Height - lf.Height - 50);
                    lf.Left = scr.Bounds.Left + (scr.Bounds.Width - lf.Width);
                    break;
                }
                lf.Show();
                timer1.Tag = lf;
                toolStripStart.Checked = timer1.Enabled = true;
            }
            else
            {
                toolStripStart.Checked = timer1.Enabled = false;
                LearnForm lf = timer1.Tag as LearnForm;
                if (lf != null)
                {
                    lf.Hide();
                    timer1.Tag = null;
                }
            }
            pauseToolStripMenuItem.Checked = !toolStripStart.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LearnForm lf = timer1.Tag as LearnForm;
            if (lf != null)
            {
                lf.Text = timer1.ToString();
            }
        }

        public void LearningFormClosed()
        {
            toolStripStart.Checked = timer1.Enabled = false;
            if (timer1.Tag != null)
            {
                timer1.Tag = null;
            }
            pauseToolStripMenuItem.Checked = !toolStripStart.Checked;
        }

        private void toolExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolNewButton_Click(object sender, EventArgs e)
        {
            Microsoft.Data.Sqlite.SqliteConnection x = new Microsoft.Data.Sqlite.SqliteConnection();
            if (x != null)
            {
                x.Open();
                Microsoft.Data.Sqlite.SqliteCommand cmd = x.CreateCommand();
                cmd.CommandText = "create table config (id integer primary key, name text, value text, active integer)";
                cmd.ExecuteNonQuery();

            }
        }
    }
}
