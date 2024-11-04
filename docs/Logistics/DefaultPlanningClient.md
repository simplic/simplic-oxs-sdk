# Simplic.OxS.SDK.Logistics.DefaultPlanningClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByResource**](DefaultPlanningClient.md#defaultplanninggetbyresourceresourceidget) | **GET** /DefaultPlanning/get-by-resource/{resourceId} | Gets plan for resource matching given id. |
| [**GetByShift**](DefaultPlanningClient.md#defaultplanninggetbyshiftshiftidget) | **GET** /DefaultPlanning/get-by-shift/{shiftId} | Gets the plan with given id. |
| [**Post**](DefaultPlanningClient.md#defaultplanningpost) | **POST** /DefaultPlanning | Posts a new plan. |
| [**Delete**](DefaultPlanningClient.md#defaultplanningshiftiddelete) | **DELETE** /DefaultPlanning/{shiftId} | Deletes plan matching given id. |
| [**Patch**](DefaultPlanningClient.md#defaultplanningshiftidpatch) | **PATCH** /DefaultPlanning/{shiftId} | Patches plan matching given id. |
| [**Validate**](DefaultPlanningClient.md#defaultplanningvalidateget) | **GET** /DefaultPlanning/validate | Checks whether any resource has been assigned in multiple plans. |

<a id="defaultplanninggetbyresourceresourceidget"></a>
# **GetByResource**
> DefaultPlanningAssignmentResponse GetByResource (Guid resourceId, Guid? shiftId = null)

Gets plan for resource matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetByResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);
            var resourceId = "resourceId_example";  // Guid | 
            var shiftId = "shiftId_example";  // Guid? |  (optional) 

            try
            {
                // Gets plan for resource matching given id.
                DefaultPlanningAssignmentResponse result = apiInstance.GetByResource(resourceId, shiftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.GetByResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets plan for resource matching given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.GetByResourceWithHttpInfo(resourceId, shiftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.GetByResourceWithHttpInfo: " + e.Message);
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
# **GetByShift**
> DefaultPlanningAssignmentResponse GetByShift (Guid shiftId)

Gets the plan with given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetByShiftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);
            var shiftId = "shiftId_example";  // Guid | 

            try
            {
                // Gets the plan with given id.
                DefaultPlanningAssignmentResponse result = apiInstance.GetByShift(shiftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.GetByShift: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByShiftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the plan with given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.GetByShiftWithHttpInfo(shiftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.GetByShiftWithHttpInfo: " + e.Message);
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
# **Post**
> DefaultPlanningAssignmentResponse Post (PostDefaultPlanningRequest? postDefaultPlanningRequest = null)

Posts a new plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);
            var postDefaultPlanningRequest = new PostDefaultPlanningRequest?(); // PostDefaultPlanningRequest? |  (optional) 

            try
            {
                // Posts a new plan.
                DefaultPlanningAssignmentResponse result = apiInstance.Post(postDefaultPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Posts a new plan.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.PostWithHttpInfo(postDefaultPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.PostWithHttpInfo: " + e.Message);
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
# **Delete**
> void Delete (Guid shiftId)

Deletes plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);
            var shiftId = "shiftId_example";  // Guid | 

            try
            {
                // Deletes plan matching given id.
                apiInstance.Delete(shiftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes plan matching given id.
    apiInstance.DeleteWithHttpInfo(shiftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.DeleteWithHttpInfo: " + e.Message);
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
# **Patch**
> DefaultPlanningAssignmentResponse Patch (Guid shiftId, PatchDefaultPlanningRequest? patchDefaultPlanningRequest = null)

Patches plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);
            var shiftId = "shiftId_example";  // Guid | 
            var patchDefaultPlanningRequest = new PatchDefaultPlanningRequest?(); // PatchDefaultPlanningRequest? |  (optional) 

            try
            {
                // Patches plan matching given id.
                DefaultPlanningAssignmentResponse result = apiInstance.Patch(shiftId, patchDefaultPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches plan matching given id.
    ApiResponse<DefaultPlanningAssignmentResponse> response = apiInstance.PatchWithHttpInfo(shiftId, patchDefaultPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.PatchWithHttpInfo: " + e.Message);
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
# **Validate**
> ValidateResponse Validate ()

Checks whether any resource has been assigned in multiple plans.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultPlanningClient(config);

            try
            {
                // Checks whether any resource has been assigned in multiple plans.
                ValidateResponse result = apiInstance.Validate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultPlanningClient.Validate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks whether any resource has been assigned in multiple plans.
    ApiResponse<ValidateResponse> response = apiInstance.ValidateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultPlanningClient.ValidateWithHttpInfo: " + e.Message);
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

