# Simplic.OxS.SDK.Telematic.TelematicClient

All URIs are relative to *https://dev-oxs.simplic.io/telematic-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReadJob**](TelematicClient.md#telematiccreatereadjobput) | **PUT** /Telematic/create-read-job |  |
| [**DeleteReadJob**](TelematicClient.md#telematicdeletereadjobdelete) | **DELETE** /Telematic/delete-read-job |  |
| [**GetAvailableServices**](TelematicClient.md#telematicgetavailableservicesget) | **GET** /Telematic/get-available-services |  |

<a id="telematiccreatereadjobput"></a>
# **CreateReadJob**
> void CreateReadJob (CreateReadJobRequest? createReadJobRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class CreateReadJobExample
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
                apiInstance.CreateReadJob(createReadJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.CreateReadJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReadJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateReadJobWithHttpInfo(createReadJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.CreateReadJobWithHttpInfo: " + e.Message);
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
# **DeleteReadJob**
> void DeleteReadJob (DeleteReadJobRequest? deleteReadJobRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class DeleteReadJobExample
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
                apiInstance.DeleteReadJob(deleteReadJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.DeleteReadJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReadJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteReadJobWithHttpInfo(deleteReadJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.DeleteReadJobWithHttpInfo: " + e.Message);
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
# **GetAvailableServices**
> AvailableServices GetAvailableServices ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;
using Simplic.OxS.SDK.Telematic;

namespace Example
{
    public class GetAvailableServicesExample
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
                AvailableServices result = apiInstance.GetAvailableServices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TelematicClient.GetAvailableServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AvailableServices> response = apiInstance.GetAvailableServicesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TelematicClient.GetAvailableServicesWithHttpInfo: " + e.Message);
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

