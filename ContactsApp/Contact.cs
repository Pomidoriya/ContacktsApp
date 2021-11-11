using System;

namespace ContacktsApp
{
    /// <summary>
    /// Класс, содержащий контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// E-mail контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// ID Vkontakte контакта.
        /// </summary>
        private string _idVk;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        public PhoneNumber phoneNumber = new PhoneNumber();

        /// <summary>
        /// Ограничение на устанавливаемую дату рождения (минимум 1 января 1901)
        /// </summary>
        private readonly DateTime _dateMinimum = new DateTime(1901, 01, 01);

        /// <summary>
        /// Метод, устанавливающий и возвращающий дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                //Дата рождения не может быть раньше 1 января 1901 года.
                if (value < _dateMinimum)
                {
                    throw new ArgumentException(
                        "Вы ввели неправильную дату рождения.\n"
                        + "Введите дату, начиная с 1901 года.");
                }

                //Дата рождения не может быть больше нынешней даты.
                if (value > DateTime.Now)
                {
                    throw new ArgumentException(
                        "Вы ввели неверную дату рождения.\n"
                        + "Дата рождения не может быть больше, чем нынешняя.\n"
                        + "Введите дату рождения заново");
                }
                else
                    _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий и возвращающий ID Vk контакта.
        /// </summary>
        public string IdVk
        {
            get { return _idVk; }
            set
            {
                //ID не может быть длиннее 15 символов.
                if (value.Length > 12)
                {
                    throw new ArgumentException(
                        "ID Вконтакте не может превышать 12 символов.\n"
                        + "Введите ID, который не превышает 12 символов");
                }
                //Проверка на пустую строку.
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод.");
                }
                else
                    _idVk = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий и возвращающий фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                //Фамилия не может быть длиннее 50 символов.
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Вы ввели фамилию, состоящую более чем из 50 символов.\n" +
                        "Введите фамилию, длиной до 50 символов.");
                }

                //Фамилия не может быть короче 1 символов (есть фамилии с 2 буквой)
                if (value.Length < 2)
                {
                    throw new ArgumentException(
                        "Вы ввели фамилию, состоящую менее чем из 2 символов.\n" +
                        "Введите фамилию, длиной более 2 символов.");
                }

                //Проверка на пустую строку.
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку.\nПовторите ввод.");
                }
                else
                {
                    //Вся строка в нижний регистр.
                    value.ToLower();

                    //Представляем строку как массив чар.
                    char[] familyChar = value.ToCharArray();

                    //1 элемент массива в верхний регистр.
                    familyChar[0] = char.ToUpper(familyChar[0]);

                    //Переписываем в стринг
                    string familyString = new string(familyChar);

                    //Вносим данные.
                    _surname = familyString;
                }
            }
        }

        /// <summary>
        /// Метод, устанавливающий и возвращающий имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                //Имя не может быть длиннее 60 символов.
                if (value.Length > 60)
                {
                    throw new ArgumentException(
                        "Вы ввели имя, состоящее более чем из 60 символов.\n" +
                        "Введите имя, длиной до 60 символов.");
                }

                //Имя не может быть короче 1 символов.
                if (value.Length < 1)
                {
                    throw new ArgumentException(
                        "Вы ввели имя, состоящее менее чем из 1 символов.\n" +
                        "Введите имя, длиной более 1 символов.");
                }

                //Проверка на пустую строку.
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод.");
                }
                else
                {
                    //Вся строка в нижний регистр.
                    value.ToLower();

                    //Представляем строку как массив чар.
                    char[] nameChar = value.ToCharArray();

                    //1 элемент массива в верхний регистр.
                    nameChar[0] = char.ToUpper(nameChar[0]);

                    //Переписываем в стринг
                    string nameString = new string(nameChar);

                    _name = nameString;
                }
            }
        }

        /// <summary>
        /// Метод, устанавливающий и возвращающий E-mail контакта.
        /// </summary>

        public string Email
        {
            get { return _email; }
            set
            {
                //E-mail не может быть длиннее чем 64 символа.
                if (value.Length > 64)
                {
                    throw new ArgumentException(
                        "Вы ввели e-mail, длиной более чем 64 символов.\n" +
                        "Введите e-mail, длиной до 64 символов.");
                }
                //Проверка на пустую строку.
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод.");
                }
                else
                    _email = value;
            }
        }

        /// <summary>
        /// Конструктор класса с 6 входными параметрами.
        /// </summary>
        /// <param name="phoneNumber"></param> Номер телефона контакта.
        /// <param name="name"></param> Имя контакта.
        /// <param name="surname"></param> Фамилия контакта.
        /// <param name="email"></param> E-mail контакта.
        /// <param name="dateOfBirth"></param> Дата рождения контакта.
        /// <param name="idVk"></param> ID Vk контакта.
        public Contact(long phoneNumber, string name, string surname, string email, DateTime dateOfBirth,
            string idVk)
        {
            this.phoneNumber.Number = phoneNumber;
            Name = name;
            Surname = surname;
            Email = email;
            DateOfBirth = dateOfBirth;
            IdVk = idVk;
        }

        /// <summary>
        /// Реализация клонирования
        /// </summary>
        /// <returns>Возвращает объект - клон контакта, с полями: номер телефона, имя, фамилия, емейл, дата рождения, айди вк.</returns>
        public object Clone()
        {
            return new Contact(phoneNumber.Number, Name, Surname, Email, DateOfBirth, IdVk);
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Contact()
        { }
    }
}



