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

namespace sqlcnet
{

    public partial class LoadCpdsForm : Form
    {
        DataTable dt;
        CachedCsvReader csv;

        public HelpForm HelpF;
        NpgsqlConnection conn;
        readonly string cs = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksi_cpds; Password=12345";
        //NpgsqlDataAdapter adapt;
        public GKForm f2;
        public LoadCpdsForm f_cpds;
        public TestForm TF;
        string cmb, cmb2;
        protected DataGridView MyDgv;
        public LoadCpdsForm()
        {
            InitializeComponent();
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
            cmd.Dispose();
            conn.Close();
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


                //button_form2.Text = "test";
               
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
                if (cmb == "genepath" || cmb == "cpdpath")
                {
                    sql = "SELECT " + cmb + ".*, pathway.name FROM " + cmb + " JOIN pathway ON pathway.pathid= " + cmb + ".pathid WHERE  " + cmb + "." + cmb2 + " IN (";
                }

                if (cmb == "genedis" || cmb == "cpddis" )
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
            //Chart chart = new Chart();
            //Series newSeries = new Series("New Series");

            // Set the chart type to a histogram
            //newSeries.ChartType = SeriesChartType.Column;
            //fc.chart1.Series[0].ChartType = SeriesChartType.
            // Loop through the pathwayGeneCounts dictionary and add the data points to the chart
            //foreach (KeyValuePair<string, int> kvp in pathwayGeneCounts)
            //{
            //    string pathway = kvp.Key; // get the name of the pathway from the key of the current key-value pair
            //    int geneCount = kvp.Value; // get the number of genes in the pathway from the value of the current key-value pair
            //    fc.chart1.Series[0].Points.AddXY(pathway, geneCount); // add the pathway and gene count as a data point to the chart
            //}

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
