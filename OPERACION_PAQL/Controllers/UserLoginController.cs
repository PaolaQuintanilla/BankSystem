using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPERACION_PAQL.Models;

namespace OPERACION_PAQL.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly BdClientesPaqlContext _context;

        public UserLoginController(BdClientesPaqlContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            //string mainconn = ConfigurationManager.ConnectionString[]
            if(user.Username == null)
            {
                return View();
            }

            var resultU = await _context.Users.FirstOrDefaultAsync(u => u.Username.Equals(user.Username));
            var resultP = await _context.Users.FirstOrDefaultAsync(u => u.Password.Equals(user.Password));

            if(resultU == null || resultP == null)
            {
                return View();
            }

            return RedirectToAction("index", "customers", null);
        }

    }
}
