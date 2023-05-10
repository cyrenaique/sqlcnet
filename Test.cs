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


        private void checkedListBox_Signal_ItemCheck(object sender, ItemCheckEventArgs e)
        {


            DataTable groupedDataTable = (DataTable)dg_test.DataSource ;



            //DataTable groupedDataTable = tab_test.AsEnumerable()
            //                           .GroupBy(row => row.Field<string>("batchid"))
            //                           .Select(group =>
            //                           {
            //                               DataRow newRow = tab_test.NewRow();
            //                               newRow["batchid"] = group.Key;

            //                               foreach (DataColumn column in tab_test.Columns)
            //                               {
            //                                   if (column.ColumnName != "batchid" && IsNumericType(column.DataType) )
            //                                   {
            //                                       newRow[column.ColumnName] = group.Average(row => row.Field<double>(column.ColumnName));
            //                                   }
            //                               }

            //                               return newRow;
            //                           })
            //                           .CopyToDataTable();
            // Loop through the rows of the DataGridView and add them to the plot
            var sp= new ScottPlot.Plot();
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
               
                if (checkedListBox_Signal.GetItemCheckState(i).ToString() == "Checked")
                {
                    var sp2 = formsPlot1.Plot.AddSignal(values, label: groupedDataTable.Rows[i]["batchid"].ToString());
                    sp2.Smooth = true;
                }
                if (checkedListBox_Signal.GetItemCheckState(i).ToString()!="Checked")
                {
                    formsPlot1.Plot.Remove(sp);
                }
               

            }
           

                //TF.formsPlot1.Plot.XAxis.SetBoundary(0, tbl_profiles.Columns.Count-4);

                formsPlot1.Plot.AxisAuto();
            formsPlot1.Plot.Legend();
            formsPlot1.Refresh();
            // Display the plot in a new form

            //form.Controls.Add(plt);
            //Show();
        }
    }
}
