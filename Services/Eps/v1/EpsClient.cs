using System;
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
        ///
        /// 创建企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEnterpriseProjectResponse CreateEnterpriseProject(CreateEnterpriseProjectRequest createEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 停用企业项目
        ///
        /// 停用企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableEnterpriseProjectResponse DisableEnterpriseProject(DisableEnterpriseProjectRequest disableEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , disableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 启用企业项目
        ///
        /// 启用企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableEnterpriseProjectResponse EnableEnterpriseProject(EnableEnterpriseProjectRequest enableEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , enableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询企业项目的API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目列表
        ///
        /// 查询当前用户已授权的企业项目列表，用户可以使用企业项目绑定资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEnterpriseProjectResponse ListEnterpriseProject(ListEnterpriseProjectRequest listEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目支持的服务
        ///
        /// 查询企业项目支持的服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvidersResponse ListProviders(ListProvidersRequest listProvidersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/providers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }
        
        /// <summary>
        /// 迁移资源
        ///
        /// 迁移资源到目标企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询API版本号详情
        ///
        /// 查询指定的企业项目API版本号详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目详情
        ///
        /// 查询企业项目详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnterpriseProjectResponse ShowEnterpriseProject(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目配额
        ///
        /// 查询企业项目的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnterpriseProjectQuotaResponse ShowEnterpriseProjectQuota(ShowEnterpriseProjectQuotaRequest showEnterpriseProjectQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目绑定的资源列表
        ///
        /// 查询企业项目下绑定的资源详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceBindEnterpriseProjectResponse ShowResourceBindEnterpriseProject(ShowResourceBindEnterpriseProjectRequest showResourceBindEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , showResourceBindEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowResourceBindEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 修改企业项目
        ///
        /// 修改企业项目。当前仅支持修改名称和描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEnterpriseProjectResponse UpdateEnterpriseProject(UpdateEnterpriseProjectRequest updateEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id" , updateEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEnterpriseProjectResponse>(response);
        }
        
    }
}