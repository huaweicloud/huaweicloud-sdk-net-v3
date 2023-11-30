using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V3.Model;

namespace HuaweiCloud.SDK.Aom.V3
{
    public partial class AomClient : Client
    {
        public static ClientBuilder<AomClient> NewBuilder()
        {
            return new ClientBuilder<AomClient>();
        }

        
        /// <summary>
        /// 新增应用
        ///
        /// 新增应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAppResponse>(response);
        }

        public SyncInvoker<CreateAppResponse> CreateAppInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new SyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAppResponse>);
        }
        
        /// <summary>
        /// 新增组件
        ///
        /// 新增组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateComponentResponse CreateComponent(CreateComponentRequest createComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createComponentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateComponentResponse>(response);
        }

        public SyncInvoker<CreateComponentResponse> CreateComponentInvoker(CreateComponentRequest createComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/components", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createComponentRequest);
            return new SyncInvoker<CreateComponentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateComponentResponse>);
        }
        
        /// <summary>
        /// 创建环境
        ///
        /// 创建环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEnvResponse CreateEnv(CreateEnvRequest createEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEnvResponse>(response);
        }

        public SyncInvoker<CreateEnvResponse> CreateEnvInvoker(CreateEnvRequest createEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/environments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvRequest);
            return new SyncInvoker<CreateEnvResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEnvResponse>);
        }
        
        /// <summary>
        /// 新增子应用
        ///
        /// 新增子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubAppResponse CreateSubApp(CreateSubAppRequest createSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubAppResponse>(response);
        }

        public SyncInvoker<CreateSubAppResponse> CreateSubAppInvoker(CreateSubAppRequest createSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubAppRequest);
            return new SyncInvoker<CreateSubAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubAppResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public SyncInvoker<DeleteAppResponse> DeleteAppInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", deleteAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new SyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除组件
        ///
        /// 删除组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteComponentResponse DeleteComponent(DeleteComponentRequest deleteComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", deleteComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteComponentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteComponentResponse>(response);
        }

        public SyncInvoker<DeleteComponentResponse> DeleteComponentInvoker(DeleteComponentRequest deleteComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", deleteComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteComponentRequest);
            return new SyncInvoker<DeleteComponentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteComponentResponse>);
        }
        
        /// <summary>
        /// 删除环境
        ///
        /// 删除环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEnvResponse DeleteEnv(DeleteEnvRequest deleteEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", deleteEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEnvResponse>(response);
        }

        public SyncInvoker<DeleteEnvResponse> DeleteEnvInvoker(DeleteEnvRequest deleteEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", deleteEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvRequest);
            return new SyncInvoker<DeleteEnvResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEnvResponse>);
        }
        
        /// <summary>
        /// 删除子应用
        ///
        /// 删除子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubAppResponse DeleteSubApp(DeleteSubAppRequest deleteSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", deleteSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubAppResponse>(response);
        }

        public SyncInvoker<DeleteSubAppResponse> DeleteSubAppInvoker(DeleteSubAppRequest deleteSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", deleteSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubAppRequest);
            return new SyncInvoker<DeleteSubAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubAppResponse>);
        }
        
        /// <summary>
        /// 查询绑定在节点上的资源列表
        ///
        /// 查询绑定在节点上的资源列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceUnderNodeResponse ListResourceUnderNode(ListResourceUnderNodeRequest listResourceUnderNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rf_resource_type", listResourceUnderNodeRequest.RfResourceType.ToString());
            urlParam.Add("type", listResourceUnderNodeRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource/{rf_resource_type}/type/{type}/ci-relationships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUnderNodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceUnderNodeResponse>(response);
        }

        public SyncInvoker<ListResourceUnderNodeResponse> ListResourceUnderNodeInvoker(ListResourceUnderNodeRequest listResourceUnderNodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rf_resource_type", listResourceUnderNodeRequest.RfResourceType.ToString());
            urlParam.Add("type", listResourceUnderNodeRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource/{rf_resource_type}/type/{type}/ci-relationships", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUnderNodeRequest);
            return new SyncInvoker<ListResourceUnderNodeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceUnderNodeResponse>);
        }
        
        /// <summary>
        /// 查询应用详情
        ///
        /// 查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppResponse ShowApp(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public SyncInvoker<ShowAppResponse> ShowAppInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new SyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 根据应用名称查询应用详情
        ///
        /// 查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppByNameResponse ShowAppByName(ShowAppByNameRequest showAppByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppByNameResponse>(response);
        }

        public SyncInvoker<ShowAppByNameResponse> ShowAppByNameInvoker(ShowAppByNameRequest showAppByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppByNameRequest);
            return new SyncInvoker<ShowAppByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppByNameResponse>);
        }
        
        /// <summary>
        /// 查询组件详情
        ///
        /// 查询组件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowComponentResponse ShowComponent(ShowComponentRequest showComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", showComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowComponentResponse>(response);
        }

        public SyncInvoker<ShowComponentResponse> ShowComponentInvoker(ShowComponentRequest showComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", showComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentRequest);
            return new SyncInvoker<ShowComponentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComponentResponse>);
        }
        
        /// <summary>
        /// 根据组件名称查询组件详情
        ///
        /// 查询组件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowComponentByNameResponse ShowComponentByName(ShowComponentByNameRequest showComponentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showComponentByNameRequest.ApplicationId.ToString());
            urlParam.Add("component_name", showComponentByNameRequest.ComponentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/application/{application_id}/name/{component_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowComponentByNameResponse>(response);
        }

        public SyncInvoker<ShowComponentByNameResponse> ShowComponentByNameInvoker(ShowComponentByNameRequest showComponentByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", showComponentByNameRequest.ApplicationId.ToString());
            urlParam.Add("component_name", showComponentByNameRequest.ComponentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/application/{application_id}/name/{component_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentByNameRequest);
            return new SyncInvoker<ShowComponentByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComponentByNameResponse>);
        }
        
        /// <summary>
        /// 查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnvResponse ShowEnv(ShowEnvRequest showEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", showEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvResponse>(response);
        }

        public SyncInvoker<ShowEnvResponse> ShowEnvInvoker(ShowEnvRequest showEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", showEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvRequest);
            return new SyncInvoker<ShowEnvResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvResponse>);
        }
        
        /// <summary>
        /// 根据环境名称查询环境详情
        ///
        /// 查询环境详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnvByNameResponse ShowEnvByName(ShowEnvByNameRequest showEnvByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_name", showEnvByNameRequest.EnvironmentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/name/{environment_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnvByNameResponse>(response);
        }

        public SyncInvoker<ShowEnvByNameResponse> ShowEnvByNameInvoker(ShowEnvByNameRequest showEnvByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_name", showEnvByNameRequest.EnvironmentName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/name/{environment_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvByNameRequest);
            return new SyncInvoker<ShowEnvByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnvByNameResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppResponse UpdateApp(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAppResponse>(response);
        }

        public SyncInvoker<UpdateAppResponse> UpdateAppInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id", updateAppRequest.ApplicationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new SyncInvoker<UpdateAppResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 修改组件
        ///
        /// 修改组件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateComponentResponse UpdateComponent(UpdateComponentRequest updateComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", updateComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComponentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateComponentResponse>(response);
        }

        public SyncInvoker<UpdateComponentResponse> UpdateComponentInvoker(UpdateComponentRequest updateComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id", updateComponentRequest.ComponentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComponentRequest);
            return new SyncInvoker<UpdateComponentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateComponentResponse>);
        }
        
        /// <summary>
        /// 修改环境
        ///
        /// 修改环境。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEnvResponse UpdateEnv(UpdateEnvRequest updateEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", updateEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateEnvResponse>(response);
        }

        public SyncInvoker<UpdateEnvResponse> UpdateEnvInvoker(UpdateEnvRequest updateEnvRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id", updateEnvRequest.EnvironmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvRequest);
            return new SyncInvoker<UpdateEnvResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateEnvResponse>);
        }
        
        /// <summary>
        /// 修改子应用
        ///
        /// 修改子应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubAppResponse UpdateSubApp(UpdateSubAppRequest updateSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", updateSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubAppRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubAppResponse>(response);
        }

        public SyncInvoker<UpdateSubAppResponse> UpdateSubAppInvoker(UpdateSubAppRequest updateSubAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id", updateSubAppRequest.SubAppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubAppRequest);
            return new SyncInvoker<UpdateSubAppResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubAppResponse>);
        }
        
    }
}