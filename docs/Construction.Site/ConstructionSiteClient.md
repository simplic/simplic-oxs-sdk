# Simplic.OxS.SDK.Construction.Site.ConstructionSiteClient

All URIs are relative to *https://dev-oxs.simplic.io/construction-site-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConstructionSiteGetAllGet**](ConstructionSiteClient.md#constructionsitegetallget) | **GET** /ConstructionSite/get-all |  |
| [**ConstructionSiteIdDelete**](ConstructionSiteClient.md#constructionsiteiddelete) | **DELETE** /ConstructionSite/{id} |  |
| [**ConstructionSiteIdGet**](ConstructionSiteClient.md#constructionsiteidget) | **GET** /ConstructionSite/{id} |  |
| [**ConstructionSiteIdPut**](ConstructionSiteClient.md#constructionsiteidput) | **PUT** /ConstructionSite/{id} |  |
| [**ConstructionSitePost**](ConstructionSiteClient.md#constructionsitepost) | **POST** /ConstructionSite |  |

<a id="constructionsitegetallget"></a>
# **ConstructionSiteGetAllGet**
> List&lt;ConstructionSiteModel&gt; ConstructionSiteGetAllGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteClient(config);

            try
            {
                List<ConstructionSiteModel> result = apiInstance.ConstructionSiteGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ConstructionSiteModel>> response = apiInstance.ConstructionSiteGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ConstructionSiteModel&gt;**](ConstructionSiteModel.md)

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

<a id="constructionsiteiddelete"></a>
# **ConstructionSiteIdDelete**
> void ConstructionSiteIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ConstructionSiteIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ConstructionSiteIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdDeleteWithHttpInfo: " + e.Message);
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

<a id="constructionsiteidget"></a>
# **ConstructionSiteIdGet**
> ConstructionSiteModel ConstructionSiteIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ConstructionSiteModel result = apiInstance.ConstructionSiteIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteModel> response = apiInstance.ConstructionSiteIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConstructionSiteModel**](ConstructionSiteModel.md)

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

<a id="constructionsiteidput"></a>
# **ConstructionSiteIdPut**
> ConstructionSiteModel ConstructionSiteIdPut (Guid id, UpdateConstructionSiteRequest? updateConstructionSiteRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteClient(config);
            var id = "id_example";  // Guid | 
            var updateConstructionSiteRequest = new UpdateConstructionSiteRequest?(); // UpdateConstructionSiteRequest? |  (optional) 

            try
            {
                ConstructionSiteModel result = apiInstance.ConstructionSiteIdPut(id, updateConstructionSiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteModel> response = apiInstance.ConstructionSiteIdPutWithHttpInfo(id, updateConstructionSiteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSiteIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateConstructionSiteRequest** | [**UpdateConstructionSiteRequest?**](UpdateConstructionSiteRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteModel**](ConstructionSiteModel.md)

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

<a id="constructionsitepost"></a>
# **ConstructionSitePost**
> ConstructionSiteModel ConstructionSitePost (CreateConstructionSiteRequest? createConstructionSiteRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteClient(config);
            var createConstructionSiteRequest = new CreateConstructionSiteRequest?(); // CreateConstructionSiteRequest? |  (optional) 

            try
            {
                ConstructionSiteModel result = apiInstance.ConstructionSitePost(createConstructionSiteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteModel> response = apiInstance.ConstructionSitePostWithHttpInfo(createConstructionSiteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteClient.ConstructionSitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConstructionSiteRequest** | [**CreateConstructionSiteRequest?**](CreateConstructionSiteRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteModel**](ConstructionSiteModel.md)

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

