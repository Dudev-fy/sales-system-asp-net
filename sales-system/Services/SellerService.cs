using Microsoft.EntityFrameworkCore;
using sales_system.Data;
using sales_system.Models;
using System.Runtime.Remoting;

namespace sales_system.Services
{
    public class SellerService
    {
        private readonly sales_systemContext _context;

        public SellerService(sales_systemContext context)
        {
            _context = context;
        }
        
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges(); 
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
    }
}
