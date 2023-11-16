# Simplic.OxS.SDK.Vehicle.Temperature.ReportingClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-temperature-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateReport**](ReportingClient.md#reportinggeneratereportvehicleidget) | **GET** /Reporting/generate-report/{vehicleId} |  |
| [**GetMap**](ReportingClient.md#reportinggetmapreportinstanceidget) | **GET** /Reporting/get-map/{reportInstanceId} |  |
| [**GetRecipients**](ReportingClient.md#reportinggetrecipientsget) | **GET** /Reporting/get-recipients |  |
| [**SendReport**](ReportingClient.md#reportingsendreportpost) | **POST** /Reporting/send-report |  |

<a id="reportinggeneratereportvehicleidget"></a>
# **GenerateReport**
> LocationReportModel GenerateReport (Guid vehicleId, DateTime? startDate = null, DateTime? endDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GenerateReportExample
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
                LocationReportModel result = apiInstance.GenerateReport(vehicleId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.GenerateReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LocationReportModel> response = apiInstance.GenerateReportWithHttpInfo(vehicleId, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.GenerateReportWithHttpInfo: " + e.Message);
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
# **GetMap**
> void GetMap (Guid reportInstanceId, int? width = null, int? height = null, string? color = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GetMapExample
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
                apiInstance.GetMap(reportInstanceId, width, height, color);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.GetMap: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetMapWithHttpInfo(reportInstanceId, width, height, color);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.GetMapWithHttpInfo: " + e.Message);
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
# **GetRecipients**
> void GetRecipients ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class GetRecipientsExample
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
                apiInstance.GetRecipients();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.GetRecipients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecipientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetRecipientsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.GetRecipientsWithHttpInfo: " + e.Message);
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
# **SendReport**
> void SendReport (SendReportRequest? sendReportRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;
using Simplic.OxS.SDK.Vehicle.Temperature;

namespace Example
{
    public class SendReportExample
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
                apiInstance.SendReport(sendReportRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingClient.SendReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SendReportWithHttpInfo(sendReportRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingClient.SendReportWithHttpInfo: " + e.Message);
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

