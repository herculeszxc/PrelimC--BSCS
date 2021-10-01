using System;

namespace Prelim
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, position;
            int idNum;
            double rpd, ndw, rph, otr, nhw, gross, tax, sss, phh, pgi, total, net, otrhw, nhww;

            Console.Write("//////////////////////////////////////////////////////////////////////////\n");
            Console.Write("\t\t\t- PRELIM EXAMINATION | SDF 104 -\n");
            Console.Write("\t\t\t    HERC BANDIOLA - BSCS - 2A\n");
            Console.Write("//////////////////////////////////////////////////////////////////////////\n");
            Console.Write("Name of employee: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Position: ");
            position = Convert.ToString(Console.ReadLine());

            Console.Write("ID number: ");
            idNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rate per day: ");
            rpd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of days work: ");
            ndw = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rate per hour: ");
            rph = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of hours work: ");
            nhw = Convert.ToDouble(Console.ReadLine());

            Console.Write("Over time rate: ");
            otr = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of hour work: ");
            nhww = Convert.ToDouble(Console.ReadLine());

            
            rph = rpd / 8;
            otr = (rpd * .30) + rph;
            gross = (rpd * ndw) + (otr * nhww);
            tax = .08 * gross;
            sss = .05 * gross;
            phh = .02 * gross;
            pgi = .04 * gross;
            total = tax + sss + phh + pgi;
            net = gross - total;

            Console.Write("//////////////////////////////////////////////////////////////////////////\n");
            Console.Write("\t\t\t- GROSS INCOME: " + gross + "\n");
            Console.Write("//////////////////////////////////////////////////////////////////////////\n");
            Console.Write("\t\t- DEDUCTIONS: " + "\n");
            Console.Write("//////////////////////////////////////////////////////////////////////////\n");

            Console.Write("\t\t\t\tTAX: " + tax + "\n");
            Console.Write("\t\t\t\tSSS: " + sss + "\n");
            Console.Write("\t\t\t\tPHIL HEALTH: " + phh + "\n");
            Console.Write("\t\t\t\tPAG-IBIG: " + pgi + "\n");

            Console.Write(" ");

            Console.Write("\t\t\tTOTAL DEDUCTION: " + total + "\n");

            Console.Write(" ");
            Console.Write("//////////////////////////////////////////////////////////////////////////\n");
            Console.Write("\t\t\tNET INCOME: " + net + "\n");
            Console.Write("//////////////////////////////////////////////////////////////////////////\n");

        }
    }
}
