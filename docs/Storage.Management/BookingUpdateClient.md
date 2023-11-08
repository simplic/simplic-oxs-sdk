# Simplic.OxS.SDK.Storage.Management.BookingUpdateClient

All URIs are relative to *https://dev-oxs.simplic.io/storage-management-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookingUpdateConfirmUpdatesRecievedPost**](BookingUpdateClient.md#bookingupdateconfirmupdatesrecievedpost) | **POST** /BookingUpdate/confirm-updates-recieved |  |
| [**BookingUpdateGetRecentUpdatesGet**](BookingUpdateClient.md#bookingupdategetrecentupdatesget) | **GET** /BookingUpdate/get-recent-updates |  |

<a id="bookingupdateconfirmupdatesrecievedpost"></a>
# **BookingUpdateConfirmUpdatesRecievedPost**
> int BookingUpdateConfirmUpdatesRecievedPost (DateTime? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Storage.Management;
using Simplic.OxS.SDK.Storage.Management;
using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class BookingUpdateConfirmUpdatesRecievedPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingUpdateClient(config);
            var body = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                int result = apiInstance.BookingUpdateConfirmUpdatesRecievedPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingUpdateClient.BookingUpdateConfirmUpdatesRecievedPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingUpdateConfirmUpdatesRecievedPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.BookingUpdateConfirmUpdatesRecievedPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingUpdateClient.BookingUpdateConfirmUpdatesRecievedPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **DateTime?** |  | [optional]  |

### Return type

**int**

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bookingupdategetrecentupdatesget"></a>
# **BookingUpdateGetRecentUpdatesGet**
> List&lt;BookingUpdate&gt; BookingUpdateGetRecentUpdatesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Storage.Management;
using Simplic.OxS.SDK.Storage.Management;
using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class BookingUpdateGetRecentUpdatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingUpdateClient(config);

            try
            {
                List<BookingUpdate> result = apiInstance.BookingUpdateGetRecentUpdatesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingUpdateClient.BookingUpdateGetRecentUpdatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingUpdateGetRecentUpdatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<BookingUpdate>> response = apiInstance.BookingUpdateGetRecentUpdatesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingUpdateClient.BookingUpdateGetRecentUpdatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;BookingUpdate&gt;**](BookingUpdate.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

