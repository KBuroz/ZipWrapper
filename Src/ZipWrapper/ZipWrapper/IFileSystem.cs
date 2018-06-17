namespace ZipWrapper
{
    public interface IFileSystem
    {
        bool FileExists(string path);
        bool DirectoryExists(string path);
        bool ParentDirectoryExists(string path);
    }
}
