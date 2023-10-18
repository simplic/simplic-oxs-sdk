# Simplic.OxS.SDK.Telematic.TelematicClient

All URIs are relative to *https://dev-oxs.simplic.io/telematic-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TelematicCreateReadJobPut**](TelematicClient.md#telematiccreatereadjobput) | **PUT** /Telematic/create-read-job |  |
| [**TelematicDeleteReadJobDelete**](TelematicClient.md#telematicdeletereadjobdelete) | **DELETE** /Telematic/delete-read-job |  |
| [**TelematicGetAvailableServicesGet**](TelematicClient.md#telematicgetavailableservicesget) | **GET** /Telematic/get-available-services |  |

<a id="telematiccreatereadjobput"></a>
# **TelematicCreateReadJobPut**
> void TelematicCreateReadJobPut (CreateReadJobRequest? createReadJobRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicCreateReadJobPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TelematicClient(config);
            var createReadJobRequest = new CreateReadJobRequest?(); // CreateReadJobRequest? |  (optional) 

            try
            {
                apiInstance.TelematicCreateReadJobPut(createReadJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.TelematicCreateReadJobPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicCreateReadJobPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TelematicCreateReadJobPutWithHttpInfo(createReadJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.TelematicCreateReadJobPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createReadJobRequest** | [**CreateReadJobRequest?**](CreateReadJobRequest?.md) |  | [optional]  |

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

<a id="telematicdeletereadjobdelete"></a>
# **TelematicDeleteReadJobDelete**
> void TelematicDeleteReadJobDelete (DeleteReadJobRequest? deleteReadJobRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicDeleteReadJobDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TelematicClient(config);
            var deleteReadJobRequest = new DeleteReadJobRequest?(); // DeleteReadJobRequest? |  (optional) 

            try
            {
                apiInstance.TelematicDeleteReadJobDelete(deleteReadJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.TelematicDeleteReadJobDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicDeleteReadJobDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TelematicDeleteReadJobDeleteWithHttpInfo(deleteReadJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.TelematicDeleteReadJobDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteReadJobRequest** | [**DeleteReadJobRequest?**](DeleteReadJobRequest?.md) |  | [optional]  |

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

<a id="telematicgetavailableservicesget"></a>
# **TelematicGetAvailableServicesGet**
> AvailableServices TelematicGetAvailableServicesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class TelematicGetAvailableServicesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/telematic-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TelematicClient(config);

            try
            {
                AvailableServices result = apiInstance.TelematicGetAvailableServicesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.TelematicGetAvailableServicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TelematicGetAvailableServicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AvailableServices> response = apiInstance.TelematicGetAvailableServicesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.TelematicGetAvailableServicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AvailableServices**](AvailableServices.md)

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

