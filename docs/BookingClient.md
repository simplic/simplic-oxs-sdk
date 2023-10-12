# Simplic.OxS.SDK.TimeSlot.BookingClient

All URIs are relative to *https://dev-oxs.simplic.io/timeslot-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookingCancelBookingIdDelete**](BookingClient.md#bookingcancelbookingiddelete) | **DELETE** /Booking/cancel-booking/{id} | Removes a time slot booking the a time slot |
| [**BookingCreateBookingIdPut**](BookingClient.md#bookingcreatebookingidput) | **PUT** /Booking/create-booking/{id} | Book a time slot |
| [**BookingIdGet**](BookingClient.md#bookingidget) | **GET** /Booking/{id} | Gets a time slot for the current foreign organization by its id |
| [**BookingUpdateBookingIdPut**](BookingClient.md#bookingupdatebookingidput) | **PUT** /Booking/update-booking/{id} | Updates an existing booking |

<a id="bookingcancelbookingiddelete"></a>
# **BookingCancelBookingIdDelete**
> void BookingCancelBookingIdDelete (Guid id)

Removes a time slot booking the a time slot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class BookingCancelBookingIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingClient(config);
            var id = "id_example";  // Guid | Unique time-slot id

            try
            {
                // Removes a time slot booking the a time slot
                apiInstance.BookingCancelBookingIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingClient.BookingCancelBookingIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingCancelBookingIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a time slot booking the a time slot
    apiInstance.BookingCancelBookingIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingClient.BookingCancelBookingIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique time-slot id |  |

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

<a id="bookingcreatebookingidput"></a>
# **BookingCreateBookingIdPut**
> TimeSlotModel BookingCreateBookingIdPut (Guid id, CreateTimeSlotBookingRequest? createTimeSlotBookingRequest = null)

Book a time slot

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class BookingCreateBookingIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingClient(config);
            var id = "id_example";  // Guid | 
            var createTimeSlotBookingRequest = new CreateTimeSlotBookingRequest?(); // CreateTimeSlotBookingRequest? | Booking request (optional) 

            try
            {
                // Book a time slot
                TimeSlotModel result = apiInstance.BookingCreateBookingIdPut(id, createTimeSlotBookingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingClient.BookingCreateBookingIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingCreateBookingIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Book a time slot
    ApiResponse<TimeSlotModel> response = apiInstance.BookingCreateBookingIdPutWithHttpInfo(id, createTimeSlotBookingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingClient.BookingCreateBookingIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **createTimeSlotBookingRequest** | [**CreateTimeSlotBookingRequest?**](CreateTimeSlotBookingRequest?.md) | Booking request | [optional]  |

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

<a id="bookingidget"></a>
# **BookingIdGet**
> TimeSlotModel BookingIdGet (Guid id)

Gets a time slot for the current foreign organization by its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class BookingIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingClient(config);
            var id = "id_example";  // Guid | Uniqiue time slot id

            try
            {
                // Gets a time slot for the current foreign organization by its id
                TimeSlotModel result = apiInstance.BookingIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingClient.BookingIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a time slot for the current foreign organization by its id
    ApiResponse<TimeSlotModel> response = apiInstance.BookingIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingClient.BookingIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Uniqiue time slot id |  |

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

<a id="bookingupdatebookingidput"></a>
# **BookingUpdateBookingIdPut**
> TimeSlotModel BookingUpdateBookingIdPut (Guid id, UpdateTimeSlotBookingRequest? updateTimeSlotBookingRequest = null)

Updates an existing booking

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;
using Simplic.OxS.SDK.TimeSlot;

namespace Example
{
    public class BookingUpdateBookingIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/timeslot-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BookingClient(config);
            var id = "id_example";  // Guid | Unique time slot id
            var updateTimeSlotBookingRequest = new UpdateTimeSlotBookingRequest?(); // UpdateTimeSlotBookingRequest? | Update request (optional) 

            try
            {
                // Updates an existing booking
                TimeSlotModel result = apiInstance.BookingUpdateBookingIdPut(id, updateTimeSlotBookingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookingClient.BookingUpdateBookingIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookingUpdateBookingIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an existing booking
    ApiResponse<TimeSlotModel> response = apiInstance.BookingUpdateBookingIdPutWithHttpInfo(id, updateTimeSlotBookingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookingClient.BookingUpdateBookingIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique time slot id |  |
| **updateTimeSlotBookingRequest** | [**UpdateTimeSlotBookingRequest?**](UpdateTimeSlotBookingRequest?.md) | Update request | [optional]  |

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

