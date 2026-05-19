using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraryForWinFormMiniProject
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; } // safe to store as string to preserve leading zeros
    }
}
