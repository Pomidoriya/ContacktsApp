using System;


namespace ContacktsApp
{
    /// <summary>
    /// Класс, принимающий и возвращающий номер телефона учащегося.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        public long Number
        {
            get { return _number; }
            set
            {
                //Проверка на начало номера с 8.
                if (value.ToString()[0] != '8')
                {
                    throw new ArgumentException("Введите номер телефона, начинающийся с 8.");
                }

                //Проверка на количество цифр.
                if (value > 99999999999)
                {
                    throw new ArgumentException("Вы ввели некорректное значение, введите номер, состоящий из 11 цифр!");
                }

                //Проверка на количество цифр
                if (value < 10000000000)
                {
                    throw new ArgumentException("Вы ввели некорректное значение, введите номер, состоящий из 11 цифр!");
                }

                else
                {
                    _number = value;
                }
            }
        }
    }
}
