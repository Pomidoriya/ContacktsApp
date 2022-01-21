using System;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Класс тестов для тестирования Contact
    /// </summary>
    [TestFixture]
    class ContactTest
    {
        private Contact _testContact;

        public void SetUp()
        {
            _testContact = new Contact();
        }

        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            var expected = "Басков";
            _testContact.Surname = expected;
            var actual = _testContact.Surname;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест сеттера Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            _testContact.Surname = "Басков";
            var actual = _testContact.Surname;

            // Assert
            Assert.AreEqual(actual, _testContact.Surname, "Сеттер неправильно заполнил фамилию");
        }

        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Басков-Басков-Басков-Басков-Басков-Басков-Басков-Басков-Басков", 
            "Должно возникать исключение, если фамилия длиннее 50 символов",
            TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            // SetUp
            SetUp();

            // Assert
            Assert.Throws<ArgumentException>
                (

                () => 
                { 
                    _testContact.Surname = wrongSurname;
                },
                message

                );
        }

        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            var expected = "Николя";
            _testContact.Name = expected;
            var actual = _testContact.Name;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void TestNameSet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            _testContact.Name = "Николя";
            var actual = _testContact.Name;

            // Assert
            Assert.AreEqual(actual, _testContact.Name, "Сеттер неправильно заполнил имя");
        }

        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("Николя-Николя-Николя-Николя-Николя-Николя-Николя-Николя", 
            "Должно возникать исключение, если имя длиннее 50 символов", 
            TestName = "Присвоение неправильного имени больше 50 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            // SetUp
            SetUp();

            // Assert
            Assert.Throws<ArgumentException>(
            () => { _testContact.Name = wrongName; },
            message);
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestMailGet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            var expected = "igorserd2909@mail.ru";
            _testContact.Email = expected;
            var actual = _testContact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную почту");
        }

        [Test(Description = "Позитивный тест сеттера Email")]
        public void TestMailSet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            _testContact.Email = "igorserd.igor@mail.ru";
            var actual = _testContact.Email;

            // Assert
            Assert.AreEqual(actual, _testContact.Email, "Сеттер неправильно заполнил почту");
        }

        [TestCase("",
            "Должно возникать исключение, если Email - пустая строка",
            TestName = "Присвоение пустой строки в качестве почты")]
        [TestCase("igorserdigorserdigorserdigorserdigorserdigorserdigorserdigorserd@mail.ru",
            "Должно возникать исключение, если почта больше 50 символов",
            TestName = "Присвоение неправильной почты больше 50 символов")]
        public void TestMailSet_ArgumentException(string wrongEmail, string message)
        {
            // SetUp
            SetUp();

            // Assert
            Assert.Throws<ArgumentException>(
                () => { _testContact.Email = wrongEmail; },
                message);
        }

        [Test(Description = "Позитивный тест геттера IdVk")]
        public void TestIdVkGet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            var expected = "id123456";
            _testContact.IdVK = expected;
            var actual = _testContact.IdVK;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер IdVK возвращает неправильный  idvk");
        }

        [Test(Description = "Позитивный тест сеттера IdVk")]
        public void TestIdVkSet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            _testContact.IdVK = "igorserd.igor";
            var actual = _testContact.IdVK;

            // Assert
            Assert.AreEqual(actual, _testContact.IdVK, "Сеттер неправильно заполнил idVk");
        }

        [TestCase("",
            "Должно возникать исключение, если IdVK - пустая строка",
            TestName = "Присвоение пустой строки в качестве IdVK")]
        [TestCase("id1234567899999999",
            "Должно возникать исключение, если IdVK > 15 символов",
            TestName = "Присвоение неправильной даты больше текущей")]
        public void TestIdVKSet_ArgumentException(string wrongIdVk, string message)
        {
            // SetUp
            SetUp();

            // Assert
            Assert.Throws<ArgumentException>(
                () => { _testContact.IdVK = wrongIdVk; },
                message);
        }

        [Test(Description = "Позитивный тест геттера BirthDate")]
        public void TestDateGet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            DateTime expected = new DateTime(2000, 8, 30);
            _testContact.BirthDate = expected;
            var actual = _testContact.BirthDate;

            // Assert
            Assert.AreEqual(expected.Year, actual.Year, "Геттер BirthDay возвращает неправильную дату");
        }

        [Test(Description = "Позитивный тест сеттера BirthDate")]
        public void TestDateSet_CorrectValue()
        {
            // SetUp
            SetUp();

            // Act
            _testContact.BirthDate = new DateTime(2000, 5, 20);
            var actual = _testContact.BirthDate;

            // Assert
            Assert.AreEqual(actual, _testContact.BirthDate, "Сеттер неправильно заполнил дату");
        }

        [TestCase("1899, 1, 5",
            "Должно возникать исключение, если год меньше 1900",
            TestName = "Присвоение неправильной даты меньше 1900")]
        [TestCase(null, "Должно возникать исключение, если дата - пустая строка",
            TestName = "Присвоение путой строки")]
        [TestCase("2025, 1, 5",
            "Должно возникать исключение, если год больше текущего", 
            TestName = "Присвоение неправильной даты больше текущей")]
        public void TestDateSet_ArgumentException(DateTime wrongDate, string message)
        {
            // SetUp
            SetUp();

            // Assert
            Assert.Throws<ArgumentException>(
                () => { _testContact.BirthDate = wrongDate; },
                message);
        }
    }
}
