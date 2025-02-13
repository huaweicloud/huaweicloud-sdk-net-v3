using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Rabbitmq.V2.Model;

namespace HuaweiCloud.SDK.Rabbitmq.V2
{
    public partial class RabbitmqClient : Client
    {
        public static ClientBuilder<RabbitmqClient> NewBuilder()
        {
            return new ClientBuilder<RabbitmqClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateOrDeleteRabbitMqTagResponse BatchCreateOrDeleteRabbitMqTag(BatchCreateOrDeleteRabbitMqTagRequest batchCreateOrDeleteRabbitMqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRabbitMqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRabbitMqTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteRabbitMqTagResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteRabbitMqTagResponse> BatchCreateOrDeleteRabbitMqTagInvoker(BatchCreateOrDeleteRabbitMqTagRequest batchCreateOrDeleteRabbitMqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRabbitMqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRabbitMqTagRequest);
            return new SyncInvoker<BatchCreateOrDeleteRabbitMqTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteRabbitMqTagResponse>);
        }
        
        /// <summary>
        /// 批量删除实例
        ///
        /// 批量删除实例。
        /// 
        /// 实例删除后，实例中原有的数据将被删除，且没有备份，请谨慎操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestartOrDeleteInstancesResponse BatchRestartOrDeleteInstances(BatchRestartOrDeleteInstancesRequest batchRestartOrDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>(response);
        }

        public SyncInvoker<BatchRestartOrDeleteInstancesResponse> BatchRestartOrDeleteInstancesInvoker(BatchRestartOrDeleteInstancesRequest batchRestartOrDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            return new SyncInvoker<BatchRestartOrDeleteInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 创建实例(按需)
        ///
        /// 创建实例，该接口创建的实例为按需计费的方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostPaidInstanceResponse CreatePostPaidInstance(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>(response);
        }

        public SyncInvoker<CreatePostPaidInstanceResponse> CreatePostPaidInstanceInvoker(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            return new SyncInvoker<CreatePostPaidInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建实例[，该接口支持创建按需[和包周期](tag:hws,hws_eu,hws_hk,ctc,cmcc)计费方式的实例](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,cmcc,sbc)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostPaidInstanceByEngineResponse CreatePostPaidInstanceByEngine(CreatePostPaidInstanceByEngineRequest createPostPaidInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createPostPaidInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceByEngineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceByEngineResponse>(response);
        }

        public SyncInvoker<CreatePostPaidInstanceByEngineResponse> CreatePostPaidInstanceByEngineInvoker(CreatePostPaidInstanceByEngineRequest createPostPaidInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createPostPaidInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceByEngineRequest);
            return new SyncInvoker<CreatePostPaidInstanceByEngineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidInstanceByEngineResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建用户（仅AMQP版本支持）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserResponse CreateUser(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public SyncInvoker<CreateUserResponse> CreateUserInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new SyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
        }
        
        /// <summary>
        /// 删除后台任务管理中的指定记录
        ///
        /// 删除后台任务管理中的指定记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBackgroundTaskResponse DeleteBackgroundTask(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
        }

        public SyncInvoker<DeleteBackgroundTaskResponse> DeleteBackgroundTaskInvoker(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            return new SyncInvoker<DeleteBackgroundTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 删除指定的实例
        ///
        /// 删除指定的实例，释放该实例的所有资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 删除用户（仅AMQP版本支持）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 开启RabbitMQ实例域名访问能力
        ///
        /// 开启RabbitMQ实例域名访问功能后，客户端可以通过域名连接RabbitMQ实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDnsResponse EnableDns(EnableDnsRequest enableDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", enableDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableDnsResponse>(response);
        }

