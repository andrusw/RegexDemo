namespace RegexDemo
{
    partial class FormRegex
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
            this.radioButtonMatch = new System.Windows.Forms.RadioButton();
            this.radioButtonReplace = new System.Windows.Forms.RadioButton();
            this.groupBoxRegextype = new System.Windows.Forms.GroupBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.buttonRunRegex = new System.Windows.Forms.Button();
            this.labelRegex = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelCompareText = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelRegexReplace = new System.Windows.Forms.Label();
            this.textBoxRegexReplace = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRegextype.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMatch
            // 
            this.radioButtonMatch.AutoSize = true;
            this.radioButtonMatch.Checked = true;
            this.radioButtonMatch.Location = new System.Drawing.Point(8, 26);
            this.radioButtonMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonMatch.Name = "radioButtonMatch";
            this.radioButtonMatch.Size = new System.Drawing.Size(71, 24);
            this.radioButtonMatch.TabIndex = 0;
            this.radioButtonMatch.TabStop = true;
            this.radioButtonMatch.Text = "Match";
            this.radioButtonMatch.UseVisualStyleBackColor = true;
            this.radioButtonMatch.CheckedChanged += new System.EventHandler(this.radioButtonMatch_CheckedChanged);
            // 
            // radioButtonReplace
            // 
            this.radioButtonReplace.AutoSize = true;
            this.radioButtonReplace.Location = new System.Drawing.Point(87, 26);
            this.radioButtonReplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonReplace.Name = "radioButtonReplace";
            this.radioButtonReplace.Size = new System.Drawing.Size(86, 24);
            this.radioButtonReplace.TabIndex = 1;
            this.radioButtonReplace.Text = "Replace";
            this.radioButtonReplace.UseVisualStyleBackColor = true;
            this.radioButtonReplace.CheckedChanged += new System.EventHandler(this.radioButtonReplace_CheckedChanged);
            // 
            // groupBoxRegextype
            // 
            this.groupBoxRegextype.Controls.Add(this.radioButtonMatch);
            this.groupBoxRegextype.Controls.Add(this.radioButtonReplace);
            this.groupBoxRegextype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegextype.Location = new System.Drawing.Point(1044, 18);
            this.groupBoxRegextype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRegextype.Name = "groupBoxRegextype";
            this.groupBoxRegextype.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRegextype.Size = new System.Drawing.Size(180, 51);
            this.groupBoxRegextype.TabIndex = 4;
            this.groupBoxRegextype.TabStop = false;
            this.groupBoxRegextype.Text = "Regex";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegex.Location = new System.Drawing.Point(6, 35);
            this.textBoxRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(554, 26);
            this.textBoxRegex.TabIndex = 1;
            // 
            // buttonRunRegex
            // 
            this.buttonRunRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunRegex.Location = new System.Drawing.Point(568, 127);
            this.buttonRunRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRunRegex.Name = "buttonRunRegex";
            this.buttonRunRegex.Size = new System.Drawing.Size(112, 54);
            this.buttonRunRegex.TabIndex = 9;
            this.buttonRunRegex.Text = "Run Regex\r\n";
            this.buttonRunRegex.UseVisualStyleBackColor = true;
            this.buttonRunRegex.Click += new System.EventHandler(this.buttonRunRegex_Click);
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegex.Location = new System.Drawing.Point(6, 10);
            this.labelRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(195, 20);
            this.labelRegex.TabIndex = 0;
            this.labelRegex.Text = "Regular Expression Match";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 114);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(554, 696);
            this.textBoxSearch.TabIndex = 6;
            // 
            // labelCompareText
            // 
            this.labelCompareText.AutoSize = true;
            this.labelCompareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompareText.Location = new System.Drawing.Point(6, 89);
            this.labelCompareText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompareText.Name = "labelCompareText";
            this.labelCompareText.Size = new System.Drawing.Size(105, 20);
            this.labelCompareText.TabIndex = 5;
            this.labelCompareText.Text = "Text to match";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(688, 114);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(554, 696);
            this.textBoxResult.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(684, 89);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(63, 20);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Results";
            // 
            // labelRegexReplace
            // 
            this.labelRegexReplace.AutoSize = true;
            this.labelRegexReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegexReplace.Location = new System.Drawing.Point(684, 10);
            this.labelRegexReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegexReplace.Name = "labelRegexReplace";
            this.labelRegexReplace.Size = new System.Drawing.Size(210, 20);
            this.labelRegexReplace.TabIndex = 2;
            this.labelRegexReplace.Text = "Regular Expression Replace";
            this.labelRegexReplace.Visible = false;
            // 
            // textBoxRegexReplace
            // 
            this.textBoxRegexReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegexReplace.Location = new System.Drawing.Point(688, 35);
            this.textBoxRegexReplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRegexReplace.Name = "textBoxRegexReplace";
            this.textBoxRegexReplace.Size = new System.Drawing.Size(335, 26);
            this.textBoxRegexReplace.TabIndex = 3;
            this.textBoxRegexReplace.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelRegex);
            this.panel1.Controls.Add(this.groupBoxRegextype);
            this.panel1.Controls.Add(this.labelRegexReplace);
            this.panel1.Controls.Add(this.textBoxRegex);
            this.panel1.Controls.Add(this.textBoxRegexReplace);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.labelCompareText);
            this.panel1.Controls.Add(this.textBoxResult);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonRunRegex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 843);
            this.panel1.TabIndex = 10;
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 843);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRegex";
            this.Text = "Regex Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegextype.ResumeLayout(false);
            this.groupBoxRegextype.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMatch;
        private System.Windows.Forms.RadioButton radioButtonReplace;
        private System.Windows.Forms.GroupBox groupBoxRegextype;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Button buttonRunRegex;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelCompareText;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelRegexReplace;
        private System.Windows.Forms.TextBox textBoxRegexReplace;
        private System.Windows.Forms.Panel panel1;
    }
}

