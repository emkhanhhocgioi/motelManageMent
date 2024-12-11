using motelManageMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motelManageMent.Service
{
    class CalculationHelper
    {
        public CalculationHelper() {
        }

        public int sumCustomer(List<Customer> list)
        {
            int count = 0;
            foreach (Customer customer in list)
            {
                count++;
            }
            return count;
        
        

        }
        public int sumCustomer(List<Room> list)
        {
            int count = 0;
            foreach (Room roo in list)
            {
                count++;
            }
            return count;



        }

    }
}
