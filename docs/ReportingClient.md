# Simplic.OxS.SDK.Vehicle.Temperature.ReportingClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportingGenerateReportVehicleIdGet**](ReportingClient.md#reportinggeneratereportvehicleidget) | **GET** /Reporting/generate-report/{vehicleId} |  |
| [**ReportingGetMapReportInstanceIdGet**](ReportingClient.md#reportinggetmapreportinstanceidget) | **GET** /Reporting/get-map/{reportInstanceId} |  |
| [**ReportingGetRecipientsGet**](ReportingClient.md#reportinggetrecipientsget) | **GET** /Reporting/get-recipients |  |
| [**ReportingSendReportPost**](ReportingClient.md#reportingsendreportpost) | **POST** /Reporting/send-report |  |

<a id="reportinggeneratereportvehicleidget"></a>
# **ReportingGenerateReportVehicleIdGet**
> LocationReportModel ReportingGenerateReportVehicleIdGet (Guid vehicleId, DateTime? startDate = null, DateTime? endDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class ReportingGenerateReportVehicleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportingClient(config);
            var vehicleId = "vehicleId_example";  // Guid | 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                LocationReportModel result = apiInstance.ReportingGenerateReportVehicleIdGet(vehicleId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.ReportingGenerateReportVehicleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingGenerateReportVehicleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LocationReportModel> response = apiInstance.ReportingGenerateReportVehicleIdGetWithHttpInfo(vehicleId, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.ReportingGenerateReportVehicleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleId** | **Guid** |  |  |
| **startDate** | **DateTime?** |  | [optional]  |
| **endDate** | **DateTime?** |  | [optional]  |

### Return type

[**LocationReportModel**](LocationReportModel.md)

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

<a id="reportinggetmapreportinstanceidget"></a>
# **ReportingGetMapReportInstanceIdGet**
> void ReportingGetMapReportInstanceIdGet (Guid reportInstanceId, int? width = null, int? height = null, string? color = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class ReportingGetMapReportInstanceIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportingClient(config);
            var reportInstanceId = "reportInstanceId_example";  // Guid | 
            var width = 400;  // int? |  (optional)  (default to 400)
            var height = 400;  // int? |  (optional)  (default to 400)
            var color = "\"ff0000\"";  // string? |  (optional)  (default to "ff0000")

            try
            {
                apiInstance.ReportingGetMapReportInstanceIdGet(reportInstanceId, width, height, color);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.ReportingGetMapReportInstanceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingGetMapReportInstanceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReportingGetMapReportInstanceIdGetWithHttpInfo(reportInstanceId, width, height, color);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.ReportingGetMapReportInstanceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reportInstanceId** | **Guid** |  |  |
| **width** | **int?** |  | [optional] [default to 400] |
| **height** | **int?** |  | [optional] [default to 400] |
| **color** | **string?** |  | [optional] [default to &quot;ff0000&quot;] |

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

<a id="reportinggetrecipientsget"></a>
# **ReportingGetRecipientsGet**
> void ReportingGetRecipientsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class ReportingGetRecipientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportingClient(config);

            try
            {
                apiInstance.ReportingGetRecipientsGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.ReportingGetRecipientsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingGetRecipientsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReportingGetRecipientsGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.ReportingGetRecipientsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="reportingsendreportpost"></a>
# **ReportingSendReportPost**
> void ReportingSendReportPost (SendReportRequest? sendReportRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class ReportingSendReportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-temperature-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportingClient(config);
            var sendReportRequest = new SendReportRequest?(); // SendReportRequest? |  (optional) 

            try
            {
                apiInstance.ReportingSendReportPost(sendReportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.ReportingSendReportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportingSendReportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReportingSendReportPostWithHttpInfo(sendReportRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.ReportingSendReportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendReportRequest** | [**SendReportRequest?**](SendReportRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

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

