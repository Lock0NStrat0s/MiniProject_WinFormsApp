using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PersonModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool IsActive { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

    }
}
