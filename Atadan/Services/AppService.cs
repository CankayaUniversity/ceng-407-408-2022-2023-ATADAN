using Atadan.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow;

namespace Atadan.Services {
    public class AppService {
        public AppService() { }
        private static AppService instance = null;
        public static AppService Instance {
            get {
                if (instance == null) {
                    instance = new AppService();
                }
                return instance;
            }
        }

        public SearchResponse searchResponse { get; set; }
        public AiResultModel aiResultModel { get; set; }
        public byte[] mainImage { get; set; }


        private readonly string apiKey = "";
        private readonly string cx = "";

        public async Task<SearchResponse> SearchOnline(string search) {
            string text = search + "tedavisi";
            string apiUrl = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cx}&q={Uri.EscapeDataString(text)}";
            using (HttpClient client = new HttpClient()) {
                try {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    // Process the JSON response and display the search results within your app
                    SearchResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(json);
                    // Access the search results from the 'searchResponse' object and display them in your UI
                    return searchResponse;
                }
                catch (Exception ex) {
                    // Handle any exceptions or display an error message
                    return null;
                }
            }
        }
        public async Task<SearchResponse> SearchOnlineChem(string search) {
            string text = search + "ilaç tedavisi";
            string apiUrl = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cx}&q={Uri.EscapeDataString(text)}";
            using (HttpClient client = new HttpClient()) {
                try {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    // Process the JSON response and display the search results within your app
                    SearchResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(json);
                    // Access the search results from the 'searchResponse' object and display them in your UI
                    return searchResponse;
                }
                catch (Exception ex) {
                    // Handle any exceptions or display an error message
                    return null;
                }
            }
        }


        public async void OpenApiUrlButton(string link) { // Replace with your actual API URL
            using (HttpClient client = new HttpClient()) {
                try {
                    System.Uri uri = new Uri(link);
                    await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

                    // Handle the API response as needed
                }
                catch (Exception ex) {
                    // Handle any exceptions or display an error message
                }
            }
        }

    }
}
