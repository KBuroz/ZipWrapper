using System;
using System.IO;
using System.IO.Compression;

namespace ZipWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) Help(args);
            else if (args[0].ToUpper() == "EXTRACT") EXTRACT(args);
            else if (args[0].ToUpper() == "CREATE") CREATE(args);
            else if (args[0].ToUpper() == "HELP") Help(args);
            else Help(args);
        }

        static void EXTRACT(string[] args)
        {
            
        }

        static void CREATE(string[] args)
        {

        }

        static void Help(string[] args)
        {
            Console.WriteLine("Examples:\r\n");
            Console.WriteLine("  ZipWrapper Extract\r\n");
            Console.WriteLine("  ZipWrapper Create\r\n");
        }
    }
}
