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
    public partial class ViewForm : Form
    {
        public string id,title,state,description,owner,date;
        public ViewForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            BugTracker.Home f = new BugTracker.Home();
            f.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            BugTracker.ViewForm f = new BugTracker.ViewForm(); f.Show();
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (search_box.Text != "" & search_box.Text != "Bug Title")
            {
                using (DataSet ds = datamanager.getdatasetstored("FindBug", "Bugs", datamanager.createparameter("@title", SqlDbType.NVarChar, search_box.Text)))
                {
                    var table = ds.Tables[0];
                    if (table.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables["Bugs"];
                    }
                    else { MessageBox.Show("No Bug Found"); }

                }
            }
            else { MessageBox.Show("Please enter Bug Title"); }
            search_box.Text = "";

        }

        private void search_box_Click(object sender, EventArgs e)
        {
            search_box.Text = "";
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            using (DataSet ds = datamanager.getdatasetstored("ViewBugs", "Bugs"))
            {
                var table = ds.Tables[0];

                dataGridView1.DataSource = ds.Tables["Bugs"];

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete 
            if (MessageBox.Show("Do You Want To Delete This Bug", "Delete Bug ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewCell onecell in dataGridView1.SelectedCells)
                {
                    if (onecell.Selected)
                    {
                        id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        datamanager.executenonqueryoutput("DeleteBug", datamanager.createparameter("id", SqlDbType.Int, id));
                        dataGridView1.Rows.RemoveAt(onecell.RowIndex);
                        MessageBox.Show("Successfully Deleted ");


                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //ubdate 

            datamanager.executenonqueryoutput("UpdateBug", datamanager.createparameter("@id", SqlDbType.Int, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                , datamanager.createparameter("@title", SqlDbType.NVarChar, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString())
                , datamanager.createparameter("@state", SqlDbType.NVarChar, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                , datamanager.createparameter("@description", SqlDbType.NVarChar, dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString())
                , datamanager.createparameter("@owner", SqlDbType.NVarChar, dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())
                , datamanager.createparameter("@date", SqlDbType.NVarChar, dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()));
            MessageBox.Show("Successfully updated");

        }
    }
}
