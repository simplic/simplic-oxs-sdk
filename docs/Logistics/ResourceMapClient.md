# Simplic.OxS.SDK.Logistics.ResourceMapClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByLocation**](ResourceMapClient.md#resourcemapgetbylocationget) | **GET** /ResourceMap/get-by-location | Retrieves resources from a specific group and location. |

<a id="resourcemapgetbylocationget"></a>
# **GetByLocation**
> List&lt;ResourceMapResponse&gt; GetByLocation (double? longitude = null, double? latitude = null, double? maxDistanceMeter = null, double? minDistanceMeter = null, string? group = null)

Retrieves resources from a specific group and location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetByLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceMapClient(config);
            var longitude = 1.2D;  // double? |  (optional) 
            var latitude = 1.2D;  // double? |  (optional) 
            var maxDistanceMeter = 1.2D;  // double? |  (optional) 
            var minDistanceMeter = 1.2D;  // double? |  (optional) 
            var group = "group_example";  // string? |  (optional) 

            try
            {
                // Retrieves resources from a specific group and location.
                List<ResourceMapResponse> result = apiInstance.GetByLocation(longitude, latitude, maxDistanceMeter, minDistanceMeter, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceMapClient.GetByLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources from a specific group and location.
    ApiResponse<List<ResourceMapResponse>> response = apiInstance.GetByLocationWithHttpInfo(longitude, latitude, maxDistanceMeter, minDistanceMeter, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceMapClient.GetByLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **longitude** | **double?** |  | [optional]  |
| **latitude** | **double?** |  | [optional]  |
| **maxDistanceMeter** | **double?** |  | [optional]  |
| **minDistanceMeter** | **double?** |  | [optional]  |
| **group** | **string?** |  | [optional]  |

### Return type

[**List&lt;ResourceMapResponse&gt;**](ResourceMapResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

