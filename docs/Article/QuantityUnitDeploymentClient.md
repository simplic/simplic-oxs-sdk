# Simplic.OxS.SDK.Article.QuantityUnitDeploymentClient

All URIs are relative to *https://dev-oxs.simplic.io/article-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Patch**](QuantityUnitDeploymentClient.md#quantityunitdeploymentidpatch) | **PATCH** /QuantityUnitDeployment/{id} |  |
| [**Post**](QuantityUnitDeploymentClient.md#quantityunitdeploymentpost) | **POST** /QuantityUnitDeployment |  |

<a id="quantityunitdeploymentidpatch"></a>
# **Patch**
> QuantityUnitModel Patch (Guid id, UpdateQuantityUnitRequest? updateQuantityUnitRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Article;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuantityUnitDeploymentClient(config);
            var id = "id_example";  // Guid | 
            var updateQuantityUnitRequest = new UpdateQuantityUnitRequest?(); // UpdateQuantityUnitRequest? |  (optional) 

            try
            {
                QuantityUnitModel result = apiInstance.Patch(id, updateQuantityUnitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuantityUnitDeploymentClient.Patch: " + e.Message);
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
    ApiResponse<QuantityUnitModel> response = apiInstance.PatchWithHttpInfo(id, updateQuantityUnitRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuantityUnitDeploymentClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateQuantityUnitRequest** | [**UpdateQuantityUnitRequest?**](UpdateQuantityUnitRequest?.md) |  | [optional]  |

### Return type

[**QuantityUnitModel**](QuantityUnitModel.md)

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

<a id="quantityunitdeploymentpost"></a>
# **Post**
> QuantityUnitModel Post (CreateQuantityUnitRequest? createQuantityUnitRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Article;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuantityUnitDeploymentClient(config);
            var createQuantityUnitRequest = new CreateQuantityUnitRequest?(); // CreateQuantityUnitRequest? |  (optional) 

            try
            {
                QuantityUnitModel result = apiInstance.Post(createQuantityUnitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuantityUnitDeploymentClient.Post: " + e.Message);
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
    ApiResponse<QuantityUnitModel> response = apiInstance.PostWithHttpInfo(createQuantityUnitRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuantityUnitDeploymentClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createQuantityUnitRequest** | [**CreateQuantityUnitRequest?**](CreateQuantityUnitRequest?.md) |  | [optional]  |

### Return type

[**QuantityUnitModel**](QuantityUnitModel.md)

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

