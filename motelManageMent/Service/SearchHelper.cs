using motelManageMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motelManageMent.Service
{
    public class SearchHelper
    {

        public SearchHelper() { 

        }

        public string[] SearchChing(List<Customer> list, string pointer)
        {
            pointer = pointer.Trim();
            List<string> results = new List<string>();

      
            foreach (var customer in list)
            {
         
                if (customer.CustomerName.Contains(pointer))
                {
                    results.Add(customer.CustomerID+":"+customer.CustomerName);
                }
            }


            return results.ToArray();
        }

        public string[] SearchRoom(List<Room> list, string pointer)
        {
            pointer = pointer.Trim();
            List<string> results = new List<string>();


            foreach (var room in list)
            {

                if (room.Id == int.Parse(pointer) && room.IsOccupied != 1 )
                {
                    results.Add("Phòng:"+room.Id+" | "+room.RoomType);
                }
            }


            return results.ToArray();
        }

    }
}
