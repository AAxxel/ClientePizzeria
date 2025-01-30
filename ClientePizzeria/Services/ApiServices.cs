using System.Text;
using System.Text.Json;
using ClientePizzeria.Models;
using Newtonsoft.Json;
using POSPizzeria.DTOs;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ClientePizzeria.Services
{
    public static class ApiServices
    {
        private static string _baseUrl = "http://localhost:5165/api/";
        private static HttpClient _client = new HttpClient();
        public static void SetAuthorizationToken(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public static async Task<T> getData<T>(string endPoint)
        {
            string url = _baseUrl + endPoint;
            try
            {

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    T data = JsonConvert.DeserializeObject<T>(jsonResponse);
                    return data;
                }
                else
                {
                    Console.WriteLine($"Error en GET: {response.StatusCode}");
                    throw new Exception($"{response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}");
                return default;
            }
        }

        public static async Task<T> postData<T>(string endPoint, T data)
        {
            string url = _baseUrl + endPoint;
            try
            {
                string jsonData = JsonSerializer.Serialize(data);
                System.Diagnostics.Debug.WriteLine(jsonData);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error en POST: {response.StatusCode}");
                    throw new Exception($"{response.ReasonPhrase}");

                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                T result = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la petición HTTP: {ex.Message}");
                MessageBox.Show($"Error al obtener: {ex.Message}");
                return default;
            }
        }

        public static async Task<Pedido> realizarPedidoService(string endPoint, CreatePedido data)
        {
            string url = _baseUrl + endPoint;
            try
            {
                string jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);


                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error en POST: {response.StatusCode}");
                    throw new Exception($"{response}");

                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                Pedido result = JsonSerializer.Deserialize<Pedido>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la petición HTTP: {ex.Message}");
                MessageBox.Show($"Error al obtener: {ex}");
                return default;
            }
        }

        public static async Task<AuthResponse> postLogin(string endPoint, Auth data)
        {
            string url = _baseUrl + endPoint;
            try
            {
                string jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error en POST: {response.StatusCode}");
                    throw new Exception($"{response.ReasonPhrase}");

                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                AuthResponse result = JsonSerializer.Deserialize<AuthResponse>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la petición HTTP: {ex.Message}");
                MessageBox.Show($"Error al guardar: {ex.Message}");
                return default;
            }
        }
        public static async Task<T> putData<T>(string endPoint, T data)
        {
            string url = _baseUrl + endPoint;
            try
            {
                string jsonData = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PutAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error en PUT: {response.StatusCode}");
                    throw new Exception($"{response.StatusCode}");
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                T result = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la petición HTTP: {ex.Message}");
                MessageBox.Show($"Error al editar. Intente de nuevo: {ex.Message}");
                return default;
            }
        }

    }
}

