using Microsoft.AspNetCore.Mvc;
using POSProfessional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSProfessional.Controllers
{
    public class authController : Controller
    {
        private readonly POSProfessionalDBContext _context;
        public IActionResult Login()
        {
            return View();
        }
    }
}
