using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eps.v1.Model;

namespace HuaweiCloud.SDK.Eps.v1
{
    public partial class EpsClient : Client
    {
        public static ClientBuilder<EpsClient> NewBuilder()
        {
            return new ClientBuilder<EpsClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建企业项目
        /// </summary>
        public CreateEPResponse CreateEP(CreateEPRequest createEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEPResponse>(response);
        }
        
        /// <summary>
        /// 停用企业项目
        /// </summary>
        public DisableEPResponse DisableEP(DisableEPRequest disableEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , disableEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableEPResponse>(response);
        }
        
        /// <summary>
        /// 启用企业项目
        /// </summary>
        public EnableEPResponse EnableEP(EnableEPRequest enableEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , enableEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableEPResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目列表
        /// </summary>
        public ListEPResponse ListEP(ListEPRequest listEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEPResponse>(response);
        }
        
        /// <summary>
        /// 迁移资源
        /// </summary>
        public MigrateResourceResponse MigrateResource(MigrateResourceRequest migrateResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , migrateResourceRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<MigrateResourceResponse>(response);
        }
        
        /// <summary>
        /// 修改企业项目
        /// </summary>
        public ModifyEPResponse ModifyEP(ModifyEPRequest modifyEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , modifyEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", modifyEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<ModifyEPResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本号详情
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目详情
        /// </summary>
        public ShowEPResponse ShowEP(ShowEPRequest showEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEPResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目配额
        /// </summary>
        public ShowEPQuotaResponse ShowEPQuota(ShowEPQuotaRequest showEPQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showEPQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEPQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目绑定的资源列表
        /// </summary>
        public ShowResourceBindEPResponse ShowResourceBindEP(ShowResourceBindEPRequest showResourceBindEPRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showResourceBindEPRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEPRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowResourceBindEPResponse>(response);
        }
        
    }
}