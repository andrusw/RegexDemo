using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexDemo
{
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonRunRegex_Click(object sender, EventArgs e)
        {
            string[] lines = this.textBoxSearch.Text.Split(new char[] { '\n' });
            string regex = this.textBoxRegex.Text;
            this.textBoxResult.Text = "";

            if(this.radioButtonMatch.Checked)
            {
                foreach(string line in lines)
                {
                    if(Regex.IsMatch(line,regex))
                    {
                        this.textBoxResult.Text += line + '\n';
                    }
                }
            }
            else if (this.radioButtonReplace.Checked)
            {
                Regex r = new Regex(regex);
                string replace = this.textBoxRegexReplace.Text;

                foreach (string line in lines)
                {
                    this.textBoxResult.Text += r.Replace(line,replace ) + '\n';
                }
            }

        }

        private void radioButtonMatch_CheckedChanged(object sender, EventArgs e)
        {
            this.labelCompareText.Text = "Text to match";
            this.labelRegexReplace.Visible = false;
            this.textBoxRegexReplace.Visible = false;
        }

        private void radioButtonReplace_CheckedChanged(object sender, EventArgs e)
        {
            this.labelCompareText.Text = "Text to replace";
            this.labelRegexReplace.Visible = true;
            this.textBoxRegexReplace.Visible = true;
        }
    }
}
