using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZipWrapper.Tests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void Validate_NoArgumentsProvided_AddsError()
        {
            // Arrange
            var fileSystem = new MockFileSystem();
            var validateCLI = new ValidateCLI(fileSystem);

            // Act
            var result = validateCLI.Validate(new string[] { });

            // Assert
            Assert.IsFalse(result, "The validate function returned true while in a invalid state.");
            Assert.AreEqual(validateCLI._Error_NoArgumentsProvided, validateCLI.Errors[0], "Incorrect error message.");
        }

        [TestMethod]
        public void Validate_Create_BadArgument_ZipFile_AddsError()
        {
            // Arrange
            var fileSystem = new MockFileSystem();
            var validateCLI = new ValidateCLI(fileSystem);

            // Act
            var result = validateCLI.Validate(new string[] { "extract", fileSystem.BadFile, "C:\\goodDirectory" });

            // Assert
            Assert.IsFalse(result, "The validate function returned true while in a invalid state.");
            Assert.AreEqual(validateCLI._Error_ZipFile_DoesNotExist, validateCLI.Errors[0], "Incorrect error message.");
        }

        [TestMethod]
        public void Validate_Create_BadArgument_ExtractParentDirectory_AddsError()
        {
            // Arrange
            var fileSystem = new MockFileSystem();
            var validateCLI = new ValidateCLI(fileSystem);

            // Act
            var result = validateCLI.Validate(new string[] { "extract", "C:\\directory\\zipfile.zip", fileSystem.BadParentDirectory });

            // Assert
            Assert.IsFalse(result, "The validate function returned true while in a invalid state.");
            Assert.AreEqual(validateCLI._Error_ExtractTo_DoesNotExist, validateCLI.Errors[0], "Incorrect error message.");
        }


    }
}
