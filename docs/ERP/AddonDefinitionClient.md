# Simplic.OxS.SDK.ERP.AddonDefinitionClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ById**](AddonDefinitionClient.md#addondefinitionbyididget) | **GET** /AddonDefinition/by-id/{id} | One addon definition. |
| [**Get**](AddonDefinitionClient.md#addondefinitionentityget) | **GET** /AddonDefinition/{entity} | The addon definitions of one entity. |
| [**Delete**](AddonDefinitionClient.md#addondefinitioniddelete) | **DELETE** /AddonDefinition/{id} | Retires an addon definition. |
| [**Put**](AddonDefinitionClient.md#addondefinitionidput) | **PUT** /AddonDefinition/{id} | Changes the labels and the value list of an addon definition. |
| [**Post**](AddonDefinitionClient.md#addondefinitionpost) | **POST** /AddonDefinition | Defines an addon property of an entity. |

<a id="addondefinitionbyididget"></a>
# **ById**
> AddonDefinitionResponse ById (Guid id)

One addon definition.

Answers the definition of that id, also a retired one. An addon definition is a property an organisation adds to an extendable entity of this service: it is one of the properties of the entity's `addon` member (`GET /schema/addons`), and OxQL filters and sorts by it as its kind. The rules are described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class ByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonDefinitionClient(config);
            var id = "id_example";  // Guid | The id of the definition.

            try
            {
                // One addon definition.
                AddonDefinitionResponse result = apiInstance.ById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonDefinitionClient.ById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // One addon definition.
    ApiResponse<AddonDefinitionResponse> response = apiInstance.ByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddonDefinitionClient.ByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the definition. |  |

### Return type

[**AddonDefinitionResponse**](AddonDefinitionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The definition. |  -  |
| **401** | The request carries no credentials. |  -  |
| **404** | The caller&#39;s organisation has no definition of that id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addondefinitionentityget"></a>
# **Get**
> List&lt;AddonDefinitionResponse&gt; Get (string entity)

The addon definitions of one entity.

Answers every definition the caller's organisation holds for the entity, ordered by path, the retired ones among them and flagged. An addon definition is a property an organisation adds to an extendable entity of this service: it is one of the properties of the entity's `addon` member (`GET /schema/addons`), and OxQL filters and sorts by it as its kind. The rules are described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonDefinitionClient(config);
            var entity = "entity_example";  // string | The id of the entity, as the schema document names it (`parcel.parcel`). An id the entity had before is read as the entity.

            try
            {
                // The addon definitions of one entity.
                List<AddonDefinitionResponse> result = apiInstance.Get(entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonDefinitionClient.Get: " + e.Message);
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
    // The addon definitions of one entity.
    ApiResponse<List<AddonDefinitionResponse>> response = apiInstance.GetWithHttpInfo(entity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddonDefinitionClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entity** | **string** | The id of the entity, as the schema document names it (&#x60;parcel.parcel&#x60;). An id the entity had before is read as the entity. |  |

### Return type

[**List&lt;AddonDefinitionResponse&gt;**](AddonDefinitionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The definitions; an empty list for an entity without any. |  -  |
| **401** | The request carries no credentials. |  -  |
| **404** | The service has no entity of that id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addondefinitioniddelete"></a>
# **Delete**
> void Delete (Guid id)

Retires an addon definition.

The definition stays stored and is flagged retired; its key is no property of the entity's `addon` member any more, and the values stored under it stay. A retired definition is retired again without an effect, and `POST /AddonDefinition` with its path and kind revives it. An addon definition is a property an organisation adds to an extendable entity of this service: it is one of the properties of the entity's `addon` member (`GET /schema/addons`), and OxQL filters and sorts by it as its kind. The rules are described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonDefinitionClient(config);
            var id = "id_example";  // Guid | The id of the definition.

            try
            {
                // Retires an addon definition.
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonDefinitionClient.Delete: " + e.Message);
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
    // Retires an addon definition.
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddonDefinitionClient.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the definition. |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/problem+json, text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The definition is retired. |  -  |
| **401** | The request carries no credentials. |  -  |
| **404** | The caller&#39;s organisation has no definition of that id. |  -  |
| **409** | The definition was to move to the current id of its entity, and another request defined its path there meanwhile. The body is the reason as a sentence; the request can be sent again. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addondefinitionidput"></a>
# **Put**
> AddonDefinitionResponse Put (Guid id, UpdateAddonDefinitionRequest? updateAddonDefinitionRequest = null)

Changes the labels and the value list of an addon definition.

Replaces the display name, the description and the value list of the definition by those of the body; a member left out is cleared. Entity, path and kind stay as they are. An addon definition is a property an organisation adds to an extendable entity of this service: it is one of the properties of the entity's `addon` member (`GET /schema/addons`), and OxQL filters and sorts by it as its kind. The rules are described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonDefinitionClient(config);
            var id = "id_example";  // Guid | The id of the definition.
            var updateAddonDefinitionRequest = new UpdateAddonDefinitionRequest?(); // UpdateAddonDefinitionRequest? | The labels and the value list the definition gets. (optional) 

            try
            {
                // Changes the labels and the value list of an addon definition.
                AddonDefinitionResponse result = apiInstance.Put(id, updateAddonDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonDefinitionClient.Put: " + e.Message);
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
    // Changes the labels and the value list of an addon definition.
    ApiResponse<AddonDefinitionResponse> response = apiInstance.PutWithHttpInfo(id, updateAddonDefinitionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddonDefinitionClient.PutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the definition. |  |
| **updateAddonDefinitionRequest** | [**UpdateAddonDefinitionRequest?**](UpdateAddonDefinitionRequest?.md) | The labels and the value list the definition gets. | [optional]  |

### Return type

[**AddonDefinitionResponse**](AddonDefinitionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The definition as it is stored. |  -  |
| **400** | A rule refuses the value list or a text (the kind takes no value list, a size limit). The body is the reason as a sentence. A body that cannot be read is answered as &#x60;application/problem+json&#x60;. |  -  |
| **401** | The request carries no credentials. |  -  |
| **404** | The caller&#39;s organisation has no definition of that id. |  -  |
| **409** | The definition was to move to the current id of its entity, and another request defined its path there meanwhile. The body is the reason as a sentence; the request can be sent again. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addondefinitionpost"></a>
# **Post**
> AddonDefinitionResponse Post (CreateAddonDefinitionRequest? createAddonDefinitionRequest = null)

Defines an addon property of an entity.

Stores a definition for the caller's organisation and answers it with its id. Its entity, path and kind do not change afterwards; a retired definition of the same path and kind is revived, with its id, instead of a second one being stored. An addon definition is a property an organisation adds to an extendable entity of this service: it is one of the properties of the entity's `addon` member (`GET /schema/addons`), and OxQL filters and sorts by it as its kind. The rules are described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/erp-api/v1";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonDefinitionClient(config);
            var createAddonDefinitionRequest = new CreateAddonDefinitionRequest?(); // CreateAddonDefinitionRequest? | The definition to store. (optional) 

            try
            {
                // Defines an addon property of an entity.
                AddonDefinitionResponse result = apiInstance.Post(createAddonDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonDefinitionClient.Post: " + e.Message);
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
    // Defines an addon property of an entity.
    ApiResponse<AddonDefinitionResponse> response = apiInstance.PostWithHttpInfo(createAddonDefinitionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddonDefinitionClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAddonDefinitionRequest** | [**CreateAddonDefinitionRequest?**](CreateAddonDefinitionRequest?.md) | The definition to store. | [optional]  |

### Return type

[**AddonDefinitionResponse**](AddonDefinitionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The definition as it is stored. &#x60;Location&#x60; names the route that answers it. |  -  |
| **400** | A rule refuses the definition (the entity, the path, the kind, the value list, a size limit, a path that another definition&#39;s path is part of). The body is the reason as a sentence. A body that cannot be read is answered as &#x60;application/problem+json&#x60;. |  -  |
| **401** | The request carries no credentials. |  -  |
| **403** | The request belongs to no organisation. |  -  |
| **409** | The path is already defined on the entity, or was defined with another kind and retired. The body is the reason as a sentence. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

