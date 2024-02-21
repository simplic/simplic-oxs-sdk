# Simplic.OxS.SDK.Ai.TrainingClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UploadCsv**](TrainingClient.md#traininguploadcsvmodelidpost) | **POST** /Training/upload-csv/{modelId} |  |

<a id="traininguploadcsvmodelidpost"></a>
# **UploadCsv**
> CreateModelResponse UploadCsv (Guid modelId, System.IO.Stream? file = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Ai;
using Simplic.OxS.SDK.Ai;
using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class UploadCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TrainingClient(config);
            var modelId = "modelId_example";  // Guid | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                CreateModelResponse result = apiInstance.UploadCsv(modelId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrainingClient.UploadCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateModelResponse> response = apiInstance.UploadCsvWithHttpInfo(modelId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrainingClient.UploadCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelId** | **Guid** |  |  |
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

### Return type

[**CreateModelResponse**](CreateModelResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

