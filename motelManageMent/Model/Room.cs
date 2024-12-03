using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motelManageMent.Model
{
    public class Room
    {
        // Properties
        public int Id { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }

        // Constructor
        public Room(int id, string roomType, int roomNumber)
        {
            Id = id;
            RoomType = roomType;
            RoomNumber = roomNumber;
        }

        // Default constructor (optional)
        public Room()
        {
        }
    }
}
