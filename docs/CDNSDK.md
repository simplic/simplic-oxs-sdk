# Simplic.OxS.SDK.CDN.Api.CDNSDK

All URIs are relative to *https://dev-oxs.simplic.io/cdn-api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CDNBlobIdDelete**](CDNSDK.md#cdnblobiddelete) | **DELETE** /CDN/{blobId} |  |
| [**CDNGetFileBlobIdGet**](CDNSDK.md#cdngetfileblobidget) | **GET** /CDN/get-file/{blobId} |  |
| [**CDNGetMetadataBlobIdGet**](CDNSDK.md#cdngetmetadatablobidget) | **GET** /CDN/get-metadata/{blobId} |  |
| [**CDNUploadFilePost**](CDNSDK.md#cdnuploadfilepost) | **POST** /CDN/upload-file |  |
| [**CDNUploadPost**](CDNSDK.md#cdnuploadpost) | **POST** /CDN/upload |  |

<a id="cdnblobiddelete"></a>
# **CDNBlobIdDelete**
> BlobMetadata CDNBlobIdDelete (Guid blobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN.Api;
using Simplic.OxS.SDK.CDN.Client;
using Simplic.OxS.SDK.CDN.Model;

namespace Example
{
    public class CDNBlobIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CDNSDK(config);
            var blobId = "blobId_example";  // Guid | 

            try
            {
                BlobMetadata result = apiInstance.CDNBlobIdDelete(blobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CDNSDK.CDNBlobIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNBlobIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BlobMetadata> response = apiInstance.CDNBlobIdDeleteWithHttpInfo(blobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CDNSDK.CDNBlobIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blobId** | **Guid** |  |  |

### Return type

[**BlobMetadata**](BlobMetadata.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cdngetfileblobidget"></a>
# **CDNGetFileBlobIdGet**
> System.IO.Stream CDNGetFileBlobIdGet (Guid blobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN.Api;
using Simplic.OxS.SDK.CDN.Client;
using Simplic.OxS.SDK.CDN.Model;

namespace Example
{
    public class CDNGetFileBlobIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CDNSDK(config);
            var blobId = "blobId_example";  // Guid | 

            try
            {
                System.IO.Stream result = apiInstance.CDNGetFileBlobIdGet(blobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CDNSDK.CDNGetFileBlobIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNGetFileBlobIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.CDNGetFileBlobIdGetWithHttpInfo(blobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CDNSDK.CDNGetFileBlobIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blobId** | **Guid** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cdngetmetadatablobidget"></a>
# **CDNGetMetadataBlobIdGet**
> BlobMetadata CDNGetMetadataBlobIdGet (Guid blobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN.Api;
using Simplic.OxS.SDK.CDN.Client;
using Simplic.OxS.SDK.CDN.Model;

namespace Example
{
    public class CDNGetMetadataBlobIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CDNSDK(config);
            var blobId = "blobId_example";  // Guid | 

            try
            {
                BlobMetadata result = apiInstance.CDNGetMetadataBlobIdGet(blobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CDNSDK.CDNGetMetadataBlobIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNGetMetadataBlobIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BlobMetadata> response = apiInstance.CDNGetMetadataBlobIdGetWithHttpInfo(blobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CDNSDK.CDNGetMetadataBlobIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blobId** | **Guid** |  |  |

### Return type

[**BlobMetadata**](BlobMetadata.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cdnuploadfilepost"></a>
# **CDNUploadFilePost**
> UploadFilesResponse CDNUploadFilePost (List<System.IO.Stream>? files = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN.Api;
using Simplic.OxS.SDK.CDN.Client;
using Simplic.OxS.SDK.CDN.Model;

namespace Example
{
    public class CDNUploadFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CDNSDK(config);
            var files = new List<System.IO.Stream>?(); // List<System.IO.Stream>? |  (optional) 

            try
            {
                UploadFilesResponse result = apiInstance.CDNUploadFilePost(files);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CDNSDK.CDNUploadFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNUploadFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UploadFilesResponse> response = apiInstance.CDNUploadFilePostWithHttpInfo(files);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CDNSDK.CDNUploadFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **List&lt;System.IO.Stream&gt;?** |  | [optional]  |

### Return type

[**UploadFilesResponse**](UploadFilesResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cdnuploadpost"></a>
# **CDNUploadPost**
> UploadResponse CDNUploadPost (UploadBytesRequest? uploadBytesRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Simplic.OxS.SDK.CDN.Api;
using Simplic.OxS.SDK.CDN.Client;
using Simplic.OxS.SDK.CDN.Model;

namespace Example
{
    public class CDNUploadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev-oxs.simplic.io/cdn-api/v1";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CDNSDK(config);
            var uploadBytesRequest = new UploadBytesRequest?(); // UploadBytesRequest? |  (optional) 

            try
            {
                UploadResponse result = apiInstance.CDNUploadPost(uploadBytesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CDNSDK.CDNUploadPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNUploadPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UploadResponse> response = apiInstance.CDNUploadPostWithHttpInfo(uploadBytesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CDNSDK.CDNUploadPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadBytesRequest** | [**UploadBytesRequest?**](UploadBytesRequest?.md) |  | [optional]  |

### Return type

[**UploadResponse**](UploadResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

