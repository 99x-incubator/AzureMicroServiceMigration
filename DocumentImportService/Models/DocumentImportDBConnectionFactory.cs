using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentImportService.Models
{
    public class DocumentImportDBConnectionFactory
    {
        static string connection = @"Server=tcp:comphackdbserver.database.windows.net,1433;Initial Catalog=DocumentImport;Persist Security Info=False;User ID=compello;Password=Compdev123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private static SqlConnection sqlConnection;

        public static SqlConnection Get()
        {
            if(sqlConnection == null)
              sqlConnection = new SqlConnection(connection);

            return sqlConnection;
        }
    }
}
