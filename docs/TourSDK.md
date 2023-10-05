# Simplic.OxS.SDK.Logistics.TourSDK

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TourAddTagToTourPut**](TourSDK.md#touraddtagtotourput) | **PUT** /Tour/add-tag-to-tour |  |
| [**TourConvertShipmentToTourPost**](TourSDK.md#tourconvertshipmenttotourpost) | **POST** /Tour/convert-shipment-to-tour |  |
| [**TourGetAggregatedLoadingSlotsGet**](TourSDK.md#tourgetaggregatedloadingslotsget) | **GET** /Tour/get-aggregated-loading-slots | Get all used loading slots for a specific resource |
| [**TourGetAllByDatesGet**](TourSDK.md#tourgetallbydatesget) | **GET** /Tour/get-all-by-dates | Retrieves all tours between two dates. |
| [**TourGetByGlobalTourIdGet**](TourSDK.md#tourgetbyglobaltouridget) | **GET** /Tour/get-by-global-tour-id | Retrieves all tours with the given global tour id. |
| [**TourGetByShipmentIdGet**](TourSDK.md#tourgetbyshipmentidget) | **GET** /Tour/get-by-shipment-id | Retrieves all tours that contains actions with the given shipment id. |
| [**TourIdDelete**](TourSDK.md#touriddelete) | **DELETE** /Tour/{id} | Deletes the given tour. |
| [**TourIdGet**](TourSDK.md#touridget) | **GET** /Tour/{id} | Retrieves the tour with the given id. |
| [**TourIdPatch**](TourSDK.md#touridpatch) | **PATCH** /Tour/{id} | Patches a tour object. |
| [**TourManipulatePost**](TourSDK.md#tourmanipulatepost) | **POST** /Tour/manipulate | Updates/saves the given tour. |
| [**TourPost**](TourSDK.md#tourpost) | **POST** /Tour | Creates a new tour object. |
| [**TourRemoveTagFromTourPut**](TourSDK.md#tourremovetagfromtourput) | **PUT** /Tour/remove-tag-from-tour |  |
| [**TourSendToTelematicPut**](TourSDK.md#toursendtotelematicput) | **PUT** /Tour/send-to-telematic |  |
| [**TourSetTourActualTimesPut**](TourSDK.md#toursettouractualtimesput) | **PUT** /Tour/set-tour-actual-times | Sets the actual times of a tour. Also gives the option to change the tour status, e.g to started. |

<a id="touraddtagtotourput"></a>
# **TourAddTagToTourPut**
> void TourAddTagToTourPut (AddTagToTourRequest? addTagToTourRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourAddTagToTourPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var addTagToTourRequest = new AddTagToTourRequest?(); // AddTagToTourRequest? |  (optional) 

            try
            {
                apiInstance.TourAddTagToTourPut(addTagToTourRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourAddTagToTourPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourAddTagToTourPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TourAddTagToTourPutWithHttpInfo(addTagToTourRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourAddTagToTourPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addTagToTourRequest** | [**AddTagToTourRequest?**](AddTagToTourRequest?.md) |  | [optional]  |

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

<a id="tourconvertshipmenttotourpost"></a>
# **TourConvertShipmentToTourPost**
> TourModel TourConvertShipmentToTourPost (ShipmentToTourRequest? shipmentToTourRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourConvertShipmentToTourPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var shipmentToTourRequest = new ShipmentToTourRequest?(); // ShipmentToTourRequest? |  (optional) 

            try
            {
                TourModel result = apiInstance.TourConvertShipmentToTourPost(shipmentToTourRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourConvertShipmentToTourPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourConvertShipmentToTourPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TourModel> response = apiInstance.TourConvertShipmentToTourPostWithHttpInfo(shipmentToTourRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourConvertShipmentToTourPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentToTourRequest** | [**ShipmentToTourRequest?**](ShipmentToTourRequest?.md) |  | [optional]  |

### Return type

[**TourModel**](TourModel.md)

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

<a id="tourgetaggregatedloadingslotsget"></a>
# **TourGetAggregatedLoadingSlotsGet**
> List&lt;UsedLoadingSlotAggregationModel&gt; TourGetAggregatedLoadingSlotsGet (Guid? resourceId = null, string? loadingSlotNames = null, int? count = null)

Get all used loading slots for a specific resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourGetAggregatedLoadingSlotsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var resourceId = "resourceId_example";  // Guid? | Resource id (optional) 
            var loadingSlotNames = "loadingSlotNames_example";  // string? | Names of the loading slots to query (comma separated). E.g. K1, K2 (optional) 
            var count = 56;  // int? | Amount of data for each loading slot (optional) 

            try
            {
                // Get all used loading slots for a specific resource
                List<UsedLoadingSlotAggregationModel> result = apiInstance.TourGetAggregatedLoadingSlotsGet(resourceId, loadingSlotNames, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourGetAggregatedLoadingSlotsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourGetAggregatedLoadingSlotsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all used loading slots for a specific resource
    ApiResponse<List<UsedLoadingSlotAggregationModel>> response = apiInstance.TourGetAggregatedLoadingSlotsGetWithHttpInfo(resourceId, loadingSlotNames, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourGetAggregatedLoadingSlotsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | **Guid?** | Resource id | [optional]  |
| **loadingSlotNames** | **string?** | Names of the loading slots to query (comma separated). E.g. K1, K2 | [optional]  |
| **count** | **int?** | Amount of data for each loading slot | [optional]  |

### Return type

[**List&lt;UsedLoadingSlotAggregationModel&gt;**](UsedLoadingSlotAggregationModel.md)

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

<a id="tourgetallbydatesget"></a>
# **TourGetAllByDatesGet**
> List&lt;TourModel&gt; TourGetAllByDatesGet (DateTime? start = null, DateTime? end = null)

Retrieves all tours between two dates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourGetAllByDatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Retrieves all tours between two dates.
                List<TourModel> result = apiInstance.TourGetAllByDatesGet(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourGetAllByDatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourGetAllByDatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all tours between two dates.
    ApiResponse<List<TourModel>> response = apiInstance.TourGetAllByDatesGetWithHttpInfo(start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourGetAllByDatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **DateTime?** |  | [optional]  |
| **end** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;TourModel&gt;**](TourModel.md)

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

<a id="tourgetbyglobaltouridget"></a>
# **TourGetByGlobalTourIdGet**
> List&lt;TourModel&gt; TourGetByGlobalTourIdGet (Guid? id = null)

Retrieves all tours with the given global tour id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourGetByGlobalTourIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                // Retrieves all tours with the given global tour id.
                List<TourModel> result = apiInstance.TourGetByGlobalTourIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourGetByGlobalTourIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourGetByGlobalTourIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all tours with the given global tour id.
    ApiResponse<List<TourModel>> response = apiInstance.TourGetByGlobalTourIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourGetByGlobalTourIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;TourModel&gt;**](TourModel.md)

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

<a id="tourgetbyshipmentidget"></a>
# **TourGetByShipmentIdGet**
> List&lt;TourModel&gt; TourGetByShipmentIdGet (Guid? id = null)

Retrieves all tours that contains actions with the given shipment id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourGetByShipmentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                // Retrieves all tours that contains actions with the given shipment id.
                List<TourModel> result = apiInstance.TourGetByShipmentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourGetByShipmentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourGetByShipmentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all tours that contains actions with the given shipment id.
    ApiResponse<List<TourModel>> response = apiInstance.TourGetByShipmentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourGetByShipmentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;TourModel&gt;**](TourModel.md)

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

<a id="touriddelete"></a>
# **TourIdDelete**
> Object TourIdDelete (Guid id)

Deletes the given tour.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var id = "id_example";  // Guid | Id of a tour to delete.

            try
            {
                // Deletes the given tour.
                Object result = apiInstance.TourIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the given tour.
    ApiResponse<Object> response = apiInstance.TourIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of a tour to delete. |  |

### Return type

**Object**

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

<a id="touridget"></a>
# **TourIdGet**
> TourModel TourIdGet (Guid id)

Retrieves the tour with the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var id = "id_example";  // Guid | Id of the tour.

            try
            {
                // Retrieves the tour with the given id.
                TourModel result = apiInstance.TourIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the tour with the given id.
    ApiResponse<TourModel> response = apiInstance.TourIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the tour. |  |

### Return type

[**TourModel**](TourModel.md)

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

<a id="touridpatch"></a>
# **TourIdPatch**
> TourModel TourIdPatch (Guid id, PatchTourRequest? patchTourRequest = null)

Patches a tour object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var id = "id_example";  // Guid | The id of the tour.
            var patchTourRequest = new PatchTourRequest?(); // PatchTourRequest? | The patch request object. (optional) 

            try
            {
                // Patches a tour object.
                TourModel result = apiInstance.TourIdPatch(id, patchTourRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches a tour object.
    ApiResponse<TourModel> response = apiInstance.TourIdPatchWithHttpInfo(id, patchTourRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the tour. |  |
| **patchTourRequest** | [**PatchTourRequest?**](PatchTourRequest?.md) | The patch request object. | [optional]  |

### Return type

[**TourModel**](TourModel.md)

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

<a id="tourmanipulatepost"></a>
# **TourManipulatePost**
> TourManipulateResponse TourManipulatePost (ManipulateTourRequest? manipulateTourRequest = null)

Updates/saves the given tour.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourManipulatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var manipulateTourRequest = new ManipulateTourRequest?(); // ManipulateTourRequest? |  (optional) 

            try
            {
                // Updates/saves the given tour.
                TourManipulateResponse result = apiInstance.TourManipulatePost(manipulateTourRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourManipulatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourManipulatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates/saves the given tour.
    ApiResponse<TourManipulateResponse> response = apiInstance.TourManipulatePostWithHttpInfo(manipulateTourRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourManipulatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manipulateTourRequest** | [**ManipulateTourRequest?**](ManipulateTourRequest?.md) |  | [optional]  |

### Return type

[**TourManipulateResponse**](TourManipulateResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tourpost"></a>
# **TourPost**
> TourModel TourPost (CreateTourRequest? createTourRequest = null)

Creates a new tour object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var createTourRequest = new CreateTourRequest?(); // CreateTourRequest? | Tour to create. (optional) 

            try
            {
                // Creates a new tour object.
                TourModel result = apiInstance.TourPost(createTourRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new tour object.
    ApiResponse<TourModel> response = apiInstance.TourPostWithHttpInfo(createTourRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTourRequest** | [**CreateTourRequest?**](CreateTourRequest?.md) | Tour to create. | [optional]  |

### Return type

[**TourModel**](TourModel.md)

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

<a id="tourremovetagfromtourput"></a>
# **TourRemoveTagFromTourPut**
> void TourRemoveTagFromTourPut (RemoveTagFromTourRequest? removeTagFromTourRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourRemoveTagFromTourPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var removeTagFromTourRequest = new RemoveTagFromTourRequest?(); // RemoveTagFromTourRequest? |  (optional) 

            try
            {
                apiInstance.TourRemoveTagFromTourPut(removeTagFromTourRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourRemoveTagFromTourPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourRemoveTagFromTourPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TourRemoveTagFromTourPutWithHttpInfo(removeTagFromTourRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourRemoveTagFromTourPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeTagFromTourRequest** | [**RemoveTagFromTourRequest?**](RemoveTagFromTourRequest?.md) |  | [optional]  |

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

<a id="toursendtotelematicput"></a>
# **TourSendToTelematicPut**
> List&lt;UsedLoadingSlotAggregationModel&gt; TourSendToTelematicPut (Guid? tourId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourSendToTelematicPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var tourId = "tourId_example";  // Guid? |  (optional) 

            try
            {
                List<UsedLoadingSlotAggregationModel> result = apiInstance.TourSendToTelematicPut(tourId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourSendToTelematicPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourSendToTelematicPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<UsedLoadingSlotAggregationModel>> response = apiInstance.TourSendToTelematicPutWithHttpInfo(tourId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourSendToTelematicPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tourId** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;UsedLoadingSlotAggregationModel&gt;**](UsedLoadingSlotAggregationModel.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="toursettouractualtimesput"></a>
# **TourSetTourActualTimesPut**
> void TourSetTourActualTimesPut (SetTourActualTimesRequest? setTourActualTimesRequest = null)

Sets the actual times of a tour. Also gives the option to change the tour status, e.g to started.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;
using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class TourSetTourActualTimesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TourSDK(config);
            var setTourActualTimesRequest = new SetTourActualTimesRequest?(); // SetTourActualTimesRequest? | The SetTOurActualTimesRequest object. (optional) 

            try
            {
                // Sets the actual times of a tour. Also gives the option to change the tour status, e.g to started.
                apiInstance.TourSetTourActualTimesPut(setTourActualTimesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TourSDK.TourSetTourActualTimesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TourSetTourActualTimesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the actual times of a tour. Also gives the option to change the tour status, e.g to started.
    apiInstance.TourSetTourActualTimesPutWithHttpInfo(setTourActualTimesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TourSDK.TourSetTourActualTimesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setTourActualTimesRequest** | [**SetTourActualTimesRequest?**](SetTourActualTimesRequest?.md) | The SetTOurActualTimesRequest object. | [optional]  |

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

