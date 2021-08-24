using Dev.Business.Interfaces.Repositories;
using Dev.Business.Models;
using Dev.Data.Context;

namespace Dev.Data.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(MeuDbContext context) : base(context) { }
    }
}
