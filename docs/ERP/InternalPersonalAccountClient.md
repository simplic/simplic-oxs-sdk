# Simplic.OxS.SDK.ERP.InternalPersonalAccountClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetById**](InternalPersonalAccountClient.md#internalinternalpersonalaccountgetbyidget) | **GET** /internal/InternalPersonalAccount/get-by-id |  |

<a id="internalinternalpersonalaccountgetbyidget"></a>
# **GetById**
> PersonalAccountModel GetById (Guid? id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class GetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalPersonalAccountClient(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                PersonalAccountModel result = apiInstance.GetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalPersonalAccountClient.GetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.GetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalPersonalAccountClient.GetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**PersonalAccountModel**](PersonalAccountModel.md)

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

