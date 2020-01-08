using FluentAssertions;
using PatientCare.API.Framework.Core.Utilities;
using System;
using System.Collections.Generic;
using Xunit;
using static PatientCare.API.Framework.UnitTests.Core.Utilities.TestModels.JsonConverterTestModel;

namespace PatientCare.API.Framework.UnitTests.Core.Utilities
{
    public class JsonConverterUnitTests
    {
        /// <summary>  
        /// To Get a instance of object Company  
        /// </summary>  
        /// <returns>instance of company</returns>  
        private Company GetCompanyObject()
        {
            return new Company
            {
                Name = "Health Partners",
                TotalEmployee = 50,
                Established = DateTime.Now,
                IsGovtOrganisation = false,
                TotalAsset = 20000000,
                Branches = new List<Branch>
                {
                    new Branch
                    {
                        Country = "USA",
                        State = "Minnesota",
                        Address = new Location
                        {
                            BuildingName = "Health Partners Tower",
                            Street = "101 Main Road",
                            ZipCode = 550010
                        }
                    },
                    new Branch
                    {
                        Country = "USA",
                        State = "Germantown",
                        Address = new Location
                        {
                            BuildingName = "Zinc Tower",
                            Street = "Germantown Road",
                            ZipCode = 50001
                        }
                    }
                },
                Departments = new Dictionary<string, Department>
                {
                    { "Engineering", new Department { DeptId = 001, DeptName = "Super Engineers" } },
                    { "Support", new Department { DeptId = 002, DeptName = "24*7 Tech Support" } },
                    { "Marketings", new Department { DeptId = 003, DeptName = "Tech Mavens" } }
                },
                Management = new Management { CEO = "Tarun Kumar Rajak", Founder = "Ashok Kisku" }
            };
        }

        [Fact]
        public void Serialize_WhenObjectExists_ReturnsJsonString()
        {
            // arrange
            var obj = GetCompanyObject();

            // act 
            var json = JsonConverter.Serialize(obj);

            // assert
            json.Should().NotBeNull();
            json.Should().NotBeEmpty();
        }

        [Fact]
        public void Serialize_WhenObjectIsEmpty_ReturnsEmptyJsonString()
        {
            // arrange

            // act 
            var json = JsonConverter.Serialize(null);

            // assert
            json.Should().Contain("null");
        }

    }
}