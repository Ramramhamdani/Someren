using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void mcStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartDate.Text = $"{mcStartDate.SelectionRange.Start.ToString("dd/MMM/yyyy")}";
        }

        private void mcEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblEndDate.Text = $"{mcStartDate.SelectionRange.Start.ToString("dd/MMM/yyyy")}";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string startDate = lblStartDate.Text;
            string endDate = lblEndDate.Text;
            DateTime start = mcStartDate.SelectionStart;
            DateTime end = mcEndDate.SelectionStart;
            // go to the method to bring information from the database
            //change panel
            if (start > DateTime.Today || end > DateTime.Today)
            {
                MessageBox.Show("Enter a valid date!");
            }
            else
            {
                Close();
            }
        }
    }
}
