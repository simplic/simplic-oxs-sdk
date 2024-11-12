# Simplic.OxS.SDK.Logistics.ShipmentClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllWithConditions**](ShipmentClient.md#shipmentgetallwithconditionsget) | **GET** /Shipment/get-all-with-conditions | Retrives all shipments for the given conditions. |
| [**GetUpdatedSince**](ShipmentClient.md#shipmentgetupdatedsinceget) | **GET** /Shipment/get-updated-since | Retrives the shipment with the given id. |
| [**Delete**](ShipmentClient.md#shipmentiddelete) | **DELETE** /Shipment/{id} |  |
| [**Get**](ShipmentClient.md#shipmentidget) | **GET** /Shipment/{id} | Retrives the shipment with the given id. |
| [**Patch**](ShipmentClient.md#shipmentidpatch) | **PATCH** /Shipment/{id} |  |
| [**Post**](ShipmentClient.md#shipmentpost) | **POST** /Shipment |  |

<a id="shipmentgetallwithconditionsget"></a>
# **GetAllWithConditions**
> List&lt;ShipmentModel&gt; GetAllWithConditions (string? status = null, DateTime? from = null, DateTime? to = null)

Retrives all shipments for the given conditions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetAllWithConditionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var status = "status_example";  // string? | Status of the shipment. (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date since when to retrieve. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date until to retrive. (optional) 

            try
            {
                // Retrives all shipments for the given conditions.
                List<ShipmentModel> result = apiInstance.GetAllWithConditions(status, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.GetAllWithConditions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllWithConditionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives all shipments for the given conditions.
    ApiResponse<List<ShipmentModel>> response = apiInstance.GetAllWithConditionsWithHttpInfo(status, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.GetAllWithConditionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string?** | Status of the shipment. | [optional]  |
| **from** | **DateTime?** | Date since when to retrieve. | [optional]  |
| **to** | **DateTime?** | Date until to retrive. | [optional]  |

### Return type

[**List&lt;ShipmentModel&gt;**](ShipmentModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentgetupdatedsinceget"></a>
# **GetUpdatedSince**
> List&lt;ShipmentModel&gt; GetUpdatedSince (DateTime? since = null)

Retrives the shipment with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetUpdatedSinceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Retrives the shipment with the given id.
                List<ShipmentModel> result = apiInstance.GetUpdatedSince(since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.GetUpdatedSince: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUpdatedSinceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the shipment with the given id.
    ApiResponse<List<ShipmentModel>> response = apiInstance.GetUpdatedSinceWithHttpInfo(since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.GetUpdatedSinceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **since** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;ShipmentModel&gt;**](ShipmentModel.md)

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

<a id="shipmentiddelete"></a>
# **Delete**
> Object Delete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                Object result = apiInstance.Delete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Delete: " + e.Message);
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
    ApiResponse<Object> response = apiInstance.DeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.DeleteWithHttpInfo: " + e.Message);
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

<a id="shipmentidget"></a>
# **Get**
> ShipmentModel Get (Guid id)

Retrives the shipment with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var id = "id_example";  // Guid | Id of the shipment

            try
            {
                // Retrives the shipment with the given id.
                ShipmentModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Get: " + e.Message);
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
    // Retrives the shipment with the given id.
    ApiResponse<ShipmentModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the shipment |  |

### Return type

[**ShipmentModel**](ShipmentModel.md)

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

<a id="shipmentidpatch"></a>
# **Patch**
> ShipmentModel Patch (Guid id, PatchShipmentRequest? patchShipmentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var id = "id_example";  // Guid | 
            var patchShipmentRequest = new PatchShipmentRequest?(); // PatchShipmentRequest? |  (optional) 

            try
            {
                ShipmentModel result = apiInstance.Patch(id, patchShipmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Patch: " + e.Message);
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
    ApiResponse<ShipmentModel> response = apiInstance.PatchWithHttpInfo(id, patchShipmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchShipmentRequest** | [**PatchShipmentRequest?**](PatchShipmentRequest?.md) |  | [optional]  |

### Return type

[**ShipmentModel**](ShipmentModel.md)

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

<a id="shipmentpost"></a>
# **Post**
> ShipmentModel Post (CreateShipmentRequest? createShipmentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentClient(config);
            var createShipmentRequest = new CreateShipmentRequest?(); // CreateShipmentRequest? |  (optional) 

            try
            {
                ShipmentModel result = apiInstance.Post(createShipmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Post: " + e.Message);
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
    ApiResponse<ShipmentModel> response = apiInstance.PostWithHttpInfo(createShipmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createShipmentRequest** | [**CreateShipmentRequest?**](CreateShipmentRequest?.md) |  | [optional]  |

### Return type

[**ShipmentModel**](ShipmentModel.md)

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

