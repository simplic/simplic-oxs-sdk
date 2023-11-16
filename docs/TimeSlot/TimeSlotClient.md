# Simplic.OxS.SDK.TimeSlot.TimeSlotClient

All URIs are relative to *https://dev-oxs.simplic.io/timeslot-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByDate**](TimeSlotClient.md#timeslotgetbydateget) | **GET** /TimeSlot/get-by-date | Gets a list of time slots by a specific date range |
| [**Delete**](TimeSlotClient.md#timeslotiddelete) | **DELETE** /TimeSlot/{id} | Deletes a time slot |
| [**Get**](TimeSlotClient.md#timeslotidget) | **GET** /TimeSlot/{id} | Gets a time slot by its unique id |
| [**Put**](TimeSlotClient.md#timeslotidput) | **PUT** /TimeSlot/{id} | Updates an existing time slot |
| [**Post**](TimeSlotClient.md#timeslotpost) | **POST** /TimeSlot | Creates a new time slot |
| [**SetState**](TimeSlotClient.md#timeslotsetstateput) | **PUT** /TimeSlot/set-state | Sets a given bookingstate |

<a id="timeslotgetbydateget"></a>
# **GetByDate**
> List&lt;TimeSlotModel&gt; GetByDate (Guid? siteId = null, DateTime? start = null, DateTime? end = null)

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
    public class GetByDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var siteId = "siteId_example";  // Guid? |  (optional) 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start date time (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End date time (optional) 

            try
            {
                // Gets a list of time slots by a specific date range
                List<TimeSlotModel> result = apiInstance.GetByDate(siteId, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.GetByDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of time slots by a specific date range
    ApiResponse<List<TimeSlotModel>> response = apiInstance.GetByDateWithHttpInfo(siteId, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.GetByDateWithHttpInfo: " + e.Message);
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
# **Delete**
> void Delete (Guid id)

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
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var id = "id_example";  // Guid | Id of the time slot

            try
            {
                // Deletes a time slot
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.Delete: " + e.Message);
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
    // Deletes a time slot
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.DeleteWithHttpInfo: " + e.Message);
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
# **Get**
> TimeSlotModel Get (Guid id)

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
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var id = "id_example";  // Guid | Unique time slot id

            try
            {
                // Gets a time slot by its unique id
                TimeSlotModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.Get: " + e.Message);
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
    // Gets a time slot by its unique id
    ApiResponse<TimeSlotModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.GetWithHttpInfo: " + e.Message);
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
# **Put**
> TimeSlotModel Put (Guid id, UpdateTimeSlotRequest? updateTimeSlotRequest = null)

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
    public class PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var id = "id_example";  // Guid | Unique timeslot id
            var updateTimeSlotRequest = new UpdateTimeSlotRequest?(); // UpdateTimeSlotRequest? | Time slot model to update (optional) 

            try
            {
                // Updates an existing time slot
                TimeSlotModel result = apiInstance.Put(id, updateTimeSlotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.Put: " + e.Message);
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
    // Updates an existing time slot
    ApiResponse<TimeSlotModel> response = apiInstance.PutWithHttpInfo(id, updateTimeSlotRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.PutWithHttpInfo: " + e.Message);
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
# **Post**
> TimeSlotModel Post (CreateTimeSlotRequest? createTimeSlotRequest = null)

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
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var createTimeSlotRequest = new CreateTimeSlotRequest?(); // CreateTimeSlotRequest? | Model containing all time slot details (optional) 

            try
            {
                // Creates a new time slot
                TimeSlotModel result = apiInstance.Post(createTimeSlotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.Post: " + e.Message);
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
    // Creates a new time slot
    ApiResponse<TimeSlotModel> response = apiInstance.PostWithHttpInfo(createTimeSlotRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.PostWithHttpInfo: " + e.Message);
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
# **SetState**
> void SetState (Guid? id = null, int? bookingState = null)

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
    public class SetStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimeSlotClient(config);
            var id = "id_example";  // Guid? | Id of the time slot (optional) 
            var bookingState = 56;  // int? | Int of the Bookingstate              [0 = Open]              [1 = Booked]              [2 = Canceled]              [3 = Done]              [4 = Locked] (optional) 

            try
            {
                // Sets a given bookingstate
                apiInstance.SetState(id, bookingState);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeSlotClient.SetState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets a given bookingstate
    apiInstance.SetStateWithHttpInfo(id, bookingState);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeSlotClient.SetStateWithHttpInfo: " + e.Message);
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

