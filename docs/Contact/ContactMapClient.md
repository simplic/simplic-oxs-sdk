# Simplic.OxS.SDK.Contact.ContactMapClient

All URIs are relative to *https://dev-oxs.simplic.io/contact-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByLocation**](ContactMapClient.md#contactmapgetbylocationget) | **GET** /ContactMap/get-by-location |  |

<a id="contactmapgetbylocationget"></a>
# **GetByLocation**
> List&lt;ContactMapResponse&gt; GetByLocation (double? longitude = null, double? latitude = null, double? maxDistanceMeter = null, double? minDistanceMeter = null, string? group = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contact;

namespace Example
{
    public class GetByLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contact-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactMapClient(config);
            var longitude = 1.2D;  // double? |  (optional) 
            var latitude = 1.2D;  // double? |  (optional) 
            var maxDistanceMeter = 1.2D;  // double? |  (optional) 
            var minDistanceMeter = 1.2D;  // double? |  (optional) 
            var group = "group_example";  // string? |  (optional) 

            try
            {
                List<ContactMapResponse> result = apiInstance.GetByLocation(longitude, latitude, maxDistanceMeter, minDistanceMeter, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactMapClient.GetByLocation: " + e.Message);
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
    ApiResponse<List<ContactMapResponse>> response = apiInstance.GetByLocationWithHttpInfo(longitude, latitude, maxDistanceMeter, minDistanceMeter, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactMapClient.GetByLocationWithHttpInfo: " + e.Message);
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

[**List&lt;ContactMapResponse&gt;**](ContactMapResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

