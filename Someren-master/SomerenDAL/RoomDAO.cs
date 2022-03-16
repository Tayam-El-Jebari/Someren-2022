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
    public class RoomDAO : BaseDao
    {
        public List<Room>GetAllRooms()
        {
            try
            {
                // change attributes from Room, give them the right name. 
                string query = "SELECT roomNumber, capacity, type FROM [Room]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                // within this exception show te user that something went wrong. 
                throw new Exception("Rooms could not be loaded properly. Please try again" + e.Message);
            }
        }
        private List<Room> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Room> rooms = new List<Room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Room room = new Room()
                    {
                        // studentID en teacherID? 
                        Number = (int)dr["roomNumber"],
                        Capacity = (int)dr["capacity"],
                        Type = (string)dr["type"]
                    };
                    rooms.Add(room);
                }
                return rooms;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try agian" + e.Message);
            }
        }
    }
}
