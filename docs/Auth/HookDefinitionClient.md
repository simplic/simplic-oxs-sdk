# Simplic.OxS.SDK.Auth.HookDefinitionClient

All URIs are relative to *https://dev-oxs.simplic.io/auth-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HookDefinitionGet**](HookDefinitionClient.md#hookdefinitionget) | **GET** /HookDefinition |  |

<a id="hookdefinitionget"></a>
# **HookDefinitionGet**
> HookDefinitionResponse HookDefinitionGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class HookDefinitionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HookDefinitionClient(config);

            try
            {
                HookDefinitionResponse result = apiInstance.HookDefinitionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HookDefinitionClient.HookDefinitionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HookDefinitionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HookDefinitionResponse> response = apiInstance.HookDefinitionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HookDefinitionClient.HookDefinitionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HookDefinitionResponse**](HookDefinitionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

