# Simplic.OxS.SDK.Ai.ConversationClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetContexts**](ConversationClient.md#conversationgetcontextsget) | **GET** /Conversation/get-contexts |  |
| [**Delete**](ConversationClient.md#conversationiddelete) | **DELETE** /Conversation/{id} |  |
| [**Get**](ConversationClient.md#conversationidget) | **GET** /Conversation/{id} |  |
| [**Reply**](ConversationClient.md#conversationreplypost) | **POST** /Conversation/reply |  |
| [**ReplyStream**](ConversationClient.md#conversationreplystreampost) | **POST** /Conversation/reply-stream | Reply to a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \&quot;reasoning\&quot; (thinking tokens) and \&quot;content\&quot; (response tokens). Final event is \&quot;done\&quot; with the complete message as JSON data. |
| [**Start**](ConversationClient.md#conversationstartpost) | **POST** /Conversation/start |  |
| [**StartStream**](ConversationClient.md#conversationstartstreampost) | **POST** /Conversation/start-stream | Start a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \&quot;reasoning\&quot; (thinking tokens) and \&quot;content\&quot; (response tokens). Final event is \&quot;done\&quot; with the complete conversation as JSON data. |

<a id="conversationgetcontextsget"></a>
# **GetContexts**
> List&lt;ContextModel&gt; GetContexts ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class GetContextsExample
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

            var apiInstance = new ConversationClient(config);

            try
            {
                List<ContextModel> result = apiInstance.GetContexts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.GetContexts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContextsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ContextModel>> response = apiInstance.GetContextsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.GetContextsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ContextModel&gt;**](ContextModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationiddelete"></a>
# **Delete**
> void Delete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class DeleteExample
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

            var apiInstance = new ConversationClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.Delete: " + e.Message);
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
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.DeleteWithHttpInfo: " + e.Message);
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

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationidget"></a>
# **Get**
> ConversationModel Get (Guid id)



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

            var apiInstance = new ConversationClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ConversationModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.Get: " + e.Message);
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
    ApiResponse<ConversationModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConversationModel**](ConversationModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationreplypost"></a>
# **Reply**
> MessageModel Reply (ReplyToConversationRequest? replyToConversationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class ReplyExample
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

            var apiInstance = new ConversationClient(config);
            var replyToConversationRequest = new ReplyToConversationRequest?(); // ReplyToConversationRequest? |  (optional) 

            try
            {
                MessageModel result = apiInstance.Reply(replyToConversationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.Reply: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MessageModel> response = apiInstance.ReplyWithHttpInfo(replyToConversationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.ReplyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **replyToConversationRequest** | [**ReplyToConversationRequest?**](ReplyToConversationRequest?.md) |  | [optional]  |

### Return type

[**MessageModel**](MessageModel.md)

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationreplystreampost"></a>
# **ReplyStream**
> void ReplyStream (ReplyToConversationRequest? replyToConversationRequest = null)

Reply to a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete message as JSON data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class ReplyStreamExample
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

            var apiInstance = new ConversationClient(config);
            var replyToConversationRequest = new ReplyToConversationRequest?(); // ReplyToConversationRequest? |  (optional) 

            try
            {
                // Reply to a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete message as JSON data.
                apiInstance.ReplyStream(replyToConversationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.ReplyStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplyStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reply to a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete message as JSON data.
    apiInstance.ReplyStreamWithHttpInfo(replyToConversationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.ReplyStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **replyToConversationRequest** | [**ReplyToConversationRequest?**](ReplyToConversationRequest?.md) |  | [optional]  |

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationstartpost"></a>
# **Start**
> ConversationModel Start (StartConversationRequest? startConversationRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class StartExample
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

            var apiInstance = new ConversationClient(config);
            var startConversationRequest = new StartConversationRequest?(); // StartConversationRequest? |  (optional) 

            try
            {
                ConversationModel result = apiInstance.Start(startConversationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.Start: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConversationModel> response = apiInstance.StartWithHttpInfo(startConversationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.StartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startConversationRequest** | [**StartConversationRequest?**](StartConversationRequest?.md) |  | [optional]  |

### Return type

[**ConversationModel**](ConversationModel.md)

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="conversationstartstreampost"></a>
# **StartStream**
> void StartStream (StartConversationRequest? startConversationRequest = null)

Start a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete conversation as JSON data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class StartStreamExample
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

            var apiInstance = new ConversationClient(config);
            var startConversationRequest = new StartConversationRequest?(); // StartConversationRequest? |  (optional) 

            try
            {
                // Start a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete conversation as JSON data.
                apiInstance.StartStream(startConversationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConversationClient.StartStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a conversation with Server-Sent Events streaming. Streams reasoning and content tokens as they arrive from the LLM. Event types: \"reasoning\" (thinking tokens) and \"content\" (response tokens). Final event is \"done\" with the complete conversation as JSON data.
    apiInstance.StartStreamWithHttpInfo(startConversationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConversationClient.StartStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startConversationRequest** | [**StartConversationRequest?**](StartConversationRequest?.md) |  | [optional]  |

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

