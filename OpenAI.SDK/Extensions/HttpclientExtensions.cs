﻿using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenAI.GPT3.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetFromJsonAsync<T>(this HttpClient client, string uri)
        {
            var response = await client.GetAsync(uri);
            return await response.Content.ReadFromJsonAsync<T>() ?? throw new InvalidOperationException();
        }

        public static async Task<TResponse> PostAndReadAsAsync<TResponse>(this HttpClient client, string uri, object requestModel)
        {
            var response = await client.PostAsJsonAsync(uri, requestModel, new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            });
            return await response.Content.ReadFromJsonAsync<TResponse>() ?? throw new InvalidOperationException();
        }

        public static async Task<TResponse> PostFileAndReadAsAsync<TResponse>(this HttpClient client, string uri, HttpContent content)
        {
            var response = await client.PostAsync(uri, content);
            return await response.Content.ReadFromJsonAsync<TResponse>() ?? throw new InvalidOperationException();
        }

        public static async Task<TResponse> DeleteAndReadAsAsync<TResponse>(this HttpClient client, string uri)
        {
            var response = await client.DeleteAsync(uri);
            return await response.Content.ReadFromJsonAsync<TResponse>() ?? throw new InvalidOperationException();
        }
    }
}