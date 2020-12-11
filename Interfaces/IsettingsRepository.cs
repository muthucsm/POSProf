using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POSProfessional.Models;

namespace POSProfessional.Interfaces
{
    public interface IsettingsRepository
    {
        Task<List<Categories>> GetCategories();
    }
}
