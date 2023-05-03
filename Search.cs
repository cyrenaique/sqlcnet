using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlcnet
{
    internal class Search:LoadCpdsForm
    {
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
                    var command = new NpgsqlCommand($"SELECT * FROM {table} WHERE {col} = '{text}'", conn);

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
