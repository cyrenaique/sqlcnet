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


            formsPlot1.Plot.XAxis2.Label("Cosine Distance: " + dist.ToString());
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
            for (int i = 0; i < list_pro.Count; i++)
            {
                for (int j = 0; j < list_pro.Count; j++)
                {
                    data[i, j] = Distance(list_pro[i].ToList(), list_pro[j].ToList());
                }

            }
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddHeatmap(data);
            formsPlot1.Refresh();


            //using System.Drawing;
            //using System.Windows.Forms.DataVisualization.Charting;

            //// ...

            //// Create a new chart control
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill;

            //// Set the chart type to heatmap
            //chart.ChartAreas.Add("ChartArea1");
            //chart.Series.Add("Series1");
            //chart.Series["Series1"].ChartType = SeriesChartType.HeatMap;

            //// Add some data to the chart
            //chart.Series["Series1"].Points.AddXY(0, 0, 1);
            //chart.Series["Series1"].Points.AddXY(1, 0, 2);
            //chart.Series["Series1"].Points.AddXY(2, 0, 3);
            //chart.Series["Series1"].Points.AddXY(0, 1, 4);
            //chart.Series["Series1"].Points.AddXY(1, 1, 5);
            //chart.Series["Series1"].Points.AddXY(2, 1, 6);
            //chart.Series["Series1"].Points.AddXY(0, 2, 7);
            //chart.Series["Series1"].Points.AddXY(1, 2, 8);
            //chart.Series["Series1"].Points.AddXY(2, 2, 9);

            //// Set the color scale for the heatmap
            //chart.Series["Series1"]["Palette"] = "HeatMap";

            //// Add a legend to the chart
            //chart.Legends.Add("Legend1");

            //// Add the chart to a form
            //this.Controls.Add(chart);


        }
    }
}
