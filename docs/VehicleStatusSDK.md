# Simplic.OxS.SDK.Vehicle.VehicleStatusSDK

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VehicleStatusGetAllGet**](VehicleStatusSDK.md#vehiclestatusgetallget) | **GET** /VehicleStatus/get-all |  |
| [**VehicleStatusIdDelete**](VehicleStatusSDK.md#vehiclestatusiddelete) | **DELETE** /VehicleStatus/{id} |  |
| [**VehicleStatusIdGet**](VehicleStatusSDK.md#vehiclestatusidget) | **GET** /VehicleStatus/{id} |  |
| [**VehicleStatusIdPut**](VehicleStatusSDK.md#vehiclestatusidput) | **PUT** /VehicleStatus/{id} |  |
| [**VehicleStatusPost**](VehicleStatusSDK.md#vehiclestatuspost) | **POST** /VehicleStatus |  |

<a id="vehiclestatusgetallget"></a>
# **VehicleStatusGetAllGet**
> List&lt;VehicleStatusModel&gt; VehicleStatusGetAllGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class VehicleStatusGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleStatusSDK(config);

            try
            {
                List<VehicleStatusModel> result = apiInstance.VehicleStatusGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleStatusGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleStatusModel>> response = apiInstance.VehicleStatusGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;VehicleStatusModel&gt;**](VehicleStatusModel.md)

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

<a id="vehiclestatusiddelete"></a>
# **VehicleStatusIdDelete**
> void VehicleStatusIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class VehicleStatusIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleStatusSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.VehicleStatusIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleStatusIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VehicleStatusIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdDeleteWithHttpInfo: " + e.Message);
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

<a id="vehiclestatusidget"></a>
# **VehicleStatusIdGet**
> VehicleStatusModel VehicleStatusIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class VehicleStatusIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleStatusSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                VehicleStatusModel result = apiInstance.VehicleStatusIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleStatusIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleStatusModel> response = apiInstance.VehicleStatusIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**VehicleStatusModel**](VehicleStatusModel.md)

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

<a id="vehiclestatusidput"></a>
# **VehicleStatusIdPut**
> VehicleStatusModel VehicleStatusIdPut (Guid id, UpdateVehicleStatusRequest? updateVehicleStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class VehicleStatusIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleStatusSDK(config);
            var id = "id_example";  // Guid | 
            var updateVehicleStatusRequest = new UpdateVehicleStatusRequest?(); // UpdateVehicleStatusRequest? |  (optional) 

            try
            {
                VehicleStatusModel result = apiInstance.VehicleStatusIdPut(id, updateVehicleStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleStatusIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleStatusModel> response = apiInstance.VehicleStatusIdPutWithHttpInfo(id, updateVehicleStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateVehicleStatusRequest** | [**UpdateVehicleStatusRequest?**](UpdateVehicleStatusRequest?.md) |  | [optional]  |

### Return type

[**VehicleStatusModel**](VehicleStatusModel.md)

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

<a id="vehiclestatuspost"></a>
# **VehicleStatusPost**
> VehicleStatusModel VehicleStatusPost (CreateVehicleStatusRequest? createVehicleStatusRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class VehicleStatusPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleStatusSDK(config);
            var createVehicleStatusRequest = new CreateVehicleStatusRequest?(); // CreateVehicleStatusRequest? |  (optional) 

            try
            {
                VehicleStatusModel result = apiInstance.VehicleStatusPost(createVehicleStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleStatusPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleStatusModel> response = apiInstance.VehicleStatusPostWithHttpInfo(createVehicleStatusRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleStatusSDK.VehicleStatusPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createVehicleStatusRequest** | [**CreateVehicleStatusRequest?**](CreateVehicleStatusRequest?.md) |  | [optional]  |

### Return type

[**VehicleStatusModel**](VehicleStatusModel.md)

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

