# Simplic.OxS.SDK.Organization.InternalOrganizationSiteSDK

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InternalInternalOrganizationSiteGetAllByOrganizationGet**](InternalOrganizationSiteSDK.md#internalinternalorganizationsitegetallbyorganizationget) | **GET** /internal/InternalOrganizationSite/get-all-by-organization |  |
| [**InternalInternalOrganizationSiteIdGet**](InternalOrganizationSiteSDK.md#internalinternalorganizationsiteidget) | **GET** /internal/InternalOrganizationSite/{id} |  |

<a id="internalinternalorganizationsitegetallbyorganizationget"></a>
# **InternalInternalOrganizationSiteGetAllByOrganizationGet**
> List&lt;OrganizationSiteModel&gt; InternalInternalOrganizationSiteGetAllByOrganizationGet (Guid? id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class InternalInternalOrganizationSiteGetAllByOrganizationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalOrganizationSiteSDK(config);
            var id = "id_example";  // Guid? |  (optional) 

            try
            {
                List<OrganizationSiteModel> result = apiInstance.InternalInternalOrganizationSiteGetAllByOrganizationGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalOrganizationSiteSDK.InternalInternalOrganizationSiteGetAllByOrganizationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalOrganizationSiteGetAllByOrganizationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<OrganizationSiteModel>> response = apiInstance.InternalInternalOrganizationSiteGetAllByOrganizationGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalOrganizationSiteSDK.InternalInternalOrganizationSiteGetAllByOrganizationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;OrganizationSiteModel&gt;**](OrganizationSiteModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="internalinternalorganizationsiteidget"></a>
# **InternalInternalOrganizationSiteIdGet**
> OrganizationSiteModel InternalInternalOrganizationSiteIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class InternalInternalOrganizationSiteIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalOrganizationSiteSDK(config);
            var id = "id_example";  // Guid | 

            try
            {
                OrganizationSiteModel result = apiInstance.InternalInternalOrganizationSiteIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalOrganizationSiteSDK.InternalInternalOrganizationSiteIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InternalInternalOrganizationSiteIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrganizationSiteModel> response = apiInstance.InternalInternalOrganizationSiteIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalOrganizationSiteSDK.InternalInternalOrganizationSiteIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**OrganizationSiteModel**](OrganizationSiteModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

