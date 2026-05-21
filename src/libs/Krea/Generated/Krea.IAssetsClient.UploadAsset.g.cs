#nullable enable

namespace Krea
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Upload an asset<br/>
        /// Uploads a binary file (image, video, audio, or 3D model) to the account. Returns an<br/>
        /// `Asset` whose `image_url` can be referenced in generation requests. Accepts JPEG, PNG,<br/>
        /// WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3 up to 75 MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Asset> UploadAssetAsync(

            global::Krea.AssetUploadRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an asset<br/>
        /// Uploads a binary file (image, video, audio, or 3D model) to the account. Returns an<br/>
        /// `Asset` whose `image_url` can be referenced in generation requests. Accepts JPEG, PNG,<br/>
        /// WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3 up to 75 MB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Asset>> UploadAssetAsResponseAsync(

            global::Krea.AssetUploadRequest request,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an asset<br/>
        /// Uploads a binary file (image, video, audio, or 3D model) to the account. Returns an<br/>
        /// `Asset` whose `image_url` can be referenced in generation requests. Accepts JPEG, PNG,<br/>
        /// WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3 up to 75 MB.
        /// </summary>
        /// <param name="file">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="filename">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="description">
        /// Optional description to store with the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Asset> UploadAssetAsync(
            byte[] file,
            string filename,
            string? description = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload an asset<br/>
        /// Uploads a binary file (image, video, audio, or 3D model) to the account. Returns an<br/>
        /// `Asset` whose `image_url` can be referenced in generation requests. Accepts JPEG, PNG,<br/>
        /// WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3 up to 75 MB.
        /// </summary>
        /// <param name="file">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="filename">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="description">
        /// Optional description to store with the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.Asset> UploadAssetAsync(
            global::System.IO.Stream file,
            string filename,
            string? description = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an asset<br/>
        /// Uploads a binary file (image, video, audio, or 3D model) to the account. Returns an<br/>
        /// `Asset` whose `image_url` can be referenced in generation requests. Accepts JPEG, PNG,<br/>
        /// WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3 up to 75 MB.
        /// </summary>
        /// <param name="file">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="filename">
        /// Binary file contents. Allowed: JPEG, PNG, WebP, HEIC, MP4, MOV, WebM, GLB, WAV, MP3. Max 75 MB.
        /// </param>
        /// <param name="description">
        /// Optional description to store with the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Krea.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Krea.AutoSDKHttpResponse<global::Krea.Asset>> UploadAssetAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? description = default,
            global::Krea.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}