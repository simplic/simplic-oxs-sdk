# Simplic.OxS.SDK.ERP.InternalTransactionClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddBillingLines**](InternalTransactionClient.md#internalinternaltransactionaddbillinglinespost) | **POST** /internal/InternalTransaction/add-billing-lines | Creates a set of billing lines and adds them to an existing transaction. |

<a id="internalinternaltransactionaddbillinglinespost"></a>
# **AddBillingLines**
> TransactionModel AddBillingLines (AddBillingLinesToTransactionRequest? addBillingLinesToTransactionRequest = null)

Creates a set of billing lines and adds them to an existing transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class AddBillingLinesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InternalTransactionClient(config);
            var addBillingLinesToTransactionRequest = new AddBillingLinesToTransactionRequest?(); // AddBillingLinesToTransactionRequest? | The request containing the transaction ID and billing lines to create and add. (optional) 

            try
            {
                // Creates a set of billing lines and adds them to an existing transaction.
                TransactionModel result = apiInstance.AddBillingLines(addBillingLinesToTransactionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InternalTransactionClient.AddBillingLines: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddBillingLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a set of billing lines and adds them to an existing transaction.
    ApiResponse<TransactionModel> response = apiInstance.AddBillingLinesWithHttpInfo(addBillingLinesToTransactionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InternalTransactionClient.AddBillingLinesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addBillingLinesToTransactionRequest** | [**AddBillingLinesToTransactionRequest?**](AddBillingLinesToTransactionRequest?.md) | The request containing the transaction ID and billing lines to create and add. | [optional]  |

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

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

