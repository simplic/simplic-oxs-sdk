# Simplic.OxS.SDK.Article.ArticleGroupClient

All URIs are relative to *https://dev-oxs.simplic.io/article-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArticleGroupIdDelete**](ArticleGroupClient.md#articlegroupiddelete) | **DELETE** /ArticleGroup/{id} |  |
| [**ArticleGroupIdGet**](ArticleGroupClient.md#articlegroupidget) | **GET** /ArticleGroup/{id} |  |
| [**ArticleGroupIdPut**](ArticleGroupClient.md#articlegroupidput) | **PUT** /ArticleGroup/{id} |  |
| [**ArticleGroupPost**](ArticleGroupClient.md#articlegrouppost) | **POST** /ArticleGroup |  |

<a id="articlegroupiddelete"></a>
# **ArticleGroupIdDelete**
> void ArticleGroupIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleGroupClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ArticleGroupIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ArticleGroupIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdDeleteWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articlegroupidget"></a>
# **ArticleGroupIdGet**
> ArticleGroupModel ArticleGroupIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGroupIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleGroupClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ArticleGroupModel result = apiInstance.ArticleGroupIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleGroupModel> response = apiInstance.ArticleGroupIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ArticleGroupModel**](ArticleGroupModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articlegroupidput"></a>
# **ArticleGroupIdPut**
> ArticleGroupModel ArticleGroupIdPut (Guid id, UpdateArticleGroupRequest? updateArticleGroupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGroupIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleGroupClient(config);
            var id = "id_example";  // Guid | 
            var updateArticleGroupRequest = new UpdateArticleGroupRequest?(); // UpdateArticleGroupRequest? |  (optional) 

            try
            {
                ArticleGroupModel result = apiInstance.ArticleGroupIdPut(id, updateArticleGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGroupIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleGroupModel> response = apiInstance.ArticleGroupIdPutWithHttpInfo(id, updateArticleGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateArticleGroupRequest** | [**UpdateArticleGroupRequest?**](UpdateArticleGroupRequest?.md) |  | [optional]  |

### Return type

[**ArticleGroupModel**](ArticleGroupModel.md)

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

<a id="articlegrouppost"></a>
# **ArticleGroupPost**
> ArticleGroupModel ArticleGroupPost (CreateArticleGroupRequest? createArticleGroupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleGroupClient(config);
            var createArticleGroupRequest = new CreateArticleGroupRequest?(); // CreateArticleGroupRequest? |  (optional) 

            try
            {
                ArticleGroupModel result = apiInstance.ArticleGroupPost(createArticleGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleGroupModel> response = apiInstance.ArticleGroupPostWithHttpInfo(createArticleGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleGroupClient.ArticleGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createArticleGroupRequest** | [**CreateArticleGroupRequest?**](CreateArticleGroupRequest?.md) |  | [optional]  |

### Return type

[**ArticleGroupModel**](ArticleGroupModel.md)

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

