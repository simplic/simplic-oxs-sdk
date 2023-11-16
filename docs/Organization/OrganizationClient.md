# Simplic.OxS.SDK.Organization.OrganizationClient

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get**](OrganizationClient.md#organizationget) | **GET** /Organization | Returns the actual organization, from \&quot;OId\&quot;-claim in the jwt token |
| [**GetForUserGet**](OrganizationClient.md#organizationgetforuserget) | **GET** /Organization/get-for-user | Returns a list of organizations that belongs to the current user |
| [**GetMemberInvitationsGet**](OrganizationClient.md#organizationgetmemberinvitationsget) | **GET** /Organization/get-member-invitations | Returns a list of member invitations for the organization that belongs to the current user |
| [**GetMemberListGet**](OrganizationClient.md#organizationgetmemberlistget) | **GET** /Organization/get-member-list | Returns all member that belongs to the current organization |
| [**Post**](OrganizationClient.md#organizationpost) | **POST** /Organization | Creates a new organization and connects it with the currently logged in user |
| [**Put**](OrganizationClient.md#organizationput) | **PUT** /Organization | Change the actual organization information |

<a id="organizationget"></a>
# **Get**
> OrganizationModel Get ()

Returns the actual organization, from \"OId\"-claim in the jwt token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
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

            var apiInstance = new OrganizationClient(config);

            try
            {
                // Returns the actual organization, from \"OId\"-claim in the jwt token
                OrganizationModel result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.Get: " + e.Message);
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
    // Returns the actual organization, from \"OId\"-claim in the jwt token
    ApiResponse<OrganizationModel> response = apiInstance.GetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OrganizationModel**](OrganizationModel.md)

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

<a id="organizationgetforuserget"></a>
# **GetForUserGet**
> List&lt;OrganizationMemberModel&gt; GetForUserGet ()

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
    public class GetForUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationClient(config);

            try
            {
                // Returns a list of organizations that belongs to the current user
                List<OrganizationMemberModel> result = apiInstance.GetForUserGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.GetForUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetForUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of organizations that belongs to the current user
    ApiResponse<List<OrganizationMemberModel>> response = apiInstance.GetForUserGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.GetForUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrganizationMemberModel&gt;**](OrganizationMemberModel.md)

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

<a id="organizationgetmemberinvitationsget"></a>
# **GetMemberInvitationsGet**
> List&lt;OrganizationMemberInvitationModel&gt; GetMemberInvitationsGet ()

Returns a list of member invitations for the organization that belongs to the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class GetMemberInvitationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationClient(config);

            try
            {
                // Returns a list of member invitations for the organization that belongs to the current user
                List<OrganizationMemberInvitationModel> result = apiInstance.GetMemberInvitationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.GetMemberInvitationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberInvitationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of member invitations for the organization that belongs to the current user
    ApiResponse<List<OrganizationMemberInvitationModel>> response = apiInstance.GetMemberInvitationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.GetMemberInvitationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrganizationMemberInvitationModel&gt;**](OrganizationMemberInvitationModel.md)

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

<a id="organizationgetmemberlistget"></a>
# **GetMemberListGet**
> List&lt;OrganizationMemberModel&gt; GetMemberListGet ()

Returns all member that belongs to the current organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class GetMemberListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationClient(config);

            try
            {
                // Returns all member that belongs to the current organization
                List<OrganizationMemberModel> result = apiInstance.GetMemberListGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.GetMemberListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all member that belongs to the current organization
    ApiResponse<List<OrganizationMemberModel>> response = apiInstance.GetMemberListGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.GetMemberListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;OrganizationMemberModel&gt;**](OrganizationMemberModel.md)

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

<a id="organizationpost"></a>
# **Post**
> OrganizationModel Post (CreateOrganizationRequest? createOrganizationRequest = null)

Creates a new organization and connects it with the currently logged in user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationClient(config);
            var createOrganizationRequest = new CreateOrganizationRequest?(); // CreateOrganizationRequest? |  (optional) 

            try
            {
                // Creates a new organization and connects it with the currently logged in user
                OrganizationModel result = apiInstance.Post(createOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.Post: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new organization and connects it with the currently logged in user
    ApiResponse<OrganizationModel> response = apiInstance.PostWithHttpInfo(createOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrganizationRequest** | [**CreateOrganizationRequest?**](CreateOrganizationRequest?.md) |  | [optional]  |

### Return type

[**OrganizationModel**](OrganizationModel.md)

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

<a id="organizationput"></a>
# **Put**
> OrganizationModel Put (UpdateOrganizationRequest? updateOrganizationRequest = null)

Change the actual organization information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationClient(config);
            var updateOrganizationRequest = new UpdateOrganizationRequest?(); // UpdateOrganizationRequest? | Update request model (optional) 

            try
            {
                // Change the actual organization information
                OrganizationModel result = apiInstance.Put(updateOrganizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationClient.Put: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the actual organization information
    ApiResponse<OrganizationModel> response = apiInstance.PutWithHttpInfo(updateOrganizationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationClient.PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateOrganizationRequest** | [**UpdateOrganizationRequest?**](UpdateOrganizationRequest?.md) | Update request model | [optional]  |

### Return type

[**OrganizationModel**](OrganizationModel.md)

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

