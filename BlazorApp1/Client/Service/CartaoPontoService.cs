using Azure.Core;
using BlazorApp1.Client.Service.Interfaces;
using BlazorApp1.Server;
using Syncfusion.Blazor.Kanban.Internal;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorApp1.Client.Service
{
    public class CartaoPontoService : ICartaoPontoService
    {
        private readonly HttpClient _http;
        private const string API = "api/CartaoPonto";
        public CartaoPontoService(HttpClient httpClient)
        {
            _http = httpClient;
        }
        public async Task<CartaoPonto?> Create(CartaoPonto cartaoPonto)
        {
            var response = await _http.PostAsJsonAsync(API, cartaoPonto);

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<CartaoPonto>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });

        }

        public async Task<List<CartaoPonto?>> GetAllCartaoPonto()
        {
            var response = await _http.GetAsync(API);

            var json = response.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<List<CartaoPonto>>(json,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                });


        }
        public async Task<CartaoPonto?> GetByIdCartaoPonto(int id)
        {
            var response = await _http.GetAsync(API + $"/{id}");

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<CartaoPonto>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });
        }


        public async Task<bool> Delete(int id)
        {
            var response = await _http.DeleteAsync(API + $"/{id}");

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<bool>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> Edit(CartaoPonto obj)
        {
            var response = await _http.PutAsJsonAsync(API, obj);

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<bool>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
