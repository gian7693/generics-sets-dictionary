using System;
using System.Collections.Generic;
using System.Numerics;
using Course.Entities;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            try
            {
                using(StreamReader sr = File.OpenText(path)) 
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        LogRecord logRecord = new LogRecord(line[0], DateTime.Parse(line[1]));
                        set.Add(logRecord);
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}