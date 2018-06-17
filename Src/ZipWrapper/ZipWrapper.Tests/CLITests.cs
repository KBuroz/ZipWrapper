using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZipWrapper;

namespace ZipWrapper.Tests
{
    [TestClass]
    public class CLITests
    {
        [TestMethod]
        public void Command_Extract_Calls_Extract()
        {
            // Arrange
            var zipShell = new MockZipShell_Bare();
            var cli = new CLI(zipShell);

            // Act
            cli.ParseCommand(new string[] { "extract", "", "" });

            // Assert
            Assert.IsTrue(zipShell.ExtractToDirectoryCalled1, "First signature of the extract command was never called");            
        }

        [TestMethod]
        public void Command_Create_Calls_Create()
        {
            // Arrange
            var zipShell = new MockZipShell_Bare();
            var cli = new CLI(zipShell);

            // Act
            cli.ParseCommand(new string[] { "create", "", "" });

            // Assert
            Assert.IsTrue(zipShell.CreateFromDirectoryCalled1, "First signature of the create command was never called");
        }
    }
}
