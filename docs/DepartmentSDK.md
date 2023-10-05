# Simplic.OxS.SDK.Logistics.DepartmentSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DepartmentGetByNameNameGet**](DepartmentSDK.md#departmentgetbynamenameget) | **GET** /Department/get-by-name/{name} | Gets departments with given name. |
| [**DepartmentGetByOrderOrderIdGet**](DepartmentSDK.md#departmentgetbyorderorderidget) | **GET** /Department/get-by-order/{orderId} | Gets departments with given order id. |
| [**DepartmentIdDelete**](DepartmentSDK.md#departmentiddelete) | **DELETE** /Department/{id} | Deletes department matching given id. |
| [**DepartmentIdGet**](DepartmentSDK.md#departmentidget) | **GET** /Department/{id} | Gets department matching given id. |
| [**DepartmentIdPatch**](DepartmentSDK.md#departmentidpatch) | **PATCH** /Department/{id} | Patches department matching given id. |
| [**DepartmentPost**](DepartmentSDK.md#departmentpost) | **POST** /Department | Creates a new department. |

<a id="departmentgetbynamenameget"></a>
# **DepartmentGetByNameNameGet**
> List&lt;DepartmentResponse&gt; DepartmentGetByNameNameGet (string name)

Gets departments with given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentGetByNameNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var name = "name_example";  // string | 

            try
            {
                // Gets departments with given name.
                List<DepartmentResponse> result = apiInstance.DepartmentGetByNameNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentGetByNameNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentGetByNameNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets departments with given name.
    ApiResponse<List<DepartmentResponse>> response = apiInstance.DepartmentGetByNameNameGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentGetByNameNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**List&lt;DepartmentResponse&gt;**](DepartmentResponse.md)

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

<a id="departmentgetbyorderorderidget"></a>
# **DepartmentGetByOrderOrderIdGet**
> List&lt;DepartmentResponse&gt; DepartmentGetByOrderOrderIdGet (int orderId)

Gets departments with given order id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentGetByOrderOrderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var orderId = 56;  // int | 

            try
            {
                // Gets departments with given order id.
                List<DepartmentResponse> result = apiInstance.DepartmentGetByOrderOrderIdGet(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentGetByOrderOrderIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentGetByOrderOrderIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets departments with given order id.
    ApiResponse<List<DepartmentResponse>> response = apiInstance.DepartmentGetByOrderOrderIdGetWithHttpInfo(orderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentGetByOrderOrderIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **int** |  |  |

### Return type

[**List&lt;DepartmentResponse&gt;**](DepartmentResponse.md)

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

<a id="departmentiddelete"></a>
# **DepartmentIdDelete**
> void DepartmentIdDelete (Guid id)

Deletes department matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deletes department matching given id.
                apiInstance.DepartmentIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes department matching given id.
    apiInstance.DepartmentIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentIdDeleteWithHttpInfo: " + e.Message);
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

<a id="departmentidget"></a>
# **DepartmentIdGet**
> DepartmentResponse DepartmentIdGet (Guid id)

Gets department matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Gets department matching given id.
                DepartmentResponse result = apiInstance.DepartmentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets department matching given id.
    ApiResponse<DepartmentResponse> response = apiInstance.DepartmentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**DepartmentResponse**](DepartmentResponse.md)

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

<a id="departmentidpatch"></a>
# **DepartmentIdPatch**
> DepartmentResponse DepartmentIdPatch (Guid id, PatchDepartmentRequest? patchDepartmentRequest = null)

Patches department matching given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var id = "id_example";  // Guid | 
            var patchDepartmentRequest = new PatchDepartmentRequest?(); // PatchDepartmentRequest? |  (optional) 

            try
            {
                // Patches department matching given id.
                DepartmentResponse result = apiInstance.DepartmentIdPatch(id, patchDepartmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches department matching given id.
    ApiResponse<DepartmentResponse> response = apiInstance.DepartmentIdPatchWithHttpInfo(id, patchDepartmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchDepartmentRequest** | [**PatchDepartmentRequest?**](PatchDepartmentRequest?.md) |  | [optional]  |

### Return type

[**DepartmentResponse**](DepartmentResponse.md)

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
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="departmentpost"></a>
# **DepartmentPost**
> DepartmentResponse DepartmentPost (PostDepartmentRequest? postDepartmentRequest = null)

Creates a new department.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DepartmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DepartmentSDK(config);
            var postDepartmentRequest = new PostDepartmentRequest?(); // PostDepartmentRequest? |  (optional) 

            try
            {
                // Creates a new department.
                DepartmentResponse result = apiInstance.DepartmentPost(postDepartmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentSDK.DepartmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new department.
    ApiResponse<DepartmentResponse> response = apiInstance.DepartmentPostWithHttpInfo(postDepartmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentSDK.DepartmentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postDepartmentRequest** | [**PostDepartmentRequest?**](PostDepartmentRequest?.md) |  | [optional]  |

### Return type

[**DepartmentResponse**](DepartmentResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

