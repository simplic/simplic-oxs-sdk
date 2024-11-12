# Simplic.OxS.SDK.Vehicle.VehicleClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByQrcode**](VehicleClient.md#vehiclegetbyqrcodeget) | **GET** /Vehicle/get-by-qrcode |  |
| [**GetCountOfVehicles**](VehicleClient.md#vehiclegetcountofvehiclesget) | **GET** /Vehicle/get-count-of-vehicles |  |
| [**GetFilteredWithPaging**](VehicleClient.md#vehiclegetfilteredwithpagingget) | **GET** /Vehicle/get-filtered-with-paging |  |
| [**GetFleetAge**](VehicleClient.md#vehiclegetfleetageget) | **GET** /Vehicle/get-fleet-age |  |
| [**Delete**](VehicleClient.md#vehicleiddelete) | **DELETE** /Vehicle/{id} |  |
| [**Get**](VehicleClient.md#vehicleidget) | **GET** /Vehicle/{id} |  |
| [**Put**](VehicleClient.md#vehicleidput) | **PUT** /Vehicle/{id} |  |
| [**Post**](VehicleClient.md#vehiclepost) | **POST** /Vehicle |  |

<a id="vehiclegetbyqrcodeget"></a>
# **GetByQrcode**
> List&lt;VehicleModel&gt; GetByQrcode (string? qRCode = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class GetByQrcodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var qRCode = "qRCode_example";  // string? |  (optional) 

            try
            {
                List<VehicleModel> result = apiInstance.GetByQrcode(qRCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.GetByQrcode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQrcodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleModel>> response = apiInstance.GetByQrcodeWithHttpInfo(qRCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.GetByQrcodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qRCode** | **string?** |  | [optional]  |

### Return type

[**List&lt;VehicleModel&gt;**](VehicleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vehiclegetcountofvehiclesget"></a>
# **GetCountOfVehicles**
> int GetCountOfVehicles (string? searchText = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class GetCountOfVehiclesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var searchText = "searchText_example";  // string? |  (optional) 

            try
            {
                int result = apiInstance.GetCountOfVehicles(searchText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.GetCountOfVehicles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCountOfVehiclesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.GetCountOfVehiclesWithHttpInfo(searchText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.GetCountOfVehiclesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchText** | **string?** |  | [optional]  |

### Return type

**int**

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vehiclegetfilteredwithpagingget"></a>
# **GetFilteredWithPaging**
> List&lt;VehicleModel&gt; GetFilteredWithPaging (string? searchText = null, int? skip = null, int? limit = null, bool? isDeleted = null, bool? registrationPlateRequired = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class GetFilteredWithPagingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var searchText = "searchText_example";  // string? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var isDeleted = true;  // bool? |  (optional) 
            var registrationPlateRequired = true;  // bool? |  (optional) 

            try
            {
                List<VehicleModel> result = apiInstance.GetFilteredWithPaging(searchText, skip, limit, isDeleted, registrationPlateRequired);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.GetFilteredWithPaging: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilteredWithPagingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<VehicleModel>> response = apiInstance.GetFilteredWithPagingWithHttpInfo(searchText, skip, limit, isDeleted, registrationPlateRequired);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.GetFilteredWithPagingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchText** | **string?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |
| **isDeleted** | **bool?** |  | [optional]  |
| **registrationPlateRequired** | **bool?** |  | [optional]  |

### Return type

[**List&lt;VehicleModel&gt;**](VehicleModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vehiclegetfleetageget"></a>
# **GetFleetAge**
> double GetFleetAge ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class GetFleetAgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);

            try
            {
                double result = apiInstance.GetFleetAge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.GetFleetAge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFleetAgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<double> response = apiInstance.GetFleetAgeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.GetFleetAgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**double**

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vehicleiddelete"></a>
# **Delete**
> void Delete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.Delete: " + e.Message);
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
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.DeleteWithHttpInfo: " + e.Message);
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

<a id="vehicleidget"></a>
# **Get**
> VehicleModel Get (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                VehicleModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.Get: " + e.Message);
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
    ApiResponse<VehicleModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**VehicleModel**](VehicleModel.md)

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

<a id="vehicleidput"></a>
# **Put**
> VehicleModel Put (Guid id, UpdateVehicleRequest? updateVehicleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var id = "id_example";  // Guid | 
            var updateVehicleRequest = new UpdateVehicleRequest?(); // UpdateVehicleRequest? |  (optional) 

            try
            {
                VehicleModel result = apiInstance.Put(id, updateVehicleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.Put: " + e.Message);
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
    ApiResponse<VehicleModel> response = apiInstance.PutWithHttpInfo(id, updateVehicleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateVehicleRequest** | [**UpdateVehicleRequest?**](UpdateVehicleRequest?.md) |  | [optional]  |

### Return type

[**VehicleModel**](VehicleModel.md)

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

<a id="vehiclepost"></a>
# **Post**
> VehicleModel Post (CreateVehicleRequest? createVehicleRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VehicleClient(config);
            var createVehicleRequest = new CreateVehicleRequest?(); // CreateVehicleRequest? |  (optional) 

            try
            {
                VehicleModel result = apiInstance.Post(createVehicleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VehicleClient.Post: " + e.Message);
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
    ApiResponse<VehicleModel> response = apiInstance.PostWithHttpInfo(createVehicleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VehicleClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createVehicleRequest** | [**CreateVehicleRequest?**](CreateVehicleRequest?.md) |  | [optional]  |

### Return type

[**VehicleModel**](VehicleModel.md)

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

