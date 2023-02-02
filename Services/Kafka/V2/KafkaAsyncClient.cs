using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace HuaweiCloud.SDK.Kafka.V2
{
    public partial class KafkaAsyncClient : Client
    {
        public static ClientBuilder<KafkaAsyncClient> NewBuilder()
        {
            return new ClientBuilder<KafkaAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteKafkaTagResponse> BatchCreateOrDeleteKafkaTagAsync(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例批量删除Topic
        ///
        /// 该接口用于向Kafka实例批量删除Topic。批量删除多个消费组时，部分删除成功，部分失败，此时接口返回删除成功，并在返回中显示删除失败的消费组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInstanceTopicResponse> BatchDeleteInstanceTopicAsync(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 批量删除Kafka实例的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInstanceUsersResponse> BatchDeleteInstanceUsersAsync(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>(response);
        }
        
        /// <summary>
        /// 创建实例的转储节点
        ///
        /// 创建实例的转储节点。
        /// 
        /// **当前通过调用API，只支持按需实例创建转储节点。**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest createConnectorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createConnectorRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConnectorResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建实例。
        /// 
        /// 该接口支持创建按需和包周期两种计费方式的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceByEngineResponse> CreateInstanceByEngineAsync(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , createInstanceByEngineRequest.Engine.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceByEngineResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例创建Topic
        ///
        /// 该接口用于向Kafka实例创建Topic。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceTopicResponse> CreateInstanceTopicAsync(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建Kafka实例的用户，用户可连接开启SASL的Kafka实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceUserResponse> CreateInstanceUserAsync(CreateInstanceUserRequest createInstanceUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createInstanceUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateInstanceUserResponse>(response);
        }
        
        /// <summary>
        /// 新增Kafka实例指定Topic分区
        ///
        /// 新增Kafka实例指定Topic分区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest createPartitionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPartitionRequest.InstanceId.ToString());
            urlParam.Add("topic" , createPartitionRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePartitionResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// [创建按需计费类型的Kafka实例。](tag:hc,hk,hws,hws_hk,ctc,sbc,hk_sbc,cmcc,hws_eu)[创建kafka实例。](tag:otc,ocb,hws_ocb)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePostPaidInstanceResponse> CreatePostPaidInstanceAsync(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例开始分区重平衡任务
        ///
        /// 该接口用于向Kafka实例提交分区重平衡任务，若成功则返回重平衡任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReassignmentTaskResponse> CreateReassignmentTaskAsync(CreateReassignmentTaskRequest createReassignmentTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createReassignmentTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/reassign",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReassignmentTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateReassignmentTaskResponse>(response);
        }
        
        /// <summary>
        /// 创建转储任务
        ///
        /// 创建转储任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSinkTaskResponse> CreateSinkTaskAsync(CreateSinkTaskRequest createSinkTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , createSinkTaskRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSinkTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSinkTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id" , deleteBackgroundTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除单个转储任务
        ///
        /// 删除单个转储任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSinkTaskResponse> DeleteSinkTaskAsync(DeleteSinkTaskRequest deleteSinkTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , deleteSinkTaskRequest.ConnectorId.ToString());
            urlParam.Add("task_id" , deleteSinkTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSinkTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSinkTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/available-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackgroundTasksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackgroundTasksResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , listEngineProductsRequest.Engine.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEngineProductsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有消费组
        ///
        /// 查询所有消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceConsumerGroupsResponse> ListInstanceConsumerGroupsAsync(ListInstanceConsumerGroupsRequest listInstanceConsumerGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceConsumerGroupsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例查询Topic
        ///
        /// 该接口用于查询指定Kafka实例的Topic详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTopicsResponse> ListInstanceTopicsAsync(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceTopicsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceTopicsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有实例列表
        ///
        /// 查询租户的实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest listInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询产品规格列表
        ///
        /// 在创建kafka实例时，需要配置订购的产品ID（即product_id），可通过该接口查询产品规格。
        /// 
        /// 例如，要订购按需计费、基准带宽为100MB的kafka实例，可从接口响应消息中，查找Hourly的消息体，然后找到bandwidth为100MB的记录对应的product_id，该product_id的值即是创建上述kafka实例时需要配置的产品ID。
        /// 
        /// 同时，unavailable_zones字段表示资源不足的可用区列表，如果为空，则表示所有可用区都有资源，如果不为空，则表示字段值的可用区没有资源。所以必须确保您购买的资源所在的可用区有资源，不在该字段列表内。
        /// 
        /// [例如，响应消息中bandwidth字段为1200MB的记录，unavailable_zones字段包含cn-east-2b、cn-east-2a和cn-east-2d，表示在华东-上海2的可用区1、可用区2、可用区3都没有该资源。](tag:hc,hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest listProductsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }
        
        /// <summary>
        /// 查询转储任务列表
        ///
        /// 查询转储任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSinkTasksResponse> ListSinkTasksAsync(ListSinkTasksRequest listSinkTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , listSinkTasksRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSinkTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSinkTasksResponse>(response);
        }
        
        /// <summary>
        /// 重置Manager密码
        ///
        /// 重置Manager密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetManagerPasswordResponse> ResetManagerPasswordAsync(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetManagerPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>(response);
        }
        
        /// <summary>
        /// 重置消费组消费进度到指定位置
        ///
        /// Kafka实例不支持在线重置消费进度。在执行重置消费进度之前，必须停止被重置消费组客户端。
        /// 
        /// &gt; 停止待重置消费组客户端，然后等待一段时间（即ConsumerConfig.SESSION_TIMEOUT_MS_CONFIG配置的时间，默认为1000毫秒）后，服务端才认为此消费组客户端已下线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetMessageOffsetResponse> ResetMessageOffsetAsync(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group" , resetMessageOffsetRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }
        
        /// <summary>
        /// 重置用户密码
        ///
        /// 重置用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetUserPasswrodResponse> ResetUserPasswrodAsync(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name" , resetUserPasswrodRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>(response);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeEngineInstanceResponse> ResizeEngineInstanceAsync(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , resizeEngineInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id" , resizeEngineInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeEngineInstanceResponse>(response);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。[当前通过调用API，只支持按需实例进行实例规格变更。](tag:hc,hk,hws,hws_hk,ctc,sbc,hk_sbc,cmcc,hws_eu)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }
        
        /// <summary>
        /// 重启Manager
        ///
        /// 重启Manager。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartManagerResponse> RestartManagerAsync(RestartManagerRequest restartManagerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartManagerRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RestartManagerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id" , showBackgroundTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showCesHierarchyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCesHierarchyResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka集群元数据信息
        ///
        /// 查询Kafka集群元数据信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showClusterRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka实例的协调器信息
        ///
        /// 查询Kafka实例的协调器信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCoordinatorsResponse> ShowCoordinatorsAsync(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showCoordinatorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCoordinatorsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        ///
        /// 查询实例的扩容规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEngineInstanceExtendProductInfoResponse> ShowEngineInstanceExtendProductInfoAsync(ShowEngineInstanceExtendProductInfoRequest showEngineInstanceExtendProductInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , showEngineInstanceExtendProductInfoRequest.Engine.ToString());
            urlParam.Add("instance_id" , showEngineInstanceExtendProductInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEngineInstanceExtendProductInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEngineInstanceExtendProductInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询消费组信息
        ///
        /// 查询消费组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupsResponse> ShowGroupsAsync(ShowGroupsRequest showGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group" , showGroupsRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowGroupsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        ///
        /// 查询实例的扩容规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceExtendProductInfoResponse> ShowInstanceExtendProductInfoAsync(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceExtendProductInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询消息
        ///
        /// 查询消息的偏移量和消息内容。
        /// 先根据时间戳查询消息的偏移量，再根据偏移量查询消息内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceMessagesResponse> ShowInstanceMessagesAsync(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceMessagesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka实例Topic详细信息(单个实例调用不要超过1s一次)
        ///
        /// 查询Kafka实例Topic详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceTopicDetailResponse> ShowInstanceTopicDetailAsync(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic" , showInstanceTopicDetailRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表。
        /// 
        /// Kafka实例开启SASL功能时，才支持多用户管理的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceUsersResponse> ShowInstanceUsersAsync(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKafkaProjectTagsResponse> ShowKafkaProjectTagsAsync(ShowKafkaProjectTagsRequest showKafkaProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKafkaTagsResponse> ShowKafkaTagsAsync(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showKafkaTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询topic的磁盘存储情况
        ///
        /// 查询topic在Broker上磁盘占用情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKafkaTopicPartitionDiskusageResponse> ShowKafkaTopicPartitionDiskusageAsync(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMaintainWindowsResponse>(response);
        }
        
        /// <summary>
        /// 查询分区指定时间段的消息
        ///
        /// 查询分区指定时间段的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMessagesResponse> ShowMessagesAsync(ShowMessagesRequest showMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic" , showMessagesRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询分区最早消息的位置
        ///
        /// 查询分区最早消息的位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPartitionBeginningMessageResponse> ShowPartitionBeginningMessageAsync(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionBeginningMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询分区最新消息的位置
        ///
        /// 查询分区最新消息的位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPartitionEndMessageResponse> ShowPartitionEndMessageAsync(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionEndMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询分区指定偏移量的消息
        ///
        /// 查询分区指定偏移量的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPartitionMessageResponse> ShowPartitionMessageAsync(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询单个转储任务
        ///
        /// 查询单个转储任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSinkTaskDetailResponse> ShowSinkTaskDetailAsync(ShowSinkTaskDetailRequest showSinkTaskDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , showSinkTaskDetailRequest.ConnectorId.ToString());
            urlParam.Add("task_id" , showSinkTaskDetailRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSinkTaskDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSinkTaskDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询用户权限
        ///
        /// 查询用户权限。
        /// 
        /// Kafka实例开启SASL功能时，才支持多用户管理的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopicAccessPolicyResponse> ShowTopicAccessPolicyAsync(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name" , showTopicAccessPolicyRequest.TopicName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改实例信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest updateInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 开启或关闭实例自动创建topic功能
        ///
        /// 开启或关闭实例自动创建topic功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceAutoCreateTopicResponse> UpdateInstanceAutoCreateTopicAsync(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>(response);
        }
        
        /// <summary>
        /// 修改实例跨VPC访问的内网IP
        ///
        /// 修改实例跨VPC访问的内网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceCrossVpcIpResponse> UpdateInstanceCrossVpcIpAsync(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>(response);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic
        ///
        /// 修改Kafka实例Topic
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceTopicResponse> UpdateInstanceTopicAsync(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 修改转储任务的配额
        ///
        /// 修改转储任务的配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSinkTaskQuotaResponse> UpdateSinkTaskQuotaAsync(UpdateSinkTaskQuotaRequest updateSinkTaskQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , updateSinkTaskQuotaRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSinkTaskQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateSinkTaskQuotaResponse>(response);
        }
        
        /// <summary>
        /// 设置用户权限
        ///
        /// 设置用户权限。
        /// 
        /// Kafka实例开启SASL功能时，才支持多用户管理的功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTopicAccessPolicyResponse> UpdateTopicAccessPolicyAsync(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTopicAccessPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic分区的副本
        ///
        /// 修改Kafka实例Topic分区的副本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTopicReplicaResponse> UpdateTopicReplicaAsync(UpdateTopicReplicaRequest updateTopicReplicaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic" , updateTopicReplicaRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>(response);
        }
        
    }
}