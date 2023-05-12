using Npgsql;
using ScottPlot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Plotly.NET.StyleParam.LinearAxisId;

namespace sqlcnet
{
    public partial class TestForm : Form
    {
        //private DataTable _tabName;
        int flag = 0;
        string batchid;
        DataTable dataTable = new DataTable();
        public TestForm()
        {
            InitializeComponent();
            //checkedListBox_Signal.Height = checkedListBox_Signal.Items.Count * checkedListBox_Signal.ItemHeight;
            //_tabName = tabName;
        }

        private static bool IsNumericType(Type type)
        {
            return type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(long) || type == typeof(short);
        }


        private void checkedListBox_Signal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable groupedDataTable = (DataTable)dg_test.DataSource;
            //checkedListBox_Signal.Size = new Size(150, checkedListBox_Signal.Items.Count * checkedListBox_Signal.ItemHeight);
            ScottPlot.Plottable.SignalPlot sp = new ScottPlot.Plottable.SignalPlot();
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Style(Style.Black);
            formsPlot1.Plot.Palette = ScottPlot.Palette.OneHalfDark;
            List<double[]> list_pro = new List<double[]>();
            double dist = 0.0;
            for (int i = 0; i < groupedDataTable.Rows.Count; i++)
            {
                if (checkedListBox_Signal.GetItemChecked(i))
                {
                    double[] values = new double[groupedDataTable.Columns.Count];
                    for (int j = 0; j < groupedDataTable.Columns.Count; j++)
                    {
                        if (groupedDataTable.Columns[j].ColumnName != "batchid" && IsNumericType(groupedDataTable.Columns[j].DataType))
                        {

                            double.TryParse(groupedDataTable.Rows[i][j].ToString(), out values[j]);
                        }

                    }
                    list_pro.Add(values);

                    sp = formsPlot1.Plot.AddSignal(values, label: groupedDataTable.Rows[i]["batchid"].ToString());
                    sp.Smooth = true;


                    formsPlot1.Plot.AxisAuto();
                    formsPlot1.Plot.Legend();
                    formsPlot1.Refresh();
                }

            }
            //var bnColor = System.Drawing.ColorTranslator.FromHtml("#2e3440");
            //formsPlot1.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);

            //formsPlot1.Plot.XAxis2.Label("Cosine Distance: " + dist.ToString());
            formsPlot1.Refresh();
        }

        public static double Distance(List<double> l1, List<double> l2)
        {
            double dotProduct = 0.0;
            double l2norm1 = 0.0;
            double l2norm2 = 0.0;
            for (int i = 0; i < l1.Count(); i++)
            {

                dotProduct += l1[i] * l2[i];
                l2norm1 += l1[i] * l1[i];
                l2norm2 += l2[i] * l2[i];
            }
            double cos = dotProduct / (Math.Sqrt(l2norm1) * Math.Sqrt(l2norm2));
            // convert cosine value to radians then to degrees
            return cos;
        }

        private void button_disp_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dg_test.DataSource;


