using System;
using System.Collections.Generic;

#nullable disable

namespace BookingDetailsApi.Models
{
    public partial class BookingDetail
    {
        public int BookingId { get; set; }
        public string EmailId { get; set; }
        public int? TrainNo { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public DateTime? JourneyDate { get; set; }
        public int? NoOfSeats { get; set; }
        public string BookingStatus { get; set; }

        public virtual Register Email { get; set; }
        public virtual TrainDetail TrainNoNavigation { get; set; }
    }
}
