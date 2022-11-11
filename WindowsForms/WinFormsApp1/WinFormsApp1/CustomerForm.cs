namespace WinFormsApp1
{
    public partial class CustomerForm : Form
    {
        public Customer EditCustomer { 
            get 
            {
                return new Customer { Name = nameTextBox.Text, Address = addressTextBox.Text, City = cityTextBox.Text };
            } 
        }
        public CustomerForm()
        {
            InitializeComponent();
        }
    }
}
