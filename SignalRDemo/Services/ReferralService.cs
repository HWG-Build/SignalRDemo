
using System;
using System.Collections.Generic;


namespace SignalRDemo.Services
{
    public class ReferralService
    {
        List<Referral> referrals = new List<Referral>();

        public List<Referral> Load()
        {
            var referrals = new List<Referral>();

            return referrals;
        }

        public void Save(Referral referral)
        {
            if(referral != null)
            {
                referrals.Add(referral);
            }
        }

        public string Delete(Guid id)
        {
            if (id != null)
            {
                foreach(var item in referrals)
                {
                    if(item.Id == id)
                    {
                        referrals.Remove(item);
                        break;
                    }
                }
                return "Referral does not exist.";
            }
            else
            {
                return "Referral does not exist.";
            }

        }
    }

    public class Referral
    {
        public Guid Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
    }
}

