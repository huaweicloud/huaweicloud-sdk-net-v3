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
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteKafkaTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>(response);
        }

        public SyncInvoker<BatchCreateOrDeleteKafkaTagResponse> BatchCreateOrDeleteKafkaTagInvoker(BatchCreateOrDeleteKafkaTagRequest batchCreateOrDeleteKafkaTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateOrDeleteKafkaTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteKafkaTagRequest);
            return new SyncInvoker<BatchCreateOrDeleteKafkaTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateOrDeleteKafkaTagResponse>);
        }
        
        /// <summary>
        /// Kafka实例批量删除消费组
        ///
        /// 该接口用于向Kafka实例批量删除消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteGroupResponse BatchDeleteGroup(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteGroupResponse>(response);
        }

        public SyncInvoker<BatchDeleteGroupResponse> BatchDeleteGroupInvoker(BatchDeleteGroupRequest batchDeleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteInstanceTopicResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstanceTopicResponse> BatchDeleteInstanceTopicInvoker(BatchDeleteInstanceTopicRequest batchDeleteInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>(response);
        }

        public SyncInvoker<BatchDeleteInstanceUsersResponse> BatchDeleteInstanceUsersInvoker(BatchDeleteInstanceUsersRequest batchDeleteInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteInstanceUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInstanceUsersRequest);
            return new SyncInvoker<BatchDeleteInstanceUsersResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<BatchDeleteInstanceUsersResponse>);
        }
        
        /// <summary>
        /// 批量删除消息积压诊断报告
        ///
        /// 批量删除消息积压诊断报告
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteMessageDiagnosisReportsResponse BatchDeleteMessageDiagnosisReports(BatchDeleteMessageDiagnosisReportsRequest batchDeleteMessageDiagnosisReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMessageDiagnosisReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMessageDiagnosisReportsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteMessageDiagnosisReportsResponse>(response);
        }

        public SyncInvoker<BatchDeleteMessageDiagnosisReportsResponse> BatchDeleteMessageDiagnosisReportsInvoker(BatchDeleteMessageDiagnosisReportsRequest batchDeleteMessageDiagnosisReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteMessageDiagnosisReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteMessageDiagnosisReportsRequest);
            return new SyncInvoker<BatchDeleteMessageDiagnosisReportsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteMessageDiagnosisReportsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(closeKafkaManagerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>(response);
        }

        public SyncInvoker<CloseKafkaManagerResponse> CloseKafkaManagerInvoker(CloseKafkaManagerRequest closeKafkaManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(closeKafkaManagerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/management", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", closeKafkaManagerRequest);
            return new SyncInvoker<CloseKafkaManagerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<CloseKafkaManagerResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建实例。
        /// 
        /// [该接口支持创建按需和包周期两种计费方式的实例。](tag:hws,hws_eu,hws_hk,ctc)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceByEngineResponse CreateInstanceByEngine(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceByEngineRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceByEngineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceByEngineResponse>(response);
        }

        public SyncInvoker<CreateInstanceByEngineResponse> CreateInstanceByEngineInvoker(CreateInstanceByEngineRequest createInstanceByEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceByEngineRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
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
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceTopicResponse>(response);
        }

        public SyncInvoker<CreateInstanceTopicResponse> CreateInstanceTopicInvoker(CreateInstanceTopicRequest createInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTopicRequest);
            return new SyncInvoker<CreateInstanceTopicResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceTopicResponse>);
        }
        
        /// <summary>
        /// 创建用户
        ///
        /// 创建Kafka实例的用户，用户可连接开启SASL的Kafka实例。 [ 2023年7月15日前创建的Kafka实例，一个实例最多创建20个用户。2023年7月15日及以后创建的Kafka实例，一个实例最多创建500个用户。](tag:hws,hws_hk) [一个实例最多创建500个用户。](tag:fcs,ax,hcs)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceUserResponse CreateInstanceUser(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceUserResponse>(response);
        }

        public SyncInvoker<CreateInstanceUserResponse> CreateInstanceUserInvoker(CreateInstanceUserRequest createInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(createKafkaConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>(response);
        }

        public SyncInvoker<CreateKafkaConsumerGroupResponse> CreateKafkaConsumerGroupInvoker(CreateKafkaConsumerGroupRequest createKafkaConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaConsumerGroupRequest);
            return new SyncInvoker<CreateKafkaConsumerGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateKafkaConsumerGroupResponse>);
        }
        
        /// <summary>
        /// Kafka实例开始分区平衡任务
        ///
        /// 该接口用于向Kafka实例提交分区平衡任务，若成功则返回分区平衡任务的job id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKafkaReassignmentTaskResponse CreateKafkaReassignmentTask(CreateKafkaReassignmentTaskRequest createKafkaReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaReassignmentTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaReassignmentTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaReassignmentTaskResponse>(response);
        }

        public SyncInvoker<CreateKafkaReassignmentTaskResponse> CreateKafkaReassignmentTaskInvoker(CreateKafkaReassignmentTaskRequest createKafkaReassignmentTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaReassignmentTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/reassign", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaReassignmentTaskRequest);
            return new SyncInvoker<CreateKafkaReassignmentTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaReassignmentTaskResponse>);
        }
        
        /// <summary>
        /// 开启Kafka实例重平衡日志功能
        ///
        /// 开启Kafka实例重平衡日志功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKafkaRebalanceLogTaskResponse CreateKafkaRebalanceLogTask(CreateKafkaRebalanceLogTaskRequest createKafkaRebalanceLogTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaRebalanceLogTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaRebalanceLogTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaRebalanceLogTaskResponse>(response);
        }

        public SyncInvoker<CreateKafkaRebalanceLogTaskResponse> CreateKafkaRebalanceLogTaskInvoker(CreateKafkaRebalanceLogTaskRequest createKafkaRebalanceLogTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaRebalanceLogTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaRebalanceLogTaskRequest);
            return new SyncInvoker<CreateKafkaRebalanceLogTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaRebalanceLogTaskResponse>);
        }
        
        /// <summary>
        /// 创建Topic流控配置
        ///
        /// 该接口用于向Kafka实例提交创建Topic级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKafkaTopicQuotaResponse CreateKafkaTopicQuota(CreateKafkaTopicQuotaRequest createKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaTopicQuotaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaTopicQuotaResponse>(response);
        }

        public SyncInvoker<CreateKafkaTopicQuotaResponse> CreateKafkaTopicQuotaInvoker(CreateKafkaTopicQuotaRequest createKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaTopicQuotaRequest);
            return new SyncInvoker<CreateKafkaTopicQuotaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaTopicQuotaResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(createKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<CreateKafkaUserClientQuotaTaskResponse> CreateKafkaUserClientQuotaTaskInvoker(CreateKafkaUserClientQuotaTaskRequest createKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<CreateKafkaUserClientQuotaTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKafkaUserClientQuotaTaskResponse>);
        }
        
        /// <summary>
        /// 创建消息积压诊断任务
        ///
        /// 创建消息积压诊断任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMessageDiagnosisTaskResponse CreateMessageDiagnosisTask(CreateMessageDiagnosisTaskRequest createMessageDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMessageDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageDiagnosisTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMessageDiagnosisTaskResponse>(response);
        }

        public SyncInvoker<CreateMessageDiagnosisTaskResponse> CreateMessageDiagnosisTaskInvoker(CreateMessageDiagnosisTaskRequest createMessageDiagnosisTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMessageDiagnosisTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMessageDiagnosisTaskRequest);
            return new SyncInvoker<CreateMessageDiagnosisTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMessageDiagnosisTaskResponse>);
        }
        
        /// <summary>
        /// 新增Kafka实例指定Topic分区
        ///
        /// 新增Kafka实例指定Topic分区。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePartitionResponse CreatePartition(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePartitionResponse>(response);
        }

        public SyncInvoker<CreatePartitionResponse> CreatePartitionInvoker(CreatePartitionRequest createPartitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createPartitionRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions-reassignment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPartitionRequest);
            return new SyncInvoker<CreatePartitionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePartitionResponse>);
        }
        
        /// <summary>
        /// 创建Kafka实例
        ///
        /// 创建实例。
        /// 
        /// [该接口支持创建按需和包周期两种计费方式的实例。](tag:hws,hws_eu,hws_hk,ctc,cmcc,ax)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePostPaidKafkaInstanceResponse CreatePostPaidKafkaInstance(CreatePostPaidKafkaInstanceRequest createPostPaidKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidKafkaInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePostPaidKafkaInstanceResponse>(response);
        }

        public SyncInvoker<CreatePostPaidKafkaInstanceResponse> CreatePostPaidKafkaInstanceInvoker(CreatePostPaidKafkaInstanceRequest createPostPaidKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPostPaidKafkaInstanceRequest);
            return new SyncInvoker<CreatePostPaidKafkaInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePostPaidKafkaInstanceResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>(response);
        }

        public SyncInvoker<DeleteBackgroundTaskResponse> DeleteBackgroundTaskInvoker(DeleteBackgroundTaskRequest deleteBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackgroundTaskRequest);
            return new SyncInvoker<DeleteBackgroundTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 删除消费组在指定Topic的消费位点
        ///
        /// 删除消费组在指定Topic的消费位点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConsumerGroupOffsetsResponse DeleteConsumerGroupOffsets(DeleteConsumerGroupOffsetsRequest deleteConsumerGroupOffsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConsumerGroupOffsetsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteConsumerGroupOffsetsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/groups/{group}/delete-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupOffsetsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteConsumerGroupOffsetsResponse>(response);
        }

        public SyncInvoker<DeleteConsumerGroupOffsetsResponse> DeleteConsumerGroupOffsetsInvoker(DeleteConsumerGroupOffsetsRequest deleteConsumerGroupOffsetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConsumerGroupOffsetsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteConsumerGroupOffsetsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/groups/{group}/delete-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConsumerGroupOffsetsRequest);
            return new SyncInvoker<DeleteConsumerGroupOffsetsResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteConsumerGroupOffsetsResponse>);
        }
        
        /// <summary>
        /// kafka实例删除指定消费组
        ///
        /// kafka实例删除指定消费组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public SyncInvoker<DeleteGroupResponse> DeleteGroupInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new SyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 删除指定的实例
        ///
        /// 删除指定的实例，释放该实例的所有资源。
        /// 
        /// [注意：调用本接口删除的实例将被彻底删除，不会进入回收站，且删除后不可恢复。若您需要删除的实例进入回收站，请使用[批量重启或删除实例](BatchRestartOrDeleteInstances.xml)。](tag:hws,hws_hk,cmcc,ctc,sbc,hk_sbc,tm,hk_tm,srg)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除指定消费组
        ///
        /// 删除指定消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceConsumerGroupResponse DeleteInstanceConsumerGroup(DeleteInstanceConsumerGroupRequest deleteInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceConsumerGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceConsumerGroupResponse>(response);
        }

        public SyncInvoker<DeleteInstanceConsumerGroupResponse> DeleteInstanceConsumerGroupInvoker(DeleteInstanceConsumerGroupRequest deleteInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceConsumerGroupRequest);
            return new SyncInvoker<DeleteInstanceConsumerGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 删除Kafka消息
        ///
        /// 删除Kafka消息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKafkaTopicMessagesResponse DeleteKafkaTopicMessages(DeleteKafkaTopicMessagesRequest deleteKafkaTopicMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicMessagesRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/messages/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaTopicMessagesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteKafkaTopicMessagesResponse>(response);
        }

        public SyncInvoker<DeleteKafkaTopicMessagesResponse> DeleteKafkaTopicMessagesInvoker(DeleteKafkaTopicMessagesRequest deleteKafkaTopicMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicMessagesRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/messages/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaTopicMessagesRequest);
            return new SyncInvoker<DeleteKafkaTopicMessagesResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteKafkaTopicMessagesResponse>);
        }
        
        /// <summary>
        /// 删除Topic流控配置
        ///
        /// 该接口用于向Kafka实例提交删除Topic级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKafkaTopicQuotaResponse DeleteKafkaTopicQuota(DeleteKafkaTopicQuotaRequest deleteKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaTopicQuotaRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteKafkaTopicQuotaResponse>(response);
        }

        public SyncInvoker<DeleteKafkaTopicQuotaResponse> DeleteKafkaTopicQuotaInvoker(DeleteKafkaTopicQuotaRequest deleteKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaTopicQuotaRequest);
            return new SyncInvoker<DeleteKafkaTopicQuotaResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteKafkaTopicQuotaResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<DeleteKafkaUserClientQuotaTaskResponse> DeleteKafkaUserClientQuotaTaskInvoker(DeleteKafkaUserClientQuotaTaskRequest deleteKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<DeleteKafkaUserClientQuotaTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteKafkaUserClientQuotaTaskResponse>);
        }
        
        /// <summary>
        /// 删除指定的定时任务
        ///
        /// 删除指定的定时任务。仅当定时任务处于执行成功或已取消状态时，方可执行删除操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduledTaskResponse DeleteScheduledTask(DeleteScheduledTaskRequest deleteScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduledTaskResponse>(response);
        }

        public SyncInvoker<DeleteScheduledTaskResponse> DeleteScheduledTaskInvoker(DeleteScheduledTaskRequest deleteScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduledTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduledTaskRequest);
            return new SyncInvoker<DeleteScheduledTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduledTaskResponse>);
        }
        
        /// <summary>
        /// 开启Kafka实例域名访问能力
        ///
        /// 开启Kafka实例域名访问后，客户端可以通过域名连接Kafka实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDnsResponse EnableDns(EnableDnsRequest enableDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDnsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/dns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDnsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableDnsResponse>(response);
        }

        public SyncInvoker<EnableDnsResponse> EnableDnsInvoker(EnableDnsRequest enableDnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDnsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/dns", urlParam);
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
            if (StringUtils.TryConvertToNonEmptyString(listBackgroundTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBackgroundTasksResponse>(response);
        }

        public SyncInvoker<ListBackgroundTasksResponse> ListBackgroundTasksInvoker(ListBackgroundTasksRequest listBackgroundTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBackgroundTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackgroundTasksRequest);
            return new SyncInvoker<ListBackgroundTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBackgroundTasksResponse>);
        }
        
        /// <summary>
        /// 查询特性开关列表
        ///
        /// 获取特性开关列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListConfigFeaturesResponse ListConfigFeatures(ListConfigFeaturesRequest listConfigFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/config/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigFeaturesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConfigFeaturesResponse>(response);
        }

        public SyncInvoker<ListConfigFeaturesResponse> ListConfigFeaturesInvoker(ListConfigFeaturesRequest listConfigFeaturesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/config/features", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConfigFeaturesRequest);
            return new SyncInvoker<ListConfigFeaturesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConfigFeaturesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listEngineProductsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEngineProductsResponse>(response);
        }

        public SyncInvoker<ListEngineProductsResponse> ListEngineProductsInvoker(ListEngineProductsRequest listEngineProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEngineProductsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEngineProductsRequest);
            return new SyncInvoker<ListEngineProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEngineProductsResponse>);
        }
        
        /// <summary>
        /// 查询指定消费组
        ///
        /// 查询指定消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConsumerGroupResponse ListInstanceConsumerGroup(ListInstanceConsumerGroupRequest listInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupResponse> ListInstanceConsumerGroupInvoker(ListInstanceConsumerGroupRequest listInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupRequest);
            return new SyncInvoker<ListInstanceConsumerGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupResponse>);
        }
        
        /// <summary>
        /// 查询指定消费组的消费成员
        ///
        /// 查询指定消费组的消费成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConsumerGroupMembersResponse ListInstanceConsumerGroupMembers(ListInstanceConsumerGroupMembersRequest listInstanceConsumerGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupMembersResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupMembersResponse> ListInstanceConsumerGroupMembersInvoker(ListInstanceConsumerGroupMembersRequest listInstanceConsumerGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMembersRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupMembersRequest);
            return new SyncInvoker<ListInstanceConsumerGroupMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupMembersResponse>);
        }
        
        /// <summary>
        /// 查询消费组消息位点
        ///
        /// 查询消费组消息位点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConsumerGroupMessageOffsetResponse ListInstanceConsumerGroupMessageOffset(ListInstanceConsumerGroupMessageOffsetRequest listInstanceConsumerGroupMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupMessageOffsetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupMessageOffsetResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupMessageOffsetResponse> ListInstanceConsumerGroupMessageOffsetInvoker(ListInstanceConsumerGroupMessageOffsetRequest listInstanceConsumerGroupMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupMessageOffsetRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupMessageOffsetRequest);
            return new SyncInvoker<ListInstanceConsumerGroupMessageOffsetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupMessageOffsetResponse>);
        }
        
        /// <summary>
        /// 查询指定消费组的Topic
        ///
        /// 查询指定消费组的Topic。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceConsumerGroupTopicsResponse ListInstanceConsumerGroupTopics(ListInstanceConsumerGroupTopicsRequest listInstanceConsumerGroupTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupTopicsResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupTopicsResponse> ListInstanceConsumerGroupTopicsInvoker(ListInstanceConsumerGroupTopicsRequest listInstanceConsumerGroupTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupTopicsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupTopicsRequest);
            return new SyncInvoker<ListInstanceConsumerGroupTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceConsumerGroupTopicsResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceConsumerGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceConsumerGroupsResponse>(response);
        }

        public SyncInvoker<ListInstanceConsumerGroupsResponse> ListInstanceConsumerGroupsInvoker(ListInstanceConsumerGroupsRequest listInstanceConsumerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceConsumerGroupsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTopicsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTopicsResponse>(response);
        }

        public SyncInvoker<ListInstanceTopicsResponse> ListInstanceTopicsInvoker(ListInstanceTopicsRequest listInstanceTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTopicsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询消息积压诊断报告列表
        ///
        /// 查询消息积压诊断报告列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMessageDiagnosisReportsResponse ListMessageDiagnosisReports(ListMessageDiagnosisReportsRequest listMessageDiagnosisReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMessageDiagnosisReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageDiagnosisReportsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMessageDiagnosisReportsResponse>(response);
        }

        public SyncInvoker<ListMessageDiagnosisReportsResponse> ListMessageDiagnosisReportsInvoker(ListMessageDiagnosisReportsRequest listMessageDiagnosisReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMessageDiagnosisReportsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageDiagnosisReportsRequest);
            return new SyncInvoker<ListMessageDiagnosisReportsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMessageDiagnosisReportsResponse>);
        }
        
        /// <summary>
        /// 查询实例的定时任务列表
        ///
        /// 查询实例的定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduledTasksResponse ListScheduledTasks(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduledTasksResponse>(response);
        }

        public SyncInvoker<ListScheduledTasksResponse> ListScheduledTasksInvoker(ListScheduledTasksRequest listScheduledTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listScheduledTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduledTasksRequest);
            return new SyncInvoker<ListScheduledTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduledTasksResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(listTopicPartitionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listTopicPartitionsRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicPartitionsResponse>(response);
        }

        public SyncInvoker<ListTopicPartitionsResponse> ListTopicPartitionsInvoker(ListTopicPartitionsRequest listTopicPartitionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicPartitionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listTopicPartitionsRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/partitions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicPartitionsRequest);
            return new SyncInvoker<ListTopicPartitionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTopicPartitionsResponse>);
        }
        
        /// <summary>
        /// 查询Topic的当前生产者列表
        ///
        /// 查询Topic的当前生产者列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopicProducersResponse ListTopicProducers(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicProducersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listTopicProducersRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/topics/{topic}/producers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicProducersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTopicProducersResponse>(response);
        }

        public SyncInvoker<ListTopicProducersResponse> ListTopicProducersInvoker(ListTopicProducersRequest listTopicProducersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTopicProducersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listTopicProducersRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
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
            if (StringUtils.TryConvertToNonEmptyString(modifyInstanceConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>(response);
        }

        public SyncInvoker<ModifyInstanceConfigsResponse> ModifyInstanceConfigsInvoker(ModifyInstanceConfigsRequest modifyInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyInstanceConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyInstanceConfigsRequest);
            return new SyncInvoker<ModifyInstanceConfigsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyInstanceConfigsResponse>);
        }
        
        /// <summary>
        /// 开启或者关闭Kafka实例公网访问功能
        ///
        /// 开启或者关闭Kafka实例公网访问功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyKafkaPublicIpAccessSwitchResponse ModifyKafkaPublicIpAccessSwitch(ModifyKafkaPublicIpAccessSwitchRequest modifyKafkaPublicIpAccessSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyKafkaPublicIpAccessSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/public-boundwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyKafkaPublicIpAccessSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ModifyKafkaPublicIpAccessSwitchResponse>(response);
        }

        public SyncInvoker<ModifyKafkaPublicIpAccessSwitchResponse> ModifyKafkaPublicIpAccessSwitchInvoker(ModifyKafkaPublicIpAccessSwitchRequest modifyKafkaPublicIpAccessSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyKafkaPublicIpAccessSwitchRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/public-boundwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyKafkaPublicIpAccessSwitchRequest);
            return new SyncInvoker<ModifyKafkaPublicIpAccessSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ModifyKafkaPublicIpAccessSwitchResponse>);
        }
        
        /// <summary>
        /// 修改Topic流控配置
        ///
        /// 该接口用于向Kafka实例提交修改Topic级别的流控任务，若成功则返回流控任务的job_id。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyKafkaTopicQuotaResponse ModifyKafkaTopicQuota(ModifyKafkaTopicQuotaRequest modifyKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyKafkaTopicQuotaRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyKafkaTopicQuotaResponse>(response);
        }

        public SyncInvoker<ModifyKafkaTopicQuotaResponse> ModifyKafkaTopicQuotaInvoker(ModifyKafkaTopicQuotaRequest modifyKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyKafkaTopicQuotaRequest);
            return new SyncInvoker<ModifyKafkaTopicQuotaResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyKafkaTopicQuotaResponse>);
        }
        
        /// <summary>
        /// 更新回收站策略
        ///
        /// 更新回收站策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyRecyclePolicyResponse ModifyRecyclePolicy(ModifyRecyclePolicyRequest modifyRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRecyclePolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyRecyclePolicyResponse>(response);
        }

        public SyncInvoker<ModifyRecyclePolicyResponse> ModifyRecyclePolicyInvoker(ModifyRecyclePolicyRequest modifyRecyclePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRecyclePolicyRequest);
            return new SyncInvoker<ModifyRecyclePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyRecyclePolicyResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(resetManagerPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/kafka-manager-password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetManagerPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetManagerPasswordResponse>(response);
        }

        public SyncInvoker<ResetManagerPasswordResponse> ResetManagerPasswordInvoker(ResetManagerPasswordRequest resetManagerPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetManagerPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetResponse>(response);
        }

        public SyncInvoker<ResetMessageOffsetResponse> ResetMessageOffsetInvoker(ResetMessageOffsetRequest resetMessageOffsetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
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
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetWithEngineRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetWithEngineRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/groups/{group}/reset-message-offset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetMessageOffsetWithEngineRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetMessageOffsetWithEngineResponse>(response);
        }

        public SyncInvoker<ResetMessageOffsetWithEngineResponse> ResetMessageOffsetWithEngineInvoker(ResetMessageOffsetWithEngineRequest resetMessageOffsetWithEngineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetWithEngineRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetMessageOffsetWithEngineRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
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
            if (StringUtils.TryConvertToNonEmptyString(resetPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/password", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetPasswordResponse>(response);
        }

        public SyncInvoker<ResetPasswordResponse> ResetPasswordInvoker(ResetPasswordRequest resetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetPasswordRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswrodRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswrodRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>(response);
        }

        public SyncInvoker<ResetUserPasswrodResponse> ResetUserPasswrodInvoker(ResetUserPasswrodRequest resetUserPasswrodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswrodRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resetUserPasswrodRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswrodRequest);
            return new SyncInvoker<ResetUserPasswrodResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResetUserPasswrodResponse>);
        }
        
        /// <summary>
        /// 实例扩容
        ///
        /// 实例规格变更。[当前通过调用API，只支持按需实例进行实例扩容。](tag:hws,hws_hk,ctc,cmcc,hws_eu,ax)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResizeKafkaInstanceResponse ResizeKafkaInstance(ResizeKafkaInstanceRequest resizeKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeKafkaInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeKafkaInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResizeKafkaInstanceResponse>(response);
        }

        public SyncInvoker<ResizeKafkaInstanceResponse> ResizeKafkaInstanceInvoker(ResizeKafkaInstanceRequest resizeKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resizeKafkaInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resizeKafkaInstanceRequest);
            return new SyncInvoker<ResizeKafkaInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ResizeKafkaInstanceResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(restartManagerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RestartManagerResponse>(response);
        }

        public SyncInvoker<RestartManagerResponse> RestartManagerInvoker(RestartManagerRequest restartManagerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartManagerRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/restart-kafka-manager", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartManagerRequest);
            return new SyncInvoker<RestartManagerResponse>(this, "PUT", request, JsonUtils.DeSerialize<RestartManagerResponse>);
        }
        
        /// <summary>
        /// 恢复回收站实例
        ///
        /// 恢复回收站实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreRecycleInstanceResponse RestoreRecycleInstance(RestoreRecycleInstanceRequest restoreRecycleInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreRecycleInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RestoreRecycleInstanceResponse>(response);
        }

        public SyncInvoker<RestoreRecycleInstanceResponse> RestoreRecycleInstanceInvoker(RestoreRecycleInstanceRequest restoreRecycleInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreRecycleInstanceRequest);
            return new SyncInvoker<RestoreRecycleInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RestoreRecycleInstanceResponse>);
        }
        
        /// <summary>
        /// Kafka生产消息
        ///
        /// 在控制台发送指定消息到Kafka实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendKafkaMessageResponse SendKafkaMessage(SendKafkaMessageRequest sendKafkaMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendKafkaMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendKafkaMessageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendKafkaMessageResponse>(response);
        }

        public SyncInvoker<SendKafkaMessageResponse> SendKafkaMessageInvoker(SendKafkaMessageRequest sendKafkaMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(sendKafkaMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskResponse>(response);
        }

        public SyncInvoker<ShowBackgroundTaskResponse> ShowBackgroundTaskInvoker(ShowBackgroundTaskRequest showBackgroundTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskRequest);
            return new SyncInvoker<ShowBackgroundTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskResponse>);
        }
        
        /// <summary>
        /// 查询后台任务中的指定实例的变更进度
        ///
        /// 查询后台任务中的指定实例的变更进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBackgroundTaskProgressResponse ShowBackgroundTaskProgress(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>(response);
        }

        public SyncInvoker<ShowBackgroundTaskProgressResponse> ShowBackgroundTaskProgressInvoker(ShowBackgroundTaskProgressRequest showBackgroundTaskProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showBackgroundTaskProgressRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackgroundTaskProgressRequest);
            return new SyncInvoker<ShowBackgroundTaskProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBackgroundTaskProgressResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showCesHierarchyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/ces-hierarchy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCesHierarchyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCesHierarchyResponse>(response);
        }

        public SyncInvoker<ShowCesHierarchyResponse> ShowCesHierarchyInvoker(ShowCesHierarchyRequest showCesHierarchyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCesHierarchyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }

        public SyncInvoker<ShowClusterResponse> ShowClusterInvoker(ShowClusterRequest showClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showCoordinatorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCoordinatorsResponse>(response);
        }

        public SyncInvoker<ShowCoordinatorsResponse> ShowCoordinatorsInvoker(ShowCoordinatorsRequest showCoordinatorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCoordinatorsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/coordinators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCoordinatorsRequest);
            return new SyncInvoker<ShowCoordinatorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCoordinatorsResponse>);
        }
        
        /// <summary>
        /// 消息积压诊断预检查
        ///
        /// 消息积压诊断预检查
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiagnosisPreCheckResponse ShowDiagnosisPreCheck(ShowDiagnosisPreCheckRequest showDiagnosisPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiagnosisPreCheckRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/diagnosis-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisPreCheckRequest);
            var response = DoHttpRequestSync("GET", request);
            var showDiagnosisPreCheckResponse = JsonUtils.DeSerializeNull<ShowDiagnosisPreCheckResponse>(response);
            showDiagnosisPreCheckResponse.Body = JsonUtils.DeSerializeList<KafkaDiagnosisCheckEntity>(response);
            return showDiagnosisPreCheckResponse;
        }

        public SyncInvoker<ShowDiagnosisPreCheckResponse> ShowDiagnosisPreCheckInvoker(ShowDiagnosisPreCheckRequest showDiagnosisPreCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiagnosisPreCheckRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/diagnosis-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiagnosisPreCheckRequest);
            return new SyncInvoker<ShowDiagnosisPreCheckResponse>(this, "GET", request, response =>
            {
                var showDiagnosisPreCheckResponse = JsonUtils.DeSerializeNull<ShowDiagnosisPreCheckResponse>(response);
                showDiagnosisPreCheckResponse.Body = JsonUtils.DeSerializeList<KafkaDiagnosisCheckEntity>(response);
                return showDiagnosisPreCheckResponse;
            });
        }
        
        /// <summary>
        /// 查询指定消费组信息
        ///
        /// 查询指定消费组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupResponse ShowGroup(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
        }

        public SyncInvoker<ShowGroupResponse> ShowGroupInvoker(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            return new SyncInvoker<ShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showGroupsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsResponse>(response);
        }

        public SyncInvoker<ShowGroupsResponse> ShowGroupsInvoker(ShowGroupsRequest showGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupsRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigsResponse>(response);
        }

        public SyncInvoker<ShowInstanceConfigsResponse> ShowInstanceConfigsInvoker(ShowInstanceConfigsRequest showInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigsRequest);
            return new SyncInvoker<ShowInstanceConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigsResponse>);
        }
        
        /// <summary>
        /// 查询消息
        ///
        /// Kafka实例支持两种消息查询方式，具体查询范围及结果如下：
        /// - 按创建时间查询：若已知消息的创建时间段，可通过该方式查询，将返回消息列表及对应偏移量，但不包含消息具体内容。
        /// - 按偏移量查询：若已知目标消息所属Topic的分区及具体偏移量，可通过该方式查询，将返回消息列表及完整的消息内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceMessagesResponse ShowInstanceMessages(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceMessagesResponse>(response);
        }

        public SyncInvoker<ShowInstanceMessagesResponse> ShowInstanceMessagesInvoker(ShowInstanceMessagesRequest showInstanceMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopicDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopicDetailRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTopicDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTopicDetailResponse>(response);
        }

        public SyncInvoker<ShowInstanceTopicDetailResponse> ShowInstanceTopicDetailInvoker(ShowInstanceTopicDetailRequest showInstanceTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopicDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceTopicDetailRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
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
            if (StringUtils.TryConvertToNonEmptyString(showInstanceUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceUsersResponse>(response);
        }

        public SyncInvoker<ShowInstanceUsersResponse> ShowInstanceUsersInvoker(ShowInstanceUsersRequest showInstanceUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceUsersRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceUsersRequest);
            return new SyncInvoker<ShowInstanceUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceUsersResponse>);
        }
        
        /// <summary>
        /// 查询Kafka集群信息
        ///
        /// 查询Kafka集群信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaClusterResponse ShowKafkaCluster(ShowKafkaClusterRequest showKafkaClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaClusterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/manage/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaClusterResponse>(response);
        }

        public SyncInvoker<ShowKafkaClusterResponse> ShowKafkaClusterInvoker(ShowKafkaClusterRequest showKafkaClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaClusterRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/manage/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaClusterRequest);
            return new SyncInvoker<ShowKafkaClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaClusterResponse>);
        }
        
        /// <summary>
        /// 查询实例的扩容规格列表
        ///
        /// 查询实例的扩容规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaInstanceExtendProductInfoResponse ShowKafkaInstanceExtendProductInfo(ShowKafkaInstanceExtendProductInfoRequest showKafkaInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaInstanceExtendProductInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaInstanceExtendProductInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaInstanceExtendProductInfoResponse>(response);
        }

        public SyncInvoker<ShowKafkaInstanceExtendProductInfoResponse> ShowKafkaInstanceExtendProductInfoInvoker(ShowKafkaInstanceExtendProductInfoRequest showKafkaInstanceExtendProductInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaInstanceExtendProductInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaInstanceExtendProductInfoRequest);
            return new SyncInvoker<ShowKafkaInstanceExtendProductInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaInstanceExtendProductInfoResponse>);
        }
        
        /// <summary>
        /// 查询Kafka产品规格核数
        ///
        /// 查询Kafka产品规格核数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaProductCoresResponse ShowKafkaProductCores(ShowKafkaProductCoresRequest showKafkaProductCoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/products/cores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProductCoresRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaProductCoresResponse>(response);
        }

        public SyncInvoker<ShowKafkaProductCoresResponse> ShowKafkaProductCoresInvoker(ShowKafkaProductCoresRequest showKafkaProductCoresRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/products/cores", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaProductCoresRequest);
            return new SyncInvoker<ShowKafkaProductCoresResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaProductCoresResponse>);
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
        /// 查询Kafka实例重平衡日志详情
        ///
        /// 查询Kafka实例重平衡日志详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaRebalanceLogResponse ShowKafkaRebalanceLog(ShowKafkaRebalanceLogRequest showKafkaRebalanceLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaRebalanceLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaRebalanceLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaRebalanceLogResponse>(response);
        }

        public SyncInvoker<ShowKafkaRebalanceLogResponse> ShowKafkaRebalanceLogInvoker(ShowKafkaRebalanceLogRequest showKafkaRebalanceLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaRebalanceLogRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaRebalanceLogRequest);
            return new SyncInvoker<ShowKafkaRebalanceLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaRebalanceLogResponse>);
        }
        
        /// <summary>
        /// 获取Kafka实例扩容前置检查信息
        ///
        /// 获取Kafka实例扩容前置检查信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaScalePreCheckInfoResponse ShowKafkaScalePreCheckInfo(ShowKafkaScalePreCheckInfoRequest showKafkaScalePreCheckInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaScalePreCheckInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaScalePreCheckInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaScalePreCheckInfoResponse>(response);
        }

        public SyncInvoker<ShowKafkaScalePreCheckInfoResponse> ShowKafkaScalePreCheckInfoInvoker(ShowKafkaScalePreCheckInfoRequest showKafkaScalePreCheckInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaScalePreCheckInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/extend-check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaScalePreCheckInfoRequest);
            return new SyncInvoker<ShowKafkaScalePreCheckInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaScalePreCheckInfoResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTagsResponse>(response);
        }

        public SyncInvoker<ShowKafkaTagsResponse> ShowKafkaTagsInvoker(ShowKafkaTagsRequest showKafkaTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/{instance_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTagsRequest);
            return new SyncInvoker<ShowKafkaTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTagsResponse>);
        }
        
        /// <summary>
        /// 获取Kafka Topic详细信息
        ///
        /// 获取Kafka Topic详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaTopicDetailResponse ShowKafkaTopicDetail(ShowKafkaTopicDetailRequest showKafkaTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicDetailRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/topics-detail/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            var showKafkaTopicDetailResponse = JsonUtils.DeSerializeNull<ShowKafkaTopicDetailResponse>(response);
            showKafkaTopicDetailResponse.Body = JsonUtils.DeSerializeList<KafkaTopicDetailEntity>(response);
            return showKafkaTopicDetailResponse;
        }

        public SyncInvoker<ShowKafkaTopicDetailResponse> ShowKafkaTopicDetailInvoker(ShowKafkaTopicDetailRequest showKafkaTopicDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicDetailRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicDetailRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/topics-detail/{topic}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicDetailRequest);
            return new SyncInvoker<ShowKafkaTopicDetailResponse>(this, "GET", request, response =>
            {
                var showKafkaTopicDetailResponse = JsonUtils.DeSerializeNull<ShowKafkaTopicDetailResponse>(response);
                showKafkaTopicDetailResponse.Body = JsonUtils.DeSerializeList<KafkaTopicDetailEntity>(response);
                return showKafkaTopicDetailResponse;
            });
        }
        
        /// <summary>
        /// 查询Topic的磁盘存储情况
        ///
        /// 查询Topic在Broker上磁盘占用情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaTopicPartitionDiskusageResponse ShowKafkaTopicPartitionDiskusage(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicPartitionDiskusageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>(response);
        }

        public SyncInvoker<ShowKafkaTopicPartitionDiskusageResponse> ShowKafkaTopicPartitionDiskusageInvoker(ShowKafkaTopicPartitionDiskusageRequest showKafkaTopicPartitionDiskusageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicPartitionDiskusageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics/diskusage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicPartitionDiskusageRequest);
            return new SyncInvoker<ShowKafkaTopicPartitionDiskusageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTopicPartitionDiskusageResponse>);
        }
        
        /// <summary>
        /// 查询Topic流控配置
        ///
        /// 该接口用于查询Topic级别的流控任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKafkaTopicQuotaResponse ShowKafkaTopicQuota(ShowKafkaTopicQuotaRequest showKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaTopicQuotaResponse>(response);
        }

        public SyncInvoker<ShowKafkaTopicQuotaResponse> ShowKafkaTopicQuotaInvoker(ShowKafkaTopicQuotaRequest showKafkaTopicQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaTopicQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-topic-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaTopicQuotaRequest);
            return new SyncInvoker<ShowKafkaTopicQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKafkaTopicQuotaResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showKafkaUserClientQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKafkaUserClientQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKafkaUserClientQuotaResponse>(response);
        }

        public SyncInvoker<ShowKafkaUserClientQuotaResponse> ShowKafkaUserClientQuotaInvoker(ShowKafkaUserClientQuotaRequest showKafkaUserClientQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showKafkaUserClientQuotaRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
        /// 查询诊断报告详情
        ///
        /// 查询诊断报告详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMessageDiagnosisReportResponse ShowMessageDiagnosisReport(ShowMessageDiagnosisReportRequest showMessageDiagnosisReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMessageDiagnosisReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMessageDiagnosisReportRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessageDiagnosisReportRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMessageDiagnosisReportResponse>(response);
        }

        public SyncInvoker<ShowMessageDiagnosisReportResponse> ShowMessageDiagnosisReportInvoker(ShowMessageDiagnosisReportRequest showMessageDiagnosisReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMessageDiagnosisReportRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMessageDiagnosisReportRequest.ReportId, out var valueOfReportId)) urlParam.Add("report_id", valueOfReportId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/message-diagnosis/{report_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessageDiagnosisReportRequest);
            return new SyncInvoker<ShowMessageDiagnosisReportResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMessageDiagnosisReportResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMessagesRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/messages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMessagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMessagesResponse>(response);
        }

        public SyncInvoker<ShowMessagesResponse> ShowMessagesInvoker(ShowMessagesRequest showMessagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMessagesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showMessagesRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
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
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/beginning-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionBeginningMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionBeginningMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionBeginningMessageResponse> ShowPartitionBeginningMessageInvoker(ShowPartitionBeginningMessageRequest showPartitionBeginningMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionBeginningMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
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
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/end-message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionEndMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionEndMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionEndMessageResponse> ShowPartitionEndMessageInvoker(ShowPartitionEndMessageRequest showPartitionEndMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionEndMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
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
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPartitionMessageResponse>(response);
        }

        public SyncInvoker<ShowPartitionMessageResponse> ShowPartitionMessageInvoker(ShowPartitionMessageRequest showPartitionMessageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.Topic, out var valueOfTopic)) urlParam.Add("topic", valueOfTopic);
            if (StringUtils.TryConvertToNonEmptyString(showPartitionMessageRequest.Partition, out var valueOfPartition)) urlParam.Add("partition", valueOfPartition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/management/topics/{topic}/partitions/{partition}/message", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPartitionMessageRequest);
            return new SyncInvoker<ShowPartitionMessageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPartitionMessageResponse>);
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
        /// 查询回收站实例列表
        ///
        /// 查询回收站实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecycleInstancesResponse ShowRecycleInstances(ShowRecycleInstancesRequest showRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecycleInstancesResponse>(response);
        }

        public SyncInvoker<ShowRecycleInstancesResponse> ShowRecycleInstancesInvoker(ShowRecycleInstancesRequest showRecycleInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/recycle", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecycleInstancesRequest);
            return new SyncInvoker<ShowRecycleInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecycleInstancesResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showTopicAccessPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showTopicAccessPolicyRequest.TopicName, out var valueOfTopicName)) urlParam.Add("topic_name", valueOfTopicName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>(response);
        }

        public SyncInvoker<ShowTopicAccessPolicyResponse> ShowTopicAccessPolicyInvoker(ShowTopicAccessPolicyRequest showTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTopicAccessPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showTopicAccessPolicyRequest.TopicName, out var valueOfTopicName)) urlParam.Add("topic_name", valueOfTopicName);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/{topic_name}/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopicAccessPolicyRequest);
            return new SyncInvoker<ShowTopicAccessPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopicAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 查询Kafka实例版本信息
        ///
        /// 查询Kafka实例版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpgradeInstanceVersionResponse ShowUpgradeInstanceVersion(ShowUpgradeInstanceVersionRequest showUpgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeInstanceVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpgradeInstanceVersionResponse>(response);
        }

        public SyncInvoker<ShowUpgradeInstanceVersionResponse> ShowUpgradeInstanceVersionInvoker(ShowUpgradeInstanceVersionRequest showUpgradeInstanceVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUpgradeInstanceVersionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpgradeInstanceVersionRequest);
            return new SyncInvoker<ShowUpgradeInstanceVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpgradeInstanceVersionResponse>);
        }
        
        /// <summary>
        /// 查询磁盘自动扩容配置
        ///
        /// 查询磁盘自动扩容配置，包括磁盘自动扩容是否开启，以及开启后的扩容阈值、扩容步长、扩容上限信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVolumeExpandConfigResponse ShowVolumeExpandConfig(ShowVolumeExpandConfigRequest showVolumeExpandConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVolumeExpandConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-volume-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeExpandConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVolumeExpandConfigResponse>(response);
        }

        public SyncInvoker<ShowVolumeExpandConfigResponse> ShowVolumeExpandConfigInvoker(ShowVolumeExpandConfigRequest showVolumeExpandConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVolumeExpandConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-volume-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeExpandConfigRequest);
            return new SyncInvoker<ShowVolumeExpandConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVolumeExpandConfigResponse>);
        }
        
        /// <summary>
        /// 关闭Kafka实例重平衡日志功能
        ///
        /// 关闭Kafka实例重平衡日志功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopKafkaRebalanceLogTaskResponse StopKafkaRebalanceLogTask(StopKafkaRebalanceLogTaskRequest stopKafkaRebalanceLogTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopKafkaRebalanceLogTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopKafkaRebalanceLogTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<StopKafkaRebalanceLogTaskResponse>(response);
        }

        public SyncInvoker<StopKafkaRebalanceLogTaskResponse> StopKafkaRebalanceLogTaskInvoker(StopKafkaRebalanceLogTaskRequest stopKafkaRebalanceLogTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopKafkaRebalanceLogTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/log/rebalance-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopKafkaRebalanceLogTaskRequest);
            return new SyncInvoker<StopKafkaRebalanceLogTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<StopKafkaRebalanceLogTaskResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceResponse>(response);
        }

        public SyncInvoker<UpdateInstanceResponse> UpdateInstanceInvoker(UpdateInstanceRequest updateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRequest);
            return new SyncInvoker<UpdateInstanceResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceResponse>);
        }
        
        /// <summary>
        /// 开启或关闭实例自动创建Topic功能
        ///
        /// 开启或关闭实例自动创建Topic功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceAutoCreateTopicResponse UpdateInstanceAutoCreateTopic(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAutoCreateTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>(response);
        }

        public SyncInvoker<UpdateInstanceAutoCreateTopicResponse> UpdateInstanceAutoCreateTopicInvoker(UpdateInstanceAutoCreateTopicRequest updateInstanceAutoCreateTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceAutoCreateTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/autotopic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceAutoCreateTopicRequest);
            return new SyncInvoker<UpdateInstanceAutoCreateTopicResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateInstanceAutoCreateTopicResponse>);
        }
        
        /// <summary>
        /// 修改指定消费组
        ///
        /// 修改指定消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConsumerGroupResponse UpdateInstanceConsumerGroup(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups/{group}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConsumerGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceConsumerGroupResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConsumerGroupResponse> UpdateInstanceConsumerGroupInvoker(UpdateInstanceConsumerGroupRequest updateInstanceConsumerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConsumerGroupRequest.Group, out var valueOfGroup)) urlParam.Add("group", valueOfGroup);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceCrossVpcIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>(response);
        }

        public SyncInvoker<UpdateInstanceCrossVpcIpResponse> UpdateInstanceCrossVpcIpInvoker(UpdateInstanceCrossVpcIpRequest updateInstanceCrossVpcIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceCrossVpcIpRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/crossvpc/modify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceCrossVpcIpRequest);
            return new SyncInvoker<UpdateInstanceCrossVpcIpResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateInstanceCrossVpcIpResponse>);
        }
        
        /// <summary>
        /// 修改所有消费组
        ///
        /// 修改所有消费组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceGroupResponse UpdateInstanceGroup(UpdateInstanceGroupRequest updateInstanceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceGroupResponse>(response);
        }

        public SyncInvoker<UpdateInstanceGroupResponse> UpdateInstanceGroupInvoker(UpdateInstanceGroupRequest updateInstanceGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceGroupRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceGroupRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceGroupRequest);
            return new SyncInvoker<UpdateInstanceGroupResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceGroupResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceTopicRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceTopicResponse>(response);
        }

        public SyncInvoker<UpdateInstanceTopicResponse> UpdateInstanceTopicInvoker(UpdateInstanceTopicRequest updateInstanceTopicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceTopicRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>(response);
        }

        public SyncInvoker<UpdateInstanceUserResponse> UpdateInstanceUserInvoker(UpdateInstanceUserRequest updateInstanceUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceUserRequest.UserName, out var valueOfUserName)) urlParam.Add("user_name", valueOfUserName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{engine}/{project_id}/instances/{instance_id}/users/{user_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceUserRequest);
            return new SyncInvoker<UpdateInstanceUserResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceUserResponse>);
        }
        
        /// <summary>
        /// 修改Kafka的接入方式
        ///
        /// 修改Kafka的内网或者公网接入方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKafkaPortProtocolResponse UpdateKafkaPortProtocol(UpdateKafkaPortProtocolRequest updateKafkaPortProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaPortProtocolRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaPortProtocolRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{engine}/instances/{instance_id}/plain-ssl-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaPortProtocolRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateKafkaPortProtocolResponse>(response);
        }

        public SyncInvoker<UpdateKafkaPortProtocolResponse> UpdateKafkaPortProtocolInvoker(UpdateKafkaPortProtocolRequest updateKafkaPortProtocolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaPortProtocolRequest.Engine, out var valueOfEngine)) urlParam.Add("engine", valueOfEngine);
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaPortProtocolRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{engine}/instances/{instance_id}/plain-ssl-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaPortProtocolRequest);
            return new SyncInvoker<UpdateKafkaPortProtocolResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateKafkaPortProtocolResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>(response);
        }

        public SyncInvoker<UpdateKafkaUserClientQuotaTaskResponse> UpdateKafkaUserClientQuotaTaskInvoker(UpdateKafkaUserClientQuotaTaskRequest updateKafkaUserClientQuotaTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateKafkaUserClientQuotaTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/kafka/{project_id}/instances/{instance_id}/kafka-user-client-quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKafkaUserClientQuotaTaskRequest);
            return new SyncInvoker<UpdateKafkaUserClientQuotaTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateKafkaUserClientQuotaTaskResponse>);
        }
        
        /// <summary>
        /// 修改指定的定时任务
        ///
        /// 修改指定的定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateScheduledTaskResponse UpdateScheduledTask(UpdateScheduledTaskRequest updateScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateScheduledTaskResponse>(response);
        }

        public SyncInvoker<UpdateScheduledTaskResponse> UpdateScheduledTaskInvoker(UpdateScheduledTaskRequest updateScheduledTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateScheduledTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/scheduled-tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduledTaskRequest);
            return new SyncInvoker<UpdateScheduledTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateScheduledTaskResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAccessPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateTopicAccessPolicyResponse>(response);
        }

        public SyncInvoker<UpdateTopicAccessPolicyResponse> UpdateTopicAccessPolicyInvoker(UpdateTopicAccessPolicyRequest updateTopicAccessPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTopicAccessPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/instances/{instance_id}/topics/accesspolicy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTopicAccessPolicyRequest);
            return new SyncInvoker<UpdateTopicAccessPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateTopicAccessPolicyResponse>);
        }
        
        /// <summary>
        /// 修改磁盘自动扩容配置
        ///
        /// 该接口用于修改磁盘自动扩容配置，包含磁盘自动扩容是否开启、扩容阈值、扩容步长，以及扩容上限的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVolumeExpansionConfigResponse UpdateVolumeExpansionConfig(UpdateVolumeExpansionConfigRequest updateVolumeExpansionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVolumeExpansionConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-volume-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVolumeExpansionConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateVolumeExpansionConfigResponse>(response);
        }

        public SyncInvoker<UpdateVolumeExpansionConfigResponse> UpdateVolumeExpansionConfigInvoker(UpdateVolumeExpansionConfigRequest updateVolumeExpansionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVolumeExpansionConfigRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/auto-volume-expand", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVolumeExpansionConfigRequest);
            return new SyncInvoker<UpdateVolumeExpansionConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateVolumeExpansionConfigResponse>);
        }
        
        /// <summary>
        /// 实例升级
        ///
        /// 实例内核升级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpgradeInstanceResponse UpgradeInstance(UpgradeInstanceRequest upgradeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpgradeInstanceResponse>(response);
        }

        public SyncInvoker<UpgradeInstanceResponse> UpgradeInstanceInvoker(UpgradeInstanceRequest upgradeInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(upgradeInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", upgradeInstanceRequest);
            return new SyncInvoker<UpgradeInstanceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpgradeInstanceResponse>);
        }
        
        /// <summary>
        /// 开启Smart Connect（按需实例）
        ///
        /// 开启Smart Connect，提交创建Smart Connect节点任务。
        /// 
        /// [**当前通过调用API，只支持按需实例创建Smart Connect节点。**](tag:hws,hws_hk,g42,hk_g42,ctc,cmcc)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateConnectorResponse CreateConnector(CreateConnectorRequest createConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createConnectorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectorResponse>(response);
        }

        public SyncInvoker<CreateConnectorResponse> CreateConnectorInvoker(CreateConnectorRequest createConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createConnectorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(createConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectorTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectorTaskResponse>(response);
        }

        public SyncInvoker<CreateConnectorTaskResponse> CreateConnectorTaskInvoker(CreateConnectorTaskRequest createConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteConnectorResponse>(response);
        }

        public SyncInvoker<DeleteConnectorResponse> DeleteConnectorInvoker(DeleteConnectorRequest deleteConnectorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/delete-connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorRequest);
            return new SyncInvoker<DeleteConnectorResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteConnectorResponse>);
        }
        
        /// <summary>
        /// 删除Smart Connect任务
        ///
        /// 删除Smart Connect任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteConnectorTaskResponse DeleteConnectorTask(DeleteConnectorTaskRequest deleteConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectorTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteConnectorTaskResponse>(response);
        }

        public SyncInvoker<DeleteConnectorTaskResponse> DeleteConnectorTaskInvoker(DeleteConnectorTaskRequest deleteConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
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
            if (StringUtils.TryConvertToNonEmptyString(listConnectorTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectorTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListConnectorTasksResponse>(response);
        }

        public SyncInvoker<ListConnectorTasksResponse> ListConnectorTasksInvoker(ListConnectorTasksRequest listConnectorTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listConnectorTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectorTasksRequest);
            return new SyncInvoker<ListConnectorTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConnectorTasksResponse>);
        }
        
        /// <summary>
        /// 查询OBS桶列表
        ///
        /// 查询OBS桶列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListObsBucketsResponse ListObsBuckets(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/dms/obs/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listObsBucketsResponse = JsonUtils.DeSerializeNull<ListObsBucketsResponse>(response);
            listObsBucketsResponse.Body = JsonUtils.DeSerializeList<ObsBucketEntity>(response);
            return listObsBucketsResponse;
        }

        public SyncInvoker<ListObsBucketsResponse> ListObsBucketsInvoker(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/dms/obs/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            return new SyncInvoker<ListObsBucketsResponse>(this, "GET", request, response =>
            {
                var listObsBucketsResponse = JsonUtils.DeSerializeNull<ListObsBucketsResponse>(response);
                listObsBucketsResponse.Body = JsonUtils.DeSerializeList<ObsBucketEntity>(response);
                return listObsBucketsResponse;
            });
        }
        
        /// <summary>
        /// 修改Smart Connect任务配置
        ///
        /// 修改Smart Connect任务配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyConnectorTaskResponse ModifyConnectorTask(ModifyConnectorTaskRequest modifyConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifyConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyConnectorTaskResponse>(response);
        }

        public SyncInvoker<ModifyConnectorTaskResponse> ModifyConnectorTaskInvoker(ModifyConnectorTaskRequest modifyConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(modifyConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyConnectorTaskRequest);
            return new SyncInvoker<ModifyConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyConnectorTaskResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(pauseConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(pauseConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/pause", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", pauseConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<PauseConnectorTaskResponse>(response);
        }

        public SyncInvoker<PauseConnectorTaskResponse> PauseConnectorTaskInvoker(PauseConnectorTaskRequest pauseConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(pauseConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(pauseConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
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
            if (StringUtils.TryConvertToNonEmptyString(restartConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RestartConnectorTaskResponse>(response);
        }

        public SyncInvoker<RestartConnectorTaskResponse> RestartConnectorTaskInvoker(RestartConnectorTaskRequest restartConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/kafka/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartConnectorTaskRequest);
            return new SyncInvoker<RestartConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RestartConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 启动未启动的Smart Connect任务/重启Smart Connect任务
        ///
        /// 启动未启动的Smart Connect任务/重启Smart Connect任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestartSmartConnectorTaskResponse RestartSmartConnectorTask(RestartSmartConnectorTaskRequest restartSmartConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartSmartConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartSmartConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartSmartConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RestartSmartConnectorTaskResponse>(response);
        }

        public SyncInvoker<RestartSmartConnectorTaskResponse> RestartSmartConnectorTaskInvoker(RestartSmartConnectorTaskRequest restartSmartConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(restartSmartConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(restartSmartConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/restart", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restartSmartConnectorTaskRequest);
            return new SyncInvoker<RestartSmartConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RestartSmartConnectorTaskResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(resumeConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resumeConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/resume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeConnectorTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ResumeConnectorTaskResponse>(response);
        }

        public SyncInvoker<ResumeConnectorTaskResponse> ResumeConnectorTaskInvoker(ResumeConnectorTaskRequest resumeConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resumeConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(resumeConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}/resume", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resumeConnectorTaskRequest);
            return new SyncInvoker<ResumeConnectorTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ResumeConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 查询开启Smart Connect功能所需资源信息
        ///
        /// 查询开启Smart Connect功能所需要使用的资源的情况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConnectorResourceInfoResponse ShowConnectorResourceInfo(ShowConnectorResourceInfoRequest showConnectorResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConnectorResourceInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorResourceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConnectorResourceInfoResponse>(response);
        }

        public SyncInvoker<ShowConnectorResourceInfoResponse> ShowConnectorResourceInfoInvoker(ShowConnectorResourceInfoRequest showConnectorResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConnectorResourceInfoRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorResourceInfoRequest);
            return new SyncInvoker<ShowConnectorResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConnectorResourceInfoResponse>);
        }
        
        /// <summary>
        /// 查询Smart Connect任务详情
        ///
        /// 查询Smart Connect任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowConnectorTaskResponse ShowConnectorTask(ShowConnectorTaskRequest showConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowConnectorTaskResponse>(response);
        }

        public SyncInvoker<ShowConnectorTaskResponse> ShowConnectorTaskInvoker(ShowConnectorTaskRequest showConnectorTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showConnectorTaskRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showConnectorTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showConnectorTaskRequest);
            return new SyncInvoker<ShowConnectorTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowConnectorTaskResponse>);
        }
        
        /// <summary>
        /// 校验Connector连通性
        ///
        /// 校验Connector连通性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateConnectorConnectivityResponse ValidateConnectorConnectivity(ValidateConnectorConnectivityRequest validateConnectorConnectivityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateConnectorConnectivityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConnectorConnectivityRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ValidateConnectorConnectivityResponse>(response);
        }

        public SyncInvoker<ValidateConnectorConnectivityResponse> ValidateConnectorConnectivityInvoker(ValidateConnectorConnectivityRequest validateConnectorConnectivityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateConnectorConnectivityRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/connector/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateConnectorConnectivityRequest);
            return new SyncInvoker<ValidateConnectorConnectivityResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ValidateConnectorConnectivityResponse>);
        }
        
    }
}