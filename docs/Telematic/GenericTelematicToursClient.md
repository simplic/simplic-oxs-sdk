# Simplic.OxS.SDK.Telematic.GenericTelematicToursClient

All URIs are relative to *https://dev-oxs.simplic.io/telematic-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TelematicToursGet**](GenericTelematicToursClient.md#telematictoursget) | **GET** /generic-telematic-tours |  |
| [**TelematicToursTourIdGet**](GenericTelematicToursClient.md#telematictourstouridget) | **GET** /generic-telematic-tours/{tourId} |  |
| [**TelematicToursTourIdPlacesPlaceIdCompleteStepPost**](GenericTelematicToursClient.md#telematictourstouridplacesplaceidcompletesteppost) | **POST** /generic-telematic-tours/{tourId}/places/{placeId}/complete-step |  |

<a id="telematictoursget"></a>
# **TelematicToursGet**
> List&lt;TelematicTourResponse&gt; TelematicToursGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GenericTelematicToursClient(config);

            try
            {
                List<TelematicTourResponse> result = apiInstance.TelematicToursGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TelematicTourResponse>> response = apiInstance.TelematicToursGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TelematicTourResponse&gt;**](TelematicTourResponse.md)

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

<a id="telematictourstouridget"></a>
# **TelematicToursTourIdGet**
> TelematicTourResponse TelematicToursTourIdGet (Guid tourId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursTourIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GenericTelematicToursClient(config);
            var tourId = "tourId_example";  // Guid | 

            try
            {
                TelematicTourResponse result = apiInstance.TelematicToursTourIdGet(tourId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursTourIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TelematicTourResponse> response = apiInstance.TelematicToursTourIdGetWithHttpInfo(tourId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid** |  |  |

### Return type

[**TelematicTourResponse**](TelematicTourResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="telematictourstouridplacesplaceidcompletesteppost"></a>
# **TelematicToursTourIdPlacesPlaceIdCompleteStepPost**
> TelematicTourResponse TelematicToursTourIdPlacesPlaceIdCompleteStepPost (Guid tourId, Guid placeId, CompleteWorkflowStepRequest? completeWorkflowStepRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursTourIdPlacesPlaceIdCompleteStepPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GenericTelematicToursClient(config);
            var tourId = "tourId_example";  // Guid | 
            var placeId = "placeId_example";  // Guid | 
            var completeWorkflowStepRequest = new CompleteWorkflowStepRequest?(); // CompleteWorkflowStepRequest? |  (optional) 

            try
            {
                TelematicTourResponse result = apiInstance.TelematicToursTourIdPlacesPlaceIdCompleteStepPost(tourId, placeId, completeWorkflowStepRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdPlacesPlaceIdCompleteStepPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursTourIdPlacesPlaceIdCompleteStepPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TelematicTourResponse> response = apiInstance.TelematicToursTourIdPlacesPlaceIdCompleteStepPostWithHttpInfo(tourId, placeId, completeWorkflowStepRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdPlacesPlaceIdCompleteStepPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid** |  |  |
| **placeId** | **Guid** |  |  |
| **completeWorkflowStepRequest** | [**CompleteWorkflowStepRequest?**](CompleteWorkflowStepRequest?.md) |  | [optional]  |

### Return type

[**TelematicTourResponse**](TelematicTourResponse.md)

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

