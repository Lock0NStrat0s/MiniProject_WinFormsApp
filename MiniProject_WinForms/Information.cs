using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDemoLibrary;

namespace MiniProject_WinForms
{
    public partial class Information : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public Information()
        {
            InitializeComponent();
            _lstbInformation.DataSource = addresses;
            _lstbInformation.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            AddressModel newAddress = new AddressModel();

            AddressEntry entry = new AddressEntry(this);
            entry.Show();
        }

        private void _btnSaveRecord_Click(object sender, EventArgs e)
        {
            PersonModel pesron = new PersonModel
            {
                FirstName = _txtbFirstName.Text,
                LastName = _txtbLastName.Text,
                IsActive = _chkbIsActive.Checked,
                Addresses = addresses.ToList()
            };
        }

    }

}
