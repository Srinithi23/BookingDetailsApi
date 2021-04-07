using BookingDetailsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDetailsApi.Repository
{
    public interface IBooking
    {
        IEnumerable<BookingDetail> GetBookingDetail();
        BookingDetail GetBookingById(int bid);
        Task<BookingDetail> AddBookingDetail(BookingDetail book);
        Task<BookingDetail> CancelBookingDetail(int id);

    }
}
