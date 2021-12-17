using System;


namespace ContactsApp
{
    /// <summary>
    /// Класс, принимающий и возвращающий номер телефона учащегося.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;
        /// <summary>
        /// Метод, устанавливающий и возвращающий номер контакта.
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                //Проверка на начало номера с 8.
                if (value.ToString()[0] != '8')
                {
                    throw new ArgumentException("Enter a phone number starting with 8.");
                }

                //Проверка на количество цифр.
                if (value > 99999999999)
                {
                    throw new ArgumentException("You have entered an incorrect value," +
                        " please enter a number consisting of 11 digits!");
                }

                //Проверка на количество цифр
                if (value < 10000000000)
                {
                    throw new ArgumentException("You have entered an incorrect value," +
                        " please enter a number consisting of 11 digits!");
                }

                else
                {
                    _number = value;
                }
            }
        }
    }
}
