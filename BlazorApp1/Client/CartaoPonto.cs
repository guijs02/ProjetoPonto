using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Server
{
    public class CartaoPonto
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Entrada 1")]
        public DateTime? Entrada1 { get; set; }
        [DisplayName("Saida 1")]
        public DateTime? Saida1 { get; set; }
        [DisplayName("Entrada 2")]
        public DateTime? Entrada2 { get; set; }
        [DisplayName("Saida 2")]
        public DateTime? Saida2 { get; set; }


    }
    public static class CartaoPontoApi
    {
        public const string GetAllCartaoPonto = "api/cartaoPonto";
    }
}
