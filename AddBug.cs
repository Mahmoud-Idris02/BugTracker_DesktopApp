using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class AddBug : Form
    {
        public AddBug()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BugTracker.Home f = new BugTracker.Home();
            f.Show();
            this.Close();
            

        }

        private void Create_Click(object sender, EventArgs e)
        {
            datamanager.executenonqueryoutput("AddBug", datamanager.createparameter("@title", SqlDbType.NVarChar, Title.Text)
                , datamanager.createparameter("@state", SqlDbType.NVarChar, state.SelectedItem)
                , datamanager.createparameter("@description", SqlDbType.NVarChar, Description.Text)
                , datamanager.createparameter("@owner", SqlDbType.NVarChar, Creation.Text)
                , datamanager.createparameter("@date", SqlDbType.NVarChar, dateTimePicker1.Text));
                  MessageBox.Show("Successfully Added");
            Title.Text = Description.Text =Creation.Text = "";
            state.SelectedItem = "";
        }
    }
}
