using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExampleTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidName_ShouldWork()
        {
            // Assign
            string expected = "The file was correctly loaded";
            string fileName = "A valid file name for test";

            // Act
            string actual = Example.ExampleLoadTextFile(fileName, fileName);

            // Assert
            // Or Assert.True(actual.Length > 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleLoadTextFile_InvalidName_ShouldFail()
        {
            // Assign
            // Expect an exception so no initial for 
            string fileName = "";

            // Act
            // Axception test, so actual in Assert statement
            try
            {
                Example.ExampleLoadTextFile(fileName, fileName);

            }
            catch (Exception err)
            {

                var testException = err;
            }
            // Assert
            // Or Assert.True(actual.Length > 0);
            Assert.Throws<ArgumentException>("file", () => Example.ExampleLoadTextFile(fileName, fileName));
        }
    }
}
