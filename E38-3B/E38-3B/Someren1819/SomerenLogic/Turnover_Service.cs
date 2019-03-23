using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Turnover_Service
    {
        Turnover_DAO turnover_db = new Turnover_DAO();

        public List<Turnover> GetTurnover()
        {
            try
            {
                List<Turnover> turnovers = turnover_db.Get_All_Turnovers();
                return turnovers;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
