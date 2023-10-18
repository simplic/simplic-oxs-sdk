# Simplic.OxS.SDK.Auth.AuthClient

All URIs are relative to *https://dev-oxs.simplic.io/auth-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthChangePasswordPost**](AuthClient.md#authchangepasswordpost) | **POST** /Auth/change-password |  |
| [**AuthLoginPost**](AuthClient.md#authloginpost) | **POST** /Auth/login | Login using username and password. Will return a JWT when logging in was successful. |
| [**AuthRegisterPost**](AuthClient.md#authregisterpost) | **POST** /Auth/register |  |
| [**AuthRestorePasswordPost**](AuthClient.md#authrestorepasswordpost) | **POST** /Auth/restore-password |  |
| [**AuthSelectOrganizationPost**](AuthClient.md#authselectorganizationpost) | **POST** /Auth/select-organization |  |
| [**AuthSendVerificationCodePost**](AuthClient.md#authsendverificationcodepost) | **POST** /Auth/send-verification-code |  |
| [**AuthVerifyMailPost**](AuthClient.md#authverifymailpost) | **POST** /Auth/verify-mail |  |
| [**AuthVerifyTwoFactorPost**](AuthClient.md#authverifytwofactorpost) | **POST** /Auth/verify-two-factor |  |

<a id="authchangepasswordpost"></a>
# **AuthChangePasswordPost**
> ChangePasswordResponse AuthChangePasswordPost (ChangePasswordRequest? changePasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthChangePasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var changePasswordRequest = new ChangePasswordRequest?(); // ChangePasswordRequest? |  (optional) 

            try
            {
                ChangePasswordResponse result = apiInstance.AuthChangePasswordPost(changePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthChangePasswordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthChangePasswordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChangePasswordResponse> response = apiInstance.AuthChangePasswordPostWithHttpInfo(changePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthChangePasswordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changePasswordRequest** | [**ChangePasswordRequest?**](ChangePasswordRequest?.md) |  | [optional]  |

### Return type

[**ChangePasswordResponse**](ChangePasswordResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authloginpost"></a>
# **AuthLoginPost**
> LoginResponse AuthLoginPost (LoginRequest? loginRequest = null)

Login using username and password. Will return a JWT when logging in was successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var loginRequest = new LoginRequest?(); // LoginRequest? | Login model containing credentials. (optional) 

            try
            {
                // Login using username and password. Will return a JWT when logging in was successful.
                LoginResponse result = apiInstance.AuthLoginPost(loginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login using username and password. Will return a JWT when logging in was successful.
    ApiResponse<LoginResponse> response = apiInstance.AuthLoginPostWithHttpInfo(loginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginRequest** | [**LoginRequest?**](LoginRequest?.md) | Login model containing credentials. | [optional]  |

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Login was successful. A jwt-token will only be returned for users with verified mail addresses.              If a mail address is not verified, the response object property ErrorState will be &#x60;mail_not_verified&#x60;. |  -  |
| **401** | Credentials are incorrect. |  -  |
| **400** | Http body/login model is incorrect. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authregisterpost"></a>
# **AuthRegisterPost**
> RegisterResponse AuthRegisterPost (RegisterRequest? registerRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthRegisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var registerRequest = new RegisterRequest?(); // RegisterRequest? |  (optional) 

            try
            {
                RegisterResponse result = apiInstance.AuthRegisterPost(registerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthRegisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRegisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RegisterResponse> response = apiInstance.AuthRegisterPostWithHttpInfo(registerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthRegisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerRequest** | [**RegisterRequest?**](RegisterRequest?.md) |  | [optional]  |

### Return type

[**RegisterResponse**](RegisterResponse.md)

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

<a id="authrestorepasswordpost"></a>
# **AuthRestorePasswordPost**
> ResetPasswordResponse AuthRestorePasswordPost (ResetPasswordRequest? resetPasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthRestorePasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var resetPasswordRequest = new ResetPasswordRequest?(); // ResetPasswordRequest? |  (optional) 

            try
            {
                ResetPasswordResponse result = apiInstance.AuthRestorePasswordPost(resetPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthRestorePasswordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthRestorePasswordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ResetPasswordResponse> response = apiInstance.AuthRestorePasswordPostWithHttpInfo(resetPasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthRestorePasswordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resetPasswordRequest** | [**ResetPasswordRequest?**](ResetPasswordRequest?.md) |  | [optional]  |

### Return type

[**ResetPasswordResponse**](ResetPasswordResponse.md)

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

<a id="authselectorganizationpost"></a>
# **AuthSelectOrganizationPost**
> LoginResponse AuthSelectOrganizationPost (SelectOrganizationRequest? selectOrganizationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthSelectOrganizationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var selectOrganizationRequest = new SelectOrganizationRequest?(); // SelectOrganizationRequest? |  (optional) 

            try
            {
                LoginResponse result = apiInstance.AuthSelectOrganizationPost(selectOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthSelectOrganizationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSelectOrganizationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginResponse> response = apiInstance.AuthSelectOrganizationPostWithHttpInfo(selectOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthSelectOrganizationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **selectOrganizationRequest** | [**SelectOrganizationRequest?**](SelectOrganizationRequest?.md) |  | [optional]  |

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authsendverificationcodepost"></a>
# **AuthSendVerificationCodePost**
> void AuthSendVerificationCodePost (SendVerificationCodeRequest? sendVerificationCodeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthSendVerificationCodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var sendVerificationCodeRequest = new SendVerificationCodeRequest?(); // SendVerificationCodeRequest? |  (optional) 

            try
            {
                apiInstance.AuthSendVerificationCodePost(sendVerificationCodeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthSendVerificationCodePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthSendVerificationCodePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AuthSendVerificationCodePostWithHttpInfo(sendVerificationCodeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthSendVerificationCodePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendVerificationCodeRequest** | [**SendVerificationCodeRequest?**](SendVerificationCodeRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authverifymailpost"></a>
# **AuthVerifyMailPost**
> void AuthVerifyMailPost (VerifyMailRequest? verifyMailRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthVerifyMailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var verifyMailRequest = new VerifyMailRequest?(); // VerifyMailRequest? |  (optional) 

            try
            {
                apiInstance.AuthVerifyMailPost(verifyMailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthVerifyMailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthVerifyMailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AuthVerifyMailPostWithHttpInfo(verifyMailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthVerifyMailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyMailRequest** | [**VerifyMailRequest?**](VerifyMailRequest?.md) |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authverifytwofactorpost"></a>
# **AuthVerifyTwoFactorPost**
> TwoFactorResponse AuthVerifyTwoFactorPost (TwoFactorRequest? twoFactorRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;
using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class AuthVerifyTwoFactorPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var twoFactorRequest = new TwoFactorRequest?(); // TwoFactorRequest? |  (optional) 

            try
            {
                TwoFactorResponse result = apiInstance.AuthVerifyTwoFactorPost(twoFactorRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.AuthVerifyTwoFactorPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthVerifyTwoFactorPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TwoFactorResponse> response = apiInstance.AuthVerifyTwoFactorPostWithHttpInfo(twoFactorRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.AuthVerifyTwoFactorPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **twoFactorRequest** | [**TwoFactorRequest?**](TwoFactorRequest?.md) |  | [optional]  |

### Return type

[**TwoFactorResponse**](TwoFactorResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

