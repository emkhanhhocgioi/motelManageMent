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
                    results.Add(customer.CustomerName);
                }
            }


            return results.ToArray();
        }
       

    }
}
