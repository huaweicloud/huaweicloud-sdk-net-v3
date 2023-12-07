using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V3.Model;

namespace HuaweiCloud.SDK.Aom.V3
{
    public partial class AomAsyncClient : Client
    {
        public static ClientBuilder<AomAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AomAsyncClient>();
        }

        
        /// <summary>
        /// 新增应用
        ///
        /// 新增应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAppResponse>(response);
        }

        public AsyncInvoker<CreateAppResponse> CreateAppAsyncInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new AsyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAppResponse>);
        }
        
        /// <summary>
        /// 新增组件
        ///
        /// 新增组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest createComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createComponentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateComponentResponse>(response);
        }

        public AsyncInvoker<CreateComponentResponse> CreateComponentAsyncInvoker(CreateComponentRequest createComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createComponentRequest);
            return new AsyncInvoker<CreateComponentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateComponentResponse>);
        }
        
        /// <summary>
        /// 创建环境
        ///
        /// 创建环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEnvResponse> CreateEnvAsync(CreateEnvRequest createEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEnvResponse>(response);
        }

        public AsyncInvoker<CreateEnvResponse> CreateEnvAsyncInvoker(CreateEnvRequest createEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvRequest);
            return new AsyncInvoker<CreateEnvResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnvResponse>);
        }
        
        /// <summary>
        /// 新增子应用
        ///
        /// 新增子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubAppResponse> CreateSubAppAsync(CreateSubAppRequest createSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubAppResponse>(response);
        }

        public AsyncInvoker<CreateSubAppResponse> CreateSubAppAsyncInvoker(CreateSubAppRequest createSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubAppRequest);
            return new AsyncInvoker<CreateSubAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubAppResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public AsyncInvoker<DeleteAppResponse> DeleteAppAsyncInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new AsyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除组件
        ///
        /// 删除组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest deleteComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", deleteComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteComponentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteComponentResponse>(response);
        }

        public AsyncInvoker<DeleteComponentResponse> DeleteComponentAsyncInvoker(DeleteComponentRequest deleteComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", deleteComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteComponentRequest);
            return new AsyncInvoker<DeleteComponentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteComponentResponse>);
        }
        
        /// <summary>
        /// 删除环境
        ///
        /// 删除环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEnvResponse> DeleteEnvAsync(DeleteEnvRequest deleteEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", deleteEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEnvResponse>(response);
        }

        public AsyncInvoker<DeleteEnvResponse> DeleteEnvAsyncInvoker(DeleteEnvRequest deleteEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", deleteEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvRequest);
            return new AsyncInvoker<DeleteEnvResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEnvResponse>);
        }
        
        /// <summary>
        /// 删除子应用
        ///
        /// 删除子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubAppResponse> DeleteSubAppAsync(DeleteSubAppRequest deleteSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", deleteSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubAppResponse>(response);
        }

        public AsyncInvoker<DeleteSubAppResponse> DeleteSubAppAsyncInvoker(DeleteSubAppRequest deleteSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", deleteSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubAppRequest);
            return new AsyncInvoker<DeleteSubAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubAppResponse>);
        }
        
        /// <summary>
        /// 查询绑定在节点上的资源列表
        ///
        /// 查询绑定在节点上的资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceUnderNodeResponse> ListResourceUnderNodeAsync(ListResourceUnderNodeRequest listResourceUnderNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rf_resource_type", listResourceUnderNodeRequest.RfResourceType.ToString());
            urlParam.Add("type", listResourceUnderNodeRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource/{rf_resource_type}/type/{type}/ci-relationships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUnderNodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceUnderNodeResponse>(response);
        }

        public AsyncInvoker<ListResourceUnderNodeResponse> ListResourceUnderNodeAsyncInvoker(ListResourceUnderNodeRequest listResourceUnderNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rf_resource_type", listResourceUnderNodeRequest.RfResourceType.ToString());
            urlParam.Add("type", listResourceUnderNodeRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource/{rf_resource_type}/type/{type}/ci-relationships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUnderNodeRequest);
            return new AsyncInvoker<ListResourceUnderNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceUnderNodeResponse>);
        }
        
        /// <summary>
        /// 查询应用详情
        ///
        /// 查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppResponse> ShowAppAsync(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public AsyncInvoker<ShowAppResponse> ShowAppAsyncInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new AsyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 根据应用名称查询应用详情
        ///
        /// 查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppByNameResponse> ShowAppByNameAsync(ShowAppByNameRequest showAppByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppByNameResponse>(response);
        }

        public AsyncInvoker<ShowAppByNameResponse> ShowAppByNameAsyncInvoker(ShowAppByNameRequest showAppByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppByNameRequest);
            return new AsyncInvoker<ShowAppByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppByNameResponse>);
        }
        
        /// <summary>
        /// 查询组件详情
        ///
        /// 查询组件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowComponentResponse> ShowComponentAsync(ShowComponentRequest showComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", showComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowComponentResponse>(response);
        }

        public AsyncInvoker<ShowComponentResponse> ShowComponentAsyncInvoker(ShowComponentRequest showComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", showComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentRequest);
            return new AsyncInvoker<ShowComponentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComponentResponse>);
        }
        
        /// <summary>
        /// 根据组件名称查询组件详情
        ///
        /// 查询组件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowComponentByNameResponse> ShowComponentByNameAsync(ShowComponentByNameRequest showComponentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showComponentByNameRequest.ApplicationId.ToString());
            urlParam.Add("component_name", showComponentByNameRequest.ComponentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/application/{application_id}/name/{component_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowComponentByNameResponse>(response);
        }

        public AsyncInvoker<ShowComponentByNameResponse> ShowComponentByNameAsyncInvoker(ShowComponentByNameRequest showComponentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showComponentByNameRequest.ApplicationId.ToString());
            urlParam.Add("component_name", showComponentByNameRequest.ComponentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/application/{application_id}/name/{component_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentByNameRequest);
            return new AsyncInvoker<ShowComponentByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComponentByNameResponse>);
        }
        
        /// <summary>
        /// 查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnvResponse> ShowEnvAsync(ShowEnvRequest showEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", showEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvResponse>(response);
        }

        public AsyncInvoker<ShowEnvResponse> ShowEnvAsyncInvoker(ShowEnvRequest showEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", showEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvRequest);
            return new AsyncInvoker<ShowEnvResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvResponse>);
        }
        
        /// <summary>
        /// 根据环境名称查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnvByNameResponse> ShowEnvByNameAsync(ShowEnvByNameRequest showEnvByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_name", showEnvByNameRequest.EnvironmentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/name/{environment_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvByNameResponse>(response);
        }

        public AsyncInvoker<ShowEnvByNameResponse> ShowEnvByNameAsyncInvoker(ShowEnvByNameRequest showEnvByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_name", showEnvByNameRequest.EnvironmentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/name/{environment_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvByNameRequest);
            return new AsyncInvoker<ShowEnvByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvByNameResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAppResponse>(response);
        }

        public AsyncInvoker<UpdateAppResponse> UpdateAppAsyncInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new AsyncInvoker<UpdateAppResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 修改组件
        ///
        /// 修改组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateComponentResponse> UpdateComponentAsync(UpdateComponentRequest updateComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", updateComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComponentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateComponentResponse>(response);
        }

        public AsyncInvoker<UpdateComponentResponse> UpdateComponentAsyncInvoker(UpdateComponentRequest updateComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", updateComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComponentRequest);
            return new AsyncInvoker<UpdateComponentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateComponentResponse>);
        }
        
        /// <summary>
        /// 修改环境
        ///
        /// 修改环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEnvResponse> UpdateEnvAsync(UpdateEnvRequest updateEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", updateEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateEnvResponse>(response);
        }

        public AsyncInvoker<UpdateEnvResponse> UpdateEnvAsyncInvoker(UpdateEnvRequest updateEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", updateEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvRequest);
            return new AsyncInvoker<UpdateEnvResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateEnvResponse>);
        }
        
        /// <summary>
        /// 修改子应用
        ///
        /// 修改子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubAppResponse> UpdateSubAppAsync(UpdateSubAppRequest updateSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", updateSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubAppRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubAppResponse>(response);
        }

        public AsyncInvoker<UpdateSubAppResponse> UpdateSubAppAsyncInvoker(UpdateSubAppRequest updateSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", updateSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubAppRequest);
            return new AsyncInvoker<UpdateSubAppResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubAppResponse>);
        }
        
    }
}