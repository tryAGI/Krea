
#nullable enable

namespace Krea
{
    public partial class EnhanceClient
    {


        private static readonly global::Krea.EndPointSecurityRequirement s_EnhanceTopazStandardSecurityRequirement0 =
            new global::Krea.EndPointSecurityRequirement
            {
                Authorizations = new global::Krea.EndPointAuthorizationRequirement[]
                {                    new global::Krea.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Krea.EndPointSecurityRequirement[] s_EnhanceTopazStandardSecurityRequirements =
            new global::Krea.EndPointSecurityRequirement[]
            {                s_EnhanceTopazStandardSecurityRequirement0,
            };
        partial void PrepareEnhanceTopazStandardArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Krea.TopazEnhanceRequest request);
        partial void PrepareEnhanceTopazStandardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Krea.TopazEnhanceRequest request);
        partial void ProcessEnhanceTopazStandardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEnhanceTopazStandardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Krea.Job> EnhanceTopazStandardAsync(

            global::Krea.TopazEnhanceRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EnhanceTopazStandardAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Job>> EnhanceTopazStandardAsResponseAsync(

            global::Krea.TopazEnhanceRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEnhanceTopazStandardArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Krea.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EnhanceTopazStandardSecurityRequirements,
                operationName: "EnhanceTopazStandardAsync");

            using var __timeoutCancellationTokenSource = global::Krea.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Krea.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Krea.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Krea.PathBuilder(
                                path: "/generate/enhance/topaz/standard-enhance",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Krea.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Krea.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEnhanceTopazStandardRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Krea.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Krea.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EnhanceTopazStandard",
                                methodName: "EnhanceTopazStandardAsync",
                                pathTemplate: "\"/generate/enhance/topaz/standard-enhance\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Krea.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Krea.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Krea.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EnhanceTopazStandard",
                                methodName: "EnhanceTopazStandardAsync",
                                pathTemplate: "\"/generate/enhance/topaz/standard-enhance\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Krea.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Krea.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Krea.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Krea.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Krea.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EnhanceTopazStandard",
                                methodName: "EnhanceTopazStandardAsync",
                                pathTemplate: "\"/generate/enhance/topaz/standard-enhance\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Krea.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessEnhanceTopazStandardResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Krea.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Krea.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EnhanceTopazStandard",
                                methodName: "EnhanceTopazStandardAsync",
                                pathTemplate: "\"/generate/enhance/topaz/standard-enhance\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Krea.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Krea.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EnhanceTopazStandard",
                                methodName: "EnhanceTopazStandardAsync",
                                pathTemplate: "\"/generate/enhance/topaz/standard-enhance\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessEnhanceTopazStandardResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Krea.Job.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Krea.AutoSDKHttpResponse<global::Krea.Job>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Krea.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Krea.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Krea.Job.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Krea.AutoSDKHttpResponse<global::Krea.Job>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Krea.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Krea.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Enhance image with Topaz (standard)
        /// </summary>
        /// <param name="batchSize">
        /// Default Value: 1
        /// </param>
        /// <param name="width">
        /// Output width in pixels. Range 1-32000.
        /// </param>
        /// <param name="height">
        /// Output height in pixels. Range 1-32000.
        /// </param>
        /// <param name="seed">
        /// Default Value: 1337
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="outputFormat">
        /// Default Value: jpg
        /// </param>
        /// <param name="subjectDetection">
        /// Default Value: All
        /// </param>
        /// <param name="faceEnhancement">
        /// Default Value: false
        /// </param>
        /// <param name="faceEnhancementCreativity">
        /// Default Value: 0.5
        /// </param>
        /// <param name="faceEnhancementStrength">
        /// Default Value: 0.5
        /// </param>
        /// <param name="cropToFill">
        /// Default Value: false
        /// </param>
        /// <param name="imageUrl">
        /// Source image to enhance.
        /// </param>
        /// <param name="model">
        /// Topaz model variant.
        /// </param>
        /// <param name="upscalingActivated">
        /// Default Value: false
        /// </param>
        /// <param name="imageScalingFactor">
        /// Range 1-32.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="sharpen">
        /// Default Value: 0.5
        /// </param>
        /// <param name="denoise">
        /// Default Value: 0.5
        /// </param>
        /// <param name="fixCompression">
        /// Default Value: 0.5
        /// </param>
        /// <param name="strength">
        /// Default Value: 0.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Krea.Job> EnhanceTopazStandardAsync(
            double width,
            double height,
            string imageUrl,
            global::Krea.TopazEnhanceRequestModel model,
            double? batchSize = default,
            double? seed = default,
            string? prompt = default,
            global::Krea.TopazEnhanceRequestOutputFormat? outputFormat = default,
            global::Krea.TopazEnhanceRequestSubjectDetection? subjectDetection = default,
            bool? faceEnhancement = default,
            double? faceEnhancementCreativity = default,
            double? faceEnhancementStrength = default,
            bool? cropToFill = default,
            bool? upscalingActivated = default,
            double? imageScalingFactor = default,
            double? sharpen = default,
            double? denoise = default,
            double? fixCompression = default,
            double? strength = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Krea.TopazEnhanceRequest
            {
                BatchSize = batchSize,
                Width = width,
                Height = height,
                Seed = seed,
                Prompt = prompt,
                OutputFormat = outputFormat,
                SubjectDetection = subjectDetection,
                FaceEnhancement = faceEnhancement,
                FaceEnhancementCreativity = faceEnhancementCreativity,
                FaceEnhancementStrength = faceEnhancementStrength,
                CropToFill = cropToFill,
                ImageUrl = imageUrl,
                Model = model,
                UpscalingActivated = upscalingActivated,
                ImageScalingFactor = imageScalingFactor,
                Sharpen = sharpen,
                Denoise = denoise,
                FixCompression = fixCompression,
                Strength = strength,
            };

            return await EnhanceTopazStandardAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}