# Simplic.OxS.SDK.vehicle-temperature.TemperatureSDK

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TemperatureByDateVehicleIdGet**](TemperatureSDK.md#temperaturebydatevehicleidget) | **GET** /Temperature/by-date/{vehicleId} |  |
| [**TemperaturePost**](TemperatureSDK.md#temperaturepost) | **POST** /Temperature |  |
| [**TemperatureVehicleIdGet**](TemperatureSDK.md#temperaturevehicleidget) | **GET** /Temperature/{vehicleId} |  |

<a id="temperaturebydatevehicleidget"></a>
# **TemperatureByDateVehicleIdGet**
> List&lt;GetTemperatureResponse&gt; TemperatureByDateVehicleIdGet (Guid vehicleId, DateTime? from = null, DateTime? to = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;

namespace Example
{
    public class TemperatureByDateVehicleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemperatureSDK(config);
            var vehicleId = "vehicleId_example";  // Guid | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                List<GetTemperatureResponse> result = apiInstance.TemperatureByDateVehicleIdGet(vehicleId, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureSDK.TemperatureByDateVehicleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemperatureByDateVehicleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GetTemperatureResponse>> response = apiInstance.TemperatureByDateVehicleIdGetWithHttpInfo(vehicleId, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureSDK.TemperatureByDateVehicleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;GetTemperatureResponse&gt;**](GetTemperatureResponse.md)

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

<a id="temperaturepost"></a>
# **TemperaturePost**
> List&lt;GetTemperatureResponse&gt; TemperaturePost (PostTemperatureRequest? postTemperatureRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;

namespace Example
{
    public class TemperaturePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemperatureSDK(config);
            var postTemperatureRequest = new PostTemperatureRequest?(); // PostTemperatureRequest? |  (optional) 

            try
            {
                List<GetTemperatureResponse> result = apiInstance.TemperaturePost(postTemperatureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureSDK.TemperaturePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemperaturePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GetTemperatureResponse>> response = apiInstance.TemperaturePostWithHttpInfo(postTemperatureRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureSDK.TemperaturePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postTemperatureRequest** | [**PostTemperatureRequest?**](PostTemperatureRequest?.md) |  | [optional]  |

### Return type

[**List&lt;GetTemperatureResponse&gt;**](GetTemperatureResponse.md)

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

<a id="temperaturevehicleidget"></a>
# **TemperatureVehicleIdGet**
> VehicleDetailsResponse TemperatureVehicleIdGet (Guid vehicleId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;
using Simplic.OxS.SDK.vehicle-temperature;

namespace Example
{
    public class TemperatureVehicleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemperatureSDK(config);
            var vehicleId = "vehicleId_example";  // Guid | 

            try
            {
                VehicleDetailsResponse result = apiInstance.TemperatureVehicleIdGet(vehicleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureSDK.TemperatureVehicleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemperatureVehicleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VehicleDetailsResponse> response = apiInstance.TemperatureVehicleIdGetWithHttpInfo(vehicleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureSDK.TemperatureVehicleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |

### Return type

[**VehicleDetailsResponse**](VehicleDetailsResponse.md)

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

