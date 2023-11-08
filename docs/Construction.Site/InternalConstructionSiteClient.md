# Simplic.OxS.SDK.Construction.Site.InternalConstructionSiteClient

All URIs are relative to *https://dev-oxs.simplic.io/construction-site-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InternalInternalConstructionSiteGetByIdGet**](InternalConstructionSiteClient.md#internalinternalconstructionsitegetbyidget) | **GET** /internal/InternalConstructionSite/get-by-id |  |

<a id="internalinternalconstructionsitegetbyidget"></a>
# **InternalInternalConstructionSiteGetByIdGet**
> ConstructionSiteModel InternalInternalConstructionSiteGetByIdGet (Guid? id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;
using Simplic.OxS.SDK.Construction.Site;

namespace Example
{
    public class InternalInternalConstructionSiteGetByIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/construction-site-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalConstructionSiteClient(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                ConstructionSiteModel result = apiInstance.InternalInternalConstructionSiteGetByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalConstructionSiteClient.InternalInternalConstructionSiteGetByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalConstructionSiteGetByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConstructionSiteModel> response = apiInstance.InternalInternalConstructionSiteGetByIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalConstructionSiteClient.InternalInternalConstructionSiteGetByIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**ConstructionSiteModel**](ConstructionSiteModel.md)

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

