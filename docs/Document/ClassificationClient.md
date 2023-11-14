# Simplic.OxS.SDK.Document.ClassificationClient

All URIs are relative to *https://dev-oxs.simplic.io/document-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiClassificationClassificationIdGet**](ClassificationClient.md#apiclassificationclassificationidget) | **GET** /api/Classification/{classificationId} |  |
| [**ApiClassificationIdPatch**](ClassificationClient.md#apiclassificationidpatch) | **PATCH** /api/Classification/{id} |  |
| [**ApiClassificationPost**](ClassificationClient.md#apiclassificationpost) | **POST** /api/Classification |  |

<a id="apiclassificationclassificationidget"></a>
# **ApiClassificationClassificationIdGet**
> ClassificationResponse ApiClassificationClassificationIdGet (Guid classificationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;

namespace Example
{
    public class ApiClassificationClassificationIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/document-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClassificationClient(config);
            var classificationId = "classificationId_example";  // Guid | 

            try
            {
                ClassificationResponse result = apiInstance.ApiClassificationClassificationIdGet(classificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationClient.ApiClassificationClassificationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiClassificationClassificationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ClassificationResponse> response = apiInstance.ApiClassificationClassificationIdGetWithHttpInfo(classificationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClassificationClient.ApiClassificationClassificationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **classificationId** | **Guid** |  |  |

### Return type

[**ClassificationResponse**](ClassificationResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiclassificationidpatch"></a>
# **ApiClassificationIdPatch**
> ClassificationResponse ApiClassificationIdPatch (Guid id, PatchClassificationRequest? patchClassificationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;

namespace Example
{
    public class ApiClassificationIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/document-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClassificationClient(config);
            var id = "id_example";  // Guid | 
            var patchClassificationRequest = new PatchClassificationRequest?(); // PatchClassificationRequest? |  (optional) 

            try
            {
                ClassificationResponse result = apiInstance.ApiClassificationIdPatch(id, patchClassificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationClient.ApiClassificationIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiClassificationIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ClassificationResponse> response = apiInstance.ApiClassificationIdPatchWithHttpInfo(id, patchClassificationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClassificationClient.ApiClassificationIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **patchClassificationRequest** | [**PatchClassificationRequest?**](PatchClassificationRequest?.md) |  | [optional]  |

### Return type

[**ClassificationResponse**](ClassificationResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiclassificationpost"></a>
# **ApiClassificationPost**
> ClassificationResponse ApiClassificationPost (CreateClassificationRequest? createClassificationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;
using Simplic.OxS.SDK.Document;

namespace Example
{
    public class ApiClassificationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/document-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClassificationClient(config);
            var createClassificationRequest = new CreateClassificationRequest?(); // CreateClassificationRequest? |  (optional) 

            try
            {
                ClassificationResponse result = apiInstance.ApiClassificationPost(createClassificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClassificationClient.ApiClassificationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiClassificationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ClassificationResponse> response = apiInstance.ApiClassificationPostWithHttpInfo(createClassificationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClassificationClient.ApiClassificationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createClassificationRequest** | [**CreateClassificationRequest?**](CreateClassificationRequest?.md) |  | [optional]  |

### Return type

[**ClassificationResponse**](ClassificationResponse.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

