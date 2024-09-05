using sales_system.Models.Enums;

namespace sales_system.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Department Department { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() {}

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Department department, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Department = department;
            Seller = seller;
        }
    }
}
