// <auto-generated>
/*
 * Simplic.OxS.Geo
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

namespace Simplic.OxS.SDK.Geo
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the geo service.
    /// </summary>
    public interface IRoutingClient
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
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RoutingResponse</returns>
        RoutingResponse CalculateRoute(RequestRoute requestRoute = default(RequestRoute));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestRoute"> (optional)</param>
        /// <returns>ApiResponse of RoutingResponse</returns>
        ApiResponse<RoutingResponse> CalculateRouteWithHttpInfo(RequestRoute requestRoute = default(RequestRoute));
         
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RoutingResponse</returns>
        Task<RoutingResponse> CalculateRouteAsync(RequestRoute requestRoute = default(RequestRoute), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RoutingResponse)</returns>
        Task<ApiResponse<RoutingResponse>> CalculateRouteWithHttpInfoAsync(RequestRoute requestRoute = default(RequestRoute), CancellationToken cancellationToken = default(CancellationToken));

    }

    /// <inheritdoc cref="IRoutingClient">
    public class RoutingClient : IRoutingClient
    {
        private __RoutingClient _internalClient;
        private HttpClient _httpClient;

        public RoutingClient(string host, string? authorization = null)
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri($"{host}/geo-api/v1") };
            var jsonSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(jsonSerializerOptions);
            var events = new RoutingClientEvents();
            if (authorization is null)
            {
                _internalClient = new __RoutingClient(_httpClient, jsonSerializerOptionsProvider, events, new NullTokenProvider<ApiKeyToken>());
            }
            else
            {
                var token = new ApiKeyToken(authorization, "Authorization", "");
                _internalClient = new __RoutingClient(_httpClient, jsonSerializerOptionsProvider, events, new ApiKeyTokenProvider(new[] { token }));
            }
        }

        public RoutingClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <inheritdoc />
        public string GetBasePath() => _httpClient.BaseAddress.ToString();

        /// <inheritdoc />
        public RoutingResponse CalculateRoute(RequestRoute requestRoute = default(RequestRoute))
        {
            try
            {
                var response = _internalClient.CalculateRouteAsync(requestRoute).GetAwaiter().GetResult();
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
        public ApiResponse<RoutingResponse> CalculateRouteWithHttpInfo(RequestRoute requestRoute = default(RequestRoute))
        {
            try
            {
                var response = _internalClient.CalculateRouteAsync(requestRoute).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<RoutingResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <inheritdoc />
        public async Task<RoutingResponse> CalculateRouteAsync(RequestRoute requestRoute = default(RequestRoute), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.CalculateRouteAsync(requestRoute, cancellationToken);
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
        public async Task<ApiResponse<RoutingResponse>> CalculateRouteWithHttpInfoAsync(RequestRoute requestRoute = default(RequestRoute), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.CalculateRouteAsync(requestRoute, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<RoutingResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
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
    internal interface __IRoutingClient : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        RoutingClientEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse"/>&gt;</returns>
        Task<__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse> CalculateRouteAsync(Option<RequestRoute> requestRoute = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse"/>?&gt;</returns>
        Task<__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse?> CalculateRouteOrDefaultAsync(Option<RequestRoute> requestRoute = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoutingClientEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnRoutingCalculateRoutePost;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorRoutingCalculateRoutePost;

        internal void ExecuteOnRoutingCalculateRoutePost(__RoutingClient.RoutingClientRoutingCalculateRoutePostApiResponse apiResponse)
        {
            OnRoutingCalculateRoutePost?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorRoutingCalculateRoutePost(Exception exception)
        {
            OnErrorRoutingCalculateRoutePost?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal sealed partial class __RoutingClient : __IRoutingClient
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public RoutingClientEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __RoutingClient(
            HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            RoutingClientEvents routingClientEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            HttpClient = httpClient;
            Events = routingClientEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatRoutingCalculateRoutePost(Option<RequestRoute> requestRoute);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="requestRoute"></param>
        /// <returns></returns>
        private void ValidateRoutingCalculateRoutePost(Option<RequestRoute> requestRoute)
        {
            if (requestRoute.IsSet && requestRoute.Value == null)
                throw new ArgumentNullException(nameof(requestRoute));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="requestRoute"></param>
        private void AfterRoutingCalculateRoutePostDefaultImplementation(__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse apiResponseLocalVar, Option<RequestRoute> requestRoute)
        {
            bool suppressDefaultLog = false;
            AfterRoutingCalculateRoutePost(ref suppressDefaultLog, apiResponseLocalVar, requestRoute);
            //if (!suppressDefaultLog)
            //    Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="requestRoute"></param>
        partial void AfterRoutingCalculateRoutePost(ref bool suppressDefaultLog, __RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse apiResponseLocalVar, Option<RequestRoute> requestRoute);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="requestRoute"></param>
        private void OnErrorRoutingCalculateRoutePostDefaultImplementation(Exception exception, string pathFormat, string path, Option<RequestRoute> requestRoute)
        {
            bool suppressDefaultLog = false;
            OnErrorRoutingCalculateRoutePost(ref suppressDefaultLog, exception, pathFormat, path, requestRoute);
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
        /// <param name="requestRoute"></param>
        partial void OnErrorRoutingCalculateRoutePost(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, Option<RequestRoute> requestRoute);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse"/>&gt;</returns>
        public async Task<__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse?> CalculateRouteOrDefaultAsync(Option<RequestRoute> requestRoute = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await CalculateRouteAsync(requestRoute, cancellationToken).ConfigureAwait(false);
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
        /// <param name="requestRoute"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse"/>&gt;</returns>
        public async Task<__RoutingClient.IRoutingClientRoutingCalculateRoutePostApiResponse> CalculateRouteAsync(Option<RequestRoute> requestRoute = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateRoutingCalculateRoutePost(requestRoute);

                FormatRoutingCalculateRoutePost(requestRoute);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.PathAndQuery + "/Routing/calculate-route";

                    if (requestRoute.IsSet)
                        httpRequestMessageLocalVar.Content = (requestRoute.Value as object) is System.IO.Stream stream
                            ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                            : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(requestRoute.Value, _jsonSerializerOptions));

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

                        RoutingClientRoutingCalculateRoutePostApiResponse apiResponseLocalVar = new RoutingClientRoutingCalculateRoutePostApiResponse(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/Routing/calculate-route", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterRoutingCalculateRoutePostDefaultImplementation(apiResponseLocalVar, requestRoute);

                        Events.ExecuteOnRoutingCalculateRoutePost(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorRoutingCalculateRoutePostDefaultImplementation(e, "/Routing/calculate-route", uriBuilderLocalVar.Path, requestRoute);
                Events.ExecuteOnErrorRoutingCalculateRoutePost(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="IRoutingClientRoutingCalculateRoutePostApiResponse"/>
        /// </summary>
        internal interface IRoutingClientRoutingCalculateRoutePostApiResponse : Simplic.OxS.SDK.__IApiResponse, IOk<RoutingResponse>, IBadRequest<ProblemDetails>, IUnauthorized<ProblemDetails>
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
        /// The <see cref="RoutingClientRoutingCalculateRoutePostApiResponse"/>
        /// </summary>
        internal partial class RoutingClientRoutingCalculateRoutePostApiResponse : Simplic.OxS.SDK.__ApiResponse, IRoutingClientRoutingCalculateRoutePostApiResponse
        {
            /// <summary>
            /// The <see cref="RoutingClientRoutingCalculateRoutePostApiResponse"/>
            /// </summary>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public RoutingClientRoutingCalculateRoutePostApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public RoutingResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<RoutingResponse>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out RoutingResponse result)
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
