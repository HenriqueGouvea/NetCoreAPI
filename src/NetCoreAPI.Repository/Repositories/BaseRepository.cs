namespace NetCoreAPI.Repository.Repositories
{
    public class BaseRepository
    {
        protected readonly NetCoreAPIContext _context;

        public BaseRepository(NetCoreAPIContext context)
        {
            _context = context;
        }

        protected async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}