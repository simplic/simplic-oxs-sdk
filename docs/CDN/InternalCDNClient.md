# Simplic.OxS.SDK.CDN.InternalCDNClient

All URIs are relative to *https://dev-oxs.simplic.io/cdn-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Upload**](InternalCDNClient.md#internalinternalcdnuploadpost) | **POST** /internal/InternalCDN/upload |  |

<a id="internalinternalcdnuploadpost"></a>
# **Upload**
> UploadResponse Upload (UploadBytesRequest? uploadBytesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN;
using Simplic.OxS.SDK.CDN;
using Simplic.OxS.SDK.CDN;

namespace Example
{
    public class UploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalCDNClient(config);
            var uploadBytesRequest = new UploadBytesRequest?(); // UploadBytesRequest? |  (optional) 

            try
            {
                UploadResponse result = apiInstance.Upload(uploadBytesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalCDNClient.Upload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UploadResponse> response = apiInstance.UploadWithHttpInfo(uploadBytesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalCDNClient.UploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadBytesRequest** | [**UploadBytesRequest?**](UploadBytesRequest?.md) |  | [optional]  |

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

