using System.ComponentModel;

namespace DisposePattern.WithPattern;

// A base class that implements IDisposable.
// By implementing IDisposable, you are announcing that
// instances of this type allocate scarce resources.
public class ServiceProxy : IDisposable
{
    private readonly HttpClient _httpClient;
    
    // Pointer to an external unmanaged resource.
    private IntPtr _handle;
    
    // Other managed resource this class uses.
    private Component _component = new Component();
    
    /// <summary>
    /// Track whether Dispose has been called.
    /// </summary>
    private bool _disposed;
    
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

    // Implement IDisposable.
    // Do not make this method virtual.
    // A derived class should not be able to override this method.
    public void Dispose()
    {
        Dispose(true);
        
        // This object will be cleaned up by the Dispose method.
        // Therefore, you should call GC.SuppressFinalize to
        // take this object off the finalization queue
        // and prevent finalization code for this object
        // from executing a second time.
        GC.SuppressFinalize(this);
    }

    // Dispose(bool disposing) executes in two distinct scenarios.
    // If disposing equals true, the method has been called directly
    // or indirectly by a user's code. Managed and unmanaged resources
    // can be disposed.
    // If disposing equals false, the method has been called by the
    // runtime from inside the finalizer and you should not reference
    // other objects. Only unmanaged resources can be disposed.
    protected virtual void Dispose(bool disposing)
    {
        // Check to see if Dispose has already been called.
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            // Dispose managed objects
            _httpClient.Dispose();
        }
        
        // Disposed unmanaged objects
        CloseHandle(_handle);
        _handle = IntPtr.Zero;

        _disposed = true;
    }
    
    // This is an example API
    // It may not work and is just used to exemplify the current pattern
    private static string ApiUrl => "https://jsonplaceholder.typicode.com/posts";
    
    // Use interop to call the method necessary
    // to clean up the unmanaged resource.
    [System.Runtime.InteropServices.DllImport("Kernel32")]
    private static extern bool CloseHandle(IntPtr handle);
    
    // Use C# finalizer syntax for finalization code.
    // This finalizer will run only if the Dispose method
    // does not get called.
    // It gives your base class the opportunity to finalize.
    // Do not provide finalizer in types derived from this class.
    ~ServiceProxy()
    {
        // Do not re-create Dispose clean-up code here.
        // Calling Dispose(disposing: false) is optimal in terms of
        // readability and maintainability.
        Dispose(false);
    }
}