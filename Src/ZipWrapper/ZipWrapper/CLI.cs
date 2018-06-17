using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipWrapper
{
    public class CLI
    {
        IZipShell _zipShell;

        public CLI(IZipShell zipShell)
        {
            _zipShell = zipShell;
        }

        public void ParseCommand(string[] args)
        {
            if(args.Length > 0)
            {
                var primaryArg = args[0].ToUpper();

                switch(primaryArg)
                {
                    case "EXTRACT":
                        // TODO: Validate the extract command args
                        // CommandValidator.ValidateExtract(args);
                        if (args.Length == 3)
                        {
                            _zipShell.ExtractToDirectory(args[1], args[2]);
                        }
                        else if(args.Length == 4)
                        {
                            throw new NotImplementedException("Different encodings are not yet implemented.");
                            // _zipShell.ExtractToDirectory(args[1], args[2], encoding.Parse(args[3]) );
                        }
                        break;
                    case "CREATE":
                        if (args.Length == 3)
                        {
                            _zipShell.CreateFromDirectory(args[1], args[2]);
                        }
                        else if (args.Length == 5)
                        {
                            throw new NotImplementedException("Compression level and additional options are not yet implemented.");
                            // _zipShell.CreateFromDirectory(args[1], args[2], compression.Parse(args[3]), bool.Parse(args[4]))
                        }
                        else if (args.Length == 5)
                        {
                            throw new NotImplementedException("Compression level with different encoding is not yet implemented");
                            //_zipShell.CreateFromDirectory(args[1], args[2], compression.Parse(args[3]), bool.Parse(args[4]), encoding.Parse(args[5]));
                        }
                        break;
                    default:
                        Help();
                        break;
                }
            }
            else
            {
                Help();
            }
        }

        private void Help()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("==  Help  ==========================");
            Console.WriteLine("====================================");


        }
    }
}
