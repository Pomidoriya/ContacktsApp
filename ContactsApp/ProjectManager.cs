using System;
using System.IO;
using Newtonsoft.Json;
namespace ContactsApp
{
    /// <summary>
    /// Класс, реализующий сохранение данных в файл и загрузки из него.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Стандартный путь к файлу.
        /// </summary>
        public static readonly string FilesDirectoryDefault = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
             "\\ContactApp" + "\\ContactApp.txt";

        /// <summary>
        /// Метод, выполняющий запись в файл 
        /// </summary>
        /// <param name="contact">Экземпляр проекта для сериализации</param>
        /// <param name="FilesDirectoryDefault">Путь к файлу</param>
        public static void SaveToFile(Project contact, string FilesDirectoryDefault)
        {
            // Экземпляр сериалиатора
            JsonSerializer serializer = new JsonSerializer();

            var directoryFileContactApp = Path.GetDirectoryName(FilesDirectoryDefault);

            //Проверка на наличие папки, если нет папки - создаем ее.
            if (!Directory.Exists(directoryFileContactApp))
            {
                Directory.CreateDirectory(directoryFileContactApp);
            }

            //Проверка на наличие файла, если его нет - создаем.
            if (!File.Exists(FilesDirectoryDefault))
            {
                File.Create(FilesDirectoryDefault).Close();
            }

            using (StreamWriter sw = new StreamWriter(FilesDirectoryDefault))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызов сериализатора и передача объекта сериализации
                serializer.Serialize(writer, contact);
            }
        }

        /// <summary>
        /// Метод, выполняющий чтение из файла 
        /// </summary>
        public static Project LoadFromFile(string FilesDirectoryDefault)
        {
            //Переменная, в которую будет помещен результат 
            Project project = new Project();

            //Экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Проверка на наличие файла
            if (File.Exists(FilesDirectoryDefault))
            {
                //Открываем для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(FilesDirectoryDefault))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и преобразуем в целевой тип данных
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            }

            return project;
        }
    }
}

