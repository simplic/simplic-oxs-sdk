# Simplic.OxS.SDK.ERP.SchemaClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Addons**](SchemaClient.md#schemaaddonsget) | **GET** /schema/addons | The addon definitions of the caller&#39;s organisation, per entity that takes them. |
| [**Get**](SchemaClient.md#schemaget) | **GET** /schema | The Ox schema document of this service. |

<a id="schemaaddonsget"></a>
# **Addons**
> Dictionary&lt;string, List&lt;OxSchemaProperty&gt;&gt; Addons (string? ifNoneMatch = null)

The addon definitions of the caller's organisation, per entity that takes them.

Answers one list per entity of this service that takes addon definitions, keyed by entity id: an entity that is declared extendable and has an `addon` member. A list holds the organisation's addon definitions as property descriptors in the schema document's format, which are the properties of the entity's `addon` member. An entity without definitions has an empty list. The format is described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class AddonsExample
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

            var apiInstance = new SchemaClient(config);
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The `ETag` of the answer the caller holds. The route answers 304 without a body while that answer still stands. (optional) 

            try
            {
                // The addon definitions of the caller's organisation, per entity that takes them.
                Dictionary<string, List<OxSchemaProperty>> result = apiInstance.Addons(ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaClient.Addons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The addon definitions of the caller's organisation, per entity that takes them.
    ApiResponse<Dictionary<string, List<OxSchemaProperty>>> response = apiInstance.AddonsWithHttpInfo(ifNoneMatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaClient.AddonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ifNoneMatch** | **string?** | The &#x60;ETag&#x60; of the answer the caller holds. The route answers 304 without a body while that answer still stands. | [optional]  |

### Return type

**Dictionary<string, List<OxSchemaProperty>>**

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The definitions per entity id. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |
| **304** | The lists the caller holds (&#x60;If-None-Match&#x60;) are the current ones. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |
| **401** | The request carries no credentials. |  -  |
| **403** | The request belongs to no organisation. |  -  |
| **404** | The service is configured with no database, so it holds no addon definitions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="schemaget"></a>
# **Get**
> OxSchemaDocument Get (string? ifNoneMatch = null)

The Ox schema document of this service.

Describes the entities of this service a query can read: their types, keys, references and REST operations, and the limits a query is checked against. The document is the same for every organisation and does not change while the service runs; `revision` and the `ETag` name its content. Anonymous unless the service requires authorization for it. The format is described in https://github.com/simplic/simplic-oxs/blob/master/OX_SCHEMA.md.

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

            var apiInstance = new SchemaClient(config);
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The `ETag` of the answer the caller holds. The route answers 304 without a body while that answer still stands. (optional) 

            try
            {
                // The Ox schema document of this service.
                OxSchemaDocument result = apiInstance.Get(ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaClient.Get: " + e.Message);
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
    // The Ox schema document of this service.
    ApiResponse<OxSchemaDocument> response = apiInstance.GetWithHttpInfo(ifNoneMatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ifNoneMatch** | **string?** | The &#x60;ETag&#x60; of the answer the caller holds. The route answers 304 without a body while that answer still stands. | [optional]  |

### Return type

[**OxSchemaDocument**](OxSchemaDocument.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The document. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |
| **304** | The document the caller holds (&#x60;If-None-Match&#x60;) is the current one. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

