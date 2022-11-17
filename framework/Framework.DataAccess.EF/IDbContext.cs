namespace Framework.DataAccess.EF
{
    public interface IDbContext
    {
        EFContext Instance { get; }
    }
}
