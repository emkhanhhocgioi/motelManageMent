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
        public int PhoneNumber { get; set; } 
        public byte[] FImage { get; set; }
        public byte[] BImage { get; set; }

     
        public Customer()
        {
        }

    
        public Customer(int customerID, string customerName, int residentID, DateTime dob, int gender, int phoneNumber, byte[] fImage, byte[] bImage)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            ResidentID = residentID;
            DOB = dob;
            Gender = gender;
            PhoneNumber = phoneNumber;
            FImage = fImage;
            BImage = bImage;
        }

      
        public Customer(string customerName, int residentID, DateTime dob, int gender, int phoneNumber, byte[] fImage, byte[] bImage)
        {
            CustomerName = customerName;
            ResidentID = residentID;
            DOB = dob;
            Gender = gender;
            PhoneNumber = phoneNumber;
            FImage = fImage;
            BImage = bImage;
        }
    }
}
