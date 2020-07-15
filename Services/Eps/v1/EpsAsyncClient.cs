using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eps.v1.Model;

namespace HuaweiCloud.SDK.Eps.v1
{
    public partial class EpsAsyncClient : Client
    {
        public static ClientBuilder<EpsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EpsAsyncClient>();
        }

        
        /// <summary>
        /// 创建企业项目
        /// </summary>
        public async Task<CreateEPResponse> CreateEPAsync(CreateEPRequest createEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEPRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEPResponse>(response);
        }
        
        /// <summary>
        /// 停用企业项目
        /// </summary>
        public async Task<DisableEPResponse> DisableEPAsync(DisableEPRequest disableEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , disableEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEPRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DisableEPResponse>(response);
        }
        
        /// <summary>
        /// 启用企业项目
        /// </summary>
        public async Task<EnableEPResponse> EnableEPAsync(EnableEPRequest enableEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , enableEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEPRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableEPResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listApiVersionsRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目列表
        /// </summary>
        public async Task<ListEPResponse> ListEPAsync(ListEPRequest listEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listEPRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEPResponse>(response);
        }
        
        /// <summary>
        /// 迁移资源
        /// </summary>
        public async Task<MigrateResourceResponse> MigrateResourceAsync(MigrateResourceRequest migrateResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , migrateResourceRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<MigrateResourceResponse>(response);
        }
        
        /// <summary>
        /// 修改企业项目
        /// </summary>
        public async Task<ModifyEPResponse> ModifyEPAsync(ModifyEPRequest modifyEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , modifyEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEPRequest);
            SdkResponse response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<ModifyEPResponse>(response);
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
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目详情
        /// </summary>
        public async Task<ShowEPResponse> ShowEPAsync(ShowEPRequest showEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEPRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEPResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目配额
        /// </summary>
        public async Task<ShowEPQuotaResponse> ShowEPQuotaAsync(ShowEPQuotaRequest showEPQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEPQuotaRequest);
            SdkResponse response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEPQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目绑定的资源列表
        /// </summary>
        public async Task<ShowResourceBindEPResponse> ShowResourceBindEPAsync(ShowResourceBindEPRequest showResourceBindEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showResourceBindEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEPRequest);
            SdkResponse response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowResourceBindEPResponse>(response);
        }
        
    }
}