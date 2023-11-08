# Simplic.OxS.SDK.Auth.InternalUserClient

All URIs are relative to *https://dev-oxs.simplic.io/auth-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InternalInternalUserGetByEmailGet**](InternalUserClient.md#internalinternalusergetbyemailget) | **GET** /internal/InternalUser/get-by-email | Get a user by its e-mail address |
| [**InternalInternalUserGetByIdGet**](InternalUserClient.md#internalinternalusergetbyidget) | **GET** /internal/InternalUser/get-by-id | Get a user by its id |

<a id="internalinternalusergetbyemailget"></a>
# **InternalInternalUserGetByEmailGet**
> RequestUserResponse InternalInternalUserGetByEmailGet (string? email = null)

Get a user by its e-mail address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class InternalInternalUserGetByEmailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalUserClient(config);
            var email = "email_example";  // string? |  (optional) 

            try
            {
                // Get a user by its e-mail address
                RequestUserResponse result = apiInstance.InternalInternalUserGetByEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalUserClient.InternalInternalUserGetByEmailGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalUserGetByEmailGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user by its e-mail address
    ApiResponse<RequestUserResponse> response = apiInstance.InternalInternalUserGetByEmailGetWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalUserClient.InternalInternalUserGetByEmailGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** |  | [optional]  |

### Return type

[**RequestUserResponse**](RequestUserResponse.md)

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
| **502** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="internalinternalusergetbyidget"></a>
# **InternalInternalUserGetByIdGet**
> RequestUserResponse InternalInternalUserGetByIdGet (Guid? id = null)

Get a user by its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class InternalInternalUserGetByIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalUserClient(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                // Get a user by its id
                RequestUserResponse result = apiInstance.InternalInternalUserGetByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalUserClient.InternalInternalUserGetByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalUserGetByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user by its id
    ApiResponse<RequestUserResponse> response = apiInstance.InternalInternalUserGetByIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalUserClient.InternalInternalUserGetByIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**RequestUserResponse**](RequestUserResponse.md)

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
| **502** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

