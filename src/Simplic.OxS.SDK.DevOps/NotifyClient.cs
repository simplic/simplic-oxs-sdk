// <auto-generated>
/*
 * Simplic.OxS.DevOps
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

namespace Simplic.OxS.SDK.DevOps
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the devops service.
    /// </summary>
    public interface INotifyClient
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
        /// <param name="guid"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void Send(Guid guid = default(Guid));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SendWithHttpInfo(Guid guid = default(Guid));
         
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        Task SendAsync(Guid guid = default(Guid), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SendWithHttpInfoAsync(Guid guid = default(Guid), CancellationToken cancellationToken = default(CancellationToken));

    }

    /// <inheritdoc cref="INotifyClient">
    public class NotifyClient : INotifyClient
    {
        private __NotifyClient _internalClient;
        private HttpClient _httpClient;

        public NotifyClient(string host, string? authorization = null)
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri($"{host}/devops-api/v1") };
            var jsonSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(jsonSerializerOptions);
            var events = new NotifyClientEvents();
            if (authorization is null)
            {
                _internalClient = new __NotifyClient(_httpClient, jsonSerializerOptionsProvider, events, new NullTokenProvider<ApiKeyToken>());
            }
            else
            {
                var token = new ApiKeyToken(authorization, "Authorization", "");
                _internalClient = new __NotifyClient(_httpClient, jsonSerializerOptionsProvider, events, new ApiKeyTokenProvider(new[] { token }));
            }
        }

        public NotifyClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <inheritdoc />
        public string GetBasePath() => _httpClient.BaseAddress.ToString();

        /// <inheritdoc />
        public void Send(Guid guid = default(Guid))
        {
            try
            {
                var response = _internalClient.SendAsync(guid).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public ApiResponse<Object> SendWithHttpInfo(Guid guid = default(Guid))
        {
            try
            {
                var response = _internalClient.SendAsync(guid).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                return new ApiResponse<Object>(response.StatusCode, response.Headers.ToMultimap(), null, response.RawContent);
                
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <inheritdoc />
        public async Task SendAsync(Guid guid = default(Guid), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.SendAsync(guid, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
            
                
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public async Task<ApiResponse<Object>> SendWithHttpInfoAsync(Guid guid = default(Guid), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.SendAsync(guid, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                return new ApiResponse<Object>(response.StatusCode, response.Headers.ToMultimap(), null, response.RawContent);
                
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
    internal interface __INotifyClient : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        NotifyClientEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__NotifyClient.INotifyClientApiNotifySendPostApiResponse"/>&gt;</returns>
        Task<__NotifyClient.INotifyClientApiNotifySendPostApiResponse> SendAsync(Option<Guid> guid = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__NotifyClient.INotifyClientApiNotifySendPostApiResponse"/>?&gt;</returns>
        Task<__NotifyClient.INotifyClientApiNotifySendPostApiResponse?> SendOrDefaultAsync(Option<Guid> guid = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotifyClientEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnApiNotifySendPost;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorApiNotifySendPost;

        internal void ExecuteOnApiNotifySendPost(__NotifyClient.NotifyClientApiNotifySendPostApiResponse apiResponse)
        {
            OnApiNotifySendPost?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorApiNotifySendPost(Exception exception)
        {
            OnErrorApiNotifySendPost?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal sealed partial class __NotifyClient : __INotifyClient
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public NotifyClientEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __NotifyClient(
            HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            NotifyClientEvents notifyClientEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            HttpClient = httpClient;
            Events = notifyClientEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatApiNotifySendPost(ref Option<Guid> guid);

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="guid"></param>
        private void AfterApiNotifySendPostDefaultImplementation(__NotifyClient.INotifyClientApiNotifySendPostApiResponse apiResponseLocalVar, Option<Guid> guid)
        {
            bool suppressDefaultLog = false;
            AfterApiNotifySendPost(ref suppressDefaultLog, apiResponseLocalVar, guid);
            //if (!suppressDefaultLog)
            //    Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="guid"></param>
        partial void AfterApiNotifySendPost(ref bool suppressDefaultLog, __NotifyClient.INotifyClientApiNotifySendPostApiResponse apiResponseLocalVar, Option<Guid> guid);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="guid"></param>
        private void OnErrorApiNotifySendPostDefaultImplementation(Exception exception, string pathFormat, string path, Option<Guid> guid)
        {
            bool suppressDefaultLog = false;
            OnErrorApiNotifySendPost(ref suppressDefaultLog, exception, pathFormat, path, guid);
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
        /// <param name="guid"></param>
        partial void OnErrorApiNotifySendPost(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, Option<Guid> guid);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__NotifyClient.INotifyClientApiNotifySendPostApiResponse"/>&gt;</returns>
        public async Task<__NotifyClient.INotifyClientApiNotifySendPostApiResponse?> SendOrDefaultAsync(Option<Guid> guid = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await SendAsync(guid, cancellationToken).ConfigureAwait(false);
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
        /// <param name="guid"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__NotifyClient.INotifyClientApiNotifySendPostApiResponse"/>&gt;</returns>
        public async Task<__NotifyClient.INotifyClientApiNotifySendPostApiResponse> SendAsync(Option<Guid> guid = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                FormatApiNotifySendPost(ref guid);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.PathAndQuery + "/api/Notify/send";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (guid.IsSet)
                        parseQueryStringLocalVar["guid"] = guid.Value.ToString();

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

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

                    httpRequestMessageLocalVar.Method = new HttpMethod("POST");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        NotifyClientApiNotifySendPostApiResponse apiResponseLocalVar = new NotifyClientApiNotifySendPostApiResponse(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/api/Notify/send", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterApiNotifySendPostDefaultImplementation(apiResponseLocalVar, guid);

                        Events.ExecuteOnApiNotifySendPost(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorApiNotifySendPostDefaultImplementation(e, "/api/Notify/send", uriBuilderLocalVar.Path, guid);
                Events.ExecuteOnErrorApiNotifySendPost(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="INotifyClientApiNotifySendPostApiResponse"/>
        /// </summary>
        internal interface INotifyClientApiNotifySendPostApiResponse : Simplic.OxS.SDK.__IApiResponse
        {
            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            bool IsOk { get; }
        }

        /// <summary>
        /// The <see cref="NotifyClientApiNotifySendPostApiResponse"/>
        /// </summary>
        internal partial class NotifyClientApiNotifySendPostApiResponse : Simplic.OxS.SDK.__ApiResponse, INotifyClientApiNotifySendPostApiResponse
        {
            /// <summary>
            /// The <see cref="NotifyClientApiNotifySendPostApiResponse"/>
            /// </summary>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public NotifyClientApiNotifySendPostApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

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
