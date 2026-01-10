using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRWebUI.Dtos.AboutDtos
{
    public class GetAboutDto
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
