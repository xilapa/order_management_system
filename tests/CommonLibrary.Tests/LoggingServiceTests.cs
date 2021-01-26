using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using BusinessLogic;
using System;
using System.IO;
using System.Linq;

namespace CommonLibrary.Tests
{
    public class LoggingServiceTests
    {
        [Fact]
        public void TestLogInfo()
        {
            // Arrange          
            var itemsToLog = new List<ILoggable>()
                    {
                        new Customer(1)
                            {
                                FirstName = "John",
                                LastName = "Wick",
                                Email = "johnwick@email.com",
                                Addresses = null,
                                EntityState = 0
                            }
                        ,
                        new Product(3)
                            {
                                Name = "Mouse",
                                Description = "Gamer",
                                EntityState = 0
                            },
                        new Order(2)
                            {
                                OrderDate = DateTimeOffset.Now,
                                CustomerID = 1,
                                EntityState = EntityStateOption.Deleted
                            }
                    };

            var expected = new List<string>()
                    {
                        "1 : John Wick - johnwick@email.com - Status: Active",
                        "3 : Mouse - Details: Gamer - Status Active",
                        $"2 : {DateTimeOffset.Now} - CustomerID: 1 - Status: Deleted"
                    };

            // Act
            LoggingService.WriteToFile(itemsToLog);
            var actual = new List<string>();
            using (var logFile = new StreamReader(@"C:\log.txt"))
            {
                var logLine = string.Empty;
                while ((logLine = logFile.ReadLine()) != null )
                {
                    actual.Add(logLine);
                }

            }


            // Assert
            actual.TakeLast(3).Should().BeEquivalentTo(expected);

        }
    }
}
