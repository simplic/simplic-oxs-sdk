# Simplic.OxS.SDK.Telematic.GenericTelematicToursClient

All URIs are relative to *https://dev-oxs.simplic.io/telematic-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TelematicToursDownloadBlobTourIdBlobIdGet**](GenericTelematicToursClient.md#telematictoursdownloadblobtouridblobidget) | **GET** /generic-telematic-tours/download-blob/{tourId}/{blobId} | Download blob file associated with a tour. The blob must have been previously uploaded to the internal CDN and its id stored in a workflow data field. |
| [**TelematicToursGet**](GenericTelematicToursClient.md#telematictoursget) | **GET** /generic-telematic-tours | Gets all tours for the TractorUnit specified in the x-bearer token. Returns tours with complete workflow steps and execution state. |
| [**TelematicToursTourIdGet**](GenericTelematicToursClient.md#telematictourstouridget) | **GET** /generic-telematic-tours/{tourId} | Gets the current state of a specific tour for the authenticated vehicle. |
| [**TelematicToursTourIdOrdersOrderIdCompleteStepPost**](GenericTelematicToursClient.md#telematictourstouridordersorderidcompletesteppost) | **POST** /generic-telematic-tours/{tourId}/orders/{orderId}/complete-step | Completes a workflow step for a specific order in a tour. Resolves the place that contains the given order and delegates to the place-level logic. |
| [**TelematicToursTourIdPlacesPlaceIdCompleteStepPost**](GenericTelematicToursClient.md#telematictourstouridplacesplaceidcompletesteppost) | **POST** /generic-telematic-tours/{tourId}/places/{placeId}/complete-step | Completes a workflow step for a specific place in a tour. Allows passing collected data field values and marks the step as completed. Events are fired based on the step&#39;s role: - \&quot;order_started\&quot;: OrderStarted; on first in tour also TourStarted + PlaceStarted. - \&quot;order_completed\&quot;: OrderEnded; PlaceReached when all orders in the place are done;   TourEnded when all orders in the tour are done. |
| [**TelematicToursUploadBlobTourIdPlaceIdOrderIdPost**](GenericTelematicToursClient.md#telematictoursuploadblobtouridplaceidorderidpost) | **POST** /generic-telematic-tours/upload-blob/{tourId}/{placeId}/{orderId} | Uploads a blob file and attaches it to a place or order within a tour. If orderId is provided and the order exists, the blob is attached to the order&#39;s ePOD attachments. Otherwise the blob is attached to the place&#39;s attachments. |

<a id="telematictoursdownloadblobtouridblobidget"></a>
# **TelematicToursDownloadBlobTourIdBlobIdGet**
> byte[] TelematicToursDownloadBlobTourIdBlobIdGet (Guid tourId, Guid blobId)

Download blob file associated with a tour. The blob must have been previously uploaded to the internal CDN and its id stored in a workflow data field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursDownloadBlobTourIdBlobIdGetExample
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
            var tourId = "tourId_example";  // Guid | Tour id
            var blobId = "blobId_example";  // Guid | Blob id

            try
            {
                // Download blob file associated with a tour. The blob must have been previously uploaded to the internal CDN and its id stored in a workflow data field.
                byte[] result = apiInstance.TelematicToursDownloadBlobTourIdBlobIdGet(tourId, blobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursDownloadBlobTourIdBlobIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursDownloadBlobTourIdBlobIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download blob file associated with a tour. The blob must have been previously uploaded to the internal CDN and its id stored in a workflow data field.
    ApiResponse<byte[]> response = apiInstance.TelematicToursDownloadBlobTourIdBlobIdGetWithHttpInfo(tourId, blobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursDownloadBlobTourIdBlobIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid** | Tour id |  |
| **blobId** | **Guid** | Blob id |  |

### Return type

**byte[]**

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

<a id="telematictoursget"></a>
# **TelematicToursGet**
> List&lt;TelematicTourResponse&gt; TelematicToursGet ()

Gets all tours for the TractorUnit specified in the x-bearer token. Returns tours with complete workflow steps and execution state.

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
                // Gets all tours for the TractorUnit specified in the x-bearer token. Returns tours with complete workflow steps and execution state.
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
    // Gets all tours for the TractorUnit specified in the x-bearer token. Returns tours with complete workflow steps and execution state.
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

Gets the current state of a specific tour for the authenticated vehicle.

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
            var tourId = "tourId_example";  // Guid | The internal tour identifier.

            try
            {
                // Gets the current state of a specific tour for the authenticated vehicle.
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
    // Gets the current state of a specific tour for the authenticated vehicle.
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
| **tourId** | **Guid** | The internal tour identifier. |  |

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

<a id="telematictourstouridordersorderidcompletesteppost"></a>
# **TelematicToursTourIdOrdersOrderIdCompleteStepPost**
> TelematicTourResponse TelematicToursTourIdOrdersOrderIdCompleteStepPost (Guid tourId, Guid orderId, CompleteWorkflowStepRequest? completeWorkflowStepRequest = null)

Completes a workflow step for a specific order in a tour. Resolves the place that contains the given order and delegates to the place-level logic.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursTourIdOrdersOrderIdCompleteStepPostExample
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
            var tourId = "tourId_example";  // Guid | The internal tour identifier.
            var orderId = "orderId_example";  // Guid | The internal order identifier.
            var completeWorkflowStepRequest = new CompleteWorkflowStepRequest?(); // CompleteWorkflowStepRequest? | The complete workflow step request containing step id and data field values. (optional) 

            try
            {
                // Completes a workflow step for a specific order in a tour. Resolves the place that contains the given order and delegates to the place-level logic.
                TelematicTourResponse result = apiInstance.TelematicToursTourIdOrdersOrderIdCompleteStepPost(tourId, orderId, completeWorkflowStepRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdOrdersOrderIdCompleteStepPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursTourIdOrdersOrderIdCompleteStepPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Completes a workflow step for a specific order in a tour. Resolves the place that contains the given order and delegates to the place-level logic.
    ApiResponse<TelematicTourResponse> response = apiInstance.TelematicToursTourIdOrdersOrderIdCompleteStepPostWithHttpInfo(tourId, orderId, completeWorkflowStepRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursTourIdOrdersOrderIdCompleteStepPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid** | The internal tour identifier. |  |
| **orderId** | **Guid** | The internal order identifier. |  |
| **completeWorkflowStepRequest** | [**CompleteWorkflowStepRequest?**](CompleteWorkflowStepRequest?.md) | The complete workflow step request containing step id and data field values. | [optional]  |

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

<a id="telematictourstouridplacesplaceidcompletesteppost"></a>
# **TelematicToursTourIdPlacesPlaceIdCompleteStepPost**
> TelematicTourResponse TelematicToursTourIdPlacesPlaceIdCompleteStepPost (Guid tourId, Guid placeId, CompleteWorkflowStepRequest? completeWorkflowStepRequest = null)

Completes a workflow step for a specific place in a tour. Allows passing collected data field values and marks the step as completed. Events are fired based on the step's role: - \"order_started\": OrderStarted; on first in tour also TourStarted + PlaceStarted. - \"order_completed\": OrderEnded; PlaceReached when all orders in the place are done;   TourEnded when all orders in the tour are done.

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
            var tourId = "tourId_example";  // Guid | The internal tour identifier.
            var placeId = "placeId_example";  // Guid | The internal place identifier.
            var completeWorkflowStepRequest = new CompleteWorkflowStepRequest?(); // CompleteWorkflowStepRequest? | The complete workflow step request containing step id and data field values. (optional) 

            try
            {
                // Completes a workflow step for a specific place in a tour. Allows passing collected data field values and marks the step as completed. Events are fired based on the step's role: - \"order_started\": OrderStarted; on first in tour also TourStarted + PlaceStarted. - \"order_completed\": OrderEnded; PlaceReached when all orders in the place are done;   TourEnded when all orders in the tour are done.
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
    // Completes a workflow step for a specific place in a tour. Allows passing collected data field values and marks the step as completed. Events are fired based on the step's role: - \"order_started\": OrderStarted; on first in tour also TourStarted + PlaceStarted. - \"order_completed\": OrderEnded; PlaceReached when all orders in the place are done;   TourEnded when all orders in the tour are done.
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
| **tourId** | **Guid** | The internal tour identifier. |  |
| **placeId** | **Guid** | The internal place identifier. |  |
| **completeWorkflowStepRequest** | [**CompleteWorkflowStepRequest?**](CompleteWorkflowStepRequest?.md) | The complete workflow step request containing step id and data field values. | [optional]  |

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

<a id="telematictoursuploadblobtouridplaceidorderidpost"></a>
# **TelematicToursUploadBlobTourIdPlaceIdOrderIdPost**
> UploadBlobResponse TelematicToursUploadBlobTourIdPlaceIdOrderIdPost (Guid tourId, Guid placeId, Guid orderId, System.IO.Stream? file = null)

Uploads a blob file and attaches it to a place or order within a tour. If orderId is provided and the order exists, the blob is attached to the order's ePOD attachments. Otherwise the blob is attached to the place's attachments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicToursUploadBlobTourIdPlaceIdOrderIdPostExample
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
            var tourId = "tourId_example";  // Guid | The internal tour identifier.
            var placeId = "placeId_example";  // Guid | The internal place identifier.
            var orderId = "orderId_example";  // Guid | The optional internal order identifier. When supplied the blob is added to the order.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | The file to upload. (optional) 

            try
            {
                // Uploads a blob file and attaches it to a place or order within a tour. If orderId is provided and the order exists, the blob is attached to the order's ePOD attachments. Otherwise the blob is attached to the place's attachments.
                UploadBlobResponse result = apiInstance.TelematicToursUploadBlobTourIdPlaceIdOrderIdPost(tourId, placeId, orderId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursUploadBlobTourIdPlaceIdOrderIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicToursUploadBlobTourIdPlaceIdOrderIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Uploads a blob file and attaches it to a place or order within a tour. If orderId is provided and the order exists, the blob is attached to the order's ePOD attachments. Otherwise the blob is attached to the place's attachments.
    ApiResponse<UploadBlobResponse> response = apiInstance.TelematicToursUploadBlobTourIdPlaceIdOrderIdPostWithHttpInfo(tourId, placeId, orderId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenericTelematicToursClient.TelematicToursUploadBlobTourIdPlaceIdOrderIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid** | The internal tour identifier. |  |
| **placeId** | **Guid** | The internal place identifier. |  |
| **orderId** | **Guid** | The optional internal order identifier. When supplied the blob is added to the order. |  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | The file to upload. | [optional]  |

### Return type

[**UploadBlobResponse**](UploadBlobResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

