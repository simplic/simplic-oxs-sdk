# Simplic.OxS.SDK.DevOps.ProjectClient

All URIs are relative to *https://dev-oxs.simplic.io/devops-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAll**](ProjectClient.md#projectgetallget) | **GET** /Project/get-all |  |
| [**Get**](ProjectClient.md#projectidget) | **GET** /Project/{id} |  |
| [**Post**](ProjectClient.md#projectpost) | **POST** /Project |  |

<a id="projectgetallget"></a>
# **GetAll**
> List&lt;ProjectModel&gt; GetAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class GetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectClient(config);

            try
            {
                List<ProjectModel> result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectClient.GetAll: " + e.Message);
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
    ApiResponse<List<ProjectModel>> response = apiInstance.GetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectClient.GetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ProjectModel&gt;**](ProjectModel.md)

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

<a id="projectidget"></a>
# **Get**
> ProjectModel Get (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectClient(config);
            var id = "id_example";  // Guid | 

            try
            {
                ProjectModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectClient.Get: " + e.Message);
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
    ApiResponse<ProjectModel> response = apiInstance.GetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectClient.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ProjectModel**](ProjectModel.md)

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

<a id="projectpost"></a>
# **Post**
> ProjectModel Post (CreateProjectModel? createProjectModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;

using Simplic.OxS.SDK.DevOps;

namespace Example
{
    public class PostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/devops-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProjectClient(config);
            var createProjectModel = new CreateProjectModel?(); // CreateProjectModel? |  (optional) 

            try
            {
                ProjectModel result = apiInstance.Post(createProjectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectClient.Post: " + e.Message);
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
    ApiResponse<ProjectModel> response = apiInstance.PostWithHttpInfo(createProjectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectClient.PostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createProjectModel** | [**CreateProjectModel?**](CreateProjectModel?.md) |  | [optional]  |

### Return type

[**ProjectModel**](ProjectModel.md)

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

