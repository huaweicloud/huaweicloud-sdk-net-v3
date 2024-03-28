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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRocketmqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRocketmqTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteRocketmqTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteRocketmqTagResponse> BatchCreateOrDeleteRocketmqTagAsyncInvoker(BatchCreateOrDeleteRocketmqTagRequest batchCreateOrDeleteRocketmqTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteRocketmqTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteRocketmqTagRequest);
            return new AsyncInvoker<BatchCreateOrDeleteRocketmqTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteRocketmqTagResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstancesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInstancesResponse> BatchDeleteInstancesAsyncInvoker(BatchDeleteInstancesRequest batchDeleteInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstancesRequest);
            return new AsyncInvoker<BatchDeleteInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchUpdateConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateConsumerGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateConsumerGroupResponse>(response);
        }

        public AsyncInvoker<BatchUpdateConsumerGroupResponse> BatchUpdateConsumerGroupAsyncInvoker(BatchUpdateConsumerGroupRequest batchUpdateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchUpdateConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateConsumerGroupRequest);
            return new AsyncInvoker<BatchUpdateConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateConsumerGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConsumerGroupOrBatchDeleteConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupOrBatchDeleteConsumerGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>(response);
        }

        public AsyncInvoker<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse> CreateConsumerGroupOrBatchDeleteConsumerGroupAsyncInvoker(CreateConsumerGroupOrBatchDeleteConsumerGroupRequest createConsumerGroupOrBatchDeleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConsumerGroupOrBatchDeleteConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupOrBatchDeleteConsumerGroupRequest);
            return new AsyncInvoker<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConsumerGroupOrBatchDeleteConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建实例[，该接口支持创建按需和包周期两种计费方式的实例](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceByEngineResponse> CreateInstanceByEngineAsync(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceByEngineResponse>(response);
        }

        public AsyncInvoker<CreateInstanceByEngineResponse> CreateInstanceByEngineAsyncInvoker(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", createInstanceByEngineRequest.Engine.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            return new AsyncInvoker<CreateInstanceByEngineResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceByEngineResponse>);
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
        /// 新建元数据迁移任务
        ///
        /// 新建元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRocketMqMigrationTaskResponse> CreateRocketMqMigrationTaskAsync(CreateRocketMqMigrationTaskRequest createRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRocketMqMigrationTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRocketMqMigrationTaskResponse>(response);
        }

        public AsyncInvoker<CreateRocketMqMigrationTaskResponse> CreateRocketMqMigrationTaskAsyncInvoker(CreateRocketMqMigrationTaskRequest createRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRocketMqMigrationTaskRequest);
            return new AsyncInvoker<CreateRocketMqMigrationTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRocketMqMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserResponse>(response);
        }

        public AsyncInvoker<CreateUserResponse> CreateUserAsyncInvoker(CreateUserRequest createUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRequest);
            return new AsyncInvoker<CreateUserResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", deleteConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConsumerGroupResponse>(response);
        }

        public AsyncInvoker<DeleteConsumerGroupResponse> DeleteConsumerGroupAsyncInvoker(DeleteConsumerGroupRequest deleteConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", deleteConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupRequest);
            return new AsyncInvoker<DeleteConsumerGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConsumerGroupResponse>);
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
        /// 删除元数据迁移任务
        ///
        /// 删除元数据迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRocketMqMigrationTaskResponse> DeleteRocketMqMigrationTaskAsync(DeleteRocketMqMigrationTaskRequest deleteRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRocketMqMigrationTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRocketMqMigrationTaskResponse>(response);
        }

        public AsyncInvoker<DeleteRocketMqMigrationTaskResponse> DeleteRocketMqMigrationTaskAsyncInvoker(DeleteRocketMqMigrationTaskRequest deleteRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRocketMqMigrationTaskRequest);
            return new AsyncInvoker<DeleteRocketMqMigrationTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRocketMqMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteUserResponse>(response);
        }

        public AsyncInvoker<DeleteUserResponse> DeleteUserAsyncInvoker(DeleteUserRequest deleteUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", deleteUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRequest);
            return new AsyncInvoker<DeleteUserResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", exportDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportDlqMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var exportDlqMessageResponse = JsonUtils.DeSerializeNull<ExportDlqMessageResponse>(response);
            exportDlqMessageResponse.Body = JsonUtils.DeSerializeList<Message>(response);
            return exportDlqMessageResponse;
        }

        public AsyncInvoker<ExportDlqMessageResponse> ExportDlqMessageAsyncInvoker(ExportDlqMessageRequest exportDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", exportDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportDlqMessageRequest);
            return new AsyncInvoker<ExportDlqMessageResponse>(this, "POST", request, response =>
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
        /// 查询代理列表
        ///
        /// 查询代理列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBrokersResponse> ListBrokersAsync(ListBrokersRequest listBrokersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBrokersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/brokers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBrokersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBrokersResponse>(response);
        }

        public AsyncInvoker<ListBrokersResponse> ListBrokersAsyncInvoker(ListBrokersRequest listBrokersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listBrokersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/brokers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBrokersRequest);
            return new AsyncInvoker<ListBrokersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBrokersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listConsumeGroupAccessPolicyRequest.Engine.ToString());
            urlParam.Add("instance_id", listConsumeGroupAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("group_id", listConsumeGroupAccessPolicyRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeGroupAccessPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConsumeGroupAccessPolicyResponse>(response);
        }

        public AsyncInvoker<ListConsumeGroupAccessPolicyResponse> ListConsumeGroupAccessPolicyAsyncInvoker(ListConsumeGroupAccessPolicyRequest listConsumeGroupAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listConsumeGroupAccessPolicyRequest.Engine.ToString());
            urlParam.Add("instance_id", listConsumeGroupAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("group_id", listConsumeGroupAccessPolicyRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumeGroupAccessPolicyRequest);
            return new AsyncInvoker<ListConsumeGroupAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConsumeGroupAccessPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConsumerGroupsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>(response);
        }

        public AsyncInvoker<ListInstanceConsumerGroupsResponse> ListInstanceConsumerGroupsAsyncInvoker(ListInstanceConsumerGroupsRequest listInstanceConsumerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceConsumerGroupsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            return new AsyncInvoker<ListInstanceConsumerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstancesResponse> ListInstancesAsyncInvoker(ListInstancesRequest listInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstancesRequest);
            return new AsyncInvoker<ListInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstancesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessageTraceRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessageTraceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTraceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMessageTraceResponse>(response);
        }

        public AsyncInvoker<ListMessageTraceResponse> ListMessageTraceAsyncInvoker(ListMessageTraceRequest listMessageTraceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessageTraceRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessageTraceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/trace", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTraceRequest);
            return new AsyncInvoker<ListMessageTraceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageTraceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessagesRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMessagesResponse>(response);
        }

        public AsyncInvoker<ListMessagesResponse> ListMessagesAsyncInvoker(ListMessagesRequest listMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", listMessagesRequest.Engine.ToString());
            urlParam.Add("instance_id", listMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessagesRequest);
            return new AsyncInvoker<ListMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessagesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketMqMigrationTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRocketMqMigrationTaskResponse>(response);
        }

        public AsyncInvoker<ListRocketMqMigrationTaskResponse> ListRocketMqMigrationTaskAsyncInvoker(ListRocketMqMigrationTaskRequest listRocketMqMigrationTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketMqMigrationTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketMqMigrationTaskRequest);
            return new AsyncInvoker<ListRocketMqMigrationTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRocketMqMigrationTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicAccessPolicyRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAccessPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicAccessPolicyResponse>(response);
        }

        public AsyncInvoker<ListTopicAccessPolicyResponse> ListTopicAccessPolicyAsyncInvoker(ListTopicAccessPolicyRequest listTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicAccessPolicyRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAccessPolicyRequest);
            return new AsyncInvoker<ListTopicAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicAccessPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserResponse>(response);
        }

        public AsyncInvoker<ListUserResponse> ListUserAsyncInvoker(ListUserRequest listUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserRequest);
            return new AsyncInvoker<ListUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resetConsumeOffsetRequest.Engine.ToString());
            urlParam.Add("instance_id", resetConsumeOffsetRequest.InstanceId.ToString());
            urlParam.Add("group_id", resetConsumeOffsetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConsumeOffsetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetConsumeOffsetResponse>(response);
        }

        public AsyncInvoker<ResetConsumeOffsetResponse> ResetConsumeOffsetAsyncInvoker(ResetConsumeOffsetRequest resetConsumeOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resetConsumeOffsetRequest.Engine.ToString());
            urlParam.Add("instance_id", resetConsumeOffsetRequest.InstanceId.ToString());
            urlParam.Add("group_id", resetConsumeOffsetRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group_id}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetConsumeOffsetRequest);
            return new AsyncInvoker<ResetConsumeOffsetResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetConsumeOffsetResponse>);
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
        public async Task<ResizeInstanceResponse> ResizeInstanceAsync(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeInstanceResponse> ResizeInstanceAsyncInvoker(ResizeInstanceRequest resizeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeInstanceRequest);
            return new AsyncInvoker<ResizeInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeInstanceResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", sendDlqMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", sendDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/deadletter-resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDlqMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendDlqMessageResponse>(response);
        }

        public AsyncInvoker<SendDlqMessageResponse> SendDlqMessageAsyncInvoker(SendDlqMessageRequest sendDlqMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", sendDlqMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", sendDlqMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/deadletter-resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendDlqMessageRequest);
            return new AsyncInvoker<SendDlqMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<SendDlqMessageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerConnectionsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerConnectionsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rocketmq/{project_id}/instances/{instance_id}/groups/{group}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerConnectionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConsumerConnectionsResponse>(response);
        }

        public AsyncInvoker<ShowConsumerConnectionsResponse> ShowConsumerConnectionsAsyncInvoker(ShowConsumerConnectionsRequest showConsumerConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerConnectionsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerConnectionsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/rocketmq/{project_id}/instances/{instance_id}/groups/{group}/clients", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerConnectionsRequest);
            return new AsyncInvoker<ShowConsumerConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConsumerConnectionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerListOrDetailsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerListOrDetailsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerListOrDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowConsumerListOrDetailsResponse>(response);
        }

        public AsyncInvoker<ShowConsumerListOrDetailsResponse> ShowConsumerListOrDetailsAsyncInvoker(ShowConsumerListOrDetailsRequest showConsumerListOrDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConsumerListOrDetailsRequest.InstanceId.ToString());
            urlParam.Add("group", showConsumerListOrDetailsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConsumerListOrDetailsRequest);
            return new AsyncInvoker<ShowConsumerListOrDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConsumerListOrDetailsResponse>);
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
        /// 查询指定消费组
        ///
        /// 查询指定消费组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupResponse> ShowGroupAsync(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
        }

        public AsyncInvoker<ShowGroupResponse> ShowGroupAsyncInvoker(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            return new AsyncInvoker<ShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupResponse>);
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
        /// 查询RocketMQ配置
        ///
        /// 该接口用于查询RocketMQ配置，若成功则返回配置的相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRocketMqConfigsResponse> ShowRocketMqConfigsAsync(ShowRocketMqConfigsRequest showRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketMqConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketMqConfigsResponse>(response);
        }

        public AsyncInvoker<ShowRocketMqConfigsResponse> ShowRocketMqConfigsAsyncInvoker(ShowRocketMqConfigsRequest showRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketMqConfigsRequest);
            return new AsyncInvoker<ShowRocketMqConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketMqConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketmqProjectTagsResponse>(response);
        }

        public AsyncInvoker<ShowRocketmqProjectTagsResponse> ShowRocketmqProjectTagsAsyncInvoker(ShowRocketmqProjectTagsRequest showRocketmqProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqProjectTagsRequest);
            return new AsyncInvoker<ShowRocketmqProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketmqProjectTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketmqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRocketmqTagsResponse>(response);
        }

        public AsyncInvoker<ShowRocketmqTagsResponse> ShowRocketmqTagsAsyncInvoker(ShowRocketmqTagsRequest showRocketmqTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showRocketmqTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRocketmqTagsRequest);
            return new AsyncInvoker<ShowRocketmqTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRocketmqTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", showUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserResponse>(response);
        }

        public AsyncInvoker<ShowUserResponse> ShowUserAsyncInvoker(ShowUserRequest showUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", showUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRequest);
            return new AsyncInvoker<ShowUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConsumerGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateConsumerGroupResponse>(response);
        }

        public AsyncInvoker<UpdateConsumerGroupResponse> UpdateConsumerGroupAsyncInvoker(UpdateConsumerGroupRequest updateConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateConsumerGroupRequest);
            return new AsyncInvoker<UpdateConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateConsumerGroupResponse>);
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
        /// 修改RocketMQ配置
        ///
        /// 该接口用于修改RocketMQ配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRocketMqConfigsResponse> UpdateRocketMqConfigsAsync(UpdateRocketMqConfigsRequest updateRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRocketMqConfigsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRocketMqConfigsResponse>(response);
        }

        public AsyncInvoker<UpdateRocketMqConfigsResponse> UpdateRocketMqConfigsAsyncInvoker(UpdateRocketMqConfigsRequest updateRocketMqConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateRocketMqConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rocketmq/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRocketMqConfigsRequest);
            return new AsyncInvoker<UpdateRocketMqConfigsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRocketMqConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserResponse>(response);
        }

        public AsyncInvoker<UpdateUserResponse> UpdateUserAsyncInvoker(UpdateUserRequest updateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRequest);
            return new AsyncInvoker<UpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", validateConsumedMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", validateConsumedMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConsumedMessageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateConsumedMessageResponse>(response);
        }

        public AsyncInvoker<ValidateConsumedMessageResponse> ValidateConsumedMessageAsyncInvoker(ValidateConsumedMessageRequest validateConsumedMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", validateConsumedMessageRequest.Engine.ToString());
            urlParam.Add("instance_id", validateConsumedMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/messages/resend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConsumedMessageRequest);
            return new AsyncInvoker<ValidateConsumedMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateConsumedMessageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createTopicOrBatchDeleteTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTopicOrBatchDeleteTopicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTopicOrBatchDeleteTopicResponse>(response);
        }

        public AsyncInvoker<CreateTopicOrBatchDeleteTopicResponse> CreateTopicOrBatchDeleteTopicAsyncInvoker(CreateTopicOrBatchDeleteTopicRequest createTopicOrBatchDeleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createTopicOrBatchDeleteTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTopicOrBatchDeleteTopicRequest);
            return new AsyncInvoker<CreateTopicOrBatchDeleteTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTopicOrBatchDeleteTopicResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", deleteTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTopicResponse>(response);
        }

        public AsyncInvoker<DeleteTopicResponse> DeleteTopicAsyncInvoker(DeleteTopicRequest deleteTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", deleteTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            return new AsyncInvoker<DeleteTopicResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTopicResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConsumerGroupOfTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", listConsumerGroupOfTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupOfTopicRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConsumerGroupOfTopicResponse>(response);
        }

        public AsyncInvoker<ListConsumerGroupOfTopicResponse> ListConsumerGroupOfTopicAsyncInvoker(ListConsumerGroupOfTopicRequest listConsumerGroupOfTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConsumerGroupOfTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", listConsumerGroupOfTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupOfTopicRequest);
            return new AsyncInvoker<ListConsumerGroupOfTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConsumerGroupOfTopicResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketInstanceTopicsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRocketInstanceTopicsResponse>(response);
        }

        public AsyncInvoker<ListRocketInstanceTopicsResponse> ListRocketInstanceTopicsAsyncInvoker(ListRocketInstanceTopicsRequest listRocketInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listRocketInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRocketInstanceTopicsRequest);
            return new AsyncInvoker<ListRocketInstanceTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRocketInstanceTopicsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOneTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", showOneTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOneTopicRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOneTopicResponse>(response);
        }

        public AsyncInvoker<ShowOneTopicResponse> ShowOneTopicAsyncInvoker(ShowOneTopicRequest showOneTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showOneTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", showOneTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOneTopicRequest);
            return new AsyncInvoker<ShowOneTopicResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOneTopicResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicStatusRequest.InstanceId.ToString());
            urlParam.Add("topic", showTopicStatusRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopicStatusResponse>(response);
        }

        public AsyncInvoker<ShowTopicStatusResponse> ShowTopicStatusAsyncInvoker(ShowTopicStatusRequest showTopicStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicStatusRequest.InstanceId.ToString());
            urlParam.Add("topic", showTopicStatusRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicStatusRequest);
            return new AsyncInvoker<ShowTopicStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopicStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTopicResponse>(response);
        }

        public AsyncInvoker<UpdateTopicResponse> UpdateTopicAsyncInvoker(UpdateTopicRequest updateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicRequest);
            return new AsyncInvoker<UpdateTopicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTopicResponse>);
        }
        
    }
}