# Simplic.OxS.SDK.Geo.LocationClient

All URIs are relative to *https://dev-oxs.simplic.io/geo-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SearchAddress**](LocationClient.md#locationsearchaddresspost) | **POST** /Location/search-address |  |

<a id="locationsearchaddresspost"></a>
# **SearchAddress**
> LocationResponse SearchAddress (RequestGeoLocation? requestGeoLocation = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Geo;
using Simplic.OxS.SDK.Geo;
using Simplic.OxS.SDK.Geo;

namespace Example
{
    public class SearchAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/geo-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocationClient(config);
            var requestGeoLocation = new RequestGeoLocation?(); // RequestGeoLocation? |  (optional) 

            try
            {
                LocationResponse result = apiInstance.SearchAddress(requestGeoLocation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationClient.SearchAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LocationResponse> response = apiInstance.SearchAddressWithHttpInfo(requestGeoLocation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationClient.SearchAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestGeoLocation** | [**RequestGeoLocation?**](RequestGeoLocation?.md) |  | [optional]  |

### Return type

[**LocationResponse**](LocationResponse.md)

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

