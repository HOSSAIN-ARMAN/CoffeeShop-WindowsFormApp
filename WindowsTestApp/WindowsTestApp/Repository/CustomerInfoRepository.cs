using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WindowsTestApp.Model;

namespace WindowsTestApp.Repository
{
    public class CustomerInfoRepository
    {

        public bool Save(CustomerInfoModel customerInfoModel)
        {
            bool isSave = false;

            try
            {
                string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(connection);
                string query = @"INSERT INTO Customers (Name, Address, Contact) VALUES ('" + customerInfoModel.Name + "', '" + customerInfoModel.Address + "','" + customerInfoModel.Contact + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    isSave = true;
                }
                sqlConnection.Close();
            }catch(Exception exception)
            {

            }

            return isSave;
        }
        public DataTable Display()
        {
            string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            
          
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public List<CustomerInfoModel> delete(CustomerInfoModel customerInfoModel)
        {
            string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"DELETE FROM Customers WHERE Id = "+customerInfoModel.Id+"";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<CustomerInfoModel> deleteCustomerInfo = new List<CustomerInfoModel>();
            
            while (sqlDataReader.Read())
            {
                customerInfoModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customerInfoModel.Name = sqlDataReader["Name"].ToString();
                customerInfoModel.Address = sqlDataReader["Address"].ToString();
               customerInfoModel.Contact = sqlDataReader["Contact"].ToString();
               deleteCustomerInfo.Add(customerInfoModel);
            }

            sqlConnection.Close();

            return deleteCustomerInfo;
        }
        public List<CustomerInfoModel> Upddate(CustomerInfoModel customerInfoModel)
        {
            string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"UPDATE Customers SET Name = '"+ customerInfoModel.Name + "', Address = '"+customerInfoModel.Address+"', Contact = '"+customerInfoModel.Contact+"' WHERE Id = "+customerInfoModel.Id+"";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<CustomerInfoModel> updateCustomerInfo = new List<CustomerInfoModel>();
            updateCustomerInfo.Add(customerInfoModel);

            sqlConnection.Close();
            return updateCustomerInfo;
        }
        public List<CustomerInfoModel> Search(CustomerInfoModel customerInfoModel)
        {
            string connection = @"Server = DESKTOP-CUF3262; DataBase = TestApp; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Customers WHERE Name = '"+customerInfoModel.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<CustomerInfoModel> customerSearch = new List<CustomerInfoModel>();
            while (sqlDataReader.Read())
            {
                customerInfoModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customerInfoModel.Name = sqlDataReader["Name"].ToString();
                customerInfoModel.Address = sqlDataReader["Address"].ToString();
                customerInfoModel.Contact = sqlDataReader["Contact"].ToString();
                customerSearch.Add(customerInfoModel);
            }
            sqlConnection.Close();
            return customerSearch;
        }
    }
}
