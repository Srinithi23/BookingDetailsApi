using System;
using System.Collections.Generic;

#nullable disable

namespace BookingDetailsApi.Models
{
    public partial class PassengerDetail
    {
        public int SerialNo { get; set; }
        public int? TrainNo { get; set; }
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string EmailId { get; set; }

        public virtual Register Email { get; set; }
        public virtual TrainDetail TrainNoNavigation { get; set; }
    }
}
