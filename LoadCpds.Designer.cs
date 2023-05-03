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
            this.toolTip_swap = new System.Windows.Forms.ToolTip(this.components);
            this.swap = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TabPage();
            this.selectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.plot_results = new System.Windows.Forms.Button();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.y_combo = new System.Windows.Forms.ComboBox();
            this.comboBox_fields = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.x_combo = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox_mapping = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dGV_results = new System.Windows.Forms.DataGridView();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.dGV_cpds = new System.Windows.Forms.DataGridView();
            this.searchtb = new System.Windows.Forms.TabControl();
            this.profiles = new System.Windows.Forms.TabPage();
            this.dGV_corr = new System.Windows.Forms.DataGridView();
            this.pltcorr = new System.Windows.Forms.Button();
            this.dGV_crisper = new System.Windows.Forms.DataGridView();
            this.textBox_gene = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGV_search = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search_2 = new System.Windows.Forms.Button();
            this.find_gene = new System.Windows.Forms.Button();
            this.dGV_cpd = new System.Windows.Forms.DataGridView();
            this.contains = new System.Windows.Forms.RadioButton();
            this.equal_radioButton = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).BeginInit();
            this.searchtb.SuspendLayout();
            this.profiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_corr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_crisper)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpd)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(3, 64);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 25);
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
            // swap
            // 
            this.swap.Location = new System.Drawing.Point(674, 247);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(75, 23);
            this.swap.TabIndex = 21;
            this.swap.Text = "Swap";
            this.toolTip_swap.SetToolTip(this.swap, "Swap Data between the Grid View");
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // search
            // 
            this.search.Controls.Add(this.selectLabel);
            this.search.Controls.Add(this.plot_results);
            this.search.Controls.Add(this.materialLabel5);
            this.search.Controls.Add(this.y_combo);
            this.search.Controls.Add(this.comboBox_fields);
            this.search.Controls.Add(this.materialLabel4);
            this.search.Controls.Add(this.materialLabel1);
            this.search.Controls.Add(this.x_combo);
            this.search.Controls.Add(this.materialLabel3);
            this.search.Controls.Add(this.comboBox_mapping);
            this.search.Controls.Add(this.materialLabel2);
            this.search.Controls.Add(this.searchBox);
            this.search.Controls.Add(this.swap);
            this.search.Controls.Add(this.dGV_results);
            this.search.Controls.Add(this.comboBox_tables);
            this.search.Controls.Add(this.dGV_cpds);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(1382, 623);
            this.search.TabIndex = 0;
            this.search.Text = "Meta Data";
            this.search.UseVisualStyleBackColor = true;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Depth = 0;
            this.selectLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectLabel.Location = new System.Drawing.Point(6, 21);
            this.selectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(103, 19);
            this.selectLabel.TabIndex = 27;
            this.selectLabel.Text = "Select Column";
            // 
            // plot_results
            // 
            this.plot_results.Location = new System.Drawing.Point(469, 572);
            this.plot_results.Name = "plot_results";
            this.plot_results.Size = new System.Drawing.Size(75, 23);
            this.plot_results.TabIndex = 26;
            this.plot_results.Text = "plot results";
            this.plot_results.UseVisualStyleBackColor = true;
            this.plot_results.Click += new System.EventHandler(this.plot_results_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(84, 572);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(11, 19);
            this.materialLabel5.TabIndex = 32;
            this.materialLabel5.Text = "Y";
            // 
            // y_combo
            // 
            this.y_combo.FormattingEnabled = true;
            this.y_combo.Location = new System.Drawing.Point(101, 572);
            this.y_combo.Name = "y_combo";
            this.y_combo.Size = new System.Drawing.Size(121, 21);
            this.y_combo.TabIndex = 23;
            // 
            // comboBox_fields
            // 
            this.comboBox_fields.FormattingEnabled = true;
            this.comboBox_fields.Location = new System.Drawing.Point(9, 43);
            this.comboBox_fields.Name = "comboBox_fields";
            this.comboBox_fields.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fields.TabIndex = 15;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(297, 574);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(11, 19);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "X";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(274, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Mapping Column";
            // 
            // x_combo
            // 
            this.x_combo.FormattingEnabled = true;
            this.x_combo.Location = new System.Drawing.Point(314, 574);
            this.x_combo.Name = "x_combo";
            this.x_combo.Size = new System.Drawing.Size(121, 21);
            this.x_combo.TabIndex = 22;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(1086, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "SearchBox";
            // 
            // comboBox_mapping
            // 
            this.comboBox_mapping.FormattingEnabled = true;
            this.comboBox_mapping.Location = new System.Drawing.Point(276, 42);
            this.comboBox_mapping.Name = "comboBox_mapping";
            this.comboBox_mapping.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mapping.Sorted = true;
            this.comboBox_mapping.TabIndex = 19;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(840, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Choose Table";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1089, 43);
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
            this.dGV_results.Location = new System.Drawing.Point(774, 83);
            this.dGV_results.Name = "dGV_results";
            this.dGV_results.Size = new System.Drawing.Size(584, 414);
            this.dGV_results.TabIndex = 0;
            this.dGV_results.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_results_CellDoubleClick);
            this.dGV_results.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_results_ColumnHeaderMouseDoubleClick);
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(843, 43);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tables.Sorted = true;
            this.comboBox_tables.TabIndex = 14;
            this.comboBox_tables.DropDownClosed += new System.EventHandler(this.comboBox_tables_DropDownClosed);
            // 
            // dGV_cpds
            // 
            this.dGV_cpds.AllowUserToAddRows = false;
            this.dGV_cpds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_cpds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_cpds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_cpds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_cpds.Location = new System.Drawing.Point(9, 83);
            this.dGV_cpds.Name = "dGV_cpds";
            this.dGV_cpds.Size = new System.Drawing.Size(659, 414);
            this.dGV_cpds.TabIndex = 0;
            // 
            // searchtb
            // 
            this.searchtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtb.Controls.Add(this.search);
            this.searchtb.Controls.Add(this.profiles);
            this.searchtb.Controls.Add(this.tabPage1);
            this.searchtb.Location = new System.Drawing.Point(17, 92);
            this.searchtb.Name = "searchtb";
            this.searchtb.SelectedIndex = 0;
            this.searchtb.Size = new System.Drawing.Size(1390, 649);
            this.searchtb.TabIndex = 28;
            // 
            // profiles
            // 
            this.profiles.Controls.Add(this.equal_radioButton);
            this.profiles.Controls.Add(this.contains);
            this.profiles.Controls.Add(this.dGV_cpd);
            this.profiles.Controls.Add(this.find_gene);
            this.profiles.Controls.Add(this.dGV_corr);
            this.profiles.Controls.Add(this.pltcorr);
            this.profiles.Controls.Add(this.dGV_crisper);
            this.profiles.Controls.Add(this.textBox_gene);
            this.profiles.Location = new System.Drawing.Point(4, 22);
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(1382, 623);
            this.profiles.TabIndex = 1;
            this.profiles.Text = "Profiles";
            this.profiles.UseVisualStyleBackColor = true;
            // 
            // dGV_corr
            // 
            this.dGV_corr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_corr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_corr.Location = new System.Drawing.Point(687, 59);
            this.dGV_corr.Name = "dGV_corr";
            this.dGV_corr.Size = new System.Drawing.Size(602, 500);
            this.dGV_corr.TabIndex = 5;
            // 
            // pltcorr
            // 
            this.pltcorr.Location = new System.Drawing.Point(160, 563);
            this.pltcorr.Name = "pltcorr";
            this.pltcorr.Size = new System.Drawing.Size(158, 23);
            this.pltcorr.TabIndex = 4;
            this.pltcorr.Text = "plot heatmap";
            this.pltcorr.UseVisualStyleBackColor = true;
            // 
            // dGV_crisper
            // 
            this.dGV_crisper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_crisper.Location = new System.Drawing.Point(14, 82);
            this.dGV_crisper.Name = "dGV_crisper";
            this.dGV_crisper.Size = new System.Drawing.Size(455, 176);
            this.dGV_crisper.TabIndex = 2;
            this.dGV_crisper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_gene
            // 
            this.textBox_gene.Location = new System.Drawing.Point(42, 35);
            this.textBox_gene.Name = "textBox_gene";
            this.textBox_gene.Size = new System.Drawing.Size(195, 20);
            this.textBox_gene.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGV_search);
            this.tabPage1.Controls.Add(this.searchText);
            this.tabPage1.Controls.Add(this.search_2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1382, 623);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGV_search
            // 
            this.dGV_search.AllowUserToAddRows = false;
            this.dGV_search.AllowUserToDeleteRows = false;
            this.dGV_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_search.Location = new System.Drawing.Point(382, 27);
            this.dGV_search.Name = "dGV_search";
            this.dGV_search.Size = new System.Drawing.Size(976, 542);
            this.dGV_search.TabIndex = 2;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(74, 49);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 1;
            // 
            // search_2
            // 
            this.search_2.Location = new System.Drawing.Point(220, 44);
            this.search_2.Name = "search_2";
            this.search_2.Size = new System.Drawing.Size(81, 28);
            this.search_2.TabIndex = 0;
            this.search_2.Text = "SearchDB";
            this.search_2.UseVisualStyleBackColor = true;
            this.search_2.Click += new System.EventHandler(this.search_2_Click);

            // 
            // find_gene
            // 
            this.find_gene.Location = new System.Drawing.Point(394, 32);
            this.find_gene.Name = "find_gene";
            this.find_gene.Size = new System.Drawing.Size(75, 23);
            this.find_gene.TabIndex = 6;
            this.find_gene.Text = "search";
            this.find_gene.UseVisualStyleBackColor = true;
            this.find_gene.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_cpd
            // 
            this.dGV_cpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_cpd.Location = new System.Drawing.Point(14, 277);
            this.dGV_cpd.Name = "dGV_cpd";
            this.dGV_cpd.Size = new System.Drawing.Size(455, 257);
            this.dGV_cpd.TabIndex = 7;
            // 
            // contains
            // 
            this.contains.AutoSize = true;
            this.contains.Location = new System.Drawing.Point(266, 32);
            this.contains.Name = "contains";
            this.contains.Size = new System.Drawing.Size(65, 17);
            this.contains.TabIndex = 8;
            this.contains.Text = "contains";
            this.contains.UseVisualStyleBackColor = true;
            // 
            // equal_radioButton
            // 
            this.equal_radioButton.AutoSize = true;
            this.equal_radioButton.Checked = true;
            this.equal_radioButton.Location = new System.Drawing.Point(267, 55);
            this.equal_radioButton.Name = "equal_radioButton";
            this.equal_radioButton.Size = new System.Drawing.Size(51, 17);
            this.equal_radioButton.TabIndex = 9;
            this.equal_radioButton.TabStop = true;
            this.equal_radioButton.Text = "equal";
            this.equal_radioButton.UseVisualStyleBackColor = true;

            // 
            // LoadCpdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 755);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoadCpdsForm";
            this.Text = "LoadCpds";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).EndInit();
            this.searchtb.ResumeLayout(false);
            this.profiles.ResumeLayout(false);
            this.profiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_corr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_crisper)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pathwaysToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_swap;
        private System.Windows.Forms.TabPage search;
        private MaterialSkin.Controls.MaterialLabel selectLabel;
        private System.Windows.Forms.Button plot_results;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox y_combo;
        private System.Windows.Forms.ComboBox comboBox_fields;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox x_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBox_mapping;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.DataGridView dGV_results;
        private System.Windows.Forms.ComboBox comboBox_tables;
        public System.Windows.Forms.DataGridView dGV_cpds;
        private System.Windows.Forms.TabControl searchtb;
        private System.Windows.Forms.TabPage profiles;
        private System.Windows.Forms.DataGridView dGV_crisper;
        private System.Windows.Forms.TextBox textBox_gene;
        private System.Windows.Forms.DataGridView dGV_corr;
        private System.Windows.Forms.Button pltcorr;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox searchText;
        public System.Windows.Forms.Button search_2;
        public System.Windows.Forms.DataGridView dGV_search;
        private System.Windows.Forms.Button find_gene;
        private System.Windows.Forms.DataGridView dGV_cpd;
        private System.Windows.Forms.RadioButton equal_radioButton;
        private System.Windows.Forms.RadioButton contains;
    }
}