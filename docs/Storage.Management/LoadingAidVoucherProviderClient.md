# Simplic.OxS.SDK.Storage.Management.LoadingAidVoucherProviderClient

All URIs are relative to *https://dev-oxs.simplic.io/storage-management-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidVoucherProviderIdDelete**](LoadingAidVoucherProviderClient.md#aidvoucherprovideriddelete) | **DELETE** /loading-aid-voucher-provider/{id} |  |
| [**AidVoucherProviderIdGet**](LoadingAidVoucherProviderClient.md#aidvoucherprovideridget) | **GET** /loading-aid-voucher-provider/{id} |  |
| [**AidVoucherProviderIdPatch**](LoadingAidVoucherProviderClient.md#aidvoucherprovideridpatch) | **PATCH** /loading-aid-voucher-provider/{id} |  |
| [**AidVoucherProviderPost**](LoadingAidVoucherProviderClient.md#aidvoucherproviderpost) | **POST** /loading-aid-voucher-provider |  |

<a id="aidvoucherprovideriddelete"></a>
# **AidVoucherProviderIdDelete**
> void AidVoucherProviderIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class AidVoucherProviderIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidVoucherProviderClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.AidVoucherProviderIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidVoucherProviderIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidVoucherProviderIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdDeleteWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aidvoucherprovideridget"></a>
# **AidVoucherProviderIdGet**
> LoadingAidVoucherProviderResponse AidVoucherProviderIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class AidVoucherProviderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidVoucherProviderClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                LoadingAidVoucherProviderResponse result = apiInstance.AidVoucherProviderIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidVoucherProviderIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoadingAidVoucherProviderResponse> response = apiInstance.AidVoucherProviderIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**LoadingAidVoucherProviderResponse**](LoadingAidVoucherProviderResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aidvoucherprovideridpatch"></a>
# **AidVoucherProviderIdPatch**
> LoadingAidVoucherProviderResponse AidVoucherProviderIdPatch (Guid id, PatchLoadingAidVoucherProviderRequest? patchLoadingAidVoucherProviderRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class AidVoucherProviderIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidVoucherProviderClient(config);
            var id = "id_example";  // Guid | 
            var patchLoadingAidVoucherProviderRequest = new PatchLoadingAidVoucherProviderRequest?(); // PatchLoadingAidVoucherProviderRequest? |  (optional) 

            try
            {
                LoadingAidVoucherProviderResponse result = apiInstance.AidVoucherProviderIdPatch(id, patchLoadingAidVoucherProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidVoucherProviderIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoadingAidVoucherProviderResponse> response = apiInstance.AidVoucherProviderIdPatchWithHttpInfo(id, patchLoadingAidVoucherProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchLoadingAidVoucherProviderRequest** | [**PatchLoadingAidVoucherProviderRequest?**](PatchLoadingAidVoucherProviderRequest?.md) |  | [optional]  |

### Return type

[**LoadingAidVoucherProviderResponse**](LoadingAidVoucherProviderResponse.md)

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

<a id="aidvoucherproviderpost"></a>
# **AidVoucherProviderPost**
> LoadingAidVoucherProviderResponse AidVoucherProviderPost (CreateLoadingAidVoucherProviderRequest? createLoadingAidVoucherProviderRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class AidVoucherProviderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/storage-management-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LoadingAidVoucherProviderClient(config);
            var createLoadingAidVoucherProviderRequest = new CreateLoadingAidVoucherProviderRequest?(); // CreateLoadingAidVoucherProviderRequest? |  (optional) 

            try
            {
                LoadingAidVoucherProviderResponse result = apiInstance.AidVoucherProviderPost(createLoadingAidVoucherProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidVoucherProviderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoadingAidVoucherProviderResponse> response = apiInstance.AidVoucherProviderPostWithHttpInfo(createLoadingAidVoucherProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderClient.AidVoucherProviderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLoadingAidVoucherProviderRequest** | [**CreateLoadingAidVoucherProviderRequest?**](CreateLoadingAidVoucherProviderRequest?.md) |  | [optional]  |

### Return type

[**LoadingAidVoucherProviderResponse**](LoadingAidVoucherProviderResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

