using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTest.Views
{
    public static class VisualInterface
    {
        public static void WriteMenu()
        {
            Console.WriteLine("Hi! Choose an option to continue!\r\n" +
                               "  1. Add new plate\r\n" +
                               "  2. Show plates\r\n" +
                               "  3. Find a plate\r\n" +
                               "  4. Remove a plate\r\n" +
                               "  5. Generate excel with plates\r\n" +
                               "  6. Exit\r\n");
        }

        public static string AskForString(string answer)
        {
            Console.WriteLine(answer);
            return Console.ReadLine();
        }

        public static int AskForInteger(string answer)
        {
            Console.WriteLine(answer);
            return Console.Read();
        }
    }
}
