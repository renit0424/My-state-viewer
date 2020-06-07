using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_state_viewer
{
    public partial class Main : Form
    {
        Sub sub;
        public Main()
        {
            InitializeComponent();
            sub = new Sub();
            sub.main = this;
            if (sub.radioButton1.Checked == true)
            {
               label1.Text = $"{sub.radioButton1.Text} {Properties.Settings.Default.テキスト1}";
            }
            else
            {
                label1.Text = $"{sub.radioButton2.Text} {Properties.Settings.Default.テキスト1}";
            }
            label2.Text = Properties.Settings.Default.テキスト2;
        }

        private void 在席ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "在席";
        }

        private void 離席ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "離席";
        }

        private void 作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "作業";
        }

        private void 外出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "外出";
        }

        private void 就寝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "就寝";
        }

        private void 不明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "不明";
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = toolStripTextBox1.TextBox.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToString("HH時mm分ss秒");
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sub.Show();
        }
    }
}
