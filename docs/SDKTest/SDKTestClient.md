# Simplic.OxS.SDK.SDKTest.SDKTestClient

All URIs are relative to *https://localhost:5193/sdktest-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SDKTestGetExampleSGet**](SDKTestClient.md#sdktestgetexamplesget) | **GET** /SDKTest/get-example/{s} |  |
| [**SDKTestPostExampleSPost**](SDKTestClient.md#sdktestpostexamplespost) | **POST** /SDKTest/post-example/{s} |  |

<a id="sdktestgetexamplesget"></a>
# **SDKTestGetExampleSGet**
> GetExampleResponse SDKTestGetExampleSGet (string s)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.SDKTest;
using Simplic.OxS.SDK.SDKTest;
using Simplic.OxS.SDK.SDKTest;

namespace Example
{
    public class SDKTestGetExampleSGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost:5193/sdktest-api/v1";
            // Configure API key authorization: i-api-key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SDKTestClient(config);
            var s = "s_example";  // string | 

            try
            {
                GetExampleResponse result = apiInstance.SDKTestGetExampleSGet(s);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SDKTestClient.SDKTestGetExampleSGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SDKTestGetExampleSGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetExampleResponse> response = apiInstance.SDKTestGetExampleSGetWithHttpInfo(s);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SDKTestClient.SDKTestGetExampleSGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s** | **string** |  |  |

### Return type

[**GetExampleResponse**](GetExampleResponse.md)

### Authorization

[i-api-key](../README.md#i-api-key), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sdktestpostexamplespost"></a>
# **SDKTestPostExampleSPost**
> GetExampleResponse SDKTestPostExampleSPost (string s)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.SDKTest;
using Simplic.OxS.SDK.SDKTest;
using Simplic.OxS.SDK.SDKTest;

namespace Example
{
    public class SDKTestPostExampleSPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost:5193/sdktest-api/v1";
            // Configure API key authorization: i-api-key
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SDKTestClient(config);
            var s = "s_example";  // string | 

            try
            {
                GetExampleResponse result = apiInstance.SDKTestPostExampleSPost(s);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SDKTestClient.SDKTestPostExampleSPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SDKTestPostExampleSPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetExampleResponse> response = apiInstance.SDKTestPostExampleSPostWithHttpInfo(s);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SDKTestClient.SDKTestPostExampleSPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s** | **string** |  |  |

### Return type

[**GetExampleResponse**](GetExampleResponse.md)

### Authorization

[i-api-key](../README.md#i-api-key), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

