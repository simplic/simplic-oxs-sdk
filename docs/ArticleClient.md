# Simplic.OxS.SDK.Article.ArticleClient

All URIs are relative to *https://dev-oxs.simplic.io/article-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArticleGetArticleByBarcodeGet**](ArticleClient.md#articlegetarticlebybarcodeget) | **GET** /Article/get-article-by-barcode |  |
| [**ArticleGetArticleByNumberGet**](ArticleClient.md#articlegetarticlebynumberget) | **GET** /Article/get-article-by-number |  |
| [**ArticleGetArticlesByGroupidGet**](ArticleClient.md#articlegetarticlesbygroupidget) | **GET** /Article/get-articles-by-groupid |  |
| [**ArticleGetArticlesByNameGet**](ArticleClient.md#articlegetarticlesbynameget) | **GET** /Article/get-articles-by-name |  |
| [**ArticleIdDelete**](ArticleClient.md#articleiddelete) | **DELETE** /Article/{id} |  |
| [**ArticleIdGet**](ArticleClient.md#articleidget) | **GET** /Article/{id} |  |
| [**ArticleIdPut**](ArticleClient.md#articleidput) | **PUT** /Article/{id} |  |
| [**ArticlePost**](ArticleClient.md#articlepost) | **POST** /Article |  |

<a id="articlegetarticlebybarcodeget"></a>
# **ArticleGetArticleByBarcodeGet**
> ArticleModel ArticleGetArticleByBarcodeGet (string? barcode = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGetArticleByBarcodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var barcode = "barcode_example";  // string? |  (optional) 

            try
            {
                ArticleModel result = apiInstance.ArticleGetArticleByBarcodeGet(barcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleGetArticleByBarcodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGetArticleByBarcodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleModel> response = apiInstance.ArticleGetArticleByBarcodeGetWithHttpInfo(barcode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleGetArticleByBarcodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barcode** | **string?** |  | [optional]  |

### Return type

[**ArticleModel**](ArticleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articlegetarticlebynumberget"></a>
# **ArticleGetArticleByNumberGet**
> ArticleModel ArticleGetArticleByNumberGet (string? articleNumber = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGetArticleByNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var articleNumber = "articleNumber_example";  // string? |  (optional) 

            try
            {
                ArticleModel result = apiInstance.ArticleGetArticleByNumberGet(articleNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleGetArticleByNumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGetArticleByNumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleModel> response = apiInstance.ArticleGetArticleByNumberGetWithHttpInfo(articleNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleGetArticleByNumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **articleNumber** | **string?** |  | [optional]  |

### Return type

[**ArticleModel**](ArticleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articlegetarticlesbygroupidget"></a>
# **ArticleGetArticlesByGroupidGet**
> List&lt;ArticleModel&gt; ArticleGetArticlesByGroupidGet (Guid? groupId = null, int? skip = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGetArticlesByGroupidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var groupId = "groupId_example";  // Guid? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List<ArticleModel> result = apiInstance.ArticleGetArticlesByGroupidGet(groupId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleGetArticlesByGroupidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGetArticlesByGroupidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ArticleModel>> response = apiInstance.ArticleGetArticlesByGroupidGetWithHttpInfo(groupId, skip, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleGetArticlesByGroupidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**List&lt;ArticleModel&gt;**](ArticleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articlegetarticlesbynameget"></a>
# **ArticleGetArticlesByNameGet**
> List&lt;ArticleModel&gt; ArticleGetArticlesByNameGet (string? searchName = null, int? skip = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleGetArticlesByNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var searchName = "searchName_example";  // string? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                List<ArticleModel> result = apiInstance.ArticleGetArticlesByNameGet(searchName, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleGetArticlesByNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleGetArticlesByNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ArticleModel>> response = apiInstance.ArticleGetArticlesByNameGetWithHttpInfo(searchName, skip, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleGetArticlesByNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchName** | **string?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**List&lt;ArticleModel&gt;**](ArticleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="articleiddelete"></a>
# **ArticleIdDelete**
> void ArticleIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ArticleIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ArticleIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleIdDeleteWithHttpInfo: " + e.Message);
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

<a id="articleidget"></a>
# **ArticleIdGet**
> ArticleModel ArticleIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ArticleModel result = apiInstance.ArticleIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleModel> response = apiInstance.ArticleIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ArticleModel**](ArticleModel.md)

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

<a id="articleidput"></a>
# **ArticleIdPut**
> ArticleModel ArticleIdPut (Guid id, UpdateArticleRequest? updateArticleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticleIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var id = "id_example";  // Guid | 
            var updateArticleRequest = new UpdateArticleRequest?(); // UpdateArticleRequest? |  (optional) 

            try
            {
                ArticleModel result = apiInstance.ArticleIdPut(id, updateArticleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticleIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticleIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleModel> response = apiInstance.ArticleIdPutWithHttpInfo(id, updateArticleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticleIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateArticleRequest** | [**UpdateArticleRequest?**](UpdateArticleRequest?.md) |  | [optional]  |

### Return type

[**ArticleModel**](ArticleModel.md)

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

<a id="articlepost"></a>
# **ArticlePost**
> ArticleModel ArticlePost (CreateArticleRequest? createArticleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class ArticlePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArticleClient(config);
            var createArticleRequest = new CreateArticleRequest?(); // CreateArticleRequest? |  (optional) 

            try
            {
                ArticleModel result = apiInstance.ArticlePost(createArticleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArticleClient.ArticlePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArticlePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ArticleModel> response = apiInstance.ArticlePostWithHttpInfo(createArticleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArticleClient.ArticlePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createArticleRequest** | [**CreateArticleRequest?**](CreateArticleRequest?.md) |  | [optional]  |

### Return type

[**ArticleModel**](ArticleModel.md)

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

