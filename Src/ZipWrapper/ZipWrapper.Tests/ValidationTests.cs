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
    }
}
