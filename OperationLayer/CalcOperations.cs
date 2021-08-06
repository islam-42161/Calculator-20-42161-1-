using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationLayer
{
    public class CalcOperations
    {
        public int newCalculation()
        {
            int result = 0;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QETIVTO;Initial Catalog=Lab Task Database;Integrated Security=True");
            connection.Open();
            string query = "";
            SqlCommand cmd = new SqlCommand(query,connection);
            connection.Close();
            return result;
        }
    }
}
