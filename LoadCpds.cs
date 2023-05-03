using System;
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

namespace sqlcnet
{

    public partial class LoadCpdsForm : MaterialForm
    {
        DataTable dt;
        CachedCsvReader csv;

        public HelpForm HelpF;
        NpgsqlConnection conn;
        readonly string cs = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksi_cpds; Password=12345";
        public GKForm f2;
        public LoadCpdsForm f_cpds;
        public TestForm TF;
        string cmb, cmb2;
        protected DataGridView MyDgv;
        public LoadCpdsForm()
        {
            
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dGV_cpds.Visible = false;
            dGV_results.Visible = false;

            //comboBox_tables----------------------------------------------
            conn = new NpgsqlConnection(cs);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = "select table_name from information_schema.tables where table_schema='public'"
            };
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt = new DataTable();
                dt.Load(reader);
                comboBox_tables.DataSource = dt;
                comboBox_tables.ValueMember = dt.Columns[0].ColumnName;

            }

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
            //genecombo----------------------------------------------
            genecombo.DataSource = unique_items;
            cmd.Dispose();
            conn.Close();
        }
        private void genecombo_DropDownClosed(object sender, EventArgs e)
        {
           
                // for dGV_crisper
                conn.Open();
                string gen_nam = textBox_gene.Text;
                cmb = genecombo.GetItemText(this.genecombo.SelectedItem);
                string sql3 = "select platemap.plate,platemap.well,platemap.tags,gene.symbol from platemap" +
                    " inner join crispermeta on crispermeta.batchid=platemap.batchid" +
                    " inner join gene on crispermeta.geneid=gene.geneid" +
                    " where gene. " + cmb + "= '" + gen_nam + "' GROUP BY plate, well,tags,symbol";


                Console.WriteLine(sql3);
                dt = new DataTable();
                NpgsqlCommand command = new NpgsqlCommand(sql3, conn);

                NpgsqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(reader);
                dGV_crisper.DataSource = dt;

                foreach (DataGridViewRow row in dGV_crisper.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

                // for dGV_cpd
                conn.Open();
                string sql4 = "select platemap.plate,platemap.well,platemap.tags,gene.symbol from platemap" +
                    " inner join batchs on batchs.batchid=platemap.batchid" +
                    " inner join cpd on cpd.pubchemid=batchs.pubchemid" +
                    " inner join cpdgene on cpdgene.pubchemid=cpd.pubchemid" +
                    " inner join gene on cpdgene.geneid=gene.geneid" +
                    " where gene. " + cmb + "= '" + gen_nam + "' GROUP BY plate, well,tags,symbol";
                Console.WriteLine(sql4);
                dt = new DataTable();
                NpgsqlCommand command2 = new NpgsqlCommand(sql4, conn);

                NpgsqlDataReader reader2 = command2.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(reader2);

                dGV_cpd.DataSource = dt;

                foreach (DataGridViewRow row in dGV_cpd.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

           

        


        }
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
                    string string_path = "http://www.kegg.jp/kegg-bin/show_pathway?"+gene_txt+ "/default%3dpink/";
                    foreach (string item in unique_items)
                    {
                        string_path += item+"+";

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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string text = comboBox_mapping.GetItemText(this.comboBox_mapping.SelectedItem);
            (dGV_results.DataSource as DataTable).DefaultView.RowFilter = string.Format(text+" LIKE '{0}%'", searchBox.Text);                    

        }

        private void comboBox_tables_DropDownClosed(object sender, EventArgs e)
        {
            cmb = comboBox_tables.GetItemText(this.comboBox_tables.SelectedItem);

            conn.Open();
       
            string sql2 ="select * from " + cmb; ;
           
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, conn);
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
            conn.Close();


            List<string> list_res_data = new List<string>();
            string val_combo = comboBox_fields.GetItemText(this.comboBox_fields.SelectedItem);
            cmb2 = comboBox_mapping.GetItemText(this.comboBox_mapping.SelectedItem);
            dGV_results.Visible = true;
            if (col_list.Contains(cmb2))
            {
                foreach (DataGridViewRow row in dGV_cpds.Rows)
                {

                    list_res_data.Add(row.Cells[val_combo].Value.ToString());
                }

                List<string> unique_items = new HashSet<string>(list_res_data).ToList();

                // Define the SQL query using a parameterized query with the IN operator
                string sql = "SELECT * FROM " + cmb + " WHERE " + cmb2 + " IN (";


                if (cmb == "cpdgene" || cmb == "genepath" || cmb == "genedis")
                {
                    sql = "SELECT " + cmb + ".*, gene.name, gene.symbol FROM " + cmb + " JOIN gene ON gene.geneid= " + cmb + ".geneid WHERE  " + cmb + "." + cmb2 + " IN (";
                }
                if (cmb == "cpdpath")
                {
                    sql = "SELECT " + cmb + ".*, pathway.name FROM " + cmb + " JOIN pathway ON pathway.pathid= " + cmb + ".pathid WHERE  " + cmb + "." + cmb2 + " IN (";
                }

                if ( cmb == "cpddis" )
                {
                    sql = "SELECT " + cmb + ".*, disease.name FROM " + cmb + " JOIN disease ON disease.disid= " + cmb + ".disid WHERE  " + cmb + "." + cmb2 + " IN (";
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

                dt = new DataTable();
                NpgsqlCommand command = new NpgsqlCommand(sql, conn); 
                // Execute the query and retrieve the results
                conn.Open();
                NpgsqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(reader);
                dGV_results.DataSource = dt;
                
                foreach (DataGridViewRow row in dGV_results.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();                    
                }
                MessageBox.Show("Done");
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
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, conn);
            conn.Open();
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

            Dictionary<string, HashSet<string>> unique_pathways = new Dictionary<string, HashSet<string>>();
            foreach (var item in path_list)
            {
                unique_pathways.Add(item, new HashSet<string>());
            }
            conn.Close();
            conn.Open();
            Npgsql.NpgsqlDataReader Resource2 = command2.ExecuteReader();

            while (Resource2.Read())
            {
                if (Resource2.GetString(0).Contains("hsa"))
                {

                    unique_pathways[Resource2.GetString(0)].Add(Resource2.GetString(1));
                }
                //break;
            }

            conn.Close();

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
            fc.Show();
            // add cpds 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_2_Click(object sender, EventArgs e)
        {
            string text = searchText.Text;
            if (conn.FullState == ConnectionState.Closed)
            {
                conn.Open();
            }


            // get a list of all tables in the database
            var tables = conn.GetSchema("Tables").Rows.Cast<DataRow>()
                .Select(row => row["TABLE_NAME"].ToString())
                .ToList();

            // create a new DataTable to hold the results
            var resultsTable = new DataTable();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                //CommandText = "select table_name from information_schema.tables where table_schema='public'"
            };


            List<string> TableNames = new List<string>();


            dGV_search.Visible = true;

            // loop over each table and search for the string
            foreach (var table in tables)
            {
                var schemaTable = conn.GetSchema("Columns", new[] { null, null, table });

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
                    var command = new NpgsqlCommand($"SELECT * FROM {table} WHERE {col} LIKE '%{text}%'", conn);

                    // create a new SqlDataAdapter object to fill a DataTable with the results of the query
                    var adapter = new NpgsqlDataAdapter(command);
                    var tableResults = new DataTable();

                    adapter.Fill(tableResults);
                    resultsTable.Merge(tableResults);

                }


            }

            // bind the results table to a DataGridView
            dGV_search.DataSource = resultsTable;
            //int blankCellIndex = -1;
            //int numberOfDataRows = dGV_search.AllowUserToAddRows ? dGV_search.Rows.Count - 1 : dGV_search.Rows.Count; //it may be a blank row at the end
            //for (int j = 0; j < numberOfDataRows; j++)
            //{
            //    for (int i = 0; i < dGV_search.Rows[j].Cells.Count; i++)
            //    {
            //        if (dGV_search.Rows[j].Cells[i].Value.ToString() == "" && i > blankCellIndex)
            //        {
            //            blankCellIndex = i;
            //            break;
            //        }
            //    }
            //}

            //if (blankCellIndex > -1)
            //{
            //    for (int index = blankCellIndex; index < dGV_search.Columns.Count; index++)
            //    {
            //        dGV_search.Columns.RemoveAt(index);
            //        index--;
            //    }
            //}
            List<string> collist=new List<string>();

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
    }
}
