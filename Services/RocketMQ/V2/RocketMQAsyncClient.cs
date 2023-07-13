using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.RocketMQ.V2.Model;

namespace HuaweiCloud.SDK.RocketMQ.V2
{
    public partial class RocketMQAsyncClient : Client
    {
        public static ClientBuilder<RocketMQAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RocketMQAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateOrDeleteRocketmqTagResponse> BatchCreateOrDeleteRocketmqTagAsync(BatchCreateOrDeleteRocketmqTagRequest batchCreateOrDeleteRocketmqTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchCreateOrDeleteRocketmqTagRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRocketmqTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteRocketmqTagResponse>(response);
        }
        
        /// <summary>
        /// 批量删除实例
        ///
        /// 批量删除实例。**实例删除后，实例中原有的数据将被删除，且没有备份，请谨慎操作。**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInstancesResponse> BatchDeleteInstancesAsync(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }
        
        /// <summary>
        /// 批量修改消费组
        ///
        /// 批量修改消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateConsumerGroupResponse> BatchUpdateConsumerGroupAsync(BatchUpdateConsumerGroupRequest batchUpdateConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , batchUpdateConsumerGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建消费组或批量删除消费组
        ///
        /// 创建消费组或批量删除消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse> CreateConsumerGroupOrBatchDeleteConsumerGroupAsync(CreateConsumerGroupOrBatchDeleteConsumerGroupRequest createConsumerGroupOrBatchDeleteConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createConsumerGroupOrBatchDeleteConsumerGroupRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupOrBatchDeleteConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建实例
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
        /// 创建实例（按需）
        ///
        /// 创建实例，该接口创建的实例为按需计费的方式。
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
        /// 新建元数据迁移任务
        ///
        /// 新建元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRocketMqMigrationTaskResponse> CreateRocketMqMigrationTaskAsync(CreateRocketMqMigrationTaskRequest createRocketMqMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createRocketMqMigrationTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRocketMqMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            CreateRocketMqMigrationTaskResponse createRocketMqMigrationTaskResponse = JsonUtils.DeSerializeNull<CreateRocketMqMigrationTaskResponse>(response);
            return createRocketMqMigrationTaskResponse;
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }
        
