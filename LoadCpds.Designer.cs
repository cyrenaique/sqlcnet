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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.swap = new MaterialSkin.Controls.MaterialButton();
            this.search_tab = new System.Windows.Forms.TabPage();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.comboBox_mapping = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBox_fields = new MaterialSkin.Controls.MaterialComboBox();
            this.selectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.plot_results = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.y_combo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.x_combo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dGV_results = new System.Windows.Forms.DataGridView();
            this.dGV_cpds = new System.Windows.Forms.DataGridView();
            this.searchtb = new System.Windows.Forms.TabControl();
            this.profiles_tab = new System.Windows.Forms.TabPage();
            this.groupBox_way = new System.Windows.Forms.GroupBox();
            this.contains = new MaterialSkin.Controls.MaterialRadioButton();
            this.startswith_radioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.equal_radioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBoxGeneBatch = new System.Windows.Forms.GroupBox();
            this.radioButton_cpd = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButton_gene = new MaterialSkin.Controls.MaterialRadioButton();
            this.textBox_gene = new MaterialSkin.Controls.MaterialTextBox();
            this.plot_prof = new MaterialSkin.Controls.MaterialButton();
            this.get_profile = new MaterialSkin.Controls.MaterialButton();
            this.dGV_crisper = new System.Windows.Forms.DataGridView();
            this.search_all_tab = new System.Windows.Forms.TabPage();
            this.searchText = new MaterialSkin.Controls.MaterialTextBox();
            this.dGV_search = new System.Windows.Forms.DataGridView();
            this.search_all_db = new MaterialSkin.Controls.MaterialButton();
            this.compunds_tab = new System.Windows.Forms.TabPage();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.toolStrip1.SuspendLayout();
            this.search_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).BeginInit();
            this.searchtb.SuspendLayout();
            this.profiles_tab.SuspendLayout();
            this.groupBox_way.SuspendLayout();
            this.groupBoxGeneBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_crisper)).BeginInit();
            this.search_all_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_search)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1187, 25);
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
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
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
            this.swap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.swap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.swap.Depth = 0;
            this.swap.HighEmphasis = true;
            this.swap.Icon = null;
            this.swap.Location = new System.Drawing.Point(535, 218);
            this.swap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.swap.MouseState = MaterialSkin.MouseState.HOVER;
            this.swap.Name = "swap";
            this.swap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.swap.Size = new System.Drawing.Size(64, 36);
            this.swap.TabIndex = 21;
            this.swap.Text = "Swap";
            this.toolTip_swap.SetToolTip(this.swap, "Swap Data between the Grid View");
            this.swap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.swap.UseAccentColor = false;
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // search_tab
            // 
            this.search_tab.Controls.Add(this.comboBox_tables);
            this.search_tab.Controls.Add(this.comboBox_mapping);
            this.search_tab.Controls.Add(this.comboBox_fields);
            this.search_tab.Controls.Add(this.selectLabel);
            this.search_tab.Controls.Add(this.plot_results);
            this.search_tab.Controls.Add(this.materialLabel5);
            this.search_tab.Controls.Add(this.y_combo);
            this.search_tab.Controls.Add(this.materialLabel4);
            this.search_tab.Controls.Add(this.materialLabel1);
            this.search_tab.Controls.Add(this.x_combo);
            this.search_tab.Controls.Add(this.materialLabel2);
            this.search_tab.Controls.Add(this.swap);
            this.search_tab.Controls.Add(this.dGV_results);
            this.search_tab.Controls.Add(this.dGV_cpds);
            this.search_tab.Location = new System.Drawing.Point(4, 22);
            this.search_tab.Name = "search_tab";
            this.search_tab.Padding = new System.Windows.Forms.Padding(3);
            this.search_tab.Size = new System.Drawing.Size(1124, 518);
            this.search_tab.TabIndex = 0;
            this.search_tab.Text = "Meta Data";
            this.search_tab.UseVisualStyleBackColor = true;
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(759, 53);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tables.Sorted = true;
            this.comboBox_tables.TabIndex = 35;
            this.comboBox_tables.DropDownClosed += new System.EventHandler(this.comboBox_tables_DropDownClosed);
            // 
            // comboBox_mapping
            // 
            this.comboBox_mapping.AutoResize = false;
            this.comboBox_mapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_mapping.Depth = 0;
            this.comboBox_mapping.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_mapping.DropDownHeight = 174;
            this.comboBox_mapping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mapping.DropDownWidth = 121;
            this.comboBox_mapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox_mapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox_mapping.FormattingEnabled = true;
            this.comboBox_mapping.IntegralHeight = false;
            this.comboBox_mapping.ItemHeight = 43;
            this.comboBox_mapping.Location = new System.Drawing.Point(278, 25);
            this.comboBox_mapping.MaxDropDownItems = 4;
            this.comboBox_mapping.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox_mapping.Name = "comboBox_mapping";
            this.comboBox_mapping.Size = new System.Drawing.Size(202, 49);
            this.comboBox_mapping.Sorted = true;
            this.comboBox_mapping.StartIndex = 0;
            this.comboBox_mapping.TabIndex = 34;
            // 
            // comboBox_fields
            // 
            this.comboBox_fields.AutoResize = false;
            this.comboBox_fields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox_fields.Depth = 0;
            this.comboBox_fields.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_fields.DropDownHeight = 174;
            this.comboBox_fields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fields.DropDownWidth = 121;
            this.comboBox_fields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox_fields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox_fields.FormattingEnabled = true;
            this.comboBox_fields.IntegralHeight = false;
            this.comboBox_fields.ItemHeight = 43;
            this.comboBox_fields.Location = new System.Drawing.Point(21, 25);
            this.comboBox_fields.MaxDropDownItems = 4;
            this.comboBox_fields.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox_fields.Name = "comboBox_fields";
            this.comboBox_fields.Size = new System.Drawing.Size(224, 49);
            this.comboBox_fields.StartIndex = 0;
            this.comboBox_fields.TabIndex = 33;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Depth = 0;
            this.selectLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selectLabel.Location = new System.Drawing.Point(18, 3);
            this.selectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(103, 19);
            this.selectLabel.TabIndex = 27;
            this.selectLabel.Text = "Select Column";
            // 
            // plot_results
            // 
            this.plot_results.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plot_results.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.plot_results.Depth = 0;
            this.plot_results.HighEmphasis = true;
            this.plot_results.Icon = null;
            this.plot_results.Location = new System.Drawing.Point(461, 426);
            this.plot_results.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.plot_results.MouseState = MaterialSkin.MouseState.HOVER;
            this.plot_results.Name = "plot_results";
            this.plot_results.NoAccentTextColor = System.Drawing.Color.Empty;
            this.plot_results.Size = new System.Drawing.Size(123, 36);
            this.plot_results.TabIndex = 26;
            this.plot_results.Text = "plot results";
            this.plot_results.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.plot_results.UseAccentColor = false;
            this.plot_results.UseVisualStyleBackColor = true;
            this.plot_results.Click += new System.EventHandler(this.plot_results_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(261, 424);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(11, 19);
            this.materialLabel5.TabIndex = 32;
            this.materialLabel5.Text = "Y";
            // 
            // y_combo
            // 
            this.y_combo.AutoResize = false;
            this.y_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.y_combo.Depth = 0;
            this.y_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.y_combo.DropDownHeight = 174;
            this.y_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.y_combo.DropDownWidth = 121;
            this.y_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.y_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.y_combo.FormattingEnabled = true;
            this.y_combo.IntegralHeight = false;
            this.y_combo.ItemHeight = 43;
            this.y_combo.Location = new System.Drawing.Point(278, 420);
            this.y_combo.MaxDropDownItems = 4;
            this.y_combo.MouseState = MaterialSkin.MouseState.OUT;
            this.y_combo.Name = "y_combo";
            this.y_combo.Size = new System.Drawing.Size(121, 49);
            this.y_combo.StartIndex = 0;
            this.y_combo.TabIndex = 23;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(50, 426);
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
            this.materialLabel1.Location = new System.Drawing.Point(276, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Mapping Column";
            // 
            // x_combo
            // 
            this.x_combo.AutoResize = false;
            this.x_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.x_combo.Depth = 0;
            this.x_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.x_combo.DropDownHeight = 174;
            this.x_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.x_combo.DropDownWidth = 121;
            this.x_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.x_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.x_combo.FormattingEnabled = true;
            this.x_combo.IntegralHeight = false;
            this.x_combo.ItemHeight = 43;
            this.x_combo.Location = new System.Drawing.Point(67, 420);
            this.x_combo.MaxDropDownItems = 4;
            this.x_combo.MouseState = MaterialSkin.MouseState.OUT;
            this.x_combo.Name = "x_combo";
            this.x_combo.Size = new System.Drawing.Size(121, 49);
            this.x_combo.StartIndex = 0;
            this.x_combo.TabIndex = 22;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(770, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Choose Table";
            // 
            // dGV_results
            // 
            this.dGV_results.AllowUserToAddRows = false;
            this.dGV_results.AllowUserToDeleteRows = false;
            this.dGV_results.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_results.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_results.Location = new System.Drawing.Point(616, 85);
            this.dGV_results.Name = "dGV_results";
            this.dGV_results.Size = new System.Drawing.Size(483, 305);
            this.dGV_results.TabIndex = 0;
            this.dGV_results.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_results_CellDoubleClick);
            this.dGV_results.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_results_ColumnHeaderMouseDoubleClick);
            // 
            // dGV_cpds
            // 
            this.dGV_cpds.AllowDrop = true;
            this.dGV_cpds.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_cpds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_cpds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_cpds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_cpds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_cpds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_cpds.Location = new System.Drawing.Point(9, 85);
            this.dGV_cpds.Name = "dGV_cpds";
            this.dGV_cpds.Size = new System.Drawing.Size(504, 305);
            this.dGV_cpds.TabIndex = 0;
            this.dGV_cpds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGV_cpds_KeyDown);
            // 
            // searchtb
            // 
            this.searchtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtb.Controls.Add(this.search_tab);
            this.searchtb.Controls.Add(this.profiles_tab);
            this.searchtb.Controls.Add(this.search_all_tab);
            this.searchtb.Controls.Add(this.compunds_tab);
            this.searchtb.Location = new System.Drawing.Point(17, 92);
            this.searchtb.Name = "searchtb";
            this.searchtb.SelectedIndex = 0;
            this.searchtb.Size = new System.Drawing.Size(1132, 544);
            this.searchtb.TabIndex = 28;
            // 
            // profiles_tab
            // 
            this.profiles_tab.Controls.Add(this.groupBox_way);
            this.profiles_tab.Controls.Add(this.groupBoxGeneBatch);
            this.profiles_tab.Controls.Add(this.textBox_gene);
            this.profiles_tab.Controls.Add(this.plot_prof);
            this.profiles_tab.Controls.Add(this.get_profile);
            this.profiles_tab.Controls.Add(this.dGV_crisper);
            this.profiles_tab.Location = new System.Drawing.Point(4, 22);
            this.profiles_tab.Name = "profiles_tab";
            this.profiles_tab.Size = new System.Drawing.Size(1124, 518);
            this.profiles_tab.TabIndex = 1;
            this.profiles_tab.Text = "Profiles";
            this.profiles_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox_way
            // 
            this.groupBox_way.Controls.Add(this.contains);
            this.groupBox_way.Controls.Add(this.startswith_radioButton);
            this.groupBox_way.Controls.Add(this.equal_radioButton);
            this.groupBox_way.Location = new System.Drawing.Point(260, 88);
            this.groupBox_way.Name = "groupBox_way";
            this.groupBox_way.Size = new System.Drawing.Size(200, 142);
            this.groupBox_way.TabIndex = 19;
            this.groupBox_way.TabStop = false;
            this.groupBox_way.Text = "How search";
            // 
            // contains
            // 
            this.contains.AutoSize = true;
            this.contains.Depth = 0;
            this.contains.Location = new System.Drawing.Point(3, 102);
            this.contains.Margin = new System.Windows.Forms.Padding(0);
            this.contains.MouseLocation = new System.Drawing.Point(-1, -1);
            this.contains.MouseState = MaterialSkin.MouseState.HOVER;
            this.contains.Name = "contains";
            this.contains.Ripple = true;
            this.contains.Size = new System.Drawing.Size(96, 37);
            this.contains.TabIndex = 2;
            this.contains.TabStop = true;
            this.contains.Text = "contains";
            this.contains.UseVisualStyleBackColor = true;
            // 
            // startswith_radioButton
            // 
            this.startswith_radioButton.AutoSize = true;
            this.startswith_radioButton.Depth = 0;
            this.startswith_radioButton.Location = new System.Drawing.Point(3, 58);
            this.startswith_radioButton.Margin = new System.Windows.Forms.Padding(0);
            this.startswith_radioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.startswith_radioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startswith_radioButton.Name = "startswith_radioButton";
            this.startswith_radioButton.Ripple = true;
            this.startswith_radioButton.Size = new System.Drawing.Size(109, 37);
            this.startswith_radioButton.TabIndex = 1;
            this.startswith_radioButton.TabStop = true;
            this.startswith_radioButton.Text = "starts with";
            this.startswith_radioButton.UseVisualStyleBackColor = true;
            // 
            // equal_radioButton
            // 
            this.equal_radioButton.AutoSize = true;
            this.equal_radioButton.Checked = true;
            this.equal_radioButton.Depth = 0;
            this.equal_radioButton.Location = new System.Drawing.Point(3, 16);
            this.equal_radioButton.Margin = new System.Windows.Forms.Padding(0);
            this.equal_radioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.equal_radioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.equal_radioButton.Name = "equal_radioButton";
            this.equal_radioButton.Ripple = true;
            this.equal_radioButton.Size = new System.Drawing.Size(74, 37);
            this.equal_radioButton.TabIndex = 0;
            this.equal_radioButton.TabStop = true;
            this.equal_radioButton.Text = "equal";
            this.equal_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneBatch
            // 
            this.groupBoxGeneBatch.Controls.Add(this.radioButton_cpd);
            this.groupBoxGeneBatch.Controls.Add(this.radioButton_gene);
            this.groupBoxGeneBatch.Location = new System.Drawing.Point(14, 108);
            this.groupBoxGeneBatch.Name = "groupBoxGeneBatch";
            this.groupBoxGeneBatch.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGeneBatch.TabIndex = 18;
            this.groupBoxGeneBatch.TabStop = false;
            this.groupBoxGeneBatch.Text = "search in";
            // 
            // radioButton_cpd
            // 
            this.radioButton_cpd.AutoSize = true;
            this.radioButton_cpd.Depth = 0;
            this.radioButton_cpd.Location = new System.Drawing.Point(3, 63);
            this.radioButton_cpd.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_cpd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton_cpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton_cpd.Name = "radioButton_cpd";
            this.radioButton_cpd.Ripple = true;
            this.radioButton_cpd.Size = new System.Drawing.Size(119, 37);
            this.radioButton_cpd.TabIndex = 1;
            this.radioButton_cpd.TabStop = true;
            this.radioButton_cpd.Text = "compounds";
            this.radioButton_cpd.UseVisualStyleBackColor = true;
            // 
            // radioButton_gene
            // 
            this.radioButton_gene.AutoSize = true;
            this.radioButton_gene.Checked = true;
            this.radioButton_gene.Depth = 0;
            this.radioButton_gene.Location = new System.Drawing.Point(3, 16);
            this.radioButton_gene.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_gene.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButton_gene.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButton_gene.Name = "radioButton_gene";
            this.radioButton_gene.Ripple = true;
            this.radioButton_gene.Size = new System.Drawing.Size(71, 37);
            this.radioButton_gene.TabIndex = 0;
            this.radioButton_gene.TabStop = true;
            this.radioButton_gene.Text = "Gene";
            this.radioButton_gene.UseVisualStyleBackColor = true;
            // 
            // textBox_gene
            // 
            this.textBox_gene.AnimateReadOnly = false;
            this.textBox_gene.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gene.Depth = 0;
            this.textBox_gene.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_gene.LeadingIcon = null;
            this.textBox_gene.Location = new System.Drawing.Point(48, 23);
            this.textBox_gene.MaxLength = 50;
            this.textBox_gene.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_gene.Multiline = false;
            this.textBox_gene.Name = "textBox_gene";
            this.textBox_gene.Size = new System.Drawing.Size(313, 50);
            this.textBox_gene.TabIndex = 17;
            this.textBox_gene.Text = "";
            this.textBox_gene.TrailingIcon = null;
            // 
            // plot_prof
            // 
            this.plot_prof.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plot_prof.BackColor = System.Drawing.Color.RosyBrown;
            this.plot_prof.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.plot_prof.Depth = 0;
            this.plot_prof.ForeColor = System.Drawing.Color.Black;
            this.plot_prof.HighEmphasis = true;
            this.plot_prof.Icon = null;
            this.plot_prof.Location = new System.Drawing.Point(172, 283);
            this.plot_prof.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.plot_prof.MouseState = MaterialSkin.MouseState.HOVER;
            this.plot_prof.Name = "plot_prof";
            this.plot_prof.NoAccentTextColor = System.Drawing.Color.Empty;
            this.plot_prof.Size = new System.Drawing.Size(128, 36);
            this.plot_prof.TabIndex = 14;
            this.plot_prof.Text = "Plot Profiles";
            this.plot_prof.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.plot_prof.UseAccentColor = false;
            this.plot_prof.UseVisualStyleBackColor = false;
            this.plot_prof.Visible = false;
            this.plot_prof.Click += new System.EventHandler(this.plot_prof_Click);
            // 
            // get_profile
            // 
            this.get_profile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.get_profile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.get_profile.Depth = 0;
            this.get_profile.HighEmphasis = true;
            this.get_profile.Icon = null;
            this.get_profile.Location = new System.Drawing.Point(467, 146);
            this.get_profile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.get_profile.MouseState = MaterialSkin.MouseState.HOVER;
            this.get_profile.Name = "get_profile";
            this.get_profile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.get_profile.Size = new System.Drawing.Size(78, 36);
            this.get_profile.TabIndex = 6;
            this.get_profile.Text = "search";
            this.get_profile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.get_profile.UseAccentColor = false;
            this.get_profile.UseVisualStyleBackColor = true;
            this.get_profile.Click += new System.EventHandler(this.get_profile_Click);
            // 
            // dGV_crisper
            // 
            this.dGV_crisper.AllowUserToAddRows = false;
            this.dGV_crisper.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_crisper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_crisper.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dGV_crisper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_crisper.Location = new System.Drawing.Point(552, 34);
            this.dGV_crisper.Name = "dGV_crisper";
            this.dGV_crisper.Size = new System.Drawing.Size(550, 446);
            this.dGV_crisper.TabIndex = 2;
            this.dGV_crisper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search_all_tab
            // 
            this.search_all_tab.Controls.Add(this.searchText);
            this.search_all_tab.Controls.Add(this.dGV_search);
            this.search_all_tab.Controls.Add(this.search_all_db);
            this.search_all_tab.Location = new System.Drawing.Point(4, 22);
            this.search_all_tab.Name = "search_all_tab";
            this.search_all_tab.Padding = new System.Windows.Forms.Padding(3);
            this.search_all_tab.Size = new System.Drawing.Size(1124, 518);
            this.search_all_tab.TabIndex = 2;
            this.search_all_tab.Text = "search";
            this.search_all_tab.UseVisualStyleBackColor = true;
            // 
            // searchText
            // 
            this.searchText.AnimateReadOnly = false;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Depth = 0;
            this.searchText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchText.LeadingIcon = null;
            this.searchText.Location = new System.Drawing.Point(16, 75);
            this.searchText.MaxLength = 50;
            this.searchText.MouseState = MaterialSkin.MouseState.OUT;
            this.searchText.Multiline = false;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(225, 50);
            this.searchText.TabIndex = 3;
            this.searchText.Text = "";
            this.searchText.TrailingIcon = null;
            // 
            // dGV_search
            // 
            this.dGV_search.AllowUserToAddRows = false;
            this.dGV_search.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dGV_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_search.Location = new System.Drawing.Point(263, 20);
            this.dGV_search.Name = "dGV_search";
            this.dGV_search.Size = new System.Drawing.Size(855, 450);
            this.dGV_search.TabIndex = 2;
            // 
            // search_all_db
            // 
            this.search_all_db.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_all_db.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.search_all_db.Depth = 0;
            this.search_all_db.HighEmphasis = true;
            this.search_all_db.Icon = null;
            this.search_all_db.Location = new System.Drawing.Point(51, 145);
            this.search_all_db.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.search_all_db.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_all_db.Name = "search_all_db";
            this.search_all_db.NoAccentTextColor = System.Drawing.Color.Empty;
            this.search_all_db.Size = new System.Drawing.Size(119, 36);
            this.search_all_db.TabIndex = 0;
            this.search_all_db.Text = "Search in DB";
            this.search_all_db.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.search_all_db.UseAccentColor = false;
            this.search_all_db.UseVisualStyleBackColor = true;
            this.search_all_db.Click += new System.EventHandler(this.search_all_db_Click);
            // 
            // compunds_tab
            // 
            this.compunds_tab.Location = new System.Drawing.Point(4, 22);
            this.compunds_tab.Name = "compunds_tab";
            this.compunds_tab.Size = new System.Drawing.Size(1124, 518);
            this.compunds_tab.TabIndex = 3;
            this.compunds_tab.Text = "compounds";
            this.compunds_tab.UseVisualStyleBackColor = true;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // LoadCpdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 650);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoadCpdsForm";
            this.Text = "LoadCpds";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.search_tab.ResumeLayout(false);
            this.search_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_cpds)).EndInit();
            this.searchtb.ResumeLayout(false);
            this.profiles_tab.ResumeLayout(false);
            this.profiles_tab.PerformLayout();
            this.groupBox_way.ResumeLayout(false);
            this.groupBox_way.PerformLayout();
            this.groupBoxGeneBatch.ResumeLayout(false);
            this.groupBoxGeneBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_crisper)).EndInit();
            this.search_all_tab.ResumeLayout(false);
            this.search_all_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_search)).EndInit();
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
        private System.Windows.Forms.TabPage search_tab;
        private MaterialSkin.Controls.MaterialLabel selectLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dGV_results;
        private System.Windows.Forms.DataGridView dGV_crisper;
        private System.Windows.Forms.TabPage search_all_tab;
        public System.Windows.Forms.DataGridView dGV_search;
        public System.Windows.Forms.TabControl searchtb;
        public System.Windows.Forms.TabPage profiles_tab;
        private System.Windows.Forms.TabPage compunds_tab;
        private MaterialSkin.Controls.MaterialComboBox comboBox_mapping;
        private MaterialSkin.Controls.MaterialComboBox comboBox_fields;
        private MaterialSkin.Controls.MaterialComboBox y_combo;
        private MaterialSkin.Controls.MaterialComboBox x_combo;
        private MaterialSkin.Controls.MaterialButton plot_results;
        private MaterialSkin.Controls.MaterialButton swap;
        public MaterialSkin.Controls.MaterialButton search_all_db;
        private MaterialSkin.Controls.MaterialButton get_profile;
        private MaterialSkin.Controls.MaterialButton plot_prof;
        private MaterialSkin.Controls.MaterialTextBox textBox_gene;
        private System.Windows.Forms.GroupBox groupBox_way;
        private MaterialSkin.Controls.MaterialRadioButton contains;
        private MaterialSkin.Controls.MaterialRadioButton startswith_radioButton;
        private MaterialSkin.Controls.MaterialRadioButton equal_radioButton;
        private System.Windows.Forms.GroupBox groupBoxGeneBatch;
        private MaterialSkin.Controls.MaterialRadioButton radioButton_cpd;
        private MaterialSkin.Controls.MaterialRadioButton radioButton_gene;
        private MaterialSkin.Controls.MaterialTextBox searchText;
        public System.Windows.Forms.DataGridView dGV_cpds;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.ComboBox comboBox_tables;
    }
}