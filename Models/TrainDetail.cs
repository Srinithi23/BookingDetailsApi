using System;
using System.Collections.Generic;

#nullable disable

namespace BookingDetailsApi.Models
{
    public partial class TrainDetail
    {
        public TrainDetail()
        {
            BookingDetails = new HashSet<BookingDetail>();
            PassengerDetails = new HashSet<PassengerDetail>();
        }

        public int TrainNo { get; set; }
        public string TrainName { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public DateTime? JourneyDate { get; set; }
        public int? SeatAvailA { get; set; }
        public int? SeatAvailB { get; set; }
        public int? SeatAvailC { get; set; }
        public int? FareA { get; set; }
        public int? FareB { get; set; }
        public int? FareC { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<PassengerDetail> PassengerDetails { get; set; }
    }
}
