using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ClassLibraryTest
{

    public class TestRepo : ITestRepo
    {
        private readonly IConfiguration _configuration;
        public TestRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetTestConnectionString()
        {
            return _configuration.GetConnectionString("Database");
        }

        public bool TestConnection()
        {
            using (var con = new NpgsqlConnection(_configuration.GetConnectionString("Database")))
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
