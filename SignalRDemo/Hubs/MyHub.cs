using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using SignalRDemo.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace SignalRDemo.Hubs
{
    public class MyHub : Hub
    {
        public void AddReferral(string firstname, string lastname, string sex, string dob)
        {
            ReferralService.Save(firstname, lastname, sex, dob);
            int referrals = ReferralService.GetCount();
            Clients.All.loadReferrals(referrals);
        }

        public void RemoveReferral()
        {
            ReferralService.Delete();
            int referrals = ReferralService.GetCount();
            Clients.All.loadReferrals(referrals);
        }

        public override Task OnConnected()
        {
            string name = Context.ConnectionId;
            Clients.All.addUserIcon(name);
            GetCount();
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool b)
        {
            string name = Context.ConnectionId;
            Clients.All.removeUserIcon(name);

            GetCount();

            return base.OnDisconnected(b);
        }

        private void GetCount()
        {
            int referrals = ReferralService.GetCount();
            Clients.All.loadReferrals(referrals);
        }
    }
}