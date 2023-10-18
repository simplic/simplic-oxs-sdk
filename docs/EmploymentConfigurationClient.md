# Simplic.OxS.SDK.Telematic.EmploymentConfigurationClient

All URIs are relative to *https://dev-oxs.simplic.io/telematic-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmploymentConfigurationGetForEmploymentIdGet**](EmploymentConfigurationClient.md#employmentconfigurationgetforemploymentidget) | **GET** /EmploymentConfiguration/get-for-employment/{id} |  |
| [**EmploymentConfigurationIdDelete**](EmploymentConfigurationClient.md#employmentconfigurationiddelete) | **DELETE** /EmploymentConfiguration/{id} |  |
| [**EmploymentConfigurationIdGet**](EmploymentConfigurationClient.md#employmentconfigurationidget) | **GET** /EmploymentConfiguration/{id} |  |
| [**EmploymentConfigurationIdPatch**](EmploymentConfigurationClient.md#employmentconfigurationidpatch) | **PATCH** /EmploymentConfiguration/{id} |  |
| [**EmploymentConfigurationPost**](EmploymentConfigurationClient.md#employmentconfigurationpost) | **POST** /EmploymentConfiguration |  |

<a id="employmentconfigurationgetforemploymentidget"></a>
# **EmploymentConfigurationGetForEmploymentIdGet**
> List&lt;EmploymentConfigurationModel&gt; EmploymentConfigurationGetForEmploymentIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class EmploymentConfigurationGetForEmploymentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmploymentConfigurationClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                List<EmploymentConfigurationModel> result = apiInstance.EmploymentConfigurationGetForEmploymentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationGetForEmploymentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmploymentConfigurationGetForEmploymentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EmploymentConfigurationModel>> response = apiInstance.EmploymentConfigurationGetForEmploymentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationGetForEmploymentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**List&lt;EmploymentConfigurationModel&gt;**](EmploymentConfigurationModel.md)

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

<a id="employmentconfigurationiddelete"></a>
# **EmploymentConfigurationIdDelete**
> Object EmploymentConfigurationIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class EmploymentConfigurationIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmploymentConfigurationClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                Object result = apiInstance.EmploymentConfigurationIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmploymentConfigurationIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.EmploymentConfigurationIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

**Object**

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

<a id="employmentconfigurationidget"></a>
# **EmploymentConfigurationIdGet**
> EmploymentConfigurationModel EmploymentConfigurationIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class EmploymentConfigurationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmploymentConfigurationClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                EmploymentConfigurationModel result = apiInstance.EmploymentConfigurationIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmploymentConfigurationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmploymentConfigurationModel> response = apiInstance.EmploymentConfigurationIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**EmploymentConfigurationModel**](EmploymentConfigurationModel.md)

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

<a id="employmentconfigurationidpatch"></a>
# **EmploymentConfigurationIdPatch**
> EmploymentConfigurationModel EmploymentConfigurationIdPatch (Guid id, PatchEmploymentConfigurationRequest? patchEmploymentConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class EmploymentConfigurationIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmploymentConfigurationClient(config);
            var id = "id_example";  // Guid | 
            var patchEmploymentConfigurationRequest = new PatchEmploymentConfigurationRequest?(); // PatchEmploymentConfigurationRequest? |  (optional) 

            try
            {
                EmploymentConfigurationModel result = apiInstance.EmploymentConfigurationIdPatch(id, patchEmploymentConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmploymentConfigurationIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmploymentConfigurationModel> response = apiInstance.EmploymentConfigurationIdPatchWithHttpInfo(id, patchEmploymentConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchEmploymentConfigurationRequest** | [**PatchEmploymentConfigurationRequest?**](PatchEmploymentConfigurationRequest?.md) |  | [optional]  |

### Return type

[**EmploymentConfigurationModel**](EmploymentConfigurationModel.md)

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

<a id="employmentconfigurationpost"></a>
# **EmploymentConfigurationPost**
> EmploymentConfigurationModel EmploymentConfigurationPost (CreateEmploymentConfigurationRequest? createEmploymentConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class EmploymentConfigurationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmploymentConfigurationClient(config);
            var createEmploymentConfigurationRequest = new CreateEmploymentConfigurationRequest?(); // CreateEmploymentConfigurationRequest? |  (optional) 

            try
            {
                EmploymentConfigurationModel result = apiInstance.EmploymentConfigurationPost(createEmploymentConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmploymentConfigurationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EmploymentConfigurationModel> response = apiInstance.EmploymentConfigurationPostWithHttpInfo(createEmploymentConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentConfigurationClient.EmploymentConfigurationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEmploymentConfigurationRequest** | [**CreateEmploymentConfigurationRequest?**](CreateEmploymentConfigurationRequest?.md) |  | [optional]  |

### Return type

[**EmploymentConfigurationModel**](EmploymentConfigurationModel.md)

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

