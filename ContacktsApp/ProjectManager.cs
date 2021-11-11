using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
namespace ContacktsApp
{
    /// <summary>
    /// Класс, реализующий сохранение данных в файл и загрузки из него.
    /// </summary>
    public class ProjectManager
    {
        //TODO: переменная приравненая к адрессу, для дальнейшего улучшению
        private const string V = "C:\\Users\\Игорь\\AppData\\Roaming\\111.txt";
        
        /// <summary>
        /// Стандартный путь к файлу.
        /// </summary>
        public static readonly string FilesDirectory = V;//переместить ссылку на сохранение в myDocuments или APPDATA
                                                                            // сделал временно для проверки через форму
        /// <summary>
        /// Метод, выполняющий запись в файл 
        /// </summary>
        /// <param name="contact">Экземпляр проекта для сериализации</param>
     
        public static void SaveToFile(Project contact)
        {
            // Экземпляр сериалиатора
            JsonSerializer serializer = new JsonSerializer();

            var directoryFileContactApp = System.IO.Path.GetDirectoryName(FilesDirectory);

            //Проверка на папку. Если нет папки ContactsApp, то создаем ее.
            if (!System.IO.Directory.Exists(directoryFileContactApp))
            {
                Directory.CreateDirectory(directoryFileContactApp);
            }

            //Проверка на файл. Еси нет файла, то создаем его.
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
        
        
        public static Project LoadFromFile()
        {
            //Переменная, в которую будет помещен результат десериализации
            Project project = new Project();

            //Экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Проверка на наличие файла
            if (System.IO.File.Exists(FilesDirectory))
            {
                //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(FilesDirectory))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
            }

            return project;
        }
    }
}

