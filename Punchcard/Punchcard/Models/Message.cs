using System;
namespace Punchcard
{
    public class Message
    {
        public string text { get; set; } 
        public string user { get; set; }

        public Message(string mess, string usr)
        {
            text = mess;
            user = usr;
        }

        public Message()
        {

        }
    }
}
