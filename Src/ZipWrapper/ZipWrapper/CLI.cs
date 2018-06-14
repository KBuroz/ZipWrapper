using System;
using System.Collections.Generic;
using System.Linq;

namespace ZipWrapper
{
    class CLI
    {
        IZipShell _zipShell;

        public CLI(IZipShell zipShell)
        {
            _zipShell = zipShell;
        }

        public void ParseCommand(string[] args)
        {
            
        }
    }
}
