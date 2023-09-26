# Simplic.OxS.SDK.Logistics...LoadingAidTypeSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LoadingAidTypeGetAllGet**](LoadingAidTypeSDK.md#loadingaidtypegetallget) | **GET** /LoadingAidType/get-all | Retrieves all loading aid types. |
| [**LoadingAidTypeIdGet**](LoadingAidTypeSDK.md#loadingaidtypeidget) | **GET** /LoadingAidType/{id} | Retrives the loading aid type with the given id. |
| [**LoadingAidTypeIdPatch**](LoadingAidTypeSDK.md#loadingaidtypeidpatch) | **PATCH** /LoadingAidType/{id} | Patches the loading aid type. |
| [**LoadingAidTypePost**](LoadingAidTypeSDK.md#loadingaidtypepost) | **POST** /LoadingAidType | Creates a new loading aid type. |

<a id="loadingaidtypegetallget"></a>
# **LoadingAidTypeGetAllGet**
> List&lt;LoadingAidTypeResponse&gt; LoadingAidTypeGetAllGet ()

Retrieves all loading aid types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class LoadingAidTypeGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidTypeSDK(config);

            try
            {
                // Retrieves all loading aid types.
                List<LoadingAidTypeResponse> result = apiInstance.LoadingAidTypeGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadingAidTypeGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all loading aid types.
    ApiResponse<List<LoadingAidTypeResponse>> response = apiInstance.LoadingAidTypeGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LoadingAidTypeResponse&gt;**](LoadingAidTypeResponse.md)

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

<a id="loadingaidtypeidget"></a>
# **LoadingAidTypeIdGet**
> LoadingAidTypeResponse LoadingAidTypeIdGet (Guid id)

Retrives the loading aid type with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class LoadingAidTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidTypeSDK(config);
            var id = "id_example";  // Guid | Id of the loading aid type.

            try
            {
                // Retrives the loading aid type with the given id.
                LoadingAidTypeResponse result = apiInstance.LoadingAidTypeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadingAidTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the loading aid type with the given id.
    ApiResponse<LoadingAidTypeResponse> response = apiInstance.LoadingAidTypeIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the loading aid type. |  |

### Return type

[**LoadingAidTypeResponse**](LoadingAidTypeResponse.md)

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

<a id="loadingaidtypeidpatch"></a>
# **LoadingAidTypeIdPatch**
> LoadingAidTypeResponse LoadingAidTypeIdPatch (Guid id, PatchLoadingAidTypeRequest? patchLoadingAidTypeRequest = null)

Patches the loading aid type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class LoadingAidTypeIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidTypeSDK(config);
            var id = "id_example";  // Guid | It of the loading aid to update.
            var patchLoadingAidTypeRequest = new PatchLoadingAidTypeRequest?(); // PatchLoadingAidTypeRequest? | A patch loading aid request. (optional) 

            try
            {
                // Patches the loading aid type.
                LoadingAidTypeResponse result = apiInstance.LoadingAidTypeIdPatch(id, patchLoadingAidTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadingAidTypeIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches the loading aid type.
    ApiResponse<LoadingAidTypeResponse> response = apiInstance.LoadingAidTypeIdPatchWithHttpInfo(id, patchLoadingAidTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypeIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | It of the loading aid to update. |  |
| **patchLoadingAidTypeRequest** | [**PatchLoadingAidTypeRequest?**](PatchLoadingAidTypeRequest?.md) | A patch loading aid request. | [optional]  |

### Return type

[**LoadingAidTypeResponse**](LoadingAidTypeResponse.md)

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

<a id="loadingaidtypepost"></a>
# **LoadingAidTypePost**
> LoadingAidTypeResponse LoadingAidTypePost (CreateLoadingAidTypeRequest? createLoadingAidTypeRequest = null)

Creates a new loading aid type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class LoadingAidTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidTypeSDK(config);
            var createLoadingAidTypeRequest = new CreateLoadingAidTypeRequest?(); // CreateLoadingAidTypeRequest? | A create loading aid type request object. (optional) 

            try
            {
                // Creates a new loading aid type.
                LoadingAidTypeResponse result = apiInstance.LoadingAidTypePost(createLoadingAidTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadingAidTypePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new loading aid type.
    ApiResponse<LoadingAidTypeResponse> response = apiInstance.LoadingAidTypePostWithHttpInfo(createLoadingAidTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidTypeSDK.LoadingAidTypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLoadingAidTypeRequest** | [**CreateLoadingAidTypeRequest?**](CreateLoadingAidTypeRequest?.md) | A create loading aid type request object. | [optional]  |

### Return type

[**LoadingAidTypeResponse**](LoadingAidTypeResponse.md)

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

