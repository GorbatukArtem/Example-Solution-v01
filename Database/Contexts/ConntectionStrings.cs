using System;
using Microsoft.Data.SqlClient;

namespace Database.Contexts
{
    public static class ConntectionStrings
    {
        public static string GetProductionConnectionString()
        {
            //var sqlbuilder = new SqlConnectionStringBuilder
            //{
            //    DataSource = @"", 
            //    InitialCatalog = "", 
                
            //    UserID = "", 
            //    Password = ""
            //};
            
            //return sqlbuilder.ConnectionString;

            throw new NotImplementedException();
        }
        public static string GetDevelopmentConnectionString()
        {
            var sqlbuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "MySolution",
                AttachDBFilename = @"C:\Users\gorba\source\repos\MySolution\Database\LocalDbs\MySolution.mdf", // |DataDirectory|

                IntegratedSecurity = true,
                ConnectTimeout = 30,

                Encrypt = false,
                TrustServerCertificate = false,
                MultipleActiveResultSets = true
            };
            
            return sqlbuilder.ConnectionString;
        }
    }
}