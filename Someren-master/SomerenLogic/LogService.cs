using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LogService
    {
        public void WriteLog(string message)
        {
            string filename = "...\\...\\...\\LogFile.txt";
            StreamWriter writer = new StreamWriter(filename, true);

            if (File.Exists(filename))
            {
                writer.WriteLine($"{DateTime.Now} --- error occured. Please read the pop up that appeared on your screen and try again. " +
                    $"If the problem can't be solved, feel free to reach out on us. ");
            }
            else
            {
                throw new Exception($"Could not find the file {filename}. Please try again!");
            }
            // close writer //
            writer.Close();
            
        }
    }
}

