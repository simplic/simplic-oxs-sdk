# Simplic.OxS.SDK.Construction.Site.ConstructionSiteStatusClient

All URIs are relative to *https://dev-oxs.simplic.io/construction-site-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConstructionSiteStatusGetAllGet**](ConstructionSiteStatusClient.md#constructionsitestatusgetallget) | **GET** /ConstructionSiteStatus/get-all |  |
| [**ConstructionSiteStatusIdDelete**](ConstructionSiteStatusClient.md#constructionsitestatusiddelete) | **DELETE** /ConstructionSiteStatus/{id} |  |
| [**ConstructionSiteStatusIdGet**](ConstructionSiteStatusClient.md#constructionsitestatusidget) | **GET** /ConstructionSiteStatus/{id} |  |
| [**ConstructionSiteStatusIdPut**](ConstructionSiteStatusClient.md#constructionsitestatusidput) | **PUT** /ConstructionSiteStatus/{id} |  |
| [**ConstructionSiteStatusPost**](ConstructionSiteStatusClient.md#constructionsitestatuspost) | **POST** /ConstructionSiteStatus |  |

<a id="constructionsitestatusgetallget"></a>
# **ConstructionSiteStatusGetAllGet**
> List&lt;ConstructionSiteStatusModel&gt; ConstructionSiteStatusGetAllGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteStatusGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteStatusClient(config);

            try
            {
                List<ConstructionSiteStatusModel> result = apiInstance.ConstructionSiteStatusGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteStatusGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ConstructionSiteStatusModel>> response = apiInstance.ConstructionSiteStatusGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ConstructionSiteStatusModel&gt;**](ConstructionSiteStatusModel.md)

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

<a id="constructionsitestatusiddelete"></a>
# **ConstructionSiteStatusIdDelete**
> void ConstructionSiteStatusIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteStatusIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteStatusClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ConstructionSiteStatusIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteStatusIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ConstructionSiteStatusIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdDeleteWithHttpInfo: " + e.Message);
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

<a id="constructionsitestatusidget"></a>
# **ConstructionSiteStatusIdGet**
> ConstructionSiteStatusModel ConstructionSiteStatusIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteStatusIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteStatusClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ConstructionSiteStatusModel result = apiInstance.ConstructionSiteStatusIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteStatusIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteStatusModel> response = apiInstance.ConstructionSiteStatusIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConstructionSiteStatusModel**](ConstructionSiteStatusModel.md)

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

<a id="constructionsitestatusidput"></a>
# **ConstructionSiteStatusIdPut**
> ConstructionSiteStatusModel ConstructionSiteStatusIdPut (Guid id, UpdateConstructionSiteStatusRequest? updateConstructionSiteStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteStatusIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteStatusClient(config);
            var id = "id_example";  // Guid | 
            var updateConstructionSiteStatusRequest = new UpdateConstructionSiteStatusRequest?(); // UpdateConstructionSiteStatusRequest? |  (optional) 

            try
            {
                ConstructionSiteStatusModel result = apiInstance.ConstructionSiteStatusIdPut(id, updateConstructionSiteStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteStatusIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteStatusModel> response = apiInstance.ConstructionSiteStatusIdPutWithHttpInfo(id, updateConstructionSiteStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusIdPutWithHttpInfo: " + e.Message);
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

<a id="constructionsitestatuspost"></a>
# **ConstructionSiteStatusPost**
> ConstructionSiteStatusModel ConstructionSiteStatusPost (CreateConstructionSiteStatusRequest? createConstructionSiteStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteStatusClient(config);
            var createConstructionSiteStatusRequest = new CreateConstructionSiteStatusRequest?(); // CreateConstructionSiteStatusRequest? |  (optional) 

            try
            {
                ConstructionSiteStatusModel result = apiInstance.ConstructionSiteStatusPost(createConstructionSiteStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteStatusPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteStatusModel> response = apiInstance.ConstructionSiteStatusPostWithHttpInfo(createConstructionSiteStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteStatusClient.ConstructionSiteStatusPostWithHttpInfo: " + e.Message);
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

