# Simplic.OxS.SDK.Logistics...ShipmentSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShipmentGetAllWithConditionsGet**](ShipmentSDK.md#shipmentgetallwithconditionsget) | **GET** /Shipment/get-all-with-conditions | Retrives all shipments for the given conditions. |
| [**ShipmentGetUpdatedSinceGet**](ShipmentSDK.md#shipmentgetupdatedsinceget) | **GET** /Shipment/get-updated-since | Retrives the shipment with the given id. |
| [**ShipmentIdDelete**](ShipmentSDK.md#shipmentiddelete) | **DELETE** /Shipment/{id} |  |
| [**ShipmentIdGet**](ShipmentSDK.md#shipmentidget) | **GET** /Shipment/{id} | Retrives the shipment with the given id. |
| [**ShipmentIdPatch**](ShipmentSDK.md#shipmentidpatch) | **PATCH** /Shipment/{id} |  |
| [**ShipmentPost**](ShipmentSDK.md#shipmentpost) | **POST** /Shipment |  |

<a id="shipmentgetallwithconditionsget"></a>
# **ShipmentGetAllWithConditionsGet**
> List&lt;ShipmentModel&gt; ShipmentGetAllWithConditionsGet (string? status = null, DateTime? from = null, DateTime? to = null)

Retrives all shipments for the given conditions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentGetAllWithConditionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var status = "status_example";  // string? | Status of the shipment. (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date since when to retrieve. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date until to retrive. (optional) 

            try
            {
                // Retrives all shipments for the given conditions.
                List<ShipmentModel> result = apiInstance.ShipmentGetAllWithConditionsGet(status, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentGetAllWithConditionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentGetAllWithConditionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives all shipments for the given conditions.
    ApiResponse<List<ShipmentModel>> response = apiInstance.ShipmentGetAllWithConditionsGetWithHttpInfo(status, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentGetAllWithConditionsGetWithHttpInfo: " + e.Message);
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
# **ShipmentGetUpdatedSinceGet**
> List&lt;ShipmentModel&gt; ShipmentGetUpdatedSinceGet (DateTime? since = null)

Retrives the shipment with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentGetUpdatedSinceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Retrives the shipment with the given id.
                List<ShipmentModel> result = apiInstance.ShipmentGetUpdatedSinceGet(since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentGetUpdatedSinceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentGetUpdatedSinceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the shipment with the given id.
    ApiResponse<List<ShipmentModel>> response = apiInstance.ShipmentGetUpdatedSinceGetWithHttpInfo(since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentGetUpdatedSinceGetWithHttpInfo: " + e.Message);
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
# **ShipmentIdDelete**
> Object ShipmentIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                Object result = apiInstance.ShipmentIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ShipmentIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentIdDeleteWithHttpInfo: " + e.Message);
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
# **ShipmentIdGet**
> ShipmentModel ShipmentIdGet (Guid id)

Retrives the shipment with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var id = "id_example";  // Guid | Id of the shipment

            try
            {
                // Retrives the shipment with the given id.
                ShipmentModel result = apiInstance.ShipmentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the shipment with the given id.
    ApiResponse<ShipmentModel> response = apiInstance.ShipmentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentIdGetWithHttpInfo: " + e.Message);
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
# **ShipmentIdPatch**
> ShipmentModel ShipmentIdPatch (Guid id, PatchShipmentRequest? patchShipmentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var id = "id_example";  // Guid | 
            var patchShipmentRequest = new PatchShipmentRequest?(); // PatchShipmentRequest? |  (optional) 

            try
            {
                ShipmentModel result = apiInstance.ShipmentIdPatch(id, patchShipmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShipmentModel> response = apiInstance.ShipmentIdPatchWithHttpInfo(id, patchShipmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentIdPatchWithHttpInfo: " + e.Message);
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
# **ShipmentPost**
> ShipmentModel ShipmentPost (CreateShipmentRequest? createShipmentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics..;
using Simplic.OxS.SDK.Logistics.Client;
using Simplic.OxS.SDK.Logistics.Model;

namespace Example
{
    public class ShipmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentSDK(config);
            var createShipmentRequest = new CreateShipmentRequest?(); // CreateShipmentRequest? |  (optional) 

            try
            {
                ShipmentModel result = apiInstance.ShipmentPost(createShipmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentSDK.ShipmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ShipmentModel> response = apiInstance.ShipmentPostWithHttpInfo(createShipmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentSDK.ShipmentPostWithHttpInfo: " + e.Message);
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

