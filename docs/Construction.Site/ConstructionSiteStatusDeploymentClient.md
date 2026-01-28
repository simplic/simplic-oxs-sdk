# Simplic.OxS.SDK.Construction.Site.ConstructionSiteStatusDeploymentClient

All URIs are relative to *https://dev-oxs.simplic.io/construction-site-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Patch**](ConstructionSiteStatusDeploymentClient.md#constructionsitestatusdeploymentidpatch) | **PATCH** /ConstructionSiteStatusDeployment/{id} |  |
| [**Post**](ConstructionSiteStatusDeploymentClient.md#constructionsitestatusdeploymentpost) | **POST** /ConstructionSiteStatusDeployment |  |

<a id="constructionsitestatusdeploymentidpatch"></a>
# **Patch**
> ConstructionSiteStatusModel Patch (Guid id, UpdateConstructionSiteStatusRequest? updateConstructionSiteStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ConstructionSiteStatusDeploymentClient(config);
            var id = "id_example";  // Guid | 
            var updateConstructionSiteStatusRequest = new UpdateConstructionSiteStatusRequest?(); // UpdateConstructionSiteStatusRequest? |  (optional) 

            try
            {
                ConstructionSiteStatusModel result = apiInstance.Patch(id, updateConstructionSiteStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusDeploymentClient.Patch: " + e.Message);
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
    ApiResponse<ConstructionSiteStatusModel> response = apiInstance.PatchWithHttpInfo(id, updateConstructionSiteStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusDeploymentClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateConstructionSiteStatusRequest** | [**UpdateConstructionSiteStatusRequest?**](UpdateConstructionSiteStatusRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteStatusModel**](ConstructionSiteStatusModel.md)

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

<a id="constructionsitestatusdeploymentpost"></a>
# **Post**
> ConstructionSiteStatusModel Post (CreateConstructionSiteStatusRequest? createConstructionSiteStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ConstructionSiteStatusDeploymentClient(config);
            var createConstructionSiteStatusRequest = new CreateConstructionSiteStatusRequest?(); // CreateConstructionSiteStatusRequest? |  (optional) 

            try
            {
                ConstructionSiteStatusModel result = apiInstance.Post(createConstructionSiteStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusDeploymentClient.Post: " + e.Message);
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
    ApiResponse<ConstructionSiteStatusModel> response = apiInstance.PostWithHttpInfo(createConstructionSiteStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusDeploymentClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConstructionSiteStatusRequest** | [**CreateConstructionSiteStatusRequest?**](CreateConstructionSiteStatusRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteStatusModel**](ConstructionSiteStatusModel.md)

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

