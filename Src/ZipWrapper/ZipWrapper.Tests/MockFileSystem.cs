namespace ZipWrapper.Tests
{
    class MockFileSystem : IFileSystem
    {
        public string BadDirectory = @"C:\BadDirectory";
        public string BadFile = @"C:\BadFile.txt";
        public string BadParentDirectory = @"C:\BadDirectory\ChildDirectory";

        public bool DirectoryExists(string path)
        {
            if (path == BadDirectory)
                return false;

            return true;
        }

        public bool FileExists(string path)
        {
            if (path == BadFile)
                return false;

            return true;
        }

        public bool ParentDirectoryExists(string path)
        {
            if (path == BadParentDirectory)
                return false;

            return true;
        }
    }
}
