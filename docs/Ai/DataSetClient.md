# Simplic.OxS.SDK.Ai.DataSetClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](DataSetClient.md#datasetcreatepost) | **POST** /DataSet/create |  |

<a id="datasetcreatepost"></a>
# **Create**
> CreateDataSetResponse Create (CreateDataSetRequest? createDataSetRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Ai;
using Simplic.OxS.SDK.Ai;
using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataSetClient(config);
            var createDataSetRequest = new CreateDataSetRequest?(); // CreateDataSetRequest? |  (optional) 

            try
            {
                CreateDataSetResponse result = apiInstance.Create(createDataSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSetClient.Create: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateDataSetResponse> response = apiInstance.CreateWithHttpInfo(createDataSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSetClient.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataSetRequest** | [**CreateDataSetRequest?**](CreateDataSetRequest?.md) |  | [optional]  |

### Return type

[**CreateDataSetResponse**](CreateDataSetResponse.md)

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

