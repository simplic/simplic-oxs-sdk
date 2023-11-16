# Simplic.OxS.SDK.Auth.InternalUserClient

All URIs are relative to *https://dev-oxs.simplic.io/auth-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByEmail**](InternalUserClient.md#internalinternalusergetbyemailget) | **GET** /internal/InternalUser/get-by-email | Get a user by its e-mail address |
| [**GetById**](InternalUserClient.md#internalinternalusergetbyidget) | **GET** /internal/InternalUser/get-by-id | Get a user by its id |

<a id="internalinternalusergetbyemailget"></a>
# **GetByEmail**
> RequestUserResponse GetByEmail (string? email = null)

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
    public class GetByEmailExample
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
                RequestUserResponse result = apiInstance.GetByEmail(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalUserClient.GetByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user by its e-mail address
    ApiResponse<RequestUserResponse> response = apiInstance.GetByEmailWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalUserClient.GetByEmailWithHttpInfo: " + e.Message);
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
# **GetById**
> RequestUserResponse GetById (Guid? id = null)

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
    public class GetByIdExample
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
                RequestUserResponse result = apiInstance.GetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalUserClient.GetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user by its id
    ApiResponse<RequestUserResponse> response = apiInstance.GetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalUserClient.GetByIdWithHttpInfo: " + e.Message);
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

