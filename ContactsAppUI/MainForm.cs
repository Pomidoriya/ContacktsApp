using System;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        //Создаем список контактов.
        private Project _project;
        private Project _sortProject;

        public MainForm()
        {
            InitializeComponent();

            //Выполняем десериализацию.
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);
            int countContacts = 0;

            //Выводим пока количество записей в файле не равно количеству записей в ListBox.
            while (countContacts != _project._contactsList.Count)
            {
                ContactsListBox.Items.Add(_project._contactsList[countContacts].Surname+ " " 
                    + _project._contactsList[countContacts].Name);
                countContacts++;
            }

           Project birthContact = Project.Birthday(_project, DateTime.Today);
            for (int i = 0; i < birthContact._contactsList.Count; i++)
            {
                BirthdayEnum.Text = BirthdayEnum.Text +"• "+ birthContact._contactsList[i].Surname +
                    " " + birthContact._contactsList[i].Name +  "\n";
            }

            //Подсказка для кнопок Add, Remove, Edit
            ToolTip addRemoveEdiToolTip = new ToolTip();
            addRemoveEdiToolTip.SetToolTip(button1, "Нажмите для добавления контакта в список.");
            addRemoveEdiToolTip.SetToolTip(button3, "Нажмите для удаления контакта из списка.");
            addRemoveEdiToolTip.SetToolTip(button2, "Нажмите для редактирования контакта.");
        }
        
        /// <summary>
        /// Функция добавления контакта.
        /// </summary>
        private void AddContact()
        {
            var newForm = new AddEditContactForm();

            //Создаем переменную, в которую помещаем результат взаимодействия пользователя с формой.
            var resultOfDialog = newForm.ShowDialog();

            //Если пользователь нажал ОК, то вносим исправленные данные.
            if (resultOfDialog == DialogResult.OK)
            {
                var contact = newForm.Contact;
                _project._contactsList.Add(contact);
               
                for (int i = 0; i != _project._contactsList.Count - 1; i++)
                {
                    ContactsListBox.Items.RemoveAt(0);
                }

                _project = Project.Sort(_project);

                for (int j = 0; j != _project._contactsList.Count; j++)
                {
                    ContactsListBox.Items.Add(_project._contactsList[j].Surname +
                    " " + _project._contactsList[j].Name);
                }

                ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
            }
        }

        /// <summary>
        /// Функция удаления контакта.
        /// </summary>
        private void RemoveContact()
        {
            var index = ContactsListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Выберите запись для удаления.", "Удалить");
            }

            //Если список не пуст.
            if (_project._contactsList.Count > 0)
            {
                if (index >= 0)
                {
                    string removeThisContact =
                        "Вы точно хотите удалить контакт: " + SurnameTextBox.Text + " " +NameTextBox.Text + "?";

                    var result = MessageBox.Show(removeThisContact, "Удалить", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        _project._contactsList.RemoveAt(index);
                        ContactsListBox.Items.RemoveAt(index);
                        ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
                    }
                }
            }
            else
            {
                if (index >= 0)
                {
                    MessageBox.Show("Выберите запись для удаления.", "Удалить");
                }
            }
        }

        /// <summary>
        /// Функция, выполняющая редактирование данных.
        /// </summary>
        private void EditContact()
        {
            var index = ContactsListBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Выберите запись для редактирования.", "Редактировать");
            }

            //Если список не пуст.
            if (_project._contactsList.Count > 0)
            {
                if (index >= 0)
                {
                    var contactOfIndex = _project._contactsList[index];
                    int sortIndex = 0;

                    //Если сортированный список не пуст, то выбираем элемент из него
                    if (_sortProject != null && _sortProject._contactsList.Count > 0 && FindTextBox.Text != "")
                    {
                        contactOfIndex = _sortProject._contactsList[index];
                        sortIndex = index;

                        for (int i = 0; i < _project._contactsList.Count; i++)
                        {
                            if (contactOfIndex == _project._contactsList[i])
                            {
                                index = i;
                                break;
                            }
                        }
                    }
                    
                    Contact newCloneContact = (Contact) contactOfIndex.Clone();
                    var newForm = new AddEditContactForm();
                    newForm.Contact = newCloneContact;

                    //Создаем переменную, в которую помещаем результат взаимодействия пользователя с формой.
                    var resultOfDialog = newForm.ShowDialog();

                    //Если пользователь нажал ОК, то вносим исправленные данные.
                    if (resultOfDialog == DialogResult.OK)
                    {
                        contactOfIndex = newForm.Contact;

                        //Если введена подстрока.
                        if (_sortProject != null && _sortProject._contactsList.Count > 0 && FindTextBox.Text != "")
                        {
                            _project._contactsList.RemoveAt(index);
                            _sortProject._contactsList.RemoveAt(sortIndex);
                            _project._contactsList.Insert(index, contactOfIndex);

                            while (ContactsListBox.Items.Count != 0)
                            {
                                ContactsListBox.Items.RemoveAt(0);
                            }

                            _sortProject = Project.Sort(_project, FindTextBox.Text);
                            
                            if (_sortProject != null && _sortProject._contactsList.Count != 0)
                            {
                                for (int i = 0; i < _sortProject._contactsList.Count; i++)
                                {
                                    ContactsListBox.Items.Add(_sortProject._contactsList[i].Surname +
                    " "+ _sortProject._contactsList[i].Name);
                                }
                            }

                            _project = Project.Sort(_project);
                        }

                        //Если подстрока не введена.
                        else
                        {
                            _project._contactsList.RemoveAt(index);
                            _project._contactsList.Insert(index, contactOfIndex);

                            while (ContactsListBox.Items.Count != 0)
                            {
                                ContactsListBox.Items.RemoveAt(0);
                            }

                            _project = Project.Sort(_project);

                            for (int j = 0; j != _project._contactsList.Count; j++)
                            {
                                ContactsListBox.Items.Add(_project._contactsList[j].Surname +
                    " "+_project._contactsList[j].Name);
                            }
                        }

                        //Выполняем сериализацию данных.
                        ProjectManager.SaveToFile(_project, ProjectManager.DefaultFilePath);
                    }
                }
                else
                {
                    if (index >= 0)
                    {
                        MessageBox.Show("Выберите запись для редактирования.", "Редактировать");
                    }
                }
            }
        }

        /// <summary>
        /// Вызывает функцию для добавления контакта.
        /// </summary>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Вызывает функцию для редактирования контакта.
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Вызывает функцию для удаления контакта.
        /// </summary>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        /// <summary>
        /// Переключение между контактами списка и вывод выбранного контакта.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex =  ContactsListBox.SelectedIndex;
            
            if(selectedIndex == -1)
            {
                SurnameTextBox.Text = null;
                NameTextBox.Text = null;
                BirthdayDateTimePicker.Value = new DateTime(1900, 01, 01);
                PhoneTextBox.Text = null;
                EmailTextBox.Text = null;
                VkTextBox.Text = null;
            }

            if (_project._contactsList.Count > 0)
            {
                if (selectedIndex >= 0)
                {
                    Contact contact;
                    if (_sortProject != null && _sortProject._contactsList.Count > 0 && FindTextBox.Text != "")
                    {
                        contact = _sortProject._contactsList[selectedIndex];
                    }
                    else
                    { 
                        contact = _project._contactsList[selectedIndex];
                    }

                    //Заполняем правую часть главной формы данными выбранного элемента.
                    SurnameTextBox.Text = contact.Surname;
                    NameTextBox.Text = contact.Name;
                    BirthdayDateTimePicker.Value = contact.DateOfBirth;
                    PhoneTextBox.Text = Convert.ToString(contact.phoneNumber.Number);
                    EmailTextBox.Text = contact.Email;
                    VkTextBox.Text = contact.IdVk;
                }
            }
            else
            {
                SurnameTextBox.Text = null;
                NameTextBox.Text = null;
                BirthdayDateTimePicker.Value = new DateTime(1900,01,01);
                PhoneTextBox.Text = null;
                EmailTextBox.Text = null;
                VkTextBox.Text = null;
            }
        }

        /// <summary>
        /// Добавление контакта по клику в выпадающем сверху меню из Edit.
        /// </summary>
        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Выпадение формы About, при клике в верхнем меню на About.
        /// </summary>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new AboutForm();
            newForm.Show();
        }

        /// <summary>
        /// Редактирование контакта по клику в выпадающем сверху меню из Edit.
        /// </summary>
        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }
        
        /// <summary>
        /// Удаление контакта по клику в выпадающем сверху меню из Edit.
        /// </summary>
        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        /// <summary>
        /// Закрывает главное окно по клику в выпадающем сверху меню на Exit.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Функция поиска подстроки.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);
                while (ContactsListBox.Items.Count != 0)
                {
                    ContactsListBox.Items.RemoveAt(0);
                }
                for (int i = 0; i != _project._contactsList.Count; i++)
                {
                    ContactsListBox.Items.Add(_project._contactsList[i].Surname +
                    " " + _project._contactsList[i].Name);
                }
            }

            else
            {
                _project = ProjectManager.LoadFromFile(ProjectManager.DefaultFilePath);
                _sortProject = Project.Sort(_project, FindTextBox.Text);
                if (_sortProject == null)
                {
                    while (ContactsListBox.Items.Count != 0)
                    {
                        ContactsListBox.Items.RemoveAt(0);
                    }
                }
                else
                {
                    while (ContactsListBox.Items.Count != 0)
                    {
                        ContactsListBox.Items.RemoveAt(0);
                    }
                    for (int i = 0; i != _sortProject._contactsList.Count; i++)
                    {
                        ContactsListBox.Items.Add(_sortProject._contactsList[i].Surname +
                    " " + _sortProject._contactsList[i].Name);
                    }
                }
            }
        }

        /// <summary>
        /// Удаление контакта по нажатию клавиши Delete.
        /// </summary>
        private void ContactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveContact();
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }
    }
}