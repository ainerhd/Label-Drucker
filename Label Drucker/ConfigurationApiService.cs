using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Drucker.Services
{
    /// <summary>
    /// Einfacher Service zum Abrufen von Konfigurationsdaten über eine REST-Schnittstelle.
    /// </summary>
    public class ConfigurationApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _baseUrl;

        public ConfigurationApiService(string baseUrl)
        {
            _baseUrl = baseUrl?.TrimEnd('/');
        }

        /// <summary>
        /// Ruft Konfigurationsdaten für einen Auftrag und eine ConfigurationId ab.
        /// </summary>
        public string GetConfigurationData(string orderNumber, string configurationId)
        {
            if (string.IsNullOrEmpty(_baseUrl))
                throw new InvalidOperationException("API base URL is not configured.");

            var url = $"{_baseUrl}/config/{configurationId}?order={orderNumber}";
            try
            {
                var response = _httpClient.GetAsync(url).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Abrufen der Konfiguration: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
