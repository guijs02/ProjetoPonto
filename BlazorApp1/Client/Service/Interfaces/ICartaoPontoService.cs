using BlazorApp1.Server;

namespace BlazorApp1.Client.Service.Interfaces
{
    public interface ICartaoPontoService
    {
        Task<CartaoPonto> Create(CartaoPonto cartao);
        Task<List<CartaoPonto>> GetAllCartaoPonto();
        Task<bool> Delete(int id);
        Task<bool> Edit(CartaoPonto obj);
        Task<CartaoPonto> GetByIdCartaoPonto(int id);
    }
}
