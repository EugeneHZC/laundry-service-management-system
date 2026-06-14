using System;

namespace Laundry_Service_Management.models
{
    public class Booking
    {
        public decimal booking_id { get; set; }

        public DateTime booking_date { get; set; }

        public DateTime service_time { get; set; }

        public string delivery_to_shop_method { get; set; }

        public decimal total_amount { get; set; }

        public string service_type { get; set; }

        public string status { get; set; }

        public string delivery_from_shop_method { get; set; }

        public string delivery_address { get; set; }

        public string remarks { get; set; }

        public decimal user_id { get; set; }

        public decimal? payment_id { get; set; }
    }
}
