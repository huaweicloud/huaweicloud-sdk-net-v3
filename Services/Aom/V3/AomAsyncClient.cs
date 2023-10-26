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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateAppResponse createAppResponse = JsonUtils.DeSerializeNull<CreateAppResponse>(response);
            return createAppResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/components",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createComponentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateComponentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/environments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEnvRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEnvResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/sub-applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateSubAppResponse createSubAppResponse = JsonUtils.DeSerializeNull<CreateSubAppResponse>(response);
            return createSubAppResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , deleteAppRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteAppResponse deleteAppResponse = JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
            return deleteAppResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id" , deleteComponentRequest.ComponentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteComponentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteComponentResponse deleteComponentResponse = JsonUtils.DeSerializeNull<DeleteComponentResponse>(response);
            return deleteComponentResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id" , deleteEnvRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEnvRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEnvResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id" , deleteSubAppRequest.SubAppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteSubAppResponse deleteSubAppResponse = JsonUtils.DeSerializeNull<DeleteSubAppResponse>(response);
            return deleteSubAppResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rf_resource_type" , listResourceUnderNodeRequest.RfResourceType.ToString());
            urlParam.Add("type" , listResourceUnderNodeRequest.Type.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/resource/{rf_resource_type}/type/{type}/ci-relationships",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceUnderNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceUnderNodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , showAppRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppByNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id" , showComponentRequest.ComponentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowComponentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , showComponentByNameRequest.ApplicationId.ToString());
            urlParam.Add("component_name" , showComponentByNameRequest.ComponentName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/components/application/{application_id}/name/{component_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComponentByNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowComponentByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id" , showEnvRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEnvResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_name" , showEnvByNameRequest.EnvironmentName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/environments/name/{environment_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnvByNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEnvByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_id" , updateAppRequest.ApplicationId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/applications/{application_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("component_id" , updateComponentRequest.ComponentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/components/{component_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComponentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateComponentResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("environment_id" , updateEnvRequest.EnvironmentId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/environments/{environment_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEnvRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateEnvResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_app_id" , updateSubAppRequest.SubAppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/sub-applications/{sub_app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateSubAppResponse>(response);
        }
        
    }
}