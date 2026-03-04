using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DtoLayer.MenuTableDto
{
    public class UpdateMenuTableDto
    {
        public int MenuTableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
