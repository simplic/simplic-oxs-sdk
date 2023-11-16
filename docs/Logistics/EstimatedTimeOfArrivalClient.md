# Simplic.OxS.SDK.Logistics.EstimatedTimeOfArrivalClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalgetallget) | **GET** /EstimatedTimeOfArrival/get-all | Retrives all etas for the current organization. |
| [**GetByTour**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalgetbytouridget) | **GET** /EstimatedTimeOfArrival/get-by-tour/{id} | Retrives the eta with the given tourId. |
| [**Get**](EstimatedTimeOfArrivalClient.md#estimatedtimeofarrivalidget) | **GET** /EstimatedTimeOfArrival/{id} | Retrives the eta with the given id. |

<a id="estimatedtimeofarrivalgetallget"></a>
# **GetAll**
> List&lt;EstimatedTimeOfArrivalResponse&gt; GetAll ()

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
    public class GetAllExample
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
                List<EstimatedTimeOfArrivalResponse> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.GetAll: " + e.Message);
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
    // Retrives all etas for the current organization.
    ApiResponse<List<EstimatedTimeOfArrivalResponse>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.GetAllWithHttpInfo: " + e.Message);
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
# **GetByTour**
> EstimatedTimeOfArrivalResponse GetByTour (string id, Guid? tourId = null)

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
    public class GetByTourExample
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
                EstimatedTimeOfArrivalResponse result = apiInstance.GetByTour(id, tourId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.GetByTour: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByTourWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrives the eta with the given tourId.
    ApiResponse<EstimatedTimeOfArrivalResponse> response = apiInstance.GetByTourWithHttpInfo(id, tourId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.GetByTourWithHttpInfo: " + e.Message);
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
# **Get**
> EstimatedTimeOfArrivalResponse Get (Guid id)

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
    public class GetExample
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
                EstimatedTimeOfArrivalResponse result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.Get: " + e.Message);
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
    // Retrives the eta with the given id.
    ApiResponse<EstimatedTimeOfArrivalResponse> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EstimatedTimeOfArrivalClient.GetWithHttpInfo: " + e.Message);
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

