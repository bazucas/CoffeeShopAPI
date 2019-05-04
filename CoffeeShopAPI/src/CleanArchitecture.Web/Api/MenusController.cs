using System.Linq;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public MenusController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _appDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _appDbContext.Menus.Include("SubMenus").FirstOrDefault(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
    }
}