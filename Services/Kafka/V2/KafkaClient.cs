using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Kafka.V2.Model;

namespace HuaweiCloud.SDK.Kafka.V2
{
    public partial class KafkaClient : Client
    {
        public static ClientBuilder<KafkaClient> NewBuilder()
        {
            return new ClientBuilder<KafkaClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        /// </summary>
        public BatchCreateOrDeleteKafkaTagResponse BatchCreateOrDeleteKafkaTag(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例批量删除Topic
        /// </summary>
        public BatchDeleteInstanceTopicResponse BatchDeleteInstanceTopic(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 批量删除用户
        /// </summary>
        public BatchDeleteInstanceUsersResponse BatchDeleteInstanceUsers(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchDeleteInstanceUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>(response);
        }
        
        /// <summary>
        /// 批量重启或删除实例
        /// </summary>
        public BatchRestartOrDeleteInstancesResponse BatchRestartOrDeleteInstances(BatchRestartOrDeleteInstancesRequest batchRestartOrDeleteInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestartOrDeleteInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchRestartOrDeleteInstancesResponse>(response);
        }
        
        /// <summary>
        /// 创建实例的转储节点
        /// </summary>
        public CreateConnectorResponse CreateConnector(CreateConnectorRequest createConnectorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createConnectorRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateConnectorResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例创建Topic
        /// </summary>
        public CreateInstanceTopicResponse CreateInstanceTopic(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 创建用户
        /// </summary>
        public CreateInstanceUserResponse CreateInstanceUser(CreateInstanceUserRequest createInstanceUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createInstanceUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateInstanceUserResponse>(response);
        }
        
        /// <summary>
        /// 新增Kafka实例指定Topic分区
        /// </summary>
        public CreatePartitionResponse CreatePartition(CreatePartitionRequest createPartitionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createPartitionRequest.InstanceId.ToString());
            urlParam.Add("topic" , createPartitionRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreatePartitionResponse>(response);
        }
        
        /// <summary>
        /// 创建实例（按需）
        /// </summary>
        public CreatePostPaidInstanceResponse CreatePostPaidInstance(CreatePostPaidInstanceRequest createPostPaidInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePostPaidInstanceResponse>(response);
        }
        
        /// <summary>
        /// 创建转储任务
        /// </summary>
        public CreateSinkTaskResponse CreateSinkTask(CreateSinkTaskRequest createSinkTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , createSinkTaskRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSinkTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSinkTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除后台任务管理中的指定记录
        /// </summary>
        public DeleteBackgroundTaskResponse DeleteBackgroundTask(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id" , deleteBackgroundTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
        }
        
        /// <summary>
        /// 删除指定的实例
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }
        
        /// <summary>
        /// 删除单个转储任务
        /// </summary>
        public DeleteSinkTaskResponse DeleteSinkTask(DeleteSinkTaskRequest deleteSinkTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , deleteSinkTaskRequest.ConnectorId.ToString());
            urlParam.Add("task_id" , deleteSinkTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSinkTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSinkTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询可用区信息
        /// </summary>
        public ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest listAvailableZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/available-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAvailableZonesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的后台任务列表
        /// </summary>
        public ListBackgroundTasksResponse ListBackgroundTasks(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBackgroundTasksRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBackgroundTasksResponse>(response);
        }
        
        /// <summary>
        /// Kafka实例查询Topic
        /// </summary>
        public ListInstanceTopicsResponse ListInstanceTopics(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listInstanceTopicsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstanceTopicsResponse>(response);
        }
        
        /// <summary>
        /// 查询所有实例列表
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询产品规格列表
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/products",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }
        
        /// <summary>
        /// 查询转储任务列表
        /// </summary>
        public ListSinkTasksResponse ListSinkTasks(ListSinkTasksRequest listSinkTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , listSinkTasksRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSinkTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSinkTasksResponse>(response);
        }
        
        /// <summary>
        /// 重置Manager密码
        /// </summary>
        public ResetManagerPasswordResponse ResetManagerPassword(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetManagerPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>(response);
        }
        
        /// <summary>
        /// 重置消费组消费进度到指定位置
        /// </summary>
        public ResetMessageOffsetResponse ResetMessageOffset(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group" , resetMessageOffsetRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>(response);
        }
        
        /// <summary>
        /// 重置密码
        /// </summary>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest resetPasswordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetPasswordRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }
        
        /// <summary>
        /// 重置用户密码
        /// </summary>
        public ResetUserPasswrodResponse ResetUserPasswrod(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name" , resetUserPasswrodRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>(response);
        }
        
        /// <summary>
        /// 实例规格变更
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , resizeInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }
        
        /// <summary>
        /// 重启Manager
        /// </summary>
        public RestartManagerResponse RestartManager(RestartManagerRequest restartManagerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , restartManagerRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<RestartManagerResponse>(response);
        }
        
        /// <summary>
        /// 查询后台任务管理中的指定记录
        /// </summary>
        public ShowBackgroundTaskResponse ShowBackgroundTask(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showBackgroundTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id" , showBackgroundTaskRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询实例在CES的监控层级关系
        /// </summary>
        public ShowCesHierarchyResponse ShowCesHierarchy(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showCesHierarchyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCesHierarchyResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka集群元数据信息
        /// </summary>
        public ShowClusterResponse ShowCluster(ShowClusterRequest showClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showClusterRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka实例的协调器信息
        /// </summary>
        public ShowCoordinatorsResponse ShowCoordinators(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showCoordinatorsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCoordinatorsResponse>(response);
        }
        
        /// <summary>
        /// 查询消费组信息
        /// </summary>
        public ShowGroupsResponse ShowGroups(ShowGroupsRequest showGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group" , showGroupsRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定实例
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        /// </summary>
        public ShowInstanceExtendProductInfoResponse ShowInstanceExtendProductInfo(ShowInstanceExtendProductInfoRequest showInstanceExtendProductInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceExtendProductInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/extend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceExtendProductInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceExtendProductInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询消息
        /// </summary>
        public ShowInstanceMessagesResponse ShowInstanceMessages(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceMessagesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询Kafka实例Topic详细信息
        /// </summary>
        public ShowInstanceTopicDetailResponse ShowInstanceTopicDetail(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic" , showInstanceTopicDetailRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询用户列表
        /// </summary>
        public ShowInstanceUsersResponse ShowInstanceUsers(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showInstanceUsersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceUsersResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        /// </summary>
        public ShowKafkaProjectTagsResponse ShowKafkaProjectTags(ShowKafkaProjectTagsRequest showKafkaProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例标签
        /// </summary>
        public ShowKafkaTagsResponse ShowKafkaTags(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showKafkaTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询topic的磁盘存储情况
        /// </summary>
        public ShowKafkaTopicPartitionDiskusageResponse ShowKafkaTopicPartitionDiskusage(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>(response);
        }
        
        /// <summary>
        /// 查询维护时间窗时间段
        /// </summary>
        public ShowMaintainWindowsResponse ShowMaintainWindows(ShowMaintainWindowsRequest showMaintainWindowsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/instances/maintain-windows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMaintainWindowsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMaintainWindowsResponse>(response);
        }
        
        /// <summary>
        /// 查询分区指定时间段的消息
        /// </summary>
        public ShowMessagesResponse ShowMessages(ShowMessagesRequest showMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic" , showMessagesRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询分区最早消息的位置
        /// </summary>
        public ShowPartitionBeginningMessageResponse ShowPartitionBeginningMessage(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionBeginningMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询分区最新消息的位置
        /// </summary>
        public ShowPartitionEndMessageResponse ShowPartitionEndMessage(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionEndMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询分区指定偏移量的消息
        /// </summary>
        public ShowPartitionMessageResponse ShowPartitionMessage(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic" , showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition" , showPartitionMessageRequest.Partition.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPartitionMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询单个转储任务
        /// </summary>
        public ShowSinkTaskDetailResponse ShowSinkTaskDetail(ShowSinkTaskDetailRequest showSinkTaskDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , showSinkTaskDetailRequest.ConnectorId.ToString());
            urlParam.Add("task_id" , showSinkTaskDetailRequest.TaskId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSinkTaskDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSinkTaskDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询用户权限
        /// </summary>
        public ShowTopicAccessPolicyResponse ShowTopicAccessPolicy(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name" , showTopicAccessPolicyRequest.TopicName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改实例信息
        /// </summary>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest updateInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 开启或关闭实例自动创建topic功能
        /// </summary>
        public UpdateInstanceAutoCreateTopicResponse UpdateInstanceAutoCreateTopic(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>(response);
        }
        
        /// <summary>
        /// 修改实例跨VPC访问的内网IP
        /// </summary>
        public UpdateInstanceCrossVpcIpResponse UpdateInstanceCrossVpcIp(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>(response);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic
        /// </summary>
        public UpdateInstanceTopicResponse UpdateInstanceTopic(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>(response);
        }
        
        /// <summary>
        /// 修改转储任务的配额
        /// </summary>
        public UpdateSinkTaskQuotaResponse UpdateSinkTaskQuota(UpdateSinkTaskQuotaRequest updateSinkTaskQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id" , updateSinkTaskQuotaRequest.ConnectorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSinkTaskQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateSinkTaskQuotaResponse>(response);
        }
        
        /// <summary>
        /// 设置用户权限
        /// </summary>
        public UpdateTopicAccessPolicyResponse UpdateTopicAccessPolicy(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTopicAccessPolicyRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic分区的副本
        /// </summary>
        public UpdateTopicReplicaResponse UpdateTopicReplica(UpdateTopicReplicaRequest updateTopicReplicaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic" , updateTopicReplicaRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>(response);
        }
        
    }
}