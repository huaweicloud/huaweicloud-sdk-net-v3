using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dms.V2.Model;

namespace HuaweiCloud.SDK.Dms.V2
{
    public partial class DmsClient : Client
    {
        public static ClientBuilder<DmsClient> NewBuilder()
        {
            return new ClientBuilder<DmsClient>();
        }

        
        /// <summary>
        /// 批量添加或删除队列标签
        /// </summary>
        public BatchCreateOrDeleteQueueTagResponse BatchCreateOrDeleteQueueTag(BatchCreateOrDeleteQueueTagRequest batchCreateOrDeleteQueueTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , batchCreateOrDeleteQueueTagRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteQueueTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteQueueTagResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费指定消息
        /// </summary>
        public ConfirmConsumptionMessagesResponse ConfirmConsumptionMessages(ConfirmConsumptionMessagesRequest confirmConsumptionMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmConsumptionMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmConsumptionMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmConsumptionMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ConfirmConsumptionMessagesResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费死信消息
        /// </summary>
        public ConfirmDeadLettersMessagesResponse ConfirmDeadLettersMessages(ConfirmDeadLettersMessagesRequest confirmDeadLettersMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmDeadLettersMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmDeadLettersMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmDeadLettersMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ConfirmDeadLettersMessagesResponse>(response);
        }
        
        /// <summary>
        /// 消费死信消息
        /// </summary>
        public ConsumeDeadlettersMessageResponse ConsumeDeadlettersMessage(ConsumeDeadlettersMessageRequest consumeDeadlettersMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeDeadlettersMessageRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeDeadlettersMessageRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeDeadlettersMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ConsumeDeadlettersMessageResponse consumeDeadlettersMessageResponse = JsonUtils.DeSerializeNull<ConsumeDeadlettersMessageResponse>(response);
            consumeDeadlettersMessageResponse.Body = JsonUtils.DeSerializeList<ConsumeDeadlettersMessage>(response);
            return consumeDeadlettersMessageResponse;
        }
        
        /// <summary>
        /// 消费消息
        /// </summary>
        public ConsumeMessagesResponse ConsumeMessages(ConsumeMessagesRequest consumeMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ConsumeMessagesResponse consumeMessagesResponse = JsonUtils.DeSerializeNull<ConsumeMessagesResponse>(response);
            consumeMessagesResponse.Body = JsonUtils.DeSerializeList<ConsumeMessage>(response);
            return consumeMessagesResponse;
        }
        
        /// <summary>
        /// 创建消费组
        /// </summary>
        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest createConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , createConsumerGroupRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建队列
        /// </summary>
        public CreateQueueResponse CreateQueue(CreateQueueRequest createQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定队列
        /// </summary>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest deleteQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定消费组
        /// </summary>
        public DeleteSpecifiedConsumerGroupResponse DeleteSpecifiedConsumerGroup(DeleteSpecifiedConsumerGroupRequest deleteSpecifiedConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteSpecifiedConsumerGroupRequest.QueueId.ToString());
            urlParam.Add("group_id" , deleteSpecifiedConsumerGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpecifiedConsumerGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSpecifiedConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列的所有消费组
        /// </summary>
        public ListConsumerGroupsResponse ListConsumerGroups(ListConsumerGroupsRequest listConsumerGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , listConsumerGroupsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListConsumerGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查看所有队列
        /// </summary>
        public ListQueuesResponse ListQueues(ListQueuesRequest listQueuesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueuesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQueuesResponse>(response);
        }
        
        /// <summary>
        /// 向指定队列发送消息
        /// </summary>
        public SendMessagesResponse SendMessages(SendMessagesRequest sendMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , sendMessagesRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendMessagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<SendMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        /// </summary>
        public ShowProjectTagsResponse ShowProjectTags(ShowProjectTagsRequest showProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列
        /// </summary>
        public ShowQueueResponse ShowQueue(ShowQueueRequest showQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }
        
        /// <summary>
        /// 查询队列标签
        /// </summary>
        public ShowQueueTagsResponse ShowQueueTags(ShowQueueTagsRequest showQueueTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueTagsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueTagsResponse>(response);
        }
        
        /// <summary>
        /// 查看租户配额
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
    }
}