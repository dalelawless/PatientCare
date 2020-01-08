using FluentAssertions;
using PatientCare.API.Framework.Core.Constants;
using PatientCare.API.Framework.Core.Exceptions;
using PatientCare.API.Framework.Infrastructure.Logging;
using System;
using Xunit;

namespace PatientCare.API.Framework.UnitTests.Infrastructure.Logging
{
    /// <summary>
    /// PatientCare.API.Framework Infrastructor Logging Tests.
    ///     Note: All tests should follow the unti test structure of: Arrange, Act, Assert
    ///           Test name should also follow the BDD/Gherkin synta: Given, When, Then.
    ///        
    ///     Testing Framework:   xUnit.
    ///     Mocking Framework:   MOQ.
    ///     Assertion Framework: Fluent Assertions.
    /// </summary>
    public class LoggingUnitTests
    {
        [Fact]
        public void LogInformation_WhenLogged_ReturnTrue()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            // act & assert
            la.LogInformation(LoggingConstants.AppName, "Unit Test of Log Information").Should().BeTrue();
        }

        [Fact]
        public void LogInformation_WhenLogAppNameEmpty_ThrowsLogAppNameEmptyException()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            //act and assert
            la.Invoking(r => r.LogInformation("", "Testing LogInformation Guard check with empty App Nme"))
            .Should().Throw<LogAppNameException>();
        }

        [Fact]
        public void LogInformation_WhenLogMessageEmpty_ThrowsLogMessageException()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            //act and assert
            la.Invoking(r => r.LogInformation(LoggingConstants.AppName, ""))
            .Should().Throw<LogMessageException>();
        }

        [Fact]
        public void LogWarning_WhenLogAppNameEmpty_ThrowsLogAppNameEmptyException()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            //act and assert
            la.Invoking(r => r.LogWarning("", "Testing LogWarning Guard check with empty App Nme"))
            .Should().Throw<LogAppNameException>();
        }

        [Fact]
        public void LogWarning_WhenLogMessageEmpty_ThrowsLogMessageException()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            //act and assert
            la.Invoking(r => r.LogWarning(LoggingConstants.AppName, ""))
            .Should().Throw<LogMessageException>();
        }

        [Fact]
        public void LogInformation_WhenLogFailed_ReturnFalse()
        {
            // arrange
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUriFail);

            // act & assert
            la.LogInformation(LoggingConstants.AppName, "Unit Testing of negative test case of Log Information").Should().BeFalse();
        }

        [Fact(Skip = "Catch returns false not an exception")]
        public void LogInformation_ThrowsDirectoryNotFoundException()
        {
            // arrange
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUriFail);

            // act & assert
            var ex = Assert.Throws<ArgumentException>(() => la.LogInformation(LoggingConstants.AppName, "Unit Testing of DirectoryNotFoundException"));
            Assert.Equal("Directory Not Found Exception", ex.Message);
        }

        [Fact]
        public void LogWarning_WhenLogged_ReturnTrue()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            // act & assert
            la.LogWarning(LoggingConstants.AppName, "Unit Test of Log Warning").Should().BeTrue();
        }

        [Fact]
        public void LogPerformance_WhenLogged_ReturnTrue()
        {
            // arrange
            LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);

            // act & assert
            la.LogPerformance(LoggingConstants.AppName, "Unit Test of LogPerformance", DateTime.Now, DateTime.Now).Should().BeTrue();
        }

        [Fact]
        public void LogException_WhenLogged_ReturnTrue()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);
            try
            {
                throw new ArgumentException("Unit test of logging Exception.");
            }
            catch (Exception ex)
            {

                // act & assert
                LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);
                la.LogException(LoggingConstants.AppName, ex).Should().BeTrue();
            }

        }

        [Fact]
        public void LogExceptionWithMessage_WhenLogged_ReturnTrue()
        {
            // arrange
            System.IO.Directory.CreateDirectory(LoggingConstants.DefaultLogUri);

            // fake
            var fakeMessage = "Test Fake Message";

            try
            {
                throw new ArgumentException("Unit test of logging Exception.");
            }
            catch (Exception ex)
            {
                // act & assert
                LoggerAdapter la = new LoggerAdapter(LoggingConstants.DefaultLogUri);
                la.LogExceptionWithMessage(LoggingConstants.AppName, ex, fakeMessage).Should().BeTrue();
            }
        }
    }
}