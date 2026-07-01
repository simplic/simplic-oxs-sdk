# Simplic.OxS.SDK.Ai.AgentSessionClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Answer**](AgentSessionClient.md#agentsessionsessionidanswerpost) | **POST** /AgentSession/{sessionId}/answer | Answers a clarification question from the agent. |
| [**Approvals**](AgentSessionClient.md#agentsessionsessionidapprovalsget) | **GET** /AgentSession/{sessionId}/approvals | Gets pending approvals for a session. |
| [**Approve**](AgentSessionClient.md#agentsessionsessionidapprovepost) | **POST** /AgentSession/{sessionId}/approve | Approves or rejects a pending action in a session. |
| [**Get**](AgentSessionClient.md#agentsessionsessionidget) | **GET** /AgentSession/{sessionId} | Gets a session by identifier. |
| [**Messages**](AgentSessionClient.md#agentsessionsessionidmessagesget) | **GET** /AgentSession/{sessionId}/messages | Gets all messages for a session. |
| [**Workspace**](AgentSessionClient.md#agentsessionsessionidworkspaceget) | **GET** /AgentSession/{sessionId}/workspace | Gets the workspace entries accumulated during tool executions in a session. |

<a id="agentsessionsessionidanswerpost"></a>
# **Answer**
> void Answer (Guid sessionId, AnswerRequest? answerRequest = null)

Answers a clarification question from the agent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class AnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 
            var answerRequest = new AnswerRequest?(); // AnswerRequest? |  (optional) 

            try
            {
                // Answers a clarification question from the agent.
                apiInstance.Answer(sessionId, answerRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Answer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AnswerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Answers a clarification question from the agent.
    apiInstance.AnswerWithHttpInfo(sessionId, answerRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.AnswerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |
| **answerRequest** | [**AnswerRequest?**](AnswerRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentsessionsessionidapprovalsget"></a>
# **Approvals**
> List&lt;ApprovalRequestDto&gt; Approvals (Guid sessionId)

Gets pending approvals for a session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class ApprovalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 

            try
            {
                // Gets pending approvals for a session.
                List<ApprovalRequestDto> result = apiInstance.Approvals(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Approvals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApprovalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets pending approvals for a session.
    ApiResponse<List<ApprovalRequestDto>> response = apiInstance.ApprovalsWithHttpInfo(sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.ApprovalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |

### Return type

[**List&lt;ApprovalRequestDto&gt;**](ApprovalRequestDto.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentsessionsessionidapprovepost"></a>
# **Approve**
> void Approve (Guid sessionId, ApprovalDecisionRequest? approvalDecisionRequest = null)

Approves or rejects a pending action in a session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class ApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 
            var approvalDecisionRequest = new ApprovalDecisionRequest?(); // ApprovalDecisionRequest? |  (optional) 

            try
            {
                // Approves or rejects a pending action in a session.
                apiInstance.Approve(sessionId, approvalDecisionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Approve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approves or rejects a pending action in a session.
    apiInstance.ApproveWithHttpInfo(sessionId, approvalDecisionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.ApproveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |
| **approvalDecisionRequest** | [**ApprovalDecisionRequest?**](ApprovalDecisionRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentsessionsessionidget"></a>
# **Get**
> AgentSessionResponse Get (Guid sessionId)

Gets a session by identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 

            try
            {
                // Gets a session by identifier.
                AgentSessionResponse result = apiInstance.Get(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Get: " + e.Message);
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
    // Gets a session by identifier.
    ApiResponse<AgentSessionResponse> response = apiInstance.GetWithHttpInfo(sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |

### Return type

[**AgentSessionResponse**](AgentSessionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentsessionsessionidmessagesget"></a>
# **Messages**
> List&lt;AgentMessageResponse&gt; Messages (Guid sessionId)

Gets all messages for a session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class MessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 

            try
            {
                // Gets all messages for a session.
                List<AgentMessageResponse> result = apiInstance.Messages(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Messages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all messages for a session.
    ApiResponse<List<AgentMessageResponse>> response = apiInstance.MessagesWithHttpInfo(sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.MessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |

### Return type

[**List&lt;AgentMessageResponse&gt;**](AgentMessageResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentsessionsessionidworkspaceget"></a>
# **Workspace**
> List&lt;AgentWorkspaceEntryDto&gt; Workspace (Guid sessionId)

Gets the workspace entries accumulated during tool executions in a session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class WorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/ai-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AgentSessionClient(config);
            var sessionId = "sessionId_example";  // Guid | 

            try
            {
                // Gets the workspace entries accumulated during tool executions in a session.
                List<AgentWorkspaceEntryDto> result = apiInstance.Workspace(sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentSessionClient.Workspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the workspace entries accumulated during tool executions in a session.
    ApiResponse<List<AgentWorkspaceEntryDto>> response = apiInstance.WorkspaceWithHttpInfo(sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentSessionClient.WorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **Guid** |  |  |

### Return type

[**List&lt;AgentWorkspaceEntryDto&gt;**](AgentWorkspaceEntryDto.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

