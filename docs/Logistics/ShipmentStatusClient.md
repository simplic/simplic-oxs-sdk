# Simplic.OxS.SDK.Logistics.ShipmentStatusClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShipmentStatusGetAllGet**](ShipmentStatusClient.md#shipmentstatusgetallget) | **GET** /ShipmentStatus/get-all | Retrieves all shipment status. |
| [**ShipmentStatusIdGet**](ShipmentStatusClient.md#shipmentstatusidget) | **GET** /ShipmentStatus/{id} | Retrives the shipment status with the given id. |
| [**ShipmentStatusIdPut**](ShipmentStatusClient.md#shipmentstatusidput) | **PUT** /ShipmentStatus/{id} | Updates/saves the given shipment status. |
| [**ShipmentStatusPost**](ShipmentStatusClient.md#shipmentstatuspost) | **POST** /ShipmentStatus | Creates a new shipment status. |

<a id="shipmentstatusgetallget"></a>
# **ShipmentStatusGetAllGet**
> List&lt;ShipmentStatusModel&gt; ShipmentStatusGetAllGet ()

Retrieves all shipment status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ShipmentStatusGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentStatusClient(config);

            try
            {
                // Retrieves all shipment status.
                List<ShipmentStatusModel> result = apiInstance.ShipmentStatusGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentStatusGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all shipment status.
    ApiResponse<List<ShipmentStatusModel>> response = apiInstance.ShipmentStatusGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ShipmentStatusModel&gt;**](ShipmentStatusModel.md)

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

<a id="shipmentstatusidget"></a>
# **ShipmentStatusIdGet**
> ShipmentStatusModel ShipmentStatusIdGet (Guid id)

Retrives the shipment status with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ShipmentStatusIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentStatusClient(config);
            var id = "id_example";  // Guid | Id of the shipment status.

            try
            {
                // Retrives the shipment status with the given id.
                ShipmentStatusModel result = apiInstance.ShipmentStatusIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentStatusIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the shipment status with the given id.
    ApiResponse<ShipmentStatusModel> response = apiInstance.ShipmentStatusIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the shipment status. |  |

### Return type

[**ShipmentStatusModel**](ShipmentStatusModel.md)

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

<a id="shipmentstatusidput"></a>
# **ShipmentStatusIdPut**
> ShipmentStatusModel ShipmentStatusIdPut (Guid id, UpdateShipmentStatusRequest? updateShipmentStatusRequest = null)

Updates/saves the given shipment status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ShipmentStatusIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentStatusClient(config);
            var id = "id_example";  // Guid | Id of the shipment status to update.
            var updateShipmentStatusRequest = new UpdateShipmentStatusRequest?(); // UpdateShipmentStatusRequest? | Shipment status to update. (optional) 

            try
            {
                // Updates/saves the given shipment status.
                ShipmentStatusModel result = apiInstance.ShipmentStatusIdPut(id, updateShipmentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentStatusIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates/saves the given shipment status.
    ApiResponse<ShipmentStatusModel> response = apiInstance.ShipmentStatusIdPutWithHttpInfo(id, updateShipmentStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the shipment status to update. |  |
| **updateShipmentStatusRequest** | [**UpdateShipmentStatusRequest?**](UpdateShipmentStatusRequest?.md) | Shipment status to update. | [optional]  |

### Return type

[**ShipmentStatusModel**](ShipmentStatusModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentstatuspost"></a>
# **ShipmentStatusPost**
> ShipmentStatusModel ShipmentStatusPost (CreateShipmentStatusRequest? createShipmentStatusRequest = null)

Creates a new shipment status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class ShipmentStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentStatusClient(config);
            var createShipmentStatusRequest = new CreateShipmentStatusRequest?(); // CreateShipmentStatusRequest? | A create shipment status request object. (optional) 

            try
            {
                // Creates a new shipment status.
                ShipmentStatusModel result = apiInstance.ShipmentStatusPost(createShipmentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentStatusPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new shipment status.
    ApiResponse<ShipmentStatusModel> response = apiInstance.ShipmentStatusPostWithHttpInfo(createShipmentStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusClient.ShipmentStatusPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createShipmentStatusRequest** | [**CreateShipmentStatusRequest?**](CreateShipmentStatusRequest?.md) | A create shipment status request object. | [optional]  |

### Return type

[**ShipmentStatusModel**](ShipmentStatusModel.md)

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

