# Simplic.OxS.SDK.Contract.OrderSourceClient

All URIs are relative to *https://dev-oxs.simplic.io/contract-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](OrderSourceClient.md#ordersourcegetallget) | **GET** /OrderSource/get-all | Gets all order sources. Creates the default sources if none exist yet. |
| [**Delete**](OrderSourceClient.md#ordersourceiddelete) | **DELETE** /OrderSource/{id} | Deletes an order source. |
| [**Get**](OrderSourceClient.md#ordersourceidget) | **GET** /OrderSource/{id} | Gets an order source by its id. |
| [**Patch**](OrderSourceClient.md#ordersourceidpatch) | **PATCH** /OrderSource/{id} | Patches an existing order source. |
| [**Post**](OrderSourceClient.md#ordersourcepost) | **POST** /OrderSource | Creates a new order source. |

<a id="ordersourcegetallget"></a>
# **GetAll**
> List&lt;OrderSourceModel&gt; GetAll ()

Gets all order sources. Creates the default sources if none exist yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class GetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contract-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderSourceClient(config);

            try
            {
                // Gets all order sources. Creates the default sources if none exist yet.
                List<OrderSourceModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderSourceClient.GetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all order sources. Creates the default sources if none exist yet.
    ApiResponse<List<OrderSourceModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderSourceClient.GetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrderSourceModel&gt;**](OrderSourceModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersourceiddelete"></a>
# **Delete**
> void Delete (Guid id)

Deletes an order source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contract-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderSourceClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deletes an order source.
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderSourceClient.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an order source.
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderSourceClient.DeleteWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersourceidget"></a>
# **Get**
> OrderSourceModel Get (Guid id)

Gets an order source by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contract-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderSourceClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Gets an order source by its id.
                OrderSourceModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderSourceClient.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets an order source by its id.
    ApiResponse<OrderSourceModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderSourceClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**OrderSourceModel**](OrderSourceModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersourceidpatch"></a>
# **Patch**
> OrderSourceModel Patch (Guid id, PatchOrderSourceRequest? patchOrderSourceRequest = null)

Patches an existing order source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contract-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderSourceClient(config);
            var id = "id_example";  // Guid | 
            var patchOrderSourceRequest = new PatchOrderSourceRequest?(); // PatchOrderSourceRequest? |  (optional) 

            try
            {
                // Patches an existing order source.
                OrderSourceModel result = apiInstance.Patch(id, patchOrderSourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderSourceClient.Patch: " + e.Message);
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
    // Patches an existing order source.
    ApiResponse<OrderSourceModel> response = apiInstance.PatchWithHttpInfo(id, patchOrderSourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderSourceClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchOrderSourceRequest** | [**PatchOrderSourceRequest?**](PatchOrderSourceRequest?.md) |  | [optional]  |

### Return type

[**OrderSourceModel**](OrderSourceModel.md)

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

<a id="ordersourcepost"></a>
# **Post**
> OrderSourceModel Post (CreateOrderSourceRequest? createOrderSourceRequest = null)

Creates a new order source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/contract-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderSourceClient(config);
            var createOrderSourceRequest = new CreateOrderSourceRequest?(); // CreateOrderSourceRequest? |  (optional) 

            try
            {
                // Creates a new order source.
                OrderSourceModel result = apiInstance.Post(createOrderSourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderSourceClient.Post: " + e.Message);
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
    // Creates a new order source.
    ApiResponse<OrderSourceModel> response = apiInstance.PostWithHttpInfo(createOrderSourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderSourceClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrderSourceRequest** | [**CreateOrderSourceRequest?**](CreateOrderSourceRequest?.md) |  | [optional]  |

### Return type

[**OrderSourceModel**](OrderSourceModel.md)

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

