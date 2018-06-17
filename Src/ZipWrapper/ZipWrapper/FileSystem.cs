using System.IO;

namespace ZipWrapper
{
    public class FileSystem : IFileSystem
    {
        public bool DirectoryExists(string path) => Directory.Exists(path);

        public bool FileExists(string path) => File.Exists(path);

        public bool ParentDirectoryExists(string path) => Directory.GetParent(path).Exists;
    }
}
