using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cce.V5.Model;

namespace HuaweiCloud.SDK.Cce.V5
{
    public partial class CceClient : Client
    {
        public static ClientBuilder<CceClient> NewBuilder()
        {
            return new ClientBuilder<CceClient>();
        }

        
        /// <summary>
        /// 创建镜像缓存
        ///
        /// 创建镜像缓存。创建过程会在指定集群中启动临时Pod进行镜像缓存构建，创建镜像缓存后，可在负载创建时通过使用镜像缓存功能大幅减少下载容器镜像的耗时，实现容器的快速启动。单租户创建镜像缓存数量上限为50。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageCacheResponse CreateImageCache(CreateImageCacheRequest createImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageCacheRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateImageCacheResponse>(response);
        }

        public SyncInvoker<CreateImageCacheResponse> CreateImageCacheInvoker(CreateImageCacheRequest createImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageCacheRequest);
            return new SyncInvoker<CreateImageCacheResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageCacheResponse>);
        }
        
        /// <summary>
        /// 删除镜像缓存
        ///
        /// 删除镜像缓存
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteImageCacheResponse DeleteImageCache(DeleteImageCacheRequest deleteImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_cache_id", deleteImageCacheRequest.ImageCacheId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageCacheRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteImageCacheResponse>(response);
        }

        public SyncInvoker<DeleteImageCacheResponse> DeleteImageCacheInvoker(DeleteImageCacheRequest deleteImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_cache_id", deleteImageCacheRequest.ImageCacheId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageCacheRequest);
            return new SyncInvoker<DeleteImageCacheResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteImageCacheResponse>);
        }
        
        /// <summary>
        /// 查询镜像缓存列表
        ///
        /// 查询镜像缓存列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageCachesResponse ListImageCaches(ListImageCachesRequest listImageCachesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageCachesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImageCachesResponse>(response);
        }

        public SyncInvoker<ListImageCachesResponse> ListImageCachesInvoker(ListImageCachesRequest listImageCachesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageCachesRequest);
            return new SyncInvoker<ListImageCachesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageCachesResponse>);
        }
        
        /// <summary>
        /// 查询镜像缓存详情
        ///
        /// 查询镜像缓存详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageCacheResponse ShowImageCache(ShowImageCacheRequest showImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_cache_id", showImageCacheRequest.ImageCacheId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageCacheRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowImageCacheResponse>(response);
        }

        public SyncInvoker<ShowImageCacheResponse> ShowImageCacheInvoker(ShowImageCacheRequest showImageCacheRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("image_cache_id", showImageCacheRequest.ImageCacheId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/imagecaches/{image_cache_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageCacheRequest);
            return new SyncInvoker<ShowImageCacheResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageCacheResponse>);
        }
        
    }
}