using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipWrapper
{
    /// <summary>
    /// Checks user input and provides errors in case the input is not validated.
    /// </summary>
    public class ValidateCLI : IValidateCLI
    {
        internal IFileSystem fileSystem;
        internal string _Error_ZipFile_DoesNotExist = "<Zip File> argument does not exist.";
        internal string _Error_ExtractTo_DoesNotExist = "<Extract To> directory argument does not exist or it's parent does not exist.";
        internal string _Error_NoArgumentsProvided = "No arguments were provided.";

        public ValidateCLI()
        {
            fileSystem = new FileSystem();
        }
        public ValidateCLI(IFileSystem injectedFileSystem)
        {
            fileSystem = injectedFileSystem;
        }

        bool _validated = true;
        public List<string> Errors { get; private set; }

        /// <summary>
        /// Checks and validates the input from the user
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public bool Validate(string[] args)
        {
            if (args.Length == 0)
            {
                AddError(_Error_NoArgumentsProvided);
            }
            else if(args[0].ToUpper() == "EXTRACT")
            {
                // First signature ExtractToDirectory(string, string)
                if(args.Length == 3)
                {
                    // check if <Zip File> exists
                    if (fileSystem.FileExists(args[1]) == false)
                        AddError(_Error_ZipFile_DoesNotExist);

                    // check if <Extract To> exists
                    if (fileSystem.DirectoryExists(args[2]) == false && fileSystem.ParentDirectoryExists(args[2]) == false)
                        AddError(_Error_ExtractTo_DoesNotExist);
                }
            }

            return _validated;
        }

        /// <summary>
        /// Both adds the error and then sets the validated variable to false.
        /// </summary>
        /// <param name="error">Error string to add.</param>
        private void AddError(string error)
        {
            if (Errors == null) Errors = new List<string>();

            Errors.Add(error);

            _validated = false;
        }
    }
}
