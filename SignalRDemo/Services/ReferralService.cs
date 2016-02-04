
using System;
using System.Collections.Generic;


namespace SignalRDemo.Services
{
    public class ReferralService
    {
        
        public static List<Referral> referrals = new List<Referral>();

        public static int Load()
        {
            return referrals.Count;
        }

        public static void Save(string first, string last, string sex, string birthday)
        {
            Referral referral = new Referral()
            {
                Id = referrals.Count+1,
                firstname = first,
                lastname = last,
                gender = sex,
                dob = birthday
            };
            
            if (referral != null)
            {
                referrals.Add(referral);
            }
        }

        public static void Delete()
        {
            referrals.Remove(referrals[referrals.Count-1]);
        }

        public static int GetCount()
        {
            return referrals.Count;
        }
    }


    public class Referral
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
    }
}

