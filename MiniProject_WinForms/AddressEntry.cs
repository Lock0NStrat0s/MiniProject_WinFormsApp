using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDemoLibrary;

namespace MiniProject_WinForms
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = _txtbStreetAddress.Text,
                City = _txtbCity.Text,
                Province = _txtbProvince.Text,
                PostalCode = _txtbPostalCode.Text
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
