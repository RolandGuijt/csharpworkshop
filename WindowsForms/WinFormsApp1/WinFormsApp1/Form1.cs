namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            form.ShowDialog();
            var customer = form.EditCustomer;
            FillCustomerLabels(customer);
        }

        private void FillCustomerLabels(Customer customer)
        {
            nameLabel.Text = customer.Name;
            addressLabel.Text = customer.Address;
            cityLabel.Text = customer.City;
        }

    }
}