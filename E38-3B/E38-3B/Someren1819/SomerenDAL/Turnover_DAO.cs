using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data;
using System.Data.SqlClient;
namespace SomerenDAL
{
    public class Turnover_DAO:Base
    {
        public List<Turnover> Get_All_Turnovers()
        {
            string query = "select COUNT(CashRegister.DrinkName) as DrinksSold, CashRegister.DrinkName, CashRegister.StudentName, sum(Drink.SalesPrice) as PriceOfDrinks " +
                "from cashRegister " +
                "inner join Drink on CashRegister.DrinkName = Drink.DrinkName " +
                "group by CashRegister.DrinkName, CashRegister.StudentName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Turnover> ReadTables(DataTable dataTable)
        {
            List<Turnover> turnovers = new List<Turnover>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Turnover turnover = new Turnover()
                {
                    Sales = (int)dr["DrinksSold"],
                    Price = (int)dr["PriceOfDrinks"],
                    DrinkName = (string)dr["DrinkName"]
                };
                turnovers.Add(turnover);
            }
            return  turnovers;
        }
    }
}
