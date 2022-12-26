using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest.APP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"26-12-2022 05:54:59 - {GetTurn(new DateTime(2022, 12, 26, 05, 54, 59))}");
            Console.WriteLine($"26-12-2022 06:10:00 - {GetTurn(new DateTime(2022, 12, 26, 06, 10, 00))}");
            Console.WriteLine($"26-12-2022 06:11:00 - {GetTurn(new DateTime(2022, 12, 26, 06, 11, 00))}");
            Console.WriteLine($"26-12-2022 16:49:59 - {GetTurn(new DateTime(2022, 12, 26, 16, 49, 59))}");
            Console.WriteLine($"26-12-2022 16:50:00 - {GetTurn(new DateTime(2022, 12, 26, 16, 50, 00))}");
        }


        enum Shift { Diurno, Noturno }

        static Shift GetTurn(DateTime dataInformHour)
        {
            TimeSpan InformData = new TimeSpan(dataInformHour.Hour, dataInformHour.Minute, dataInformHour.Second);

            if (InformData <= new TimeSpan(06, 10, 00) && InformData >= new TimeSpan(05, 55, 00) || InformData > new TimeSpan(16, 49, 59))
                return Shift.Noturno;

            return Shift.Diurno;
        }
    }
}
