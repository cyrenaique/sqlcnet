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
        public TestForm()
        {
            InitializeComponent();
        }

        private static bool IsNumericType(Type type)
        {
            return type == typeof(decimal) || type == typeof(double) || type == typeof(float) || type == typeof(int) || type == typeof(long) || type == typeof(short);
        }


        private void checkedListBox_Signal_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            LoadCpdsForm LC = new LoadCpdsForm();
            TestForm TF = new TestForm();
            var dataTable = ((LoadCpdsForm.)Application.OpenForms["profiles"]).DataTable;

            DataTable groupedDataTable = LC.tbl_profiles.AsEnumerable()
                                       .GroupBy(row => row.Field<string>("batchid"))
                                       .Select(group =>
                                       {
                                           DataRow newRow = LC.tbl_profiles.NewRow();
                                           newRow["batchid"] = group.Key;

                                           foreach (DataColumn column in LC.tbl_profiles.Columns)
                                           {
                                               if (column.ColumnName != "batchid" && IsNumericType(column.DataType) )
                                               {
                                                   newRow[column.ColumnName] = group.Average(row => row.Field<double>(column.ColumnName));
                                               }
                                           }

                                           return newRow;
                                       })
                                       .CopyToDataTable();
            // Loop through the rows of the DataGridView and add them to the plot
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

                if (TF.checkedListBox_Signal.GetItemCheckState(i).ToString()== groupedDataTable.Rows[i]["batchid"].ToString())
                {

                }
                var sp = TF.formsPlot1.Plot.AddSignal(values, label: groupedDataTable.Rows[i]["batchid"].ToString());
                TF.checkedListBox_Signal.Items.Add(groupedDataTable.Rows[i]["batchid"].ToString());

                sp.Smooth = true;

            }
           

                //TF.formsPlot1.Plot.XAxis.SetBoundary(0, tbl_profiles.Columns.Count-4);

                TF.formsPlot1.Plot.AxisAuto();
            TF.formsPlot1.Plot.Legend();
            TF.formsPlot1.Refresh();
            // Display the plot in a new form

            //form.Controls.Add(plt);
            TF.Show();
        }
    }
}
