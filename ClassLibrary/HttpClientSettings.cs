namespace ClassLibrary
{
    public static class HttpClientSettings
    {
        private static string _baseAddress = "http://localhost:5050";
        public static HttpClient HttpClient = new HttpClient()
        {
            BaseAddress = new Uri(_baseAddress)
        };
    }
}
