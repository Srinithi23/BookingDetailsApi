using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingDetailsApi.Models;
using BookingDetailsApi.Repository;

namespace BookingDetailsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailsController : ControllerBase
    {
        private readonly IBooking _context;
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BookingDetailsController));
       /* public BookingDetailsController()
        {

        }*/
        public BookingDetailsController(IBooking context)
        {
            _context = context;
        }

        // GET: api/BookingDetails
        [HttpGet]
        //[Route("api/[controller]")]
        public IEnumerable<BookingDetail> GetBookingDetails()
        {
            log.Info("All Items Displayed!");
            return _context.GetBookingDetail();
        }

        [HttpGet("{bid}")]
        public IActionResult GetBookingById(int bid)
        {
            log.Info("Get by id is called!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var booking = _context.GetBookingById(bid);
            log.Info("Data of the id returned!");

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookingDetail(BookingDetail book)
        {
            log.Info("Booking method is called!");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var temp = await _context.AddBookingDetail(book);

            return Ok(temp);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> CancelBookingDetail(int id)
        {
            var book = await _context.CancelBookingDetail(id);
            if (book == null)
            {
                throw new NullReferenceException();
            }
           
            return Ok(book);
        }
    }
}
