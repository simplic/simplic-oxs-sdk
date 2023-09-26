# Simplic.OxS.SDK.Logistics...TourStatusSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TourStatusGetAllGet**](TourStatusSDK.md#tourstatusgetallget) | **GET** /TourStatus/get-all | Retrieves all tour status. |
| [**TourStatusIdGet**](TourStatusSDK.md#tourstatusidget) | **GET** /TourStatus/{id} | Retrives the tour status with the given id. |
| [**TourStatusIdPatch**](TourStatusSDK.md#tourstatusidpatch) | **PATCH** /TourStatus/{id} | Updates/saves the given tour status. |
| [**TourStatusPost**](TourStatusSDK.md#tourstatuspost) | **POST** /TourStatus | Creates a new tour status. |

<a id="tourstatusgetallget"></a>
# **TourStatusGetAllGet**
> List&lt;TourStatusModel&gt; TourStatusGetAllGet ()

Retrieves all tour status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class TourStatusGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourStatusSDK(config);

            try
            {
                // Retrieves all tour status.
                List<TourStatusModel> result = apiInstance.TourStatusGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourStatusSDK.TourStatusGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourStatusGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all tour status.
    ApiResponse<List<TourStatusModel>> response = apiInstance.TourStatusGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourStatusSDK.TourStatusGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TourStatusModel&gt;**](TourStatusModel.md)

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

<a id="tourstatusidget"></a>
# **TourStatusIdGet**
> TourStatusModel TourStatusIdGet (Guid id)

Retrives the tour status with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class TourStatusIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourStatusSDK(config);
            var id = "id_example";  // Guid | Id of the tour status.

            try
            {
                // Retrives the tour status with the given id.
                TourStatusModel result = apiInstance.TourStatusIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourStatusSDK.TourStatusIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourStatusIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the tour status with the given id.
    ApiResponse<TourStatusModel> response = apiInstance.TourStatusIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourStatusSDK.TourStatusIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the tour status. |  |

### Return type

[**TourStatusModel**](TourStatusModel.md)

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

<a id="tourstatusidpatch"></a>
# **TourStatusIdPatch**
> TourStatusModel TourStatusIdPatch (Guid id, PatchTourStatusRequest? patchTourStatusRequest = null)

Updates/saves the given tour status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class TourStatusIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourStatusSDK(config);
            var id = "id_example";  // Guid | Id of the tour status to update.
            var patchTourStatusRequest = new PatchTourStatusRequest?(); // PatchTourStatusRequest? | Tour status to update. (optional) 

            try
            {
                // Updates/saves the given tour status.
                TourStatusModel result = apiInstance.TourStatusIdPatch(id, patchTourStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourStatusSDK.TourStatusIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourStatusIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates/saves the given tour status.
    ApiResponse<TourStatusModel> response = apiInstance.TourStatusIdPatchWithHttpInfo(id, patchTourStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourStatusSDK.TourStatusIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the tour status to update. |  |
| **patchTourStatusRequest** | [**PatchTourStatusRequest?**](PatchTourStatusRequest?.md) | Tour status to update. | [optional]  |

### Return type

[**TourStatusModel**](TourStatusModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tourstatuspost"></a>
# **TourStatusPost**
> TourStatusModel TourStatusPost (CreateTourStatusRequest? createTourStatusRequest = null)

Creates a new tour status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class TourStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourStatusSDK(config);
            var createTourStatusRequest = new CreateTourStatusRequest?(); // CreateTourStatusRequest? | A create tour status request object. (optional) 

            try
            {
                // Creates a new tour status.
                TourStatusModel result = apiInstance.TourStatusPost(createTourStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourStatusSDK.TourStatusPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourStatusPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new tour status.
    ApiResponse<TourStatusModel> response = apiInstance.TourStatusPostWithHttpInfo(createTourStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourStatusSDK.TourStatusPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTourStatusRequest** | [**CreateTourStatusRequest?**](CreateTourStatusRequest?.md) | A create tour status request object. | [optional]  |

### Return type

[**TourStatusModel**](TourStatusModel.md)

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

