using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class StaffRoom_DAO:Base
    {
        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT staffRoomID, capacity, type FROM [Staff Room]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["staffRoomID"],
                    Capacity = (int)dr["capacity"],
                    teacher = (string)dr["type"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
