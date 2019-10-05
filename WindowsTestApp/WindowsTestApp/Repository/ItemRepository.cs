using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using WindowsTestApp.Model;
using System.Text;
using System.Threading.Tasks;


namespace WindowsTestApp.Repository
{
    public class ItemRepository
    {
        public bool Add(TestItem testItem)
        {
            bool isAdded = false;
            try
            {

                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = @"INSERT INTO TestItems (ItemName, ItemPrice) VALUES ('" + testItem.ItemName+ "', " + testItem.ItemPrice + ")";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();//ExecuteNonQuery return 0, 1

                if (isExecute > 0)
                {
                    isAdded = true;

                }

                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return isAdded;
        }
        public bool IsNameExits(TestItem testItem)
        {
            bool isNameExits = false;
            try
            {
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);

                string query = @"SELECT * FROM TestItems WHERE ItemName = '" + testItem.ItemName + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    isNameExits = true;
                    //displayDataGridView.DataSource = dataTable;
                    //itemName = "";
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Error: " + exception.Message);
            }
            return isNameExits;
        }

        public bool Delete(TestItem testItem)
        {
            bool deleteData = false;
            try
            {
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = "DELETE FROM TestItems WHERE Id = " + testItem.Id + "";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int execute = sqlCommand.ExecuteNonQuery();
                if (execute > 0)
                {
                    deleteData = true;
                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Error: " + exception.Message);
            }
            return deleteData;
        }
        public DataTable Update(TestItem testItem)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = @"UPDATE TestItems SET ItemName = '" + testItem.ItemName + "', ItemPrice = " + testItem.ItemPrice + " WHERE Id = " + testItem.Id + "";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.Fill(dataTable);
                
                //if (execute > 0)
                //{
                //    isUpdate = true;
                //}
                //sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Error: " + exception.Message);
            }
            return dataTable;
        }
        public DataTable InstantDisplayData()
        {
             string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = @"SELECT * FROM TestItems";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);           
                sqlConnection.Close();
                return dataTable;
           
        }
        public DataTable ShowData()
        {
            
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = @"SELECT * FROM TestItems";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
               
                sqlConnection.Close();
                return dataTable;
           
        }
        public DataTable Search(TestItem testItem)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);

                string query = @"SELECT * FROM TestItems WHERE ItemName = '" + testItem.ItemName + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                
                //if (dataTable.Rows.Count > 0)
                //{
                //    displayDataGridView.DataSource = dataTable;
                //    itemNameTextBox.Text = "";
                //}
                //else
                //{
                //    MessageBox.Show("Data Not Found");
                //    itemNameTextBox.Text = "";
                //}
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
               // MessageBox.Show("Error: " + exception.Message);
            }
            return dataTable;
        }
        public DataTable ItemComboBox()
        {
            string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT Id, ItemName FROM TestItems";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
    }
}
