# Simplic.OxS.SDK.Vehicle.Temperature.VehicleConfigurationClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](VehicleConfigurationClient.md#vehicleconfigurationgetallget) | **GET** /VehicleConfiguration/get-all |  |
| [**GetDeleted**](VehicleConfigurationClient.md#vehicleconfigurationgetdeletedget) | **GET** /VehicleConfiguration/get-deleted |  |
| [**Post**](VehicleConfigurationClient.md#vehicleconfigurationpost) | **POST** /VehicleConfiguration |  |
| [**Delete**](VehicleConfigurationClient.md#vehicleconfigurationvehicleiddelete) | **DELETE** /VehicleConfiguration/{vehicleId} |  |
| [**Get**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidget) | **GET** /VehicleConfiguration/{vehicleId} |  |
| [**Patch**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidpatch) | **PATCH** /VehicleConfiguration/{vehicleId} |  |
| [**Put**](VehicleConfigurationClient.md#vehicleconfigurationvehicleidput) | **PUT** /VehicleConfiguration/{vehicleId} |  |

<a id="vehicleconfigurationgetallget"></a>
# **GetAll**
> List&lt;VehicleConfigurationModel&gt; GetAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GetAllExample
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
                List<VehicleConfigurationModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.GetAll: " + e.Message);
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
    ApiResponse<List<VehicleConfigurationModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.GetAllWithHttpInfo: " + e.Message);
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
# **GetDeleted**
> List&lt;VehicleConfigurationModel&gt; GetDeleted ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GetDeletedExample
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
                List<VehicleConfigurationModel> result = apiInstance.GetDeleted();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.GetDeleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleConfigurationModel>> response = apiInstance.GetDeletedWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.GetDeletedWithHttpInfo: " + e.Message);
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
# **Post**
> VehicleConfigurationModel Post (PostVehicleConfigurationRequest? postVehicleConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class PostExample
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
            var postVehicleConfigurationRequest = new PostVehicleConfigurationRequest?(); // PostVehicleConfigurationRequest? |  (optional) 

            try
            {
                VehicleConfigurationModel result = apiInstance.Post(postVehicleConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.Post: " + e.Message);
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
    ApiResponse<VehicleConfigurationModel> response = apiInstance.PostWithHttpInfo(postVehicleConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postVehicleConfigurationRequest** | [**PostVehicleConfigurationRequest?**](PostVehicleConfigurationRequest?.md) |  | [optional]  |

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
# **Delete**
> void Delete (Guid vehicleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class DeleteExample
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
                apiInstance.Delete(vehicleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.Delete: " + e.Message);
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
    apiInstance.DeleteWithHttpInfo(vehicleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.DeleteWithHttpInfo: " + e.Message);
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
# **Get**
> VehicleConfigurationModel Get (Guid vehicleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GetExample
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
                VehicleConfigurationModel result = apiInstance.Get(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.Get: " + e.Message);
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
    ApiResponse<VehicleConfigurationModel> response = apiInstance.GetWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.GetWithHttpInfo: " + e.Message);
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
# **Patch**
> VehicleConfigurationModel Patch (Guid vehicleId, PatchVehicleConfigurationRequest? patchVehicleConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class PatchExample
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
                VehicleConfigurationModel result = apiInstance.Patch(vehicleId, patchVehicleConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.Patch: " + e.Message);
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
    ApiResponse<VehicleConfigurationModel> response = apiInstance.PatchWithHttpInfo(vehicleId, patchVehicleConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.PatchWithHttpInfo: " + e.Message);
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
# **Put**
> VehicleConfigurationModel Put (Guid vehicleId, UpdateConfigurationRequest? updateConfigurationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class PutExample
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
                VehicleConfigurationModel result = apiInstance.Put(vehicleId, updateConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleConfigurationClient.Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleConfigurationModel> response = apiInstance.PutWithHttpInfo(vehicleId, updateConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleConfigurationClient.PutWithHttpInfo: " + e.Message);
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

