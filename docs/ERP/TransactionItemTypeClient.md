# Simplic.OxS.SDK.ERP.TransactionItemTypeClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TransactionItemTypeIdDelete**](TransactionItemTypeClient.md#transactionitemtypeiddelete) | **DELETE** /TransactionItemType/{id} |  |
| [**TransactionItemTypeIdGet**](TransactionItemTypeClient.md#transactionitemtypeidget) | **GET** /TransactionItemType/{id} |  |
| [**TransactionItemTypeIdPut**](TransactionItemTypeClient.md#transactionitemtypeidput) | **PUT** /TransactionItemType/{id} |  |
| [**TransactionItemTypePost**](TransactionItemTypeClient.md#transactionitemtypepost) | **POST** /TransactionItemType |  |

<a id="transactionitemtypeiddelete"></a>
# **TransactionItemTypeIdDelete**
> void TransactionItemTypeIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class TransactionItemTypeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionItemTypeClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.TransactionItemTypeIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransactionItemTypeIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TransactionItemTypeIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

void (empty response body)

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

<a id="transactionitemtypeidget"></a>
# **TransactionItemTypeIdGet**
> TransactionItemTypeModel TransactionItemTypeIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class TransactionItemTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionItemTypeClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                TransactionItemTypeModel result = apiInstance.TransactionItemTypeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransactionItemTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransactionItemTypeModel> response = apiInstance.TransactionItemTypeIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**TransactionItemTypeModel**](TransactionItemTypeModel.md)

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

<a id="transactionitemtypeidput"></a>
# **TransactionItemTypeIdPut**
> TransactionItemTypeModel TransactionItemTypeIdPut (Guid id, CreateTransactionItemTypeRequest? createTransactionItemTypeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class TransactionItemTypeIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionItemTypeClient(config);
            var id = "id_example";  // Guid | 
            var createTransactionItemTypeRequest = new CreateTransactionItemTypeRequest?(); // CreateTransactionItemTypeRequest? |  (optional) 

            try
            {
                TransactionItemTypeModel result = apiInstance.TransactionItemTypeIdPut(id, createTransactionItemTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransactionItemTypeIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransactionItemTypeModel> response = apiInstance.TransactionItemTypeIdPutWithHttpInfo(id, createTransactionItemTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypeIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **createTransactionItemTypeRequest** | [**CreateTransactionItemTypeRequest?**](CreateTransactionItemTypeRequest?.md) |  | [optional]  |

### Return type

[**TransactionItemTypeModel**](TransactionItemTypeModel.md)

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

<a id="transactionitemtypepost"></a>
# **TransactionItemTypePost**
> TransactionItemTypeModel TransactionItemTypePost (CreateTransactionItemTypeRequest? createTransactionItemTypeRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class TransactionItemTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionItemTypeClient(config);
            var createTransactionItemTypeRequest = new CreateTransactionItemTypeRequest?(); // CreateTransactionItemTypeRequest? |  (optional) 

            try
            {
                TransactionItemTypeModel result = apiInstance.TransactionItemTypePost(createTransactionItemTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransactionItemTypePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransactionItemTypeModel> response = apiInstance.TransactionItemTypePostWithHttpInfo(createTransactionItemTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionItemTypeClient.TransactionItemTypePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTransactionItemTypeRequest** | [**CreateTransactionItemTypeRequest?**](CreateTransactionItemTypeRequest?.md) |  | [optional]  |

### Return type

[**TransactionItemTypeModel**](TransactionItemTypeModel.md)

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

