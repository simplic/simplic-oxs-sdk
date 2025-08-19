# Simplic.OxS.SDK.Storage.Management.LoadingAidBookingQualityTypeDeploymentClient

All URIs are relative to *https://dev-oxs.simplic.io/storage-management-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Patch**](LoadingAidBookingQualityTypeDeploymentClient.md#loadingaidbookingqualitytypedeploymentidpatch) | **PATCH** /LoadingAidBookingQualityTypeDeployment/{id} |  |
| [**Post**](LoadingAidBookingQualityTypeDeploymentClient.md#loadingaidbookingqualitytypedeploymentpost) | **POST** /LoadingAidBookingQualityTypeDeployment |  |

<a id="loadingaidbookingqualitytypedeploymentidpatch"></a>
# **Patch**
> LoadingAidBookingQualityTypeResponse Patch (Guid id, PatchLoadingAidBookingQualityTypeRequest? patchLoadingAidBookingQualityTypeRequest = null)



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

            var apiInstance = new LoadingAidBookingQualityTypeDeploymentClient(config);
            var id = "id_example";  // Guid | 
            var patchLoadingAidBookingQualityTypeRequest = new PatchLoadingAidBookingQualityTypeRequest?(); // PatchLoadingAidBookingQualityTypeRequest? |  (optional) 

            try
            {
                LoadingAidBookingQualityTypeResponse result = apiInstance.Patch(id, patchLoadingAidBookingQualityTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidBookingQualityTypeDeploymentClient.Patch: " + e.Message);
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
    ApiResponse<LoadingAidBookingQualityTypeResponse> response = apiInstance.PatchWithHttpInfo(id, patchLoadingAidBookingQualityTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidBookingQualityTypeDeploymentClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchLoadingAidBookingQualityTypeRequest** | [**PatchLoadingAidBookingQualityTypeRequest?**](PatchLoadingAidBookingQualityTypeRequest?.md) |  | [optional]  |

### Return type

[**LoadingAidBookingQualityTypeResponse**](LoadingAidBookingQualityTypeResponse.md)

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

<a id="loadingaidbookingqualitytypedeploymentpost"></a>
# **Post**
> LoadingAidBookingQualityTypeResponse Post (CreateLoadingAidBookingQualityTypeRequest? createLoadingAidBookingQualityTypeRequest = null)



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

            var apiInstance = new LoadingAidBookingQualityTypeDeploymentClient(config);
            var createLoadingAidBookingQualityTypeRequest = new CreateLoadingAidBookingQualityTypeRequest?(); // CreateLoadingAidBookingQualityTypeRequest? |  (optional) 

            try
            {
                LoadingAidBookingQualityTypeResponse result = apiInstance.Post(createLoadingAidBookingQualityTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoadingAidBookingQualityTypeDeploymentClient.Post: " + e.Message);
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
    ApiResponse<LoadingAidBookingQualityTypeResponse> response = apiInstance.PostWithHttpInfo(createLoadingAidBookingQualityTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoadingAidBookingQualityTypeDeploymentClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLoadingAidBookingQualityTypeRequest** | [**CreateLoadingAidBookingQualityTypeRequest?**](CreateLoadingAidBookingQualityTypeRequest?.md) |  | [optional]  |

### Return type

[**LoadingAidBookingQualityTypeResponse**](LoadingAidBookingQualityTypeResponse.md)

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

