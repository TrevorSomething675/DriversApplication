using System.Data.SqlClient;
using System.Configuration;

namespace DriversApplication
{
    sealed class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["JIJA"].ConnectionString); //Получение строки из App.config
        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
