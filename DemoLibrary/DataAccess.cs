using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class DataAccess
    {
        private static string personTextFile = "PersonText.txt";

        public static void AddNewPerson(PersonModel person)
        {
            List<string> lines = new List<string>();
            List<PersonModel> people = personTextFile.FullFilePath().LoadFile().ConvertToModel<PersonModel>();
            AddPersonToPeopleList(people, person);

            people.SaveToFile(personTextFile);
        }

        public static void AddPersonToPeopleList(List<PersonModel> people, PersonModel person)
        {
            if(string.IsNullOrWhiteSpace(person.FirstName))
            {
                throw new ArgumentException("You passed in an invalid parameter",nameof(PersonModel.FirstName));
            }

            if(string.IsNullOrWhiteSpace(person.LastName))
            {
                throw new ArgumentException("You passed in an invalid parameter", nameof(PersonModel.LastName));
            }

            people.Add(person);
        }

        public static List<PersonModel> GetAllPersons()
        {
            return personTextFile.FullFilePath().LoadFile().ConvertToModel<PersonModel>();
        }
    }
}
