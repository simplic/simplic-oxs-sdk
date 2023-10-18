# Simplic.OxS.SDK.TimeSlot.TimeSlotSDK

All URIs are relative to *https://dev-oxs.simplic.io/timeslot-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TimeSlotGetByDateGet**](TimeSlotSDK.md#timeslotgetbydateget) | **GET** /TimeSlot/get-by-date | Gets a list of time slots by a specific date range |
| [**TimeSlotIdDelete**](TimeSlotSDK.md#timeslotiddelete) | **DELETE** /TimeSlot/{id} | Deletes a time slot |
| [**TimeSlotIdGet**](TimeSlotSDK.md#timeslotidget) | **GET** /TimeSlot/{id} | Gets a time slot by its unique id |
| [**TimeSlotIdPut**](TimeSlotSDK.md#timeslotidput) | **PUT** /TimeSlot/{id} | Updates an existing time slot |
| [**TimeSlotPost**](TimeSlotSDK.md#timeslotpost) | **POST** /TimeSlot | Creates a new time slot |
| [**TimeSlotSetStatePut**](TimeSlotSDK.md#timeslotsetstateput) | **PUT** /TimeSlot/set-state | Sets a given bookingstate |

<a id="timeslotgetbydateget"></a>
# **TimeSlotGetByDateGet**
> List&lt;TimeSlotModel&gt; TimeSlotGetByDateGet (Guid? siteId = null, DateTime? start = null, DateTime? end = null)

Gets a list of time slots by a specific date range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotGetByDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var siteId = "siteId_example";  // Guid? |  (optional) 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start date time (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End date time (optional) 

            try
            {
                // Gets a list of time slots by a specific date range
                List<TimeSlotModel> result = apiInstance.TimeSlotGetByDateGet(siteId, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotGetByDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotGetByDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of time slots by a specific date range
    ApiResponse<List<TimeSlotModel>> response = apiInstance.TimeSlotGetByDateGetWithHttpInfo(siteId, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotGetByDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **siteId** | **Guid?** |  | [optional]  |
| **start** | **DateTime?** | Start date time | [optional]  |
| **end** | **DateTime?** | End date time | [optional]  |

### Return type

[**List&lt;TimeSlotModel&gt;**](TimeSlotModel.md)

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

<a id="timeslotiddelete"></a>
# **TimeSlotIdDelete**
> void TimeSlotIdDelete (Guid id)

Deletes a time slot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var id = "id_example";  // Guid | Id of the time slot

            try
            {
                // Deletes a time slot
                apiInstance.TimeSlotIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a time slot
    apiInstance.TimeSlotIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the time slot |  |

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

<a id="timeslotidget"></a>
# **TimeSlotIdGet**
> TimeSlotModel TimeSlotIdGet (Guid id)

Gets a time slot by its unique id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var id = "id_example";  // Guid | Unique time slot id

            try
            {
                // Gets a time slot by its unique id
                TimeSlotModel result = apiInstance.TimeSlotIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a time slot by its unique id
    ApiResponse<TimeSlotModel> response = apiInstance.TimeSlotIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique time slot id |  |

### Return type

[**TimeSlotModel**](TimeSlotModel.md)

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

<a id="timeslotidput"></a>
# **TimeSlotIdPut**
> TimeSlotModel TimeSlotIdPut (Guid id, UpdateTimeSlotRequest? updateTimeSlotRequest = null)

Updates an existing time slot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var id = "id_example";  // Guid | Unique timeslot id
            var updateTimeSlotRequest = new UpdateTimeSlotRequest?(); // UpdateTimeSlotRequest? | Time slot model to update (optional) 

            try
            {
                // Updates an existing time slot
                TimeSlotModel result = apiInstance.TimeSlotIdPut(id, updateTimeSlotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an existing time slot
    ApiResponse<TimeSlotModel> response = apiInstance.TimeSlotIdPutWithHttpInfo(id, updateTimeSlotRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique timeslot id |  |
| **updateTimeSlotRequest** | [**UpdateTimeSlotRequest?**](UpdateTimeSlotRequest?.md) | Time slot model to update | [optional]  |

### Return type

[**TimeSlotModel**](TimeSlotModel.md)

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

<a id="timeslotpost"></a>
# **TimeSlotPost**
> TimeSlotModel TimeSlotPost (CreateTimeSlotRequest? createTimeSlotRequest = null)

Creates a new time slot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var createTimeSlotRequest = new CreateTimeSlotRequest?(); // CreateTimeSlotRequest? | Model containing all time slot details (optional) 

            try
            {
                // Creates a new time slot
                TimeSlotModel result = apiInstance.TimeSlotPost(createTimeSlotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new time slot
    ApiResponse<TimeSlotModel> response = apiInstance.TimeSlotPostWithHttpInfo(createTimeSlotRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTimeSlotRequest** | [**CreateTimeSlotRequest?**](CreateTimeSlotRequest?.md) | Model containing all time slot details | [optional]  |

### Return type

[**TimeSlotModel**](TimeSlotModel.md)

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

<a id="timeslotsetstateput"></a>
# **TimeSlotSetStatePut**
> void TimeSlotSetStatePut (Guid? id = null, int? bookingState = null)

Sets a given bookingstate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class TimeSlotSetStatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotSDK(config);
            var id = "id_example";  // Guid? | Id of the time slot (optional) 
            var bookingState = 56;  // int? | Int of the Bookingstate              [0 = Open]              [1 = Booked]              [2 = Canceled]              [3 = Done]              [4 = Locked] (optional) 

            try
            {
                // Sets a given bookingstate
                apiInstance.TimeSlotSetStatePut(id, bookingState);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotSDK.TimeSlotSetStatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeSlotSetStatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets a given bookingstate
    apiInstance.TimeSlotSetStatePutWithHttpInfo(id, bookingState);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotSDK.TimeSlotSetStatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** | Id of the time slot | [optional]  |
| **bookingState** | **int?** | Int of the Bookingstate              [0 &#x3D; Open]              [1 &#x3D; Booked]              [2 &#x3D; Canceled]              [3 &#x3D; Done]              [4 &#x3D; Locked] | [optional]  |

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

