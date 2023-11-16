# Simplic.OxS.SDK.Organization.MemberClient

All URIs are relative to *https://dev-oxs.simplic.io/organization-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Accept**](MemberClient.md#memberacceptpost) | **POST** /Member/accept | Accept an invitation from an organization |
| [**Decline**](MemberClient.md#memberdeclinepost) | **POST** /Member/decline | Decline an invitation from an organization |
| [**DeleteInvite**](MemberClient.md#memberdeleteinvitepost) | **POST** /Member/delete-invite | Deletes a member invite by id. |
| [**GetAll**](MemberClient.md#membergetallget) | **GET** /Member/get-all | Returns all memberships |
| [**GetPendingInvitations**](MemberClient.md#membergetpendinginvitationsget) | **GET** /Member/get-pending-invitations | Returns all memberships pending invitations |
| [**InviteMultiple**](MemberClient.md#memberinvitemultiplepost) | **POST** /Member/invite-multiple | Invites a list of users by their mail address. |
| [**Invite**](MemberClient.md#memberinvitepost) | **POST** /Member/invite | Invites a user by their mail address. |
| [**Leave**](MemberClient.md#memberleavepost) | **POST** /Member/leave | Removes a member from an organization by the id of the membership. |
| [**Remove**](MemberClient.md#memberremovepost) | **POST** /Member/remove | Removes a member from an organization by the id of the membership. |
| [**Update**](MemberClient.md#memberupdateidput) | **PUT** /Member/update/{id} | Update user membership in organization |

<a id="memberacceptpost"></a>
# **Accept**
> void Accept (AcceptJoinMemberRequest? acceptJoinMemberRequest = null)

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
    public class AcceptExample
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
                apiInstance.Accept(acceptJoinMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Accept: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept an invitation from an organization
    apiInstance.AcceptWithHttpInfo(acceptJoinMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.AcceptWithHttpInfo: " + e.Message);
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
# **Decline**
> void Decline (DeclineJoinMemberRequest? declineJoinMemberRequest = null)

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
    public class DeclineExample
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
                apiInstance.Decline(declineJoinMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Decline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeclineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline an invitation from an organization
    apiInstance.DeclineWithHttpInfo(declineJoinMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.DeclineWithHttpInfo: " + e.Message);
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
# **DeleteInvite**
> void DeleteInvite (DeleteInviteMemberRequest? deleteInviteMemberRequest = null)

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
    public class DeleteInviteExample
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
                apiInstance.DeleteInvite(deleteInviteMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.DeleteInvite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a member invite by id.
    apiInstance.DeleteInviteWithHttpInfo(deleteInviteMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.DeleteInviteWithHttpInfo: " + e.Message);
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
# **GetAll**
> List&lt;OrganizationMemberModel&gt; GetAll ()

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
    public class GetAllExample
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
                List<OrganizationMemberModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.GetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all memberships
    ApiResponse<List<OrganizationMemberModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.GetAllWithHttpInfo: " + e.Message);
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
# **GetPendingInvitations**
> List&lt;OrganizationMemberInvitationModel&gt; GetPendingInvitations ()

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
    public class GetPendingInvitationsExample
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
                List<OrganizationMemberInvitationModel> result = apiInstance.GetPendingInvitations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.GetPendingInvitations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPendingInvitationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all memberships pending invitations
    ApiResponse<List<OrganizationMemberInvitationModel>> response = apiInstance.GetPendingInvitationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.GetPendingInvitationsWithHttpInfo: " + e.Message);
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
# **InviteMultiple**
> void InviteMultiple (InviteMemberRequest? inviteMemberRequest = null)

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
    public class InviteMultipleExample
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
                apiInstance.InviteMultiple(inviteMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.InviteMultiple: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteMultipleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invites a list of users by their mail address.
    apiInstance.InviteMultipleWithHttpInfo(inviteMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.InviteMultipleWithHttpInfo: " + e.Message);
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
# **Invite**
> void Invite (string? email = null)

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
    public class InviteExample
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
                apiInstance.Invite(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Invite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invites a user by their mail address.
    apiInstance.InviteWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.InviteWithHttpInfo: " + e.Message);
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
# **Leave**
> void Leave (LeaveOrganizationRequest? leaveOrganizationRequest = null)

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
    public class LeaveExample
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
                apiInstance.Leave(leaveOrganizationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Leave: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LeaveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a member from an organization by the id of the membership.
    apiInstance.LeaveWithHttpInfo(leaveOrganizationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.LeaveWithHttpInfo: " + e.Message);
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
# **Remove**
> void Remove (RemoveMemberRequest? removeMemberRequest = null)

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
    public class RemoveExample
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
                apiInstance.Remove(removeMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Remove: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a member from an organization by the id of the membership.
    apiInstance.RemoveWithHttpInfo(removeMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.RemoveWithHttpInfo: " + e.Message);
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
# **Update**
> void Update (Guid id, UpdateMemberRequest? updateMemberRequest = null)

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
    public class UpdateExample
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
                apiInstance.Update(id, updateMemberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MemberClient.Update: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update user membership in organization
    apiInstance.UpdateWithHttpInfo(id, updateMemberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MemberClient.UpdateWithHttpInfo: " + e.Message);
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

