using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraryForWinFormMiniProject
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isYours { get; set; }
        public List<AddressModel> Address { get; set; } 
    }
}
