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
        public static readonly string FilesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
             "\\ContactApp" + "\\ContactApp.txt";
        //путь к папке appdata+roaming

        /// <summary>
        /// Метод, выполняющий запись в файл 
        /// </summary>
        /// <param name="contact">Экземпляр проекта для сериализации</param>
        /// <param name="fileContactAppPath">Путь к файлу</param>
        public static void SaveToFile(Project contact, string FilesDirectory)
        {
            // Экземпляр сериалиатора
            JsonSerializer serializer = new JsonSerializer();

            var directoryFileContactApp = System.IO.Path.GetDirectoryName(FilesDirectory);

            //Проверка на наличие папки, если нет папки - создаем ее.
            if (!System.IO.Directory.Exists(directoryFileContactApp))
            {
                Directory.CreateDirectory(directoryFileContactApp);
            }

            //Проверка на наличие файла, если его нет - создаем.
            if (!System.IO.File.Exists(FilesDirectory))
            {
                File.Create(FilesDirectory).Close();
            }

            using (StreamWriter sw = new StreamWriter(FilesDirectory))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызов сериализатора и передача объекта сериализации
                serializer.Serialize(writer, contact);
            }
        }

        /// <summary>
        /// Метод, выполняющий чтение из файла 
        /// </summary>
        public static Project LoadFromFile(string FilesDirectory)
        {
            //Переменная, в которую будет помещен результат 
            Project project = new Project();

            //Экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Проверка на наличие файла
            if (System.IO.File.Exists(FilesDirectory))
            {
                //Открываем для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(FilesDirectory))
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

