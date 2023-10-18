# Simplic.OxS.SDK.Article.InternalQuantityUnitSDK

All URIs are relative to *https://dev-oxs.simplic.io/article-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InternalInternalQuantityUnitGetByIdGet**](InternalQuantityUnitSDK.md#internalinternalquantityunitgetbyidget) | **GET** /internal/InternalQuantityUnit/get-by-id |  |

<a id="internalinternalquantityunitgetbyidget"></a>
# **InternalInternalQuantityUnitGetByIdGet**
> QuantityUnitModel InternalInternalQuantityUnitGetByIdGet (Guid? id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;
using Simplic.OxS.SDK.Article;

namespace Example
{
    public class InternalInternalQuantityUnitGetByIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/article-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalQuantityUnitSDK(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                QuantityUnitModel result = apiInstance.InternalInternalQuantityUnitGetByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalQuantityUnitSDK.InternalInternalQuantityUnitGetByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalQuantityUnitGetByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QuantityUnitModel> response = apiInstance.InternalInternalQuantityUnitGetByIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalQuantityUnitSDK.InternalInternalQuantityUnitGetByIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**QuantityUnitModel**](QuantityUnitModel.md)

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

