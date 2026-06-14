using System;

namespace Laundry_Service_Management.models
{
    public class User
    {
        public decimal user_id { get; set; }

        public string name { get; set; }

        public char gender { get; set; }

        public string phone_no { get; set; }

        public string password { get; set; }

        public string role { get; set; }

        public DateTime join_date { get; set; }
    }
}
