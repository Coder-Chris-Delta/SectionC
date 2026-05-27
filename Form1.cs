namespace SectionC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mobileCode = txtCode.Text;
            string make = txtMake.Text;
            string quantity = txtQuantity.Text;

            if (string.IsNullOrWhiteSpace(mobileCode))
            {
                MessageBox.Show("Please enter a mobile code");
            }
            if (string.IsNullOrWhiteSpace(make))
            {
                MessageBox.Show("Please enter a make");
            }
            if (!int.TryParse(quantity, out int phoneQuantity))
            {
                MessageBox.Show("Please enter the number of quantity ");
            }

            tblMobilePhones.Items.Add($"Mobile code :{mobileCode} Make: {make} Quantity: {phoneQuantity}");

            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter a code to delete in the MobileCode Box");
            }


            if (tblMobilePhones.Items.Contains(code))
            {
                tblMobilePhones.Items.Remove(code);
                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT Found";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter a code to delete in the MobileCode Box");
            }
            else
            {
                lblOutput.Text = "Record Deleted";
            }

            
        }
    }
}
