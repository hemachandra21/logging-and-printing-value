using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logapri
{
    internal class Getlogs
    {
        public Getlogs(String level)
        {
            String path = "C:/Users/User/Desktop/log.txt";

            String line;
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                if (level == "all")
                {
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else
                {
                    while (line != null)
                    {
                        if (line.Contains(level))
                            Console.WriteLine(line);

                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}