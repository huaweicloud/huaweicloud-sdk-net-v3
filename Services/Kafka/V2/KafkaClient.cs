using System;
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
        ///
        /// 批量添加或删除实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateOrDeleteKafkaTagResponse BatchCreateOrDeleteKafkaTag(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteKafkaTagResponse> BatchCreateOrDeleteKafkaTagInvoker(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            return new SyncInvoker<BatchCreateOrDeleteKafkaTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>);
        }
        
        /// <summary>
        /// Kafka实例批量删除Group
        ///
        /// 该接口用于向Kafka实例批量删除Group。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteGroupResponse BatchDeleteGroup(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteGroupResponse>(response);
        }

        public SyncInvoker<BatchDeleteGroupResponse> BatchDeleteGroupInvoker(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGroupRequest);
            return new SyncInvoker<BatchDeleteGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteGroupResponse>);
        }
        
        /// <summary>
        /// Kafka实例批量删除Topic
        ///
        /// 该接口用于向Kafka实例批量删除Topic。批量删除多个Topic时，部分删除成功，部分失败，此时接口返回删除成功，并在返回中显示删除失败的Topic信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInstanceTopicResponse BatchDeleteInstanceTopic(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstanceTopicResponse> BatchDeleteInstanceTopicInvoker(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            return new SyncInvoker<BatchDeleteInstanceTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 批量删除用户
        ///
        /// 批量删除Kafka实例的用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInstanceUsersResponse BatchDeleteInstanceUsers(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstanceUsersResponse> BatchDeleteInstanceUsersInvoker(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            return new SyncInvoker<BatchDeleteInstanceUsersResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>);
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
        /// 关闭Kafka Manager
        ///
        /// 关闭Kafka Manager，相应的原来开放出的management相关接口也将不可用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CloseKafkaManagerResponse CloseKafkaManager(CloseKafkaManagerRequest closeKafkaManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", closeKafkaManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>(response);
        }

        public SyncInvoker<CloseKafkaManagerResponse> CloseKafkaManagerInvoker(CloseKafkaManagerRequest closeKafkaManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", closeKafkaManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            return new SyncInvoker<CloseKafkaManagerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>);
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
        /// Kafka实例创建Topic
        ///
        /// 该接口用于向Kafka实例创建Topic。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceTopicResponse CreateInstanceTopic(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceTopicResponse>(response);
        }

        public SyncInvoker<CreateInstanceTopicResponse> CreateInstanceTopicInvoker(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            return new SyncInvoker<CreateInstanceTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建Kafka实例的用户，用户可连接开启SASL的Kafka实例。 [ 2023年7月15日前创建的Kafka实例，一个实例最多创建20个用户。2023年7月15日及以后创建的Kafka实例，一个实例最多创建500个用户。](tag:hws,hws_hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceUserResponse CreateInstanceUser(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceUserResponse>(response);
        }

        public SyncInvoker<CreateInstanceUserResponse> CreateInstanceUserInvoker(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            return new SyncInvoker<CreateInstanceUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceUserResponse>);
        }
        
        /// <summary>
        /// 创建消费组
        ///
        /// 实例创建消费组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKafkaConsumerGroupResponse CreateKafkaConsumerGroup(CreateKafkaConsumerGroupRequest createKafkaConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>(response);
        }

        public SyncInvoker<CreateKafkaConsumerGroupResponse> CreateKafkaConsumerGroupInvoker(CreateKafkaConsumerGroupRequest createKafkaConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            return new SyncInvoker<CreateKafkaConsumerGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 创建用户/客户端流控配置
        ///
        /// 该接口用于向Kafka实例提交创建用户、客户端级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKafkaUserClientQuotaTaskResponse CreateKafkaUserClientQuotaTask(CreateKafkaUserClientQuotaTaskRequest createKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<CreateKafkaUserClientQuotaTaskResponse> CreateKafkaUserClientQuotaTaskInvoker(CreateKafkaUserClientQuotaTaskRequest createKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<CreateKafkaUserClientQuotaTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建按需计费类型的Kafka实例。
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
        /// Kafka实例开始分区重平衡任务
        ///
        /// 该接口用于向Kafka实例提交分区重平衡任务，若成功则返回重平衡任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReassignmentTaskResponse CreateReassignmentTask(CreateReassignmentTaskRequest createReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createReassignmentTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReassignmentTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReassignmentTaskResponse>(response);
        }

        public SyncInvoker<CreateReassignmentTaskResponse> CreateReassignmentTaskInvoker(CreateReassignmentTaskRequest createReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createReassignmentTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReassignmentTaskRequest);
            return new SyncInvoker<CreateReassignmentTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReassignmentTaskResponse>);
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
        /// 删除用户/客户端流控配置
        ///
        /// 该接口用于向Kafka实例提交删除用户、客户端级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKafkaUserClientQuotaTaskResponse DeleteKafkaUserClientQuotaTask(DeleteKafkaUserClientQuotaTaskRequest deleteKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<DeleteKafkaUserClientQuotaTaskResponse> DeleteKafkaUserClientQuotaTaskInvoker(DeleteKafkaUserClientQuotaTaskRequest deleteKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<DeleteKafkaUserClientQuotaTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>);
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
        /// 查询所有消费组
        ///
        /// 查询所有消费组。
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
        /// Kafka实例查询Topic
        ///
        /// 该接口用于查询指定Kafka实例的Topic详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceTopicsResponse ListInstanceTopics(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTopicsResponse>(response);
        }

        public SyncInvoker<ListInstanceTopicsResponse> ListInstanceTopicsInvoker(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            return new SyncInvoker<ListInstanceTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTopicsResponse>);
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
        /// 查询产品规格列表
        ///
        /// 在创建kafka实例时，需要配置订购的产品ID（即product_id），可通过该接口查询产品规格。
        /// 
        /// 例如，要订购按需计费、基准带宽为100MB的kafka实例，可从接口响应消息中，查找Hourly的消息体，然后找到bandwidth为100MB的记录对应的product_id，该product_id的值即是创建上述kafka实例时需要配置的产品ID。
        /// 
        /// 同时，unavailable_zones字段表示资源不足的可用区列表，如果为空，则表示所有可用区都有资源，如果不为空，则表示字段值的可用区没有资源。所以必须确保您购买的资源所在的可用区有资源，不在该字段列表内。
        /// 
        /// [例如，响应消息中bandwidth字段为1200MB的记录，unavailable_zones字段包含cn-east-2b、cn-east-2a和cn-east-2d，表示在华东-上海2的可用区1、可用区2、可用区3都没有该资源。](tag:hws)
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
        /// 查询Topic的分区列表
        ///
        /// 查询Topic的分区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicPartitionsResponse ListTopicPartitions(ListTopicPartitionsRequest listTopicPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicPartitionsRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicPartitionsRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicPartitionsResponse>(response);
        }

        public SyncInvoker<ListTopicPartitionsResponse> ListTopicPartitionsInvoker(ListTopicPartitionsRequest listTopicPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicPartitionsRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicPartitionsRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            return new SyncInvoker<ListTopicPartitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicPartitionsResponse>);
        }
        
        /// <summary>
        /// 查询Topic的当前生产者列表
        ///
        /// 查询Topic的当前生产者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicProducersResponse ListTopicProducers(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicProducersRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicProducersRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/producers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicProducersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicProducersResponse>(response);
        }

        public SyncInvoker<ListTopicProducersResponse> ListTopicProducersInvoker(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicProducersRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicProducersRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/producers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicProducersRequest);
            return new SyncInvoker<ListTopicProducersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicProducersResponse>);
        }
        
        /// <summary>
        /// 修改实例配置
        ///
        /// 修改实例配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyInstanceConfigsResponse ModifyInstanceConfigs(ModifyInstanceConfigsRequest modifyInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>(response);
        }

        public SyncInvoker<ModifyInstanceConfigsResponse> ModifyInstanceConfigsInvoker(ModifyInstanceConfigsRequest modifyInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            return new SyncInvoker<ModifyInstanceConfigsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>);
        }
        
        /// <summary>
        /// 重置Manager密码
        ///
        /// 重置Manager密码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetManagerPasswordResponse ResetManagerPassword(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetManagerPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>(response);
        }

        public SyncInvoker<ResetManagerPasswordResponse> ResetManagerPasswordInvoker(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetManagerPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            return new SyncInvoker<ResetManagerPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>);
        }
        
        /// <summary>
        /// 重置消费组消费进度到指定位置
        ///
        /// Kafka实例不支持在线重置消费进度。在执行重置消费进度之前，必须停止被重置消费组客户端。
        /// 
        /// 停止待重置消费组客户端，然后等待一段时间（即ConsumerConfig.SESSION_TIMEOUT_MS_CONFIG配置的时间，默认为1000毫秒）后，服务端才认为此消费组客户端已下线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetMessageOffsetResponse ResetMessageOffset(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>(response);
        }

        public SyncInvoker<ResetMessageOffsetResponse> ResetMessageOffsetInvoker(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            return new SyncInvoker<ResetMessageOffsetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>);
        }
        
        /// <summary>
        /// 重置消费组消费进度到指定位置
        ///
        /// Kafka实例不支持在线重置消费进度。在执行重置消费进度之前，必须停止被重置消费组客户端。
        /// 
        /// 停止待重置消费组客户端，然后等待一段时间（即ConsumerConfig.SESSION_TIMEOUT_MS_CONFIG配置的时间，默认为1000毫秒）后，服务端才认为此消费组客户端已下线。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetMessageOffsetWithEngineResponse ResetMessageOffsetWithEngine(ResetMessageOffsetWithEngineRequest resetMessageOffsetWithEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetWithEngineRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetWithEngineRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetWithEngineRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetWithEngineResponse>(response);
        }

        public SyncInvoker<ResetMessageOffsetWithEngineResponse> ResetMessageOffsetWithEngineInvoker(ResetMessageOffsetWithEngineRequest resetMessageOffsetWithEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetWithEngineRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetWithEngineRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetWithEngineRequest);
            return new SyncInvoker<ResetMessageOffsetWithEngineResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetMessageOffsetWithEngineResponse>);
        }
        
        /// <summary>
        /// 重置密码
        ///
        /// 重置密码（只针对开通SSL的实例）。
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
        /// 重置用户密码
        ///
        /// 重置用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetUserPasswrodResponse ResetUserPasswrod(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name", resetUserPasswrodRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>(response);
        }

        public SyncInvoker<ResetUserPasswrodResponse> ResetUserPasswrodInvoker(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name", resetUserPasswrodRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            return new SyncInvoker<ResetUserPasswrodResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>);
        }
        
        /// <summary>
        /// 实例扩容
        ///
        /// 实例规格变更。[当前通过调用API，只支持按需实例进行实例扩容。](tag:hws,hws_hk,ctc,cmcc,hws_eu)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeEngineInstanceResponse ResizeEngineInstance(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeEngineInstanceResponse>(response);
        }

        public SyncInvoker<ResizeEngineInstanceResponse> ResizeEngineInstanceInvoker(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            return new SyncInvoker<ResizeEngineInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeEngineInstanceResponse>);
        }
        
        /// <summary>
        /// 实例扩容
        ///
        /// 实例扩容。[当前通过调用API，只支持按需实例进行实例扩容。](tag:hws,hws_hk,ctc,cmcc,hws_eu)
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
        /// 重启Manager
        ///
        /// 重启Manager。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartManagerResponse RestartManager(RestartManagerRequest restartManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RestartManagerResponse>(response);
        }

        public SyncInvoker<RestartManagerResponse> RestartManagerInvoker(RestartManagerRequest restartManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            return new SyncInvoker<RestartManagerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestartManagerResponse>);
        }
        
        /// <summary>
        /// Kafka生产消息
        ///
        /// 在控制台发送指定消息到Kafka实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendKafkaMessageResponse SendKafkaMessage(SendKafkaMessageRequest sendKafkaMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", sendKafkaMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendKafkaMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendKafkaMessageResponse>(response);
        }

        public SyncInvoker<SendKafkaMessageResponse> SendKafkaMessageInvoker(SendKafkaMessageRequest sendKafkaMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", sendKafkaMessageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendKafkaMessageRequest);
            return new SyncInvoker<SendKafkaMessageResponse>(this, "POST", request, JsonUtils.DeSerialize<SendKafkaMessageResponse>);
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
        /// 查询Kafka集群元数据信息
        ///
        /// 查询Kafka集群元数据信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterResponse ShowCluster(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClusterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public SyncInvoker<ShowClusterResponse> ShowClusterInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClusterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new SyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
        }
        
        /// <summary>
        /// 查询Kafka实例的协调器信息
        ///
        /// 查询Kafka实例的协调器信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCoordinatorsResponse ShowCoordinators(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCoordinatorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCoordinatorsResponse>(response);
        }

        public SyncInvoker<ShowCoordinatorsResponse> ShowCoordinatorsInvoker(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCoordinatorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            return new SyncInvoker<ShowCoordinatorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCoordinatorsResponse>);
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
        /// 查询消费组信息
        ///
        /// 查询消费组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupsResponse ShowGroups(ShowGroupsRequest showGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsResponse>(response);
        }

        public SyncInvoker<ShowGroupsResponse> ShowGroupsInvoker(ShowGroupsRequest showGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            return new SyncInvoker<ShowGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupsResponse>);
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
        /// 获取实例配置
        ///
        /// 获取实例配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceConfigsResponse ShowInstanceConfigs(ShowInstanceConfigsRequest showInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigsResponse>(response);
        }

        public SyncInvoker<ShowInstanceConfigsResponse> ShowInstanceConfigsInvoker(ShowInstanceConfigsRequest showInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            return new SyncInvoker<ShowInstanceConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigsResponse>);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        ///
        /// 查询实例的扩容规格列表。
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
        /// 查询消息
        ///
        /// 查询消息的偏移量和消息内容。
        /// 先根据时间戳查询消息的偏移量，再根据偏移量查询消息内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMessagesResponse ShowInstanceMessages(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMessagesResponse>(response);
        }

        public SyncInvoker<ShowInstanceMessagesResponse> ShowInstanceMessagesInvoker(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            return new SyncInvoker<ShowInstanceMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceMessagesResponse>);
        }
        
        /// <summary>
        /// 查询Kafka实例Topic详细信息
        ///
        /// 查询Kafka实例Topic详细信息。(单个实例调用不要超过1s一次)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceTopicDetailResponse ShowInstanceTopicDetail(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic", showInstanceTopicDetailRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>(response);
        }

        public SyncInvoker<ShowInstanceTopicDetailResponse> ShowInstanceTopicDetailInvoker(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic", showInstanceTopicDetailRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            return new SyncInvoker<ShowInstanceTopicDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>);
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
        public ShowInstanceUsersResponse ShowInstanceUsers(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceUsersResponse>(response);
        }

        public SyncInvoker<ShowInstanceUsersResponse> ShowInstanceUsersInvoker(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            return new SyncInvoker<ShowInstanceUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceUsersResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询项目标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaProjectTagsResponse ShowKafkaProjectTags(ShowKafkaProjectTagsRequest showKafkaProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>(response);
        }

        public SyncInvoker<ShowKafkaProjectTagsResponse> ShowKafkaProjectTagsInvoker(ShowKafkaProjectTagsRequest showKafkaProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            return new SyncInvoker<ShowKafkaProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询实例标签
        ///
        /// 查询实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaTagsResponse ShowKafkaTags(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTagsResponse>(response);
        }

        public SyncInvoker<ShowKafkaTagsResponse> ShowKafkaTagsInvoker(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            return new SyncInvoker<ShowKafkaTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTagsResponse>);
        }
        
        /// <summary>
        /// 查询topic的磁盘存储情况
        ///
        /// 查询topic在Broker上磁盘占用情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaTopicPartitionDiskusageResponse ShowKafkaTopicPartitionDiskusage(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>(response);
        }

        public SyncInvoker<ShowKafkaTopicPartitionDiskusageResponse> ShowKafkaTopicPartitionDiskusageInvoker(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            return new SyncInvoker<ShowKafkaTopicPartitionDiskusageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>);
        }
        
        /// <summary>
        /// 查询用户/客户端流控配置
        ///
        /// 该接口用于向Kafka实例查询流控的配置，若成功则返回流控配置的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaUserClientQuotaResponse ShowKafkaUserClientQuota(ShowKafkaUserClientQuotaRequest showKafkaUserClientQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaUserClientQuotaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaUserClientQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaUserClientQuotaResponse>(response);
        }

        public SyncInvoker<ShowKafkaUserClientQuotaResponse> ShowKafkaUserClientQuotaInvoker(ShowKafkaUserClientQuotaRequest showKafkaUserClientQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaUserClientQuotaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaUserClientQuotaRequest);
            return new SyncInvoker<ShowKafkaUserClientQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaUserClientQuotaResponse>);
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
        /// 查询分区指定时间段的消息
        ///
        /// 查询分区指定时间段的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMessagesResponse ShowMessages(ShowMessagesRequest showMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic", showMessagesRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMessagesResponse>(response);
        }

        public SyncInvoker<ShowMessagesResponse> ShowMessagesInvoker(ShowMessagesRequest showMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic", showMessagesRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            return new SyncInvoker<ShowMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMessagesResponse>);
        }
        
        /// <summary>
        /// 查询分区最早消息的位置
        ///
        /// 查询分区最早消息的位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPartitionBeginningMessageResponse ShowPartitionBeginningMessage(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionBeginningMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionBeginningMessageResponse> ShowPartitionBeginningMessageInvoker(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionBeginningMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            return new SyncInvoker<ShowPartitionBeginningMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>);
        }
        
        /// <summary>
        /// 查询分区最新消息的位置
        ///
        /// 查询分区最新消息的位置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPartitionEndMessageResponse ShowPartitionEndMessage(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionEndMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionEndMessageResponse> ShowPartitionEndMessageInvoker(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionEndMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            return new SyncInvoker<ShowPartitionEndMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>);
        }
        
        /// <summary>
        /// 查询分区指定偏移量的消息
        ///
        /// 查询分区指定偏移量的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPartitionMessageResponse ShowPartitionMessage(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionMessageResponse> ShowPartitionMessageInvoker(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            return new SyncInvoker<ShowPartitionMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionMessageResponse>);
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
        public ShowTopicAccessPolicyResponse ShowTopicAccessPolicy(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name", showTopicAccessPolicyRequest.TopicName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>(response);
        }

        public SyncInvoker<ShowTopicAccessPolicyResponse> ShowTopicAccessPolicyInvoker(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name", showTopicAccessPolicyRequest.TopicName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            return new SyncInvoker<ShowTopicAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 修改实例信息
        ///
        /// 修改实例信息。
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
        /// 开启或关闭实例自动创建topic功能
        ///
        /// 开启或关闭实例自动创建topic功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceAutoCreateTopicResponse UpdateInstanceAutoCreateTopic(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>(response);
        }

        public SyncInvoker<UpdateInstanceAutoCreateTopicResponse> UpdateInstanceAutoCreateTopicInvoker(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            return new SyncInvoker<UpdateInstanceAutoCreateTopicResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>);
        }
        
        /// <summary>
        /// 编辑消费组
        ///
        /// 编辑消费组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConsumerGroupResponse UpdateInstanceConsumerGroup(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceConsumerGroupRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateInstanceConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConsumerGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceConsumerGroupResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConsumerGroupResponse> UpdateInstanceConsumerGroupInvoker(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceConsumerGroupRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateInstanceConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConsumerGroupRequest);
            return new SyncInvoker<UpdateInstanceConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 修改实例跨VPC访问的内网IP
        ///
        /// 修改实例跨VPC访问的内网IP。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceCrossVpcIpResponse UpdateInstanceCrossVpcIp(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>(response);
        }

        public SyncInvoker<UpdateInstanceCrossVpcIpResponse> UpdateInstanceCrossVpcIpInvoker(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            return new SyncInvoker<UpdateInstanceCrossVpcIpResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic
        ///
        /// 修改Kafka实例Topic
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceTopicResponse UpdateInstanceTopic(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>(response);
        }

        public SyncInvoker<UpdateInstanceTopicResponse> UpdateInstanceTopicInvoker(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            return new SyncInvoker<UpdateInstanceTopicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 修改用户参数
        ///
        /// 修改用户参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceUserResponse UpdateInstanceUser(UpdateInstanceUserRequest updateInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceUserRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateInstanceUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>(response);
        }

        public SyncInvoker<UpdateInstanceUserResponse> UpdateInstanceUserInvoker(UpdateInstanceUserRequest updateInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceUserRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateInstanceUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            return new SyncInvoker<UpdateInstanceUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>);
        }
        
        /// <summary>
        /// 修改用户/客户端流控配置
        ///
        /// 该接口用于向Kafka实例提交修改用户、客户端级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKafkaUserClientQuotaTaskResponse UpdateKafkaUserClientQuotaTask(UpdateKafkaUserClientQuotaTaskRequest updateKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<UpdateKafkaUserClientQuotaTaskResponse> UpdateKafkaUserClientQuotaTaskInvoker(UpdateKafkaUserClientQuotaTaskRequest updateKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<UpdateKafkaUserClientQuotaTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>);
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
        public UpdateTopicAccessPolicyResponse UpdateTopicAccessPolicy(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicAccessPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>(response);
        }

        public SyncInvoker<UpdateTopicAccessPolicyResponse> UpdateTopicAccessPolicyInvoker(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicAccessPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            return new SyncInvoker<UpdateTopicAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 修改Kafka实例Topic分区的副本
        ///
        /// 修改Kafka实例Topic分区的副本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTopicReplicaResponse UpdateTopicReplica(UpdateTopicReplicaRequest updateTopicReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicReplicaRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>(response);
        }

        public SyncInvoker<UpdateTopicReplicaResponse> UpdateTopicReplicaInvoker(UpdateTopicReplicaRequest updateTopicReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicReplicaRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            return new SyncInvoker<UpdateTopicReplicaResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>);
        }
        
        /// <summary>
        /// 开启Smart Connect（按需实例）
        ///
        /// 开启Smart Connect，提交创建Smart Connect节点任务。
        /// 
        /// **当前通过调用API，只支持按需实例创建Smart Connect节点。**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConnectorResponse CreateConnector(CreateConnectorRequest createConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectorResponse>(response);
        }

        public SyncInvoker<CreateConnectorResponse> CreateConnectorInvoker(CreateConnectorRequest createConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            return new SyncInvoker<CreateConnectorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConnectorResponse>);
        }
        
        /// <summary>
        /// 创建Smart Connect任务
        ///
        /// 创建Smart Connect任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConnectorTaskResponse CreateConnectorTask(CreateConnectorTaskRequest createConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectorTaskResponse>(response);
        }

        public SyncInvoker<CreateConnectorTaskResponse> CreateConnectorTaskInvoker(CreateConnectorTaskRequest createConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorTaskRequest);
            return new SyncInvoker<CreateConnectorTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 关闭Smart Connect（按需实例）
        ///
        /// 介绍按需实例如何关闭Smart Connect。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest deleteConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteConnectorResponse>(response);
        }

        public SyncInvoker<DeleteConnectorResponse> DeleteConnectorInvoker(DeleteConnectorRequest deleteConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            return new SyncInvoker<DeleteConnectorResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteConnectorResponse>);
        }
        
        /// <summary>
        /// 删除Smart Connector任务
        ///
        /// 删除Smart Connector任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConnectorTaskResponse DeleteConnectorTask(DeleteConnectorTaskRequest deleteConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConnectorTaskResponse>(response);
        }

        public SyncInvoker<DeleteConnectorTaskResponse> DeleteConnectorTaskInvoker(DeleteConnectorTaskRequest deleteConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", deleteConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorTaskRequest);
            return new SyncInvoker<DeleteConnectorTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 查询Smart Connect任务列表
        ///
        /// 查询Smart Connect任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConnectorTasksResponse ListConnectorTasks(ListConnectorTasksRequest listConnectorTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConnectorTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectorTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConnectorTasksResponse>(response);
        }

        public SyncInvoker<ListConnectorTasksResponse> ListConnectorTasksInvoker(ListConnectorTasksRequest listConnectorTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listConnectorTasksRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectorTasksRequest);
            return new SyncInvoker<ListConnectorTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConnectorTasksResponse>);
        }
        
        /// <summary>
        /// 暂停Smart Connect任务
        ///
        /// 暂停Smart Connect任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PauseConnectorTaskResponse PauseConnectorTask(PauseConnectorTaskRequest pauseConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", pauseConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PauseConnectorTaskResponse>(response);
        }

        public SyncInvoker<PauseConnectorTaskResponse> PauseConnectorTaskInvoker(PauseConnectorTaskRequest pauseConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", pauseConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", pauseConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConnectorTaskRequest);
            return new SyncInvoker<PauseConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<PauseConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 启动未启动的Smart Connect任务/重启已暂停或者运行中的Smart Connect任务
        ///
        /// 用于**启动未启动的Smart Connect任务**以及**重启已暂停或者运行中的Smart Connect任务**。注意，重启Smart Connect任务将重置同步进度，并重新开始同步任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartConnectorTaskResponse RestartConnectorTask(RestartConnectorTaskRequest restartConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", restartConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RestartConnectorTaskResponse>(response);
        }

        public SyncInvoker<RestartConnectorTaskResponse> RestartConnectorTaskInvoker(RestartConnectorTaskRequest restartConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", restartConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartConnectorTaskRequest);
            return new SyncInvoker<RestartConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RestartConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 启动已暂停的Smart Connect任务
        ///
        /// 启动已暂停的Smart Connect任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResumeConnectorTaskResponse ResumeConnectorTask(ResumeConnectorTaskRequest resumeConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resumeConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", resumeConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/resume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResumeConnectorTaskResponse>(response);
        }

        public SyncInvoker<ResumeConnectorTaskResponse> ResumeConnectorTaskInvoker(ResumeConnectorTaskRequest resumeConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resumeConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", resumeConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/resume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeConnectorTaskRequest);
            return new SyncInvoker<ResumeConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResumeConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 查询Smart Connector任务详情
        ///
        /// 查询Smart Connector任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConnectorTaskResponse ShowConnectorTask(ShowConnectorTaskRequest showConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConnectorTaskResponse>(response);
        }

        public SyncInvoker<ShowConnectorTaskResponse> ShowConnectorTaskInvoker(ShowConnectorTaskRequest showConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showConnectorTaskRequest.InstanceId.ToString());
            urlParam.Add("task_id", showConnectorTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorTaskRequest);
            return new SyncInvoker<ShowConnectorTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConnectorTaskResponse>);
        }
        
    }
}