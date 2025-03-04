# Simplic.OxS.SDK.Auth.AuthClient

All URIs are relative to *https://dev-oxs.simplic.io/auth-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangePassword**](AuthClient.md#authchangepasswordpost) | **POST** /Auth/change-password |  |
| [**Login**](AuthClient.md#authloginpost) | **POST** /Auth/login | Login using username and password. Will return a JWT when logging in was successful. |
| [**Register**](AuthClient.md#authregisterpost) | **POST** /Auth/register |  |
| [**RestorePassword**](AuthClient.md#authrestorepasswordpost) | **POST** /Auth/restore-password |  |
| [**SelectOrganization**](AuthClient.md#authselectorganizationpost) | **POST** /Auth/select-organization |  |
| [**SendVerificationCode**](AuthClient.md#authsendverificationcodepost) | **POST** /Auth/send-verification-code |  |
| [**VerifyMail**](AuthClient.md#authverifymailpost) | **POST** /Auth/verify-mail |  |
| [**VerifyTwoFactor**](AuthClient.md#authverifytwofactorpost) | **POST** /Auth/verify-two-factor |  |

<a id="authchangepasswordpost"></a>
# **ChangePassword**
> ChangePasswordResponse ChangePassword (ChangePasswordRequest? changePasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class ChangePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var changePasswordRequest = new ChangePasswordRequest?(); // ChangePasswordRequest? |  (optional) 

            try
            {
                ChangePasswordResponse result = apiInstance.ChangePassword(changePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.ChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ChangePasswordResponse> response = apiInstance.ChangePasswordWithHttpInfo(changePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.ChangePasswordWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authloginpost"></a>
# **Login**
> LoginResponse Login (LoginRequest? loginRequest = null)

Login using username and password. Will return a JWT when logging in was successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var loginRequest = new LoginRequest?(); // LoginRequest? | Login model containing credentials. (optional) 

            try
            {
                // Login using username and password. Will return a JWT when logging in was successful.
                LoginResponse result = apiInstance.Login(loginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login using username and password. Will return a JWT when logging in was successful.
    ApiResponse<LoginResponse> response = apiInstance.LoginWithHttpInfo(loginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.LoginWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

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
# **Register**
> RegisterResponse Register (RegisterRequest? registerRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class RegisterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var registerRequest = new RegisterRequest?(); // RegisterRequest? |  (optional) 

            try
            {
                RegisterResponse result = apiInstance.Register(registerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.Register: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RegisterResponse> response = apiInstance.RegisterWithHttpInfo(registerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.RegisterWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authrestorepasswordpost"></a>
# **RestorePassword**
> ResetPasswordResponse RestorePassword (ResetPasswordRequest? resetPasswordRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class RestorePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var resetPasswordRequest = new ResetPasswordRequest?(); // ResetPasswordRequest? |  (optional) 

            try
            {
                ResetPasswordResponse result = apiInstance.RestorePassword(resetPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.RestorePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestorePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ResetPasswordResponse> response = apiInstance.RestorePasswordWithHttpInfo(resetPasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.RestorePasswordWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authselectorganizationpost"></a>
# **SelectOrganization**
> LoginResponse SelectOrganization (SelectOrganizationRequest? selectOrganizationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class SelectOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var selectOrganizationRequest = new SelectOrganizationRequest?(); // SelectOrganizationRequest? |  (optional) 

            try
            {
                LoginResponse result = apiInstance.SelectOrganization(selectOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.SelectOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SelectOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LoginResponse> response = apiInstance.SelectOrganizationWithHttpInfo(selectOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.SelectOrganizationWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authsendverificationcodepost"></a>
# **SendVerificationCode**
> void SendVerificationCode (SendVerificationCodeRequest? sendVerificationCodeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class SendVerificationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var sendVerificationCodeRequest = new SendVerificationCodeRequest?(); // SendVerificationCodeRequest? |  (optional) 

            try
            {
                apiInstance.SendVerificationCode(sendVerificationCodeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.SendVerificationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendVerificationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SendVerificationCodeWithHttpInfo(sendVerificationCodeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.SendVerificationCodeWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authverifymailpost"></a>
# **VerifyMail**
> void VerifyMail (VerifyMailRequest? verifyMailRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class VerifyMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var verifyMailRequest = new VerifyMailRequest?(); // VerifyMailRequest? |  (optional) 

            try
            {
                apiInstance.VerifyMail(verifyMailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.VerifyMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.VerifyMailWithHttpInfo(verifyMailRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.VerifyMailWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authverifytwofactorpost"></a>
# **VerifyTwoFactor**
> TwoFactorResponse VerifyTwoFactor (TwoFactorRequest? twoFactorRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Auth;

namespace Example
{
    public class VerifyTwoFactorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/auth-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthClient(config);
            var twoFactorRequest = new TwoFactorRequest?(); // TwoFactorRequest? |  (optional) 

            try
            {
                TwoFactorResponse result = apiInstance.VerifyTwoFactor(twoFactorRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthClient.VerifyTwoFactor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyTwoFactorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TwoFactorResponse> response = apiInstance.VerifyTwoFactorWithHttpInfo(twoFactorRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthClient.VerifyTwoFactorWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

