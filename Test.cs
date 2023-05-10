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

namespace sqlcnet
{
    public partial class TestForm : Form
    {
        //private DataTable _tabName;
        public TestForm()
        {
            InitializeComponent();
            //_tabName = tabName;
        }

        private static bool IsNumericType(Type type)
        {
            return type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(long) || type == typeof(short);
        }
        

        private void checkedListBox_Signal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable groupedDataTable = (DataTable)dg_test.DataSource;

            ScottPlot.Plottable.SignalPlot sp = new ScottPlot.Plottable.SignalPlot();
            formsPlot1.Plot.Clear();
            for (int i = 0; i < groupedDataTable.Rows.Count; i++)
            //foreach (int i in checkedListBox_Signal.CheckedIndices)
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


                    sp = formsPlot1.Plot.AddSignal(values, label: groupedDataTable.Rows[i]["batchid"].ToString());
                    sp.Smooth = true;
                    formsPlot1.Plot.AxisAuto();
                    formsPlot1.Plot.Legend();
                    formsPlot1.Refresh();
                }



            }

        }
    }
}
