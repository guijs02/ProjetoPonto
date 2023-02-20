using BlazorApp1.Server.Context;
using BlazorApp1.Server.Repository.Interface;

namespace BlazorApp1.Server.Repository
{
    public class CartaoPontoRepository : ICartaoPontoRepository
    {
        private readonly ApplicationDbContext _db;
        public CartaoPontoRepository(ApplicationDbContext context)
        {
            _db = context;
        }
        public CartaoPonto Create(CartaoPonto cartaoPonto)
        {
            try
            {
                if (cartaoPonto is not null)
                    _db.CartaoPonto.Add(cartaoPonto);
                _db.SaveChanges();
                return cartaoPonto;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
