using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace logapri
{
    public class Logging
    {
        public static void log()
        {
            String message = "";
            String[] levels = {"error","debug", "warning" };
            String path = "C:/Users/User/Desktop/log.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            { sw = File.CreateText(path); }
            else
            { sw = File.AppendText(path); }
            //sw.WriteLine();

            for (int i = 0; i < levels.Length; i++)
            {
                message = "[" + levels[i] + "] this is " + levels[i] + " : " + DateTime.Now.ToString();
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine(message);
                }
            }

            sw.WriteLine("-----------------------------------------------------");

            sw.Flush();
            sw.Close();
        }

        public static void log(String mess)
        {
            String message = mess;
            String[] levels = { "error", "debug", "warning" };
            String path = "C:/Users/User/Desktop/log.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            { sw = File.CreateText(path); }
            else
            { sw = File.AppendText(path); }

            for (int i = 0; i < levels.Length; i++)
            {
                message = "[" + levels[i] + "] this is " + levels[i] + " : " + DateTime.Now.ToString();
                for (int j = 0; j < 3; j++)
                {
                    sw.WriteLine(message);
                }
            }

            sw.WriteLine("-----------------------------------------------------");

            sw.Flush();
            sw.Close();
        }
    }
}
