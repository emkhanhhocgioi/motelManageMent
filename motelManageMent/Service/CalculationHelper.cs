using motelManageMent.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int sumRoom(List<Room> list)
        {
            int count = 0;
            foreach (Room roo in list)
            {
                count++;
            }
            return count;



        }
        public int sumOrder(List<Bookeds> list)
        {
            int count = 0;
            foreach (Bookeds b in list)
            {
                count++;
            }
            return count;
        }

        public int SumDoanhThu(List<Bookeds> list, int month, int year)
        {
            int sum = 0;

            try
            {
                // Kiểm tra nếu list là null hoặc rỗng
                if (list == null || list.Count == 0)
                {
                    throw new ArgumentException("Danh sách đơn hàng không hợp lệ.");
                }
                foreach (Bookeds b in list)
                {
                    if (b.OrderStatus == 1 && b.CreateTime.Month ==month && b.CreateTime.Year == year)
                    {
                        sum = sum + b.OrderSum;
                    }

                }

            }
            catch (Exception ex)
            {
            
                
             
            }
            return sum;
        }

        public Dictionary<string, int> doanhthutochart(List<Bookeds> list)
        {
            Dictionary<string, int> monthData = new Dictionary<string, int>();

     
            for (int i = 1; i <= 12; i++)
            {
                int sum = 0; 
        
                foreach (Bookeds b in list)
                {
                    
                    if (b.CreateTime.Month == i)
                    {
                        sum += b.OrderSum; 
                    }
                }

               
                if (sum > 0)
                {
                    monthData.Add("Tháng " + i, sum);
                }
                else
                {
                    monthData.Add("Tháng " + i, 0);
                }
            }

            return monthData;
        }
      
       
        public int sumOrderMonth(List<Bookeds> list, int month, int year)
        {
            int count = 0;
            foreach (Bookeds b in list)
            {
                if (b.CreateTime.Month == month && b.CreateTime.Year ==year)
                {

                    count++;
                }
             
            }
            return count;
        }

        public Dictionary<string, int> CountSumToChart(List<Bookeds> list,int? month,int? year)
        {
            Dictionary<string, int> monthData = new Dictionary<string, int>();

            if(month != null && year != null)
            {
                for (int i = 1; i <= 12; i++)
                {
                    int sum = 0;

                    foreach (Bookeds b in list)
                    {

                        if (b.CreateTime.Month == i)
                        {
                            sum += b.OrderSum;
                        }
                    }


                    if (sum > 0)
                    {
                        monthData.Add("Tháng " + i, sum);
                    }
                    else
                    {
                        monthData.Add("Tháng " + i, 0);
                    }
                }

            }
            else
            {

            }
            

            return monthData;
        }


        public int doanhthutest(List<Bookeds> li)
        {
            int sum = 0;
            foreach (Bookeds b in li)
            { 
                if(b.OrderStatus == 1)
                {
                    sum = sum + b.OrderSum;
                }
              
            }
            return sum;
        
        }


    }
}
