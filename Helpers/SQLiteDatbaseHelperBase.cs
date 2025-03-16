using Compras.Models;

namespace Compras.Helpers
{
    public class SQLiteDatbaseHelperBase
    {
        public Task<List<Produto>> GetAll()
        {
            _conn.Table<Produto>().ToListAsync();
        }
    }
}