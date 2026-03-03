    using MovieTicket.API.Data;
    using MovieTicket.API.Models;
    using MovieTicket.API.DTOs;
    using Microsoft.EntityFrameworkCore;

    namespace MovieTicket.API.Services;

    public class BookingService : IBookingService
    {
        private readonly AppDbContext _db;

        public BookingService(AppDbContext db)
        {
            _db = db;
        }

        public Booking Create(CreateBookingDto dto)

            {var booking = new Booking
            {
                MovieId = dto.MovieId,
                CustomerName = dto.CustomerName,
                Tickets = dto.Tickets,
                Status = "Booked",
                
                
            };

            _db.Bookings.Add(booking);
            _db.SaveChanges();

            return booking;
        }

        public List<Booking> GetAll(string userName)
        {   
            if(string.IsNullOrWhiteSpace(userName)){
                return new List<Booking>();
            }
            return _db.Bookings.Where(b=>b.CustomerName==userName).ToList();
        }

        public void Cancel(int id)
        {
            var booking = _db.Bookings.Find(id);
            if (booking != null)
            {
                booking.Status = "Cancelled";
                _db.SaveChanges();
            }
        }
        
    }