using System.Collections.Generic;
using System.Linq;
using APIMoedas.Models;

namespace APIMoedas.Data
{
    public class CotacoesRepository
    {
        private readonly MoedasContext _context;

        public CotacoesRepository(MoedasContext context)
        {
            _context = context;
        }

        public IEnumerable<Cotacao> GetAll()
        {
            return _context.Cotacoes.ToArray();
        }
    }
}