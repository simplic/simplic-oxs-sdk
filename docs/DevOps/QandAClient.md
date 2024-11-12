# Simplic.OxS.SDK.DevOps.QandAClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckSession**](QandAClient.md#apiqandachecksessionget) | **GET** /api/QandA/checkSession |  |
| [**CompanyData**](QandAClient.md#apiqandacompanydataget) | **GET** /api/QandA/companyData |  |
| [**EndSurvey**](QandAClient.md#apiqandaendsurveyget) | **GET** /api/QandA/endSurvey |  |
| [**GetModules**](QandAClient.md#apiqandagetmodulesget) | **GET** /api/QandA/getModules |  |
| [**GetProcesses**](QandAClient.md#apiqandagetprocessesget) | **GET** /api/QandA/getProcesses |  |
| [**GetQuestion**](QandAClient.md#apiqandagetquestionget) | **GET** /api/QandA/get-question |  |
| [**MoveBackward**](QandAClient.md#apiqandamovebackwardget) | **GET** /api/QandA/moveBackward |  |
| [**MoveForward**](QandAClient.md#apiqandamoveforwardget) | **GET** /api/QandA/moveForward |  |
| [**NewSession**](QandAClient.md#apiqandanewsessionpost) | **POST** /api/QandA/new-session |  |

<a id="apiqandachecksessionget"></a>
# **CheckSession**
> void CheckSession (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class CheckSessionExample
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
                apiInstance.CheckSession(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.CheckSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CheckSessionWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.CheckSessionWithHttpInfo: " + e.Message);
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
# **CompanyData**
> void CompanyData (string? sessionId = null, string? companyName = null, string? street = null, string? email = null, string? country = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class CompanyDataExample
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
                apiInstance.CompanyData(sessionId, companyName, street, email, country);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.CompanyData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompanyDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CompanyDataWithHttpInfo(sessionId, companyName, street, email, country);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.CompanyDataWithHttpInfo: " + e.Message);
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
# **EndSurvey**
> void EndSurvey (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class EndSurveyExample
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
                apiInstance.EndSurvey(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.EndSurvey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndSurveyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.EndSurveyWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.EndSurveyWithHttpInfo: " + e.Message);
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
# **GetModules**
> void GetModules (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class GetModulesExample
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
                apiInstance.GetModules(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.GetModules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetModulesWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.GetModulesWithHttpInfo: " + e.Message);
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
# **GetProcesses**
> void GetProcesses (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class GetProcessesExample
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
                apiInstance.GetProcesses(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.GetProcesses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetProcessesWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.GetProcessesWithHttpInfo: " + e.Message);
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
# **GetQuestion**
> void GetQuestion (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class GetQuestionExample
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
                apiInstance.GetQuestion(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.GetQuestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetQuestionWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.GetQuestionWithHttpInfo: " + e.Message);
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
# **MoveBackward**
> void MoveBackward (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class MoveBackwardExample
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
                apiInstance.MoveBackward(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.MoveBackward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveBackwardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveBackwardWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.MoveBackwardWithHttpInfo: " + e.Message);
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
# **MoveForward**
> void MoveForward (string? sessionId = null, string? moduleId = null, string? processId = null, List<string>? userInput = null, string? commentBox = null, string? questionId = null, Dictionary<string, Question>? answeredQuestions = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class MoveForwardExample
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
                apiInstance.MoveForward(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.MoveForward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveForwardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveForwardWithHttpInfo(sessionId, moduleId, processId, userInput, commentBox, questionId, answeredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.MoveForwardWithHttpInfo: " + e.Message);
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
# **NewSession**
> void NewSession (System.IO.Stream? file = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class NewSessionExample
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
                apiInstance.NewSession(file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QandAClient.NewSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.NewSessionWithHttpInfo(file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QandAClient.NewSessionWithHttpInfo: " + e.Message);
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

