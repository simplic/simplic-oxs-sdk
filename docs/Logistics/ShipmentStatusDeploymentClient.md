# Simplic.OxS.SDK.Logistics.ShipmentStatusDeploymentClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Patch**](ShipmentStatusDeploymentClient.md#shipmentstatusdeploymentidpatch) | **PATCH** /ShipmentStatusDeployment/{id} |  |
| [**Post**](ShipmentStatusDeploymentClient.md#shipmentstatusdeploymentpost) | **POST** /ShipmentStatusDeployment |  |

<a id="shipmentstatusdeploymentidpatch"></a>
# **Patch**
> ShipmentStatusModel Patch (Guid id, UpdateShipmentStatusRequest? updateShipmentStatusRequest = null)



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

            var apiInstance = new ShipmentStatusDeploymentClient(config);
            var id = "id_example";  // Guid | 
            var updateShipmentStatusRequest = new UpdateShipmentStatusRequest?(); // UpdateShipmentStatusRequest? |  (optional) 

            try
            {
                ShipmentStatusModel result = apiInstance.Patch(id, updateShipmentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusDeploymentClient.Patch: " + e.Message);
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
    ApiResponse<ShipmentStatusModel> response = apiInstance.PatchWithHttpInfo(id, updateShipmentStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusDeploymentClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateShipmentStatusRequest** | [**UpdateShipmentStatusRequest?**](UpdateShipmentStatusRequest?.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentstatusdeploymentpost"></a>
# **Post**
> ShipmentStatusModel Post (CreateShipmentStatusRequest? createShipmentStatusRequest = null)



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

            var apiInstance = new ShipmentStatusDeploymentClient(config);
            var createShipmentStatusRequest = new CreateShipmentStatusRequest?(); // CreateShipmentStatusRequest? |  (optional) 

            try
            {
                ShipmentStatusModel result = apiInstance.Post(createShipmentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentStatusDeploymentClient.Post: " + e.Message);
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
    ApiResponse<ShipmentStatusModel> response = apiInstance.PostWithHttpInfo(createShipmentStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentStatusDeploymentClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createShipmentStatusRequest** | [**CreateShipmentStatusRequest?**](CreateShipmentStatusRequest?.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

