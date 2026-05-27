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
                MessageBox.Show("Please enter the a mobile code");
            }else if (string.IsNullOrWhiteSpace(make))
            {
                MessageBox.Show("Please enter the make");
            }else if((!int.TryParse(quantity, out int phoneQuantity))){
                MessageBox.Show("Please enter the the quantity in a number");
            }
            else
            {
                tblMobilePhones.Items.Add(mobileCode);
                tblMobilePhones.Items.Add(make);
                tblMobilePhones.Items.Add(quantity);
                lblOutput.Text = "Record Added";
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Please enter a code to delete in the MobileCode Box");
            }



            if (code.Equals(tblMobilePhones.Items[0].ToString()))
            {
                tblMobilePhones.Items.Remove(tblMobilePhones.Items[0]);
                tblMobilePhones.Items.Clear();
                
                lblOutput.Text = "Record Found";
            }
            else
            {
                lblOutput.Text = "Record NOT found";
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
