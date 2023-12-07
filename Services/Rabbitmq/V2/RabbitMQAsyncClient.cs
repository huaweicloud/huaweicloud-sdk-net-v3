using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rabbitmq.V2.Model;

namespace HuaweiCloud.SDK.Rabbitmq.V2
{
    public partial class RabbitmqAsyncClient : Client
    {
        public static ClientBuilder<RabbitmqAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RabbitmqAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteRabbitMqTagResponse> BatchCreateOrDeleteRabbitMqTagAsync(BatchCreateOrDeleteRabbitMqTagRequest batchCreateOrDeleteRabbitMqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRabbitMqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRabbitMqTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteRabbitMqTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteRabbitMqTagResponse> BatchCreateOrDeleteRabbitMqTagAsyncInvoker(BatchCreateOrDeleteRabbitMqTagRequest batchCreateOrDeleteRabbitMqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRabbitMqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRabbitMqTagRequest);
            return new AsyncInvoker<BatchCreateOrDeleteRabbitMqTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteRabbitMqTagResponse>);
        }
        
        /// <summary>
        /// 批量重启或删除实例
        ///
        /// 批量重启或删除实例。
        /// 
        /// 在实例重启过程中，客户端的生产与消费消息等请求会被拒绝。
        /// 
        /// 实例删除后，实例中原有的数据将被删除，且没有备份，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestartOrDeleteInstancesResponse> BatchRestartOrDeleteInstancesAsync(BatchRestartOrDeleteInstancesRequest batchRestartOrDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>(response);
        }

        public AsyncInvoker<BatchRestartOrDeleteInstancesResponse> BatchRestartOrDeleteInstancesAsyncInvoker(BatchRestartOrDeleteInstancesRequest batchRestartOrDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            return new AsyncInvoker<BatchRestartOrDeleteInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 创建实例(按需)
        ///
        /// 创建实例，该接口创建的实例为按需计费的方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostPaidInstanceResponse> CreatePostPaidInstanceAsync(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>(response);
        }

        public AsyncInvoker<CreatePostPaidInstanceResponse> CreatePostPaidInstanceAsyncInvoker(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            return new AsyncInvoker<CreatePostPaidInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建实例，该接口支持创建按需[和包周期](tag:hws,hws_eu,hws_hk,ctc,cmcc)计费方式的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostPaidInstanceByEngineResponse> CreatePostPaidInstanceByEngineAsync(CreatePostPaidInstanceByEngineRequest createPostPaidInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createPostPaidInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceByEngineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceByEngineResponse>(response);
        }

        public AsyncInvoker<CreatePostPaidInstanceByEngineResponse> CreatePostPaidInstanceByEngineAsyncInvoker(CreatePostPaidInstanceByEngineRequest createPostPaidInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createPostPaidInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceByEngineRequest);
            return new AsyncInvoker<CreatePostPaidInstanceByEngineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidInstanceByEngineResponse>);
        }
        
        /// <summary>
        /// 删除后台任务管理中的指定记录
        ///
        /// 删除后台任务管理中的指定记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBackgroundTaskResponse> DeleteBackgroundTaskAsync(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
        }

        public AsyncInvoker<DeleteBackgroundTaskResponse> DeleteBackgroundTaskAsyncInvoker(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            return new AsyncInvoker<DeleteBackgroundTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 删除指定的实例
        ///
        /// 删除指定的实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 在创建实例时，需要配置实例所在的可用区ID，可通过该接口查询可用区的ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }

        public AsyncInvoker<ListAvailableZonesResponse> ListAvailableZonesAsyncInvoker(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            return new AsyncInvoker<ListAvailableZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 查询实例的后台任务列表
        ///
        /// 查询实例的后台任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBackgroundTasksResponse> ListBackgroundTasksAsync(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBackgroundTasksResponse>(response);
        }

        public AsyncInvoker<ListBackgroundTasksResponse> ListBackgroundTasksAsyncInvoker(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            return new AsyncInvoker<ListBackgroundTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackgroundTasksResponse>);
        }
        
        /// <summary>
        /// 查询产品规格列表
        ///
        /// 查询产品规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEngineProductsResponse> ListEngineProductsAsync(ListEngineProductsRequest listEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listEngineProductsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEngineProductsResponse>(response);
        }

        public AsyncInvoker<ListEngineProductsResponse> ListEngineProductsAsyncInvoker(ListEngineProductsRequest listEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listEngineProductsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            return new AsyncInvoker<ListEngineProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEngineProductsResponse>);
        }
        
        /// <summary>
        /// 查询所有实例列表
        ///
        /// 查询租户的实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesDetailsResponse> ListInstancesDetailsAsync(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesDetailsResponse>(response);
        }

        public AsyncInvoker<ListInstancesDetailsResponse> ListInstancesDetailsAsyncInvoker(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            return new AsyncInvoker<ListInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesDetailsResponse>);
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPluginsResponse>(response);
        }

        public AsyncInvoker<ListPluginsResponse> ListPluginsAsyncInvoker(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginsRequest);
            return new AsyncInvoker<ListPluginsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginsResponse>);
        }
        
        /// <summary>
        /// 查询产品规格列表
        ///
        /// 在创建实例时，需要配置订购的产品ID（即product_id），可通过该接口查询产品规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public AsyncInvoker<ListProductsResponse> ListProductsAsyncInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new AsyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 重置密码
        ///
        /// 重置密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public AsyncInvoker<ResetPasswordResponse> ResetPasswordAsyncInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new AsyncInvoker<ResetPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
        }
        
        /// <summary>
        /// 新规格实例的规格变更
        ///
        /// 实例规格变更。
        /// 
        /// [**当前通过调用API，只支持按需实例进行实例规格变更。**](tag:hws,hws_hk,ctc,cmcc,hws_eu)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeEngineInstanceResponse> ResizeEngineInstanceAsync(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeEngineInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeEngineInstanceResponse> ResizeEngineInstanceAsyncInvoker(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            return new AsyncInvoker<ResizeEngineInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeEngineInstanceResponse>);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。
        /// 
        /// [**当前通过调用API，只支持按需实例进行实例规格变更。**](tag:hws,hws_hk,ctc,cmcc,hws_eu)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceResponse> ResizeInstanceAsyncInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new AsyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 查询后台任务管理中的指定记录
        ///
        /// 查询后台任务管理中的指定记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBackgroundTaskResponse> ShowBackgroundTaskAsync(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskResponse>(response);
        }

        public AsyncInvoker<ShowBackgroundTaskResponse> ShowBackgroundTaskAsyncInvoker(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            return new AsyncInvoker<ShowBackgroundTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 查询实例在CES的监控层级关系
        ///
        /// 查询实例在CES的监控层级关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCesHierarchyResponse> ShowCesHierarchyAsync(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCesHierarchyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCesHierarchyResponse>(response);
        }

        public AsyncInvoker<ShowCesHierarchyResponse> ShowCesHierarchyAsyncInvoker(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCesHierarchyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            return new AsyncInvoker<ShowCesHierarchyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCesHierarchyResponse>);
        }
        
        /// <summary>
        /// 查询新规格可扩容规格列表
        ///
        /// 查询新规格实例可扩容列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEngineInstanceExtendProductInfoResponse> ShowEngineInstanceExtendProductInfoAsync(ShowEngineInstanceExtendProductInfoRequest showEngineInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", showEngineInstanceExtendProductInfoRequest.Engine.ToString());
            urlParam.Add("instance_id", showEngineInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEngineInstanceExtendProductInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEngineInstanceExtendProductInfoResponse>(response);
        }

        public AsyncInvoker<ShowEngineInstanceExtendProductInfoResponse> ShowEngineInstanceExtendProductInfoAsyncInvoker(ShowEngineInstanceExtendProductInfoRequest showEngineInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", showEngineInstanceExtendProductInfoRequest.Engine.ToString());
            urlParam.Add("instance_id", showEngineInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEngineInstanceExtendProductInfoRequest);
            return new AsyncInvoker<ShowEngineInstanceExtendProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEngineInstanceExtendProductInfoResponse>);
        }
        
        /// <summary>
        /// 查询指定实例
        ///
        /// 查询指定实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceResponse> ShowInstanceAsync(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public AsyncInvoker<ShowInstanceResponse> ShowInstanceAsyncInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new AsyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 查询可扩容规格列表
        ///
        /// 查询可扩容规格列表。
        /// 
        /// RabbtiMQ只支持只增加节点数的扩容方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceExtendProductInfoResponse> ShowInstanceExtendProductInfoAsync(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>(response);
        }

        public AsyncInvoker<ShowInstanceExtendProductInfoResponse> ShowInstanceExtendProductInfoAsyncInvoker(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            return new AsyncInvoker<ShowInstanceExtendProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        ///
        /// 查询维护时间窗开始时间和结束时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMaintainWindowsResponse> ShowMaintainWindowsAsync(ShowMaintainWindowsRequest showMaintainWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMaintainWindowsResponse>(response);
        }

        public AsyncInvoker<ShowMaintainWindowsResponse> ShowMaintainWindowsAsyncInvoker(ShowMaintainWindowsRequest showMaintainWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            return new AsyncInvoker<ShowMaintainWindowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMaintainWindowsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRabbitMqProjectTagsResponse> ShowRabbitMqProjectTagsAsync(ShowRabbitMqProjectTagsRequest showRabbitMqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRabbitMqProjectTagsResponse>(response);
        }

        public AsyncInvoker<ShowRabbitMqProjectTagsResponse> ShowRabbitMqProjectTagsAsyncInvoker(ShowRabbitMqProjectTagsRequest showRabbitMqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqProjectTagsRequest);
            return new AsyncInvoker<ShowRabbitMqProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRabbitMqProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRabbitMqTagsResponse> ShowRabbitMqTagsAsync(ShowRabbitMqTagsRequest showRabbitMqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRabbitMqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRabbitMqTagsResponse>(response);
        }

        public AsyncInvoker<ShowRabbitMqTagsResponse> ShowRabbitMqTagsAsyncInvoker(ShowRabbitMqTagsRequest showRabbitMqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRabbitMqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqTagsRequest);
            return new AsyncInvoker<ShowRabbitMqTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRabbitMqTagsResponse>);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改实例的名称和描述信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceResponse> UpdateInstanceAsyncInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            return new AsyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceResponse>);
        }
        
        /// <summary>
        /// 开启或关闭插件
        ///
        /// 开启或关闭插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePluginsResponse> UpdatePluginsAsync(UpdatePluginsRequest updatePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePluginsResponse>(response);
        }

        public AsyncInvoker<UpdatePluginsResponse> UpdatePluginsAsyncInvoker(UpdatePluginsRequest updatePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginsRequest);
            return new AsyncInvoker<UpdatePluginsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePluginsResponse>);
        }
        
    }
}