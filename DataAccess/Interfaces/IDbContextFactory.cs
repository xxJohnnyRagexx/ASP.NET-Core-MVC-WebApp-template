namespace DataAccess.Interfaces
{
    public interface IDbContextFactory
    {
        ApplicationDbContext GetDbContext();
    }
}