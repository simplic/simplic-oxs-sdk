# Simplic.OxS.SDK.Document.RossumClient

All URIs are relative to *https://dev-oxs.simplic.io/document-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Hook**](RossumClient.md#apirossumhookpost) | **POST** /api/Rossum/hook |  |

<a id="apirossumhookpost"></a>
# **Hook**
> void Hook ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;

namespace Example
{
    public class HookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/document-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RossumClient(config);

            try
            {
                apiInstance.Hook();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RossumClient.Hook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HookWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RossumClient.HookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

