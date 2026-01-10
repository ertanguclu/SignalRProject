using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRWebUI.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
