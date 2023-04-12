namespace BugTracker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Add_Bug_Click(object sender, EventArgs e)
        {
            
            BugTracker.AddBug f = new BugTracker.AddBug();
            f.Show();
            this.Hide();

        }

        private void View_Bug_Click(object sender, EventArgs e)
        {
            
            BugTracker.ViewForm f = new BugTracker.ViewForm();
            f.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}