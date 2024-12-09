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

        public int IsOccupied { get; set; }
        // Constructor
        public Room(int id, string roomType, int roomNumber , int isocupied)
        {
            Id = id;
            RoomType = roomType;
            RoomNumber = roomNumber;
            IsOccupied = isocupied;
        }

        // Default constructor (optional)
        public Room()
        {
        }
    }
}
