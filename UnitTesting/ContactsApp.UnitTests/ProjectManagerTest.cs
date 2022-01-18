using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тестирование класса сериализации и десериализации
    /// </summary>
    [TestFixture]
    class ProjectManagerTest
    {
        public string Location
        {
            get
            {
                var location = Assembly.GetExecutingAssembly().Location;
                location = location.Replace("\\ContactsApp.UnitTests.dll", "\\TestData\\");
                return location;
            }
        }
        private Project GetCorrectProject()
        {
            var project = new Project();

            PhoneNumber expectedphone = new PhoneNumber {Number = 77078677680};
            var contact = new Contact(
                "Igor",
                "Serdyuk",
                "igorserd@mail.ru",
                "igorserd",
                new DateTime(2001, 9, 28),
                expectedphone);
            project.Contacts.Add(contact);

            expectedphone = new PhoneNumber {Number = 79131124856};
            contact = new Contact(
                "Ivanov",
                "Ivan",
                "Ivanov@mail.ru",
                "Id123456",
                new DateTime(1972, 9, 28),
                expectedphone);
            project.Contacts.Add(contact);
            return project;
        }

        [Test(Description = "Тест метода LoadFromFile")]
        public void ProjectManager_LoadCorrectData_FileLoadCorrected()
        {
            //SetUp
            var expectedProject = GetCorrectProject();

            //Act
            var actualProject = ProjectManager.LoadFromFile(Location, "correctproject.json");

             //Assert
            Assert.AreEqual(expectedProject.Contacts.Count, actualProject.Contacts.Count);

            Assert.Multiple(() =>
            {

                for (int i = 0; i < expectedProject.Contacts.Count; i++)
                {
                    var expected = expectedProject.Contacts[i];
                    var actual = actualProject.Contacts[i];
                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [TestCase(Description = "Негативный тест загрузки", TestName ="Загрузка некорректного файла")]
        public void ProjectManager_LoadIncorrectData_FileLoadIncorrectly()
        {
            //Act
            var actualProject = ProjectManager.LoadFromFile(Location, "incorrectproject.json");
            Assert.IsNotNull(actualProject);
            var expectedCount = 0;

            //Assert
            Assert.AreEqual(expectedCount, actualProject.Contacts.Count);
        }

        [TestCase(Description = "Негативный тест загрузки", TestName = "Загрузка пустого файла")]
        public void ProjectManager_LoadNullData_FileLoadIncorrectly()
        {
            //Act
            var actualProject = ProjectManager.LoadFromFile("\\lkjhgfd", "\\sdfghjk.json\\");
            Assert.IsNotNull(actualProject);
            var expectedCount = 0;

            //Assert
            Assert.AreEqual(expectedCount, actualProject.Contacts.Count);
        }

        [TestCase(Description = "", TestName = "Позитивный тест сохранения")]
        public void ProjectManager_SaveCorrectData_FileSaveCorrectly()
        {
            // Setup
            var savingProject = GetCorrectProject();

            // Act
            ProjectManager.SaveToFile(savingProject, Location, "SavedProjectFile.json");

            // Assert
            var expected = File.ReadAllText(Location + "correctproject.json");
            var actual = File.ReadAllText(Location + "SavedProjectFile.json");
            Assert.AreEqual(expected, actual);
        }
    }
}