        public SyncInvoker<EnableDnsResponse> EnableDnsInvoker(EnableDnsRequest enableDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", enableDnsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnsRequest);
            return new SyncInvoker<EnableDnsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableDnsResponse>);
        }
        
        /// <summary>
        /// 查询可用区信息
        ///
        /// 在创建实例时，需要配置实例所在的可用区ID，可通过该接口查询可用区的ID。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }

        public SyncInvoker<ListAvailableZonesResponse> ListAvailableZonesInvoker(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/available-zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            return new SyncInvoker<ListAvailableZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableZonesResponse>);
        }
        
        /// <summary>
        /// 查询实例的后台任务列表
        ///
        /// 查询实例的后台任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBackgroundTasksResponse ListBackgroundTasks(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackgroundTasksResponse>(response);
        }

        public SyncInvoker<ListBackgroundTasksResponse> ListBackgroundTasksInvoker(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBackgroundTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            return new SyncInvoker<ListBackgroundTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackgroundTasksResponse>);
        }
        
        /// <summary>
        /// 查询产品规格列表
        ///
        /// 查询产品规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEngineProductsResponse ListEngineProducts(ListEngineProductsRequest listEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listEngineProductsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEngineProductsResponse>(response);
        }

        public SyncInvoker<ListEngineProductsResponse> ListEngineProductsInvoker(ListEngineProductsRequest listEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listEngineProductsRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            return new SyncInvoker<ListEngineProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEngineProductsResponse>);
        }
        
        /// <summary>
        /// 查询所有实例列表
        ///
        /// 查询租户的实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesDetailsResponse ListInstancesDetails(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesDetailsResponse>(response);
        }

        public SyncInvoker<ListInstancesDetailsResponse> ListInstancesDetailsInvoker(ListInstancesDetailsRequest listInstancesDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesDetailsRequest);
            return new SyncInvoker<ListInstancesDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesDetailsResponse>);
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPluginsResponse ListPlugins(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPluginsResponse>(response);
        }

        public SyncInvoker<ListPluginsResponse> ListPluginsInvoker(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listPluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginsRequest);
            return new SyncInvoker<ListPluginsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginsResponse>);
        }
        
        /// <summary>
        /// 查询产品规格列表
        ///
        /// 在创建实例时，需要配置订购的产品ID（即product_id），可通过该接口查询产品规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public SyncInvoker<ListProductsResponse> ListProductsInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new SyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表（仅AMQP版本支持）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserResponse ListUser(ListUserRequest listUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserResponse>(response);
        }

        public SyncInvoker<ListUserResponse> ListUserInvoker(ListUserRequest listUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserRequest);
            return new SyncInvoker<ListUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserResponse>);
        }
        
        /// <summary>
        /// 重置密码
        ///
        /// 重置密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public SyncInvoker<ResetPasswordResponse> ResetPasswordInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            return new SyncInvoker<ResetPasswordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetPasswordResponse>);
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
        public ResizeEngineInstanceResponse ResizeEngineInstance(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeEngineInstanceResponse>(response);
        }

        public SyncInvoker<ResizeEngineInstanceResponse> ResizeEngineInstanceInvoker(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            return new SyncInvoker<ResizeEngineInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeEngineInstanceResponse>);
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
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 查询后台任务管理中的指定记录
        ///
        /// 查询后台任务管理中的指定记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackgroundTaskResponse ShowBackgroundTask(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskResponse>(response);
        }

        public SyncInvoker<ShowBackgroundTaskResponse> ShowBackgroundTaskInvoker(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showBackgroundTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            return new SyncInvoker<ShowBackgroundTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 查询实例在CES的监控层级关系
        ///
        /// 查询实例在CES的监控层级关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCesHierarchyResponse ShowCesHierarchy(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCesHierarchyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCesHierarchyResponse>(response);
        }

        public SyncInvoker<ShowCesHierarchyResponse> ShowCesHierarchyInvoker(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCesHierarchyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            return new SyncInvoker<ShowCesHierarchyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCesHierarchyResponse>);
        }
        
        /// <summary>
        /// 查询新规格可扩容规格列表
        ///
        /// 查询新规格实例可扩容列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEngineInstanceExtendProductInfoResponse ShowEngineInstanceExtendProductInfo(ShowEngineInstanceExtendProductInfoRequest showEngineInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", showEngineInstanceExtendProductInfoRequest.Engine.ToString());
            urlParam.Add("instance_id", showEngineInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEngineInstanceExtendProductInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEngineInstanceExtendProductInfoResponse>(response);
        }

        public SyncInvoker<ShowEngineInstanceExtendProductInfoResponse> ShowEngineInstanceExtendProductInfoInvoker(ShowEngineInstanceExtendProductInfoRequest showEngineInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", showEngineInstanceExtendProductInfoRequest.Engine.ToString());
            urlParam.Add("instance_id", showEngineInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEngineInstanceExtendProductInfoRequest);
            return new SyncInvoker<ShowEngineInstanceExtendProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEngineInstanceExtendProductInfoResponse>);
        }
        
        /// <summary>
        /// 查询指定实例
        ///
        /// 查询指定实例的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new SyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
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
        public ShowInstanceExtendProductInfoResponse ShowInstanceExtendProductInfo(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>(response);
        }

        public SyncInvoker<ShowInstanceExtendProductInfoResponse> ShowInstanceExtendProductInfoInvoker(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceExtendProductInfoRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            return new SyncInvoker<ShowInstanceExtendProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        ///
        /// 查询维护时间窗开始时间和结束时间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMaintainWindowsResponse ShowMaintainWindows(ShowMaintainWindowsRequest showMaintainWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMaintainWindowsResponse>(response);
        }

        public SyncInvoker<ShowMaintainWindowsResponse> ShowMaintainWindowsInvoker(ShowMaintainWindowsRequest showMaintainWindowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            return new SyncInvoker<ShowMaintainWindowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMaintainWindowsResponse>);
        }
        
        /// <summary>
        /// 查看租户配额
        ///
        /// 查询租户最大可以创建的实例个数和已创建的实例个数，以及每个实例最大可以创建标签的个数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRabbitMqProjectTagsResponse ShowRabbitMqProjectTags(ShowRabbitMqProjectTagsRequest showRabbitMqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRabbitMqProjectTagsResponse>(response);
        }

        public SyncInvoker<ShowRabbitMqProjectTagsResponse> ShowRabbitMqProjectTagsInvoker(ShowRabbitMqProjectTagsRequest showRabbitMqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqProjectTagsRequest);
            return new SyncInvoker<ShowRabbitMqProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRabbitMqProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRabbitMqTagsResponse ShowRabbitMqTags(ShowRabbitMqTagsRequest showRabbitMqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRabbitMqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRabbitMqTagsResponse>(response);
        }

        public SyncInvoker<ShowRabbitMqTagsResponse> ShowRabbitMqTagsInvoker(ShowRabbitMqTagsRequest showRabbitMqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRabbitMqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rabbitmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRabbitMqTagsRequest);
            return new SyncInvoker<ShowRabbitMqTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRabbitMqTagsResponse>);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改实例的名称和描述信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }

        public SyncInvoker<UpdateInstanceResponse> UpdateInstanceInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            return new SyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceResponse>);
        }
        
        /// <summary>
        /// 开启或关闭插件
        ///
        /// 开启或关闭插件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePluginsResponse UpdatePlugins(UpdatePluginsRequest updatePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePluginsResponse>(response);
        }

        public SyncInvoker<UpdatePluginsResponse> UpdatePluginsInvoker(UpdatePluginsRequest updatePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updatePluginsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/rabbitmq/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePluginsRequest);
            return new SyncInvoker<UpdatePluginsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePluginsResponse>);
        }
        
        /// <summary>
        /// 修改用户参数
        ///
        /// 修改用户参数（仅AMQP版本支持）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public SyncInvoker<UpdateUserResponse> UpdateUserInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new SyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
        }
        
        /// <summary>
        /// 添加绑定
        ///
        /// 添加绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBindingResponse CreateBinding(CreateBindingRequest createBindingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBindingRequest.InstanceId.ToString());
            urlParam.Add("vhost", createBindingRequest.Vhost.ToString());
            urlParam.Add("exchange", createBindingRequest.Exchange.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBindingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBindingResponse>(response);
        }

        public SyncInvoker<CreateBindingResponse> CreateBindingInvoker(CreateBindingRequest createBindingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createBindingRequest.InstanceId.ToString());
            urlParam.Add("vhost", createBindingRequest.Vhost.ToString());
            urlParam.Add("exchange", createBindingRequest.Exchange.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBindingRequest);
            return new SyncInvoker<CreateBindingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBindingResponse>);
        }
        
        /// <summary>
        /// 删除绑定
        ///
        /// 删除绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest deleteBindingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBindingRequest.InstanceId.ToString());
            urlParam.Add("vhost", deleteBindingRequest.Vhost.ToString());
            urlParam.Add("exchange", deleteBindingRequest.Exchange.ToString());
            urlParam.Add("destination_type", deleteBindingRequest.DestinationType.ToString());
            urlParam.Add("destination", deleteBindingRequest.Destination.ToString());
            urlParam.Add("properties_key", deleteBindingRequest.PropertiesKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/destination-type/{destination_type}/destination/{destination}/properties-key/{properties_key}/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBindingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBindingResponse>(response);
        }

        public SyncInvoker<DeleteBindingResponse> DeleteBindingInvoker(DeleteBindingRequest deleteBindingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteBindingRequest.InstanceId.ToString());
            urlParam.Add("vhost", deleteBindingRequest.Vhost.ToString());
            urlParam.Add("exchange", deleteBindingRequest.Exchange.ToString());
            urlParam.Add("destination_type", deleteBindingRequest.DestinationType.ToString());
            urlParam.Add("destination", deleteBindingRequest.Destination.ToString());
            urlParam.Add("properties_key", deleteBindingRequest.PropertiesKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/destination-type/{destination_type}/destination/{destination}/properties-key/{properties_key}/unbinding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBindingRequest);
            return new SyncInvoker<DeleteBindingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBindingResponse>);
        }
        
        /// <summary>
        /// 查询Exchange绑定信息列表
        ///
        /// 查询Exchange绑定信息列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBindingsResponse ListBindings(ListBindingsRequest listBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindingsRequest.InstanceId.ToString());
            urlParam.Add("vhost", listBindingsRequest.Vhost.ToString());
            urlParam.Add("exchange", listBindingsRequest.Exchange.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBindingsResponse>(response);
        }

        public SyncInvoker<ListBindingsResponse> ListBindingsInvoker(ListBindingsRequest listBindingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBindingsRequest.InstanceId.ToString());
            urlParam.Add("vhost", listBindingsRequest.Vhost.ToString());
            urlParam.Add("exchange", listBindingsRequest.Exchange.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges/{exchange}/binding", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBindingsRequest);
            return new SyncInvoker<ListBindingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBindingsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定Exchange
        ///
        /// 批量删除指定Exchange。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteExchangesResponse BatchDeleteExchanges(BatchDeleteExchangesRequest batchDeleteExchangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteExchangesRequest.InstanceId.ToString());
            urlParam.Add("vhost", batchDeleteExchangesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteExchangesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteExchangesResponse>(response);
        }

        public SyncInvoker<BatchDeleteExchangesResponse> BatchDeleteExchangesInvoker(BatchDeleteExchangesRequest batchDeleteExchangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteExchangesRequest.InstanceId.ToString());
            urlParam.Add("vhost", batchDeleteExchangesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteExchangesRequest);
            return new SyncInvoker<BatchDeleteExchangesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteExchangesResponse>);
        }
        
        /// <summary>
        /// 创建Exchange
        ///
        /// 创建Exchange。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateExchangeResponse CreateExchange(CreateExchangeRequest createExchangeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createExchangeRequest.InstanceId.ToString());
            urlParam.Add("vhost", createExchangeRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExchangeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateExchangeResponse>(response);
        }

        public SyncInvoker<CreateExchangeResponse> CreateExchangeInvoker(CreateExchangeRequest createExchangeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createExchangeRequest.InstanceId.ToString());
            urlParam.Add("vhost", createExchangeRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExchangeRequest);
            return new SyncInvoker<CreateExchangeResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateExchangeResponse>);
        }
        
        /// <summary>
        /// 查询Exchange列表
        ///
        /// 查询Exchange列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExchangesResponse ListExchanges(ListExchangesRequest listExchangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listExchangesRequest.InstanceId.ToString());
            urlParam.Add("vhost", listExchangesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExchangesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListExchangesResponse>(response);
        }

        public SyncInvoker<ListExchangesResponse> ListExchangesInvoker(ListExchangesRequest listExchangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listExchangesRequest.InstanceId.ToString());
            urlParam.Add("vhost", listExchangesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/exchanges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExchangesRequest);
            return new SyncInvoker<ListExchangesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExchangesResponse>);
        }
        
        /// <summary>
        /// 批量删除指定Queue
        ///
        /// 批量删除指定Queue。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteQueuesResponse BatchDeleteQueues(BatchDeleteQueuesRequest batchDeleteQueuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteQueuesRequest.InstanceId.ToString());
            urlParam.Add("vhost", batchDeleteQueuesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteQueuesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteQueuesResponse>(response);
        }

        public SyncInvoker<BatchDeleteQueuesResponse> BatchDeleteQueuesInvoker(BatchDeleteQueuesRequest batchDeleteQueuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteQueuesRequest.InstanceId.ToString());
            urlParam.Add("vhost", batchDeleteQueuesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteQueuesRequest);
            return new SyncInvoker<BatchDeleteQueuesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteQueuesResponse>);
        }
        
        /// <summary>
        /// 创建Queue
        ///
        /// 创建Queue。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateQueueResponse CreateQueue(CreateQueueRequest createQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createQueueRequest.InstanceId.ToString());
            urlParam.Add("vhost", createQueueRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQueueRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateQueueResponse>(response);
        }

        public SyncInvoker<CreateQueueResponse> CreateQueueInvoker(CreateQueueRequest createQueueRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createQueueRequest.InstanceId.ToString());
            urlParam.Add("vhost", createQueueRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQueueRequest);
            return new SyncInvoker<CreateQueueResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateQueueResponse>);
        }
        
        /// <summary>
        /// 清空Queue消息
        ///
        /// 清空Queue消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteQueueInfoResponse DeleteQueueInfo(DeleteQueueInfoRequest deleteQueueInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteQueueInfoRequest.InstanceId.ToString());
            urlParam.Add("vhost", deleteQueueInfoRequest.Vhost.ToString());
            urlParam.Add("queue", deleteQueueInfoRequest.Queue.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues/{queue}/contents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueInfoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteQueueInfoResponse>(response);
        }

        public SyncInvoker<DeleteQueueInfoResponse> DeleteQueueInfoInvoker(DeleteQueueInfoRequest deleteQueueInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteQueueInfoRequest.InstanceId.ToString());
            urlParam.Add("vhost", deleteQueueInfoRequest.Vhost.ToString());
            urlParam.Add("queue", deleteQueueInfoRequest.Queue.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues/{queue}/contents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueInfoRequest);
            return new SyncInvoker<DeleteQueueInfoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteQueueInfoResponse>);
        }
        
        /// <summary>
        /// 查询所属Vhost下Queue的列表
        ///
        /// 查询所属Vhost下Queue的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQueuesResponse ListQueues(ListQueuesRequest listQueuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listQueuesRequest.InstanceId.ToString());
            urlParam.Add("vhost", listQueuesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueuesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQueuesResponse>(response);
        }

        public SyncInvoker<ListQueuesResponse> ListQueuesInvoker(ListQueuesRequest listQueuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listQueuesRequest.InstanceId.ToString());
            urlParam.Add("vhost", listQueuesRequest.Vhost.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueuesRequest);
            return new SyncInvoker<ListQueuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueuesResponse>);
        }
        
        /// <summary>
        /// 查询指定Queue详情
        ///
        /// 查询指定Queue详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQueueDetailsResponse ShowQueueDetails(ShowQueueDetailsRequest showQueueDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showQueueDetailsRequest.InstanceId.ToString());
            urlParam.Add("vhost", showQueueDetailsRequest.Vhost.ToString());
            urlParam.Add("queue", showQueueDetailsRequest.Queue.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues/{queue}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQueueDetailsResponse>(response);
        }

        public SyncInvoker<ShowQueueDetailsResponse> ShowQueueDetailsInvoker(ShowQueueDetailsRequest showQueueDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showQueueDetailsRequest.InstanceId.ToString());
            urlParam.Add("vhost", showQueueDetailsRequest.Vhost.ToString());
            urlParam.Add("queue", showQueueDetailsRequest.Queue.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts/{vhost}/queues/{queue}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueDetailsRequest);
            return new SyncInvoker<ShowQueueDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQueueDetailsResponse>);
        }
        
        /// <summary>
        /// 批量删除指定Vhost
        ///
        /// 批量删除指定Vhost。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteVhostsResponse BatchDeleteVhosts(BatchDeleteVhostsRequest batchDeleteVhostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteVhostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteVhostsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteVhostsResponse>(response);
        }

        public SyncInvoker<BatchDeleteVhostsResponse> BatchDeleteVhostsInvoker(BatchDeleteVhostsRequest batchDeleteVhostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteVhostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteVhostsRequest);
            return new SyncInvoker<BatchDeleteVhostsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteVhostsResponse>);
        }
        
        /// <summary>
        /// 创建Vhost
        ///
        /// 创建Vhost。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVhostResponse CreateVhost(CreateVhostRequest createVhostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createVhostRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVhostRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<CreateVhostResponse>(response);
        }

        public SyncInvoker<CreateVhostResponse> CreateVhostInvoker(CreateVhostRequest createVhostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createVhostRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVhostRequest);
            return new SyncInvoker<CreateVhostResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<CreateVhostResponse>);
        }
        
        /// <summary>
        /// 查询Vhost列表
        ///
        /// 查询Vhost列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVhostsResponse ListVhosts(ListVhostsRequest listVhostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listVhostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVhostsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVhostsResponse>(response);
        }

        public SyncInvoker<ListVhostsResponse> ListVhostsInvoker(ListVhostsRequest listVhostsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listVhostsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rabbitmq/{project_id}/instances/{instance_id}/vhosts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVhostsRequest);
            return new SyncInvoker<ListVhostsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVhostsResponse>);
        }
        
    }
}