using MovieTicket.API.Models;
using MovieTicket.API.DTOs;

namespace MovieTicket.API.Services;

public interface IBookingService
{
    Booking Create(CreateBookingDto dto);
    List<Booking> GetAll(string userName);
    void Cancel(int id);
    
}
