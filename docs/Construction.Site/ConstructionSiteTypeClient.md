# Simplic.OxS.SDK.Construction.Site.ConstructionSiteTypeClient

All URIs are relative to *https://dev-oxs.simplic.io/construction-site-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConstructionSiteTypeGetAllGet**](ConstructionSiteTypeClient.md#constructionsitetypegetallget) | **GET** /ConstructionSiteType/get-all |  |
| [**ConstructionSiteTypeIdDelete**](ConstructionSiteTypeClient.md#constructionsitetypeiddelete) | **DELETE** /ConstructionSiteType/{id} |  |
| [**ConstructionSiteTypeIdGet**](ConstructionSiteTypeClient.md#constructionsitetypeidget) | **GET** /ConstructionSiteType/{id} |  |
| [**ConstructionSiteTypeIdPut**](ConstructionSiteTypeClient.md#constructionsitetypeidput) | **PUT** /ConstructionSiteType/{id} |  |
| [**ConstructionSiteTypePost**](ConstructionSiteTypeClient.md#constructionsitetypepost) | **POST** /ConstructionSiteType |  |

<a id="constructionsitetypegetallget"></a>
# **ConstructionSiteTypeGetAllGet**
> List&lt;ConstructionSiteTypeModel&gt; ConstructionSiteTypeGetAllGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteTypeGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteTypeClient(config);

            try
            {
                List<ConstructionSiteTypeModel> result = apiInstance.ConstructionSiteTypeGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteTypeGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ConstructionSiteTypeModel>> response = apiInstance.ConstructionSiteTypeGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ConstructionSiteTypeModel&gt;**](ConstructionSiteTypeModel.md)

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

<a id="constructionsitetypeiddelete"></a>
# **ConstructionSiteTypeIdDelete**
> void ConstructionSiteTypeIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteTypeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteTypeClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ConstructionSiteTypeIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteTypeIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ConstructionSiteTypeIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdDeleteWithHttpInfo: " + e.Message);
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

<a id="constructionsitetypeidget"></a>
# **ConstructionSiteTypeIdGet**
> ConstructionSiteTypeModel ConstructionSiteTypeIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteTypeClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ConstructionSiteTypeModel result = apiInstance.ConstructionSiteTypeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteTypeModel> response = apiInstance.ConstructionSiteTypeIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConstructionSiteTypeModel**](ConstructionSiteTypeModel.md)

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

<a id="constructionsitetypeidput"></a>
# **ConstructionSiteTypeIdPut**
> ConstructionSiteTypeModel ConstructionSiteTypeIdPut (Guid id, UpdateConstructionSiteTypeRequest? updateConstructionSiteTypeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteTypeIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteTypeClient(config);
            var id = "id_example";  // Guid | 
            var updateConstructionSiteTypeRequest = new UpdateConstructionSiteTypeRequest?(); // UpdateConstructionSiteTypeRequest? |  (optional) 

            try
            {
                ConstructionSiteTypeModel result = apiInstance.ConstructionSiteTypeIdPut(id, updateConstructionSiteTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteTypeIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteTypeModel> response = apiInstance.ConstructionSiteTypeIdPutWithHttpInfo(id, updateConstructionSiteTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypeIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateConstructionSiteTypeRequest** | [**UpdateConstructionSiteTypeRequest?**](UpdateConstructionSiteTypeRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteTypeModel**](ConstructionSiteTypeModel.md)

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

<a id="constructionsitetypepost"></a>
# **ConstructionSiteTypePost**
> ConstructionSiteTypeModel ConstructionSiteTypePost (CreateConstructionSiteTypeRequest? createConstructionSiteTypeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class ConstructionSiteTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConstructionSiteTypeClient(config);
            var createConstructionSiteTypeRequest = new CreateConstructionSiteTypeRequest?(); // CreateConstructionSiteTypeRequest? |  (optional) 

            try
            {
                ConstructionSiteTypeModel result = apiInstance.ConstructionSiteTypePost(createConstructionSiteTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConstructionSiteTypePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteTypeModel> response = apiInstance.ConstructionSiteTypePostWithHttpInfo(createConstructionSiteTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConstructionSiteTypeClient.ConstructionSiteTypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConstructionSiteTypeRequest** | [**CreateConstructionSiteTypeRequest?**](CreateConstructionSiteTypeRequest?.md) |  | [optional]  |

### Return type

[**ConstructionSiteTypeModel**](ConstructionSiteTypeModel.md)

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

