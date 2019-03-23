using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Room_Service
    {
        StaffRoom_DAO room_db = new StaffRoom_DAO();

        public List<Room> GetRoom()
        {
            try
            {
                List<Room> room = room_db.Db_Get_All_Rooms();
                return room;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
