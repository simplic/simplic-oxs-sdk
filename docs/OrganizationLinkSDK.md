# Simplic.OxS.SDK.Organization.OrganizationLinkSDK

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrganizationLinkGetLinkedGet**](OrganizationLinkSDK.md#organizationlinkgetlinkedget) | **GET** /OrganizationLink/get-linked | Returns a list of organizations that belongs to the current user |

<a id="organizationlinkgetlinkedget"></a>
# **OrganizationLinkGetLinkedGet**
> List&lt;OrganizationLinkModel&gt; OrganizationLinkGetLinkedGet (string? module = null, string? searchContains = null)

Returns a list of organizations that belongs to the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkGetLinkedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkSDK(config);
            var module = "module_example";  // string? |  (optional) 
            var searchContains = "searchContains_example";  // string? |  (optional) 

            try
            {
                // Returns a list of organizations that belongs to the current user
                List<OrganizationLinkModel> result = apiInstance.OrganizationLinkGetLinkedGet(module, searchContains);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkSDK.OrganizationLinkGetLinkedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkGetLinkedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of organizations that belongs to the current user
    ApiResponse<List<OrganizationLinkModel>> response = apiInstance.OrganizationLinkGetLinkedGetWithHttpInfo(module, searchContains);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkSDK.OrganizationLinkGetLinkedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **module** | **string?** |  | [optional]  |
| **searchContains** | **string?** |  | [optional]  |

### Return type

[**List&lt;OrganizationLinkModel&gt;**](OrganizationLinkModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

