using System;
using System.Collections.Generic;
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
            mcStartDate.MaxSelectionCount = 1000;
            lblStartDate.Text = $"{mcStartDate.SelectionRange.Start.ToString("dd-MM-yyyy")}";
            lblEndDate.Text = $"{mcStartDate.SelectionRange.End.ToString("dd-MM-yyyy")}";
        }

        private void mcEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string startDate = lblStartDate.Text;
            string endDate = lblEndDate.Text;
            DateTime start = mcStartDate.SelectionStart;
            DateTime end = mcStartDate.SelectionEnd;
            // go to the method to bring information from the database
            //change panel
            if (start > DateTime.Today || end > DateTime.Today)
            {
                MessageBox.Show("Enter a valid date!");
            }
            else if (start > end)
            {
                MessageBox.Show("Start date should be older than end date");
            }
            else
            {
                if (rbSales.Checked)
                {
                    SomerenLogic.Revenue_Service revenue_Service = new SomerenLogic.Revenue_Service();
                    List<SomerenModel.Revenue> revenues = revenue_Service.GetRevenue(start, end);

                    lstvRevenue.Clear();
                    lstvRevenue.View = View.Details;
                    lstvRevenue.Columns.Add("NumberOfCustomer");
                    lstvRevenue.Columns.Add("StudentName");
                    lstvRevenue.Columns.Add("NumberOfSales");
                    lstvRevenue.Columns[0].Width = 100;
                    lstvRevenue.Columns[1].Width = 100;
                    lstvRevenue.Columns[2].Width = 100;

                    foreach (SomerenModel.Revenue rev in revenues)
                    {
                        ListViewItem list = new ListViewItem(rev.NCustomers.ToString());
                        list.SubItems.Add(rev.StudentName);
                        list.SubItems.Add(rev.Sales.ToString());
                        lstvRevenue.Items.Add(list);
                    }
                }
                else if (rbTurnover.Checked)
                {
                    SomerenLogic.Turnover_Service turnover_Service = new SomerenLogic.Turnover_Service();
                    List<SomerenModel.Turnover> turnovers = turnover_Service.GetTurnover(start, end);

                    lstvRevenue.Clear();
                    lstvRevenue.View = View.Details;
                    lstvRevenue.Columns.Add("DrinksSold");
                    lstvRevenue.Columns[0].Width = 100;
                    lstvRevenue.Columns.Add("DrinkName");
                    lstvRevenue.Columns.Add("StudentName");
                    lstvRevenue.Columns.Add("PriceOfDrinks");
                    lstvRevenue.Columns.Add("TotalPrice");
                    lstvRevenue.Columns[1].Width = 100;
                    lstvRevenue.Columns[2].Width = 100;
                    lstvRevenue.Columns[3].Width = 100;
                    lstvRevenue.Columns[4].Width = 100;

                    foreach (SomerenModel.Turnover turn in turnovers)
                    {
                        ListViewItem list = new ListViewItem(turn.Sales.ToString());
                        list.SubItems.Add(turn.DrinkName);
                        list.SubItems.Add(turn.StudentName);
                        list.SubItems.Add(turn.Price.ToString());
                        list.SubItems.Add(turn.Totturnover.ToString());
                        lstvRevenue.Items.Add(list);
                    }
                }
                
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
