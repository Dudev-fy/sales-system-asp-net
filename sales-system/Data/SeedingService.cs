using sales_system.Models;
using sales_system.Models.Enums;

namespace sales_system.Data
{
    public class SeedingService
    {
        private sales_systemContext _context;

        public SeedingService(sales_systemContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Seller.Any() || _context.Department.Any() || _context.SalesRecord.Any()) {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Cristiano Ronaldo", "900@gmail.com", new DateTime(1990, 7, 11), 3500.0, d2);
            Seller s3 = new Seller(3, "Giulya Bueno", "giulya@gmail.com", new DateTime(2005, 1, 1), 2200.0, d3);
            Seller s4 = new Seller(4, "Lucas Moura", "lucao@gmail.com", new DateTime(2000, 3, 8), 3000.0, d4);
            Seller s5 = new Seller(5, "Maria Moura", "maria@gmail.com", new DateTime(1984, 7, 8), 4000.0, d2);
            Seller s6 = new Seller(6, "Jessica Silva", "jes@gmail.com", new DateTime(1999, 9, 11), 3000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 7, 5), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2024, 10, 19), 20000.0, SaleStatus.Peding, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2024, 12, 25), 5000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 5, 3), 3000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 10, 8), 50000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2024, 3, 6), 45000.0, SaleStatus.Peding, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2023, 11, 15), 32000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 1, 12), 15000.0, SaleStatus.Peding, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2024, 4, 18), 8000.0, SaleStatus.Canceled, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 8, 20), 22000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2023, 7, 30), 35000.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2023, 6, 5), 27000.0, SaleStatus.Peding, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 9, 11), 12000.0, SaleStatus.Canceled, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2023, 2, 21), 46000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 11, 9), 6000.0, SaleStatus.Peding, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2024, 5, 28), 54000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2024, 9, 1), 25000.0, SaleStatus.Peding, s6);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 10, 22), 9000.0, SaleStatus.Canceled, s5);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 6, 14), 41000.0, SaleStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2023, 4, 25), 7000.0, SaleStatus.Peding, s3);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2022, 3, 17), 13000.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2024, 7, 4), 48000.0, SaleStatus.Canceled, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 9, 10), 33000.0, SaleStatus.Peding, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2022, 8, 12), 17000.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2023, 1, 19), 21000.0, SaleStatus.Peding, s5);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2024, 6, 23), 37000.0, SaleStatus.Billed, s6);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2022, 12, 2), 29000.0, SaleStatus.Canceled, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1,s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, 
                r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27
            );

            _context.SaveChanges();
        }
    }
}
