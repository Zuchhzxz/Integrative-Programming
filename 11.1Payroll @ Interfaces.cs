using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class payroll
    {
        static void Main(string[] args)
        {
            string emp_name, position, reply;
            int no_days_work = 0, n = 0;
            double sss = 0, philhealth = 0, tax = 0, pag_ibig = 0, daily_rate = 0;
            double total_deductions = 0, gross_pay = 0, net_pay = 0;


            do
            {
                Console.Clear();
                Console.Write("EMPLOYEE'S PAYROLL SYSTEM");
                Console.Write("\n\n");
                Console.Write("Enter Employee's Name       : ");
                emp_name = Console.ReadLine();
                Console.Write("Enter Employee's Position   : ");
                position = Console.ReadLine();
                Console.Write("Enter Number of Day's Work  : ");
                no_days_work = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Daily Salary Rate     : ");
                daily_rate = Convert.ToDouble(Console.ReadLine());

                gross_pay = (no_days_work * daily_rate);

                Console.Write("\n\n");
                Console.WriteLine("Gross Pay       : Php {0:0.00}.", gross_pay);
                Console.Write("\n\n");
                Console.Write("===== DEDUCTIONS =====");
                Console.Write("\n\n");
                Console.Write("Enter SSS Contribution            : ");
                sss = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter PAG-IBIG Contribution       : ");
                pag_ibig = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter PHILHEALTH Contribution     : ");
                philhealth = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter BIR TAX Contribution        : ");
                tax = Convert.ToDouble(Console.ReadLine());

                total_deductions = (sss + pag_ibig + philhealth + tax);

                net_pay = (gross_pay - total_deductions);

                Console.Write("\n\n");
                Console.WriteLine("Total Deductions      : Php {0:0.00}.", total_deductions);
                Console.Write("\n\n");
                Console.Write("===== DISPLAY RESULTS =====");
                Console.Write("\n\n");
                Console.WriteLine("Employee's Name       : {0}.", emp_name);
                Console.WriteLine("Empoyee's  Position   : {0}.", position);
                Console.WriteLine("Gross Pay             : Php {0:0.00}.", gross_pay);
                Console.WriteLine("Total Deductions      : Php {0:0.00}.", total_deductions);
                Console.Write("\n\n");
                Console.WriteLine("Net Pay               : Php {0:0.00}.", net_pay);
                Console.Write("\n\n");
                Console.Write("Do You Want To Continue? Y/N : ");
                reply = Console.ReadLine();

                if (reply == "y" || reply == "Y")
                {
                    continue;
                }
                else if (reply == "n" || reply == "N")
                {
                    Console.Write("\n\n");
                    Console.Write("Thank You For Using This Software.");
                    Console.Write("\n\n");
                    break;
                }

            } while (n == 0);
            Console.ReadLine();
        }
    }
}
