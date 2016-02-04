using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using SignalRDemo.Services;
using System.Collections.Generic;

namespace SignalRDemo.Hubs
{
    public class MyHub : Hub
    {
        public void AddReferral(string firstname, string lastname, string sex, string dob)
        {
            ReferralService.Save(firstname, lastname, sex, dob);
        }

        public void RemoveReferral()
        {
            ReferralService.Delete();
        }

        public override Task OnConnected()
        {
            string name = Context.ConnectionId;
            Clients.All.addUserIcon(name);

            int referrals = ReferralService.GetCount();
            Clients.All.loadReferrals(referrals);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool b)
        {
            string name = Context.ConnectionId;
            Clients.All.removeUserIcon(name);

            int referrals = ReferralService.GetCount();
            Clients.All.loadReferrals(referrals);

            return base.OnDisconnected(b);
        }
    }
}