# Simplic.OxS.SDK.Ai.AgentClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Ask**](AgentClient.md#agentaskpost) | **POST** /Agent/ask | Ask mode: research and answer questions without executing write operations. Accepts &#x60;application/json&#x60;. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the &#x60;content&#x60; field. |
| [**Execute**](AgentClient.md#agentexecutepost) | **POST** /Agent/execute | Agent mode: execute tool-based actions with approval workflows. Accepts &#x60;application/json&#x60;. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the &#x60;content&#x60; field. |
| [**Plan**](AgentClient.md#agentplanpost) | **POST** /Agent/plan | Create an execution plan without executing it. Accepts &#x60;application/json&#x60;. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the &#x60;content&#x60; field. |
| [**Stream**](AgentClient.md#agentstreampost) | **POST** /Agent/stream | Stream agent execution events using Server-Sent Events. Accepts &#x60;application/json&#x60;. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the &#x60;content&#x60; field. |

<a id="agentaskpost"></a>
# **Ask**
> AgentResponse Ask (AgentRequest? agentRequest = null)

Ask mode: research and answer questions without executing write operations. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class AskExample
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

            var apiInstance = new AgentClient(config);
            var agentRequest = new AgentRequest?(); // AgentRequest? |  (optional) 

            try
            {
                // Ask mode: research and answer questions without executing write operations. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
                AgentResponse result = apiInstance.Ask(agentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentClient.Ask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ask mode: research and answer questions without executing write operations. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
    ApiResponse<AgentResponse> response = apiInstance.AskWithHttpInfo(agentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentClient.AskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentRequest** | [**AgentRequest?**](AgentRequest?.md) |  | [optional]  |

### Return type

[**AgentResponse**](AgentResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentexecutepost"></a>
# **Execute**
> AgentResponse Execute (AgentRequest? agentRequest = null)

Agent mode: execute tool-based actions with approval workflows. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class ExecuteExample
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

            var apiInstance = new AgentClient(config);
            var agentRequest = new AgentRequest?(); // AgentRequest? |  (optional) 

            try
            {
                // Agent mode: execute tool-based actions with approval workflows. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
                AgentResponse result = apiInstance.Execute(agentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentClient.Execute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Agent mode: execute tool-based actions with approval workflows. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
    ApiResponse<AgentResponse> response = apiInstance.ExecuteWithHttpInfo(agentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentClient.ExecuteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentRequest** | [**AgentRequest?**](AgentRequest?.md) |  | [optional]  |

### Return type

[**AgentResponse**](AgentResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentplanpost"></a>
# **Plan**
> AgentPlan Plan (AgentRequest? agentRequest = null)

Create an execution plan without executing it. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class PlanExample
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

            var apiInstance = new AgentClient(config);
            var agentRequest = new AgentRequest?(); // AgentRequest? |  (optional) 

            try
            {
                // Create an execution plan without executing it. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
                AgentPlan result = apiInstance.Plan(agentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentClient.Plan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an execution plan without executing it. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
    ApiResponse<AgentPlan> response = apiInstance.PlanWithHttpInfo(agentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentClient.PlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentRequest** | [**AgentRequest?**](AgentRequest?.md) |  | [optional]  |

### Return type

[**AgentPlan**](AgentPlan.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="agentstreampost"></a>
# **Stream**
> void Stream (AgentRequest? agentRequest = null)

Stream agent execution events using Server-Sent Events. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class StreamExample
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

            var apiInstance = new AgentClient(config);
            var agentRequest = new AgentRequest?(); // AgentRequest? |  (optional) 

            try
            {
                // Stream agent execution events using Server-Sent Events. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
                apiInstance.Stream(agentRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentClient.Stream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stream agent execution events using Server-Sent Events. Accepts `application/json`. Attach documents via Simplic.OxS.AI.Agent.Models.AgentDocument with base64-encoded bytes in the `content` field.
    apiInstance.StreamWithHttpInfo(agentRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentClient.StreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **agentRequest** | [**AgentRequest?**](AgentRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

