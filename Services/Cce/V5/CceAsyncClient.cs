using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cce.V5.Model;

namespace HuaweiCloud.SDK.Cce.V5
{
    public partial class CceAsyncClient : Client
    {
        public static ClientBuilder<CceAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CceAsyncClient>().WithExceptionHandler(new CceExceptionHandler());
        }

        
        /// <summary>
        /// 创建镜像缓存
        ///
        /// 创建镜像缓存。创建过程会在指定集群中启动临时Pod进行镜像缓存构建，创建镜像缓存后，可在负载创建时通过使用镜像缓存功能大幅减少下载容器镜像的耗时，实现容器的快速启动。单租户创建镜像缓存数量上限为50。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImageCacheResponse> CreateImageCacheAsync(CreateImageCacheRequest createImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageCacheRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateImageCacheResponse>(response);
        }

        public AsyncInvoker<CreateImageCacheResponse> CreateImageCacheAsyncInvoker(CreateImageCacheRequest createImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageCacheRequest);
            return new AsyncInvoker<CreateImageCacheResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageCacheResponse>);
        }
        
        /// <summary>
        /// 删除镜像缓存
        ///
        /// 删除镜像缓存
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImageCacheResponse> DeleteImageCacheAsync(DeleteImageCacheRequest deleteImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageCacheRequest.ImageCacheId, out var valueOfImageCacheId)) urlParam.Add("image_cache_id", valueOfImageCacheId);
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageCacheRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteImageCacheResponse>(response);
        }

        public AsyncInvoker<DeleteImageCacheResponse> DeleteImageCacheAsyncInvoker(DeleteImageCacheRequest deleteImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageCacheRequest.ImageCacheId, out var valueOfImageCacheId)) urlParam.Add("image_cache_id", valueOfImageCacheId);
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageCacheRequest);
            return new AsyncInvoker<DeleteImageCacheResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteImageCacheResponse>);
        }
        
        /// <summary>
        /// 查询镜像缓存列表
        ///
        /// 查询镜像缓存列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageCachesResponse> ListImageCachesAsync(ListImageCachesRequest listImageCachesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageCachesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageCachesResponse>(response);
        }

        public AsyncInvoker<ListImageCachesResponse> ListImageCachesAsyncInvoker(ListImageCachesRequest listImageCachesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageCachesRequest);
            return new AsyncInvoker<ListImageCachesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageCachesResponse>);
        }
        
        /// <summary>
        /// 查询套餐包列表
        ///
        /// 查询套餐包列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPackageProductsResponse> ListPackageProductsAsync(ListPackageProductsRequest listPackageProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/package-products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPackageProductsResponse>(response);
        }

        public AsyncInvoker<ListPackageProductsResponse> ListPackageProductsAsyncInvoker(ListPackageProductsRequest listPackageProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/package-products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPackageProductsRequest);
            return new AsyncInvoker<ListPackageProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPackageProductsResponse>);
        }
        
        /// <summary>
        /// 查询镜像缓存详情
        ///
        /// 查询镜像缓存详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageCacheResponse> ShowImageCacheAsync(ShowImageCacheRequest showImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageCacheRequest.ImageCacheId, out var valueOfImageCacheId)) urlParam.Add("image_cache_id", valueOfImageCacheId);
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageCacheRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageCacheResponse>(response);
        }

        public AsyncInvoker<ShowImageCacheResponse> ShowImageCacheAsyncInvoker(ShowImageCacheRequest showImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageCacheRequest.ImageCacheId, out var valueOfImageCacheId)) urlParam.Add("image_cache_id", valueOfImageCacheId);
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageCacheRequest);
            return new AsyncInvoker<ShowImageCacheResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageCacheResponse>);
        }
        
        /// <summary>
        /// 订购套餐包
        ///
        /// 订购套餐包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SubscribePackageProductsResponse> SubscribePackageProductsAsync(SubscribePackageProductsRequest subscribePackageProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/package-products/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", subscribePackageProductsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SubscribePackageProductsResponse>(response);
        }

        public AsyncInvoker<SubscribePackageProductsResponse> SubscribePackageProductsAsyncInvoker(SubscribePackageProductsRequest subscribePackageProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/package-products/subscribe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", subscribePackageProductsRequest);
            return new AsyncInvoker<SubscribePackageProductsResponse>(this, "POST", request, JsonUtils.DeSerialize<SubscribePackageProductsResponse>);
        }
        
    }
}