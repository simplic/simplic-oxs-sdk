# Simplic.OxS.SDK.Organization.OrganizationLinkInvitationSDK

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrganizationLinkInvitationAcceptOneTimeIdPut**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationacceptonetimeidput) | **PUT** /OrganizationLinkInvitation/accept-one-time/{id} | Accept a pending invitation |
| [**OrganizationLinkInvitationCreateOneTimePost**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationcreateonetimepost) | **POST** /OrganizationLinkInvitation/create-one-time | Creates a new invitation for linking with another organization |
| [**OrganizationLinkInvitationCreateStaticPost**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationcreatestaticpost) | **POST** /OrganizationLinkInvitation/create-static | Creates a new invitation for linking with another organization |
| [**OrganizationLinkInvitationDeclineOneTimeIdPut**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationdeclineonetimeidput) | **PUT** /OrganizationLinkInvitation/decline-one-time/{id} | Decline a pending invitation |
| [**OrganizationLinkInvitationGet**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationget) | **GET** /OrganizationLinkInvitation | Get static invitation links |
| [**OrganizationLinkInvitationGetByTokenTokenGet**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationgetbytokentokenget) | **GET** /OrganizationLinkInvitation/get-by-token/{token} | Get invitation by token |
| [**OrganizationLinkInvitationGetMyInvitationsGet**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationgetmyinvitationsget) | **GET** /OrganizationLinkInvitation/get-my-invitations | Gets a list of all pending invitations |
| [**OrganizationLinkInvitationIdDelete**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationiddelete) | **DELETE** /OrganizationLinkInvitation/{id} | Delete an invitation |
| [**OrganizationLinkInvitationJoinStaticTokenPut**](OrganizationLinkInvitationSDK.md#organizationlinkinvitationjoinstatictokenput) | **PUT** /OrganizationLinkInvitation/join-static/{token} | Create an orgainzation link by using a static token |

<a id="organizationlinkinvitationacceptonetimeidput"></a>
# **OrganizationLinkInvitationAcceptOneTimeIdPut**
> OrganizationLinkInvitationAcceptedResponse OrganizationLinkInvitationAcceptOneTimeIdPut (Guid id)

Accept a pending invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationAcceptOneTimeIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Accept a pending invitation
                OrganizationLinkInvitationAcceptedResponse result = apiInstance.OrganizationLinkInvitationAcceptOneTimeIdPut(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationAcceptOneTimeIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationAcceptOneTimeIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept a pending invitation
    ApiResponse<OrganizationLinkInvitationAcceptedResponse> response = apiInstance.OrganizationLinkInvitationAcceptOneTimeIdPutWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationAcceptOneTimeIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Invitation id |  |

### Return type

[**OrganizationLinkInvitationAcceptedResponse**](OrganizationLinkInvitationAcceptedResponse.md)

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

<a id="organizationlinkinvitationcreateonetimepost"></a>
# **OrganizationLinkInvitationCreateOneTimePost**
> OrganizationLinkInvitationModel OrganizationLinkInvitationCreateOneTimePost (OrganizationLinkInvitationRequest? organizationLinkInvitationRequest = null)

Creates a new invitation for linking with another organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationCreateOneTimePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var organizationLinkInvitationRequest = new OrganizationLinkInvitationRequest?(); // OrganizationLinkInvitationRequest? | Invitation request (optional) 

            try
            {
                // Creates a new invitation for linking with another organization
                OrganizationLinkInvitationModel result = apiInstance.OrganizationLinkInvitationCreateOneTimePost(organizationLinkInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationCreateOneTimePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationCreateOneTimePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new invitation for linking with another organization
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.OrganizationLinkInvitationCreateOneTimePostWithHttpInfo(organizationLinkInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationCreateOneTimePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationLinkInvitationRequest** | [**OrganizationLinkInvitationRequest?**](OrganizationLinkInvitationRequest?.md) | Invitation request | [optional]  |

### Return type

[**OrganizationLinkInvitationModel**](OrganizationLinkInvitationModel.md)

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

<a id="organizationlinkinvitationcreatestaticpost"></a>
# **OrganizationLinkInvitationCreateStaticPost**
> OrganizationLinkInvitationModel OrganizationLinkInvitationCreateStaticPost (OrganizationLinkStaticInvitationRequest? organizationLinkStaticInvitationRequest = null)

Creates a new invitation for linking with another organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationCreateStaticPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var organizationLinkStaticInvitationRequest = new OrganizationLinkStaticInvitationRequest?(); // OrganizationLinkStaticInvitationRequest? | Invitation request (optional) 

            try
            {
                // Creates a new invitation for linking with another organization
                OrganizationLinkInvitationModel result = apiInstance.OrganizationLinkInvitationCreateStaticPost(organizationLinkStaticInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationCreateStaticPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationCreateStaticPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new invitation for linking with another organization
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.OrganizationLinkInvitationCreateStaticPostWithHttpInfo(organizationLinkStaticInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationCreateStaticPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationLinkStaticInvitationRequest** | [**OrganizationLinkStaticInvitationRequest?**](OrganizationLinkStaticInvitationRequest?.md) | Invitation request | [optional]  |

### Return type

[**OrganizationLinkInvitationModel**](OrganizationLinkInvitationModel.md)

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

<a id="organizationlinkinvitationdeclineonetimeidput"></a>
# **OrganizationLinkInvitationDeclineOneTimeIdPut**
> void OrganizationLinkInvitationDeclineOneTimeIdPut (Guid id)

Decline a pending invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationDeclineOneTimeIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Decline a pending invitation
                apiInstance.OrganizationLinkInvitationDeclineOneTimeIdPut(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationDeclineOneTimeIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationDeclineOneTimeIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline a pending invitation
    apiInstance.OrganizationLinkInvitationDeclineOneTimeIdPutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationDeclineOneTimeIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Invitation id |  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="organizationlinkinvitationget"></a>
# **OrganizationLinkInvitationGet**
> List&lt;OrganizationLinkInvitationModel&gt; OrganizationLinkInvitationGet ()

Get static invitation links

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);

            try
            {
                // Get static invitation links
                List<OrganizationLinkInvitationModel> result = apiInstance.OrganizationLinkInvitationGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get static invitation links
    ApiResponse<List<OrganizationLinkInvitationModel>> response = apiInstance.OrganizationLinkInvitationGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrganizationLinkInvitationModel&gt;**](OrganizationLinkInvitationModel.md)

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

<a id="organizationlinkinvitationgetbytokentokenget"></a>
# **OrganizationLinkInvitationGetByTokenTokenGet**
> OrganizationLinkInvitationModel OrganizationLinkInvitationGetByTokenTokenGet (string token)

Get invitation by token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationGetByTokenTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var token = "token_example";  // string | Invitation token

            try
            {
                // Get invitation by token
                OrganizationLinkInvitationModel result = apiInstance.OrganizationLinkInvitationGetByTokenTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGetByTokenTokenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationGetByTokenTokenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get invitation by token
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.OrganizationLinkInvitationGetByTokenTokenGetWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGetByTokenTokenGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Invitation token |  |

### Return type

[**OrganizationLinkInvitationModel**](OrganizationLinkInvitationModel.md)

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

<a id="organizationlinkinvitationgetmyinvitationsget"></a>
# **OrganizationLinkInvitationGetMyInvitationsGet**
> List&lt;OrganizationLinkInvitationModel&gt; OrganizationLinkInvitationGetMyInvitationsGet ()

Gets a list of all pending invitations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationGetMyInvitationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);

            try
            {
                // Gets a list of all pending invitations
                List<OrganizationLinkInvitationModel> result = apiInstance.OrganizationLinkInvitationGetMyInvitationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGetMyInvitationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationGetMyInvitationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of all pending invitations
    ApiResponse<List<OrganizationLinkInvitationModel>> response = apiInstance.OrganizationLinkInvitationGetMyInvitationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationGetMyInvitationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrganizationLinkInvitationModel&gt;**](OrganizationLinkInvitationModel.md)

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

<a id="organizationlinkinvitationiddelete"></a>
# **OrganizationLinkInvitationIdDelete**
> void OrganizationLinkInvitationIdDelete (Guid id)

Delete an invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Delete an invitation
                apiInstance.OrganizationLinkInvitationIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an invitation
    apiInstance.OrganizationLinkInvitationIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Invitation id |  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="organizationlinkinvitationjoinstatictokenput"></a>
# **OrganizationLinkInvitationJoinStaticTokenPut**
> OrganizationLinkInvitationAcceptedResponse OrganizationLinkInvitationJoinStaticTokenPut (string token)

Create an orgainzation link by using a static token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class OrganizationLinkInvitationJoinStaticTokenPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationSDK(config);
            var token = "token_example";  // string | Invitation token

            try
            {
                // Create an orgainzation link by using a static token
                OrganizationLinkInvitationAcceptedResponse result = apiInstance.OrganizationLinkInvitationJoinStaticTokenPut(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationJoinStaticTokenPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrganizationLinkInvitationJoinStaticTokenPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an orgainzation link by using a static token
    ApiResponse<OrganizationLinkInvitationAcceptedResponse> response = apiInstance.OrganizationLinkInvitationJoinStaticTokenPutWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationSDK.OrganizationLinkInvitationJoinStaticTokenPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Invitation token |  |

### Return type

[**OrganizationLinkInvitationAcceptedResponse**](OrganizationLinkInvitationAcceptedResponse.md)

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

