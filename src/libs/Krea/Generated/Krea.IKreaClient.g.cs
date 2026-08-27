
#nullable enable

namespace Krea
{
    /// <summary>
    /// Krea AI provides unified access to 40+ state-of-the-art generative AI models for<br/>
    /// image, video, 3D, and image-enhancement through a single REST API. All generation<br/>
    /// endpoints are asynchronous: they return a job object immediately; poll the `/jobs/{id}`<br/>
    /// endpoint (or supply an `X-Webhook-URL` header) to retrieve the result.<br/>
    /// Authentication: Bearer token. Generate keys in the Krea dashboard.<br/>
    /// Base URL: https://api.krea.ai<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IKreaClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Krea.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Krea.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AssetsClient Assets { get; }

        /// <summary>
        ///
        /// </summary>
        public EnhanceClient Enhance { get; }

        /// <summary>
        ///
        /// </summary>
        public ImageClient Image { get; }

        /// <summary>
        ///
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        ///
        /// </summary>
        public NodeAppsClient NodeApps { get; }

        /// <summary>
        ///
        /// </summary>
        public StylesClient Styles { get; }

        /// <summary>
        ///
        /// </summary>
        public VideoClient Video { get; }

    }
}