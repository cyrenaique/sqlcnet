namespace sqlcnet
{
    partial class plotProfilesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.checkedListBox_Signal = new System.Windows.Forms.CheckedListBox();
            this.dg_test = new System.Windows.Forms.DataGridView();
            this.button_disp = new MaterialSkin.Controls.MaterialButton();
            this.button_stat = new MaterialSkin.Controls.MaterialButton();
            this.numericUpDown_sim = new System.Windows.Forms.NumericUpDown();
            this.dgv_sim = new System.Windows.Forms.DataGridView();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1317, 614);
            this.webBrowser1.TabIndex = 0;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.AutoSize = true;
            this.formsPlot1.Location = new System.Drawing.Point(11, 86);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(934, 547);
            this.formsPlot1.TabIndex = 1;
            // 
            // checkedListBox_Signal
            // 
            this.checkedListBox_Signal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_Signal.CheckOnClick = true;
            this.checkedListBox_Signal.FormattingEnabled = true;
            this.checkedListBox_Signal.Location = new System.Drawing.Point(951, 77);
            this.checkedListBox_Signal.Name = "checkedListBox_Signal";
            this.checkedListBox_Signal.Size = new System.Drawing.Size(333, 139);
            this.checkedListBox_Signal.TabIndex = 2;
            this.checkedListBox_Signal.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Signal_SelectedIndexChanged);
            // 
            // dg_test
            // 
            this.dg_test.AllowUserToAddRows = false;
            this.dg_test.AllowUserToDeleteRows = false;
            this.dg_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_test.Location = new System.Drawing.Point(379, 427);
            this.dg_test.Name = "dg_test";
            this.dg_test.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_test.Size = new System.Drawing.Size(240, 150);
            this.dg_test.TabIndex = 3;
            this.dg_test.Visible = false;
            // 
            // button_disp
            // 
            this.button_disp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_disp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_disp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_disp.Depth = 0;
            this.button_disp.HighEmphasis = true;
            this.button_disp.Icon = null;
            this.button_disp.Location = new System.Drawing.Point(1062, 225);
            this.button_disp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_disp.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_disp.Name = "button_disp";
            this.button_disp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_disp.Size = new System.Drawing.Size(91, 36);
            this.button_disp.TabIndex = 4;
            this.button_disp.Text = "HeatMap";
            this.button_disp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_disp.UseAccentColor = false;
            this.button_disp.UseVisualStyleBackColor = true;
            this.button_disp.Click += new System.EventHandler(this.button_disp_Click);
            // 
            // button_stat
            // 
            this.button_stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_stat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_stat.Depth = 0;
            this.button_stat.HighEmphasis = true;
            this.button_stat.Icon = null;
            this.button_stat.Location = new System.Drawing.Point(972, 318);
            this.button_stat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_stat.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_stat.Name = "button_stat";
            this.button_stat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_stat.Size = new System.Drawing.Size(117, 36);
            this.button_stat.TabIndex = 5;
            this.button_stat.Text = "Sim Profiles";
            this.button_stat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_stat.UseAccentColor = false;
            this.button_stat.UseVisualStyleBackColor = true;
            this.button_stat.Click += new System.EventHandler(this.button_stat_Click);
            // 
            // numericUpDown_sim
            // 
            this.numericUpDown_sim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sim.DecimalPlaces = 2;
            this.numericUpDown_sim.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown_sim.Location = new System.Drawing.Point(1141, 286);
            this.numericUpDown_sim.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numericUpDown_sim.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147418112});
            this.numericUpDown_sim.Name = "numericUpDown_sim";
            this.numericUpDown_sim.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_sim.TabIndex = 6;
            this.numericUpDown_sim.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            this.numericUpDown_sim.ValueChanged += new System.EventHandler(this.numericUpDown_sim_ValueChanged);
            // 
            // dgv_sim
            // 
            this.dgv_sim.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_sim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_sim.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sim.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_sim.Location = new System.Drawing.Point(1006, 363);
            this.dgv_sim.Name = "dgv_sim";
            this.dgv_sim.Size = new System.Drawing.Size(255, 288);
            this.dgv_sim.TabIndex = 8;
            this.dgv_sim.Visible = false;
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(1156, 329);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(51, 17);
            this.checkBoxSave.TabIndex = 9;
            this.checkBoxSave.Text = "Save";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(971, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(138, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "threshold Similarity";
            // 
            // plotProfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 681);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.dgv_sim);
            this.Controls.Add(this.numericUpDown_sim);
            this.Controls.Add(this.button_stat);
            this.Controls.Add(this.button_disp);
            this.Controls.Add(this.dg_test);
            this.Controls.Add(this.checkedListBox_Signal);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "plotProfilesForm";
            this.Text = "Plots";
            ((System.ComponentModel.ISupportInitialize)(this.dg_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        public ScottPlot.FormsPlot formsPlot1;
        public System.Windows.Forms.CheckedListBox checkedListBox_Signal;
        public System.Windows.Forms.DataGridView dg_test;
        private System.Windows.Forms.NumericUpDown numericUpDown_sim;
        private System.Windows.Forms.DataGridView dgv_sim;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private MaterialSkin.Controls.MaterialButton button_disp;
        private MaterialSkin.Controls.MaterialButton button_stat;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}