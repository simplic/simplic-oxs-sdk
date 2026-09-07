# Simplic.OxS.SDK.Contract.OrderClient

All URIs are relative to *https://dev-oxs.simplic.io/contract-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](OrderClient.md#ordergetallget) | **GET** /Order/get-all | Gets all orders of the current organization. |
| [**Delete**](OrderClient.md#orderiddelete) | **DELETE** /Order/{id} | Deletes an order. |
| [**Get**](OrderClient.md#orderidget) | **GET** /Order/{id} | Gets an order by its id. |
| [**Patch**](OrderClient.md#orderidpatch) | **PATCH** /Order/{id} | Updates an existing order. |
| [**Status**](OrderClient.md#orderidstatuspost) | **POST** /Order/{id}/status | Sets the status of an order. |
| [**Post**](OrderClient.md#orderpost) | **POST** /Order | Creates a new order. |
| [**Search**](OrderClient.md#ordersearchget) | **GET** /Order/search | Searches orders by customer, contract and status. |

<a id="ordergetallget"></a>
# **GetAll**
> List&lt;OrderModel&gt; GetAll ()

Gets all orders of the current organization.

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

            var apiInstance = new OrderClient(config);

            try
            {
                // Gets all orders of the current organization.
                List<OrderModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.GetAll: " + e.Message);
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
    // Gets all orders of the current organization.
    ApiResponse<List<OrderModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.GetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrderModel&gt;**](OrderModel.md)

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

<a id="orderiddelete"></a>
# **Delete**
> void Delete (Guid id)

Deletes an order.

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

            var apiInstance = new OrderClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Deletes an order.
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Delete: " + e.Message);
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
    // Deletes an order.
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.DeleteWithHttpInfo: " + e.Message);
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

<a id="orderidget"></a>
# **Get**
> OrderModel Get (Guid id)

Gets an order by its id.

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

            var apiInstance = new OrderClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Gets an order by its id.
                OrderModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Get: " + e.Message);
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
    // Gets an order by its id.
    ApiResponse<OrderModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**OrderModel**](OrderModel.md)

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

<a id="orderidpatch"></a>
# **Patch**
> OrderModel Patch (Guid id, UpdateOrderRequest? updateOrderRequest = null)

Updates an existing order.

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

            var apiInstance = new OrderClient(config);
            var id = "id_example";  // Guid | 
            var updateOrderRequest = new UpdateOrderRequest?(); // UpdateOrderRequest? |  (optional) 

            try
            {
                // Updates an existing order.
                OrderModel result = apiInstance.Patch(id, updateOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Patch: " + e.Message);
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
    // Updates an existing order.
    ApiResponse<OrderModel> response = apiInstance.PatchWithHttpInfo(id, updateOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateOrderRequest** | [**UpdateOrderRequest?**](UpdateOrderRequest?.md) |  | [optional]  |

### Return type

[**OrderModel**](OrderModel.md)

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

<a id="orderidstatuspost"></a>
# **Status**
> OrderModel Status (Guid id, SetOrderStatusRequest? setOrderStatusRequest = null)

Sets the status of an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class StatusExample
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

            var apiInstance = new OrderClient(config);
            var id = "id_example";  // Guid | 
            var setOrderStatusRequest = new SetOrderStatusRequest?(); // SetOrderStatusRequest? |  (optional) 

            try
            {
                // Sets the status of an order.
                OrderModel result = apiInstance.Status(id, setOrderStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Status: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the status of an order.
    ApiResponse<OrderModel> response = apiInstance.StatusWithHttpInfo(id, setOrderStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.StatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **setOrderStatusRequest** | [**SetOrderStatusRequest?**](SetOrderStatusRequest?.md) |  | [optional]  |

### Return type

[**OrderModel**](OrderModel.md)

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

<a id="orderpost"></a>
# **Post**
> OrderModel Post (CreateOrderRequest? createOrderRequest = null)

Creates a new order.

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

            var apiInstance = new OrderClient(config);
            var createOrderRequest = new CreateOrderRequest?(); // CreateOrderRequest? |  (optional) 

            try
            {
                // Creates a new order.
                OrderModel result = apiInstance.Post(createOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Post: " + e.Message);
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
    // Creates a new order.
    ApiResponse<OrderModel> response = apiInstance.PostWithHttpInfo(createOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrderRequest** | [**CreateOrderRequest?**](CreateOrderRequest?.md) |  | [optional]  |

### Return type

[**OrderModel**](OrderModel.md)

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

<a id="ordersearchget"></a>
# **Search**
> List&lt;OrderModel&gt; Search (Guid? customerContactId = null, Guid? contractId = null, Guid? statusId = null)

Searches orders by customer, contract and status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class SearchExample
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

            var apiInstance = new OrderClient(config);
            var customerContactId = "customerContactId_example";  // Guid? |  (optional) 
            var contractId = "contractId_example";  // Guid? |  (optional) 
            var statusId = "statusId_example";  // Guid? |  (optional) 

            try
            {
                // Searches orders by customer, contract and status.
                List<OrderModel> result = apiInstance.Search(customerContactId, contractId, statusId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderClient.Search: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searches orders by customer, contract and status.
    ApiResponse<List<OrderModel>> response = apiInstance.SearchWithHttpInfo(customerContactId, contractId, statusId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderClient.SearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerContactId** | **Guid?** |  | [optional]  |
| **contractId** | **Guid?** |  | [optional]  |
| **statusId** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;OrderModel&gt;**](OrderModel.md)

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

