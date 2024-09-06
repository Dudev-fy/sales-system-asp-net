using sales_system.Data;
using sales_system.Models;

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
    }
}
