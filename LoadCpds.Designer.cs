namespace sqlcnet
{
    partial class LoadCpdsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadCpdsForm));
            this.dGV_cpds = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pathwaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_fields = new System.Windows.Forms.ComboBox();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dGV_results = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_mapping = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.swap = new System.Windows.Forms.Button();
            this.toolTip_swap = new System.Windows.Forms.ToolTip(this.components);
            this.x_combo = new System.Windows.Forms.ComboBox();
            this.y_combo = new System.Windows.Forms.ComboBox();
            this.x_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.plot_results = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_cpds
            // 
            this.dGV_cpds.AllowUserToAddRows = false;
            this.dGV_cpds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_cpds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_cpds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_cpds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_cpds.Location = new System.Drawing.Point(12, 134);
            this.dGV_cpds.Name = "dGV_cpds";
            this.dGV_cpds.Size = new System.Drawing.Size(669, 486);
            this.dGV_cpds.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1532, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathwaysToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // pathwaysToolStripMenuItem
            // 
            this.pathwaysToolStripMenuItem.Name = "pathwaysToolStripMenuItem";
            this.pathwaysToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pathwaysToolStripMenuItem.Text = "Pathways";
            this.pathwaysToolStripMenuItem.Click += new System.EventHandler(this.pathwaysToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1044, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Column";
            // 
            // comboBox_fields
            // 
            this.comboBox_fields.FormattingEnabled = true;
            this.comboBox_fields.Location = new System.Drawing.Point(121, 57);
            this.comboBox_fields.Name = "comboBox_fields";
            this.comboBox_fields.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fields.TabIndex = 15;
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(1030, 57);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tables.Sorted = true;
            this.comboBox_tables.TabIndex = 14;
            this.comboBox_tables.DropDownClosed += new System.EventHandler(this.comboBox_tables_DropDownClosed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1388, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SearchBox";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1371, 112);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dGV_results
            // 
            this.dGV_results.AllowUserToAddRows = false;
            this.dGV_results.AllowUserToDeleteRows = false;
            this.dGV_results.AllowUserToOrderColumns = true;
            this.dGV_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_results.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_results.Location = new System.Drawing.Point(719, 134);
            this.dGV_results.Name = "dGV_results";
            this.dGV_results.Size = new System.Drawing.Size(752, 486);
            this.dGV_results.TabIndex = 0;
            this.dGV_results.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_results_CellDoubleClick);
            this.dGV_results.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_results_ColumnHeaderMouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1051, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data In DB";
            // 
            // comboBox_mapping
            // 
            this.comboBox_mapping.FormattingEnabled = true;
            this.comboBox_mapping.Location = new System.Drawing.Point(342, 57);
            this.comboBox_mapping.Name = "comboBox_mapping";
            this.comboBox_mapping.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mapping.Sorted = true;
            this.comboBox_mapping.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mapping column";
            // 
            // swap
            // 
            this.swap.Location = new System.Drawing.Point(667, 86);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(75, 23);
            this.swap.TabIndex = 21;
            this.swap.Text = "Swap";
            this.toolTip_swap.SetToolTip(this.swap, "Swap Data between the Grid View");
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // x_combo
            // 
            this.x_combo.FormattingEnabled = true;
            this.x_combo.Location = new System.Drawing.Point(1264, 646);
            this.x_combo.Name = "x_combo";
            this.x_combo.Size = new System.Drawing.Size(121, 21);
            this.x_combo.TabIndex = 22;
            // 
            // y_combo
            // 
            this.y_combo.FormattingEnabled = true;
            this.y_combo.Location = new System.Drawing.Point(1264, 673);
            this.y_combo.Name = "y_combo";
            this.y_combo.Size = new System.Drawing.Size(121, 21);
            this.y_combo.TabIndex = 23;
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(1207, 649);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 13);
            this.x_label.TabIndex = 24;
            this.x_label.Text = "X";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(1207, 676);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(14, 13);
            this.y_label.TabIndex = 25;
            this.y_label.Text = "Y";
            // 
            // plot_results
            // 
            this.plot_results.Location = new System.Drawing.Point(1412, 666);
            this.plot_results.Name = "plot_results";
            this.plot_results.Size = new System.Drawing.Size(75, 23);
            this.plot_results.TabIndex = 26;
            this.plot_results.Text = "plot results";
            this.plot_results.UseVisualStyleBackColor = true;
            this.plot_results.Click += new System.EventHandler(this.plot_results_Click);
            // 
            // LoadCpdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 856);
            this.Controls.Add(this.plot_results);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.y_combo);
            this.Controls.Add(this.x_combo);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_mapping);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_fields);
            this.Controls.Add(this.comboBox_tables);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dGV_results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dGV_cpds);
            this.Name = "LoadCpdsForm";
            this.Text = "LoadCpds";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dGV_cpds;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_fields;
        private System.Windows.Forms.ComboBox comboBox_tables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dGV_results;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_mapping;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pathwaysToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_swap;
        private System.Windows.Forms.ComboBox x_combo;
        private System.Windows.Forms.ComboBox y_combo;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Button plot_results;
    }
}