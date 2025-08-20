# Simplic.OxS.SDK.Storage.Management.LoadingAidVoucherProviderDeploymentClient

All URIs are relative to *https://dev-oxs.simplic.io/storage-management-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Patch**](LoadingAidVoucherProviderDeploymentClient.md#loadingaidvoucherproviderdeploymentidpatch) | **PATCH** /LoadingAidVoucherProviderDeployment/{id} |  |
| [**Post**](LoadingAidVoucherProviderDeploymentClient.md#loadingaidvoucherproviderdeploymentpost) | **POST** /LoadingAidVoucherProviderDeployment |  |

<a id="loadingaidvoucherproviderdeploymentidpatch"></a>
# **Patch**
> LoadingAidVoucherProviderResponse Patch (Guid id, PatchLoadingAidVoucherProviderRequest? patchLoadingAidVoucherProviderRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class PatchExample
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

            var apiInstance = new LoadingAidVoucherProviderDeploymentClient(config);
            var id = "id_example";  // Guid | 
            var patchLoadingAidVoucherProviderRequest = new PatchLoadingAidVoucherProviderRequest?(); // PatchLoadingAidVoucherProviderRequest? |  (optional) 

            try
            {
                LoadingAidVoucherProviderResponse result = apiInstance.Patch(id, patchLoadingAidVoucherProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderDeploymentClient.Patch: " + e.Message);
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
    ApiResponse<LoadingAidVoucherProviderResponse> response = apiInstance.PatchWithHttpInfo(id, patchLoadingAidVoucherProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderDeploymentClient.PatchWithHttpInfo: " + e.Message);
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

<a id="loadingaidvoucherproviderdeploymentpost"></a>
# **Post**
> LoadingAidVoucherProviderResponse Post (CreateLoadingAidVoucherProviderRequest? createLoadingAidVoucherProviderRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Storage.Management;

namespace Example
{
    public class PostExample
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

            var apiInstance = new LoadingAidVoucherProviderDeploymentClient(config);
            var createLoadingAidVoucherProviderRequest = new CreateLoadingAidVoucherProviderRequest?(); // CreateLoadingAidVoucherProviderRequest? |  (optional) 

            try
            {
                LoadingAidVoucherProviderResponse result = apiInstance.Post(createLoadingAidVoucherProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidVoucherProviderDeploymentClient.Post: " + e.Message);
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
    ApiResponse<LoadingAidVoucherProviderResponse> response = apiInstance.PostWithHttpInfo(createLoadingAidVoucherProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidVoucherProviderDeploymentClient.PostWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

