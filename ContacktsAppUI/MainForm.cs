using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContacktsApp;
namespace ContacktsAppUI
{
    public partial class MainForm : Form
    {
        Project listContacts = new Project();
        Project listContacts1 = new Project();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact(71233231221, "igor", "Serdyuk", "igorserd@gm.re", DateTime.Now, "77078677680");
            listContacts.contactsList.Add(contact);
            ProjectManager.SaveToFile(listContacts);
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listContacts1 = ProjectManager.LoadFromFile();

            foreach(Contact i in listContacts1.contactsList)
            {
                label1.Text = i.Name + " "+ i.Surname + " " + i.IdVk + " " + i.Email + " " + i.DateOfBirth + " " + i.phoneNumber;
            }
        }

       
    }
}
