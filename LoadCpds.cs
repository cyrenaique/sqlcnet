﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using LumenWorks.Framework.IO.Csv;
using Npgsql;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using CefSharp.DevTools.Profiler;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ScottPlot;
using ScottPlot.Palettes;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace sqlcnet
{

    public partial class LoadCpdsForm : MaterialForm
    {
        DataTable dt;
        CachedCsvReader csv;

        public HelpForm HelpF;
        public NpgsqlConnection conn_meta, conn_profile;
        readonly string cs_meta = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksi_cpds; Password=12345";
        readonly string cs_profile = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksilink_cpds; Password=12345";
        public GKForm f2;
        public LoadCpdsForm f_cpds;
        public plotProfilesForm TF;
        string cmb, cmb2;
        protected DataGridView MyDgv;
        public DataTable tbl_profiles;
        //public DataTable tbl_profiles { get; } = new DataTable();

        public LoadCpdsForm()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dGV_cpds.Visible = true;
            dGV_results.Visible = false;

            //comboBox_tables----------------------------------------------
            conn_meta = new NpgsqlConnection(cs_meta);
            if (conn_meta.State == ConnectionState.Closed)
            {
                conn_meta.Open();
            }

            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = conn_meta,
                CommandType = CommandType.Text,
                CommandText = "select table_name from information_schema.tables where table_schema='public'"
            };
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt = new DataTable();
                dt.Load(reader);
                //dt.DefaultView.Sort = dt.Columns[0].ColumnName;
                comboBox_tables.DataSource = dt;
                comboBox_tables.ValueMember = dt.Columns[0].ColumnName;

            }

            comboBox_tables.Sorted = true;

            //comboBox_mapping----------------------------------------------
            cmd.CommandText = "SELECT column_name, table_name FROM information_schema.columns WHERE table_schema = 'public'";
            NpgsqlDataReader columnReader = cmd.ExecuteReader();
            List<string> columnNames = new List<string>();

            // Loop through the columns and add their names to the List
            while (columnReader.Read())
            {
                string columnName = columnReader.GetString(0); // get the name of the column from the first column of the column reader
                columnNames.Add($"{columnName}"); // add the column name to the List, including the table name as a prefix
            }
            List<string> unique_items = new HashSet<string>(columnNames).ToList();

            columnReader.Close();
            comboBox_mapping.DataSource = unique_items;

            cmd.Dispose();

        }
        // -----------------------------------------------------------
        // tab 1
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.Text = openFileDialog1.FileName;
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                System.IO.StreamReader sr = new System.IO.StreamReader(fs);
                csv = new CachedCsvReader(sr, true);

            }
            dGV_cpds.DataSource = csv;
            dGV_cpds.Visible = true;
            List<string> columns_name = new List<string>();
            for (var i = 0; i < dGV_cpds.ColumnCount; i++)
            {
                columns_name.Add(dGV_cpds.Columns[i].HeaderText);

            }
            comboBox_fields.DataSource = columns_name;
            foreach (DataGridViewRow row in dGV_cpds.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            HelpF = new HelpForm();
            HelpF.Show();
        }

        public string Find_Info(string Path)
        {
            HttpWebRequest req2 = WebRequest.Create(string.Format("http://rest.kegg.jp/get/" + Path)) as HttpWebRequest;
            req2.Method = "GET";

            HttpWebResponse response = req2.GetResponse() as HttpWebResponse;
            StreamReader reader2 = new StreamReader(response.GetResponseStream());

            string GenInfo = reader2.ReadToEnd();
            reader2.Close();

            return GenInfo;
        }

        private void dGV_results_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                string gene_txt = dGV_results.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                List<string> columns_name = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();
                if (columns_name[e.ColumnIndex].Contains("pathid"))
                {
                    f2 = new GKForm();
                    List<string> sel = new List<string>();
                    Dictionary<string, List<string>> pathway_genes = new Dictionary<string, List<string>>();
                    foreach (DataGridViewRow row in dGV_results.Rows)
                    {
                        if (row.Cells[e.ColumnIndex].Value.ToString() == gene_txt)
                        {
                            sel.Add(row.Cells[1].Value.ToString());

                        }

                    }
                    List<string> unique_items = new HashSet<string>(sel).ToList();
                    string string_path = "http://www.kegg.jp/kegg-bin/show_pathway?" + gene_txt + "/default%3dpink/";
                    foreach (string item in unique_items)
                    {
                        string_path += item + "+";

                    }
                    string_path += "%09,blue";
                    ChromiumWebBrowser browser = new ChromiumWebBrowser(string_path);
                    f2.toolStripContainer1.ContentPanel.Controls.Add(browser);
                    f2.Show();
                    //pathway_genes.Add(gene_txt, unique_items);


                }
                if (columns_name[e.ColumnIndex].Contains("kegg") | columns_name[e.ColumnIndex].Contains("pathid")
                    | columns_name[e.ColumnIndex].Contains("geneid") | columns_name[e.ColumnIndex].Contains("disid"))
                {
                    f2 = new GKForm();
                    ChromiumWebBrowser browser = new ChromiumWebBrowser("https://www.genome.jp/entry/" + gene_txt);
                    if (gene_txt.Contains("REACT"))
                    {
                        gene_txt = gene_txt.Replace("REACT:", "");
                        browser = new ChromiumWebBrowser("https://reactome.org/PathwayBrowser/#/" + gene_txt);
                    }
                    if (gene_txt.Contains("MESH"))
                    {
                        gene_txt = gene_txt.Replace("MESH:", "");
                        browser = new ChromiumWebBrowser("https://id.nlm.nih.gov/mesh//" + gene_txt);
                    }

                    f2.toolStripContainer1.ContentPanel.Controls.Add(browser);
                    f2.Show();
                }

                else
                {
                    f2 = new GKForm();
                    ChromiumWebBrowser browser = new ChromiumWebBrowser("https://pubchem.ncbi.nlm.nih.gov/compound/" + gene_txt);
                    f2.toolStripContainer1.ContentPanel.Controls.Add(browser);
                    f2.Show();
                }

            }

        }

        private void save_results(DataTable dt_to_save, string name)
        {

            if (dt_to_save.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = name + ".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            StringBuilder sb = new StringBuilder();

                            string[] columnNames = dt_to_save.Columns.Cast<DataColumn>().
                                                          Select(column => column.ColumnName).
                                                          ToArray();
                            sb.AppendLine(string.Join(",", columnNames));

                            foreach (DataRow row in dt_to_save.Rows)
                            {
                                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                            ToArray();
                                sb.AppendLine(string.Join(",", fields));
                            }


                            File.WriteAllText(sfd.FileName, sb.ToString());

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }


        private void comboBox_tables_DropDownClosed(object sender, EventArgs e)
        {
            //comboBox_tables.Sorted = true;
            cmb = comboBox_tables.GetItemText(comboBox_tables.SelectedItem);
            conn_meta.Close();
            if (conn_meta.State == ConnectionState.Closed)
            {
                conn_meta.Open();
            }

            string sql2 = "select * from " + cmb; ;

            NpgsqlCommand command2 = new NpgsqlCommand(sql2, conn_meta);
            Npgsql.NpgsqlDataReader Resource = command2.ExecuteReader();
            List<string> col_list = new List<string>();
            while (Resource.Read())
            {
                for (int i = 0; i < Resource.FieldCount; i++)
                {
                    col_list.Add(Resource.GetName(i).ToString());
                }
                break;
            }



            List<string> list_res_data = new List<string>();
            string val_combo = comboBox_fields.GetItemText(comboBox_fields.SelectedItem);
            cmb2 = comboBox_mapping.GetItemText(comboBox_mapping.SelectedItem);
            dGV_results.Visible = true;
            dGV_cpds.AllowUserToAddRows = false; ;
            if (col_list.Contains(cmb2))
            {
                foreach (DataGridViewRow row in dGV_cpds.Rows)
                {
                    if (row.Cells[val_combo].Value != null)
                    {
                        list_res_data.Add(row.Cells[val_combo].Value.ToString());

                    }

                   
                }

                List<string> unique_items = new HashSet<string>(list_res_data).ToList();

                // Define the SQL query using a parameterized query with the IN operator
                string sql = "SELECT * FROM " + cmb + " WHERE " + cmb2 + " IN (";


                if (cmb == "genedis")
                {
                    sql = "select  disease.name as disease_Name, gene.symbol as Gene_symbol ,gene.chromosome,genedis.* " +
                        "from genedis" +
                        " inner join disease on genedis.disid=disease.disid" +
                        "  inner join gene on genedis.geneid=gene.geneid " +
                        " WHERE  genedis." + cmb2 + " IN (";
                }
                else if (cmb == "cpdgene")
                {
                    sql = "select  cpd.name as Compound_Name, gene.symbol as Gene_symbol ,gene.chromosome,cpdgene.*" +
                        "  from cpdgene" +
                        "  inner join cpd on cpdgene.pubchemid=cpd.pubchemid" +
                        "  inner join gene on cpdgene.geneid=gene.geneid " +
                        " WHERE  cpdgene." + cmb2 + " IN (";
                }
                else if (cmb == "cpdpath")
                {
                    sql = "select  cpd.name as Compound_Name, pathway.name as Pathway_Name ,cpdpath.*" +
                        " from cpdpath " +
                        " inner join cpd on cpdpath.pubchemid=cpd.pubchemid " +
                        " inner join pathway on cpdpath.pathid=pathway.pathid " +
                        " WHERE  cpdpath." + cmb2 + " IN (";
                }

                else if (cmb == "cpddis")
                {
                    sql = "select   cpd.name as Compound_Name ,disease.name as disease_Name , cpddis.* " +
                        "from cpddis " +
                        "inner join cpd on cpddis.pubchemid=cpd.pubchemid " +
                        "inner join disease on cpddis.disid=disease.disid " +
                        " WHERE  cpddis." + cmb2 + " IN (";
                }
                else if (cmb == "genepath")
                {
                    sql = "select pathway.name as Pathway_Name ,gene.symbol as Gene_Symbol,gene.chromosome, genepath.*" +
                        " from genepath  inner join pathway on genepath.pathid=pathway.pathid " +
                        " inner join gene on genepath.geneid=gene.geneid " +
                        " WHERE  genepath." + cmb2 + " IN (";
                }

                // Add a parameter placeholder for each value in the stringList
                for (int i = 0; i < unique_items.Count; i++)
                {
                    //sql += $"@param{i}";
                    sql += "'" + unique_items[i] + "'";

                    if (i != unique_items.Count - 1)
                    {
                        sql += ",";
                    }
                }

                sql += ")";


                conn_meta.Close();
                conn_meta.Open();
                dt = new DataTable();
                NpgsqlCommand command = new NpgsqlCommand(sql, conn_meta);
                // Execute the query and retrieve the results
                //if (conn.State == ConnectionState.Closed)
                //{

                // }
                NpgsqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(reader);
                dGV_results.DataSource = dt;

                foreach (DataGridViewRow row in dGV_results.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
                //MessageBox.Show("Done");
                // add col to x_combo and y_combo
                foreach (DataGridViewColumn col in dGV_results.Columns)
                {
                    x_combo.Items.Add(col.HeaderText);
                    y_combo.Items.Add(col.HeaderText);
                }
            }
            else
            {
                MessageBox.Show("No infos");
            }

        }

        private void swap_Click(object sender, EventArgs e)
        {
            DataTable tempTable = (DataTable)dGV_results.DataSource;
            // Set the data source of dataGridView1 to the data source of dataGridView2
            dGV_results.DataSource = dGV_cpds.DataSource;
            // Set the data source of dataGridView2 to the DataTable object that was created from dataGridView1
            dGV_cpds.DataSource = tempTable;
            List<string> columns_name = new List<string>();
            for (var i = 0; i < dGV_cpds.ColumnCount; i++)
            {
                columns_name.Add(dGV_cpds.Columns[i].HeaderText);

            }
            comboBox_fields.DataSource = columns_name;
        }

        private void pathwaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql2 = "select * from genepath";
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, conn_meta);
            conn_meta.Close();
            if (conn_meta.State == ConnectionState.Closed)
            {
                conn_meta.Open();
            }
            Npgsql.NpgsqlDataReader Resource = command2.ExecuteReader();
            HashSet<string> path_list = new HashSet<string>();
            //List<string> gene_list = new List<string>();
            while (Resource.Read())
            {
                if (Resource.GetString(0).Contains("hsa"))
                {
                    path_list.Add(Resource.GetString(0));
                }
                //break;
            }
            conn_meta.Close();
            Dictionary<string, HashSet<string>> unique_pathways = new Dictionary<string, HashSet<string>>();
            foreach (var item in path_list)
            {
                unique_pathways.Add(item, new HashSet<string>());
            }
            if (conn_meta.State == ConnectionState.Closed)
            {
                conn_meta.Open();
            }
            Npgsql.NpgsqlDataReader Resource2 = command2.ExecuteReader();

            while (Resource2.Read())
            {
                if (Resource2.GetString(0).Contains("hsa"))
                {

                    unique_pathways[Resource2.GetString(0)].Add(Resource2.GetString(1));
                }
                //break;
            }



            Dictionary<string, int> pathwaytotalGeneCounts = new Dictionary<string, int>();

            // Loop through the pathways in the pathway_genes dictionary
            foreach (KeyValuePair<string, HashSet<string>> kvp in unique_pathways)
            {
                string pathway = kvp.Key; // get the name of the pathway from the key of the current key-value pair
                HashSet<string> genes = kvp.Value; // get the list of genes from the value of the current key-value pair
                int geneCount = genes.Count; // get the number of genes in the list
                pathwaytotalGeneCounts.Add(pathway, geneCount); // add the pathway and gene count to the pathwayGeneCounts dictionary
            }



            List<string> sel = new List<string>();
            Dictionary<string, HashSet<string>> pathway_genes = new Dictionary<string, HashSet<string>>();
            foreach (DataGridViewRow row in dGV_results.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains("hsa"))
                {
                    sel.Add(row.Cells[0].Value.ToString());
                }


            }
            List<string> unique_pathw = new HashSet<string>(sel).ToList();
            foreach (var item in unique_pathw)
            {
                pathway_genes.Add(item, new HashSet<string>());
            }
            foreach (DataGridViewRow row in dGV_results.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains("hsa"))
                {
                    pathway_genes[row.Cells[0].Value.ToString()].Add(row.Cells[1].Value.ToString());
                }
            }
            Dictionary<string, int> pathwayGeneCounts = new Dictionary<string, int>();

            // Loop through the pathways in the pathway_genes dictionary
            foreach (KeyValuePair<string, HashSet<string>> kvp in pathway_genes)
            {
                string pathway = kvp.Key; // get the name of the pathway from the key of the current key-value pair
                HashSet<string> genes = kvp.Value; // get the list of genes from the value of the current key-value pair
                int geneCount = genes.Count; // get the number of genes in the list
                pathwayGeneCounts.Add(pathway, geneCount); // add the pathway and gene count to the pathwayGeneCounts dictionary
            }

            // Create a new Chart object to display the histogram
            FormChart fc = new FormChart();
            var commonKeys = pathwayGeneCounts.Keys.Intersect(pathwaytotalGeneCounts.Keys);
            foreach (var key in commonKeys)
            {
                pathwaytotalGeneCounts.TryGetValue(key, out var geneCounttot);
                pathwayGeneCounts.TryGetValue(key, out var geneCount);
                float res = (float)geneCount / (float)geneCounttot;
                fc.chart1.Series[0].Points.AddXY(key, 100 * res);
                // do something with the common key
            }

            //chart.Series.Add(newSeries);
            // Display the chart in a new form
            fc.chart1.Series["Genes in Pathway"].ToolTip = "Pathway: #VALX";
            //form.Controls.Add(chart);
            fc.Show();
        }
        private void plot_results_Click(object sender, EventArgs e)
        {
            // for example X:gene , Y:cpd
            FormChart fc = new FormChart();
            HashSet<string> list_x_data = new HashSet<string>();
            List<string> list_y_data = new List<string>();

            string val_combo_x = x_combo.GetItemText(this.x_combo.SelectedItem);
            string val_combo_y = y_combo.GetItemText(this.y_combo.SelectedItem);

            /* X values should be unique */
            foreach (DataGridViewRow row in dGV_results.Rows)
            {
                list_x_data.Add(row.Cells[val_combo_x].Value.ToString());
            }

            /* dictinary of X and  y to chart plot*/
            Dictionary<string, List<string>> xyCounts = new Dictionary<string, List<string>>();
            foreach (string item in list_x_data)
            {
                xyCounts.Add(item, new List<string>());
            }

            foreach (DataGridViewRow row in dGV_results.Rows)
            {
                xyCounts[row.Cells[val_combo_x].Value.ToString()].Add(row.Cells[val_combo_y].Value.ToString());

            }

            // now count Y and chart!
            foreach (KeyValuePair<string, List<string>> kvp in xyCounts)
            {
                string x_values = kvp.Key;
                List<string> y_values = kvp.Value;
                int y_counts = y_values.Count;
                fc.chart1.Series[0].Points.AddXY(x_values, y_counts);
            }
            fc.chart1.Series[0].Name = val_combo_x + "__" + val_combo_y;

            fc.chart1.Series["Genes in Pathway"].ToolTip = "Pathway: #VALX";
            fc.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dGV_results_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<string> sel = new List<string>();
            foreach (DataGridViewRow row in dGV_results.Rows)
            {
                if (row.Cells[e.ColumnIndex].Value.ToString() != "No result" & row.Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    sel.Add(row.Cells[e.ColumnIndex].Value.ToString());
                }


                // do something with the row..
            }
            List<string> unique_items = new HashSet<string>(sel).ToList();
            List<string> columns_name = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();

            foreach (string item in unique_items)
            {
                //if (columns_name[e.ColumnIndex].Contains("pubchem") | columns_name[e.ColumnIndex].Contains("cas"))
                if (columns_name[e.ColumnIndex].Contains("kegg") | columns_name[e.ColumnIndex].Contains("pathid")
                    | columns_name[e.ColumnIndex].Contains("geneid") | columns_name[e.ColumnIndex].Contains("disid"))
                {
                    f2 = new GKForm();
                    ChromiumWebBrowser browser = new ChromiumWebBrowser("https://www.genome.jp/entry/" + item);

                    f2.toolStripContainer1.ContentPanel.Controls.Add(browser);
                    f2.Show();
                }
                else
                {
                    f2 = new GKForm();
                    ChromiumWebBrowser browser = new ChromiumWebBrowser("https://pubchem.ncbi.nlm.nih.gov/compound/" + item);
                    f2.toolStripContainer1.ContentPanel.Controls.Add(browser);
                    f2.Show();
                }
            }

        }
        // -----------------------------------------------------------
        // tab 2

        private void get_profile_Click(object sender, EventArgs e)
        {
            dGV_crisper.DataSource = null;

            conn_meta.Close();
            if (conn_meta.State == ConnectionState.Closed)
            {
                conn_meta.Open();
            }
            string search_text = textBox_gene.Text;
            tbl_profiles = new DataTable();
            var tbl_batchs_gene = new DataTable();
            string tbl_to_serach = "gene";
            string col_to_add = "symbol";
            if (radioButton_cpd.Checked)
            {
                tbl_to_serach = "cpd";
                col_to_add = "pubchemid";

            }
            var schemaTable1 = conn_meta.GetSchema("Columns", new[] { null, null, tbl_to_serach });
            var columnNames = new List<string>();
            foreach (DataRow row in schemaTable1.Rows)
            {
                if (row["DATA_TYPE"].ToString() != "double precision")
                    columnNames.Add(row["COLUMN_NAME"].ToString());
            }
            // get data
            foreach (var col in columnNames)
            {

                string sql_last_line = $" where UPPER({tbl_to_serach}.{col}) LIKE UPPER('% {search_text} %') ";

                if (equal_radioButton.Checked)
                {
                    sql_last_line = $" where UPPER({tbl_to_serach}.{col}) =  UPPER('{search_text}') ";
                }
                if (startswith_radioButton.Checked)
                {
                    sql_last_line = $" where UPPER({tbl_to_serach}.{col}) LIKE UPPER('{search_text}%') ";
                }

                //crisper
                if (radioButton_gene.Checked)
                {
                    string sql_crisper = "select crispermeta.batchid,gene.geneid,gene.symbol,gene.synonyms" +
                    " from crispermeta " +
                    "inner join gene on crispermeta.geneid=gene.geneid " + sql_last_line + "" +
                    " GROUP BY crispermeta.batchid,gene.geneid,gene.symbol,gene.synonyms";

                    var command_1 = new NpgsqlCommand(sql_crisper, conn_meta);
                    var adapter_1 = new NpgsqlDataAdapter(command_1);
                    var tableResults_1 = new DataTable();
                    adapter_1.Fill(tableResults_1);
                    tbl_batchs_gene.Merge(tableResults_1);
                }
                //cpd
                string sql_cpd = "select  batchs.batchid, gene.geneid,gene.symbol,gene.synonyms" +
                    " from batchs" +
                    " inner join cpdgene on cpdgene.pubchemid=batchs.pubchemid" +
                    " inner join gene on cpdgene.geneid=gene.geneid" + sql_last_line +
                    " GROUP BY batchs.batchid, gene.geneid,gene.symbol,gene.synonyms";
                if (radioButton_cpd.Checked)
                {
                    sql_cpd = "select  batchs.batchid, cpd.pubchemid,cpd.name " +
                       " from cpd" +
                       " inner join batchs on batchs.pubchemid=cpd.pubchemid " +
                         sql_last_line +
                       " GROUP BY batchs.batchid, cpd.pubchemid,cpd.name";
                }

                var command_2 = new NpgsqlCommand(sql_cpd, conn_meta);
                var adapter_2 = new NpgsqlDataAdapter(command_2);
                var tableResults_2 = new DataTable();
                adapter_2.Fill(tableResults_2);
                tbl_batchs_gene.Merge(tableResults_2);
                conn_meta.Close();
            }


            //get profiles
            if (tbl_batchs_gene.Rows.Count > 0)
            {
                List<string> batch_list = new List<string>(tbl_batchs_gene.Rows.Count);
                foreach (DataRow row in tbl_batchs_gene.Rows)
                {
                    batch_list.Add("'" + (string)row["batchid"] + "'");
                }

                // get profiles

                conn_profile = new NpgsqlConnection(cs_profile);
                if (conn_profile.State == ConnectionState.Closed)
                {
                    conn_profile.Open();
                }
                string sql_profile = "select * from aggprofiles where batchid  in ("
                      + string.Join(",", batch_list)
                      + ")";
                var cmd_profile = new NpgsqlCommand(sql_profile, conn_profile);
                var adp_profile = new NpgsqlDataAdapter(cmd_profile);
                adp_profile.Fill(tbl_profiles);
                conn_profile.Close();

                // add pubchemid or geneid to table
                DataTable distinctTable = tbl_batchs_gene.DefaultView.ToTable(true, col_to_add, "batchid");
                Dictionary<string, List<string>> batchGeneDict = new Dictionary<string, List<string>>();

                foreach (DataRow row in distinctTable.Rows)
                {
                    string batchid = row["batchid"].ToString();
                    string symbol = row[col_to_add].ToString();

                    if (batchGeneDict.ContainsKey(batchid))
                    {
                        batchGeneDict[batchid].Add(symbol);
                    }
                    else
                    {
                        batchGeneDict.Add(batchid, new List<string> { symbol });
                    }
                }

                tbl_profiles.Columns.Add(col_to_add);
                foreach (DataRow row in tbl_profiles.Rows)
                {
                    string batchid = row.Field<string>("batchid");
                    if (batchGeneDict.ContainsKey(batchid))
                    {
                        List<string> symbol = batchGeneDict[batchid];
                        if (symbol.Count == 1)
                        {
                            row.SetField(col_to_add, symbol[0]);
                        }
                        else
                        {
                            // Handle multiple "geneid" values for "batchid"
                        }


                    }
                }

                tbl_batchs_gene = tbl_profiles.DefaultView.ToTable(true, "source", col_to_add, "batchid");
                dGV_crisper.DataSource = tbl_batchs_gene;
                foreach (DataGridViewRow row in dGV_crisper.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Record Not Found");
            }
            plot_prof.Visible = true;



        }

        private static bool IsNumericType(Type type)
        {
            return type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(long) || type == typeof(short);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (searchtb.SelectedTab == searchtb.TabPages["search_tab"])
            {
                save_results(dt, "results");
            }
            if (searchtb.SelectedTab == searchtb.TabPages["profiles_tab"])
            {
                save_results(tbl_profiles, "profiles");

            }
            if (searchtb.SelectedTab == searchtb.TabPages["search_all_tab"])
            {

            }
            if (searchtb.SelectedTab == searchtb.TabPages["compunds_tab"])
            {

            }
            if (searchtb.SelectedTab == searchtb.TabPages["profile_tab"])
            {

            }
        }

        private void dGV_cpds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = dGV_cpds.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                // Get the clipboard data object
                IDataObject dataObject = Clipboard.GetDataObject();

                // Check if the clipboard data is in a supported format
                if (dataObject != null && dataObject.GetDataPresent(DataFormats.Text))
                {
                    // Get the clipboard text and split it into rows
                    string clipboardText = (string)dataObject.GetData(DataFormats.Text);
                    string[] clipboardRows = clipboardText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    dGV_cpds.Rows.Clear();
                    dGV_cpds.Columns.Clear();

                    // Create columns based on the headers in the clipboard data
                    string[] clipboardHeaders = clipboardRows[0].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    ;
                    foreach (string header in clipboardHeaders)
                    {
                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                            column.HeaderText = header;
                            column.Name = header;

                            dGV_cpds.Columns.Add(column);
                      
                        



                    }

                    // Iterate through the rows in the clipboard data and add them to the destination DataGridView
                    for (int i = 1; i < clipboardRows.Length; i++)
                    {
                        string[] clipboardCells = clipboardRows[i].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        DataGridViewRow newRow = new DataGridViewRow();

                        // Map the data from the source columns to the destination columns
                        for (int j = 0; j < clipboardCells.Length; j++)
                        {
                            if (j < dGV_cpds.Columns.Count)
                            {
                                DataGridViewColumn column = dGV_cpds.Columns[j];
                                if (column is DataGridViewTextBoxColumn)
                                {
                                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                                    cell.Value = clipboardCells[j];
                                    newRow.Cells.Add(cell);

                                }
                                // Add additional mapping code here for other column types
                            }
                        }

                        dGV_cpds.Rows.Add(newRow);

                    }


                    List<string> columns_name = new List<string>();
                    for (var i = 0; i < dGV_cpds.ColumnCount; i++)
                    {
                        columns_name.Add(dGV_cpds.Columns[i].HeaderText);

                    }
                    comboBox_fields.DataSource = columns_name;

                }
            }
            dGV_cpds.Refresh();
        }

        private void plot_prof_Click(object sender, EventArgs e)
        {


            plotProfilesForm TF = new plotProfilesForm();
            //var plt = TF.formsPlot1.Plot;
            DataTable groupedDataTable = tbl_profiles;
            List<string> batch_list = new List<string>(tbl_profiles.Rows.Count);
            foreach (DataRow row in tbl_profiles.Rows)
            {
                batch_list.Add("'" + (string)row["batchid"] + "'");
            }
            /*
            //string sql_profile = "select * from profiles where batchid  in ("
            //       + string.Join(",", batch_list)
            //       + ")";
            //var cmd_profile = new NpgsqlCommand(sql_profile, conn_profile);
            //var adp_profile = new NpgsqlDataAdapter(cmd_profile);
            //adp_profile.Fill(groupedDataTable);

            //DataTable groupedDataTable = tbl_profiles.AsEnumerable()
            //                            .GroupBy(row => row.Field<string>("batchid"))
            //                            .Select(group =>
            //                            {
            //                                DataRow newRow = tbl_profiles.NewRow();
            //                                newRow["batchid"] = group.Key;

            //                                foreach (DataColumn column in tbl_profiles.Columns)
            //                                {
            //                                    if (column.ColumnName != "batchid" && IsNumericType(column.DataType))
            //                                    {
            //                                        newRow[column.ColumnName] = group.Average(row => row.Field<double>(column.ColumnName));
            //                                    }
            //                                }

            //                                return newRow;
            //                            })
            //                            .CopyToDataTable();
            //for (int i = groupedDataTable.Columns.Count - 1; i >= 0; i--)
            //{
            //    bool allZero = true;
            //    for (int j = 0; j < groupedDataTable.Rows.Count; j++)
            //    {
            //        if (Convert.ToDouble(groupedDataTable.Rows[j][i]) != 0)
            //        {
            //            allZero = false;
            //            break;
            //        }
            //    }
            //    if (allZero)
            //    {
            //        groupedDataTable.Columns.RemoveAt(i);
            //    }
            //}
            // Loop through the rows of the DataGridView and add them to the plot
            //for (int i = 0; i < groupedDataTable.Rows.Count; i++)
            //{
            //    double[] values = new double[groupedDataTable.Columns.Count];
            //    for (int j = 0; j < groupedDataTable.Columns.Count; j++)
            //    {
            //        if (groupedDataTable.Columns[j].ColumnName != "batchid" && IsNumericType(groupedDataTable.Columns[j].DataType))
            //        {

            //            double.TryParse(groupedDataTable.Rows[i][j].ToString(), out values[j]);
            //        }

            //    }
            //    //var sp = TF.formsPlot1.Plot.AddSignal(values,label: groupedDataTable.Rows[i]["batchid"].ToString());
            //    TF.checkedListBox_Signal.Items.Add(groupedDataTable.Rows[i]["batchid"].ToString());

            //    //sp.Smooth = true;

            //}
            //for (int i = 0; i < TF.checkedListBox_Signal.Items.Count; i++)
            //{
            //    TF.checkedListBox_Signal.SetItemChecked(i, true);
            //}
            //TF.formsPlot1.Plot.XAxis.SetBoundary(0, tbl_profiles.Columns.Count-4);

            //TF.formsPlot1.Plot.AxisAuto();
            //TF.formsPlot1.Plot.Legend();
            //TF.formsPlot1.Refresh();
            */
            // Display the plot in a new form
            for (int i = 0; i < groupedDataTable.Rows.Count; i++)
            {

                TF.checkedListBox_Signal.Items.Add(groupedDataTable.Rows[i]["batchid"].ToString() + "+" + groupedDataTable.Rows[i]["source"].ToString());

            }


            TF.dg_test.AutoGenerateColumns = false;
            TF.dg_test.DataSource = groupedDataTable;
            //form.Controls.Add(plt);
            TF.Show();
        }

        // --------------------------------------------------------------
        // tab 3
        private void search_all_db_Click(object sender, EventArgs e)
        {
            string text = searchText.Text;
            if (conn_meta.FullState == ConnectionState.Closed)
            {
                conn_meta.Open();
            }


            // get a list of all tables in the database
            var tables = conn_meta.GetSchema("Tables").Rows.Cast<DataRow>()
                .Select(row => row["TABLE_NAME"].ToString())
                .ToList();

            // create a new DataTable to hold the results
            var resultsTable = new DataTable();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = conn_meta,
                CommandType = CommandType.Text,
                //CommandText = "select table_name from information_schema.tables where table_schema='public'"
            };


            List<string> TableNames = new List<string>();


            dGV_search.Visible = true;

            // loop over each table and search for the string
            foreach (var table in tables)
            {
                var schemaTable = conn_meta.GetSchema("Columns", new[] { null, null, table });

                // iterate over the rows of the schema table and extract the column names
                var columnNames = new List<string>();
                foreach (DataRow row in schemaTable.Rows)
                {
                    if (row["DATA_TYPE"].ToString() != "double precision")
                        columnNames.Add(row["COLUMN_NAME"].ToString());
                }


                foreach (var col in columnNames)
                {


                    // create a new SqlCommand object to search the table for the string
                    var command = new NpgsqlCommand($"SELECT * FROM {table} WHERE UPPER({col}) LIKE UPPER('{text}%')", conn_meta);

                    // create a new SqlDataAdapter object to fill a DataTable with the results of the query
                    var adapter = new NpgsqlDataAdapter(command);
                    var tableResults = new DataTable();

                    adapter.Fill(tableResults);
                    resultsTable.Merge(tableResults);

                }


            }

            // bind the results table to a DataGridView
            dGV_search.DataSource = resultsTable;

            List<string> collist = new List<string>();

            foreach (DataGridViewColumn column in dGV_search.Columns)
            {
                bool hasValue = false;

                // check if the column has any non-null values
                foreach (DataGridViewRow row in dGV_search.Rows)
                {
                    if (row.Cells[column.Index].Value.ToString() != "")
                    {
                        hasValue = true;
                        break;
                    }
                }

                // if the column has no non-null values, remove it from the DataGridView
                if (!hasValue)
                {
                    //dGV_search.Columns.Remove(column);
                    collist.Add(column.Name);
                }
            }
            foreach (var item in collist)
            {
                dGV_search.Columns.Remove(item);
            }



        }



    }
}
