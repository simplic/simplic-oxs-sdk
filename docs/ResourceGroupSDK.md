# Simplic.OxS.SDK.Logistics...ResourceGroupSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResourceGroupGet**](ResourceGroupSDK.md#resourcegroupget) | **GET** /ResourceGroup | Retrives all resource groups |
| [**ResourceGroupIdDelete**](ResourceGroupSDK.md#resourcegroupiddelete) | **DELETE** /ResourceGroup/{id} |  |
| [**ResourceGroupIdGet**](ResourceGroupSDK.md#resourcegroupidget) | **GET** /ResourceGroup/{id} | Retrives the resource group with the given id. |
| [**ResourceGroupIdPatch**](ResourceGroupSDK.md#resourcegroupidpatch) | **PATCH** /ResourceGroup/{id} |  |
| [**ResourceGroupPost**](ResourceGroupSDK.md#resourcegrouppost) | **POST** /ResourceGroup |  |

<a id="resourcegroupget"></a>
# **ResourceGroupGet**
> List&lt;GroupedResourcesModel&gt; ResourceGroupGet ()

Retrives all resource groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ResourceGroupGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceGroupSDK(config);

            try
            {
                // Retrives all resource groups
                List<GroupedResourcesModel> result = apiInstance.ResourceGroupGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceGroupGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives all resource groups
    ApiResponse<List<GroupedResourcesModel>> response = apiInstance.ResourceGroupGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GroupedResourcesModel&gt;**](GroupedResourcesModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resourcegroupiddelete"></a>
# **ResourceGroupIdDelete**
> Object ResourceGroupIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ResourceGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceGroupSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                Object result = apiInstance.ResourceGroupIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ResourceGroupIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdDeleteWithHttpInfo: " + e.Message);
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

<a id="resourcegroupidget"></a>
# **ResourceGroupIdGet**
> GroupedResourcesModel ResourceGroupIdGet (Guid id)

Retrives the resource group with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ResourceGroupIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceGroupSDK(config);
            var id = "id_example";  // Guid | Id of the resource

            try
            {
                // Retrives the resource group with the given id.
                GroupedResourcesModel result = apiInstance.ResourceGroupIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceGroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the resource group with the given id.
    ApiResponse<GroupedResourcesModel> response = apiInstance.ResourceGroupIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the resource |  |

### Return type

[**GroupedResourcesModel**](GroupedResourcesModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resourcegroupidpatch"></a>
# **ResourceGroupIdPatch**
> GroupedResourcesModel ResourceGroupIdPatch (Guid id, UpdateResourceGroupRequest? updateResourceGroupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ResourceGroupIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceGroupSDK(config);
            var id = "id_example";  // Guid | 
            var updateResourceGroupRequest = new UpdateResourceGroupRequest?(); // UpdateResourceGroupRequest? |  (optional) 

            try
            {
                GroupedResourcesModel result = apiInstance.ResourceGroupIdPatch(id, updateResourceGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceGroupIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupedResourcesModel> response = apiInstance.ResourceGroupIdPatchWithHttpInfo(id, updateResourceGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateResourceGroupRequest** | [**UpdateResourceGroupRequest?**](UpdateResourceGroupRequest?.md) |  | [optional]  |

### Return type

[**GroupedResourcesModel**](GroupedResourcesModel.md)

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

<a id="resourcegrouppost"></a>
# **ResourceGroupPost**
> GroupedResourcesModel ResourceGroupPost (CreateResourceGroupRequest? createResourceGroupRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ResourceGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ResourceGroupSDK(config);
            var createResourceGroupRequest = new CreateResourceGroupRequest?(); // CreateResourceGroupRequest? |  (optional) 

            try
            {
                GroupedResourcesModel result = apiInstance.ResourceGroupPost(createResourceGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourceGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupedResourcesModel> response = apiInstance.ResourceGroupPostWithHttpInfo(createResourceGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResourceGroupSDK.ResourceGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createResourceGroupRequest** | [**CreateResourceGroupRequest?**](CreateResourceGroupRequest?.md) |  | [optional]  |

### Return type

[**GroupedResourcesModel**](GroupedResourcesModel.md)

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

