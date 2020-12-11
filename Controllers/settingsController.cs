using Microsoft.AspNetCore.Mvc;
using POSProfessional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSProfessional.Controllers
{
    public class settingsController : Controller
    {
        private readonly POSProfessionalDBContext _context;
        public settingsController(POSProfessionalDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
