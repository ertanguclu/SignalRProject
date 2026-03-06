using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DtoLayer.MessageDto
{
    public class GetMessageDto
    {
        public int MessageID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageSendDate { get; set; }
        public bool Status { get; set; }
    }
}
