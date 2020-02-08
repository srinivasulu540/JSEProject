using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccess
{
    public class AppContext: DbContext
    {
        private readonly string connectionString;
        public AppContext(string connectionName):base()
        {
            this.connectionString = connectionName;
        }
    }
}
