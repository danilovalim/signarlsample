using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using SignalR.Learning;


namespace SignalR.Learning.Hubs
{
    public class ChatHub : Hub
    {
        public void BroadcastMessage(string message)
        {
            Clients.All.writeMessage(message);
        }
    }
}