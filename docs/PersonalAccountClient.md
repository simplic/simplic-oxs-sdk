# Simplic.OxS.SDK.ERP.PersonalAccountClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PersonalAccountAddAddressIdContactIdPut**](PersonalAccountClient.md#personalaccountaddaddressidcontactidput) | **PUT** /PersonalAccount/add-address/{id}/{contactId} |  |
| [**PersonalAccountIdDelete**](PersonalAccountClient.md#personalaccountiddelete) | **DELETE** /PersonalAccount/{id} |  |
| [**PersonalAccountIdGet**](PersonalAccountClient.md#personalaccountidget) | **GET** /PersonalAccount/{id} |  |
| [**PersonalAccountIdPut**](PersonalAccountClient.md#personalaccountidput) | **PUT** /PersonalAccount/{id} |  |
| [**PersonalAccountPost**](PersonalAccountClient.md#personalaccountpost) | **POST** /PersonalAccount |  |
| [**PersonalAccountRemoveAddressIdContactIdPut**](PersonalAccountClient.md#personalaccountremoveaddressidcontactidput) | **PUT** /PersonalAccount/remove-address/{id}/{contactId} |  |

<a id="personalaccountaddaddressidcontactidput"></a>
# **PersonalAccountAddAddressIdContactIdPut**
> PersonalAccountModel PersonalAccountAddAddressIdContactIdPut (Guid id, Guid contactId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountAddAddressIdContactIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var id = "id_example";  // Guid | 
            var contactId = "contactId_example";  // Guid | 

            try
            {
                PersonalAccountModel result = apiInstance.PersonalAccountAddAddressIdContactIdPut(id, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountAddAddressIdContactIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountAddAddressIdContactIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.PersonalAccountAddAddressIdContactIdPutWithHttpInfo(id, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountAddAddressIdContactIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **contactId** | **Guid** |  |  |

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

<a id="personalaccountiddelete"></a>
# **PersonalAccountIdDelete**
> void PersonalAccountIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.PersonalAccountIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PersonalAccountIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdDeleteWithHttpInfo: " + e.Message);
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

<a id="personalaccountidget"></a>
# **PersonalAccountIdGet**
> PersonalAccountModel PersonalAccountIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                PersonalAccountModel result = apiInstance.PersonalAccountIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.PersonalAccountIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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

<a id="personalaccountidput"></a>
# **PersonalAccountIdPut**
> PersonalAccountModel PersonalAccountIdPut (Guid id, UpdatePersonalAccountRequest? updatePersonalAccountRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var id = "id_example";  // Guid | 
            var updatePersonalAccountRequest = new UpdatePersonalAccountRequest?(); // UpdatePersonalAccountRequest? |  (optional) 

            try
            {
                PersonalAccountModel result = apiInstance.PersonalAccountIdPut(id, updatePersonalAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.PersonalAccountIdPutWithHttpInfo(id, updatePersonalAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updatePersonalAccountRequest** | [**UpdatePersonalAccountRequest?**](UpdatePersonalAccountRequest?.md) |  | [optional]  |

### Return type

[**PersonalAccountModel**](PersonalAccountModel.md)

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

<a id="personalaccountpost"></a>
# **PersonalAccountPost**
> PersonalAccountModel PersonalAccountPost (CreatePersonalAccountRequest? createPersonalAccountRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var createPersonalAccountRequest = new CreatePersonalAccountRequest?(); // CreatePersonalAccountRequest? |  (optional) 

            try
            {
                PersonalAccountModel result = apiInstance.PersonalAccountPost(createPersonalAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.PersonalAccountPostWithHttpInfo(createPersonalAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPersonalAccountRequest** | [**CreatePersonalAccountRequest?**](CreatePersonalAccountRequest?.md) |  | [optional]  |

### Return type

[**PersonalAccountModel**](PersonalAccountModel.md)

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

<a id="personalaccountremoveaddressidcontactidput"></a>
# **PersonalAccountRemoveAddressIdContactIdPut**
> PersonalAccountModel PersonalAccountRemoveAddressIdContactIdPut (Guid id, Guid contactId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;
using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PersonalAccountRemoveAddressIdContactIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalAccountClient(config);
            var id = "id_example";  // Guid | 
            var contactId = "contactId_example";  // Guid | 

            try
            {
                PersonalAccountModel result = apiInstance.PersonalAccountRemoveAddressIdContactIdPut(id, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountRemoveAddressIdContactIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonalAccountRemoveAddressIdContactIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersonalAccountModel> response = apiInstance.PersonalAccountRemoveAddressIdContactIdPutWithHttpInfo(id, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAccountClient.PersonalAccountRemoveAddressIdContactIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **contactId** | **Guid** |  |  |

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

