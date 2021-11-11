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
    }
}