            List<double[]> list_pro = new List<double[]>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                double[] values = new double[dt.Columns.Count];
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Columns[j].ColumnName != "batchid" && IsNumericType(dt.Columns[j].DataType))
                    {

                        double.TryParse(dt.Rows[i][j].ToString(), out values[j]);
                    }

                }
                list_pro.Add(values);

            }

            double[,] data = new double[list_pro.Count, list_pro.Count];
            double[] positions = new double[list_pro.Count];
            double[] positionsy = new double[list_pro.Count];
            string[] labels = new string[list_pro.Count];
            for (int i = 0; i < list_pro.Count; i++)
            {
                for (int j = 0; j < list_pro.Count; j++)
                {
                    data[i, j] = Distance(list_pro[i].ToList(), list_pro[j].ToList());
                }
                positions[i] = i;
                positionsy[list_pro.Count - 1 - i] = i;
                labels[i] = dt.Rows[i][2].ToString();

            }
            formsPlot1.Plot.Clear();
            var hm = formsPlot1.Plot.AddHeatmap(data, lockScales: false);
            formsPlot1.Plot.AddColorbar(hm);
            formsPlot1.Plot.YAxis.TickLabelStyle(rotation: 45);
            formsPlot1.Plot.XAxis.TickLabelStyle(rotation: 45);
            formsPlot1.Plot.YAxis.ManualTickSpacing(1);
            formsPlot1.Plot.XAxis.ManualTickPositions(positions, labels);
            formsPlot1.Plot.YAxis.ManualTickPositions(positionsy, labels);
            formsPlot1.Refresh();

        }

        private void save_same_profiles(List<string> sim_prof, string batch)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = batch + "_Sim_profiles.csv";
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
                        // tbl_profiles.ToCSV(sfd.FileName);
                        StringBuilder sb = new StringBuilder();

                        string columnName = "batchid";
                        sb.AppendLine(columnName);

                        foreach (string item in sim_prof)
                        {

                            sb.AppendLine(item);
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

        private void button_stat_Click(object sender, EventArgs e)
        {
            DataTable tbl_prof = new DataTable();
            DataTable groupedDataTable = (DataTable)dg_test.DataSource;
            List<string> source_list = new List<string>(groupedDataTable.Rows.Count);
            foreach (DataRow row in groupedDataTable.Rows)
            {
                source_list.Add("'" + (string)row["source"] + "'");
            }

            NpgsqlConnection conn;
            string cs_profile = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksilink_cpds; Password=12345";
            conn = new NpgsqlConnection(cs_profile);
            conn.Open();



            DataTable tbl_all_prof = new DataTable();
            batchid = checkedListBox_Signal.SelectedItem.ToString().Split('+')[0];
            string source_cpd = checkedListBox_Signal.SelectedItem.ToString().Split('+')[1];
            string sql_profile = "select * from aggprofiles where source=" + "'" + source_cpd + "'";
            NpgsqlCommand cmd_profile = new NpgsqlCommand(sql_profile, conn);
            Npgsql.NpgsqlDataReader Resource = cmd_profile.ExecuteReader();

            List<double[]> list_pro = new List<double[]>();
            List<string> list_col = new List<string>();
            for (int j = 0; j < groupedDataTable.Columns.Count; j++)
            {
                if (IsNumericType(groupedDataTable.Columns[j].DataType))
                {

                    list_col.Add(groupedDataTable.Columns[j].ColumnName);
                }

            }
            int cpt = 0;

            double[] values = new double[list_col.Count];
            for (int i = 0; i < groupedDataTable.Rows.Count; i++)
            {
                cpt = 0;
                if (groupedDataTable.Rows[i]["source"].ToString() == source_cpd && groupedDataTable.Rows[i]["batchid"].ToString() == batchid)
                {

                    foreach (string item in list_col)
                    {

                        double.TryParse(groupedDataTable.Rows[i][item].ToString(), out values[cpt]);
                        cpt++;
                    }
                    //list_pro.Add(values);
                }




            }
            //int a = 0;


            List<double> list_dist = new List<double>();
            List<string> list_batch = new List<string>();
            double sim = 0.0;
            

            // add columns to the DataTable
            dataTable.Columns.Add("batchid", typeof(string));
            dataTable.Columns.Add("Similarity", typeof(double));

            while (Resource.Read())
            {
                //string columnName = Resource.GetString(0);

                List<double> list_data = new List<double>();
                for (int i = 2; i < Resource.FieldCount; i++)
                {
                    list_data.Add(Resource.GetDouble(i));

                }
                sim = Distance(values.ToList(), list_data);
                list_dist.Add(sim);
                //if (sim > (double)numericUpDown_sim.Value)
                //{
                list_batch.Add(Resource.GetString(1));
                //}

            }
            List<double> list_dist_thre = new List<double>();
            List<string> list_batch_thre = new List<string>();
            for (int i = 0; i < list_batch.Count; i++)
            {
                if (list_dist[i] > (double)numericUpDown_sim.Value)
                {
                    DataRow row = dataTable.NewRow();
                    row["batchid"] = list_batch[i];
                    row["Similarity"] = list_dist[i];
                    dataTable.Rows.Add(row);
                    list_dist_thre.Add(list_dist[i]);
                    list_batch_thre.Add(list_batch[i]);

                }
                
            }
            dgv_sim.DataSource = dataTable;
            dgv_sim.AutoGenerateColumns = true;
            dgv_sim.Refresh();
            dgv_sim.Visible = true;
            flag = 1;
            formsPlot1.Plot.Clear();
            ScottPlot.Statistics.Histogram hist = new ScottPlot.Statistics.Histogram(min: -1, max: 1, binCount: 500);
            hist.AddRange(list_dist);
            double[] probabilities = hist.GetProbability();
            //var bar = formsPlot1.Plot.AddBar(values: probabilities, positions: hist.Bins);
            var bar = formsPlot1.Plot.AddBar(values: hist.Counts, positions: hist.Bins);
            bar.BarWidth = 0.002;
            bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
            bar.BorderColor = ColorTranslator.FromHtml("#82add9");

            // display histogram probability curve as a line plot
            formsPlot1.Plot.AddFunction(hist.GetProbabilityCurve(list_dist.ToArray(), true), Color.DarkGreen, 2, LineStyle.Dash);
            var vLine = formsPlot1.Plot.AddVerticalLine(x: (double)numericUpDown_sim.Value, color: Color.Magenta, width: 2, style: LineStyle.Dot);
            vLine.DragEnabled = true;
            numericUpDown_sim.Value = (decimal)vLine.X;
            // customize the plot style
            formsPlot1.Plot.Title("Similarity Distribution");
            //formsPlot1.Plot.YAxis.Label("Probability");
            formsPlot1.Plot.YAxis.Label("Count (#)");
            formsPlot1.Plot.XAxis.Label("Cosine Similarity of " + source_cpd);
            formsPlot1.Plot.SetAxisLimits(yMin: 0);


            formsPlot1.Refresh();

            MessageBox.Show("Done");
            if (checkBoxSave.Checked)
            {
                save_same_profiles(list_batch_thre, batchid);
            }


        }


        private void numericUpDown_sim_ValueChanged(object sender, EventArgs e)
        {
            if (flag==1)
            {
                
                DataTable dt = dataTable;
                List<string> list_batch_thre = new List<string>();
                DataTable dt_new = new DataTable();
                dt_new.Columns.Add("batchid", typeof(string));
                dt_new.Columns.Add("Similarity", typeof(double));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((double)dt.Rows[i]["Similarity"] > (double)numericUpDown_sim.Value)
                    {
                        DataRow row = dt_new.NewRow();
                        row["batchid"] = dt.Rows[i]["batchid"];
                        row["Similarity"] = dt.Rows[i]["Similarity"];
                        dt_new.Rows.Add(row);
                        list_batch_thre.Add(dt.Rows[i]["batchid"].ToString());
                    }
                }
                dgv_sim.DataSource = dt_new;
                dgv_sim.AutoGenerateColumns = true;
                dgv_sim.Refresh();
                if (checkBoxSave.Checked)
                {
                    save_same_profiles(list_batch_thre, batchid);
                }
                

            }

            var vLine = formsPlot1.Plot.AddVerticalLine(x: (double)numericUpDown_sim.Value, color: Color.DarkRed, width: 2, style: LineStyle.Dot);
            formsPlot1.Refresh();
            

            formsPlot1.Plot.Remove(vLine);

        }
    }
}
