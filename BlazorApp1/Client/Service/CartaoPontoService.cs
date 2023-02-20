using Azure.Core;
using BlazorApp1.Client.Service.Interfaces;
using BlazorApp1.Server;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorApp1.Client.Service
{
    public class CartaoPontoService : ICartaoPontoService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _options;
        public CartaoPontoService(HttpClient httpClient)
        {
            _http = httpClient;
        }
        public async Task<CartaoPonto> Create(CartaoPonto cartaoPonto)
        {
            var response = await _http.PostAsJsonAsync("api/CartaoPonto", cartaoPonto);

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<CartaoPonto>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            }) ?? throw new Exception("Json está nulo");
      
        }

        public async Task<List<CartaoPonto>> GetAllCartaoPonto()
        {
            var response = await _http.GetAsync("api/CartaoPonto");

            //JsonSerializer.<List<CartaoPonto>>(response.Content.ReadAsStringAsync().Result);
            var json = response.Content.ReadAsStringAsync().Result;
            return  JsonSerializer.Deserialize<List<CartaoPonto>>(json,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNameCaseInsensitive = true
                }) ?? throw new Exception("Json está nulo"); 

            
        }
        public async Task<CartaoPonto> GetByIdCartaoPonto(int id)
        {
            var response = await _http.GetAsync($"api/CartaoPonto/{id}");

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<CartaoPonto>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            }) ?? throw new Exception("Json está nulo");
        }


        public async Task<bool> Delete(int id)
        {
            var response = await _http.DeleteAsync($"api/CartaoPonto/{id}");

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<bool>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> Edit(CartaoPonto obj)
        {
            var response = await _http.PutAsJsonAsync("api/CartaoPonto", obj);

            var json = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<bool>(json, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            });
        }


        public async Task Desserializador(Type type, string? json)
        {
            var a = JsonSerializer.Deserialize<Type>(json, _options);


        }
    }
}
