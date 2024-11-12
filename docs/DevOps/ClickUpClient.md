# Simplic.OxS.SDK.DevOps.ClickUpClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Hooks**](ClickUpClient.md#clickuphooksidpost) | **POST** /ClickUp/hooks/{id} |  |

<a id="clickuphooksidpost"></a>
# **Hooks**
> void Hooks (string id, Root? root = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class HooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClickUpClient(config);
            var id = "id_example";  // string | 
            var root = new Root?(); // Root? |  (optional) 

            try
            {
                apiInstance.Hooks(id, root);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClickUpClient.Hooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HooksWithHttpInfo(id, root);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClickUpClient.HooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **root** | [**Root?**](Root?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

