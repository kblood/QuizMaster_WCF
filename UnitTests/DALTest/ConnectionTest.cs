using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System.Data.SqlClient;

namespace UnitTests.DALTest
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void TestConnection()
        {
            Repository<int> rep = new Repository<int>();
            SqlConnection con = new SqlConnection(rep.ConnectionString);
            con.Open();
            con.Close();
        }
    }
}
