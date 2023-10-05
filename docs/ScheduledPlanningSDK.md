# Simplic.OxS.SDK.Logistics.ScheduledPlanningSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ScheduledPlanningGetByDateGet**](ScheduledPlanningSDK.md#scheduledplanninggetbydateget) | **GET** /ScheduledPlanning/get-by-date | Gets all plans for given day. |
| [**ScheduledPlanningGetByResourceResourceIdGet**](ScheduledPlanningSDK.md#scheduledplanninggetbyresourceresourceidget) | **GET** /ScheduledPlanning/get-by-resource/{resourceId} | Gets shifts for resource on given day. |
| [**ScheduledPlanningGetByShiftShiftIdGet**](ScheduledPlanningSDK.md#scheduledplanninggetbyshiftshiftidget) | **GET** /ScheduledPlanning/get-by-shift/{shiftId} | Gets plans matching given shift id for given day. |
| [**ScheduledPlanningIdDelete**](ScheduledPlanningSDK.md#scheduledplanningiddelete) | **DELETE** /ScheduledPlanning/{id} | Deletes plan matching given id. |
| [**ScheduledPlanningIdGet**](ScheduledPlanningSDK.md#scheduledplanningidget) | **GET** /ScheduledPlanning/{id} | Gets plan matching given id. |
| [**ScheduledPlanningIdPatch**](ScheduledPlanningSDK.md#scheduledplanningidpatch) | **PATCH** /ScheduledPlanning/{id} | Patches plan matching given id. |
| [**ScheduledPlanningPost**](ScheduledPlanningSDK.md#scheduledplanningpost) | **POST** /ScheduledPlanning | Posts a new plan. |
| [**ScheduledPlanningValidateGet**](ScheduledPlanningSDK.md#scheduledplanningvalidateget) | **GET** /ScheduledPlanning/validate | Checks whether any resource has been assigned in multiple plans. |

<a id="scheduledplanninggetbydateget"></a>
# **ScheduledPlanningGetByDateGet**
> List&lt;ScheduledPlanningAssignmentResponse&gt; ScheduledPlanningGetByDateGet (DateTime? dateTime = null)

Gets all plans for given day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningGetByDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var dateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Gets all plans for given day.
                List<ScheduledPlanningAssignmentResponse> result = apiInstance.ScheduledPlanningGetByDateGet(dateTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningGetByDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all plans for given day.
    ApiResponse<List<ScheduledPlanningAssignmentResponse>> response = apiInstance.ScheduledPlanningGetByDateGetWithHttpInfo(dateTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateTime** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;ScheduledPlanningAssignmentResponse&gt;**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanninggetbyresourceresourceidget"></a>
# **ScheduledPlanningGetByResourceResourceIdGet**
> ScheduledPlanningAssignmentResponse ScheduledPlanningGetByResourceResourceIdGet (Guid resourceId, DateTime? dateTime = null, Guid? shiftId = null)

Gets shifts for resource on given day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningGetByResourceResourceIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var resourceId = "resourceId_example";  // Guid | 
            var dateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var shiftId = "shiftId_example";  // Guid? |  (optional) 

            try
            {
                // Gets shifts for resource on given day.
                ScheduledPlanningAssignmentResponse result = apiInstance.ScheduledPlanningGetByResourceResourceIdGet(resourceId, dateTime, shiftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByResourceResourceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningGetByResourceResourceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets shifts for resource on given day.
    ApiResponse<ScheduledPlanningAssignmentResponse> response = apiInstance.ScheduledPlanningGetByResourceResourceIdGetWithHttpInfo(resourceId, dateTime, shiftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByResourceResourceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | **Guid** |  |  |
| **dateTime** | **DateTime?** |  | [optional]  |
| **shiftId** | **Guid?** |  | [optional]  |

### Return type

[**ScheduledPlanningAssignmentResponse**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanninggetbyshiftshiftidget"></a>
# **ScheduledPlanningGetByShiftShiftIdGet**
> List&lt;ScheduledPlanningAssignmentResponse&gt; ScheduledPlanningGetByShiftShiftIdGet (Guid shiftId, DateTime? dateTime = null)

Gets plans matching given shift id for given day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningGetByShiftShiftIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var shiftId = "shiftId_example";  // Guid | 
            var dateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Gets plans matching given shift id for given day.
                List<ScheduledPlanningAssignmentResponse> result = apiInstance.ScheduledPlanningGetByShiftShiftIdGet(shiftId, dateTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByShiftShiftIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningGetByShiftShiftIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets plans matching given shift id for given day.
    ApiResponse<List<ScheduledPlanningAssignmentResponse>> response = apiInstance.ScheduledPlanningGetByShiftShiftIdGetWithHttpInfo(shiftId, dateTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningGetByShiftShiftIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shiftId** | **Guid** |  |  |
| **dateTime** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;ScheduledPlanningAssignmentResponse&gt;**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanningiddelete"></a>
# **ScheduledPlanningIdDelete**
> void ScheduledPlanningIdDelete (Guid id)

Deletes plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deletes plan matching given id.
                apiInstance.ScheduledPlanningIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes plan matching given id.
    apiInstance.ScheduledPlanningIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scheduledplanningidget"></a>
# **ScheduledPlanningIdGet**
> ScheduledPlanningAssignmentResponse ScheduledPlanningIdGet (Guid id)

Gets plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Gets plan matching given id.
                ScheduledPlanningAssignmentResponse result = apiInstance.ScheduledPlanningIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets plan matching given id.
    ApiResponse<ScheduledPlanningAssignmentResponse> response = apiInstance.ScheduledPlanningIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ScheduledPlanningAssignmentResponse**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanningidpatch"></a>
# **ScheduledPlanningIdPatch**
> ScheduledPlanningAssignmentResponse ScheduledPlanningIdPatch (Guid id, PatchScheduledPlanningRequest? patchScheduledPlanningRequest = null)

Patches plan matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var id = "id_example";  // Guid | 
            var patchScheduledPlanningRequest = new PatchScheduledPlanningRequest?(); // PatchScheduledPlanningRequest? |  (optional) 

            try
            {
                // Patches plan matching given id.
                ScheduledPlanningAssignmentResponse result = apiInstance.ScheduledPlanningIdPatch(id, patchScheduledPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches plan matching given id.
    ApiResponse<ScheduledPlanningAssignmentResponse> response = apiInstance.ScheduledPlanningIdPatchWithHttpInfo(id, patchScheduledPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchScheduledPlanningRequest** | [**PatchScheduledPlanningRequest?**](PatchScheduledPlanningRequest?.md) |  | [optional]  |

### Return type

[**ScheduledPlanningAssignmentResponse**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanningpost"></a>
# **ScheduledPlanningPost**
> ScheduledPlanningAssignmentResponse ScheduledPlanningPost (PostScheduledPlanningRequest? postScheduledPlanningRequest = null)

Posts a new plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);
            var postScheduledPlanningRequest = new PostScheduledPlanningRequest?(); // PostScheduledPlanningRequest? |  (optional) 

            try
            {
                // Posts a new plan.
                ScheduledPlanningAssignmentResponse result = apiInstance.ScheduledPlanningPost(postScheduledPlanningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Posts a new plan.
    ApiResponse<ScheduledPlanningAssignmentResponse> response = apiInstance.ScheduledPlanningPostWithHttpInfo(postScheduledPlanningRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postScheduledPlanningRequest** | [**PostScheduledPlanningRequest?**](PostScheduledPlanningRequest?.md) |  | [optional]  |

### Return type

[**ScheduledPlanningAssignmentResponse**](ScheduledPlanningAssignmentResponse.md)

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

<a id="scheduledplanningvalidateget"></a>
# **ScheduledPlanningValidateGet**
> ValidateResponse ScheduledPlanningValidateGet ()

Checks whether any resource has been assigned in multiple plans.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ScheduledPlanningValidateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ScheduledPlanningSDK(config);

            try
            {
                // Checks whether any resource has been assigned in multiple plans.
                ValidateResponse result = apiInstance.ScheduledPlanningValidateGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningValidateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduledPlanningValidateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks whether any resource has been assigned in multiple plans.
    ApiResponse<ValidateResponse> response = apiInstance.ScheduledPlanningValidateGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScheduledPlanningSDK.ScheduledPlanningValidateGetWithHttpInfo: " + e.Message);
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

