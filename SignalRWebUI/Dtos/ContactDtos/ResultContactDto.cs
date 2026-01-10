using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DtoLayer.ContactDto
{
    public class ResultContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
