using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Revenue_Service
    {
        Reveneue_DAO Reveneue_db = new Reveneue_DAO();

        public List<Revenue> GetRevenue(DateTime start,DateTime end)
        {
            try
            {
                List<Revenue> revenues = Reveneue_db.Get_All_Sales(start,end);
                return revenues;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
