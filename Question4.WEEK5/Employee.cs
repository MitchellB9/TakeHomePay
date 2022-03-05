using System;
using System.Collections.Generic;
using System.Text;

namespace Question4.WEEK5
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpID { get; set; }
        public int Salary { get; set; }
        public int Hourly { get; set; }
        public int HoursClocked { get; set; }


        public double TakeHomePay()
        {
            double finalPay;
            double timeHalfPay = 0;
            int timeAndHalf = 0;

            if(Hourly > Salary)
            {
                if(HoursClocked > 40)
                {
                    timeAndHalf = HoursClocked - 40;
                    timeHalfPay = timeAndHalf * (Hourly * 1.5);
                }
                finalPay = (Hourly * (HoursClocked - timeAndHalf)) + timeHalfPay;
                return finalPay - Retirement(finalPay) - SocialS(finalPay) - FedTax(finalPay);
            }
            else
            {
                finalPay = Salary - Retirement(Salary) - SocialS(Salary) - FedTax(Salary);
                return finalPay;
            }
        }

        public double Retirement(double pay)
        {
            double ret;
            ret = pay * 0.10;
            return ret;
        }
        public double SocialS(double pay)
        {
            double soc;
            soc = pay * 0.06;
            return soc;
        }

        public double FedTax(double pay)
        {
            double fed;
            fed = pay * 0.18;
            return fed;
        }

        public override string ToString()
        {
            return "\nEmployee name: " + FirstName + " " + LastName + "\nEmployee ID: " + EmpID + "\nThe employee takes home $" + TakeHomePay();
        }



    }
}
