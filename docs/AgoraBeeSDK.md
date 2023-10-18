# Simplic.OxS.SDK.vehicle-temperature.AgoraBeeSDK

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AgoraBeePost**](AgoraBeeSDK.md#agorabeepost) | **POST** /AgoraBee |  |

<a id="agorabeepost"></a>
# **AgoraBeePost**
> PostAgoraBeeResponse AgoraBeePost (PostAgoraBeeRequest? postAgoraBeeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;

namespace Example
{
    public class AgoraBeePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AgoraBeeSDK(config);
            var postAgoraBeeRequest = new PostAgoraBeeRequest?(); // PostAgoraBeeRequest? |  (optional) 

            try
            {
                PostAgoraBeeResponse result = apiInstance.AgoraBeePost(postAgoraBeeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgoraBeeSDK.AgoraBeePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AgoraBeePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostAgoraBeeResponse> response = apiInstance.AgoraBeePostWithHttpInfo(postAgoraBeeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgoraBeeSDK.AgoraBeePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postAgoraBeeRequest** | [**PostAgoraBeeRequest?**](PostAgoraBeeRequest?.md) |  | [optional]  |

### Return type

[**PostAgoraBeeResponse**](PostAgoraBeeResponse.md)

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

