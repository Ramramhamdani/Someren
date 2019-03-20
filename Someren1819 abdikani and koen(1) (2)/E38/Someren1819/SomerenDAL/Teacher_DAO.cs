using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Teacher_DAO : Base
    {

        public List<Teacher> Db_Get_All_Teachers()
        {
            //string query = "SELECT * FROM [Teacher]";
            //  string query = "SELECT teacherID, name, beveragesID FROM [TABLE]";

            string query = "SELECT teacherID, FirstName, LastName, Supervisor FROM [Teacher]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    teacherID = Convert.ToInt32(dr["teacherID"]),
                    FirstName = (String)(dr["FirstName"].ToString()),
                    LastName = (String)(dr["LastName"].ToString()),
                    Supervisor = (String)(dr["Supervisor"].ToString()),

                };
                teachers.Add(teacher);
            }
            return teachers;
        }

    }
}
