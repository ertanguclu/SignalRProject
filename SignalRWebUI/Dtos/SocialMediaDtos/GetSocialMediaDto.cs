using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRWebUI.Dtos.SocialMediaDtos
{
    public class GetSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
