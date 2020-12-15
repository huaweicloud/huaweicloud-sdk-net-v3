using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Dms.V2.Model;

namespace HuaweiCloud.SDK.Dms.V2
{
    public partial class DmsAsyncClient : Client
    {
        public static ClientBuilder<DmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DmsAsyncClient>();
        }

        
        /// <summary>
        /// 批量添加或删除队列标签
        /// </summary>
        public async Task<BatchCreateOrDeleteQueueTagResponse> BatchCreateOrDeleteQueueTagAsync(BatchCreateOrDeleteQueueTagRequest batchCreateOrDeleteQueueTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , batchCreateOrDeleteQueueTagRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateOrDeleteQueueTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteQueueTagResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费指定消息
        /// </summary>
        public async Task<ConfirmConsumptionMessagesResponse> ConfirmConsumptionMessagesAsync(ConfirmConsumptionMessagesRequest confirmConsumptionMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmConsumptionMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmConsumptionMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmConsumptionMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmConsumptionMessagesResponse>(response);
        }
        
        /// <summary>
        /// 确认已消费死信消息
        /// </summary>
        public async Task<ConfirmDeadLettersMessagesResponse> ConfirmDeadLettersMessagesAsync(ConfirmDeadLettersMessagesRequest confirmDeadLettersMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , confirmDeadLettersMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , confirmDeadLettersMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters/ack",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmDeadLettersMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ConfirmDeadLettersMessagesResponse>(response);
        }
        
        /// <summary>
        /// 消费死信消息
        /// </summary>
        public async Task<ConsumeDeadlettersMessageResponse> ConsumeDeadlettersMessageAsync(ConsumeDeadlettersMessageRequest consumeDeadlettersMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeDeadlettersMessageRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeDeadlettersMessageRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/deadletters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeDeadlettersMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ConsumeDeadlettersMessageResponse consumeDeadlettersMessageResponse = JsonUtils.DeSerializeNull<ConsumeDeadlettersMessageResponse>(response);
            consumeDeadlettersMessageResponse.Body = JsonUtils.DeSerializeList<ConsumeDeadlettersMessage>(response);
            return consumeDeadlettersMessageResponse;
        }
        
        /// <summary>
        /// 消费消息
        /// </summary>
        public async Task<ConsumeMessagesResponse> ConsumeMessagesAsync(ConsumeMessagesRequest consumeMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , consumeMessagesRequest.QueueId.ToString());
            urlParam.Add("consumer_group_id" , consumeMessagesRequest.ConsumerGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{consumer_group_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", consumeMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ConsumeMessagesResponse consumeMessagesResponse = JsonUtils.DeSerializeNull<ConsumeMessagesResponse>(response);
            consumeMessagesResponse.Body = JsonUtils.DeSerializeList<ConsumeMessage>(response);
            return consumeMessagesResponse;
        }
        
        /// <summary>
        /// 创建消费组
        /// </summary>
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest createConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , createConsumerGroupRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建队列
        /// </summary>
        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest createQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定队列
        /// </summary>
        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest deleteQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteQueueResponse>(response);
        }
        
        /// <summary>
        /// 删除指定消费组
        /// </summary>
        public async Task<DeleteSpecifiedConsumerGroupResponse> DeleteSpecifiedConsumerGroupAsync(DeleteSpecifiedConsumerGroupRequest deleteSpecifiedConsumerGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , deleteSpecifiedConsumerGroupRequest.QueueId.ToString());
            urlParam.Add("group_id" , deleteSpecifiedConsumerGroupRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups/{group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSpecifiedConsumerGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSpecifiedConsumerGroupResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列的所有消费组
        /// </summary>
        public async Task<ListConsumerGroupsResponse> ListConsumerGroupsAsync(ListConsumerGroupsRequest listConsumerGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , listConsumerGroupsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConsumerGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListConsumerGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查看所有队列
        /// </summary>
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest listQueuesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueuesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQueuesResponse>(response);
        }
        
        /// <summary>
        /// 向指定队列发送消息
        /// </summary>
        public async Task<SendMessagesResponse> SendMessagesAsync(SendMessagesRequest sendMessagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , sendMessagesRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}/messages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendMessagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<SendMessagesResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        /// </summary>
        public async Task<ShowProjectTagsResponse> ShowProjectTagsAsync(ShowProjectTagsRequest showProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查看指定队列
        /// </summary>
        public async Task<ShowQueueResponse> ShowQueueAsync(ShowQueueRequest showQueueRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queues/{queue_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueResponse>(response);
        }
        
        /// <summary>
        /// 查询队列标签
        /// </summary>
        public async Task<ShowQueueTagsResponse> ShowQueueTagsAsync(ShowQueueTagsRequest showQueueTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("queue_id" , showQueueTagsRequest.QueueId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/queue/{queue_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQueueTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQueueTagsResponse>(response);
        }
        
        /// <summary>
        /// 查看租户配额
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }
        
    }
}