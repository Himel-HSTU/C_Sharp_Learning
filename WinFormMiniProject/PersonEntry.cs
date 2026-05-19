using DemoLibraryForWinFormMiniProject;
using System.ComponentModel;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form
    {
        private void firstNameLabel_Click(object sender, EventArgs e)
        {
            // leave empty or add logic
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            // leave empty or add logic
        }

        BindingList<AddressModel> address = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();
            address.Add(new AddressModel { StreetAddress = "123 Main St", City = "Anytown", State = "CA", ZipCode = "12345" });

            addressList.DataSource = address;
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
