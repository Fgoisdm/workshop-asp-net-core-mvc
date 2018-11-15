using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Models;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {

        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //Apenas para teste, vai ser removido depois
            obj.Department = _context.Department.First();
            //-------------------------------------------
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
