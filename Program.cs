using System.IO;

namespace logapri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logging.log();
            }
            catch (Exception ex)
            {
                Logging.log(ex.Message);
            }
            //while (true)
            //{

            //    Console.WriteLine("select level : error, debug, warning, all, 0");
            //    String ulevel = Console.ReadLine();
            //    if (ulevel == "0")
            //        break;
            //    Getlogs s = new Getlogs(ulevel);
            //}
        }
    }
}