using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        private Contact _contact;
        private Project _project;

        [SetUp]
        public void InitComponent()
        {
            _project = new Project();

            _contact = new Contact();
            _contact.Name = "Maxim";
            _contact.Surname = "Petrov";
            _contact.DateOfBirth = new DateTime(1975, 01, 05);
            _contact.Email = "maxim.petrov@gmail.com";
            _contact.IdVk = "petrov75";
            _contact.phoneNumber.Number = 87078677680;
        }

        [Test(Description = "Позитивный тест сериализации")]
        public void TestSerialization_CorrectValue()
        {
            _project._contactsList.Add(_contact);

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestSerialize.notes";
            var fileReference = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestSerializeReference.notes";

            ProjectManager.SaveToFile(_project, filePath);

            var referenceProjectString = File.ReadAllText(fileReference);
            var actualProjectString = File.ReadAllText(filePath);

            Assert.AreEqual(referenceProjectString, actualProjectString, 
                "Тест сериализации не пройден." );
        }

        [Test(Description = "Позитивный тест десериализации")]
        public void TestDeserilization_CorrectValue()
        {
            Project project = new Project();
            _project._contactsList.Add(_contact);

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestDeserialize.notes";
            var fileReference = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestDeserializeReference.notes";
                        
            project = ProjectManager.LoadFromFile(fileReference);
                       
            Assert.AreEqual(_project._contactsList.Count, project._contactsList.Count, 
                "Десериализация работает неправильно.");
            for (int index = 0; index < _project._contactsList.Count; index++)
            {
                Assert.AreEqual(_project._contactsList[index].Surname, project._contactsList[index].Surname,
                    "Некорректная десериализация фамилии");
                Assert.AreEqual(_project._contactsList[index].Name, project._contactsList[index].Name,
                    "Некорректная десериализация имени");
                Assert.AreEqual(_project._contactsList[index].Email, project._contactsList[index].Email,
                    "Некорректная десериализация е-мейла");
                Assert.AreEqual(_project._contactsList[index].IdVk, project._contactsList[index].IdVk,
                    "Некорректная десериализация id vk");
                Assert.AreEqual(_project._contactsList[index].phoneNumber.Number, 
                    project._contactsList[index].phoneNumber.Number,
                    "Некорректная десериализация номера телефона");
                Assert.AreEqual(_project._contactsList[index].DateOfBirth, 
                    project._contactsList[index].DateOfBirth,
                    "Некорректная десериализация фамилии");
            }
        }
    }
}
