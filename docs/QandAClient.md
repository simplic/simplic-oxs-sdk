# Simplic.OxS.SDK.DevOps.QandAClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiQandACheckSessionGet**](QandAClient.md#apiqandachecksessionget) | **GET** /api/QandA/checkSession |  |
| [**ApiQandACompanyDataGet**](QandAClient.md#apiqandacompanydataget) | **GET** /api/QandA/companyData |  |
| [**ApiQandAEndSurveyGet**](QandAClient.md#apiqandaendsurveyget) | **GET** /api/QandA/endSurvey |  |
| [**ApiQandAGetModulesGet**](QandAClient.md#apiqandagetmodulesget) | **GET** /api/QandA/getModules |  |
| [**ApiQandAGetProcessesGet**](QandAClient.md#apiqandagetprocessesget) | **GET** /api/QandA/getProcesses |  |
| [**ApiQandAGetQuestionGet**](QandAClient.md#apiqandagetquestionget) | **GET** /api/QandA/get-question |  |
| [**ApiQandAMoveBackwardGet**](QandAClient.md#apiqandamovebackwardget) | **GET** /api/QandA/moveBackward |  |
| [**ApiQandAMoveForwardGet**](QandAClient.md#apiqandamoveforwardget) | **GET** /api/QandA/moveForward |  |
| [**ApiQandANewSessionPost**](QandAClient.md#apiqandanewsessionpost) | **POST** /api/QandA/new-session |  |

<a id="apiqandachecksessionget"></a>
# **ApiQandACheckSessionGet**
> void ApiQandACheckSessionGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandACheckSessionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandACheckSessionGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandACheckSessionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandACheckSessionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandACheckSessionGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandACheckSessionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandacompanydataget"></a>
# **ApiQandACompanyDataGet**
> void ApiQandACompanyDataGet (string? sessionId = null, string? companyName = null, string? street = null, string? email = null, string? country = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandACompanyDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var companyName = "companyName_example";  // string? |  (optional) 
            var street = "street_example";  // string? |  (optional) 
            var email = "email_example";  // string? |  (optional) 
            var country = "country_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiQandACompanyDataGet(sessionId, companyName, street, email, country);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandACompanyDataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandACompanyDataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandACompanyDataGetWithHttpInfo(sessionId, companyName, street, email, country);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandACompanyDataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **companyName** | **string?** |  | [optional]  |
| **street** | **string?** |  | [optional]  |
| **email** | **string?** |  | [optional]  |
| **country** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandaendsurveyget"></a>
# **ApiQandAEndSurveyGet**
> void ApiQandAEndSurveyGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAEndSurveyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAEndSurveyGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAEndSurveyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAEndSurveyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAEndSurveyGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAEndSurveyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandagetmodulesget"></a>
# **ApiQandAGetModulesGet**
> void ApiQandAGetModulesGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAGetModulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAGetModulesGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAGetModulesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAGetModulesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAGetModulesGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAGetModulesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandagetprocessesget"></a>
# **ApiQandAGetProcessesGet**
> void ApiQandAGetProcessesGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAGetProcessesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAGetProcessesGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAGetProcessesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAGetProcessesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAGetProcessesGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAGetProcessesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandagetquestionget"></a>
# **ApiQandAGetQuestionGet**
> void ApiQandAGetQuestionGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAGetQuestionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAGetQuestionGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAGetQuestionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAGetQuestionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAGetQuestionGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAGetQuestionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandamovebackwardget"></a>
# **ApiQandAMoveBackwardGet**
> void ApiQandAMoveBackwardGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAMoveBackwardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAMoveBackwardGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAMoveBackwardGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAMoveBackwardGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAMoveBackwardGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAMoveBackwardGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandamoveforwardget"></a>
# **ApiQandAMoveForwardGet**
> void ApiQandAMoveForwardGet (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandAMoveForwardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var sessionId = "sessionId_example";  // string? |  (optional) 
            var moduleId = "moduleId_example";  // string? |  (optional) 
            var processId = "processId_example";  // string? |  (optional) 
            var userInput = new List<string>?(); // List<string>? |  (optional) 
            var commentBox = "commentBox_example";  // string? |  (optional) 
            var questionId = "questionId_example";  // string? |  (optional) 
            var answeredQuestions = new Dictionary<string, Question>?(); // Dictionary<string, Question>? |  (optional) 

            try
            {
                apiInstance.ApiQandAMoveForwardGet(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandAMoveForwardGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandAMoveForwardGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandAMoveForwardGetWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandAMoveForwardGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string?** |  | [optional]  |
| **moduleId** | **string?** |  | [optional]  |
| **processId** | **string?** |  | [optional]  |
| **userInput** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **commentBox** | **string?** |  | [optional]  |
| **questionId** | **string?** |  | [optional]  |
| **answeredQuestions** | [**Dictionary&lt;string, Question&gt;?**](Question.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiqandanewsessionpost"></a>
# **ApiQandANewSessionPost**
> void ApiQandANewSessionPost (System.IO.Stream? file = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;
using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class ApiQandANewSessionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QandAClient(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                apiInstance.ApiQandANewSessionPost(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.ApiQandANewSessionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQandANewSessionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiQandANewSessionPostWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.ApiQandANewSessionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

