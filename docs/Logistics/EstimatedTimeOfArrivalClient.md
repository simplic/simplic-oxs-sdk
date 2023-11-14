# Simplic.OxS.SDK.Logistics.EstimatedTimeOfArrivalClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EstimatedTimeOfArrivalGetAllGet**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalgetallget) | **GET** /EstimatedTimeOfArrival/get-all | Retrives all etas for the current organization. |
| [**EstimatedTimeOfArrivalGetByTourIdGet**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalgetbytouridget) | **GET** /EstimatedTimeOfArrival/get-by-tour/{id} | Retrives the eta with the given tourId. |
| [**EstimatedTimeOfArrivalIdGet**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalidget) | **GET** /EstimatedTimeOfArrival/{id} | Retrives the eta with the given id. |

<a id="estimatedtimeofarrivalgetallget"></a>
# **EstimatedTimeOfArrivalGetAllGet**
> List&lt;EstimatedTimeOfArrivalResponse&gt; EstimatedTimeOfArrivalGetAllGet ()

Retrives all etas for the current organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class EstimatedTimeOfArrivalGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EstimatedTimeOfArrivalClient(config);

            try
            {
                // Retrives all etas for the current organization.
                List<EstimatedTimeOfArrivalResponse> result = apiInstance.EstimatedTimeOfArrivalGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EstimatedTimeOfArrivalGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives all etas for the current organization.
    ApiResponse<List<EstimatedTimeOfArrivalResponse>> response = apiInstance.EstimatedTimeOfArrivalGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EstimatedTimeOfArrivalResponse&gt;**](EstimatedTimeOfArrivalResponse.md)

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

<a id="estimatedtimeofarrivalgetbytouridget"></a>
# **EstimatedTimeOfArrivalGetByTourIdGet**
> EstimatedTimeOfArrivalResponse EstimatedTimeOfArrivalGetByTourIdGet (string id, Guid? tourId = null)

Retrives the eta with the given tourId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class EstimatedTimeOfArrivalGetByTourIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EstimatedTimeOfArrivalClient(config);
            var id = "id_example";  // string | 
            var tourId = "tourId_example";  // Guid? | Id of a tour. (optional) 

            try
            {
                // Retrives the eta with the given tourId.
                EstimatedTimeOfArrivalResponse result = apiInstance.EstimatedTimeOfArrivalGetByTourIdGet(id, tourId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalGetByTourIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EstimatedTimeOfArrivalGetByTourIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the eta with the given tourId.
    ApiResponse<EstimatedTimeOfArrivalResponse> response = apiInstance.EstimatedTimeOfArrivalGetByTourIdGetWithHttpInfo(id, tourId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalGetByTourIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **tourId** | **Guid?** | Id of a tour. | [optional]  |

### Return type

[**EstimatedTimeOfArrivalResponse**](EstimatedTimeOfArrivalResponse.md)

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

<a id="estimatedtimeofarrivalidget"></a>
# **EstimatedTimeOfArrivalIdGet**
> EstimatedTimeOfArrivalResponse EstimatedTimeOfArrivalIdGet (Guid id)

Retrives the eta with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class EstimatedTimeOfArrivalIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EstimatedTimeOfArrivalClient(config);
            var id = "id_example";  // Guid | Id of the eta.

            try
            {
                // Retrives the eta with the given id.
                EstimatedTimeOfArrivalResponse result = apiInstance.EstimatedTimeOfArrivalIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EstimatedTimeOfArrivalIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the eta with the given id.
    ApiResponse<EstimatedTimeOfArrivalResponse> response = apiInstance.EstimatedTimeOfArrivalIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.EstimatedTimeOfArrivalIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the eta. |  |

### Return type

[**EstimatedTimeOfArrivalResponse**](EstimatedTimeOfArrivalResponse.md)

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

