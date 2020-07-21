using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            // Assign
            PersonModel newPerson = new PersonModel { FirstName="Fu", LastName="Long"};
            List<PersonModel> people = new List<PersonModel>();

            // Act
            DataAccess.AddPersonToPeopleList(people, newPerson);

            // Assert
            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }
        
        [Theory]
        [InlineData("Fu", "", "LastName")]
        [InlineData("", "Long", "FirstName")]
        public void AddPersonPeopleList_ShouldFaile(string firstName, string lastName, string paramName)
        {
            // Assign
            PersonModel newPerson = new PersonModel { FirstName=firstName, LastName=lastName};
            List<PersonModel> people = new List<PersonModel>();

            // Act
            // Exception test

            // Assert
            Assert.Throws<ArgumentException>(paramName, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
