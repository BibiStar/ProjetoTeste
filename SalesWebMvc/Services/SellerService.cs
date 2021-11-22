using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
           var temp = _context.Seller.ToList();
           //var nome=temp[0].Department.Name;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
