using System;
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>(response);
        }

        public AsyncInvoker<BatchCreateOrDeleteKafkaTagResponse> BatchCreateOrDeleteKafkaTagAsyncInvoker(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchCreateOrDeleteKafkaTagRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            return new AsyncInvoker<BatchCreateOrDeleteKafkaTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>);
        }
        
        /// <summary>
        /// Kafka实例批量删除Group
        ///
        /// 该接口用于向Kafka实例批量删除Group。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteGroupResponse> BatchDeleteGroupAsync(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteGroupResponse>(response);
        }

        public AsyncInvoker<BatchDeleteGroupResponse> BatchDeleteGroupAsyncInvoker(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGroupRequest);
            return new AsyncInvoker<BatchDeleteGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteGroupResponse>);
        }
        
        /// <summary>
        /// Kafka实例批量删除Topic
        ///
        /// 该接口用于向Kafka实例批量删除Topic。批量删除多个Topic时，部分删除成功，部分失败，此时接口返回删除成功，并在返回中显示删除失败的Topic信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInstanceTopicResponse> BatchDeleteInstanceTopicAsync(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInstanceTopicResponse> BatchDeleteInstanceTopicAsyncInvoker(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            return new AsyncInvoker<BatchDeleteInstanceTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInstanceUsersResponse> BatchDeleteInstanceUsersAsyncInvoker(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", batchDeleteInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            return new AsyncInvoker<BatchDeleteInstanceUsersResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>);
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
        /// 关闭kafka manager
        ///
        /// 关闭kafka manager，相应的原来开放出的management相关接口也将不可用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CloseKafkaManagerResponse> CloseKafkaManagerAsync(CloseKafkaManagerRequest closeKafkaManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", closeKafkaManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>(response);
        }

        public AsyncInvoker<CloseKafkaManagerResponse> CloseKafkaManagerAsyncInvoker(CloseKafkaManagerRequest closeKafkaManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", closeKafkaManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            return new AsyncInvoker<CloseKafkaManagerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectorResponse>(response);
        }

        public AsyncInvoker<CreateConnectorResponse> CreateConnectorAsyncInvoker(CreateConnectorRequest createConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            return new AsyncInvoker<CreateConnectorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConnectorResponse>);
        }
        
        /// <summary>
        /// 创建关闭实例转储节点的订单
        ///
        /// 创建删除实例转储节点的订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDeleteConnectorOrderResponse> CreateDeleteConnectorOrderAsync(CreateDeleteConnectorOrderRequest createDeleteConnectorOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDeleteConnectorOrderRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeleteConnectorOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDeleteConnectorOrderResponse>(response);
        }

        public AsyncInvoker<CreateDeleteConnectorOrderResponse> CreateDeleteConnectorOrderAsyncInvoker(CreateDeleteConnectorOrderRequest createDeleteConnectorOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createDeleteConnectorOrderRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector-order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDeleteConnectorOrderRequest);
            return new AsyncInvoker<CreateDeleteConnectorOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDeleteConnectorOrderResponse>);
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
        /// Kafka实例创建Topic
        ///
        /// 该接口用于向Kafka实例创建Topic。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceTopicResponse> CreateInstanceTopicAsync(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceTopicResponse>(response);
        }

        public AsyncInvoker<CreateInstanceTopicResponse> CreateInstanceTopicAsyncInvoker(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            return new AsyncInvoker<CreateInstanceTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建Kafka实例的用户，用户可连接开启SASL的Kafka实例。 [ 2023年7月15日前创建的Kafka实例，一个实例最多创建20个用户。2023年7月15日及以后创建的Kafka实例，一个实例最多创建500个用户。](tag:hws,hws_hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceUserResponse> CreateInstanceUserAsync(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceUserResponse>(response);
        }

        public AsyncInvoker<CreateInstanceUserResponse> CreateInstanceUserAsyncInvoker(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createInstanceUserRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            return new AsyncInvoker<CreateInstanceUserResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceUserResponse>);
        }
        
        /// <summary>
        /// 创建消费组
        ///
        /// 实例创建消费组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKafkaConsumerGroupResponse> CreateKafkaConsumerGroupAsync(CreateKafkaConsumerGroupRequest createKafkaConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>(response);
        }

        public AsyncInvoker<CreateKafkaConsumerGroupResponse> CreateKafkaConsumerGroupAsyncInvoker(CreateKafkaConsumerGroupRequest createKafkaConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaConsumerGroupRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            return new AsyncInvoker<CreateKafkaConsumerGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 创建客户端流控配置
        ///
        /// 该接口用于向Kafka实例提交创建user、client级别的流控任务，若成功则返回流控任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKafkaUserClientQuotaTaskResponse> CreateKafkaUserClientQuotaTaskAsync(CreateKafkaUserClientQuotaTaskRequest createKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>(response);
        }

        public AsyncInvoker<CreateKafkaUserClientQuotaTaskResponse> CreateKafkaUserClientQuotaTaskAsyncInvoker(CreateKafkaUserClientQuotaTaskRequest createKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            return new AsyncInvoker<CreateKafkaUserClientQuotaTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPartitionRequest.InstanceId.ToString());
            urlParam.Add("topic", createPartitionRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePartitionResponse>(response);
        }

        public AsyncInvoker<CreatePartitionResponse> CreatePartitionAsyncInvoker(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createPartitionRequest.InstanceId.ToString());
            urlParam.Add("topic", createPartitionRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            return new AsyncInvoker<CreatePartitionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePartitionResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// [创建按需计费类型的Kafka实例。](tag:sbc,hk_sbc,cmcc)[创建kafka实例。](tag:otc)
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
        /// Kafka实例开始分区重平衡任务
        ///
        /// 该接口用于向Kafka实例提交分区重平衡任务，若成功则返回重平衡任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReassignmentTaskResponse> CreateReassignmentTaskAsync(CreateReassignmentTaskRequest createReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createReassignmentTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReassignmentTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReassignmentTaskResponse>(response);
        }

        public AsyncInvoker<CreateReassignmentTaskResponse> CreateReassignmentTaskAsyncInvoker(CreateReassignmentTaskRequest createReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", createReassignmentTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReassignmentTaskRequest);
            return new AsyncInvoker<CreateReassignmentTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReassignmentTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", createSinkTaskRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSinkTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSinkTaskResponse>(response);
        }

        public AsyncInvoker<CreateSinkTaskResponse> CreateSinkTaskAsyncInvoker(CreateSinkTaskRequest createSinkTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", createSinkTaskRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSinkTaskRequest);
            return new AsyncInvoker<CreateSinkTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSinkTaskResponse>);
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
        /// 关闭实例转储节点
        ///
        /// 关闭实例转储节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest deleteConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteConnectorResponse>(response);
        }

        public AsyncInvoker<DeleteConnectorResponse> DeleteConnectorAsyncInvoker(DeleteConnectorRequest deleteConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteConnectorRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            return new AsyncInvoker<DeleteConnectorResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteConnectorResponse>);
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
        /// 删除客户端流控设置
        ///
        /// 该接口用于向Kafka实例提交删除user、client级别的流控任务，若成功则返回流控任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKafkaUserClientQuotaTaskResponse> DeleteKafkaUserClientQuotaTaskAsync(DeleteKafkaUserClientQuotaTaskRequest deleteKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>(response);
        }

        public AsyncInvoker<DeleteKafkaUserClientQuotaTaskResponse> DeleteKafkaUserClientQuotaTaskAsyncInvoker(DeleteKafkaUserClientQuotaTaskRequest deleteKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", deleteKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            return new AsyncInvoker<DeleteKafkaUserClientQuotaTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", deleteSinkTaskRequest.ConnectorId.ToString());
            urlParam.Add("task_id", deleteSinkTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSinkTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSinkTaskResponse>(response);
        }

        public AsyncInvoker<DeleteSinkTaskResponse> DeleteSinkTaskAsyncInvoker(DeleteSinkTaskRequest deleteSinkTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", deleteSinkTaskRequest.ConnectorId.ToString());
            urlParam.Add("task_id", deleteSinkTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSinkTaskRequest);
            return new AsyncInvoker<DeleteSinkTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSinkTaskResponse>);
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
        /// 查询所有消费组
        ///
        /// 查询所有消费组。
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
        /// Kafka实例查询Topic
        ///
        /// 该接口用于查询指定Kafka实例的Topic详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTopicsResponse> ListInstanceTopicsAsync(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTopicsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTopicsResponse> ListInstanceTopicsAsyncInvoker(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listInstanceTopicsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            return new AsyncInvoker<ListInstanceTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTopicsResponse>);
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
        /// 查询转储任务列表
        ///
        /// 查询转储任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSinkTasksResponse> ListSinkTasksAsync(ListSinkTasksRequest listSinkTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", listSinkTasksRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSinkTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSinkTasksResponse>(response);
        }

        public AsyncInvoker<ListSinkTasksResponse> ListSinkTasksAsyncInvoker(ListSinkTasksRequest listSinkTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", listSinkTasksRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSinkTasksRequest);
            return new AsyncInvoker<ListSinkTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSinkTasksResponse>);
        }
        
        /// <summary>
        /// 查询Topic的分区列表
        ///
        /// 查询Topic的分区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicPartitionsResponse> ListTopicPartitionsAsync(ListTopicPartitionsRequest listTopicPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicPartitionsRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicPartitionsRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicPartitionsResponse>(response);
        }

        public AsyncInvoker<ListTopicPartitionsResponse> ListTopicPartitionsAsyncInvoker(ListTopicPartitionsRequest listTopicPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicPartitionsRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicPartitionsRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            return new AsyncInvoker<ListTopicPartitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicPartitionsResponse>);
        }
        
        /// <summary>
        /// 查询Topic的当前生产者列表
        ///
        /// 查询Topic的当前生产者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopicProducersResponse> ListTopicProducersAsync(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicProducersRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicProducersRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/producers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicProducersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTopicProducersResponse>(response);
        }

        public AsyncInvoker<ListTopicProducersResponse> ListTopicProducersAsyncInvoker(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", listTopicProducersRequest.InstanceId.ToString());
            urlParam.Add("topic", listTopicProducersRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/producers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicProducersRequest);
            return new AsyncInvoker<ListTopicProducersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicProducersResponse>);
        }
        
        /// <summary>
        /// 修改实例配置
        ///
        /// 修改实例配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyInstanceConfigsResponse> ModifyInstanceConfigsAsync(ModifyInstanceConfigsRequest modifyInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>(response);
        }

        public AsyncInvoker<ModifyInstanceConfigsResponse> ModifyInstanceConfigsAsyncInvoker(ModifyInstanceConfigsRequest modifyInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", modifyInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            return new AsyncInvoker<ModifyInstanceConfigsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetManagerPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>(response);
        }

        public AsyncInvoker<ResetManagerPasswordResponse> ResetManagerPasswordAsyncInvoker(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetManagerPasswordRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            return new AsyncInvoker<ResetManagerPasswordResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>);
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
        public async Task<ResetMessageOffsetResponse> ResetMessageOffsetAsync(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>(response);
        }

        public AsyncInvoker<ResetMessageOffsetResponse> ResetMessageOffsetAsyncInvoker(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetMessageOffsetRequest.InstanceId.ToString());
            urlParam.Add("group", resetMessageOffsetRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            return new AsyncInvoker<ResetMessageOffsetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>);
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
        /// 重置用户密码
        ///
        /// 重置用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetUserPasswrodResponse> ResetUserPasswrodAsync(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name", resetUserPasswrodRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>(response);
        }

        public AsyncInvoker<ResetUserPasswrodResponse> ResetUserPasswrodAsyncInvoker(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", resetUserPasswrodRequest.InstanceId.ToString());
            urlParam.Add("user_name", resetUserPasswrodRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            return new AsyncInvoker<ResetUserPasswrodResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。[当前通过调用API，只支持按需实例进行实例规格变更。](tag:hws,hws_hk,ctc,cmcc,hws_eu)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResizeEngineInstanceResponse> ResizeEngineInstanceAsync(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResizeEngineInstanceResponse>(response);
        }

        public AsyncInvoker<ResizeEngineInstanceResponse> ResizeEngineInstanceAsyncInvoker(ResizeEngineInstanceRequest resizeEngineInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", resizeEngineInstanceRequest.Engine.ToString());
            urlParam.Add("instance_id", resizeEngineInstanceRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeEngineInstanceRequest);
            return new AsyncInvoker<ResizeEngineInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeEngineInstanceResponse>);
        }
        
        /// <summary>
        /// 实例规格变更
        ///
        /// 实例规格变更。[当前通过调用API，只支持按需实例进行实例规格变更。](tag:hws,hws_hk,ctc,cmcc,hws_eu)
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
        /// 重启Manager
        ///
        /// 重启Manager。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RestartManagerResponse> RestartManagerAsync(RestartManagerRequest restartManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RestartManagerResponse>(response);
        }

        public AsyncInvoker<RestartManagerResponse> RestartManagerAsyncInvoker(RestartManagerRequest restartManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", restartManagerRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            return new AsyncInvoker<RestartManagerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestartManagerResponse>);
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
        /// 查询Kafka集群元数据信息
        ///
        /// 查询Kafka集群元数据信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClusterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public AsyncInvoker<ShowClusterResponse> ShowClusterAsyncInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showClusterRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            return new AsyncInvoker<ShowClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCoordinatorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCoordinatorsResponse>(response);
        }

        public AsyncInvoker<ShowCoordinatorsResponse> ShowCoordinatorsAsyncInvoker(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showCoordinatorsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            return new AsyncInvoker<ShowCoordinatorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCoordinatorsResponse>);
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
        /// 查询消费组信息
        ///
        /// 查询消费组信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupsResponse> ShowGroupsAsync(ShowGroupsRequest showGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsResponse>(response);
        }

        public AsyncInvoker<ShowGroupsResponse> ShowGroupsAsyncInvoker(ShowGroupsRequest showGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showGroupsRequest.InstanceId.ToString());
            urlParam.Add("group", showGroupsRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            return new AsyncInvoker<ShowGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupsResponse>);
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
        /// 获取实例配置
        ///
        /// 获取实例配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceConfigsResponse> ShowInstanceConfigsAsync(ShowInstanceConfigsRequest showInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigsResponse>(response);
        }

        public AsyncInvoker<ShowInstanceConfigsResponse> ShowInstanceConfigsAsyncInvoker(ShowInstanceConfigsRequest showInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceConfigsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            return new AsyncInvoker<ShowInstanceConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigsResponse>);
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
        /// 查询消息
        ///
        /// 查询消息的偏移量和消息内容。
        /// 先根据时间戳查询消息的偏移量，再根据偏移量查询消息内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceMessagesResponse> ShowInstanceMessagesAsync(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMessagesResponse>(response);
        }

        public AsyncInvoker<ShowInstanceMessagesResponse> ShowInstanceMessagesAsyncInvoker(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceMessagesRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            return new AsyncInvoker<ShowInstanceMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceMessagesResponse>);
        }
        
        /// <summary>
        /// 查询Kafka实例Topic详细信息
        ///
        /// 查询Kafka实例Topic详细信息。(单个实例调用不要超过1s一次)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceTopicDetailResponse> ShowInstanceTopicDetailAsync(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic", showInstanceTopicDetailRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>(response);
        }

        public AsyncInvoker<ShowInstanceTopicDetailResponse> ShowInstanceTopicDetailAsyncInvoker(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceTopicDetailRequest.InstanceId.ToString());
            urlParam.Add("topic", showInstanceTopicDetailRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            return new AsyncInvoker<ShowInstanceTopicDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceUsersResponse>(response);
        }

        public AsyncInvoker<ShowInstanceUsersResponse> ShowInstanceUsersAsyncInvoker(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showInstanceUsersRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            return new AsyncInvoker<ShowInstanceUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceUsersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>(response);
        }

        public AsyncInvoker<ShowKafkaProjectTagsResponse> ShowKafkaProjectTagsAsyncInvoker(ShowKafkaProjectTagsRequest showKafkaProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProjectTagsRequest);
            return new AsyncInvoker<ShowKafkaProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaProjectTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTagsResponse>(response);
        }

        public AsyncInvoker<ShowKafkaTagsResponse> ShowKafkaTagsAsyncInvoker(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTagsRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            return new AsyncInvoker<ShowKafkaTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>(response);
        }

        public AsyncInvoker<ShowKafkaTopicPartitionDiskusageResponse> ShowKafkaTopicPartitionDiskusageAsyncInvoker(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaTopicPartitionDiskusageRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            return new AsyncInvoker<ShowKafkaTopicPartitionDiskusageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>);
        }
        
        /// <summary>
        /// 查询客户端流控配置
        ///
        /// 该接口用于向Kafka实例查询流控的配置，若成功则返回流控配置的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKafkaUserClientQuotaResponse> ShowKafkaUserClientQuotaAsync(ShowKafkaUserClientQuotaRequest showKafkaUserClientQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaUserClientQuotaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaUserClientQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaUserClientQuotaResponse>(response);
        }

        public AsyncInvoker<ShowKafkaUserClientQuotaResponse> ShowKafkaUserClientQuotaAsyncInvoker(ShowKafkaUserClientQuotaRequest showKafkaUserClientQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showKafkaUserClientQuotaRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaUserClientQuotaRequest);
            return new AsyncInvoker<ShowKafkaUserClientQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaUserClientQuotaResponse>);
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
        /// 查询分区指定时间段的消息
        ///
        /// 查询分区指定时间段的消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMessagesResponse> ShowMessagesAsync(ShowMessagesRequest showMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic", showMessagesRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMessagesResponse>(response);
        }

        public AsyncInvoker<ShowMessagesResponse> ShowMessagesAsyncInvoker(ShowMessagesRequest showMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showMessagesRequest.InstanceId.ToString());
            urlParam.Add("topic", showMessagesRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            return new AsyncInvoker<ShowMessagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMessagesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionBeginningMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>(response);
        }

        public AsyncInvoker<ShowPartitionBeginningMessageResponse> ShowPartitionBeginningMessageAsyncInvoker(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionBeginningMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionBeginningMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionBeginningMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            return new AsyncInvoker<ShowPartitionBeginningMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionEndMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>(response);
        }

        public AsyncInvoker<ShowPartitionEndMessageResponse> ShowPartitionEndMessageAsyncInvoker(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionEndMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionEndMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionEndMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            return new AsyncInvoker<ShowPartitionEndMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionMessageResponse>(response);
        }

        public AsyncInvoker<ShowPartitionMessageResponse> ShowPartitionMessageAsyncInvoker(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showPartitionMessageRequest.InstanceId.ToString());
            urlParam.Add("topic", showPartitionMessageRequest.Topic.ToString());
            urlParam.Add("partition", showPartitionMessageRequest.Partition.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            return new AsyncInvoker<ShowPartitionMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionMessageResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", showSinkTaskDetailRequest.ConnectorId.ToString());
            urlParam.Add("task_id", showSinkTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSinkTaskDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSinkTaskDetailResponse>(response);
        }

        public AsyncInvoker<ShowSinkTaskDetailResponse> ShowSinkTaskDetailAsyncInvoker(ShowSinkTaskDetailRequest showSinkTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", showSinkTaskDetailRequest.ConnectorId.ToString());
            urlParam.Add("task_id", showSinkTaskDetailRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSinkTaskDetailRequest);
            return new AsyncInvoker<ShowSinkTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSinkTaskDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name", showTopicAccessPolicyRequest.TopicName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>(response);
        }

        public AsyncInvoker<ShowTopicAccessPolicyResponse> ShowTopicAccessPolicyAsyncInvoker(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", showTopicAccessPolicyRequest.InstanceId.ToString());
            urlParam.Add("topic_name", showTopicAccessPolicyRequest.TopicName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            return new AsyncInvoker<ShowTopicAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>);
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
        /// 开启或关闭实例自动创建topic功能
        ///
        /// 开启或关闭实例自动创建topic功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceAutoCreateTopicResponse> UpdateInstanceAutoCreateTopicAsync(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceAutoCreateTopicResponse> UpdateInstanceAutoCreateTopicAsyncInvoker(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceAutoCreateTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            return new AsyncInvoker<UpdateInstanceAutoCreateTopicResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>);
        }
        
        /// <summary>
        /// 编辑消费组
        ///
        /// 编辑消费组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConsumerGroupResponse> UpdateInstanceConsumerGroupAsync(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceConsumerGroupRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateInstanceConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConsumerGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceConsumerGroupResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConsumerGroupResponse> UpdateInstanceConsumerGroupAsyncInvoker(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceConsumerGroupRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceConsumerGroupRequest.InstanceId.ToString());
            urlParam.Add("group", updateInstanceConsumerGroupRequest.Group.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConsumerGroupRequest);
            return new AsyncInvoker<UpdateInstanceConsumerGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceConsumerGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceCrossVpcIpResponse> UpdateInstanceCrossVpcIpAsyncInvoker(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceCrossVpcIpRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            return new AsyncInvoker<UpdateInstanceCrossVpcIpResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceTopicResponse> UpdateInstanceTopicAsyncInvoker(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateInstanceTopicRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            return new AsyncInvoker<UpdateInstanceTopicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 修改用户参数
        ///
        /// 修改用户参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceUserResponse> UpdateInstanceUserAsync(UpdateInstanceUserRequest updateInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceUserRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateInstanceUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceUserResponse> UpdateInstanceUserAsyncInvoker(UpdateInstanceUserRequest updateInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("engine", updateInstanceUserRequest.Engine.ToString());
            urlParam.Add("instance_id", updateInstanceUserRequest.InstanceId.ToString());
            urlParam.Add("user_name", updateInstanceUserRequest.UserName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            return new AsyncInvoker<UpdateInstanceUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>);
        }
        
        /// <summary>
        /// 修改客户端流控设置
        ///
        /// 该接口用于向Kafka实例提交修改user、client级别的流控任务，若成功则返回流控任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKafkaUserClientQuotaTaskResponse> UpdateKafkaUserClientQuotaTaskAsync(UpdateKafkaUserClientQuotaTaskRequest updateKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>(response);
        }

        public AsyncInvoker<UpdateKafkaUserClientQuotaTaskResponse> UpdateKafkaUserClientQuotaTaskAsyncInvoker(UpdateKafkaUserClientQuotaTaskRequest updateKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateKafkaUserClientQuotaTaskRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            return new AsyncInvoker<UpdateKafkaUserClientQuotaTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>);
        }
        
        /// <summary>
        /// 修改转储任务的配额
        ///
        /// 修改转储任务的配额。
        /// 
        /// 2022年9月前创建的实例支持调用此接口新增转储任务配额，2022年9月及以后创建的实例，转储任务配额默认为最大值，由于转储任务配额不支持减少，调用此接口修改转储任务配额会报错。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSinkTaskQuotaResponse> UpdateSinkTaskQuotaAsync(UpdateSinkTaskQuotaRequest updateSinkTaskQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", updateSinkTaskQuotaRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSinkTaskQuotaRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSinkTaskQuotaResponse>(response);
        }

        public AsyncInvoker<UpdateSinkTaskQuotaResponse> UpdateSinkTaskQuotaAsyncInvoker(UpdateSinkTaskQuotaRequest updateSinkTaskQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connector_id", updateSinkTaskQuotaRequest.ConnectorId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/connectors/{connector_id}/sink-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSinkTaskQuotaRequest);
            return new AsyncInvoker<UpdateSinkTaskQuotaResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSinkTaskQuotaResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicAccessPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateTopicAccessPolicyResponse> UpdateTopicAccessPolicyAsyncInvoker(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicAccessPolicyRequest.InstanceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            return new AsyncInvoker<UpdateTopicAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTopicAccessPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicReplicaRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>(response);
        }

        public AsyncInvoker<UpdateTopicReplicaResponse> UpdateTopicReplicaAsyncInvoker(UpdateTopicReplicaRequest updateTopicReplicaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id", updateTopicReplicaRequest.InstanceId.ToString());
            urlParam.Add("topic", updateTopicReplicaRequest.Topic.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/replicas-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicReplicaRequest);
            return new AsyncInvoker<UpdateTopicReplicaResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTopicReplicaResponse>);
        }
        
    }
}