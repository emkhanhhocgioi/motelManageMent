using System;

namespace motelManageMent.Model
{
    public class Bookeds
    {
      
        public int BookedID { get; set; }
        public int RoomID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }

      
        public Bookeds(int bookedID, int roomID, int customerID, DateTime createDate, string status)
        {
            BookedID = bookedID;
            RoomID = roomID;
            CustomerID = customerID;
            CreateDate = createDate;
            Status = status;
        }

     
        public Bookeds() { }
    }
}
