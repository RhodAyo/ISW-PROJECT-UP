using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using UP.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using UP.Migrations;

namespace UP.Controllers
{
    public class AdminController : Controller
    {
        private readonly SignInManager<UPUser> _signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<UPUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AdminController(Microsoft.AspNetCore.Identity.UserManager<UPUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: AdminController
        [Authorize(Roles = "Admin, JobProvider")]
        public async Task<ActionResult> Index()
        {
            var staffcount = await _userManager.Users.CountAsync();
            TempData["staffcount"] = staffcount - 1;

            var categorycount = await _context.Roles.CountAsync();
            TempData["categorycount"] = categorycount;


            //var allproduct = await _context.AllProducts.CountAsync();
            //TempData["allproduct"] = allproduct;
            return View();
        }

        
    }
}
