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
    public partial class Sub : Form
    {
        public Main main;
        public Sub()
        {
            InitializeComponent();
        }
        private void Sub_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.テキスト1;
            textBox2.Text = Properties.Settings.Default.テキスト2;
            radioButton1.Checked = Properties.Settings.Default.radio1;
            radioButton2.Checked = Properties.Settings.Default.radio2;
            checkBox1.Checked = Properties.Settings.Default.check;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                main.label1.Text = $"{radioButton1.Text} {textBox1.Text}";
            }
            else
            {
                main.label1.Text = $"{radioButton2.Text} {textBox1.Text}";
            }
            main.label2.Text = $"{textBox2.Text}";
            Properties.Settings.Default.テキスト1 = textBox1.Text;
            Properties.Settings.Default.テキスト2 = textBox2.Text;
            Properties.Settings.Default.radio1 = radioButton1.Checked;
            Properties.Settings.Default.radio2 = radioButton2.Checked;
            Properties.Settings.Default.check = checkBox1.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                main.timer1.Start();
                main.label2.Font = new Font("メイリオ", 22);
            }
            else
            {
                main.timer1.Stop();
                main.label2.Font = new Font("メイリオ", 22);
                main.label2.Text = $"{textBox2.Text}";
            }
        }
    }
}
