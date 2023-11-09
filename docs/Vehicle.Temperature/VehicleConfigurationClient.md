# Simplic.OxS.SDK.Vehicle.Temperature.VehicleConfigurationClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VehicleConfigurationGetAllGet**](VehicleConfigurationClient.md#vehicleconfigurationgetallget) | **GET** /VehicleConfiguration/get-all |  |
| [**VehicleConfigurationGetDeletedGet**](VehicleConfigurationClient.md#vehicleconfigurationgetdeletedget) | **GET** /VehicleConfiguration/get-deleted |  |
| [**VehicleConfigurationPost**](VehicleConfigurationClient.md#vehicleconfigurationpost) | **POST** /VehicleConfiguration |  |
| [**VehicleConfigurationVehicleIdDelete**](VehicleConfigurationClient.md#vehicleconfigurationvehicleiddelete) | **DELETE** /VehicleConfiguration/{vehicleId} |  |
| [**VehicleConfigurationVehicleIdGet**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidget) | **GET** /VehicleConfiguration/{vehicleId} |  |
| [**VehicleConfigurationVehicleIdPatch**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidpatch) | **PATCH** /VehicleConfiguration/{vehicleId} |  |
| [**VehicleConfigurationVehicleIdPut**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidput) | **PUT** /VehicleConfiguration/{vehicleId} |  |

<a id="vehicleconfigurationgetallget"></a>
# **VehicleConfigurationGetAllGet**
> List&lt;VehicleConfigurationModel&gt; VehicleConfigurationGetAllGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);

            try
            {
                List<VehicleConfigurationModel> result = apiInstance.VehicleConfigurationGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleConfigurationModel>> response = apiInstance.VehicleConfigurationGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;VehicleConfigurationModel&gt;**](VehicleConfigurationModel.md)

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

<a id="vehicleconfigurationgetdeletedget"></a>
# **VehicleConfigurationGetDeletedGet**
> List&lt;VehicleConfigurationModel&gt; VehicleConfigurationGetDeletedGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationGetDeletedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);

            try
            {
                List<VehicleConfigurationModel> result = apiInstance.VehicleConfigurationGetDeletedGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationGetDeletedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationGetDeletedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleConfigurationModel>> response = apiInstance.VehicleConfigurationGetDeletedGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationGetDeletedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;VehicleConfigurationModel&gt;**](VehicleConfigurationModel.md)

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

<a id="vehicleconfigurationpost"></a>
# **VehicleConfigurationPost**
> VehicleConfigurationModel VehicleConfigurationPost (PostConfigurationRequest? postConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);
            var postConfigurationRequest = new PostConfigurationRequest?(); // PostConfigurationRequest? |  (optional) 

            try
            {
                VehicleConfigurationModel result = apiInstance.VehicleConfigurationPost(postConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleConfigurationModel> response = apiInstance.VehicleConfigurationPostWithHttpInfo(postConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postConfigurationRequest** | [**PostConfigurationRequest?**](PostConfigurationRequest?.md) |  | [optional]  |

### Return type

[**VehicleConfigurationModel**](VehicleConfigurationModel.md)

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

<a id="vehicleconfigurationvehicleiddelete"></a>
# **VehicleConfigurationVehicleIdDelete**
> void VehicleConfigurationVehicleIdDelete (Guid vehicleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationVehicleIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);
            var vehicleId = "vehicleId_example";  // Guid | 

            try
            {
                apiInstance.VehicleConfigurationVehicleIdDelete(vehicleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationVehicleIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VehicleConfigurationVehicleIdDeleteWithHttpInfo(vehicleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |

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

<a id="vehicleconfigurationvehicleidget"></a>
# **VehicleConfigurationVehicleIdGet**
> VehicleConfigurationModel VehicleConfigurationVehicleIdGet (Guid vehicleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationVehicleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);
            var vehicleId = "vehicleId_example";  // Guid | 

            try
            {
                VehicleConfigurationModel result = apiInstance.VehicleConfigurationVehicleIdGet(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationVehicleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleConfigurationModel> response = apiInstance.VehicleConfigurationVehicleIdGetWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |

### Return type

[**VehicleConfigurationModel**](VehicleConfigurationModel.md)

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

<a id="vehicleconfigurationvehicleidpatch"></a>
# **VehicleConfigurationVehicleIdPatch**
> VehicleConfigurationModel VehicleConfigurationVehicleIdPatch (Guid vehicleId, PatchVehicleConfigurationRequest? patchVehicleConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationVehicleIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);
            var vehicleId = "vehicleId_example";  // Guid | 
            var patchVehicleConfigurationRequest = new PatchVehicleConfigurationRequest?(); // PatchVehicleConfigurationRequest? |  (optional) 

            try
            {
                VehicleConfigurationModel result = apiInstance.VehicleConfigurationVehicleIdPatch(vehicleId, patchVehicleConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationVehicleIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleConfigurationModel> response = apiInstance.VehicleConfigurationVehicleIdPatchWithHttpInfo(vehicleId, patchVehicleConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |
| **patchVehicleConfigurationRequest** | [**PatchVehicleConfigurationRequest?**](PatchVehicleConfigurationRequest?.md) |  | [optional]  |

### Return type

[**VehicleConfigurationModel**](VehicleConfigurationModel.md)

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

<a id="vehicleconfigurationvehicleidput"></a>
# **VehicleConfigurationVehicleIdPut**
> VehicleConfigurationModel VehicleConfigurationVehicleIdPut (Guid vehicleId, UpdateConfigurationRequest? updateConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class VehicleConfigurationVehicleIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleConfigurationClient(config);
            var vehicleId = "vehicleId_example";  // Guid | 
            var updateConfigurationRequest = new UpdateConfigurationRequest?(); // UpdateConfigurationRequest? |  (optional) 

            try
            {
                VehicleConfigurationModel result = apiInstance.VehicleConfigurationVehicleIdPut(vehicleId, updateConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VehicleConfigurationVehicleIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleConfigurationModel> response = apiInstance.VehicleConfigurationVehicleIdPutWithHttpInfo(vehicleId, updateConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.VehicleConfigurationVehicleIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |
| **updateConfigurationRequest** | [**UpdateConfigurationRequest?**](UpdateConfigurationRequest?.md) |  | [optional]  |

### Return type

[**VehicleConfigurationModel**](VehicleConfigurationModel.md)

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

