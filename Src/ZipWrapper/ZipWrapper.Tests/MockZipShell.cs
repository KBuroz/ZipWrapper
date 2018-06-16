using System;
using System.IO.Compression;
using System.Text;

namespace ZipWrapper.Tests
{
    internal class MockZipShell_Bare : IZipShell
    {
        // Both signatures
        public Encoding providedEntryNameEncoding = null;

        // Create
        public string providedSourceDirectoryName = null;
        public string providedDestinationArchiveFileName = null;
        public CompressionLevel? providedCompressionLevel = null;
        public bool? providedIncludeBaseDirectory = null;
    
        // CreateFromDirectory
        public bool CreateFromDirectoryCalled1 = false;
        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName)
        {
            CreateFromDirectoryCalled1 = true;
            providedSourceDirectoryName = sourceDirectoryName;
            providedDestinationArchiveFileName = destinationArchiveFileName;
        }

        // CreateFromDirectory
        public bool CreateFromDirectoryCalled2 = false;
        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            CreateFromDirectoryCalled2 = true;
            providedSourceDirectoryName = sourceDirectoryName;
            providedDestinationArchiveFileName = destinationArchiveFileName;
            providedCompressionLevel = compressionLevel;
            providedIncludeBaseDirectory = includeBaseDirectory;
        }

        // CreateFromDirectory
        public bool CreateFromDirectoryCalled3 = false;
        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            CreateFromDirectoryCalled3 = true;
            providedSourceDirectoryName = sourceDirectoryName;
            providedDestinationArchiveFileName = destinationArchiveFileName;
            providedCompressionLevel = compressionLevel;
            providedIncludeBaseDirectory = includeBaseDirectory;
            providedEntryNameEncoding = entryNameEncoding;
        }



        // Extract 
        public string providedSourceArchiveFileName = null;
        public string providedDestinationDirectoryName = null;
        public ZipArchiveMode? providedZipArchiveMode = null;

        // ExtractToDirectory
        public bool ExtractToDirectoryCalled1 = false;
        public void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName)
        {
            ExtractToDirectoryCalled1 = true;
            providedSourceArchiveFileName = sourceArchiveFileName;
            providedDestinationDirectoryName = destinationDirectoryName;
        }

        // ExtractToDirectory
        public bool ExtractToDirectoryCalled2 = false;
        public void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding)
        {
            ExtractToDirectoryCalled2 = true;
            providedSourceArchiveFileName = sourceArchiveFileName;
            providedDestinationDirectoryName = destinationDirectoryName;
            providedEntryNameEncoding = entryNameEncoding;
        }

        // Open
        public ZipArchive Open(string archiveFileName, ZipArchiveMode mode)
        {
            throw new NotImplementedException();
        }

        // Open
        public ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding)
        {
            throw new NotImplementedException();
        }

        // OpenRead
        public ZipArchive OpenRead(string archiveFileName)
        {
            throw new NotImplementedException();
        }
    }
}
