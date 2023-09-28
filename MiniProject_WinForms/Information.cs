using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_WinForms
{
    public partial class Information : Form
    {
        BindingList<PersonModel> info = new BindingList<PersonModel>();
        public Information()
        {
            InitializeComponent();
        }

        private void _btnGetAddress_Click(object sender, EventArgs e)
        {

        }
    }

    public class PersonModel
    {
        public string Name { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();

    }
}
