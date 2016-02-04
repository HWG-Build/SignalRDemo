using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Hubs
{
    public class MyHub : Hub
    {
        public void Hello()
        {
        }

        public override Task OnConnected()
        {
            string name = Context.ConnectionId;
            Clients.All.addUserIcon(name);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool b)
        {
            string name = Context.ConnectionId;
            Clients.All.removeUserIcon(name);
            return base.OnDisconnected(b);
        }
    }
}