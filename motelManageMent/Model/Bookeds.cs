using System;

namespace motelManageMent.Model
{
    public class Bookeds
    {
    
        public int BID { get; set; }          
        public int CustomerID { get; set; }     
        public string CustomerName { get; set; }
        public string ResidentID { get; set; }  
        public string PhoneNumber { get; set; }   
        public int RoomID { get; set; }        
        public string RoomType { get; set; }      
        public DateTime CreateTime { get; set; } 
        public DateTime EndTime { get; set; }     
        public int OrderStatus { get; set; }     


        public Bookeds(int bid, int customerID, string customerName, string residentID,
                             string phoneNumber, int roomID, string roomType,
                             DateTime createTime, DateTime endTime, int orderStatus)
        {
            BID = bid;
            CustomerID = customerID;
            CustomerName = customerName;
            ResidentID = residentID;
            PhoneNumber = phoneNumber;
            RoomID = roomID;
            RoomType = roomType;
            CreateTime = createTime;
            EndTime = endTime;
            OrderStatus = orderStatus;
        }


        public Bookeds() { }
    }
}
