using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OllamaSharp;

namespace DocuMindAI.Services
{
    public class OllamaService
    {
        private readonly OllamaApiClient _client;
        private readonly OllamaApiClient _embeddingClient;

        public OllamaService()
        {
            _client = new OllamaApiClient(new Uri("http://localhost:11434"), "mistral");
            _embeddingClient = new OllamaApiClient(new Uri("http://localhost:11434"), "nomic-embed-text");
        }

        // Chat / generation
        public async Task<string> GenerateAsync(string prompt)
        {
            var response = new StringBuilder();
            await foreach (var chunk in _client.GenerateAsync(prompt))
            {
                response.Append(chunk?.Response ?? string.Empty);
            }
            return response.ToString();
        }

        // Embeddings
        public async Task<float[]> GetEmbeddingAsync(string text)
        {
            var result = await _embeddingClient.EmbedAsync(text);

            return result.Embeddings?.FirstOrDefault()?.ToArray() ?? Array.Empty<float>();
        }
    }
}