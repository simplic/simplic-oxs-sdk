# Simplic.OxS.SDK.Ai.LLMClient

All URIs are relative to *https://dev-oxs.simplic.io/ai-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](LLMClient.md#llmgetallget) | **GET** /LLM/get-all | Gets all available LLM providers. |
| [**GetEfforts**](LLMClient.md#llmgeteffortsget) | **GET** /LLM/get-efforts | Gets the reasoning effort levels supported by a specific model (e.g. \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, and provider-specific extensions like \&quot;xhigh\&quot;/\&quot;max\&quot;). Returns an empty list if the model has no tunable reasoning effort at all — callers should treat that as \&quot;no effort selector for this model\&quot;, not as an error. |
| [**GetTiers**](LLMClient.md#llmgettiersget) | **GET** /LLM/get-tiers | Gets the simplified capability/cost tiers (see Simplic.OxS.AI.LLMTier) available for selection, each resolved to the concrete model + reasoning effort it currently maps to. Intended for end-user-facing selectors, replacing raw model/effort pickers that assume familiarity with specific model names — clients only need to remember which tier the user picked and send its Simplic.OxS.AI.Server.Model.LLMTierModel.Model/Simplic.OxS.AI.Server.Model.LLMTierModel.Effort straight back as &#x60;Conversation.Model&#x60;/&#x60;Conversation.Effort&#x60;.  A tier is silently omitted if its mapped model is no longer registered, or no longer supports the mapped effort level — this can only happen after a provider change and should never occur in a correctly configured deployment, but failing open (fewer tiers) is safer than returning a tier the backend can&#39;t actually honor. |

<a id="llmgetallget"></a>
# **GetAll**
> List&lt;LLMModelInfoModel&gt; GetAll ()

Gets all available LLM providers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class GetAllExample
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

            var apiInstance = new LLMClient(config);

            try
            {
                // Gets all available LLM providers.
                List<LLMModelInfoModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LLMClient.GetAll: " + e.Message);
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
    // Gets all available LLM providers.
    ApiResponse<List<LLMModelInfoModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LLMClient.GetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LLMModelInfoModel&gt;**](LLMModelInfoModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="llmgeteffortsget"></a>
# **GetEfforts**
> List&lt;LLMTypeModel&gt; GetEfforts (string? model = null)

Gets the reasoning effort levels supported by a specific model (e.g. \"low\", \"medium\", \"high\", and provider-specific extensions like \"xhigh\"/\"max\"). Returns an empty list if the model has no tunable reasoning effort at all — callers should treat that as \"no effort selector for this model\", not as an error.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class GetEffortsExample
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

            var apiInstance = new LLMClient(config);
            var model = "model_example";  // string? | The model name to resolve, as returned by M:Simplic.OxS.AI.Server.Controllers.LLMController.GetAll(System.Threading.CancellationToken). (optional) 

            try
            {
                // Gets the reasoning effort levels supported by a specific model (e.g. \"low\", \"medium\", \"high\", and provider-specific extensions like \"xhigh\"/\"max\"). Returns an empty list if the model has no tunable reasoning effort at all — callers should treat that as \"no effort selector for this model\", not as an error.
                List<LLMTypeModel> result = apiInstance.GetEfforts(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LLMClient.GetEfforts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEffortsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the reasoning effort levels supported by a specific model (e.g. \"low\", \"medium\", \"high\", and provider-specific extensions like \"xhigh\"/\"max\"). Returns an empty list if the model has no tunable reasoning effort at all — callers should treat that as \"no effort selector for this model\", not as an error.
    ApiResponse<List<LLMTypeModel>> response = apiInstance.GetEffortsWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LLMClient.GetEffortsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string?** | The model name to resolve, as returned by M:Simplic.OxS.AI.Server.Controllers.LLMController.GetAll(System.Threading.CancellationToken). | [optional]  |

### Return type

[**List&lt;LLMTypeModel&gt;**](LLMTypeModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="llmgettiersget"></a>
# **GetTiers**
> List&lt;LLMTierModel&gt; GetTiers ()

Gets the simplified capability/cost tiers (see Simplic.OxS.AI.LLMTier) available for selection, each resolved to the concrete model + reasoning effort it currently maps to. Intended for end-user-facing selectors, replacing raw model/effort pickers that assume familiarity with specific model names — clients only need to remember which tier the user picked and send its Simplic.OxS.AI.Server.Model.LLMTierModel.Model/Simplic.OxS.AI.Server.Model.LLMTierModel.Effort straight back as `Conversation.Model`/`Conversation.Effort`.  A tier is silently omitted if its mapped model is no longer registered, or no longer supports the mapped effort level — this can only happen after a provider change and should never occur in a correctly configured deployment, but failing open (fewer tiers) is safer than returning a tier the backend can't actually honor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.Ai;

namespace Example
{
    public class GetTiersExample
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

            var apiInstance = new LLMClient(config);

            try
            {
                // Gets the simplified capability/cost tiers (see Simplic.OxS.AI.LLMTier) available for selection, each resolved to the concrete model + reasoning effort it currently maps to. Intended for end-user-facing selectors, replacing raw model/effort pickers that assume familiarity with specific model names — clients only need to remember which tier the user picked and send its Simplic.OxS.AI.Server.Model.LLMTierModel.Model/Simplic.OxS.AI.Server.Model.LLMTierModel.Effort straight back as `Conversation.Model`/`Conversation.Effort`.  A tier is silently omitted if its mapped model is no longer registered, or no longer supports the mapped effort level — this can only happen after a provider change and should never occur in a correctly configured deployment, but failing open (fewer tiers) is safer than returning a tier the backend can't actually honor.
                List<LLMTierModel> result = apiInstance.GetTiers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LLMClient.GetTiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the simplified capability/cost tiers (see Simplic.OxS.AI.LLMTier) available for selection, each resolved to the concrete model + reasoning effort it currently maps to. Intended for end-user-facing selectors, replacing raw model/effort pickers that assume familiarity with specific model names — clients only need to remember which tier the user picked and send its Simplic.OxS.AI.Server.Model.LLMTierModel.Model/Simplic.OxS.AI.Server.Model.LLMTierModel.Effort straight back as `Conversation.Model`/`Conversation.Effort`.  A tier is silently omitted if its mapped model is no longer registered, or no longer supports the mapped effort level — this can only happen after a provider change and should never occur in a correctly configured deployment, but failing open (fewer tiers) is safer than returning a tier the backend can't actually honor.
    ApiResponse<List<LLMTierModel>> response = apiInstance.GetTiersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LLMClient.GetTiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LLMTierModel&gt;**](LLMTierModel.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

