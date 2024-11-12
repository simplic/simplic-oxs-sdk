# Simplic.OxS.SDK.Logistics.ComposedResourceSettingsClient

All URIs are relative to *https://dev-oxs.simplic.io/logistics-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](ComposedResourceSettingsClient.md#composedresourcesettingsget) | **GET** /ComposedResourceSettings | Gets the current composed resource settings. |
| [**Patch**](ComposedResourceSettingsClient.md#composedresourcesettingspatch) | **PATCH** /ComposedResourceSettings | Patches the composed resource settings and initializes composed resources when getting enabled. |

<a id="composedresourcesettingsget"></a>
# **Get**
> ComposedResourceSettingsResponse Get ()

Gets the current composed resource settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ComposedResourceSettingsClient(config);

            try
            {
                // Gets the current composed resource settings.
                ComposedResourceSettingsResponse result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComposedResourceSettingsClient.Get: " + e.Message);
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
    // Gets the current composed resource settings.
    ApiResponse<ComposedResourceSettingsResponse> response = apiInstance.GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComposedResourceSettingsClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ComposedResourceSettingsResponse**](ComposedResourceSettingsResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="composedresourcesettingspatch"></a>
# **Patch**
> ComposedResourceSettingsResponse Patch (PatchComposedResourceSettingsRequest? patchComposedResourceSettingsRequest = null)

Patches the composed resource settings and initializes composed resources when getting enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Logistics;

namespace Example
{
    public class PatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/logistics-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ComposedResourceSettingsClient(config);
            var patchComposedResourceSettingsRequest = new PatchComposedResourceSettingsRequest?(); // PatchComposedResourceSettingsRequest? |  (optional) 

            try
            {
                // Patches the composed resource settings and initializes composed resources when getting enabled.
                ComposedResourceSettingsResponse result = apiInstance.Patch(patchComposedResourceSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComposedResourceSettingsClient.Patch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches the composed resource settings and initializes composed resources when getting enabled.
    ApiResponse<ComposedResourceSettingsResponse> response = apiInstance.PatchWithHttpInfo(patchComposedResourceSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComposedResourceSettingsClient.PatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **patchComposedResourceSettingsRequest** | [**PatchComposedResourceSettingsRequest?**](PatchComposedResourceSettingsRequest?.md) |  | [optional]  |

### Return type

[**ComposedResourceSettingsResponse**](ComposedResourceSettingsResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

