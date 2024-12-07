using System;

namespace motelManageMent.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }  
        public string CustomerName { get; set; }
        public int ResidentID { get; set; }  
        public DateTime DOB { get; set; }  
        public int Gender { get; set; }      
        public int RoomID { get; set; }     
        public byte[] FImage { get; set; }     
        public byte[] BImage { get; set; }     

        // Constructor mặc định
        public Customer()
        {
        }

        // Constructor có tham số
        public Customer(int customerID, string customerName, int residentID, DateTime dob, int gender, int roomID, byte[] fImage, byte[] bImage)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            ResidentID = residentID;
            DOB = dob;
            Gender = gender;
            RoomID = roomID;
            FImage = fImage;
            BImage = bImage;
        }

        // Constructor với các tham số mà không cần CustomerID (do CustomerID là auto-increment)
        public Customer(string customerName, int residentID, DateTime dob, int gender, int roomID, byte[] fImage, byte[] bImage)
        {
            CustomerName = customerName;
            ResidentID = residentID;
            DOB = dob;
            Gender = gender;
            RoomID = roomID;
            FImage = fImage;
            BImage = bImage;
        }
    }
}
