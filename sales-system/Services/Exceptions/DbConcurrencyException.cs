namespace sales_system.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) { }
    }
}
