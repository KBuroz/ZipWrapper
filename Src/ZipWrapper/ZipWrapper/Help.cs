using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipWrapper
{
    public class Help : IHelp
    {
        public void GetHelp()
        {
            Console.WriteLine("Example Commands:");
            Console.WriteLine("  ZipWrapper create C:\\mydirectory C:\\documents\\mydirectory.zip\r\n");
            Console.WriteLine("  ZipWrapper extract C:\\mydirectory C:\\documents\\directoryToZipInto\r\n");
        }

        public void GetHelp(string arg)
        {
            if (arg == null)
                return;

            var helpItem = arg.ToUpper().Trim();

            if(helpItem == "CREATE")
            {
                Console.WriteLine("Create:");
                Console.WriteLine("  Arguments:");
                Console.WriteLine("    ZipWrapper create <Directory> <Output> <CompressionLevel> <Include> <Encoding>\r\n");
                Console.WriteLine("      <Directory> - The path to the directory to be archived, specified as a relative or absolute path. A relative path is interpreted as relative to the current working directory.");
                Console.WriteLine("      <Output> - The path of the archive to be created, specified as a relative or absolute path. A relative path is interpreted as relative to the current working directory.");
                Console.WriteLine("      <CompressionLevel> - One of the enumeration values that indicates whether to emphasize speed or compression effectiveness when creating the entry.");
                Console.WriteLine("         Fastest, NoCompression, or Optimal");
                Console.WriteLine("      <Include> - 'true' to include the directory name from sourceDirectoryName at the root of the archive; 'false' to include only the contents of the directory.");
                Console.WriteLine("      <Encoding> - The encoding to use when reading or writing entry names in this archive. Specify a value for this parameter only when an encoding is required for interoperability with zip archive tools and libraries that do not support UTF-8 encoding for entry names.");
                Console.WriteLine("  Examples:");
                Console.WriteLine("    ZipWrapper create C:\\mydirectory C:\\documents\\mydirectory.zip\r\n");
                Console.WriteLine("    ZipWrapper create C:\\mydirectory\\myFile.txt C:\\documents\\myfile.zip\r\n");
                Console.WriteLine("    ZipWrapper create C:\\mydirectory mydirectory.zip Optimal true UTF8\r\n");
            }
            else if(helpItem == "EXTRACT")
            {
                Console.WriteLine("Extract:");
                Console.WriteLine("  Arguments:");
                Console.WriteLine("  ZipWrapper extract <Zip> <Directory> <Encoding>");
                Console.WriteLine("      <Zip> - The path to the archive that is to be extracted.");
                Console.WriteLine("      <Directory> - The path to the directory in which to place the extracted files, specified as a relative or absolute path. A relative path is interpreted as relative to the current working directory.");
                Console.WriteLine("      <Encoding> - The encoding to use when reading or writing entry names in this archive. Specify a value for this parameter only when an encoding is required for interoperability with zip archive tools and libraries that do not support UTF-8 encoding for entry names.");
                Console.WriteLine("  Examples:");
                Console.WriteLine("  ZipWrapper extract C:\\documents\\mydirectory.zip C:\\mydirectory");
                Console.WriteLine("  ZipWrapper extract C:\\documents\\mydirectory.zip C:\\mydirectory UTF8");
            }
        }
    }
}
