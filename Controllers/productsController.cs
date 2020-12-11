using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POSProfessional.Models;

namespace POSProfessional.Controllers
{
    public class productsController : Controller
    {
        private readonly POSProfessionalDBContext _context;
        public productsController(POSProfessionalDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
