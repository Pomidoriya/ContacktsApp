using System;
using System.Collections.Generic;


namespace ContactsApp
{
    using System.Linq;
    /// <summary>
    /// Класс, содержащий лист всех контактов.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Лист, который хранит в себе список контактов.
        /// </summary>
        public List<Contact> _contactsList = new List<Contact>();

        /// <summary>
        /// Функция, выполняющая сортировку по алфавиту.
        /// </summary>
        /// <param name="project">Список, который нужно отсортировать</param>
        /// <returns>Отсортированный список</returns>
        
        public static Project Sort(Project project) 
        {
            Project sortedProject = new Project();
           sortedProject._contactsList.Add(project._contactsList[0]);
            /*
             var unsortedContacts = project._contactsList;
            var sortedContacts = unsortedContacts.OrderBy(contact => contact.Surname).ToList(); //встроенная сортировка
            */
             for (int i = 1; i < project._contactsList.Count; i++)
             {

                 if (sortedProject._contactsList[i - 1].Surname[0] < project._contactsList[i].Surname[0] ||
                     sortedProject._contactsList[i - 1] == project._contactsList[i])
                 {
                     sortedProject._contactsList.Insert(i, project._contactsList[i]);
                     continue;
                 }

                 int j = i;

                 //Флаг, разрешающий присвоение
                 bool flag = true;

                 //Пока 1 символ отсортированной фамилии больше или равен 1 символа не сортированной
                 while (j > 0 && sortedProject._contactsList[j - 1].Surname[0] >= project._contactsList[i].Surname[0] &&
                        sortedProject._contactsList[j - 1] != project._contactsList[i] && flag)
                 {
                     if (project._contactsList.Count == sortedProject._contactsList.Count)
                     {
                         return sortedProject;
                     }

                     //Находим длину самой короткой фамилии.
                     int countSubmolSurname = project._contactsList[i].Surname.Length >=
                                              sortedProject._contactsList[j - 1].Surname.Length
                         ? sortedProject._contactsList[j - 1].Surname.Length - 1
                         : project._contactsList[i].Surname.Length - 1;

                     //Если первые символы фамилий равны.
                     if (sortedProject._contactsList[j - 1].Surname[0] == project._contactsList[i].Surname[0])
                     {
                         //Флаг true, если перепрыгнули фамилию, которая начинается с той же буквы.
                         bool flagJump = false;
                         while (j != 1 && sortedProject._contactsList[j - 1].Surname[0] ==
                                project._contactsList[i].Surname[0] && flag == true)
                         {
                             //Переменная для перебора символов фамилии.
                             int g = 1;
                             while (sortedProject._contactsList[j - 1].Surname[g] == project._contactsList[i].Surname[g] &&
                                    flag == true)
                             {
                                 g++;

                                 //Если g больше количества символов в фамилии, то фамилия в project является подстрокой фамилии sorted.
                                 if (g > countSubmolSurname)
                                 {
                                     if (sortedProject._contactsList[j - 1].Surname == project._contactsList[i].Surname)
                                     {
                                         sortedProject._contactsList.Insert(j, project._contactsList[i]);
                                         flag = false;
                                         g = 1;
                                         continue;
                                     }

                                     //Если не конец списка, то проверяем со следующим элементом списка.
                                     if (j != 1 && flag == true)
                                     {
                                         j--;
                                         countSubmolSurname = project._contactsList[i].Surname.Length >=
                                                              sortedProject._contactsList[j - 1].Surname.Length
                                             ? sortedProject._contactsList[j - 1].Surname.Length - 1
                                             : project._contactsList[i].Surname.Length - 1;

                                         //Проверяем содержится ли подстрока 
                                         int entry = sortedProject._contactsList[j - 1].Surname
                                             .IndexOf(project._contactsList[i].Surname);

                                         //Если в следующем элементе списка не содержится подстрока, то вставляем после этого элемента.
                                         if (entry == -1)
                                         {
                                             sortedProject._contactsList.Insert(j + 1, project._contactsList[i]);
                                             flag = false;
                                         }


                                         g = 1;
                                         continue;
                                     }

                                     //Если j=1, то проверяли с 0 элементом сортированного списка и нужно вставить фамилию на 0 элемент.
                                     else
                                     {
                                         sortedProject._contactsList.Insert(0, project._contactsList[i]);
                                         flag = false;
                                         g = 1;
                                         continue;
                                     }
                                 }
                             }

                             //Если в сортированном списке соответствующий символ меньше, то добавляем после сортированного элемента.
                             if (sortedProject._contactsList[j - 1].Surname[g] < project._contactsList[i].Surname[g] &&
                                 flag == true)
                             {
                                 sortedProject._contactsList.Insert(j, project._contactsList[i]);
                                 flag = false;
                                 continue;
                             }

                             else if (flag == true)
                             {
                                 j--;
                                 countSubmolSurname = project._contactsList[i].Surname.Length >=
                                                      sortedProject._contactsList[j - 1].Surname.Length
                                     ? sortedProject._contactsList[j - 1].Surname.Length - 1
                                     : project._contactsList[i].Surname.Length - 1;
                                 if (sortedProject._contactsList[j - 1].Surname[0] != project._contactsList[i].Surname[0])
                                 {
                                     flagJump = true;
                                 }
                             }
                         }

                         //Если перепрыгнули фамилию с одинаковой 1 буквой.
                         if (flagJump == true)
                         {
                             sortedProject._contactsList.Insert(j, project._contactsList[i]);
                             flag = false;
                             continue;
                         }

                         int k = 1;

                         //Пока символ сортированной фамилии равен соответствующему символу несортированной.
                         while (sortedProject._contactsList[j - 1].Surname[k] == project._contactsList[i].Surname[k] &&
                                flag == true)
                         {
                             k++;
                             if (k == countSubmolSurname)
                             {
                                 break;
                             }

                             if (k > countSubmolSurname)
                             {
                                 k--;
                                 break;
                             }
                         }

                         if (sortedProject._contactsList[j - 1].Surname[k] < project._contactsList[i].Surname[k] &&
                             flag == true)
                         {
                             sortedProject._contactsList.Insert(j, project._contactsList[i]);
                             flag = false;
                             continue;
                         }

                         else if (flag == true)
                         {
                             int entry = project._contactsList[i].Surname
                                 .IndexOf(sortedProject._contactsList[j - 1].Surname);

                             if (entry == 0)
                             {
                                 sortedProject._contactsList.Insert(j, project._contactsList[i]);
                                 flag = false;
                                 continue;
                             }

                             else
                             {
                                 sortedProject._contactsList.Insert(j - 1, project._contactsList[i]);
                                 flag = false;
                                 continue;
                             }

                         }
                     }

                     if (sortedProject._contactsList[j - 1].Surname[0] > project._contactsList[i].Surname[0] &&
                         flag == true)
                     {
                         j--;
                         continue;
                     }

                     if (j == 1 && flag == true)
                     {
                         sortedProject._contactsList.Insert(0, project._contactsList[i]);
                         continue;
                     }
                     else if (flag == true)
                     {
                         sortedProject._contactsList.Insert(j - 1, project._contactsList[i]);
                         continue;
                     }

                     j--;
                 }

                 if (flag == true)
                 {
                     sortedProject._contactsList.Insert(j, project._contactsList[i]);
                 }
             }
             return sortedProject;
        }
        
