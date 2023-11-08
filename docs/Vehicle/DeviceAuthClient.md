# Simplic.OxS.SDK.Vehicle.DeviceAuthClient

All URIs are relative to *https://dev-oxs.simplic.io/vehicle-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeviceAuthGet**](DeviceAuthClient.md#deviceauthget) | **GET** /DeviceAuth |  |
| [**DeviceAuthLoginPost**](DeviceAuthClient.md#deviceauthloginpost) | **POST** /DeviceAuth/login |  |
| [**DeviceAuthLogoutPost**](DeviceAuthClient.md#deviceauthlogoutpost) | **POST** /DeviceAuth/logout |  |
| [**DeviceAuthRefreshTokenPost**](DeviceAuthClient.md#deviceauthrefreshtokenpost) | **POST** /DeviceAuth/refresh-token |  |

<a id="deviceauthget"></a>
# **DeviceAuthGet**
> DeviceModel DeviceAuthGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class DeviceAuthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceAuthClient(config);

            try
            {
                DeviceModel result = apiInstance.DeviceAuthGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeviceAuthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceModel> response = apiInstance.DeviceAuthGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DeviceModel**](DeviceModel.md)

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

<a id="deviceauthloginpost"></a>
# **DeviceAuthLoginPost**
> DeviceLoginResponse DeviceAuthLoginPost (DeviceLoginRequest? deviceLoginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class DeviceAuthLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceAuthClient(config);
            var deviceLoginRequest = new DeviceLoginRequest?(); // DeviceLoginRequest? |  (optional) 

            try
            {
                DeviceLoginResponse result = apiInstance.DeviceAuthLoginPost(deviceLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeviceAuthLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceLoginResponse> response = apiInstance.DeviceAuthLoginPostWithHttpInfo(deviceLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deviceLoginRequest** | [**DeviceLoginRequest?**](DeviceLoginRequest?.md) |  | [optional]  |

### Return type

[**DeviceLoginResponse**](DeviceLoginResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deviceauthlogoutpost"></a>
# **DeviceAuthLogoutPost**
> void DeviceAuthLogoutPost (DeviceLogoutRequest? deviceLogoutRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class DeviceAuthLogoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceAuthClient(config);
            var deviceLogoutRequest = new DeviceLogoutRequest?(); // DeviceLogoutRequest? |  (optional) 

            try
            {
                apiInstance.DeviceAuthLogoutPost(deviceLogoutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthLogoutPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeviceAuthLogoutPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeviceAuthLogoutPostWithHttpInfo(deviceLogoutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthLogoutPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deviceLogoutRequest** | [**DeviceLogoutRequest?**](DeviceLogoutRequest?.md) |  | [optional]  |

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

<a id="deviceauthrefreshtokenpost"></a>
# **DeviceAuthRefreshTokenPost**
> DeviceLoginResponse DeviceAuthRefreshTokenPost (RefreshTokenRequest? refreshTokenRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;
using Simplic.OxS.SDK.Vehicle;

namespace Example
{
    public class DeviceAuthRefreshTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/vehicle-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeviceAuthClient(config);
            var refreshTokenRequest = new RefreshTokenRequest?(); // RefreshTokenRequest? |  (optional) 

            try
            {
                DeviceLoginResponse result = apiInstance.DeviceAuthRefreshTokenPost(refreshTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthRefreshTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeviceAuthRefreshTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceLoginResponse> response = apiInstance.DeviceAuthRefreshTokenPostWithHttpInfo(refreshTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceAuthClient.DeviceAuthRefreshTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshTokenRequest** | [**RefreshTokenRequest?**](RefreshTokenRequest?.md) |  | [optional]  |

### Return type

[**DeviceLoginResponse**](DeviceLoginResponse.md)

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

