using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class Reveneue_DAO:Base
    {
        public List<Revenue> Get_All_Sales()
        {
            string query = "select count (StudentName) as NumberOfCustomers,StudentName, COUNT(*) as NumberOfSales from CashRegister group by StudentName having COUNT(StudentName)> 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenues = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenue = new Revenue()
                {
                    Sales = (int)dr["NumberOfSales"],
                    NCustomers = (int)dr["NumberOfCustomers"],
                    StudentName = (string)dr["StudentName"]
                };
                revenues.Add(revenue);
            }
            return revenues;
        }
    }
    
}
