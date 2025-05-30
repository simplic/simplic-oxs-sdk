# Simplic.OxS.SDK.Geo.RoutingClient

All URIs are relative to *https://dev-oxs.simplic.io/geo-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateRoute**](RoutingClient.md#routingcalculateroutepost) | **POST** /Routing/calculate-route |  |

<a id="routingcalculateroutepost"></a>
# **CalculateRoute**
> RoutingResponse CalculateRoute (RequestRoute? requestRoute = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Geo;

namespace Example
{
    public class CalculateRouteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/geo-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RoutingClient(config);
            var requestRoute = new RequestRoute?(); // RequestRoute? |  (optional) 

            try
            {
                RoutingResponse result = apiInstance.CalculateRoute(requestRoute);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutingClient.CalculateRoute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CalculateRouteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RoutingResponse> response = apiInstance.CalculateRouteWithHttpInfo(requestRoute);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoutingClient.CalculateRouteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestRoute** | [**RequestRoute?**](RequestRoute?.md) |  | [optional]  |

### Return type

[**RoutingResponse**](RoutingResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

