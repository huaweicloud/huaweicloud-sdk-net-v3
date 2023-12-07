using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.RocketMQ.V2.Model;

namespace HuaweiCloud.SDK.RocketMQ.V2
{
    public partial class RocketMQClient : Client
    {
        public static ClientBuilder<RocketMQClient> NewBuilder()
        {
            return new ClientBuilder<RocketMQClient>();
        }

        
        /// <summary>
        /// 批量添加或删除实例标签
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateOrDeleteRocketmqTagResponse BatchCreateOrDeleteRocketmqTag(BatchCreateOrDeleteRocketmqTagRequest batchCreateOrDeleteRocketmqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRocketmqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRocketmqTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteRocketmqTagResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteRocketmqTagResponse> BatchCreateOrDeleteRocketmqTagInvoker(BatchCreateOrDeleteRocketmqTagRequest batchCreateOrDeleteRocketmqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRocketmqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRocketmqTagRequest);
            return new SyncInvoker<BatchCreateOrDeleteRocketmqTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteRocketmqTagResponse>);
        }
        
        /// <summary>
        /// 批量删除实例
        ///
        /// 批量删除实例。**实例删除后，实例中原有的数据将被删除，且没有备份，请谨慎操作。**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInstancesResponse BatchDeleteInstances(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstancesResponse> BatchDeleteInstancesInvoker(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstancesRequest);
            return new SyncInvoker<BatchDeleteInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstancesResponse>);
        }
        
        /// <summary>
        /// 批量修改消费组
        ///
        /// 批量修改消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateConsumerGroupResponse BatchUpdateConsumerGroup(BatchUpdateConsumerGroupRequest batchUpdateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchUpdateConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateConsumerGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateConsumerGroupResponse>(response);
        }

        public SyncInvoker<BatchUpdateConsumerGroupResponse> BatchUpdateConsumerGroupInvoker(BatchUpdateConsumerGroupRequest batchUpdateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchUpdateConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateConsumerGroupRequest);
            return new SyncInvoker<BatchUpdateConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 创建消费组或批量删除消费组
        ///
        /// 创建消费组或批量删除消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConsumerGroupOrBatchDeleteConsumerGroupResponse CreateConsumerGroupOrBatchDeleteConsumerGroup(CreateConsumerGroupOrBatchDeleteConsumerGroupRequest createConsumerGroupOrBatchDeleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConsumerGroupOrBatchDeleteConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupOrBatchDeleteConsumerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>(response);
        }

        public SyncInvoker<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse> CreateConsumerGroupOrBatchDeleteConsumerGroupInvoker(CreateConsumerGroupOrBatchDeleteConsumerGroupRequest createConsumerGroupOrBatchDeleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConsumerGroupOrBatchDeleteConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupOrBatchDeleteConsumerGroupRequest);
            return new SyncInvoker<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 该接口支持创建按需和包周期两种计费方式的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceByEngineResponse CreateInstanceByEngine(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceByEngineResponse>(response);
        }

        public SyncInvoker<CreateInstanceByEngineResponse> CreateInstanceByEngineInvoker(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            return new SyncInvoker<CreateInstanceByEngineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceByEngineResponse>);
        }
        
        /// <summary>
        /// 创建实例（按需）
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
        /// 新建元数据迁移任务
        ///
        /// 新建元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRocketMqMigrationTaskResponse CreateRocketMqMigrationTask(CreateRocketMqMigrationTaskRequest createRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRocketMqMigrationTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRocketMqMigrationTaskResponse>(response);
        }

        public SyncInvoker<CreateRocketMqMigrationTaskResponse> CreateRocketMqMigrationTaskInvoker(CreateRocketMqMigrationTaskRequest createRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRocketMqMigrationTaskRequest);
            return new SyncInvoker<CreateRocketMqMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRocketMqMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建用户。
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
        /// 删除指定消费组
        ///
        /// 删除指定消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest deleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", deleteConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConsumerGroupResponse>(response);
        }

        public SyncInvoker<DeleteConsumerGroupResponse> DeleteConsumerGroupInvoker(DeleteConsumerGroupRequest deleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", deleteConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupRequest);
            return new SyncInvoker<DeleteConsumerGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConsumerGroupResponse>);
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
        /// 删除元数据迁移任务
        ///
        /// 删除元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRocketMqMigrationTaskResponse DeleteRocketMqMigrationTask(DeleteRocketMqMigrationTaskRequest deleteRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRocketMqMigrationTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRocketMqMigrationTaskResponse>(response);
        }

        public SyncInvoker<DeleteRocketMqMigrationTaskResponse> DeleteRocketMqMigrationTaskInvoker(DeleteRocketMqMigrationTaskRequest deleteRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRocketMqMigrationTaskRequest);
            return new SyncInvoker<DeleteRocketMqMigrationTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRocketMqMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 删除用户
        ///
        /// 删除用户。
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
            return JsonUtils.DeSerialize<DeleteUserResponse>(response);
        }

        public SyncInvoker<DeleteUserResponse> DeleteUserInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new SyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteUserResponse>);
        }
        
        /// <summary>
        /// 导出死信消息
        ///
        /// 导出死信消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportDlqMessageResponse ExportDlqMessage(ExportDlqMessageRequest exportDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", exportDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportDlqMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            var exportDlqMessageResponse = JsonUtils.DeSerializeNull<ExportDlqMessageResponse>(response);
            exportDlqMessageResponse.Body = JsonUtils.DeSerializeList<Message>(response);
            return exportDlqMessageResponse;
        }

        public SyncInvoker<ExportDlqMessageResponse> ExportDlqMessageInvoker(ExportDlqMessageRequest exportDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", exportDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportDlqMessageRequest);
            return new SyncInvoker<ExportDlqMessageResponse>(this, "POST", request, response =>
            {
                var exportDlqMessageResponse = JsonUtils.DeSerializeNull<ExportDlqMessageResponse>(response);
                exportDlqMessageResponse.Body = JsonUtils.DeSerializeList<Message>(response);
                return exportDlqMessageResponse;
            });
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
        /// 查询代理列表
        ///
        /// 查询代理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBrokersResponse ListBrokers(ListBrokersRequest listBrokersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBrokersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/brokers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBrokersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBrokersResponse>(response);
        }

        public SyncInvoker<ListBrokersResponse> ListBrokersInvoker(ListBrokersRequest listBrokersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBrokersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/brokers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBrokersRequest);
            return new SyncInvoker<ListBrokersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBrokersResponse>);
        }
        
        /// <summary>
        /// 查询消费组的授权用户列表
        ///
        /// 查询消费组的授权用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConsumeGroupAccessPolicyResponse ListConsumeGroupAccessPolicy(ListConsumeGroupAccessPolicyRequest listConsumeGroupAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listConsumeGroupAccessPolicyRequest.Engine.ToString());
            urlParam.Add("instance_id", listConsumeGroupAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("group_id", listConsumeGroupAccessPolicyRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeGroupAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConsumeGroupAccessPolicyResponse>(response);
        }

        public SyncInvoker<ListConsumeGroupAccessPolicyResponse> ListConsumeGroupAccessPolicyInvoker(ListConsumeGroupAccessPolicyRequest listConsumeGroupAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listConsumeGroupAccessPolicyRequest.Engine.ToString());
            urlParam.Add("instance_id", listConsumeGroupAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("group_id", listConsumeGroupAccessPolicyRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeGroupAccessPolicyRequest);
            return new SyncInvoker<ListConsumeGroupAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConsumeGroupAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询消费组列表
        ///
        /// 查询消费组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConsumerGroupsResponse ListInstanceConsumerGroups(ListInstanceConsumerGroupsRequest listInstanceConsumerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConsumerGroupsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupsResponse> ListInstanceConsumerGroupsInvoker(ListInstanceConsumerGroupsRequest listInstanceConsumerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConsumerGroupsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            return new SyncInvoker<ListInstanceConsumerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询所有实例列表
        ///
        /// 查询租户的实例列表，支持按照条件查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstancesResponse ListInstances(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public SyncInvoker<ListInstancesResponse> ListInstancesInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new SyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
        }
        
        /// <summary>
        /// 查询消息轨迹
        ///
        /// 查询消息轨迹。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMessageTraceResponse ListMessageTrace(ListMessageTraceRequest listMessageTraceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessageTraceRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessageTraceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTraceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTraceResponse>(response);
        }

        public SyncInvoker<ListMessageTraceResponse> ListMessageTraceInvoker(ListMessageTraceRequest listMessageTraceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessageTraceRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessageTraceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTraceRequest);
            return new SyncInvoker<ListMessageTraceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTraceResponse>);
        }
        
        /// <summary>
        /// 查询消息
        ///
        /// 查询消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMessagesResponse ListMessages(ListMessagesRequest listMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessagesRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMessagesResponse>(response);
        }

        public SyncInvoker<ListMessagesResponse> ListMessagesInvoker(ListMessagesRequest listMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessagesRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessagesRequest);
            return new SyncInvoker<ListMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessagesResponse>);
        }
        
        /// <summary>
        /// 查询实例下所有迁移任务或查询指定迁移任务信息
        ///
        /// 1. 查询实例下所有迁移任务
        /// 2. 查询指定迁移任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRocketMqMigrationTaskResponse ListRocketMqMigrationTask(ListRocketMqMigrationTaskRequest listRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketMqMigrationTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRocketMqMigrationTaskResponse>(response);
        }

        public SyncInvoker<ListRocketMqMigrationTaskResponse> ListRocketMqMigrationTaskInvoker(ListRocketMqMigrationTaskRequest listRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketMqMigrationTaskRequest);
            return new SyncInvoker<ListRocketMqMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRocketMqMigrationTaskResponse>);
        }
        
        /// <summary>
        /// 查询主题的授权用户列表
        ///
        /// 查询主题的授权用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicAccessPolicyResponse ListTopicAccessPolicy(ListTopicAccessPolicyRequest listTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicAccessPolicyRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicAccessPolicyResponse>(response);
        }

        public SyncInvoker<ListTopicAccessPolicyResponse> ListTopicAccessPolicyInvoker(ListTopicAccessPolicyRequest listTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicAccessPolicyRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAccessPolicyRequest);
            return new SyncInvoker<ListTopicAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 查询用户列表。
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
        /// 重置消费进度
        ///
        /// 重置消费进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetConsumeOffsetResponse ResetConsumeOffset(ResetConsumeOffsetRequest resetConsumeOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resetConsumeOffsetRequest.Engine.ToString());
            urlParam.Add("instance_id", resetConsumeOffsetRequest.InstanceId.ToString());
            urlParam.Add("group_id", resetConsumeOffsetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConsumeOffsetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetConsumeOffsetResponse>(response);
        }

        public SyncInvoker<ResetConsumeOffsetResponse> ResetConsumeOffsetInvoker(ResetConsumeOffsetRequest resetConsumeOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resetConsumeOffsetRequest.Engine.ToString());
            urlParam.Add("instance_id", resetConsumeOffsetRequest.InstanceId.ToString());
            urlParam.Add("group_id", resetConsumeOffsetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConsumeOffsetRequest);
            return new SyncInvoker<ResetConsumeOffsetResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetConsumeOffsetResponse>);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。
        /// 
        /// [**当前通过调用API，只支持按需实例进行实例规格变更。**](tag:hws,hws_hk,ctc)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public SyncInvoker<ResizeInstanceResponse> ResizeInstanceInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new SyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
        }
        
        /// <summary>
        /// 重发死信消息
        ///
        /// 重发死信消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendDlqMessageResponse SendDlqMessage(SendDlqMessageRequest sendDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", sendDlqMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", sendDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/deadletter-resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDlqMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendDlqMessageResponse>(response);
        }

        public SyncInvoker<SendDlqMessageResponse> SendDlqMessageInvoker(SendDlqMessageRequest sendDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", sendDlqMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", sendDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/deadletter-resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDlqMessageRequest);
            return new SyncInvoker<SendDlqMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<SendDlqMessageResponse>);
        }
        
        /// <summary>
        /// 查询消费者列表
        ///
        /// 查询消费组内消费者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConsumerConnectionsResponse ShowConsumerConnections(ShowConsumerConnectionsRequest showConsumerConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerConnectionsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerConnectionsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rocketmq/{project_id}/instances/{instance_id}/groups/{group}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerConnectionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConsumerConnectionsResponse>(response);
        }

        public SyncInvoker<ShowConsumerConnectionsResponse> ShowConsumerConnectionsInvoker(ShowConsumerConnectionsRequest showConsumerConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerConnectionsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerConnectionsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rocketmq/{project_id}/instances/{instance_id}/groups/{group}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerConnectionsRequest);
            return new SyncInvoker<ShowConsumerConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConsumerConnectionsResponse>);
        }
        
        /// <summary>
        /// 查询消费列表或详情
        ///
        /// 查询消费列表或详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConsumerListOrDetailsResponse ShowConsumerListOrDetails(ShowConsumerListOrDetailsRequest showConsumerListOrDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerListOrDetailsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerListOrDetailsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerListOrDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConsumerListOrDetailsResponse>(response);
        }

        public SyncInvoker<ShowConsumerListOrDetailsResponse> ShowConsumerListOrDetailsInvoker(ShowConsumerListOrDetailsRequest showConsumerListOrDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerListOrDetailsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerListOrDetailsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerListOrDetailsRequest);
            return new SyncInvoker<ShowConsumerListOrDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConsumerListOrDetailsResponse>);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        ///
        /// 查询实例的扩容规格列表。
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
        /// 查询指定消费组
        ///
        /// 查询指定消费组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupResponse ShowGroup(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
        }

        public SyncInvoker<ShowGroupResponse> ShowGroupInvoker(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            return new SyncInvoker<ShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupResponse>);
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
        /// 查询RocketMQ配置
        ///
        /// 该接口用于查询RocketMQ配置，若成功则返回配置的相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRocketMqConfigsResponse ShowRocketMqConfigs(ShowRocketMqConfigsRequest showRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketMqConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketMqConfigsResponse>(response);
        }

        public SyncInvoker<ShowRocketMqConfigsResponse> ShowRocketMqConfigsInvoker(ShowRocketMqConfigsRequest showRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketMqConfigsRequest);
            return new SyncInvoker<ShowRocketMqConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketMqConfigsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRocketmqProjectTagsResponse ShowRocketmqProjectTags(ShowRocketmqProjectTagsRequest showRocketmqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketmqProjectTagsResponse>(response);
        }

        public SyncInvoker<ShowRocketmqProjectTagsResponse> ShowRocketmqProjectTagsInvoker(ShowRocketmqProjectTagsRequest showRocketmqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqProjectTagsRequest);
            return new SyncInvoker<ShowRocketmqProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketmqProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRocketmqTagsResponse ShowRocketmqTags(ShowRocketmqTagsRequest showRocketmqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketmqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketmqTagsResponse>(response);
        }

        public SyncInvoker<ShowRocketmqTagsResponse> ShowRocketmqTagsInvoker(ShowRocketmqTagsRequest showRocketmqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketmqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqTagsRequest);
            return new SyncInvoker<ShowRocketmqTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketmqTagsResponse>);
        }
        
        /// <summary>
        /// 查询用户详情
        ///
        /// 查询用户详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserResponse ShowUser(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", showUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }

        public SyncInvoker<ShowUserResponse> ShowUserInvoker(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", showUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            return new SyncInvoker<ShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserResponse>);
        }
        
        /// <summary>
        /// 修改消费组
        ///
        /// 修改指定消费组参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateConsumerGroupResponse UpdateConsumerGroup(UpdateConsumerGroupRequest updateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConsumerGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConsumerGroupResponse>(response);
        }

        public SyncInvoker<UpdateConsumerGroupResponse> UpdateConsumerGroupInvoker(UpdateConsumerGroupRequest updateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConsumerGroupRequest);
            return new SyncInvoker<UpdateConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConsumerGroupResponse>);
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
        /// 修改RocketMQ配置
        ///
        /// 该接口用于修改RocketMQ配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRocketMqConfigsResponse UpdateRocketMqConfigs(UpdateRocketMqConfigsRequest updateRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRocketMqConfigsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRocketMqConfigsResponse>(response);
        }

        public SyncInvoker<UpdateRocketMqConfigsResponse> UpdateRocketMqConfigsInvoker(UpdateRocketMqConfigsRequest updateRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRocketMqConfigsRequest);
            return new SyncInvoker<UpdateRocketMqConfigsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRocketMqConfigsResponse>);
        }
        
        /// <summary>
        /// 修改用户参数
        ///
        /// 修改用户参数。
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
        /// 消费验证
        ///
        /// 消费验证。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateConsumedMessageResponse ValidateConsumedMessage(ValidateConsumedMessageRequest validateConsumedMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", validateConsumedMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", validateConsumedMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConsumedMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateConsumedMessageResponse>(response);
        }

        public SyncInvoker<ValidateConsumedMessageResponse> ValidateConsumedMessageInvoker(ValidateConsumedMessageRequest validateConsumedMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", validateConsumedMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", validateConsumedMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConsumedMessageRequest);
            return new SyncInvoker<ValidateConsumedMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateConsumedMessageResponse>);
        }
        
        /// <summary>
        /// 创建主题或批量删除主题
        ///
        /// 创建主题或批量删除主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTopicOrBatchDeleteTopicResponse CreateTopicOrBatchDeleteTopic(CreateTopicOrBatchDeleteTopicRequest createTopicOrBatchDeleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createTopicOrBatchDeleteTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTopicOrBatchDeleteTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTopicOrBatchDeleteTopicResponse>(response);
        }

        public SyncInvoker<CreateTopicOrBatchDeleteTopicResponse> CreateTopicOrBatchDeleteTopicInvoker(CreateTopicOrBatchDeleteTopicRequest createTopicOrBatchDeleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createTopicOrBatchDeleteTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTopicOrBatchDeleteTopicRequest);
            return new SyncInvoker<CreateTopicOrBatchDeleteTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTopicOrBatchDeleteTopicResponse>);
        }
        
        /// <summary>
        /// 删除指定主题
        ///
        /// 删除指定主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", deleteTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTopicResponse>(response);
        }

        public SyncInvoker<DeleteTopicResponse> DeleteTopicInvoker(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", deleteTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            return new SyncInvoker<DeleteTopicResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTopicResponse>);
        }
        
        /// <summary>
        /// 查询主题消费组列表
        ///
        /// 查询主题消费组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConsumerGroupOfTopicResponse ListConsumerGroupOfTopic(ListConsumerGroupOfTopicRequest listConsumerGroupOfTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConsumerGroupOfTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", listConsumerGroupOfTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupOfTopicRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConsumerGroupOfTopicResponse>(response);
        }

        public SyncInvoker<ListConsumerGroupOfTopicResponse> ListConsumerGroupOfTopicInvoker(ListConsumerGroupOfTopicRequest listConsumerGroupOfTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConsumerGroupOfTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", listConsumerGroupOfTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupOfTopicRequest);
            return new SyncInvoker<ListConsumerGroupOfTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConsumerGroupOfTopicResponse>);
        }
        
        /// <summary>
        /// 查询主题列表
        ///
        /// 该接口用于查询指定RocketMQ实例的Topic列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRocketInstanceTopicsResponse ListRocketInstanceTopics(ListRocketInstanceTopicsRequest listRocketInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketInstanceTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRocketInstanceTopicsResponse>(response);
        }

        public SyncInvoker<ListRocketInstanceTopicsResponse> ListRocketInstanceTopicsInvoker(ListRocketInstanceTopicsRequest listRocketInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketInstanceTopicsRequest);
            return new SyncInvoker<ListRocketInstanceTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRocketInstanceTopicsResponse>);
        }
        
        /// <summary>
        /// 查询单个主题
        ///
        /// 查询单个主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOneTopicResponse ShowOneTopic(ShowOneTopicRequest showOneTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOneTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", showOneTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOneTopicRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOneTopicResponse>(response);
        }

        public SyncInvoker<ShowOneTopicResponse> ShowOneTopicInvoker(ShowOneTopicRequest showOneTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOneTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", showOneTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOneTopicRequest);
            return new SyncInvoker<ShowOneTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOneTopicResponse>);
        }
        
        /// <summary>
        /// 查询主题的消息数
        ///
        /// 查询主题的消息数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTopicStatusResponse ShowTopicStatus(ShowTopicStatusRequest showTopicStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicStatusRequest.InstanceId.ToString());
            urlParam.Add("topic", showTopicStatusRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopicStatusResponse>(response);
        }

        public SyncInvoker<ShowTopicStatusResponse> ShowTopicStatusInvoker(ShowTopicStatusRequest showTopicStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicStatusRequest.InstanceId.ToString());
            urlParam.Add("topic", showTopicStatusRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicStatusRequest);
            return new SyncInvoker<ShowTopicStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopicStatusResponse>);
        }
        
        /// <summary>
        /// 修改主题
        ///
        /// 修改主题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTopicResponse UpdateTopic(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTopicResponse>(response);
        }

        public SyncInvoker<UpdateTopicResponse> UpdateTopicInvoker(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicRequest);
            return new SyncInvoker<UpdateTopicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTopicResponse>);
        }
        
    }
}