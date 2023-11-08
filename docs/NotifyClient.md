# Simplic.OxS.SDK.DevOps.NotifyClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiNotifySendPost**](NotifyClient.md#apinotifysendpost) | **POST** /api/Notify/send |  |

<a id="apinotifysendpost"></a>
# **ApiNotifySendPost**
> void ApiNotifySendPost (Guid? guid = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiNotifySendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotifyClient(config);
            var guid = "guid_example";  // Guid? |  (optional) 

            try
            {
                apiInstance.ApiNotifySendPost(guid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotifyClient.ApiNotifySendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiNotifySendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiNotifySendPostWithHttpInfo(guid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotifyClient.ApiNotifySendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **guid** | **Guid?** |  | [optional]  |

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

