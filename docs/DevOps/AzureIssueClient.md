# Simplic.OxS.SDK.DevOps.AzureIssueClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateIssue**](AzureIssueClient.md#azureissueupdateissuepost) | **POST** /AzureIssue/update-issue |  |

<a id="azureissueupdateissuepost"></a>
# **UpdateIssue**
> IssueModel UpdateIssue (string apiKey, Object? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class UpdateIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AzureIssueClient(config);
            var apiKey = "apiKey_example";  // string | 
            var body = null;  // Object? |  (optional) 

            try
            {
                IssueModel result = apiInstance.UpdateIssue(apiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureIssueClient.UpdateIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IssueModel> response = apiInstance.UpdateIssueWithHttpInfo(apiKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureIssueClient.UpdateIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiKey** | **string** |  |  |
| **body** | **Object?** |  | [optional]  |

### Return type

[**IssueModel**](IssueModel.md)

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

