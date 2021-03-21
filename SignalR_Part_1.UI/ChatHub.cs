using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Part_1.UI
{
    public class ChatHub : Hub
    {
        public void Send(string userName, string message)
        {
            Clients.All.sendMessage(userName, message);
        }
        public void Hello()
        {
            Clients.All.hello();
        }

    }
}