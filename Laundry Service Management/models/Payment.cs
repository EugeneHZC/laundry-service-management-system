using System;

namespace Laundry_Service_Management.models
{
    public class Payment
    {
        public decimal payment_id { get; set; }
        public string status { get; set; }
        public decimal amount { get; set; }
        public DateTime payment_date { get; set; }
        public string payment_method { get; set; }
        public string card_number { get; set; }
    }
}