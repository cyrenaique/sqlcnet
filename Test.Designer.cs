﻿namespace sqlcnet
{
    partial class TestForm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.checkedListBox_Signal = new System.Windows.Forms.CheckedListBox();
            this.dg_test = new System.Windows.Forms.DataGridView();
            this.button_disp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(999, 523);
            this.webBrowser1.TabIndex = 0;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.AutoSize = true;
            this.formsPlot1.Location = new System.Drawing.Point(28, 22);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(730, 444);
            this.formsPlot1.TabIndex = 1;
            // 
            // checkedListBox_Signal
            // 
            this.checkedListBox_Signal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkedListBox_Signal.CheckOnClick = true;
            this.checkedListBox_Signal.FormattingEnabled = true;
            this.checkedListBox_Signal.Location = new System.Drawing.Point(831, 34);
            this.checkedListBox_Signal.Name = "checkedListBox_Signal";
            this.checkedListBox_Signal.Size = new System.Drawing.Size(138, 64);
            this.checkedListBox_Signal.TabIndex = 2;
            this.checkedListBox_Signal.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Signal_SelectedIndexChanged);
            // 
            // dg_test
            // 
            this.dg_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_test.Location = new System.Drawing.Point(757, 334);
            this.dg_test.Name = "dg_test";
            this.dg_test.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_test.Size = new System.Drawing.Size(240, 150);
            this.dg_test.TabIndex = 3;
            this.dg_test.Visible = false;
            // 
            // button_disp
            // 
            this.button_disp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_disp.Location = new System.Drawing.Point(894, 219);
            this.button_disp.Name = "button_disp";
            this.button_disp.Size = new System.Drawing.Size(75, 23);
            this.button_disp.TabIndex = 4;
            this.button_disp.Text = "HeatMap";
            this.button_disp.UseVisualStyleBackColor = true;
            this.button_disp.Click += new System.EventHandler(this.button_disp_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.button_disp);
            this.Controls.Add(this.dg_test);
            this.Controls.Add(this.checkedListBox_Signal);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "TestForm";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        public ScottPlot.FormsPlot formsPlot1;
        public System.Windows.Forms.CheckedListBox checkedListBox_Signal;
        public System.Windows.Forms.DataGridView dg_test;
        private System.Windows.Forms.Button button_disp;
    }
}