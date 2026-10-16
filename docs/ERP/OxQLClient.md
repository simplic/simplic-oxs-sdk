# Simplic.OxS.SDK.ERP.OxQLClient

All URIs are relative to *https://dev-oxs.simplic.io/erp-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Batch**](OxQLClient.md#oxqlbatchpost) | **POST** /OxQL/batch | Runs several OxQL queries in one request. |
| [**Explain**](OxQLClient.md#oxqlexplainpost) | **POST** /OxQL/explain | Explains an OxQL query without running it. |
| [**Health**](OxQLClient.md#oxqlhealthget) | **GET** /OxQL/health | The engine&#39;s version, contract, capabilities and limits on this host. |
| [**Query**](OxQLClient.md#oxqlquerypost) | **POST** /OxQL/query | Runs one OxQL query and answers a page of rows. |

<a id="oxqlbatchpost"></a>
# **Batch**
> OxQLBatchAnswer Batch (string? xOxQLContract = null, string? xOxQLTiming = null, OxQLBatchBody? oxQLBatchBody = null)

Runs several OxQL queries in one request.

Runs the queries in order under one time ceiling and answers each in its place of `results`: a page, or the refusal of that query. The status is 200 unless the batch itself is refused. The language is described in the OxQL documentation (https://github.com/simplic/oxql/blob/master/src/docs/oxql-query-syntax.md); the limits of this host are published by `GET /OxQL/health`. Send the header `X-OxQL-Contract: 2`; a request without it is read as contract 1 (legacy, see https://github.com/simplic/oxql/blob/master/src/docs/LEGACY.md).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class BatchExample
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

            var apiInstance = new OxQLClient(config);
            var xOxQLContract = "1";  // string? | The contract the request is written for. `2` is the current contract. Absent, empty or `1` is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. (optional) 
            var xOxQLTiming = "xOxQLTiming_example";  // string? | `1` or `true` asks for the `timing` member of the answer: where the request's time went (the database commands, the owners asked, this host's own share). Contract 2 only. (optional) 
            var oxQLBatchBody = new OxQLBatchBody?(); // OxQLBatchBody? | The queries. (optional) 

            try
            {
                // Runs several OxQL queries in one request.
                OxQLBatchAnswer result = apiInstance.Batch(xOxQLContract, xOxQLTiming, oxQLBatchBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OxQLClient.Batch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Runs several OxQL queries in one request.
    ApiResponse<OxQLBatchAnswer> response = apiInstance.BatchWithHttpInfo(xOxQLContract, xOxQLTiming, oxQLBatchBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OxQLClient.BatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xOxQLContract** | **string?** | The contract the request is written for. &#x60;2&#x60; is the current contract. Absent, empty or &#x60;1&#x60; is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. | [optional]  |
| **xOxQLTiming** | **string?** | &#x60;1&#x60; or &#x60;true&#x60; asks for the &#x60;timing&#x60; member of the answer: where the request&#39;s time went (the database commands, the owners asked, this host&#39;s own share). Contract 2 only. | [optional]  |
| **oxQLBatchBody** | [**OxQLBatchBody?**](OxQLBatchBody?.md) | The queries. | [optional]  |

### Return type

[**OxQLBatchAnswer**](OxQLBatchAnswer.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | One entry per query in &#x60;results&#x60;, in order: its page, or its refusal. |  -  |
| **400** | The batch itself is refused: it is no batch, or it carries more queries than the host runs. |  -  |
| **401** | The host requires authentication and the request carries none. |  -  |
| **413** | The body is larger than the host reads. |  -  |
| **500** | A fault of the engine; the message names the correlation id of its log line. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="oxqlexplainpost"></a>
# **Explain**
> OxQLExplainAnswer Explain (string? xOxQLContract = null, string? ifNoneMatch = null, OxQLExplainBody? oxQLExplainBody = null)

Explains an OxQL query without running it.

Says whether a query binds and can run on this host, with every error, the stages, the shape of the rows and, on request, the plan. The body is a query or an envelope around one. A query that does not bind is answered 200 with `valid: false`. The answer is described in https://github.com/simplic/oxql/blob/master/src/docs/oxql-operations.md. Send the header `X-OxQL-Contract: 2`; a request without it is read as contract 1 (legacy, see https://github.com/simplic/oxql/blob/master/src/docs/LEGACY.md).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class ExplainExample
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

            var apiInstance = new OxQLClient(config);
            var xOxQLContract = "1";  // string? | The contract the request is written for. `2` is the current contract. Absent, empty or `1` is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. (optional) 
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The `ETag` of the answer the caller holds. The route answers 304 without a body while that answer still stands. (optional) 
            var oxQLExplainBody = new OxQLExplainBody?(); // OxQLExplainBody? | The query, or the envelope around it. (optional) 

            try
            {
                // Explains an OxQL query without running it.
                OxQLExplainAnswer result = apiInstance.Explain(xOxQLContract, ifNoneMatch, oxQLExplainBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OxQLClient.Explain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExplainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Explains an OxQL query without running it.
    ApiResponse<OxQLExplainAnswer> response = apiInstance.ExplainWithHttpInfo(xOxQLContract, ifNoneMatch, oxQLExplainBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OxQLClient.ExplainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xOxQLContract** | **string?** | The contract the request is written for. &#x60;2&#x60; is the current contract. Absent, empty or &#x60;1&#x60; is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. | [optional]  |
| **ifNoneMatch** | **string?** | The &#x60;ETag&#x60; of the answer the caller holds. The route answers 304 without a body while that answer still stands. | [optional]  |
| **oxQLExplainBody** | [**OxQLExplainBody?**](OxQLExplainBody?.md) | The query, or the envelope around it. | [optional]  |

### Return type

[**OxQLExplainAnswer**](OxQLExplainAnswer.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Whether the query binds and can run, with its errors, stages and shapes. A query that does not bind is answered here with &#x60;valid: false&#x60;. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |
| **304** | The answer the caller holds (&#x60;If-None-Match&#x60;) still stands. |  * ETag - The validator of the answer, to send back as &#x60;If-None-Match&#x60;. <br>  |
| **400** | The body does not read, or the explain is past one of its bounds. |  -  |
| **401** | The host requires authentication and the request carries none. |  -  |
| **403** | The request belongs to no organisation, or the caller may not use the route. |  -  |
| **404** | Explain is switched off on this host. |  -  |
| **413** | The body is larger than the host reads for an explain. |  -  |
| **429** | More explains than the caller may send or have in flight; &#x60;Retry-After&#x60; says when to try again. |  * Retry-After - The seconds after which the request may be sent again. <br>  |
| **500** | A fault of the engine; the message names the correlation id of its log line. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="oxqlhealthget"></a>
# **Health**
> OxQLHealthAnswer Health (bool? shallow = null, string? xOxQLContract = null)

The engine's version, contract, capabilities and limits on this host.

Anonymous and always 200. Publishes the limits a request is checked against, what this host can do, the state of the services its model joins into and of its model. A request with `X-OxQL-Contract: 2` reads every member; one without the header reads the members contract 1 has. The members are described in https://github.com/simplic/oxql/blob/master/src/docs/oxql-operations.md.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class HealthExample
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

            var apiInstance = new OxQLClient(config);
            var shallow = false;  // bool? | `true` leaves `remote` out and measures nothing: the form one service asks of another. (optional)  (default to false)
            var xOxQLContract = "1";  // string? | The contract the request is written for. `2` is the current contract. Absent, empty or `1` is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. (optional) 

            try
            {
                // The engine's version, contract, capabilities and limits on this host.
                OxQLHealthAnswer result = apiInstance.Health(shallow, xOxQLContract);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OxQLClient.Health: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The engine's version, contract, capabilities and limits on this host.
    ApiResponse<OxQLHealthAnswer> response = apiInstance.HealthWithHttpInfo(shallow, xOxQLContract);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OxQLClient.HealthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shallow** | **bool?** | &#x60;true&#x60; leaves &#x60;remote&#x60; out and measures nothing: the form one service asks of another. | [optional] [default to false] |
| **xOxQLContract** | **string?** | The contract the request is written for. &#x60;2&#x60; is the current contract. Absent, empty or &#x60;1&#x60; is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. | [optional]  |

### Return type

[**OxQLHealthAnswer**](OxQLHealthAnswer.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The state of the engine on this host. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="oxqlquerypost"></a>
# **Query**
> OxQLQueryAnswer Query (string? xOxQLContract = null, string? xOxQLTiming = null, OxQLQueryBody? oxQLQueryBody = null)

Runs one OxQL query and answers a page of rows.

Reads one entity of this service through a pipeline of stages and answers a page of rows with what is known of their count, or a refusal with a code. The language is described in the OxQL documentation (https://github.com/simplic/oxql/blob/master/src/docs/oxql-query-syntax.md); the limits of this host are published by `GET /OxQL/health`. Send the header `X-OxQL-Contract: 2`; a request without it is read as contract 1 (legacy, see https://github.com/simplic/oxql/blob/master/src/docs/LEGACY.md). Contract 1 is not what this operation describes: its body and answer are the deprecated schemas `OxQLContract1QueryBody` and `OxQLContract1QueryAnswer`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.ERP;

namespace Example
{
    public class QueryExample
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

            var apiInstance = new OxQLClient(config);
            var xOxQLContract = "1";  // string? | The contract the request is written for. `2` is the current contract. Absent, empty or `1` is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. (optional) 
            var xOxQLTiming = "xOxQLTiming_example";  // string? | `1` or `true` asks for the `timing` member of the answer: where the request's time went (the database commands, the owners asked, this host's own share). Contract 2 only. (optional) 
            var oxQLQueryBody = new OxQLQueryBody?(); // OxQLQueryBody? | The query. (optional) 

            try
            {
                // Runs one OxQL query and answers a page of rows.
                OxQLQueryAnswer result = apiInstance.Query(xOxQLContract, xOxQLTiming, oxQLQueryBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OxQLClient.Query: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Runs one OxQL query and answers a page of rows.
    ApiResponse<OxQLQueryAnswer> response = apiInstance.QueryWithHttpInfo(xOxQLContract, xOxQLTiming, oxQLQueryBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OxQLClient.QueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xOxQLContract** | **string?** | The contract the request is written for. &#x60;2&#x60; is the current contract. Absent, empty or &#x60;1&#x60; is contract 1 (legacy): another request language and another answer. Any other value is refused with 400 on the query, batch and explain routes. | [optional]  |
| **xOxQLTiming** | **string?** | &#x60;1&#x60; or &#x60;true&#x60; asks for the &#x60;timing&#x60; member of the answer: where the request&#39;s time went (the database commands, the owners asked, this host&#39;s own share). Contract 2 only. | [optional]  |
| **oxQLQueryBody** | [**OxQLQueryBody?**](OxQLQueryBody?.md) | The query. | [optional]  |

### Return type

[**OxQLQueryAnswer**](OxQLQueryAnswer.md)

### Authorization

[ApiKey](../README.md#ApiKey), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The page: &#x60;items&#x60;, &#x60;pageInfo&#x60; with the cursor to the next page and the count, and &#x60;diagnostics&#x60; when there are any. |  -  |
| **400** | The request is wrong as written: a refusal with a code per error. |  -  |
| **401** | The host requires authentication and the request carries none. |  -  |
| **403** | The request belongs to no organisation, or the caller may not use the route. |  -  |
| **413** | The body is larger than the host reads. |  -  |
| **422** | The request is well-formed and cannot be run as asked: a service it joins into refused or is missing, or a &#x60;strict&#x60; request would lose data. |  -  |
| **500** | A fault of the engine; the message names the correlation id of its log line. |  -  |
| **504** | The query did not finish within its time. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

