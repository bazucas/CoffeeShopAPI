using CleanArchitecture.Core.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ReservationsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _appDbContext.Reservations.Add(reservation);
            _appDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}