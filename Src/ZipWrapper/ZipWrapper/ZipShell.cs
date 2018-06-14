using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipWrapper
{
    public class ZipShell : IZipShell
    {
        //
        // Summary:
        //     Creates a zip archive that contains the files and directories from the specified
        //     directory.
        //
        // Parameters:
        //   sourceDirectoryName:
        //     The path to the directory to be archived, specified as a relative or absolute
        //     path. A relative path is interpreted as relative to the current working directory.
        //
        //   destinationArchiveFileName:
        //     The path of the archive to be created, specified as a relative or absolute path.
        //     A relative path is interpreted as relative to the current working directory.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     sourceDirectoryName or destinationArchiveFileName is System.String.Empty, contains
        //     only white space, or contains at least one invalid character.
        //
        //   T:System.ArgumentNullException:
        //     sourceDirectoryName or destinationArchiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In sourceDirectoryName or destinationArchiveFileName, the specified path, file
        //     name, or both exceed the system-defined maximum length. For example, on Windows-based
        //     platforms, paths must not exceed 248 characters, and file names must not exceed
        //     260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     sourceDirectoryName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     destinationArchiveFileName already exists.-or-A file in the specified directory
        //     could not be opened.
        //
        //   T:System.UnauthorizedAccessException:
        //     destinationArchiveFileName specifies a directory.-or-The caller does not have
        //     the required permission to access the directory specified in sourceDirectoryName
        //     or the file specified in destinationArchiveFileName.
        //
        //   T:System.NotSupportedException:
        //     sourceDirectoryName or destinationArchiveFileName contains an invalid format.-or-The
        //     zip archive does not support writing.        public void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName)
        public void CreateFromDirectory(
                string sourceDirectoryName,
                string destinationArchiveFileName
            ) => ZipFile.CreateFromDirectory(
                sourceDirectoryName,
                destinationArchiveFileName
            );

        //
        // Summary:
        //     Creates a zip archive that contains the files and directories from the specified
        //     directory, uses the specified compression level, and optionally includes the
        //     base directory.
        //
        // Parameters:
        //   sourceDirectoryName:
        //     The path to the directory to be archived, specified as a relative or absolute
        //     path. A relative path is interpreted as relative to the current working directory.
        //
        //   destinationArchiveFileName:
        //     The path of the archive to be created, specified as a relative or absolute path.
        //     A relative path is interpreted as relative to the current working directory.
        //
        //   compressionLevel:
        //     One of the enumeration values that indicates whether to emphasize speed or compression
        //     effectiveness when creating the entry.
        //
        //   includeBaseDirectory:
        //     true to include the directory name from sourceDirectoryName at the root of the
        //     archive; false to include only the contents of the directory.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     sourceDirectoryName or destinationArchiveFileName is System.String.Empty, contains
        //     only white space, or contains at least one invalid character.
        //
        //   T:System.ArgumentNullException:
        //     sourceDirectoryName or destinationArchiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In sourceDirectoryName or destinationArchiveFileName, the specified path, file
        //     name, or both exceed the system-defined maximum length. For example, on Windows-based
        //     platforms, paths must not exceed 248 characters, and file names must not exceed
        //     260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     sourceDirectoryName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     destinationArchiveFileName already exists.-or-A file in the specified directory
        //     could not be opened.
        //
        //   T:System.UnauthorizedAccessException:
        //     destinationArchiveFileName specifies a directory.-or-The caller does not have
        //     the required permission to access the directory specified in sourceDirectoryName
        //     or the file specified in destinationArchiveFileName.
        //
        //   T:System.NotSupportedException:
        //     sourceDirectoryName or destinationArchiveFileName contains an invalid format.-or-The
        //     zip archive does not support writing.
        public void CreateFromDirectory(
                string sourceDirectoryName,
                string destinationArchiveFileName,
                CompressionLevel compressionLevel,
                bool includeBaseDirectory
            ) => ZipFile.CreateFromDirectory(
                sourceDirectoryName,
                destinationArchiveFileName,
                compressionLevel,
                includeBaseDirectory
            );

        //
        // Summary:
        //     Creates a zip archive that contains the files and directories from the specified
        //     directory, uses the specified compression level and character encoding for entry
        //     names, and optionally includes the base directory.
        //
        // Parameters:
        //   sourceDirectoryName:
        //     The path to the directory to be archived, specified as a relative or absolute
        //     path. A relative path is interpreted as relative to the current working directory.
        //
        //   destinationArchiveFileName:
        //     The path of the archive to be created, specified as a relative or absolute path.
        //     A relative path is interpreted as relative to the current working directory.
        //
        //   compressionLevel:
        //     One of the enumeration values that indicates whether to emphasize speed or compression
        //     effectiveness when creating the entry.
        //
        //   includeBaseDirectory:
        //     true to include the directory name from sourceDirectoryName at the root of the
        //     archive; false to include only the contents of the directory.
        //
        //   entryNameEncoding:
        //     The encoding to use when reading or writing entry names in this archive. Specify
        //     a value for this parameter only when an encoding is required for interoperability
        //     with zip archive tools and libraries that do not support UTF-8 encoding for entry
        //     names.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     sourceDirectoryName or destinationArchiveFileName is System.String.Empty, contains
        //     only white space, or contains at least one invalid character.-or- entryNameEncoding
        //     is set to a Unicode encoding other than UTF-8.
        //
        //   T:System.ArgumentNullException:
        //     sourceDirectoryName or destinationArchiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In sourceDirectoryName or destinationArchiveFileName, the specified path, file
        //     name, or both exceed the system-defined maximum length. For example, on Windows-based
        //     platforms, paths must not exceed 248 characters, and file names must not exceed
        //     260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     sourceDirectoryName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     destinationArchiveFileName already exists.-or-A file in the specified directory
        //     could not be opened.
        //
        //   T:System.UnauthorizedAccessException:
        //     destinationArchiveFileName specifies a directory.-or-The caller does not have
        //     the required permission to access the directory specified in sourceDirectoryName
        //     or the file specified in destinationArchiveFileName.
        //
        //   T:System.NotSupportedException:
        //     sourceDirectoryName or destinationArchiveFileName contains an invalid format.-or-The
        //     zip archive does not support writing.
        public void CreateFromDirectory(
                string sourceDirectoryName,
                string destinationArchiveFileName,
                CompressionLevel compressionLevel,
                bool includeBaseDirectory,
                Encoding entryNameEncoding
            ) => ZipFile.CreateFromDirectory(
                sourceDirectoryName,
                destinationArchiveFileName,
                compressionLevel,
                includeBaseDirectory,
                entryNameEncoding
            );
        //
        // Summary:
        //     Extracts all the files in the specified zip archive to a directory on the file
        //     system.
        //
        // Parameters:
        //   sourceArchiveFileName:
        //     The path to the archive that is to be extracted.
        //
        //   destinationDirectoryName:
        //     The path to the directory in which to place the extracted files, specified as
        //     a relative or absolute path. A relative path is interpreted as relative to the
        //     current working directory.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     destinationDirectoryName or sourceArchiveFileName is System.String.Empty, contains
        //     only white space, or contains at least one invalid character.
        //
        //   T:System.ArgumentNullException:
        //     destinationDirectoryName or sourceArchiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path in destinationDirectoryName or sourceArchiveFileName exceeds
        //     the system-defined maximum length. For example, on Windows-based platforms, paths
        //     must not exceed 248 characters, and file names must not exceed 260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        //
        //   T:System.IO.IOException:
        //     The directory specified by destinationDirectoryName already exists.-or-The name
        //     of an entry in the archive is System.String.Empty, contains only white space,
        //     or contains at least one invalid character.-or-Extracting an archive entry would
        //     create a file that is outside the directory specified by destinationDirectoryName.
        //     (For example, this might happen if the entry name contains parent directory accessors.)
        //     -or-An archive entry to extract has the same name as an entry that has already
        //     been extracted from the same archive.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission to access the archive or the
        //     destination directory.
        //
        //   T:System.NotSupportedException:
        //     destinationDirectoryName or sourceArchiveFileName contains an invalid format.
        //
        //   T:System.IO.FileNotFoundException:
        //     sourceArchiveFileName was not found.
        //
        //   T:System.IO.InvalidDataException:
        //     The archive specified by sourceArchiveFileName is not a valid zip archive.-or-An
        //     archive entry was not found or was corrupt.-or-An archive entry was compressed
        //     by using a compression method that is not supported.
        public void ExtractToDirectory(
                string sourceArchiveFileName,
                string destinationDirectoryName
            ) => ZipFile.ExtractToDirectory(
                sourceArchiveFileName,
                destinationDirectoryName
            );

        //
        // Summary:
        //     Extracts all the files in the specified zip archive to a directory on the file
        //     system and uses the specified character encoding for entry names.
        //
        // Parameters:
        //   sourceArchiveFileName:
        //     The path to the archive that is to be extracted.
        //
        //   destinationDirectoryName:
        //     The path to the directory in which to place the extracted files, specified as
        //     a relative or absolute path. A relative path is interpreted as relative to the
        //     current working directory.
        //
        //   entryNameEncoding:
        //     The encoding to use when reading or writing entry names in this archive. Specify
        //     a value for this parameter only when an encoding is required for interoperability
        //     with zip archive tools and libraries that do not support UTF-8 encoding for entry
        //     names.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     destinationDirectoryName or sourceArchiveFileName is System.String.Empty, contains
        //     only white space, or contains at least one invalid character.-or- entryNameEncoding
        //     is set to a Unicode encoding other than UTF-8.
        //
        //   T:System.ArgumentNullException:
        //     destinationDirectoryName or sourceArchiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path in destinationDirectoryName or sourceArchiveFileName exceeds
        //     the system-defined maximum length. For example, on Windows-based platforms, paths
        //     must not exceed 248 characters, and file names must not exceed 260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        //
        //   T:System.IO.IOException:
        //     The directory specified by destinationDirectoryName already exists.-or-The name
        //     of an entry in the archive is System.String.Empty, contains only white space,
        //     or contains at least one invalid character.-or-Extracting an archive entry would
        //     create a file that is outside the directory specified by destinationDirectoryName.
        //     (For example, this might happen if the entry name contains parent directory accessors.)
        //     -or-An archive entry to extract has the same name as an entry that has already
        //     been extracted from the same archive.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission to access the archive or the
        //     destination directory.
        //
        //   T:System.NotSupportedException:
        //     destinationDirectoryName or sourceArchiveFileName contains an invalid format.
        //
        //   T:System.IO.FileNotFoundException:
        //     sourceArchiveFileName was not found.
        //
        //   T:System.IO.InvalidDataException:
        //     The archive specified by sourceArchiveFileName is not a valid zip archive.-or-An
        //     archive entry was not found or was corrupt.-or-An archive entry was compressed
        //     by using a compression method that is not supported.
        public void ExtractToDirectory(
                string sourceArchiveFileName,
                string destinationDirectoryName,
                Encoding entryNameEncoding
            ) => ZipFile.ExtractToDirectory(
                sourceArchiveFileName,
                destinationDirectoryName,
                entryNameEncoding
            );

        //
        // Summary:
        //     Opens a zip archive at the specified path and in the specified mode.
        //
        // Parameters:
        //   archiveFileName:
        //     The path to the archive to open, specified as a relative or absolute path. A
        //     relative path is interpreted as relative to the current working directory.
        //
        //   mode:
        //     One of the enumeration values that specifies the actions which are allowed on
        //     the entries in the opened archive.
        //
        // Returns:
        //     The opened zip archive.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     archiveFileName is System.String.Empty, contains only white space, or contains
        //     at least one invalid character.
        //
        //   T:System.ArgumentNullException:
        //     archiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In archiveFileName, the specified path, file name, or both exceed the system-defined
        //     maximum length. For example, on Windows-based platforms, paths must not exceed
        //     248 characters, and file names must not exceed 260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     archiveFileName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     archiveFileName could not be opened.-or- mode is set to System.IO.Compression.ZipArchiveMode.Create,
        //     but the file specified in archiveFileName already exists.
        //
        //   T:System.UnauthorizedAccessException:
        //     archiveFileName specifies a directory.-or-The caller does not have the required
        //     permission to access the file specified in archiveFileName.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     mode specifies an invalid value.
        //
        //   T:System.IO.FileNotFoundException:
        //     mode is set to System.IO.Compression.ZipArchiveMode.Read, but the file specified
        //     in archiveFileName is not found.
        //
        //   T:System.NotSupportedException:
        //     archiveFileName contains an invalid format.
        //
        //   T:System.IO.InvalidDataException:
        //     archiveFileName could not be interpreted as a zip archive.-or- mode is System.IO.Compression.ZipArchiveMode.Update,
        //     but an entry is missing or corrupt and cannot be read.-or- mode is System.IO.Compression.ZipArchiveMode.Update,
        //     but an entry is too large to fit into memory.
        public ZipArchive Open(
                string archiveFileName,
                ZipArchiveMode mode
            ) => ZipFile.Open(
                archiveFileName,
                mode
            );

        //
        // Summary:
        //     Opens a zip archive at the specified path, in the specified mode, and by using
        //     the specified character encoding for entry names.
        //
        // Parameters:
        //   archiveFileName:
        //     The path to the archive to open, specified as a relative or absolute path. A
        //     relative path is interpreted as relative to the current working directory.
        //
        //   mode:
        //     One of the enumeration values that specifies the actions that are allowed on
        //     the entries in the opened archive.
        //
        //   entryNameEncoding:
        //     The encoding to use when reading or writing entry names in this archive. Specify
        //     a value for this parameter only when an encoding is required for interoperability
        //     with zip archive tools and libraries that do not support UTF-8 encoding for entry
        //     names.
        //
        // Returns:
        //     The opened zip archive.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     archiveFileName is System.String.Empty, contains only white space, or contains
        //     at least one invalid character.-or- entryNameEncoding is set to a Unicode encoding
        //     other than UTF-8.
        //
        //   T:System.ArgumentNullException:
        //     archiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In archiveFileName, the specified path, file name, or both exceed the system-defined
        //     maximum length. For example, on Windows-based platforms, paths must not exceed
        //     248 characters, and file names must not exceed 260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     archiveFileName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     archiveFileName could not be opened.-or- mode is set to System.IO.Compression.ZipArchiveMode.Create,
        //     but the file specified in archiveFileName already exists.
        //
        //   T:System.UnauthorizedAccessException:
        //     archiveFileName specifies a directory.-or-The caller does not have the required
        //     permission to access the file specified in archiveFileName.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     mode specifies an invalid value.
        //
        //   T:System.IO.FileNotFoundException:
        //     mode is set to System.IO.Compression.ZipArchiveMode.Read, but the file specified
        //     in archiveFileName is not found.
        //
        //   T:System.NotSupportedException:
        //     archiveFileName contains an invalid format.
        //
        //   T:System.IO.InvalidDataException:
        //     archiveFileName could not be interpreted as a zip archive.-or- mode is System.IO.Compression.ZipArchiveMode.Update,
        //     but an entry is missing or corrupt and cannot be read.-or- mode is System.IO.Compression.ZipArchiveMode.Update,
        //     but an entry is too large to fit into memory.
        public ZipArchive Open(
                string archiveFileName,
                ZipArchiveMode mode,
                Encoding entryNameEncoding
            ) => ZipFile.Open(
                archiveFileName,
                mode,
                entryNameEncoding
            );

        //
        // Summary:
        //     Opens a zip archive for reading at the specified path.
        //
        // Parameters:
        //   archiveFileName:
        //     The path to the archive to open, specified as a relative or absolute path. A
        //     relative path is interpreted as relative to the current working directory.
        //
        // Returns:
        //     The opened zip archive.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     archiveFileName is System.String.Empty, contains only white space, or contains
        //     at least one invalid character.
        //
        //   T:System.ArgumentNullException:
        //     archiveFileName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     In archiveFileName, the specified path, file name, or both exceed the system-defined
        //     maximum length. For example, on Windows-based platforms, paths must not exceed
        //     248 characters, and file names must not exceed 260 characters.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     archiveFileName is invalid or does not exist (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.IOException:
        //     archiveFileName could not be opened.
        //
        //   T:System.UnauthorizedAccessException:
        //     archiveFileName specifies a directory.-or-The caller does not have the required
        //     permission to access the file specified in archiveFileName.
        //
        //   T:System.IO.FileNotFoundException:
        //     The file specified in archiveFileName is not found.
        //
        //   T:System.NotSupportedException:
        //     archiveFileName contains an invalid format.
        //
        //   T:System.IO.InvalidDataException:
        //     archiveFileName could not be interpreted as a zip archive.
        public ZipArchive OpenRead(
                string archiveFileName
            ) => ZipFile.OpenRead(
                archiveFileName
            );
    }
}
