using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cc.V2.Model;

namespace HuaweiCloud.SDK.Cc.V2
{
    public partial class CcAsyncClient : Client
    {
        public static ClientBuilder<CcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CcAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 批量创建和删除资源标签
        ///
        /// 批量创建和删除标签。此API为历史API，请优先使用《 创建云连接实例标签》、《 创建带宽包标签》、《 删除云连接实例标签》、《 删除带宽包标签》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateDeleteTagsResponse> BatchCreateDeleteTagsAsync(BatchCreateDeleteTagsRequest batchCreateDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeleteTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchCreateDeleteTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateDeleteTagsResponse> BatchCreateDeleteTagsAsyncInvoker(BatchCreateDeleteTagsRequest batchCreateDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateDeleteTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchCreateDeleteTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateDeleteTagsRequest);
            return new AsyncInvoker<BatchCreateDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 添加资源标签
        ///
        /// 添加资源标签。此API为历史API，请优先使用《 创建云连接实例标签》、《 创建带宽包标签》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createTagRequest.ResourceId.ToString());
            urlParam.Add("resource_type", createTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签。此API为历史API，请优先使用《 删除云连接实例标签》或《 删除带宽包标签》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteTagRequest.TagKey.ToString());
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteTagRequest.TagKey.ToString());
            urlParam.Add("resource_type", deleteTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 查询账户资源标签
        ///
        /// 查询账户资源标签。此API为历史API，请优先使用《查询云连接实例的标签信息》、《查询带宽包的标签信息》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainTagsResponse> ListDomainTagsAsync(ListDomainTagsRequest listDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listDomainTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainTagsResponse>(response);
        }

        public AsyncInvoker<ListDomainTagsResponse> ListDomainTagsAsyncInvoker(ListDomainTagsRequest listDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listDomainTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTagsRequest);
            return new AsyncInvoker<ListDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 查询资源实例。此API为历史API，请优先使用《通过标签过滤云连接实例》、《通过标签过滤带宽包实例》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceByFilterTagResponse> ListResourceByFilterTagAsync(ListResourceByFilterTagRequest listResourceByFilterTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceByFilterTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceByFilterTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceByFilterTagResponse>(response);
        }

        public AsyncInvoker<ListResourceByFilterTagResponse> ListResourceByFilterTagAsyncInvoker(ListResourceByFilterTagRequest listResourceByFilterTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceByFilterTagRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/resource-instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceByFilterTagRequest);
            return new AsyncInvoker<ListResourceByFilterTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceByFilterTagResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签。此API为历史API，请优先使用《查询云连接实例的标签信息》、《查询带宽包的标签信息》。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
    }
}