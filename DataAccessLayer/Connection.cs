﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection bgl=new SqlConnection(@"Data Source=MSI;Initial Catalog=DbStaff;Integrated Security=True");
    }
}
