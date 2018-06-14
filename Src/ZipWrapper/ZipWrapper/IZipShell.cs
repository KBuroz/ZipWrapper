using System.IO.Compression;
using System.Text;

namespace ZipWrapper
{
    public interface IZipShell
    {
        void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName);
        void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory);
        void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding);
        void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName);
        void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding);
        ZipArchive Open(string archiveFileName, ZipArchiveMode mode);
        ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding);
        ZipArchive OpenRead(string archiveFileName);
    }
}