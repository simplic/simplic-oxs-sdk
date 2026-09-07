# Simplic.OxS.SDK.Contract.OrderStatusClient

All URIs are relative to *https://dev-oxs.simplic.io/contract-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Delete**](OrderStatusClient.md#orderstatusiddelete) | **DELETE** /OrderStatus/{id} | Deletes an order status. |
| [**Get**](OrderStatusClient.md#orderstatusidget) | **GET** /OrderStatus/{id} | Gets an order status by its id. |
| [**Patch**](OrderStatusClient.md#orderstatusidpatch) | **PATCH** /OrderStatus/{id} | Patches an existing order status. |
| [**Post**](OrderStatusClient.md#orderstatuspost) | **POST** /OrderStatus | Creates a new order status. |

<a id="orderstatusiddelete"></a>
# **Delete**
> void Delete (Guid id)

Deletes an order status.

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

            var apiInstance = new OrderStatusClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deletes an order status.
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderStatusClient.Delete: " + e.Message);
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
    // Deletes an order status.
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderStatusClient.DeleteWithHttpInfo: " + e.Message);
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

<a id="orderstatusidget"></a>
# **Get**
> OrderStatusModel Get (Guid id)

Gets an order status by its id.

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

            var apiInstance = new OrderStatusClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Gets an order status by its id.
                OrderStatusModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderStatusClient.Get: " + e.Message);
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
    // Gets an order status by its id.
    ApiResponse<OrderStatusModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderStatusClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**OrderStatusModel**](OrderStatusModel.md)

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

<a id="orderstatusidpatch"></a>
# **Patch**
> OrderStatusModel Patch (Guid id, PatchOrderStatusRequest? patchOrderStatusRequest = null)

Patches an existing order status.

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

            var apiInstance = new OrderStatusClient(config);
            var id = "id_example";  // Guid | 
            var patchOrderStatusRequest = new PatchOrderStatusRequest?(); // PatchOrderStatusRequest? |  (optional) 

            try
            {
                // Patches an existing order status.
                OrderStatusModel result = apiInstance.Patch(id, patchOrderStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderStatusClient.Patch: " + e.Message);
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
    // Patches an existing order status.
    ApiResponse<OrderStatusModel> response = apiInstance.PatchWithHttpInfo(id, patchOrderStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderStatusClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchOrderStatusRequest** | [**PatchOrderStatusRequest?**](PatchOrderStatusRequest?.md) |  | [optional]  |

### Return type

[**OrderStatusModel**](OrderStatusModel.md)

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

<a id="orderstatuspost"></a>
# **Post**
> OrderStatusModel Post (CreateOrderStatusRequest? createOrderStatusRequest = null)

Creates a new order status.

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

            var apiInstance = new OrderStatusClient(config);
            var createOrderStatusRequest = new CreateOrderStatusRequest?(); // CreateOrderStatusRequest? |  (optional) 

            try
            {
                // Creates a new order status.
                OrderStatusModel result = apiInstance.Post(createOrderStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderStatusClient.Post: " + e.Message);
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
    // Creates a new order status.
    ApiResponse<OrderStatusModel> response = apiInstance.PostWithHttpInfo(createOrderStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderStatusClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrderStatusRequest** | [**CreateOrderStatusRequest?**](CreateOrderStatusRequest?.md) |  | [optional]  |

### Return type

[**OrderStatusModel**](OrderStatusModel.md)

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

