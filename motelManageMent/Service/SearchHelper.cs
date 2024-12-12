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

                if (room.Id.ToString().Contains(pointer) && room.IsOccupied != 1 )
                {
                    results.Add("Phòng:"+room.Id+" | "+room.RoomType);
                }
            }


            return results.ToArray();
        }

        public void sortTableUsing(List<Bookeds> list, string pointer,DataGridView dtg, bool searchchange, bool datecheck ,bool datecheck2,DateTime ta,DateTime tb)
        {
            if (datecheck == true && datecheck2 == true && searchchange ==true)
            {
               
                pointer = pointer.Trim();
                List<Bookeds> li = new List<Bookeds>();
                foreach (Bookeds booked in list)
                {
                    if (booked.CustomerName.Contains(pointer) || booked.PhoneNumber.Contains(pointer) && booked.CreateTime >= ta && booked.CreateTime <=tb )
                    {
                        li.Add(booked);

                    }
                }
                dtg.DataSource = li;

            }
            else if (searchchange == true && datecheck == false && datecheck2 == false)
            {
                pointer = pointer.Trim();
                List<Bookeds> li = new List<Bookeds>();
                foreach (Bookeds booked in list)
                {
                    if (booked.CustomerName.Contains(pointer) || booked.PhoneNumber.Contains(pointer))
                    {
                        li.Add(booked);

                    }
                }
                dtg.DataSource = li;
            }else if(searchchange == false && datecheck == true && datecheck2 == true)
            {
                pointer = pointer.Trim();
                List<Bookeds> li = new List<Bookeds>();
                foreach (Bookeds booked in list)
                {
                    if (booked.CreateTime >= ta && booked.CreateTime <= tb)
                    {
                        li.Add(booked);

                    }
                }
                dtg.DataSource = li;
            }
            
          

        }

    }
}
