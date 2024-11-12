# Simplic.OxS.SDK.Organization.OrganizationLinkInvitationClient

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptOneTime**](OrganizationLinkInvitationClient.md#organizationlinkinvitationacceptonetimeidput) | **PUT** /OrganizationLinkInvitation/accept-one-time/{id} | Accept a pending invitation |
| [**CreateOneTime**](OrganizationLinkInvitationClient.md#organizationlinkinvitationcreateonetimepost) | **POST** /OrganizationLinkInvitation/create-one-time | Creates a new invitation for linking with another organization |
| [**CreateStatic**](OrganizationLinkInvitationClient.md#organizationlinkinvitationcreatestaticpost) | **POST** /OrganizationLinkInvitation/create-static | Creates a new invitation for linking with another organization |
| [**DeclineOneTime**](OrganizationLinkInvitationClient.md#organizationlinkinvitationdeclineonetimeidput) | **PUT** /OrganizationLinkInvitation/decline-one-time/{id} | Decline a pending invitation |
| [**Get**](OrganizationLinkInvitationClient.md#organizationlinkinvitationget) | **GET** /OrganizationLinkInvitation | Get static invitation links |
| [**GetByTokenTokenGet**](OrganizationLinkInvitationClient.md#organizationlinkinvitationgetbytokentokenget) | **GET** /OrganizationLinkInvitation/get-by-token/{token} | Get invitation by token |
| [**GetMyInvitationsGet**](OrganizationLinkInvitationClient.md#organizationlinkinvitationgetmyinvitationsget) | **GET** /OrganizationLinkInvitation/get-my-invitations | Gets a list of all pending invitations |
| [**Delete**](OrganizationLinkInvitationClient.md#organizationlinkinvitationiddelete) | **DELETE** /OrganizationLinkInvitation/{id} | Delete an invitation |
| [**JoinStatic**](OrganizationLinkInvitationClient.md#organizationlinkinvitationjoinstatictokenput) | **PUT** /OrganizationLinkInvitation/join-static/{token} | Create an orgainzation link by using a static token |

<a id="organizationlinkinvitationacceptonetimeidput"></a>
# **AcceptOneTime**
> OrganizationLinkInvitationAcceptedResponse AcceptOneTime (Guid id)

Accept a pending invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class AcceptOneTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Accept a pending invitation
                OrganizationLinkInvitationAcceptedResponse result = apiInstance.AcceptOneTime(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.AcceptOneTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptOneTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept a pending invitation
    ApiResponse<OrganizationLinkInvitationAcceptedResponse> response = apiInstance.AcceptOneTimeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.AcceptOneTimeWithHttpInfo: " + e.Message);
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
# **CreateOneTime**
> OrganizationLinkInvitationModel CreateOneTime (OrganizationLinkInvitationRequest? organizationLinkInvitationRequest = null)

Creates a new invitation for linking with another organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class CreateOneTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var organizationLinkInvitationRequest = new OrganizationLinkInvitationRequest?(); // OrganizationLinkInvitationRequest? | Invitation request (optional) 

            try
            {
                // Creates a new invitation for linking with another organization
                OrganizationLinkInvitationModel result = apiInstance.CreateOneTime(organizationLinkInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.CreateOneTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOneTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new invitation for linking with another organization
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.CreateOneTimeWithHttpInfo(organizationLinkInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.CreateOneTimeWithHttpInfo: " + e.Message);
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
# **CreateStatic**
> OrganizationLinkInvitationModel CreateStatic (OrganizationLinkStaticInvitationRequest? organizationLinkStaticInvitationRequest = null)

Creates a new invitation for linking with another organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class CreateStaticExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var organizationLinkStaticInvitationRequest = new OrganizationLinkStaticInvitationRequest?(); // OrganizationLinkStaticInvitationRequest? | Invitation request (optional) 

            try
            {
                // Creates a new invitation for linking with another organization
                OrganizationLinkInvitationModel result = apiInstance.CreateStatic(organizationLinkStaticInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.CreateStatic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStaticWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new invitation for linking with another organization
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.CreateStaticWithHttpInfo(organizationLinkStaticInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.CreateStaticWithHttpInfo: " + e.Message);
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
# **DeclineOneTime**
> void DeclineOneTime (Guid id)

Decline a pending invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class DeclineOneTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Decline a pending invitation
                apiInstance.DeclineOneTime(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.DeclineOneTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeclineOneTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline a pending invitation
    apiInstance.DeclineOneTimeWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.DeclineOneTimeWithHttpInfo: " + e.Message);
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
# **Get**
> List&lt;OrganizationLinkInvitationModel&gt; Get ()

Get static invitation links

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);

            try
            {
                // Get static invitation links
                List<OrganizationLinkInvitationModel> result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get static invitation links
    ApiResponse<List<OrganizationLinkInvitationModel>> response = apiInstance.GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.GetWithHttpInfo: " + e.Message);
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
# **GetByTokenTokenGet**
> OrganizationLinkInvitationModel GetByTokenTokenGet (string token)

Get invitation by token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class GetByTokenTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var token = "token_example";  // string | Invitation token

            try
            {
                // Get invitation by token
                OrganizationLinkInvitationModel result = apiInstance.GetByTokenTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.GetByTokenTokenGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByTokenTokenGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get invitation by token
    ApiResponse<OrganizationLinkInvitationModel> response = apiInstance.GetByTokenTokenGetWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.GetByTokenTokenGetWithHttpInfo: " + e.Message);
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
# **GetMyInvitationsGet**
> List&lt;OrganizationLinkInvitationModel&gt; GetMyInvitationsGet ()

Gets a list of all pending invitations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class GetMyInvitationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);

            try
            {
                // Gets a list of all pending invitations
                List<OrganizationLinkInvitationModel> result = apiInstance.GetMyInvitationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.GetMyInvitationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyInvitationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of all pending invitations
    ApiResponse<List<OrganizationLinkInvitationModel>> response = apiInstance.GetMyInvitationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.GetMyInvitationsGetWithHttpInfo: " + e.Message);
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
# **Delete**
> void Delete (Guid id)

Delete an invitation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var id = "id_example";  // Guid | Invitation id

            try
            {
                // Delete an invitation
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an invitation
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.DeleteWithHttpInfo: " + e.Message);
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
# **JoinStatic**
> OrganizationLinkInvitationAcceptedResponse JoinStatic (string token)

Create an orgainzation link by using a static token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class JoinStaticExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationLinkInvitationClient(config);
            var token = "token_example";  // string | Invitation token

            try
            {
                // Create an orgainzation link by using a static token
                OrganizationLinkInvitationAcceptedResponse result = apiInstance.JoinStatic(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationLinkInvitationClient.JoinStatic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JoinStaticWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an orgainzation link by using a static token
    ApiResponse<OrganizationLinkInvitationAcceptedResponse> response = apiInstance.JoinStaticWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationLinkInvitationClient.JoinStaticWithHttpInfo: " + e.Message);
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

