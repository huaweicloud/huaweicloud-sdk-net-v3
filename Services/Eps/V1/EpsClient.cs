using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eps.V1.Model;

namespace HuaweiCloud.SDK.Eps.V1
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEnterpriseProjectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<CreateEnterpriseProjectResponse> CreateEnterpriseProjectInvoker(CreateEnterpriseProjectRequest createEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEnterpriseProjectRequest);
            return new SyncInvoker<CreateEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 删除企业项目
        ///
        /// 删除企业项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEnterpriseProjectResponse DeleteEnterpriseProject(DeleteEnterpriseProjectRequest deleteEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", deleteEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnterpriseProjectRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<DeleteEnterpriseProjectResponse> DeleteEnterpriseProjectInvoker(DeleteEnterpriseProjectRequest deleteEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", deleteEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnterpriseProjectRequest);
            return new SyncInvoker<DeleteEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", disableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEnterpriseProjectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<DisableEnterpriseProjectResponse> DisableEnterpriseProjectInvoker(DisableEnterpriseProjectRequest disableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", disableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEnterpriseProjectRequest);
            return new SyncInvoker<DisableEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", enableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEnterpriseProjectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<EnableEnterpriseProjectResponse> EnableEnterpriseProjectInvoker(EnableEnterpriseProjectRequest enableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", enableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEnterpriseProjectRequest);
            return new SyncInvoker<EnableEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ListEnterpriseProjectResponse> ListEnterpriseProjectInvoker(ListEnterpriseProjectRequest listEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectRequest);
            return new SyncInvoker<ListEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询资源迁移记录
        ///
        /// 查询资源迁移记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMigrationRecordResponse ListMigrationRecord(ListMigrationRecordRequest listMigrationRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/migrate-record/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationRecordResponse>(response);
        }

        public SyncInvoker<ListMigrationRecordResponse> ListMigrationRecordInvoker(ListMigrationRecordRequest listMigrationRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/migrate-record/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationRecordRequest);
            return new SyncInvoker<ListMigrationRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationRecordResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public SyncInvoker<ListProvidersResponse> ListProvidersInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new SyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 查询资源类型映射
        ///
        /// 查询资源类型映射
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceMappingResponse ListResourceMapping(ListResourceMappingRequest listResourceMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/resources-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceMappingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceMappingResponse>(response);
        }

        public SyncInvoker<ListResourceMappingResponse> ListResourceMappingInvoker(ListResourceMappingRequest listResourceMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/resources-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceMappingRequest);
            return new SyncInvoker<ListResourceMappingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceMappingResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", migrateResourceRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<MigrateResourceResponse>(response);
        }

        public SyncInvoker<MigrateResourceResponse> MigrateResourceInvoker(MigrateResourceRequest migrateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", migrateResourceRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            return new SyncInvoker<MigrateResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<MigrateResourceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询关联资源
        ///
        /// 查询关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssociatedResourcesResponse ShowAssociatedResources(ShowAssociatedResourcesRequest showAssociatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showAssociatedResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/associated-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociatedResourcesResponse>(response);
        }

        public SyncInvoker<ShowAssociatedResourcesResponse> ShowAssociatedResourcesInvoker(ShowAssociatedResourcesRequest showAssociatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showAssociatedResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/associated-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourcesRequest);
            return new SyncInvoker<ShowAssociatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociatedResourcesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ShowEnterpriseProjectResponse> ShowEnterpriseProjectInvoker(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            return new SyncInvoker<ShowEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectQuotaResponse>(response);
        }

        public SyncInvoker<ShowEnterpriseProjectQuotaResponse> ShowEnterpriseProjectQuotaInvoker(ShowEnterpriseProjectQuotaRequest showEnterpriseProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectQuotaRequest);
            return new SyncInvoker<ShowEnterpriseProjectQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectQuotaResponse>);
        }
        
        /// <summary>
        /// 查询服务配置
        ///
        /// 查询服务配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEpConfigsResponse ShowEpConfigs(ShowEpConfigsRequest showEpConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enterprise-projects/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEpConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEpConfigsResponse>(response);
        }

        public SyncInvoker<ShowEpConfigsResponse> ShowEpConfigsInvoker(ShowEpConfigsRequest showEpConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enterprise-projects/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEpConfigsRequest);
            return new SyncInvoker<ShowEpConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEpConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showResourceBindEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEnterpriseProjectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowResourceBindEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ShowResourceBindEnterpriseProjectResponse> ShowResourceBindEnterpriseProjectInvoker(ShowResourceBindEnterpriseProjectRequest showResourceBindEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showResourceBindEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEnterpriseProjectRequest);
            return new SyncInvoker<ShowResourceBindEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResourceBindEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", updateEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEnterpriseProjectRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<UpdateEnterpriseProjectResponse> UpdateEnterpriseProjectInvoker(UpdateEnterpriseProjectRequest updateEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", updateEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEnterpriseProjectRequest);
            return new SyncInvoker<UpdateEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnterpriseProjectResponse>);
        }
        
    }
}