using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Eps.V1.Model;

namespace HuaweiCloud.SDK.Eps.V1
{
    public partial class EpsAsyncClient : Client
    {
        public static ClientBuilder<EpsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EpsAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建企业项目
        ///
        /// 创建企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEnterpriseProjectResponse> CreateEnterpriseProjectAsync(CreateEnterpriseProjectRequest createEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<CreateEnterpriseProjectResponse> CreateEnterpriseProjectAsyncInvoker(CreateEnterpriseProjectRequest createEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEnterpriseProjectRequest);
            return new AsyncInvoker<CreateEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 删除企业项目
        ///
        /// 删除企业项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEnterpriseProjectResponse> DeleteEnterpriseProjectAsync(DeleteEnterpriseProjectRequest deleteEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", deleteEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<DeleteEnterpriseProjectResponse> DeleteEnterpriseProjectAsyncInvoker(DeleteEnterpriseProjectRequest deleteEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", deleteEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnterpriseProjectRequest);
            return new AsyncInvoker<DeleteEnterpriseProjectResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 停用企业项目
        ///
        /// 停用企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableEnterpriseProjectResponse> DisableEnterpriseProjectAsync(DisableEnterpriseProjectRequest disableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", disableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<DisableEnterpriseProjectResponse> DisableEnterpriseProjectAsyncInvoker(DisableEnterpriseProjectRequest disableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", disableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disableEnterpriseProjectRequest);
            return new AsyncInvoker<DisableEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 启用企业项目
        ///
        /// 启用企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableEnterpriseProjectResponse> EnableEnterpriseProjectAsync(EnableEnterpriseProjectRequest enableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", enableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<EnableEnterpriseProjectResponse> EnableEnterpriseProjectAsyncInvoker(EnableEnterpriseProjectRequest enableEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", enableEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", enableEnterpriseProjectRequest);
            return new AsyncInvoker<EnableEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询企业项目的API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询企业项目列表
        ///
        /// 查询当前用户已授权的企业项目列表，用户可以使用企业项目绑定资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEnterpriseProjectResponse> ListEnterpriseProjectAsync(ListEnterpriseProjectRequest listEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ListEnterpriseProjectResponse> ListEnterpriseProjectAsyncInvoker(ListEnterpriseProjectRequest listEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEnterpriseProjectRequest);
            return new AsyncInvoker<ListEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询资源迁移记录
        ///
        /// 查询资源迁移记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMigrationRecordResponse> ListMigrationRecordAsync(ListMigrationRecordRequest listMigrationRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/migrate-record/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMigrationRecordResponse>(response);
        }

        public AsyncInvoker<ListMigrationRecordResponse> ListMigrationRecordAsyncInvoker(ListMigrationRecordRequest listMigrationRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/migrate-record/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMigrationRecordRequest);
            return new AsyncInvoker<ListMigrationRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMigrationRecordResponse>);
        }
        
        /// <summary>
        /// 查询企业项目支持的服务
        ///
        /// 查询企业项目支持的服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProvidersResponse> ListProvidersAsync(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public AsyncInvoker<ListProvidersResponse> ListProvidersAsyncInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new AsyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 查询资源类型映射
        ///
        /// 查询资源类型映射
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceMappingResponse> ListResourceMappingAsync(ListResourceMappingRequest listResourceMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/resources-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceMappingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceMappingResponse>(response);
        }

        public AsyncInvoker<ListResourceMappingResponse> ListResourceMappingAsyncInvoker(ListResourceMappingRequest listResourceMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/resources-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceMappingRequest);
            return new AsyncInvoker<ListResourceMappingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceMappingResponse>);
        }
        
        /// <summary>
        /// 迁移资源
        ///
        /// 迁移资源到目标企业项目。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<MigrateResourceResponse> MigrateResourceAsync(MigrateResourceRequest migrateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", migrateResourceRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<MigrateResourceResponse>(response);
        }

        public AsyncInvoker<MigrateResourceResponse> MigrateResourceAsyncInvoker(MigrateResourceRequest migrateResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", migrateResourceRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateResourceRequest);
            return new AsyncInvoker<MigrateResourceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<MigrateResourceResponse>);
        }
        
        /// <summary>
        /// 查询API版本号详情
        ///
        /// 查询指定的企业项目API版本号详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询关联资源
        ///
        /// 查询关联资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssociatedResourcesResponse> ShowAssociatedResourcesAsync(ShowAssociatedResourcesRequest showAssociatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showAssociatedResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/associated-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociatedResourcesResponse>(response);
        }

        public AsyncInvoker<ShowAssociatedResourcesResponse> ShowAssociatedResourcesAsyncInvoker(ShowAssociatedResourcesRequest showAssociatedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showAssociatedResourcesRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/associated-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourcesRequest);
            return new AsyncInvoker<ShowAssociatedResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociatedResourcesResponse>);
        }
        
        /// <summary>
        /// 查询企业项目详情
        ///
        /// 查询企业项目详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnterpriseProjectResponse> ShowEnterpriseProjectAsync(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ShowEnterpriseProjectResponse> ShowEnterpriseProjectAsyncInvoker(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            return new AsyncInvoker<ShowEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询企业项目配额
        ///
        /// 查询企业项目的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnterpriseProjectQuotaResponse> ShowEnterpriseProjectQuotaAsync(ShowEnterpriseProjectQuotaRequest showEnterpriseProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectQuotaResponse>(response);
        }

        public AsyncInvoker<ShowEnterpriseProjectQuotaResponse> ShowEnterpriseProjectQuotaAsyncInvoker(ShowEnterpriseProjectQuotaRequest showEnterpriseProjectQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectQuotaRequest);
            return new AsyncInvoker<ShowEnterpriseProjectQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectQuotaResponse>);
        }
        
        /// <summary>
        /// 查询服务配置
        ///
        /// 查询服务配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEpConfigsResponse> ShowEpConfigsAsync(ShowEpConfigsRequest showEpConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enterprise-projects/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEpConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEpConfigsResponse>(response);
        }

        public AsyncInvoker<ShowEpConfigsResponse> ShowEpConfigsAsyncInvoker(ShowEpConfigsRequest showEpConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/enterprise-projects/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEpConfigsRequest);
            return new AsyncInvoker<ShowEpConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEpConfigsResponse>);
        }
        
        /// <summary>
        /// 查询企业项目绑定的资源列表
        ///
        /// 查询企业项目下绑定的资源详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceBindEnterpriseProjectResponse> ShowResourceBindEnterpriseProjectAsync(ShowResourceBindEnterpriseProjectRequest showResourceBindEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showResourceBindEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowResourceBindEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ShowResourceBindEnterpriseProjectResponse> ShowResourceBindEnterpriseProjectAsyncInvoker(ShowResourceBindEnterpriseProjectRequest showResourceBindEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", showResourceBindEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}/resources/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showResourceBindEnterpriseProjectRequest);
            return new AsyncInvoker<ShowResourceBindEnterpriseProjectResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResourceBindEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 修改企业项目
        ///
        /// 修改企业项目。当前仅支持修改名称和描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEnterpriseProjectResponse> UpdateEnterpriseProjectAsync(UpdateEnterpriseProjectRequest updateEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", updateEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<UpdateEnterpriseProjectResponse> UpdateEnterpriseProjectAsyncInvoker(UpdateEnterpriseProjectRequest updateEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("enterprise_project_id", updateEnterpriseProjectRequest.EnterpriseProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/enterprise-projects/{enterprise_project_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEnterpriseProjectRequest);
            return new AsyncInvoker<UpdateEnterpriseProjectResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEnterpriseProjectResponse>);
        }
        
    }
}