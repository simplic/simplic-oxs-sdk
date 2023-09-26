# Simplic.OxS.SDK.Logistics...DefaultPlanningSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DefaultPlanningGetByResourceResourceIdGet**](DefaultPlanningSDK.md#defaultplanninggetbyresourceresourceidget) | **GET** /DefaultPlanning/get-by-resource/{resourceId} | Gets plan for resource matching given id. |
| [**DefaultPlanningGetByShiftShiftIdGet**](DefaultPlanningSDK.md#defaultplanninggetbyshiftshiftidget) | **GET** /DefaultPlanning/get-by-shift/{shiftId} | Gets the plan with given id. |
| [**DefaultPlanningPost**](DefaultPlanningSDK.md#defaultplanningpost) | **POST** /DefaultPlanning | Posts a new plan. |
| [**DefaultPlanningShiftIdDelete**](DefaultPlanningSDK.md#defaultplanningshiftiddelete) | **DELETE** /DefaultPlanning/{shiftId} | Deletes plan matching given id. |
| [**DefaultPlanningShiftIdPatch**](DefaultPlanningSDK.md#defaultplanningshiftidpatch) | **PATCH** /DefaultPlanning/{shiftId} | Patches plan matching given id. |
| [**DefaultPlanningValidateGet**](DefaultPlanningSDK.md#defaultplanningvalidateget) | **GET** /DefaultPlanning/validate | Checks whether any resource has been assigned in multiple plans. |

<a id="defaultplanninggetbyresourceresourceidget"></a>
# **DefaultPlanningGetByResourceResourceIdGet**
> DefaultPlanningAssignmentResponse DefaultPlanningGetByResourceResourceIdGet (Guid resourceId, Guid? shiftId = null)

Gets plan for resource matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningGetByResourceResourceIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);
            var resourceId = "resourceId_example";  // Guid | 
            var shiftId = "shiftId_example";  // Guid? |  (optional) 

            try
            {
                // Gets plan for resource matching given id.
                DefaultPlanningAssignmentResponse result = apiInstance.DefaultPlanningGetByResourceResourceIdGet(resourceId, shiftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningGetByResourceResourceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningGetByResourceResourceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets plan for resource matching given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.DefaultPlanningGetByResourceResourceIdGetWithHttpInfo(resourceId, shiftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningGetByResourceResourceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | **Guid** |  |  |
| **shiftId** | **Guid?** |  | [optional]  |

### Return type

[**DefaultPlanningAssignmentResponse**](DefaultPlanningAssignmentResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="defaultplanninggetbyshiftshiftidget"></a>
# **DefaultPlanningGetByShiftShiftIdGet**
> DefaultPlanningAssignmentResponse DefaultPlanningGetByShiftShiftIdGet (Guid shiftId)

Gets the plan with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningGetByShiftShiftIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);
            var shiftId = "shiftId_example";  // Guid | 

            try
            {
                // Gets the plan with given id.
                DefaultPlanningAssignmentResponse result = apiInstance.DefaultPlanningGetByShiftShiftIdGet(shiftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningGetByShiftShiftIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningGetByShiftShiftIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the plan with given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.DefaultPlanningGetByShiftShiftIdGetWithHttpInfo(shiftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningGetByShiftShiftIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shiftId** | **Guid** |  |  |

### Return type

[**DefaultPlanningAssignmentResponse**](DefaultPlanningAssignmentResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="defaultplanningpost"></a>
# **DefaultPlanningPost**
> DefaultPlanningAssignmentResponse DefaultPlanningPost (PostDefaultPlanningRequest? postDefaultPlanningRequest = null)

Posts a new plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);
            var postDefaultPlanningRequest = new PostDefaultPlanningRequest?(); // PostDefaultPlanningRequest? |  (optional) 

            try
            {
                // Posts a new plan.
                DefaultPlanningAssignmentResponse result = apiInstance.DefaultPlanningPost(postDefaultPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Posts a new plan.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.DefaultPlanningPostWithHttpInfo(postDefaultPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postDefaultPlanningRequest** | [**PostDefaultPlanningRequest?**](PostDefaultPlanningRequest?.md) |  | [optional]  |

### Return type

[**DefaultPlanningAssignmentResponse**](DefaultPlanningAssignmentResponse.md)

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

<a id="defaultplanningshiftiddelete"></a>
# **DefaultPlanningShiftIdDelete**
> void DefaultPlanningShiftIdDelete (Guid shiftId)

Deletes plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningShiftIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);
            var shiftId = "shiftId_example";  // Guid | 

            try
            {
                // Deletes plan matching given id.
                apiInstance.DefaultPlanningShiftIdDelete(shiftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningShiftIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningShiftIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes plan matching given id.
    apiInstance.DefaultPlanningShiftIdDeleteWithHttpInfo(shiftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningShiftIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shiftId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="defaultplanningshiftidpatch"></a>
# **DefaultPlanningShiftIdPatch**
> DefaultPlanningAssignmentResponse DefaultPlanningShiftIdPatch (Guid shiftId, PatchDefaultPlanningRequest? patchDefaultPlanningRequest = null)

Patches plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningShiftIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);
            var shiftId = "shiftId_example";  // Guid | 
            var patchDefaultPlanningRequest = new PatchDefaultPlanningRequest?(); // PatchDefaultPlanningRequest? |  (optional) 

            try
            {
                // Patches plan matching given id.
                DefaultPlanningAssignmentResponse result = apiInstance.DefaultPlanningShiftIdPatch(shiftId, patchDefaultPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningShiftIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningShiftIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches plan matching given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.DefaultPlanningShiftIdPatchWithHttpInfo(shiftId, patchDefaultPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningShiftIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shiftId** | **Guid** |  |  |
| **patchDefaultPlanningRequest** | [**PatchDefaultPlanningRequest?**](PatchDefaultPlanningRequest?.md) |  | [optional]  |

### Return type

[**DefaultPlanningAssignmentResponse**](DefaultPlanningAssignmentResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="defaultplanningvalidateget"></a>
# **DefaultPlanningValidateGet**
> ValidateResponse DefaultPlanningValidateGet ()

Checks whether any resource has been assigned in multiple plans.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class DefaultPlanningValidateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningSDK(config);

            try
            {
                // Checks whether any resource has been assigned in multiple plans.
                ValidateResponse result = apiInstance.DefaultPlanningValidateGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningValidateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DefaultPlanningValidateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks whether any resource has been assigned in multiple plans.
    ApiResponse<ValidateResponse> response = apiInstance.DefaultPlanningValidateGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningSDK.DefaultPlanningValidateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ValidateResponse**](ValidateResponse.md)

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

