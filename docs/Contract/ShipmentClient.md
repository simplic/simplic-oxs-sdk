# Simplic.OxS.SDK.Contract.ShipmentClient

All URIs are relative to *https://dev-oxs.simplic.io/contract-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Cancel**](ShipmentClient.md#shipmentidcancelpost) | **POST** /Shipment/{id}/cancel | Cancels a shipment booking.  If the booking was already confirmed, the booked quantity of a linked order item is reduced again. |
| [**Confirm**](ShipmentClient.md#shipmentidconfirmpost) | **POST** /Shipment/{id}/confirm | Confirms a pending shipment booking.  Creating a shipment booking is an asynchronous process. Only once a booking is confirmed, the booked quantity of a linked order item is increased. |

<a id="shipmentidcancelpost"></a>
# **Cancel**
> void Cancel (Guid id)

Cancels a shipment booking.  If the booking was already confirmed, the booked quantity of a linked order item is reduced again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class CancelExample
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

            var apiInstance = new ShipmentClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Cancels a shipment booking.  If the booking was already confirmed, the booked quantity of a linked order item is reduced again.
                apiInstance.Cancel(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Cancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancels a shipment booking.  If the booking was already confirmed, the booked quantity of a linked order item is reduced again.
    apiInstance.CancelWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.CancelWithHttpInfo: " + e.Message);
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

<a id="shipmentidconfirmpost"></a>
# **Confirm**
> void Confirm (Guid id)

Confirms a pending shipment booking.  Creating a shipment booking is an asynchronous process. Only once a booking is confirmed, the booked quantity of a linked order item is increased.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Contract;

namespace Example
{
    public class ConfirmExample
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

            var apiInstance = new ShipmentClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Confirms a pending shipment booking.  Creating a shipment booking is an asynchronous process. Only once a booking is confirmed, the booked quantity of a linked order item is increased.
                apiInstance.Confirm(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentClient.Confirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirms a pending shipment booking.  Creating a shipment booking is an asynchronous process. Only once a booking is confirmed, the booked quantity of a linked order item is increased.
    apiInstance.ConfirmWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentClient.ConfirmWithHttpInfo: " + e.Message);
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

