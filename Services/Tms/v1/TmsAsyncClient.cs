using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Tms.v1.Model;

namespace HuaweiCloud.SDK.Tms.v1
{
    public partial class TmsAsyncClient : Client
    {
        public static ClientBuilder<TmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<TmsAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建预定义标签
        /// </summary>
        public async Task<CreatePredefineTagsResponse> CreatePredefineTagsAsync(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除预定义标签
        /// </summary>
        public async Task<DeletePredefineTagsResponse> DeletePredefineTagsAsync(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listApiVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询预定义标签列表
        /// </summary>
        public async Task<ListPredefineTagsResponse> ListPredefineTagsAsync(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPredefineTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPredefineTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本号详情
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 修改预定义标签
        /// </summary>
        public async Task<UpdatePredefineTagsResponse> UpdatePredefineTagsAsync(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>(response);
        }
        
    }
}