        /// <summary>
        /// 删除指定消费组
        ///
        /// 删除指定消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest deleteConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group" , deleteConsumerGroupRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteConsumerGroupResponse>(response);
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
        /// 删除元数据迁移任务
        ///
        /// 删除元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRocketMqMigrationTaskResponse> DeleteRocketMqMigrationTaskAsync(DeleteRocketMqMigrationTaskRequest deleteRocketMqMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteRocketMqMigrationTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRocketMqMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteRocketMqMigrationTaskResponse deleteRocketMqMigrationTaskResponse = JsonUtils.DeSerializeNull<DeleteRocketMqMigrationTaskResponse>(response);
            return deleteRocketMqMigrationTaskResponse;
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 删除用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , deleteUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteUserResponse>(response);
        }
        
        /// <summary>
        /// 导出死信消息
        ///
        /// 导出死信消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportDlqMessageResponse> ExportDlqMessageAsync(ExportDlqMessageRequest exportDlqMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , exportDlqMessageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/export",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportDlqMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            ExportDlqMessageResponse exportDlqMessageResponse = JsonUtils.DeSerializeNull<ExportDlqMessageResponse>(response);
            exportDlqMessageResponse.Body = JsonUtils.DeSerializeList<Message>(response);
            return exportDlqMessageResponse;
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
        /// 查询代理列表
        ///
        /// 查询代理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBrokersResponse> ListBrokersAsync(ListBrokersRequest listBrokersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listBrokersRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/brokers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBrokersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBrokersResponse>(response);
        }
        
        /// <summary>
        /// 查询消费组的授权用户列表
        ///
        /// 查询消费组的授权用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConsumeGroupAccessPolicyResponse> ListConsumeGroupAccessPolicyAsync(ListConsumeGroupAccessPolicyRequest listConsumeGroupAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , listConsumeGroupAccessPolicyRequest.Engine.ToString());
            urlParam.Add("instance_id" , listConsumeGroupAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("group_id" , listConsumeGroupAccessPolicyRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeGroupAccessPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConsumeGroupAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询消费组列表
        ///
        /// 查询消费组列表。
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
        /// 查询消息轨迹
        ///
        /// 查询消息轨迹。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMessageTraceResponse> ListMessageTraceAsync(ListMessageTraceRequest listMessageTraceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , listMessageTraceRequest.Engine.ToString());
            urlParam.Add("instance_id" , listMessageTraceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/trace",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTraceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTraceResponse>(response);
        }
        
        /// <summary>
        /// 查询消息
        ///
        /// 查询消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMessagesResponse> ListMessagesAsync(ListMessagesRequest listMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , listMessagesRequest.Engine.ToString());
            urlParam.Add("instance_id" , listMessagesRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询实例下所有迁移任务或查询指定迁移任务信息
        ///
        /// 1. 查询实例下所有迁移任务
        /// 2. 查询指定迁移任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRocketMqMigrationTaskResponse> ListRocketMqMigrationTaskAsync(ListRocketMqMigrationTaskRequest listRocketMqMigrationTaskRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRocketMqMigrationTaskRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketMqMigrationTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRocketMqMigrationTaskResponse>(response);
        }
        
        /// <summary>
        /// 查询主题的授权用户列表
        ///
        /// 查询主题的授权用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicAccessPolicyResponse> ListTopicAccessPolicyAsync(ListTopicAccessPolicyRequest listTopicAccessPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic" , listTopicAccessPolicyRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/accesspolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAccessPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicAccessPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserResponse> ListUserAsync(ListUserRequest listUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listUserRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUserResponse>(response);
        }
        
        /// <summary>
        /// 重置消费进度
        ///
        /// 重置消费进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetConsumeOffsetResponse> ResetConsumeOffsetAsync(ResetConsumeOffsetRequest resetConsumeOffsetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , resetConsumeOffsetRequest.Engine.ToString());
            urlParam.Add("instance_id" , resetConsumeOffsetRequest.InstanceId.ToString());
            urlParam.Add("group_id" , resetConsumeOffsetRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/reset-message-offset",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConsumeOffsetRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResetConsumeOffsetResponse>(response);
        }
        
        /// <summary>
        /// 重发死信消息
        ///
        /// 重发死信消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendDlqMessageResponse> SendDlqMessageAsync(SendDlqMessageRequest sendDlqMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , sendDlqMessageRequest.Engine.ToString());
            urlParam.Add("instance_id" , sendDlqMessageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/deadletter-resend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDlqMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SendDlqMessageResponse>(response);
        }
        
        /// <summary>
        /// 查询消费者列表
        ///
        /// 查询消费组内消费者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConsumerConnectionsResponse> ShowConsumerConnectionsAsync(ShowConsumerConnectionsRequest showConsumerConnectionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showConsumerConnectionsRequest.InstanceId.ToString());
            urlParam.Add("group" , showConsumerConnectionsRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/rocketmq/{project_id}/instances/{instance_id}/groups/{group}/clients",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerConnectionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowConsumerConnectionsResponse>(response);
        }
        
        /// <summary>
        /// 查询消费列表或详情
        ///
        /// 查询消费列表或详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowConsumerListOrDetailsResponse> ShowConsumerListOrDetailsAsync(ShowConsumerListOrDetailsRequest showConsumerListOrDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showConsumerListOrDetailsRequest.InstanceId.ToString());
            urlParam.Add("group" , showConsumerListOrDetailsRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerListOrDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowConsumerListOrDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定消费组
        ///
        /// 查询指定消费组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupResponse> ShowGroupAsync(ShowGroupRequest showGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showGroupRequest.InstanceId.ToString());
            urlParam.Add("group" , showGroupRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
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
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRocketmqProjectTagsResponse> ShowRocketmqProjectTagsAsync(ShowRocketmqProjectTagsRequest showRocketmqProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRocketmqProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRocketmqTagsResponse> ShowRocketmqTagsAsync(ShowRocketmqTagsRequest showRocketmqTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showRocketmqTagsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRocketmqTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 查询用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserResponse> ShowUserAsync(ShowUserRequest showUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , showUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }
        
        /// <summary>
        /// 修改消费组
        ///
        /// 修改指定消费组参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest updateConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group" , updateConsumerGroupRequest.Group.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateConsumerGroupResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateInstanceRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }
        
        /// <summary>
        /// 修改用户参数
        ///
        /// 修改用户参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateUserRequest.InstanceId.ToString());
            urlParam.Add("user_name" , updateUserRequest.UserName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }
        
        /// <summary>
        /// 消费验证
        ///
        /// 消费验证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateConsumedMessageResponse> ValidateConsumedMessageAsync(ValidateConsumedMessageRequest validateConsumedMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("engine" , validateConsumedMessageRequest.Engine.ToString());
            urlParam.Add("instance_id" , validateConsumedMessageRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/resend",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConsumedMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ValidateConsumedMessageResponse>(response);
        }
        
        /// <summary>
        /// 创建主题或批量删除主题
        ///
        /// 创建主题或批量删除主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTopicOrBatchDeleteTopicResponse> CreateTopicOrBatchDeleteTopicAsync(CreateTopicOrBatchDeleteTopicRequest createTopicOrBatchDeleteTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , createTopicOrBatchDeleteTopicRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTopicOrBatchDeleteTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTopicOrBatchDeleteTopicResponse>(response);
        }
        
        /// <summary>
        /// 删除指定主题
        ///
        /// 删除指定主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest deleteTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , deleteTopicRequest.InstanceId.ToString());
            urlParam.Add("topic" , deleteTopicRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTopicResponse>(response);
        }
        
        /// <summary>
        /// 查询主题消费组列表
        ///
        /// 查询主题消费组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConsumerGroupOfTopicResponse> ListConsumerGroupOfTopicAsync(ListConsumerGroupOfTopicRequest listConsumerGroupOfTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listConsumerGroupOfTopicRequest.InstanceId.ToString());
            urlParam.Add("topic" , listConsumerGroupOfTopicRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupOfTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConsumerGroupOfTopicResponse>(response);
        }
        
        /// <summary>
        /// 查询主题列表
        ///
        /// 该接口用于查询指定RocketMQ实例的Topic列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRocketInstanceTopicsResponse> ListRocketInstanceTopicsAsync(ListRocketInstanceTopicsRequest listRocketInstanceTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listRocketInstanceTopicsRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketInstanceTopicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRocketInstanceTopicsResponse>(response);
        }
        
        /// <summary>
        /// 查询单个主题
        ///
        /// 查询单个主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOneTopicResponse> ShowOneTopicAsync(ShowOneTopicRequest showOneTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showOneTopicRequest.InstanceId.ToString());
            urlParam.Add("topic" , showOneTopicRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOneTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOneTopicResponse>(response);
        }
        
        /// <summary>
        /// 查询主题的消息数
        ///
        /// 查询主题的消息数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopicStatusResponse> ShowTopicStatusAsync(ShowTopicStatusRequest showTopicStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showTopicStatusRequest.InstanceId.ToString());
            urlParam.Add("topic" , showTopicStatusRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTopicStatusResponse>(response);
        }
        
        /// <summary>
        /// 修改主题
        ///
        /// 修改主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest updateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , updateTopicRequest.InstanceId.ToString());
            urlParam.Add("topic" , updateTopicRequest.Topic.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTopicResponse>(response);
        }
        
    }
}