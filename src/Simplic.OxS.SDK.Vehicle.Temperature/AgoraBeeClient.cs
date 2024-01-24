// <auto-generated>
/*
 * Simplic.OxS.vehicle-temperature
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the vehicle-temperature service.
    /// </summary>
    public interface IAgoraBeeClient
    {
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        string GetBasePath();

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        //IReadableConfiguration Configuration;

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PostAgoraBeeResponse</returns>
        PostAgoraBeeResponse Post(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <returns>ApiResponse of PostAgoraBeeResponse</returns>
        ApiResponse<PostAgoraBeeResponse> PostWithHttpInfo(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest));
         
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostAgoraBeeResponse</returns>
        Task<PostAgoraBeeResponse> PostAsync(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostAgoraBeeResponse)</returns>
        Task<ApiResponse<PostAgoraBeeResponse>> PostWithHttpInfoAsync(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest), CancellationToken cancellationToken = default(CancellationToken));

    }

    /// <inheritdoc cref="IAgoraBeeClient">
    public class AgoraBeeClient : IAgoraBeeClient
    {
        private __AgoraBeeClient _internalClient;
        private HttpClient _httpClient;

        public AgoraBeeClient(string host, string? authorization = null)
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri($"{host}/vehicle-temperature-api/v1") };
            var jsonSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(jsonSerializerOptions);
            var events = new AgoraBeeClientEvents();
            if (authorization is null)
            {
                _internalClient = new __AgoraBeeClient(_httpClient, jsonSerializerOptionsProvider, events, new NullTokenProvider<ApiKeyToken>());
            }
            else
            {
                var token = new ApiKeyToken(authorization, "Authorization", "");
                _internalClient = new __AgoraBeeClient(_httpClient, jsonSerializerOptionsProvider, events, new ApiKeyTokenProvider(new[] { token }));
            }
        }

        public AgoraBeeClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <inheritdoc />
        public string GetBasePath() => _httpClient.BaseAddress.ToString();

        /// <inheritdoc />
        public PostAgoraBeeResponse Post(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest))
        {
            try
            {
                var response = _internalClient.PostAsync(postAgoraBeeRequest).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                return response.Ok();
                
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public ApiResponse<PostAgoraBeeResponse> PostWithHttpInfo(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest))
        {
            try
            {
                var response = _internalClient.PostAsync(postAgoraBeeRequest).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<PostAgoraBeeResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <inheritdoc />
        public async Task<PostAgoraBeeResponse> PostAsync(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.PostAsync(postAgoraBeeRequest, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
            
                return response.Ok();
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public async Task<ApiResponse<PostAgoraBeeResponse>> PostWithHttpInfoAsync(PostAgoraBeeRequest postAgoraBeeRequest = default(PostAgoraBeeRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.PostAsync(postAgoraBeeRequest, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<PostAgoraBeeResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }    

        private string FormatErrorMessage(string message, int errorCode) => $"<{errorCode} - {(HttpStatusCode)errorCode}> {message}";
    }
    //--Custom wrapper end
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    internal interface __IAgoraBeeClient : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        AgoraBeeClientEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse"/>&gt;</returns>
        Task<__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse> PostAsync(Option<PostAgoraBeeRequest> postAgoraBeeRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse"/>?&gt;</returns>
        Task<__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse?> PostOrDefaultAsync(Option<PostAgoraBeeRequest> postAgoraBeeRequest = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgoraBeeClientEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnAgoraBeePost;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorAgoraBeePost;

        internal void ExecuteOnAgoraBeePost(__AgoraBeeClient.AgoraBeeClientAgoraBeePostApiResponse apiResponse)
        {
            OnAgoraBeePost?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorAgoraBeePost(Exception exception)
        {
            OnErrorAgoraBeePost?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal sealed partial class __AgoraBeeClient : __IAgoraBeeClient
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public AgoraBeeClientEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgoraBeeClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __AgoraBeeClient(
            HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            AgoraBeeClientEvents agoraBeeClientEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            HttpClient = httpClient;
            Events = agoraBeeClientEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatAgoraBeePost(Option<PostAgoraBeeRequest> postAgoraBeeRequest);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="postAgoraBeeRequest"></param>
        /// <returns></returns>
        private void ValidateAgoraBeePost(Option<PostAgoraBeeRequest> postAgoraBeeRequest)
        {
            if (postAgoraBeeRequest.IsSet && postAgoraBeeRequest.Value == null)
                throw new ArgumentNullException(nameof(postAgoraBeeRequest));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="postAgoraBeeRequest"></param>
        private void AfterAgoraBeePostDefaultImplementation(__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse apiResponseLocalVar, Option<PostAgoraBeeRequest> postAgoraBeeRequest)
        {
            bool suppressDefaultLog = false;
            AfterAgoraBeePost(ref suppressDefaultLog, apiResponseLocalVar, postAgoraBeeRequest);
            //if (!suppressDefaultLog)
            //    Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="postAgoraBeeRequest"></param>
        partial void AfterAgoraBeePost(ref bool suppressDefaultLog, __AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse apiResponseLocalVar, Option<PostAgoraBeeRequest> postAgoraBeeRequest);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="postAgoraBeeRequest"></param>
        private void OnErrorAgoraBeePostDefaultImplementation(Exception exception, string pathFormat, string path, Option<PostAgoraBeeRequest> postAgoraBeeRequest)
        {
            bool suppressDefaultLog = false;
            OnErrorAgoraBeePost(ref suppressDefaultLog, exception, pathFormat, path, postAgoraBeeRequest);
            //if (!suppressDefaultLog)
            //    Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="postAgoraBeeRequest"></param>
        partial void OnErrorAgoraBeePost(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, Option<PostAgoraBeeRequest> postAgoraBeeRequest);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse"/>&gt;</returns>
        public async Task<__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse?> PostOrDefaultAsync(Option<PostAgoraBeeRequest> postAgoraBeeRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await PostAsync(postAgoraBeeRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="postAgoraBeeRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse"/>&gt;</returns>
        public async Task<__AgoraBeeClient.IAgoraBeeClientAgoraBeePostApiResponse> PostAsync(Option<PostAgoraBeeRequest> postAgoraBeeRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateAgoraBeePost(postAgoraBeeRequest);

                FormatAgoraBeePost(postAgoraBeeRequest);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.PathAndQuery + "/AgoraBee";

                    if (postAgoraBeeRequest.IsSet)
                        httpRequestMessageLocalVar.Content = (postAgoraBeeRequest.Value as object) is System.IO.Stream stream
                            ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                            : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(postAgoraBeeRequest.Value, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    if (ApiKeyProvider.HasTokens)
                    {
                        ApiKeyToken apiKeyTokenLocalVar;
                        apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);
                        tokenBaseLocalVars.Add(apiKeyTokenLocalVar);
                        //apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "Authorization");
                        apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar);
                    }
                    

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json",
                        "text/json",
                        "application/*+json"
                    };

                    string? contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "text/plain",
                        "application/json",
                        "text/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("POST");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        AgoraBeeClientAgoraBeePostApiResponse apiResponseLocalVar = new AgoraBeeClientAgoraBeePostApiResponse(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/AgoraBee", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterAgoraBeePostDefaultImplementation(apiResponseLocalVar, postAgoraBeeRequest);

                        Events.ExecuteOnAgoraBeePost(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorAgoraBeePostDefaultImplementation(e, "/AgoraBee", uriBuilderLocalVar.Path, postAgoraBeeRequest);
                Events.ExecuteOnErrorAgoraBeePost(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="IAgoraBeeClientAgoraBeePostApiResponse"/>
        /// </summary>
        internal interface IAgoraBeeClientAgoraBeePostApiResponse : Simplic.OxS.SDK.__IApiResponse, IOk<PostAgoraBeeResponse>, IBadRequest<ProblemDetails>, IUnauthorized<ProblemDetails>
        {
            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            bool IsOk { get; }
    
            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            bool IsBadRequest { get; }
    
            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            bool IsUnauthorized { get; }
        }

        /// <summary>
        /// The <see cref="AgoraBeeClientAgoraBeePostApiResponse"/>
        /// </summary>
        internal partial class AgoraBeeClientAgoraBeePostApiResponse : Simplic.OxS.SDK.__ApiResponse, IAgoraBeeClientAgoraBeePostApiResponse
        {
            /// <summary>
            /// The <see cref="AgoraBeeClientAgoraBeePostApiResponse"/>
            /// </summary>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public AgoraBeeClientAgoraBeePostApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public PostAgoraBeeResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<PostAgoraBeeResponse>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out PostAgoraBeeResponse result)
            {
                result = default;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return IsOk;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public bool IsBadRequest => 400 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 400 BadRequest.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public ProblemDetails BadRequest()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsBadRequest
                    ? System.Text.Json.JsonSerializer.Deserialize<ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryBadRequest(out ProblemDetails result)
            {
                result = default;

                try
                {
                    result = BadRequest();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)400);
                }

                return IsBadRequest;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public bool IsUnauthorized => 401 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 401 Unauthorized.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public ProblemDetails Unauthorized()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsUnauthorized
                    ? System.Text.Json.JsonSerializer.Deserialize<ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryUnauthorized(out ProblemDetails result)
            {
                result = default;

                try
                {
                    result = Unauthorized();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)401);
                }

                return IsUnauthorized;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                //if (!suppressDefaultLog)
                //    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
