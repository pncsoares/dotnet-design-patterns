namespace DisposePattern.WithoutPattern;

public class ServiceProxy
{
    private readonly HttpClient _httpClient;
        
    public ServiceProxy(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }
    
    public void Get()
    {
        var response = _httpClient.GetAsync(ApiUrl);
    }

    public void Post(string request)
    {
        var stringContent = new StringContent(request);
        var response = _httpClient.PostAsync(ApiUrl, stringContent);
    }

    // This is an example API
    // It may not work and is just used to exemplify the current pattern
    private static string ApiUrl => "https://jsonplaceholder.typicode.com/posts";
}