        /// <summary>
        /// Функция, которая выполняет поиск контактов по имени и фамилии по указанной подстроке и сортирует их в алфавитном порядке.
        /// </summary>
        /// <param name="project">Проект, хранящий список, в котором будет выполняться поиск.</param>
        /// <param name="substring">Подстрока, вхождение которой будет искаться.</param>
        /// <returns>Проект с отсортированным списком, в котором есть вхождение подстроки.</returns>
        public static Project Sort(Project project, string substring)
         {
             Project sortedProject = new Project();

             for (int i = 0; i < project._contactsList.Count; i++)
             {
                 if (project._contactsList[i].Surname.Contains(substring) ||
                     project._contactsList[i].Name.Contains(substring))
                 {
                     sortedProject._contactsList.Add(project._contactsList[i]);
                 }
             }

             if (sortedProject._contactsList.Count == 0)
             {
                 sortedProject = null;
                 return sortedProject;
             }

             Project.Sort(sortedProject);

             return sortedProject;
         }

            /// <summary>
            /// Функция, выполняющая поиск людей, у который день рождения в указанную дату.
            /// </summary>
            /// <param name="project">Проект, содержащий список людей, среди который будем искать у кого день рождения.</param>
            /// <param name="today">Дата дня рождения.</param>
            /// <returns>Проект, хранящий список именинников.</returns>
            public static Project Birthday(Project project, DateTime today)
        {
            Project birthdayList = new Project();

            for (int i = 0; i < project._contactsList.Count; i++)
            {
                if (project._contactsList[i].DateOfBirth.Day == today.Day &&
                    project._contactsList[i].DateOfBirth.Month == today.Month)
                {
                    birthdayList._contactsList.Add(project._contactsList[i]);
                }
            }

            return birthdayList;
        }
    }
}
