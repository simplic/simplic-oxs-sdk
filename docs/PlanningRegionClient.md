# Simplic.OxS.SDK.Logistics.PlanningRegionClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PlanningRegionGetAllGet**](PlanningRegionClient.md#planningregiongetallget) | **GET** /PlanningRegion/get-all | Retrieves all planning region. |
| [**PlanningRegionIdGet**](PlanningRegionClient.md#planningregionidget) | **GET** /PlanningRegion/{id} | Retrives the planning region with the given id. |
| [**PlanningRegionIdPatch**](PlanningRegionClient.md#planningregionidpatch) | **PATCH** /PlanningRegion/{id} | Updates/saves the given planning region. |
| [**PlanningRegionPost**](PlanningRegionClient.md#planningregionpost) | **POST** /PlanningRegion | Creates a new planning region. |

<a id="planningregiongetallget"></a>
# **PlanningRegionGetAllGet**
> List&lt;PlanningRegionModel&gt; PlanningRegionGetAllGet ()

Retrieves all planning region.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PlanningRegionGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PlanningRegionClient(config);

            try
            {
                // Retrieves all planning region.
                List<PlanningRegionModel> result = apiInstance.PlanningRegionGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanningRegionGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all planning region.
    ApiResponse<List<PlanningRegionModel>> response = apiInstance.PlanningRegionGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PlanningRegionModel&gt;**](PlanningRegionModel.md)

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

<a id="planningregionidget"></a>
# **PlanningRegionIdGet**
> PlanningRegionModel PlanningRegionIdGet (Guid id)

Retrives the planning region with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PlanningRegionIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PlanningRegionClient(config);
            var id = "id_example";  // Guid | Id of the planning region.

            try
            {
                // Retrives the planning region with the given id.
                PlanningRegionModel result = apiInstance.PlanningRegionIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanningRegionIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the planning region with the given id.
    ApiResponse<PlanningRegionModel> response = apiInstance.PlanningRegionIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the planning region. |  |

### Return type

[**PlanningRegionModel**](PlanningRegionModel.md)

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

<a id="planningregionidpatch"></a>
# **PlanningRegionIdPatch**
> PlanningRegionModel PlanningRegionIdPatch (Guid id, PatchPlanningRegionRequest? patchPlanningRegionRequest = null)

Updates/saves the given planning region.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PlanningRegionIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PlanningRegionClient(config);
            var id = "id_example";  // Guid | Id of the planning region to update.
            var patchPlanningRegionRequest = new PatchPlanningRegionRequest?(); // PatchPlanningRegionRequest? | Shipment status to update. (optional) 

            try
            {
                // Updates/saves the given planning region.
                PlanningRegionModel result = apiInstance.PlanningRegionIdPatch(id, patchPlanningRegionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanningRegionIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates/saves the given planning region.
    ApiResponse<PlanningRegionModel> response = apiInstance.PlanningRegionIdPatchWithHttpInfo(id, patchPlanningRegionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the planning region to update. |  |
| **patchPlanningRegionRequest** | [**PatchPlanningRegionRequest?**](PatchPlanningRegionRequest?.md) | Shipment status to update. | [optional]  |

### Return type

[**PlanningRegionModel**](PlanningRegionModel.md)

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

<a id="planningregionpost"></a>
# **PlanningRegionPost**
> PlanningRegionModel PlanningRegionPost (CreatePlanningRegionRequest? createPlanningRegionRequest = null)

Creates a new planning region.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PlanningRegionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PlanningRegionClient(config);
            var createPlanningRegionRequest = new CreatePlanningRegionRequest?(); // CreatePlanningRegionRequest? | A create planning region request object. (optional) 

            try
            {
                // Creates a new planning region.
                PlanningRegionModel result = apiInstance.PlanningRegionPost(createPlanningRegionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanningRegionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new planning region.
    ApiResponse<PlanningRegionModel> response = apiInstance.PlanningRegionPostWithHttpInfo(createPlanningRegionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlanningRegionClient.PlanningRegionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPlanningRegionRequest** | [**CreatePlanningRegionRequest?**](CreatePlanningRegionRequest?.md) | A create planning region request object. | [optional]  |

### Return type

[**PlanningRegionModel**](PlanningRegionModel.md)

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

