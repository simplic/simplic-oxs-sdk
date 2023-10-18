# Simplic.OxS.SDK.Organization.MemberClient

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MemberAcceptPost**](MemberClient.md#memberacceptpost) | **POST** /Member/accept | Accept an invitation from an organization |
| [**MemberDeclinePost**](MemberClient.md#memberdeclinepost) | **POST** /Member/decline | Decline an invitation from an organization |
| [**MemberDeleteInvitePost**](MemberClient.md#memberdeleteinvitepost) | **POST** /Member/delete-invite | Deletes a member invite by id. |
| [**MemberGetAllGet**](MemberClient.md#membergetallget) | **GET** /Member/get-all | Returns all memberships |
| [**MemberGetPendingInvitationsGet**](MemberClient.md#membergetpendinginvitationsget) | **GET** /Member/get-pending-invitations | Returns all memberships pending invitations |
| [**MemberInviteMultiplePost**](MemberClient.md#memberinvitemultiplepost) | **POST** /Member/invite-multiple | Invites a list of users by their mail address. |
| [**MemberInvitePost**](MemberClient.md#memberinvitepost) | **POST** /Member/invite | Invites a user by their mail address. |
| [**MemberLeavePost**](MemberClient.md#memberleavepost) | **POST** /Member/leave | Removes a member from an organization by the id of the membership. |
| [**MemberRemovePost**](MemberClient.md#memberremovepost) | **POST** /Member/remove | Removes a member from an organization by the id of the membership. |
| [**MemberUpdateIdPut**](MemberClient.md#memberupdateidput) | **PUT** /Member/update/{id} | Update user membership in organization |

<a id="memberacceptpost"></a>
# **MemberAcceptPost**
> void MemberAcceptPost (AcceptJoinMemberRequest? acceptJoinMemberRequest = null)

Accept an invitation from an organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberAcceptPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var acceptJoinMemberRequest = new AcceptJoinMemberRequest?(); // AcceptJoinMemberRequest? | Model for accepting an invitation (optional) 

            try
            {
                // Accept an invitation from an organization
                apiInstance.MemberAcceptPost(acceptJoinMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberAcceptPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberAcceptPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept an invitation from an organization
    apiInstance.MemberAcceptPostWithHttpInfo(acceptJoinMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberAcceptPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptJoinMemberRequest** | [**AcceptJoinMemberRequest?**](AcceptJoinMemberRequest?.md) | Model for accepting an invitation | [optional]  |

### Return type

void (empty response body)

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

<a id="memberdeclinepost"></a>
# **MemberDeclinePost**
> void MemberDeclinePost (DeclineJoinMemberRequest? declineJoinMemberRequest = null)

Decline an invitation from an organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberDeclinePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var declineJoinMemberRequest = new DeclineJoinMemberRequest?(); // DeclineJoinMemberRequest? | Model for declining an invitation (optional) 

            try
            {
                // Decline an invitation from an organization
                apiInstance.MemberDeclinePost(declineJoinMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberDeclinePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberDeclinePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline an invitation from an organization
    apiInstance.MemberDeclinePostWithHttpInfo(declineJoinMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberDeclinePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **declineJoinMemberRequest** | [**DeclineJoinMemberRequest?**](DeclineJoinMemberRequest?.md) | Model for declining an invitation | [optional]  |

### Return type

void (empty response body)

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

<a id="memberdeleteinvitepost"></a>
# **MemberDeleteInvitePost**
> void MemberDeleteInvitePost (DeleteInviteMemberRequest? deleteInviteMemberRequest = null)

Deletes a member invite by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberDeleteInvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var deleteInviteMemberRequest = new DeleteInviteMemberRequest?(); // DeleteInviteMemberRequest? | Delete invitation model, containing an id (optional) 

            try
            {
                // Deletes a member invite by id.
                apiInstance.MemberDeleteInvitePost(deleteInviteMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberDeleteInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberDeleteInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a member invite by id.
    apiInstance.MemberDeleteInvitePostWithHttpInfo(deleteInviteMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberDeleteInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteInviteMemberRequest** | [**DeleteInviteMemberRequest?**](DeleteInviteMemberRequest?.md) | Delete invitation model, containing an id | [optional]  |

### Return type

void (empty response body)

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

<a id="membergetallget"></a>
# **MemberGetAllGet**
> List&lt;OrganizationMemberModel&gt; MemberGetAllGet ()

Returns all memberships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberGetAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);

            try
            {
                // Returns all memberships
                List<OrganizationMemberModel> result = apiInstance.MemberGetAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all memberships
    ApiResponse<List<OrganizationMemberModel>> response = apiInstance.MemberGetAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberGetAllGetWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="membergetpendinginvitationsget"></a>
# **MemberGetPendingInvitationsGet**
> List&lt;OrganizationMemberInvitationModel&gt; MemberGetPendingInvitationsGet ()

Returns all memberships pending invitations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberGetPendingInvitationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);

            try
            {
                // Returns all memberships pending invitations
                List<OrganizationMemberInvitationModel> result = apiInstance.MemberGetPendingInvitationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberGetPendingInvitationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberGetPendingInvitationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all memberships pending invitations
    ApiResponse<List<OrganizationMemberInvitationModel>> response = apiInstance.MemberGetPendingInvitationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberGetPendingInvitationsGetWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="memberinvitemultiplepost"></a>
# **MemberInviteMultiplePost**
> void MemberInviteMultiplePost (InviteMemberRequest? inviteMemberRequest = null)

Invites a list of users by their mail address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberInviteMultiplePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var inviteMemberRequest = new InviteMemberRequest?(); // InviteMemberRequest? | Invitation model, containing a list of mail addresses (optional) 

            try
            {
                // Invites a list of users by their mail address.
                apiInstance.MemberInviteMultiplePost(inviteMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberInviteMultiplePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberInviteMultiplePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invites a list of users by their mail address.
    apiInstance.MemberInviteMultiplePostWithHttpInfo(inviteMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberInviteMultiplePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inviteMemberRequest** | [**InviteMemberRequest?**](InviteMemberRequest?.md) | Invitation model, containing a list of mail addresses | [optional]  |

### Return type

void (empty response body)

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

<a id="memberinvitepost"></a>
# **MemberInvitePost**
> void MemberInvitePost (string? email = null)

Invites a user by their mail address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberInvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var email = "email_example";  // string? | Email to invite. (optional) 

            try
            {
                // Invites a user by their mail address.
                apiInstance.MemberInvitePost(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invites a user by their mail address.
    apiInstance.MemberInvitePostWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** | Email to invite. | [optional]  |

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

<a id="memberleavepost"></a>
# **MemberLeavePost**
> void MemberLeavePost (LeaveOrganizationRequest? leaveOrganizationRequest = null)

Removes a member from an organization by the id of the membership.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberLeavePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var leaveOrganizationRequest = new LeaveOrganizationRequest?(); // LeaveOrganizationRequest? | Model containing the member-id to remove. (optional) 

            try
            {
                // Removes a member from an organization by the id of the membership.
                apiInstance.MemberLeavePost(leaveOrganizationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberLeavePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberLeavePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a member from an organization by the id of the membership.
    apiInstance.MemberLeavePostWithHttpInfo(leaveOrganizationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberLeavePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaveOrganizationRequest** | [**LeaveOrganizationRequest?**](LeaveOrganizationRequest?.md) | Model containing the member-id to remove. | [optional]  |

### Return type

void (empty response body)

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

<a id="memberremovepost"></a>
# **MemberRemovePost**
> void MemberRemovePost (RemoveMemberRequest? removeMemberRequest = null)

Removes a member from an organization by the id of the membership.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberRemovePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var removeMemberRequest = new RemoveMemberRequest?(); // RemoveMemberRequest? | Model containing the member-id to remove. (optional) 

            try
            {
                // Removes a member from an organization by the id of the membership.
                apiInstance.MemberRemovePost(removeMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberRemovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberRemovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a member from an organization by the id of the membership.
    apiInstance.MemberRemovePostWithHttpInfo(removeMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberRemovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeMemberRequest** | [**RemoveMemberRequest?**](RemoveMemberRequest?.md) | Model containing the member-id to remove. | [optional]  |

### Return type

void (empty response body)

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

<a id="memberupdateidput"></a>
# **MemberUpdateIdPut**
> void MemberUpdateIdPut (Guid id, UpdateMemberRequest? updateMemberRequest = null)

Update user membership in organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;
using Simplic.OxS.SDK.Organization;

namespace Example
{
    public class MemberUpdateIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/organization-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MemberClient(config);
            var id = "id_example";  // Guid | 
            var updateMemberRequest = new UpdateMemberRequest?(); // UpdateMemberRequest? | Model containing the information to update. (optional) 

            try
            {
                // Update user membership in organization
                apiInstance.MemberUpdateIdPut(id, updateMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.MemberUpdateIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MemberUpdateIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update user membership in organization
    apiInstance.MemberUpdateIdPutWithHttpInfo(id, updateMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.MemberUpdateIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateMemberRequest** | [**UpdateMemberRequest?**](UpdateMemberRequest?.md) | Model containing the information to update. | [optional]  |

### Return type

void (empty response body)

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

