using BookingDetailsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingDetailsApi.Repository
{
    public class Booking : IBooking
    {
        private readonly TICKET_BOOKINGContext _context;
       
        public Booking()
        {

        }
        public Booking(TICKET_BOOKINGContext context)
        {
            _context = context;
        }

      
        public IEnumerable<BookingDetail> GetBookingDetail()
        {
            return _context.BookingDetails.ToList();
        }
        public BookingDetail GetBookingById(int bid)
        {
            BookingDetail item = _context.BookingDetails.Find(bid);

            return item;
        }
        //public BookingDetail PutBookingDetail(int id)
        //{
        //    BookingDetail item = _context.BookingDetails.Find(id);

        //    return item;
        //}

        public async Task<BookingDetail> AddBookingDetail(BookingDetail item)
        {
            BookingDetail book = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                book = new BookingDetail()
                {
                    BookingId = item.BookingId,
                    EmailId = item.EmailId,
                    TrainNo = item.TrainNo,
                    FromStation = item.FromStation,
                    ToStation = item.ToStation,
                    JourneyDate = item.JourneyDate,
                    NoOfSeats = item.NoOfSeats,
                    BookingStatus = item.BookingStatus
                };
                await _context.BookingDetails.AddAsync(book);
                await _context.SaveChangesAsync();
            }
            return book;
        }

        public async Task<BookingDetail> CancelBookingDetail(int id)
        {
            BookingDetail book = await _context.BookingDetails.FindAsync(id);
            if (book == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                _context.BookingDetails.Remove(book);
                await _context.SaveChangesAsync();
            }
            return book;
        }

        //public Task<BookingDetail> AddBookingDetail(int id)
        //{
        //    throw new NotImplementedException();
        //}



        //public Task<BookingDetail> PutBookingDetail(BookingDetail id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<BookingDetail> DeleteBookingDetail(BookingDetail id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
