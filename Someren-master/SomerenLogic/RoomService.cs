using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RoomService
    {
        private RoomDAO roomdb;

        public RoomService()
        {
            roomdb = new RoomDAO();
        }

        public List<Room> GetRooms()
        {
            List<Room> rooms = roomdb.GetAllRooms();
            return rooms;
        }
    }
}
