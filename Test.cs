using Npgsql;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sqlcnet
{
    public partial class TestForm : Form
    {
        //private DataTable _tabName;
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
            var bnColor = System.Drawing.ColorTranslator.FromHtml("#2e3440");
            formsPlot1.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);

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
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        if (IsNumericType(dt.Columns[j].DataType))
            //        {

            //            double.TryParse(dt.Rows[i][j].ToString(), out data[i, j]);
            //        }
            //    }
            //}
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

        private void button_stat_Click(object sender, EventArgs e)
        {
            DataTable tbl_prof = new DataTable();
            DataTable groupedDataTable = (DataTable)dg_test.DataSource;
            List<string> batch_list = new List<string>(groupedDataTable.Rows.Count);
            foreach (DataRow row in groupedDataTable.Rows)
            {
                batch_list.Add("'" + (string)row["batchid"] + "'");
            }

            NpgsqlConnection conn;
            string cs_profile = "Server=192.168.2.131;Port=5432;User Id=arno; Database=ksilink_cpds; Password=12345";
            conn = new NpgsqlConnection(cs_profile);
            conn.Open();



            DataTable tbl_all_prof = new DataTable();
            string sql_profile = "select * from aggprofiles";
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

            for (int i = 0; i < groupedDataTable.Rows.Count; i++)
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

            }
            int a = 0;

            while (Resource.Read())
            {
                a++;

            }



            MessageBox.Show("Done");


        }
    }
}
