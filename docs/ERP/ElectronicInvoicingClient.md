# Simplic.OxS.SDK.ERP.ElectronicInvoicingClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](ElectronicInvoicingClient.md#electronicinvoicingcreatepost) | **POST** /ElectronicInvoicing/create | Creates a PDF file that constitutes a hybrid electronic invoice according to the ZUGFeRD standard from an invoice PDF file and the relevant invoice data. |
| [**Import**](ElectronicInvoicingClient.md#electronicinvoicingimportpost) | **POST** /ElectronicInvoicing/import | Extracts the invoice data from an electronic invoice (either ZUGFeRD hybrid electronic invoice PDF or XRechnung XML) and validates it. |

<a id="electronicinvoicingcreatepost"></a>
# **Create**
> ElectronicInvoiceCreateResult Create (CreateElectronicInvoiceRequest? createElectronicInvoiceRequest = null)

Creates a PDF file that constitutes a hybrid electronic invoice according to the ZUGFeRD standard from an invoice PDF file and the relevant invoice data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ElectronicInvoicingClient(config);
            var createElectronicInvoiceRequest = new CreateElectronicInvoiceRequest?(); // CreateElectronicInvoiceRequest? |  (optional) 

            try
            {
                // Creates a PDF file that constitutes a hybrid electronic invoice according to the ZUGFeRD standard from an invoice PDF file and the relevant invoice data.
                ElectronicInvoiceCreateResult result = apiInstance.Create(createElectronicInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ElectronicInvoicingClient.Create: " + e.Message);
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
    // Creates a PDF file that constitutes a hybrid electronic invoice according to the ZUGFeRD standard from an invoice PDF file and the relevant invoice data.
    ApiResponse<ElectronicInvoiceCreateResult> response = apiInstance.CreateWithHttpInfo(createElectronicInvoiceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ElectronicInvoicingClient.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createElectronicInvoiceRequest** | [**CreateElectronicInvoiceRequest?**](CreateElectronicInvoiceRequest?.md) |  | [optional]  |

### Return type

[**ElectronicInvoiceCreateResult**](ElectronicInvoiceCreateResult.md)

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

<a id="electronicinvoicingimportpost"></a>
# **Import**
> ElectronicInvoiceImportResult Import (ImportElectronicInvoiceRequest? importElectronicInvoiceRequest = null)

Extracts the invoice data from an electronic invoice (either ZUGFeRD hybrid electronic invoice PDF or XRechnung XML) and validates it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class ImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ElectronicInvoicingClient(config);
            var importElectronicInvoiceRequest = new ImportElectronicInvoiceRequest?(); // ImportElectronicInvoiceRequest? |  (optional) 

            try
            {
                // Extracts the invoice data from an electronic invoice (either ZUGFeRD hybrid electronic invoice PDF or XRechnung XML) and validates it.
                ElectronicInvoiceImportResult result = apiInstance.Import(importElectronicInvoiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ElectronicInvoicingClient.Import: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extracts the invoice data from an electronic invoice (either ZUGFeRD hybrid electronic invoice PDF or XRechnung XML) and validates it.
    ApiResponse<ElectronicInvoiceImportResult> response = apiInstance.ImportWithHttpInfo(importElectronicInvoiceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ElectronicInvoicingClient.ImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **importElectronicInvoiceRequest** | [**ImportElectronicInvoiceRequest?**](ImportElectronicInvoiceRequest?.md) |  | [optional]  |

### Return type

[**ElectronicInvoiceImportResult**](ElectronicInvoiceImportResult.md)

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

