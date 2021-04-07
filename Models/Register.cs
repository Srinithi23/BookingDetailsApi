using System;
using System.Collections.Generic;

#nullable disable

namespace BookingDetailsApi.Models
{
    public partial class Register
    {
        public Register()
        {
            BookingDetails = new HashSet<BookingDetail>();
            PassengerDetails = new HashSet<PassengerDetail>();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<PassengerDetail> PassengerDetails { get; set; }
    }
}
