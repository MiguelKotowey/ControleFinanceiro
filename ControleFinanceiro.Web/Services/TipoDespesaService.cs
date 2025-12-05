using ControleFinanceiro.Core.DTOs;
using ControleFinanceiro.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace ControleFinanceiro.Services
{
    public class TipoDespesaService : ITipoDespesaService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "api/tiposdespesa";

        public TipoDespesaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TipoDespesaDTO>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TipoDespesaDTO>>(_baseUrl)
                ?? Enumerable.Empty<TipoDespesaDTO>();
        }

        public async Task<TipoDespesaDTO?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TipoDespesaDTO>($"{_baseUrl}/{id}");
        }

        public async Task<TipoDespesaDTO> CreateAsync(CreateTipoDespesaDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseUrl, dto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<TipoDespesaDTO>()
                ?? throw new Exception("Erro ao criar tipo de despesa");
        }

        public async Task UpdateAsync(int id, UpdateTipoDespesaDTO dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/{id}", dto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<IEnumerable<TipoDespesaDTO>> GetAtivosAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<TipoDespesaDTO>>($"{_baseUrl}/ativos")
                ?? Enumerable.Empty<TipoDespesaDTO>();
        }
    }
}
